Public Class frmParcela

    Private m_seq_parcelamento As Double
    Private m_dsc_parcelamento As String

    Public Property DSC_PARCELAMENTO
        Get
            Return m_dsc_parcelamento
        End Get
        Set(value)
            m_dsc_parcelamento = value
        End Set
    End Property

    Public Property SEQ_PARCELAMENTO
        Get
            Return m_seq_parcelamento
        End Get
        Set(value)
            m_seq_parcelamento = value
        End Set
    End Property

    Private Sub frmParcela_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxtCodigo.Text = m_seq_parcelamento

        txtDscParcelamento.Text = m_dsc_parcelamento

        Call Sb_Limpa_Titulo()

        Call sb_Lista_Parcela()

    End Sub

    Private Sub sb_Lista_Parcela()

        Dim vLinha As String()

        Try

            dgvParcela.Rows.Clear()

            Using ctx = New FINANCEIROEntities

                Dim vPar = (From par In ctx.TB_PARCELA Where par.SEQ_PARCELAMENTO = m_seq_parcelamento).ToList

                For Each vReg In vPar

                    Dim vPag = From tit In ctx.TB_TITULO
                               Join lanc In ctx.TB_LANCAMENTO On lanc.COD_TITULO Equals tit.COD_TITULO
                               Where tit.COD_TITULO = vReg.COD_TITULO
                               Select lanc.DATA

                    vLinha = {vReg.SEQ_PARCELA, vReg.NUM_PARCELA, FormatNumber(vReg.VALOR, 2), vReg.DAT_VENCIMENTO, IIf(vPag.SingleOrDefault = "00:00:00", "", vPag.SingleOrDefault)}

                    dgvParcela.Rows.Add(vLinha)

                Next

            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao preencher lista parcela.", "Erro::sb_Lista_Parcela", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Sb_Carrega_Titulo(ByVal p_seq_parcela As Double)

        Try

            Using ctx = New FINANCEIROEntities

                Dim vPar = (From tit In ctx.vw_titulo
                            Where tit.seq_parcela = p_seq_parcela
                            Select tit.COD_TITULO _
                            , tit.VALOR _
                            , tit.DAT_VENCIMENTO _
                            , tit.DESC_RAIZ _
                            , tit.DESC_CONTA _
                            , tit.VAL_PAGO _
                            , tit.DAT_PAGAMENTO).SingleOrDefault

                Call Sb_Limpa_Titulo()

                If Not IsNothing(vPar) Then

                    txtNumeroTitulo.Text = vPar.COD_TITULO
                    txtValorTitulo.Text = FormatNumber(vPar.VALOR, 2)
                    txtVencimentoTitulo.Text = vPar.DAT_VENCIMENTO
                    txtGrupo.Text = vPar.DESC_RAIZ
                    txtSubGrupo.Text = vPar.DESC_CONTA

                    If Not IsNothing(vPar.DAT_PAGAMENTO) Then

                        txtValorPago.Text = FormatNumber(vPar.VAL_PAGO, 2)
                        txtDataPagamento.Text = vPar.DAT_PAGAMENTO

                    End If

                Else

                    Call Sb_Limpa_Titulo()

                End If

            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao preencher título parcela.", "Erro::Sb_Carrega_Titulo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Sb_Carrega_Parcela(ByVal p_seq_parcela As Double)

        txtNumeroParcela.Tag = dgvParcela.CurrentRow.Cells("col_seq_parcela").Value

        txtNumeroParcela.Text = dgvParcela.CurrentRow.Cells("col_numero_parcela").Value

        txtValorParcela.Text = dgvParcela.CurrentRow.Cells("col_valor").Value

        txtVencimentoParcela.Text = dgvParcela.CurrentRow.Cells("col_vencimento").Value

        Call Sb_Carrega_Titulo(p_seq_parcela)

    End Sub

    Private Sub dgvParcela_Click(sender As Object, e As EventArgs) Handles dgvParcela.Click
        Call sb_Carrega_Parcela(dgvParcela.CurrentRow.Cells("col_seq_parcela").Value)
    End Sub

    Private Sub cmdPesquisaTitulo_Click(sender As Object, e As EventArgs) Handles cmdPesquisaTitulo.Click
        Call Sb_Pesquisa_Titulo(txtNumeroTitulo.Text)
    End Sub

    Private Sub Sb_Pesquisa_Titulo(ByVal p_cod_titulo As Double)

        Try

            Using ctx = New FINANCEIROEntities

                Dim vPar = (From tit In ctx.vw_titulo
                            Where tit.COD_TITULO = p_cod_titulo
                            Select tit.COD_TITULO _
                            , tit.VALOR _
                            , tit.DAT_VENCIMENTO _
                            , tit.DESC_RAIZ _
                            , tit.DESC_CONTA _
                            , tit.VAL_PAGO _
                            , tit.DAT_PAGAMENTO).SingleOrDefault

                Call Sb_Limpa_Titulo()

                If Not IsNothing(vPar) Then

                    txtNumeroTitulo.Text = vPar.COD_TITULO
                    txtValorTitulo.Text = FormatNumber(vPar.VALOR, 2)
                    txtVencimentoTitulo.Text = vPar.DAT_VENCIMENTO
                    txtGrupo.Text = vPar.DESC_RAIZ
                    txtSubGrupo.Text = vPar.DESC_CONTA

                    If Not IsNothing(vPar.DAT_PAGAMENTO) Then

                        txtValorPago.Text = FormatNumber(vPar.VAL_PAGO, 2)
                        txtDataPagamento.Text = vPar.DAT_PAGAMENTO

                    End If

                Else

                    MessageBox.Show("Título não encontrado.", "CFF", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao preencher título parcela.", "Erro::Sb_Pesquisa_Titulo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Sb_Atualizar_Parcela()

        Try

            Using ctx = New FINANCEIROEntities

                Dim vPar = (From par In ctx.TB_PARCELA Where par.SEQ_PARCELA = CDbl(txtNumeroParcela.Tag)).SingleOrDefault

                vPar.VALOR = txtValorParcela.Text

                vPar.DAT_VENCIMENTO = txtVencimentoParcela.Text

                vPar.COD_TITULO = txtNumeroTitulo.Text

                ctx.SaveChanges()

                Call Sb_Atualiza_Tela()

            End Using

        Catch ex As Exception

            MessageBox.Show("Erro ao atualizar parcela.", "Erro::Sb_Atualizar_Parcela", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub Sb_Atualiza_Tela()

        txtNumeroParcela.Text = ""
        txtValorParcela.Text = ""
        txtVencimentoParcela.Text = ""
        txtNumeroTitulo.Text = ""
        txtValorTitulo.Text = ""
        txtVencimentoTitulo.Text = ""
        txtGrupo.Text = ""
        txtSubGrupo.Text = ""
        txtValorPago.Text = ""
        txtDataPagamento.Text = ""

        Call sb_Lista_Parcela()

    End Sub

    Private Sub Sb_Limpa_Titulo()

        txtNumeroTitulo.Text = ""
        txtValorTitulo.Text = ""
        txtVencimentoTitulo.Text = ""
        txtGrupo.Text = ""
        txtSubGrupo.Text = ""
        txtValorPago.Text = ""
        txtDataPagamento.Text = ""

    End Sub

    Private Sub cmdAtualizarParcela_Click(sender As Object, e As EventArgs) Handles cmdAtualizarParcela.Click
        Call Sb_Atualizar_Parcela()
    End Sub

    Private Sub cmdBaixarTitulo_Click(sender As Object, e As EventArgs) Handles cmdBaixarTitulo.Click

        Dim vFormLanc As New frmLancamento

        vFormLanc.titulo = txtNumeroTitulo.Text

        vFormLanc.txtNumero.ReadOnly = True

        vFormLanc.ShowDialog()

        If vFormLanc.ok Then
            Call Sb_Atualiza_Tela()
        End If

        vFormLanc = Nothing

    End Sub

    Private Sub cmdCriarParcela_Click(sender As Object, e As EventArgs) Handles cmdCriarParcela.Click

        Dim vFormTitulo As New frmTitulo

        vFormTitulo.Codigo = 0

        vFormTitulo.ShowDialog()

        If vFormTitulo.Ok Then
            txtNumeroTitulo.Text = vFormTitulo.Codigo
        End If

        vFormTitulo = Nothing

    End Sub
End Class