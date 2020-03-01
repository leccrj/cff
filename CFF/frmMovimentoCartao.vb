Public Class frmMovimentoCartao

    Private m_empty As String = String.Empty
    Private m_seq_movimento As Double
    Private m_ok As Boolean
    Private m_cod_titulo As Double
    Private m_cod_cartao As Double = 0

    Public Property codigo
        Get
            Return m_seq_movimento
        End Get
        Set(value)
            m_seq_movimento = value
        End Set
    End Property

    Public Property ok
        Get
            Return m_ok
        End Get
        Set(value)
            'm_ok = value 
        End Set
    End Property

    Public Property cod_titulo
        Get
            Return m_cod_titulo
        End Get
        Set(value)
            m_cod_titulo = value
        End Set
    End Property

    Public Property cartao
        Get
            Return m_cod_cartao
        End Get
        Set(value)
            m_cod_cartao = value
        End Set
    End Property

    Private Sub sb_Limpa_Tela()

        cmbCartao.SelectedIndex = -1
        cmbConta.SelectedIndex = -1
        cmbSubConta.DataSource = Nothing
        txtDescricao.Text = m_empty
        rdoParcelar.Checked = True
        txtQtdParcela.Text = m_empty
        dtpData.Text = FormatDateTime(Now, DateFormat.ShortDate)
        txtNumeroTitulo.Text = m_empty
        txtValor.Text = m_empty
        txtObservacao.Text = m_empty
        txtTituloDespesa.Text = m_empty
        txtParcela.Text = m_empty

    End Sub

    Private Sub sb_Preenche_Tela()

        Try

            Using ctx = New FINANCEIROEntities

                Dim vMovimento = (From mov In ctx.TB_MOVIMENTO_CARTAO
                                  Join cartao In ctx.TB_CARTAO On cartao.COD_CARTAO Equals mov.COD_CARTAO
                                  Join conta In ctx.TB_CONTA On conta.COD_CONTA Equals mov.COD_CONTA
                                  Join tit In ctx.TB_TITULO On tit.COD_TITULO Equals mov.COD_TITULO
                                  Where mov.SEQ_MOVIMENTO = m_seq_movimento
                                  Select mov.SEQ_MOVIMENTO, cartao.COD_CARTAO, tit.COD_TITULO, mov.DESCRICAO, mov.DAT_MOVIMENTO, mov.VALOR, mov.NUM_PARCELA, conta.COD_CONTA_RAIZ, conta.COD_CONTA, mov.OBSERVACAO).SingleOrDefault


                If vMovimento.COD_CONTA_RAIZ IsNot Nothing Then

                    cmbConta.SelectedValue = vMovimento.COD_CONTA_RAIZ

                    sb_Preenche_SubConta(vMovimento.COD_CONTA_RAIZ)

                    cmbSubConta.SelectedValue = vMovimento.COD_CONTA

                Else

                    cmbConta.SelectedValue = vMovimento.COD_CONTA

                End If

                If vMovimento.NUM_PARCELA.GetValueOrDefault = 0 Then
                    txtParcela.Text = m_empty
                Else
                    txtParcela.Text = vMovimento.NUM_PARCELA
                End If

                cmbCartao.SelectedValue = vMovimento.COD_CARTAO
                txtDescricao.Text = vMovimento.DESCRICAO
                dtpData.Text = vMovimento.DAT_MOVIMENTO.ToShortDateString
                txtNumeroTitulo.Text = vMovimento.COD_TITULO
                txtValor.Text = FormatNumber(vMovimento.VALOR, 2)
                txtObservacao.Text = vMovimento.OBSERVACAO
                txtCodigo.Text = vMovimento.SEQ_MOVIMENTO

            End Using

        Catch ex As Exception

            MessageBox.Show("Erro ao preencher tela.", "Erro::sb_Preenche_Tela", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub frmMovimentoCartao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToParent()

        sb_Preenche_Cartao()

        sb_Preenche_Conta()

        If m_seq_movimento > 0 Then

            sb_Preenche_Tela()

        Else

            sb_Limpa_Tela()

            If m_cod_cartao > 0 Then

                sb_SetCartao()

                sb_SetVencimento()

            End If

            txtNumeroTitulo.Text = IIf(m_cod_titulo = 0, "", m_cod_titulo)

        End If

    End Sub

    Private Sub sb_Gravar()

        If Not fn_Valida() Then
            Exit Sub
        End If

        If m_seq_movimento > 0 Then

            sb_Alterar()

        Else

            sb_Incluir()

        End If

        Me.Close()

    End Sub

    Private Sub sb_Incluir()

        Dim vQtdParcela As Integer = 1
        Dim vValorParcela As Decimal

        Try

            vQtdParcela = IIf(Not IsNumeric(txtQtdParcela.Text), 1, txtQtdParcela.Text)

            If rdoParcelar.Checked And vQtdParcela > 1 Then

                vValorParcela = Convert.ToDecimal(txtValor.Text) / vQtdParcela

            Else

                vValorParcela = Convert.ToDecimal(txtValor.Text)

            End If

            Using ctx = New FINANCEIROEntities

                Dim vMovimento As New TB_MOVIMENTO_CARTAO

                vMovimento.COD_CARTAO = cmbCartao.SelectedValue

                If cmbSubConta.Items.Count = 0 Then
                    vMovimento.COD_CONTA = cmbConta.SelectedValue
                Else
                    vMovimento.COD_CONTA = cmbSubConta.SelectedValue
                End If

                vMovimento.DESCRICAO = txtDescricao.Text.Trim

                If IsNumeric(txtParcela.Text) Then
                    vMovimento.NUM_PARCELA = txtParcela.Text
                End If

                vMovimento.VALOR = vValorParcela

                vMovimento.DAT_MOVIMENTO = dtpData.Text

                vMovimento.COD_TITULO = txtNumeroTitulo.Text

                vMovimento.OBSERVACAO = txtObservacao.Text

                vMovimento.DAT_CADASTRO = Now.ToShortDateString

                If IsNumeric(txtTituloDespesa.Text) Then
                    vMovimento.COD_TITULO_DESPESA = txtTituloDespesa.Text
                End If

                ctx.TB_MOVIMENTO_CARTAO.Add(vMovimento)

                ctx.SaveChanges()

            End Using

            If Not fn_Atualiza_Titulo(txtNumeroTitulo.Text, vValorParcela) Then
                MessageBox.Show("Erro ao atualizar valor título.", "Erro::sb_Incluir", MessageBoxButtons.OK, MessageBoxIcon.Error)
                m_ok = False
                Exit Sub
            End If

            m_ok = True

        Catch ex As Exception

            m_ok = False

            MessageBox.Show("Erro ao gravar movimento.", "Erro::sb_Incluir", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Function fn_Atualiza_Titulo(ByVal p_cod_titulo As Long, ByVal p_valor As Decimal) As Boolean

        Try

            Using ctx = New FINANCEIROEntities

                Dim vTitulo = (From tit In ctx.TB_TITULO Where tit.COD_TITULO = p_cod_titulo).SingleOrDefault

                Dim vMovimento = (From mov In ctx.TB_MOVIMENTO_CARTAO Where mov.COD_TITULO = p_cod_titulo Select mov.VALOR).ToList.Sum

                vTitulo.VALOR = vMovimento

                ctx.SaveChanges()

            End Using

            Return True

        Catch ex As Exception

            Return False

        End Try

    End Function

    Private Sub sb_Alterar()

        Try

            Using ctx = New FINANCEIROEntities

                Dim vMovimento = (From mov In ctx.TB_MOVIMENTO_CARTAO Where mov.SEQ_MOVIMENTO = m_seq_movimento).SingleOrDefault

                vMovimento.COD_CARTAO = cmbCartao.SelectedValue

                If cmbSubConta.Items.Count = 0 Then
                    vMovimento.COD_CONTA = cmbConta.SelectedValue
                Else
                    vMovimento.COD_CONTA = cmbSubConta.SelectedValue
                End If

                vMovimento.DESCRICAO = txtDescricao.Text.Trim
                vMovimento.DAT_MOVIMENTO = dtpData.Text
                vMovimento.COD_TITULO = txtNumeroTitulo.Text
                vMovimento.VALOR = txtValor.Text
                vMovimento.OBSERVACAO = txtObservacao.Text.Trim
                vMovimento.DAT_CADASTRO = Now.ToShortDateString

                If IsNumeric(txtParcela.Text) Then
                    vMovimento.NUM_PARCELA = txtParcela.Text
                Else
                    vMovimento.NUM_PARCELA = vbEmpty
                End If

                If IsNumeric(txtTituloDespesa.Text) Then
                    vMovimento.COD_TITULO_DESPESA = txtTituloDespesa.Text
                End If

                ctx.SaveChanges()

            End Using

            If Not fn_Atualiza_Titulo(txtNumeroTitulo.Text, txtValor.Text) Then
                MessageBox.Show("Erro ao atualizar valor título.", "Erro::sb_Incluir", MessageBoxButtons.OK, MessageBoxIcon.Error)
                m_ok = False
                Exit Sub
            End If

            m_ok = True

        Catch ex As Exception

            m_ok = False

            MessageBox.Show("Erro ao gravar movimento.", "Erro::sb_Alterar", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub sb_Preenche_Conta()

        Try

            Using ctx = New FINANCEIROEntities

                cmbConta.DataSource = (From conta In ctx.TB_CONTA Where conta.TIPO = "D" And Not conta.COD_CONTA_RAIZ.HasValue).ToList

                cmbConta.DisplayMember = "DESCRICAO"

                cmbConta.ValueMember = "COD_CONTA"

            End Using

        Catch ex As Exception

            MessageBox.Show("Erro " + ex.Message, "Erro::sb_Preenche_Conta", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub sb_Preenche_SubConta(ByVal p_cod_conta As Integer)

        Try

            Using ctx = New FINANCEIROEntities

                Dim vConta = (From conta In ctx.TB_CONTA Where conta.COD_CONTA_RAIZ = p_cod_conta).ToList

                cmbSubConta.DataSource = vConta 'ctx.TB_CONTA.ToList

                cmbSubConta.DisplayMember = "DESCRICAO"

                cmbSubConta.ValueMember = "COD_CONTA"

            End Using

        Catch ex As Exception

            MessageBox.Show("Erro " + ex.Message, "Erro::sb_Preenche_SubConta", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub sb_Preenche_Cartao()

        Try

            Using ctx = New FINANCEIROEntities

                cmbCartao.DataSource = ctx.TB_CARTAO.ToList

                cmbCartao.DisplayMember = "DESCRICAO"

                cmbCartao.ValueMember = "COD_CARTAO"

            End Using

        Catch ex As Exception

            MessageBox.Show("Erro " + ex.Message, "Erro::sb_Preenche_Cartao", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub sb_SetCartao()

        Try

            Using ctx = New FINANCEIROEntities

                Dim vCartao = (From c In ctx.TB_CARTAO Where c.COD_CARTAO = m_cod_cartao).FirstOrDefault

                cmbCartao.SelectedValue = vCartao.COD_CARTAO

            End Using

        Catch ex As Exception

            MessageBox.Show("Erro " + ex.Message, "Erro::sb_SetCartao", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub sb_SetVencimento()

        Try

            Using ctx = New FINANCEIROEntities

                Dim vVencimento = (From v In ctx.TB_TITULO Where v.COD_TITULO = m_cod_titulo).FirstOrDefault

                dtpData.Text = vVencimento.DAT_VENCIMENTO

            End Using

        Catch ex As Exception

            MessageBox.Show("Erro " + ex.Message, "Erro::sb_SetVencimento", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click

        sb_Gravar()

    End Sub

    Private Sub cmdSair_Click(sender As Object, e As EventArgs) Handles cmdSair.Click

        m_ok = False

        Me.Close()

    End Sub

    Private Function fn_Valida() As Boolean

        If cmbCartao.SelectedIndex = -1 Then
            MessageBox.Show("O campo cartão é obrigatório.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If cmbConta.SelectedIndex = -1 Then
            MessageBox.Show("O campo conta é obrigatório.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If


        If txtDescricao.Text = m_empty Then
            MessageBox.Show("O campo descrição é obrigatório.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If dtpData.Text = m_empty Then
            MessageBox.Show("O campo data é obrigatório.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If txtNumeroTitulo.Text = m_empty Then
            MessageBox.Show("O campo título é obrigatório.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If txtValor.Text = m_empty Then
            MessageBox.Show("O campo valor é obrigatório.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        Return True

    End Function

    Private Sub cmbConta_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbConta.SelectionChangeCommitted
        sb_Preenche_SubConta(cmbConta.SelectedValue)
    End Sub

    Private Sub rdoParcelar_CheckedChanged(sender As Object, e As EventArgs) Handles rdoParcelar.CheckedChanged
        lblQtdParcela.Text = "parcela(s)"
    End Sub

    Private Sub rdoReplicar_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCopiar.CheckedChanged
        lblQtdParcela.Text = "cópia(s)"
    End Sub
End Class