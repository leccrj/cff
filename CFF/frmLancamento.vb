Public Class frmLancamento

    Private m_empty As String = String.Empty
    Private m_cod_lancamento As Long
    Private m_ok As Boolean
    Private m_cod_titulo As Long = 0

    Public Property titulo As Long
        Get
            Return m_cod_titulo
        End Get
        Set(value As Long)
            m_cod_titulo = value
        End Set
    End Property

    Public Property ok As Boolean
        Get
            Return m_ok
        End Get
        Set(value As Boolean)
            'm_ok = value
        End Set
    End Property

    Public Property codigo As Long
        Get
            Return m_cod_lancamento
        End Get
        Set(value As Long)
            m_cod_lancamento = value
        End Set
    End Property

    Private Sub frmLancamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()

        If m_cod_lancamento > 0 Then

            sb_Preenche_Tela()

        Else

            sb_Limpa_Tela()

            If m_cod_titulo > 0 Then

                txtNumero.Text = m_cod_titulo

                sb_Pesquisar()

            End If
        End If

    End Sub

    Private Sub cmdSair_Click(sender As Object, e As EventArgs) Handles cmdSair.Click

        m_ok = False

        Me.Close()

    End Sub

    Private Sub sb_Preenche_Tela()

        Try

            Using ctx = New FINANCEIROEntities

                Dim vLancamento = (From baixa In ctx.TB_LANCAMENTO
                                   Join titulo In ctx.TB_TITULO On titulo.COD_TITULO Equals baixa.COD_TITULO
                                   Join conta In ctx.TB_CONTA On conta.COD_CONTA Equals titulo.COD_CONTA
                                   Where baixa.COD_LANCAMENTO = m_cod_lancamento
                                   Select baixa.COD_LANCAMENTO _
                                       , titulo.COD_TITULO _
                                       , titulo.DESCRICAO _
                                       , DESC_CONTA = conta.DESCRICAO _
                                       , VAL_TITULO = titulo.VALOR _
                                       , titulo.DAT_VENCIMENTO _
                                       , baixa.DATA _
                                       , baixa.VALOR _
                                       , titulo.COD_CONTA _
                                       , baixa.OBSERVACAO).SingleOrDefault

                txtNumero.Text = vLancamento.COD_TITULO

                txtDescricao.Text = vLancamento.DESCRICAO

                txtConta.Text = vLancamento.DESC_CONTA

                txtValor.Text = FormatNumber(vLancamento.VAL_TITULO, 2)

                txtVencimento.Text = vLancamento.DAT_VENCIMENTO

                dtpData.Text = vLancamento.DATA.ToShortDateString

                txtValorLancamento.Text = FormatNumber(vLancamento.VALOR, 2)

                txtObservacao.Text = vLancamento.OBSERVACAO

            End Using

        Catch ex As Exception

            MessageBox.Show("Erro ao preencher tela.", "Erro::sb_Preenche_Tela", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub sb_Limpa_Tela()

        txtNumero.Text = m_empty

        txtDescricao.Text = m_empty

        txtConta.Text = m_empty

        txtValor.Text = m_empty

        txtVencimento.Text = m_empty

        dtpData.Text = FormatDateTime(Now, DateFormat.ShortDate)

        txtValorLancamento.Text = m_empty

        txtObservacao.Text = m_empty

    End Sub

    Private Sub sb_Gravar()

        If Not fn_Valida() Then
            Exit Sub
        End If

        If m_cod_lancamento > 0 Then

            sb_Alterar()

        Else

            sb_Incluir()

        End If

        Me.Close()

    End Sub

    Private Function fn_Valida() As Boolean

        If txtNumero.Text = m_empty Or txtDescricao.Text = m_empty Or txtConta.Text = m_empty Or txtValor.Text = m_empty Or txtVencimento.Text = m_empty Then
            MessageBox.Show("Necessário pesquisar um título.", "Gravar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If Not IsDate(dtpData.Text) Then
            MessageBox.Show("O campo data é obrigatório.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If txtValorLancamento.Text = m_empty Then
            MessageBox.Show("O campo valor é obrigatório.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        Return True

    End Function

    Private Sub sb_Excluir()

        Try

            Using ctx = New FINANCEIROEntities

                Dim vLancamento = (From lancamento In ctx.TB_LANCAMENTO Where lancamento.COD_LANCAMENTO = m_cod_lancamento).SingleOrDefault

                ctx.TB_LANCAMENTO.Remove(vLancamento)

                ctx.SaveChanges()

            End Using

            m_ok = True

            MessageBox.Show("Pagamento excluído com sucesso.", "CFF", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            m_ok = False

            MessageBox.Show("Erro ao excluir pagamento.", "Erro::sb_Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub sb_Alterar()

        Try

            Using ctx = New FINANCEIROEntities

                Dim vLancamento = (From lancamento In ctx.TB_LANCAMENTO Where lancamento.COD_LANCAMENTO = m_cod_lancamento).SingleOrDefault

                vLancamento.COD_TITULO = txtNumero.Text
                vLancamento.DATA = dtpData.Text
                vLancamento.VALOR = txtValorLancamento.Text
                vLancamento.OBSERVACAO = txtObservacao.Text.Trim

                ctx.SaveChanges()

                m_ok = True

            End Using

        Catch ex As Exception

            m_ok = False

            MessageBox.Show("Erro ao alterar baixa.", "Erro::sb_Alterar", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub sb_Incluir()

        Dim v_msg_resposta As Integer

        'título resíduo
        If CDbl(txtValorLancamento.Text) < CDbl(txtValor.Text) Then

            v_msg_resposta = MessageBox.Show("Deseja criar título com valor residual?", "CFF", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

            If v_msg_resposta = DialogResult.Cancel Then
                Exit Sub
            End If

        End If

        Try

            Using ctx = New FINANCEIROEntities

                Dim vLancamento As New TB_LANCAMENTO

                vLancamento.COD_TITULO = txtNumero.Text
                vLancamento.DATA = dtpData.Text
                vLancamento.VALOR = txtValorLancamento.Text
                vLancamento.OBSERVACAO = txtObservacao.Text.Trim

                ctx.TB_LANCAMENTO.Add(vLancamento)

                'título resíduo
                If v_msg_resposta = DialogResult.Yes Then

                    Dim vTitulo As New TB_TITULO

                    vTitulo.COD_TITULO_ORIGEM = vLancamento.COD_TITULO
                    vTitulo.COD_CONTA = txtConta.Tag
                    vTitulo.DESCRICAO = txtDescricao.Text
                    vTitulo.DAT_CADASTRO = Now.ToShortDateString
                    vTitulo.DAT_VENCIMENTO = dtpData.Value.AddMonths(1)
                    vTitulo.VALOR = CDbl(txtValor.Text) - CDbl(txtValorLancamento.Text)

                    ctx.TB_TITULO.Add(vTitulo)

                End If

                ctx.SaveChanges()

                m_ok = True

            End Using

        Catch ex As Exception

            m_ok = False

            MessageBox.Show("Erro ao efetuar baixa.", "Erro::sb_Incluir", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click

        sb_Gravar()

        If chkPrevisao.Checked Then sb_AtualizaPrevisao()

    End Sub

    Private Sub sb_Pesquisar()

        Dim v_cod_titulo As Double

        Try

            If Not IsNumeric(txtNumero.Text) Then
                Exit Sub
            End If

            v_cod_titulo = txtNumero.Text

            sb_Limpa_Tela()

            Using ctx = New FINANCEIROEntities

                Dim vTitulo = (From titulo In ctx.TB_TITULO
                               Join conta In ctx.TB_CONTA On conta.COD_CONTA Equals titulo.COD_CONTA
                               Where titulo.COD_TITULO = v_cod_titulo
                               Select titulo.DESCRICAO _
                                   , DESC_CONTA = conta.DESCRICAO _
                                   , titulo.VALOR _
                                   , titulo.DAT_VENCIMENTO _
                                   , titulo.COD_CONTA).SingleOrDefault

                If IsNothing(vTitulo) Then
                    sb_Habilita_Campos(False)
                    MessageBox.Show("Nenhum título encontrado.", "Pesquisar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                sb_Habilita_Campos(True)

                txtNumero.Text = v_cod_titulo

                txtDescricao.Text = vTitulo.DESCRICAO

                txtConta.Text = vTitulo.DESC_CONTA

                txtConta.Tag = vTitulo.COD_CONTA

                txtValor.Text = FormatNumber(vTitulo.VALOR, 2)

                txtVencimento.Text = vTitulo.DAT_VENCIMENTO

                dtpData.Text = vTitulo.DAT_VENCIMENTO.ToShortDateString

                txtValorLancamento.Text = FormatNumber(vTitulo.VALOR, 2)

            End Using

        Catch ex As Exception

            MessageBox.Show("Erro ao realizar pesquisa.", "Erro::sb_Pesquisar", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click

        sb_Pesquisar()

    End Sub

    Private Sub sb_Habilita_Campos(ByVal pEnable As Boolean)
        dtpData.Enabled = pEnable
        txtValorLancamento.ReadOnly = Not pEnable
        txtObservacao.ReadOnly = Not pEnable
    End Sub

    Private Sub cmdExcluir_Click(sender As Object, e As EventArgs) Handles cmdExcluir.Click

        If (MessageBox.Show("Deseja excluir o pagamento?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No) Then

            Exit Sub

        End If

        sb_Excluir()

        Me.Close()

    End Sub

    Private Sub sb_AtualizaPrevisao()

        Dim vcod_conta As Integer = txtConta.Tag

        Try

            Using ctx = New FINANCEIROEntities

                'titulos 
                Dim vListaTitulo = (From titulo In ctx.TB_TITULO
                                    Where titulo.COD_CONTA = vcod_conta And titulo.DAT_VENCIMENTO > txtVencimento.Text
                                    Select titulo).ToList

                For Each vTitulo In vListaTitulo

                    vTitulo.VALOR = txtValorLancamento.Text

                Next

                ctx.SaveChanges()

                m_ok = True

            End Using

        Catch ex As Exception

            m_ok = False

            MessageBox.Show("Erro ao alterar previsão.", "Erro::sb_AtualizaPrevisao", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

End Class