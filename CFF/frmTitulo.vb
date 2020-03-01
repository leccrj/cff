Public Class frmTitulo

    Private m_empty As String = String.Empty
    Private m_cod_titulo As Double
    Private m_ok As Boolean
    Private m_cod_cartao As Integer
    Private m_item_cartao As Boolean = False
    Private m_data_vencimento As Date = Now.ToShortDateString

    Public Property Vencimento
        Get
            Return m_data_vencimento
        End Get
        Set(value)
            m_data_vencimento = value
        End Set
    End Property

    Public Property Ok
        Get
            Return m_ok
        End Get
        Set(value)
            'm_ok = value 
        End Set
    End Property

    Public Property Codigo
        Get
            Return m_cod_titulo
        End Get
        Set(value)
            m_cod_titulo = value
        End Set
    End Property

    Public Property Cartao
        Get
            Return m_cod_cartao
        End Get
        Set(value)
            m_cod_cartao = value
        End Set
    End Property

    Public Property Item_Cartao
        Get
            Return m_item_cartao
        End Get
        Set(value)
            m_item_cartao = value
        End Set
    End Property


    Private Sub Sb_Limpa_Tela()

        txtCodigo.Text = m_empty

        cmbConta.SelectedIndex = -1

        cmbContaTituloFuturo.SelectedIndex = -1

        cmbSubConta.DataSource = Nothing

        cmbSubContaTituloFuturo.DataSource = Nothing

        txtDescricao.Text = m_empty

        dtpVencimento.Text = FormatDateTime(m_data_vencimento, DateFormat.ShortDate)

        mskValor.Text = m_empty

        txtParcela.Text = m_empty

        txtObservacao.Text = m_empty

        rdoParcelar.Checked = True

        txtQtdParcela.Text = m_empty

        chkGerarDebito.Checked = False

        chkBaixarTitulo.Enabled = True

        chkBaixarTitulo.Checked = True
        chkBaixarTitulo.CheckState = CheckState.Checked

        lblTipoConta.Visible = False

        cmd_itemcartao.Visible = False
        cmd_itemcartao.Enabled = False

    End Sub

    Private Sub sb_Preenche_Tela()

        Try

            Using ctx = New FINANCEIROEntities

                Dim vTitulo = (From titulo In ctx.TB_TITULO
                               Join conta In ctx.TB_CONTA On conta.COD_CONTA Equals titulo.COD_CONTA
                               Where titulo.COD_TITULO = m_cod_titulo
                               Select titulo.COD_TITULO _
                                   , conta.COD_CONTA _
                                   , conta.COD_CONTA_RAIZ _
                                   , titulo.DAT_VENCIMENTO _
                                   , titulo.DAT_PLANEJAMENTO _
                                   , titulo.DESCRICAO _
                                   , titulo.VALOR _
                                   , titulo.NUM_PARCELA _
                                   , titulo.OBSERVACAO).SingleOrDefault


                txtCodigo.Text = vTitulo.COD_TITULO

                If vTitulo.COD_CONTA_RAIZ IsNot Nothing Then

                    cmbConta.SelectedValue = vTitulo.COD_CONTA_RAIZ

                    sb_Preenche_SubConta(vTitulo.COD_CONTA_RAIZ)

                    cmbSubConta.SelectedValue = vTitulo.COD_CONTA

                Else

                    cmbConta.SelectedValue = vTitulo.COD_CONTA

                End If

                dtpVencimento.Text = vTitulo.DAT_VENCIMENTO

                dtpPlanejamento.Text = vTitulo.DAT_PLANEJAMENTO

                txtDescricao.Text = vTitulo.DESCRICAO

                mskValor.Text = FormatNumber(vTitulo.VALOR, 2)

                If vTitulo.NUM_PARCELA.GetValueOrDefault = 0 Then
                    txtParcela.Text = m_empty
                Else
                    txtParcela.Text = vTitulo.NUM_PARCELA
                End If

                txtObservacao.Text = vTitulo.OBSERVACAO

                txtDescricao.Select()

            End Using

        Catch ex As Exception

            MessageBox.Show("Erro ao preencher tela.", "Erro::sb_Preenche_Tela", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub frmTitulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToParent()

        sb_Preenche_Combo()

        sb_Limpa_Tela()

        If m_cod_titulo > 0 Then

            chkBaixarTitulo.Enabled = False

            sb_Preenche_Tela()

        End If

        sb_Configura_ItemCartao(IIf(cmbSubConta.SelectedValue = -1, cmbConta.SelectedValue, cmbSubConta.SelectedValue))

    End Sub

    Private Sub sb_Gravar()

        If Not fn_Valida() Then
            Exit Sub
        End If

        If m_cod_titulo > 0 Then

            sb_Alterar()

        Else

            sb_Incluir()

            If chkGerarDebito.Checked Then

                sb_Incluir_Titulo_Futuro()

            End If

            If chkBaixarTitulo.Checked Then

                sb_Incluir_Lancamento()

            End If

        End If

        Me.Close()

    End Sub

    Private Sub sb_Incluir_Lancamento()

        Try

            Using ctx = New FINANCEIROEntities

                Dim vLancamento As New TB_LANCAMENTO

                vLancamento.COD_TITULO = m_cod_titulo
                vLancamento.DATA = dtpVencimento.Text
                vLancamento.VALOR = mskValor.Text
                vLancamento.OBSERVACAO = txtObservacao.Text.Trim

                ctx.TB_LANCAMENTO.Add(vLancamento)

                ctx.SaveChanges()

            End Using

        Catch ex As Exception

            MessageBox.Show("Erro ao realizar baixa do título.", "Erro::sb_Incluir_Lancamento", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub sb_Incluir()

        Try

            Using ctx = New FINANCEIROEntities

                Dim vTitulo As New TB_TITULO

                If cmbSubConta.Items.Count = 0 Then
                    vTitulo.COD_CONTA = cmbConta.SelectedValue
                Else
                    vTitulo.COD_CONTA = cmbSubConta.SelectedValue
                End If

                vTitulo.DESCRICAO = txtDescricao.Text.Trim
                vTitulo.DAT_VENCIMENTO = dtpVencimento.Text
                vTitulo.DAT_PLANEJAMENTO = dtpPlanejamento.Text
                vTitulo.VALOR = mskValor.Text

                If IsNumeric(txtParcela.Text) Then

                    If txtParcela.Text > 0 Then

                        vTitulo.NUM_PARCELA = txtParcela.Text

                    End If

                End If


                vTitulo.OBSERVACAO = txtObservacao.Text.Trim
                vTitulo.DAT_CADASTRO = Now

                ctx.TB_TITULO.Add(vTitulo)

                ctx.SaveChanges()

                m_cod_titulo = vTitulo.COD_TITULO

            End Using

            m_ok = True

        Catch ex As Exception

            m_ok = False

            MessageBox.Show("Erro ao gravar título.", "Erro::sb_Incluir", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub sb_Incluir_Titulo_Futuro()

        Dim vQtdParcela As Integer = 1
        Dim vValorParcela As Decimal = 0
        Dim vNumParcela As Integer = 0
        Dim vVencimento As Date

        Try

            vQtdParcela = IIf(Not IsNumeric(txtQtdParcela.Text), 1, txtQtdParcela.Text)

            If rdoParcelar.Checked And vQtdParcela > 1 Then

                vValorParcela = Convert.ToDecimal(mskValor.Text) / vQtdParcela

            Else

                vValorParcela = Convert.ToDecimal(mskValor.Text)

            End If

            If IsNumeric(txtParcela.Text) Then
                vNumParcela = txtParcela.Text
            End If

            vVencimento = dtpVencimento.Text  'dtpVencimento.Value.ToShortDateString

            Using ctx = New FINANCEIROEntities

                Do While vNumParcela < vQtdParcela

                    Dim vTitulo As New TB_TITULO

                    vVencimento = vVencimento.AddMonths(1).ToShortDateString

                    vNumParcela = vNumParcela + 1

                    If cmbSubContaTituloFuturo.Items.Count = 0 Then
                        vTitulo.COD_CONTA = cmbContaTituloFuturo.SelectedValue
                    Else
                        vTitulo.COD_CONTA = cmbSubContaTituloFuturo.SelectedValue
                    End If

                    vTitulo.DESCRICAO = txtDescricao.Text.Trim
                    vTitulo.DAT_VENCIMENTO = vVencimento
                    vTitulo.DAT_PLANEJAMENTO = vVencimento
                    vTitulo.VALOR = vValorParcela

                    If (IsNumeric(txtParcela.Text) Or rdoParcelar.Checked) And vQtdParcela > 1 Then
                        vTitulo.NUM_PARCELA = vNumParcela
                    End If

                    vTitulo.OBSERVACAO = txtObservacao.Text.Trim
                    vTitulo.DAT_CADASTRO = Now

                    ctx.TB_TITULO.Add(vTitulo)

                Loop

                ctx.SaveChanges()

            End Using

            m_ok = True

            'MessageBox.Show("Titulo futuro gravado com sucesso.", "CFF", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            m_ok = False

            MessageBox.Show("Erro ao gravar título futuro.", "Erro::sb_Incluir", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub sb_Alterar()

        Try

            Using ctx = New FINANCEIROEntities

                Dim vTitulo = (From titulo In ctx.TB_TITULO Where titulo.COD_TITULO = m_cod_titulo).SingleOrDefault

                If cmbSubConta.Items.Count = 0 Then
                    vTitulo.COD_CONTA = cmbConta.SelectedValue
                Else
                    vTitulo.COD_CONTA = cmbSubConta.SelectedValue
                End If

                vTitulo.DESCRICAO = txtDescricao.Text.Trim
                vTitulo.DAT_VENCIMENTO = dtpVencimento.Text
                vTitulo.DAT_PLANEJAMENTO = dtpPlanejamento.Text
                vTitulo.VALOR = mskValor.Text

                If IsNumeric(txtParcela.Text) Then
                    vTitulo.NUM_PARCELA = txtParcela.Text
                End If

                vTitulo.OBSERVACAO = txtObservacao.Text.Trim

                ctx.SaveChanges()

            End Using

            m_ok = True

        Catch ex As Exception

            m_ok = False

            MessageBox.Show("Erro ao gravar título.", "Erro::sb_Alterar", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub sb_Preenche_Combo()

        sb_Preenche_Conta(cmbConta)

        sb_Preenche_Conta(cmbContaTituloFuturo)

    End Sub

    Private Sub sb_Preenche_SubConta(ByVal p_cod_conta As Integer)

        sb_Preenche_Conta(cmbSubConta, p_cod_conta)

        cmbSubConta.SelectedValue = -1

        sb_Configura_ItemCartao(cmbSubConta.SelectedValue)

    End Sub

    Private Sub sb_Preenche_SubConta_Titulo_Futuro(ByVal p_cod_conta As Integer)

        sb_Preenche_Conta(cmbSubContaTituloFuturo, p_cod_conta)

        cmbSubContaTituloFuturo.SelectedValue = -1

        sb_Configura_ItemCartao(cmbSubConta.SelectedValue)

    End Sub

    Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click

        sb_Gravar()

    End Sub

    Private Sub cmdSair_Click(sender As Object, e As EventArgs) Handles cmdSair.Click

        m_ok = False

        Me.Close()

    End Sub

    Private Function Fn_Valida() As Boolean

        If cmbConta.Text = m_empty Then
            MessageBox.Show("O campo conta é obrigatório.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If Not IsDate(dtpVencimento.Text) Then
            MessageBox.Show("O campo vencimento é obrigatório.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If txtDescricao.Text.Trim = "" Then
            MessageBox.Show("O campo descrição é obrigatório.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If mskValor.Text = m_empty Then
            MessageBox.Show("O campo valor é obrigatório.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        Return True

    End Function

    Private Sub cmbConta_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbConta.SelectionChangeCommitted
        sb_Exibe_Tipo_Conta(lblTipoConta, cmbConta.SelectedValue)
        sb_Preenche_SubConta(cmbConta.SelectedValue)
    End Sub

    Private Sub chkGerarDebito_CheckedChanged(sender As Object, e As EventArgs) Handles chkGerarDebito.CheckedChanged
        gbxGerarDebito.Enabled = chkGerarDebito.Checked
    End Sub

    Private Sub cmbContaTituloFuturo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbContaTituloFuturo.SelectionChangeCommitted
        sb_Exibe_Tipo_Conta(lblTipoContaFutura, cmbContaTituloFuturo.SelectedValue)
        sb_Preenche_SubConta_Titulo_Futuro(cmbContaTituloFuturo.SelectedValue)
    End Sub

    Private Sub sb_Exibe_Tipo_Conta(ByVal p_lbl As Label, ByVal p_cod_conta As Integer)

        Dim vTipo As String = fn_Tipo_Conta(p_cod_conta)

        p_lbl.Visible = True

        If vTipo = "C" Then

            p_lbl.Text = "Crédito"

        ElseIf vTipo = "D" Then

            p_lbl.Text = "Débito"

        Else

            p_lbl.Visible = False
            p_lbl.Text = ""

        End If

    End Sub

    Private Sub rdoParcelar_CheckedChanged(sender As Object, e As EventArgs) Handles rdoParcelar.CheckedChanged
        lblQtdParcela.Text = "parcela(s)"
    End Sub

    Private Sub rdoCopiar_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCopiar.CheckedChanged
        lblQtdParcela.Text = "cópia(s)"
    End Sub

    Private Sub sb_Configura_ItemCartao(ByVal p_cod_conta As Integer)

        m_cod_cartao = 0

        If p_cod_conta > 0 Then

            m_cod_cartao = fn_Retorna_Cartao(p_cod_conta)

            cmd_itemcartao.Visible = m_cod_cartao > 0

            cmd_itemcartao.Enabled = m_cod_titulo > 0

        Else

            cmd_itemcartao.Visible = False

            cmd_itemcartao.Enabled = False

        End If

    End Sub

    Private Sub cmbSubConta_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbSubConta.SelectionChangeCommitted
        sb_Configura_ItemCartao(cmbSubConta.SelectedValue)
    End Sub

    Private Sub cmd_itemcartao_Click(sender As Object, e As EventArgs) Handles cmd_itemcartao.Click

        m_item_cartao = True

        sb_Gravar()

    End Sub
End Class