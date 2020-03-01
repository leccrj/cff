Public Class frmParcelamento

    Private m_seq_parcelamento As Integer
    Private m_ok As Boolean

    Public Property SEQ_PARCELAMENTO
        Get
            Return m_seq_parcelamento
        End Get
        Set(value)
            m_seq_parcelamento = value
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

    Private Sub frmParcelamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call Sb_Limpa_Tela()

        ChkEntrada.Enabled = True

        ChkGerarParcela.Enabled = True

        ChkGerarTitulo.Enabled = True

        If m_seq_parcelamento > 0 Then

            ChkEntrada.Enabled = False

            ChkGerarParcela.Enabled = False

            ChkGerarTitulo.Enabled = False

            Sb_Preenche_Tela()

        End If

    End Sub

    Private Sub CmdGravar_Click(sender As Object, e As EventArgs) Handles CmdGravar.Click
        Call Sb_Gravar()
    End Sub

    Private Sub Sb_Gravar()

        If Not Fn_Valida() Then
            Exit Sub
        End If

        If m_seq_parcelamento > 0 Then

            sb_Alterar()

        Else

            sb_Incluir()

            If ChkGerarParcela.Checked Then

            End If

        End If

        Me.Close()

    End Sub

    Private Function Fn_Valida() As Boolean

        If TxtDescricao.Text.Trim = "" Then
            MessageBox.Show("O campo descrição é obrigatório.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If Not IsNumeric(TxtValor.Text) Then
            MessageBox.Show("Valor inválido.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If Not IsNumeric(TxtQtdParcela.Text) Then
            MessageBox.Show("Quantidade de Parcelas inválida.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If ChkEntrada.Checked And Not IsNumeric(TxtEntrada.Text) Then
            MessageBox.Show("Valor da entrada inválido.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        Return True

    End Function

    Private Sub Sb_Alterar()

        Try

            Using ctx = New FINANCEIROEntities

                Dim vParc = (From p In ctx.TB_PARCELAMENTO Where p.SEQ_PARCELAMENTO = m_seq_parcelamento).SingleOrDefault

                If Not IsNumeric(TxtTitulo.Text) Then
                    vParc.COD_TITULO = Nothing
                Else
                    vParc.COD_TITULO = TxtTitulo.Text
                End If

                vParc.DESCRICAO = TxtDescricao.Text.Trim
                vParc.VALOR = TxtValor.Text
                vParc.QTD_PARCELA = TxtQtdParcela.Text
                vParc.DAT_INICIO = DtpDataInicio.Value.ToShortDateString
                vParc.OBSERVACAO = TxtObservacao.Text.Trim

                ctx.SaveChanges()

            End Using

            m_ok = True

        Catch ex As Exception

            m_ok = False

            MessageBox.Show("Erro ao gravar título.", "Erro::Sb_Alterar", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub Sb_Incluir()

        Dim vParc As New TB_PARCELAMENTO
        Dim vParcela As TB_PARCELA
        Dim vTitulo As TB_TITULO
        Dim v_data_vencimento As Date
        Dim v_valor As Double

        Try

            Using ctx = New FINANCEIROEntities

                If IsNumeric(TxtTitulo.Text) Then
                    vParc.COD_TITULO = TxtTitulo.Text
                End If

                vParc.DESCRICAO = TxtDescricao.Text.Trim
                vParc.DAT_INICIO = DtpDataInicio.Value.ToShortDateString
                vParc.VALOR = TxtValor.Text
                vParc.QTD_PARCELA = TxtQtdParcela.Text
                vParc.OBSERVACAO = TxtObservacao.Text.Trim
                vParc.DAT_CADASTRO = Now

                ctx.TB_PARCELAMENTO.Add(vParc)

                m_seq_parcelamento = vParc.SEQ_PARCELAMENTO

                If ChkGerarParcela.Checked Then

                    v_data_vencimento = vParc.DAT_INICIO
                    v_valor = vParc.VALOR

                    'entrada
                    If ChkEntrada.Checked Then

                        vParcela = New TB_PARCELA

                        vParcela.SEQ_PARCELAMENTO = vParc.SEQ_PARCELAMENTO
                        vParcela.DAT_CADASTRO = Now
                        vParcela.DAT_VENCIMENTO = vParc.DAT_INICIO
                        vParcela.NUM_PARCELA = 0
                        vParcela.VALOR = TxtEntrada.Text

                        ctx.TB_PARCELA.Add(vParcela)

                        v_data_vencimento = DateAdd(DateInterval.Month, 1, vParc.DAT_INICIO)
                        v_valor = vParc.VALOR - vParcela.VALOR

                    End If

                    'parcelas
                    For i = 1 To vParc.QTD_PARCELA

                        vParcela = New TB_PARCELA

                        vParcela.SEQ_PARCELAMENTO = vParc.SEQ_PARCELAMENTO
                        vParcela.DAT_CADASTRO = Now.ToShortDateString
                        vParcela.DAT_VENCIMENTO = DateAdd(DateInterval.Month, i - 1, v_data_vencimento)
                        vParcela.NUM_PARCELA = i
                        vParcela.VALOR = v_valor / vParc.QTD_PARCELA

                        ctx.TB_PARCELA.Add(vParcela)

                        'If ChkGerarTitulo.Checked Then

                        '    vTitulo = New TB_TITULO



                        'End If

                    Next

                End If

                ctx.SaveChanges()

            End Using

            m_ok = True

        Catch ex As Exception

            m_ok = False

            MessageBox.Show("Erro ao gravar título.", "Erro::Sb_Incluir", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub Sb_Limpa_Tela()

        TxtCodigo.Text = ""
        TxtTitulo.Text = ""
        TxtDescricao.Text = ""
        TxtValor.Text = ""
        ChkGerarParcela.Checked = False
        TxtQtdParcela.Text = ""
        TxtObservacao.Text = ""
        DtpDataInicio.Value = Now.ToShortDateString

    End Sub

    Private Sub Sb_Preenche_Tela()

        Try

            Using ctx = New FINANCEIROEntities

                Dim vParc = (From p In ctx.TB_PARCELAMENTO
                             Where p.SEQ_PARCELAMENTO = m_seq_parcelamento
                             Select p.SEQ_PARCELAMENTO _
                                   , p.COD_TITULO _
                                   , p.DESCRICAO _
                                   , p.VALOR _
                                   , p.QTD_PARCELA _
                                   , p.DAT_INICIO _
                                   , p.OBSERVACAO).SingleOrDefault

                TxtCodigo.Text = vParc.SEQ_PARCELAMENTO

                If Not vParc.COD_TITULO Is Nothing Then
                    TxtTitulo.Text = vParc.COD_TITULO
                End If

                TxtDescricao.Text = vParc.DESCRICAO

                TxtValor.Text = FormatNumber(vParc.VALOR, 2)

                TxtQtdParcela.Text = vParc.QTD_PARCELA

                DtpDataInicio.Value = vParc.DAT_INICIO

                TxtObservacao.Text = vParc.OBSERVACAO

            End Using

        Catch ex As Exception

            MessageBox.Show("Erro ao preencher tela.", "Erro::Sb_Preenche_Tela", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub Sb_Pesquesa_Titulo()

        Try

            If Not IsNumeric(TxtTitulo.Text) Then
                MessageBox.Show("Número inválido.", "Pesquisa Título", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Using ctx = New FINANCEIROEntities

                Dim vTitulo = (From t In ctx.TB_TITULO
                               Where t.COD_TITULO = TxtTitulo.Text
                               Select t.DESCRICAO _
                                   , t.VALOR).SingleOrDefault

                If vTitulo Is Nothing Then
                    MessageBox.Show("Título não encontrado.", "Pesquisa Título", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                TxtDescricao.Text = vTitulo.DESCRICAO

                TxtValor.Text = FormatNumber(vTitulo.VALOR, 2)

            End Using

        Catch ex As Exception

            MessageBox.Show("Erro ao preencher tela.", "Erro::Sb_Preenche_Tela", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub CmdPesquisaTitulo_Click(sender As Object, e As EventArgs) Handles CmdPesquisaTitulo.Click
        Sb_Pesquesa_Titulo()
    End Sub

    Private Sub ChkEntrada_CheckedChanged(sender As Object, e As EventArgs) Handles ChkEntrada.CheckedChanged
        TxtEntrada.ReadOnly = Not ChkEntrada.Checked
    End Sub

    Private Sub ChkGerarParcela_CheckedChanged(sender As Object, e As EventArgs) Handles ChkGerarParcela.CheckedChanged

        ChkGerarTitulo.Checked = False

        ChkGerarTitulo.Enabled = ChkGerarParcela.Checked

    End Sub
End Class