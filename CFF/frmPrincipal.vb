Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmPrincipal

    Private vForm As Object
    Private vMes As Mes

    Private Sub ContaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles imnConta.Click

        vForm = New frmConta

        sb_Configura_Menu_Grc(True)

        sb_Configura_Tool_Conta()

        sb_Preenche_Grc_Conta()

    End Sub

    Private Sub LancamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles imnLancamento.Click

        vForm = New frmLancamento

        sb_Configura_Resumo()

        sb_Configura_Menu_Grc(True)

        sb_Preenche_Grc_Lancamento()

    End Sub

    Private Sub tsm_item_sair_Click(sender As Object, e As EventArgs) Handles imnSair.Click
        Me.Close()
    End Sub

    Private Sub sb_Configura_Menu_Grc(ByVal pVisivel As Boolean)

        stbIncluir.Visible = pVisivel
        stbEditar.Visible = pVisivel
        stbExcluir.Visible = pVisivel
        stsSeparador1.Visible = False
        stlMesAno.Visible = False
        sttMesAno.Visible = False
        stbPesquisar.Visible = False
        stlRaiz.Visible = False
        sttRaiz.Visible = False
        stbPesquisarRaiz.Visible = False
        stsSeparador1.Visible = False
        stlTitulo.Visible = False
        sttTitulo.Visible = False
        stbPesquisarTitulo.Visible = False

    End Sub

    Private Sub sb_Configura_Tool_Titulo()

        stsSeparador1.Visible = True
        stlMesAno.Visible = True
        sttMesAno.Visible = True
        If sttMesAno.Text = "" Then
            sttMesAno.Text = Now.Month.ToString + "/" + Now.Year.ToString
        End If
        stbPesquisar.Visible = True

    End Sub

    Private Sub sb_Configura_Tool_Conta()

        stsSeparador1.Visible = True
        stlRaiz.Visible = True
        sttRaiz.Visible = True
        stbPesquisarRaiz.Visible = True

    End Sub

    Private Sub sb_Configura_Tool_Movimento()

        stsSeparador1.Visible = True
        stlTitulo.Visible = True
        sttTitulo.Visible = True
        stbPesquisarTitulo.Visible = True

    End Sub

    Private Sub sb_Configura_Grc_Conta()

        Dim vCol As DataGridViewTextBoxColumn
        Dim vColImg As DataGridViewImageColumn
        Dim vColImgWidth As Integer = 30

        dgvGrc.Columns.Clear()

        'cod_conta
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_cod_conta"
            .HeaderText = "Código"
            .ReadOnly = True
            .Width = 50
            .Visible = True
        End With

        dgvGrc.Columns.Add(vCol)

        'descrição
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_descricao"
            .HeaderText = "Descrição"
            .ReadOnly = True
            .Width = 300
        End With

        dgvGrc.Columns.Add(vCol)

        'tipo
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_tipo"
            .HeaderText = "Tipo"
            .ReadOnly = True
            .Width = 100
        End With

        dgvGrc.Columns.Add(vCol)

        'ordem exibição titulo
        vCol = New DataGridViewTextBoxColumn
        With vCol
            .Name = "col_ordem"
            .HeaderText = "Ordem"
            .ReadOnly = True
            .Width = 100
        End With

        dgvGrc.Columns.Add(vCol)

        'subconta
        vColImg = New DataGridViewImageColumn

        With vColImg
            .Name = "col_subconta"
            .HeaderText = ""
            .Width = vColImgWidth
            .Image = img.Images().Item("conta")
            .ReadOnly = True
            .Resizable = DataGridViewTriState.False
            .ToolTipText = "subconta"
        End With

        dgvGrc.Columns.Add(vColImg)

    End Sub

    Private Sub sb_Configura_Grc_Titulo()

        Dim vCol As DataGridViewTextBoxColumn
        Dim vColImg As DataGridViewImageColumn
        Dim vColChk As DataGridViewCheckBoxColumn
        Dim vColImgWidth As Integer = 30

        dgvGrc.Columns.Clear()

        'cod_titulo
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_cod_titulo"
            .HeaderText = "Código"
            .Visible = True
            .ReadOnly = True
            .Width = 40
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        End With

        dgvGrc.Columns.Add(vCol)

        'conta
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_conta"
            .HeaderText = "Conta"
            .ReadOnly = True
            .Width = 95
        End With

        dgvGrc.Columns.Add(vCol)

        'tipo conta
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_tipo_conta"
            .Visible = False
        End With

        dgvGrc.Columns.Add(vCol)

        'descrição
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_descricao"
            .HeaderText = "Descrição"
            .ReadOnly = True
            .Width = 250
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        End With

        dgvGrc.Columns.Add(vCol)

        'vencimento
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_vencimento"
            .HeaderText = "Vencimento"
            .ReadOnly = True
            .Width = 70
        End With

        dgvGrc.Columns.Add(vCol)

        'data pagamento
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_pagamento"
            .HeaderText = "Pagamento"
            .ReadOnly = True
            .Width = 70
        End With

        dgvGrc.Columns.Add(vCol)

        'valor titulo
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_val_titulo"
            .HeaderText = "Valor Título"
            .ReadOnly = True
            .Width = 55
        End With

        dgvGrc.Columns.Add(vCol)

        'valor pago
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_valor"
            .HeaderText = "Valor Pago"
            .ReadOnly = True
            .Width = 55
        End With

        dgvGrc.Columns.Add(vCol)

        'valor restante
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_saldo"
            .HeaderText = "Saldo"
            .ReadOnly = True
            .Width = 55
        End With

        dgvGrc.Columns.Add(vCol)

        'cod_lancamento
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_cod_lancamento"
            .Visible = False
        End With

        dgvGrc.Columns.Add(vCol)

        'cor
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_cor"
            .Visible = False
        End With

        dgvGrc.Columns.Add(vCol)

        'check planejamento
        vColChk = New DataGridViewCheckBoxColumn

        With vColChk
            .Name = "col_planejamento"
            .HeaderText = "Planejamento"
            .Width = 75
            .Visible = True
        End With

        dgvGrc.Columns.Add(vColChk)

        'lançamento
        vColImg = New DataGridViewImageColumn

        With vColImg
            .Name = "col_lancamento"
            .HeaderText = ""
            .Width = vColImgWidth
            .Image = img.Images().Item("pagar")
            .ReadOnly = True
            .Resizable = DataGridViewTriState.False
            .ToolTipText = "pagar"
        End With

        dgvGrc.Columns.Add(vColImg)

    End Sub

    Private Sub sb_Configura_Grc_Lancamento()

        Dim vCol As DataGridViewTextBoxColumn
        Dim vColImgWidth As Integer = 30

        dgvGrc.Columns.Clear()

        'cod_lancamento
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_cod_lancamento"
            .Visible = False
            .ReadOnly = True
        End With

        dgvGrc.Columns.Add(vCol)

        'cod_titulo
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_cod_titulo"
            .HeaderText = "Título"
            .ReadOnly = True
        End With

        dgvGrc.Columns.Add(vCol)

        'descrição
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_descricao"
            .HeaderText = "Descrição"
            .ReadOnly = True
        End With

        dgvGrc.Columns.Add(vCol)

        'conta
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_conta"
            .HeaderText = "Conta"
            .ReadOnly = True
        End With

        dgvGrc.Columns.Add(vCol)

        'valor título
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_valor_titulo"
            .HeaderText = "Valor"
            .ReadOnly = True
        End With

        dgvGrc.Columns.Add(vCol)

        'vencimento
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_vencimento"
            .HeaderText = "Vencimento"
            .ReadOnly = True
        End With

        dgvGrc.Columns.Add(vCol)

        'data lançamento
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_data_lancamento"
            .HeaderText = "Data Lançamento"
            .ReadOnly = True
        End With

        dgvGrc.Columns.Add(vCol)

        'valor pago
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_valor_pago"
            .HeaderText = "Valor Pago"
            .ReadOnly = True
        End With

        dgvGrc.Columns.Add(vCol)

    End Sub

    Private Sub sb_Configura_Grc_Cartao()

        Dim vCol As DataGridViewTextBoxColumn
        Dim vColImg As DataGridViewImageColumn
        Dim vColImgWidth As Integer = 30

        dgvGrc.Columns.Clear()

        'cod_cartao
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_cod_cartao"
            .HeaderText = "Código"
            .ReadOnly = True
            .Width = 50
            .Visible = True
        End With

        dgvGrc.Columns.Add(vCol)

        'descrição
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_descricao"
            .HeaderText = "Descrição"
            .ReadOnly = True
            .Width = 300
        End With

        dgvGrc.Columns.Add(vCol)

        'numero
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_numero"
            .HeaderText = "Número"
            .ReadOnly = True
            .Width = 150
        End With

        dgvGrc.Columns.Add(vCol)

        'dia vencimento
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_dia_vencimento"
            .HeaderText = "Dia Vencimento"
            .ReadOnly = True
            .Width = 100
        End With

        dgvGrc.Columns.Add(vCol)

        'movimento
        vColImg = New DataGridViewImageColumn
        With vColImg
            .Name = "col_movimento"
            .HeaderText = ""
            .Width = vColImgWidth
            .Image = img.Images().Item("movimento")
            .ReadOnly = True
            .Resizable = DataGridViewTriState.False
            .ToolTipText = "movimento"
        End With

        dgvGrc.Columns.Add(vColImg)

    End Sub

    Private Sub sb_Configura_Grc_Parcelamento()

        Dim vCol As DataGridViewTextBoxColumn
        Dim vColImg As DataGridViewImageColumn
        Dim vColImgWidth As Integer = 30

        dgvGrc.Columns.Clear()

        'seq_parcelamento
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_seq_parcelamento"
            .Visible = False
            .ReadOnly = True
        End With

        dgvGrc.Columns.Add(vCol)

        'descrição
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_descricao"
            .HeaderText = "Descrição"
            .Visible = True
            .ReadOnly = True
            .Width = 100
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        End With

        dgvGrc.Columns.Add(vCol)

        'valor
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_valor"
            .HeaderText = "Valor"
            .Visible = True
            .ReadOnly = True
            .Width = 100
        End With

        dgvGrc.Columns.Add(vCol)

        'quantidade parcela
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_qtdparcela"
            .HeaderText = "Parcelas"
            .Visible = True
            .ReadOnly = True
            .Width = 80
        End With

        dgvGrc.Columns.Add(vCol)

        'data início
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_dat_inicio"
            .HeaderText = "Início"
            .Visible = True
            .ReadOnly = True
            .Width = 100
        End With

        dgvGrc.Columns.Add(vCol)

        'quantidade parcelas pagas
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_qtdparcela_paga"
            .HeaderText = "Parcelas Pagas"
            .Visible = True
            .ReadOnly = True
            .Width = 100
        End With

        dgvGrc.Columns.Add(vCol)

        'total pago
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_total_pago"
            .HeaderText = "Total Pago"
            .Visible = True
            .ReadOnly = True
            .Width = 100
        End With

        dgvGrc.Columns.Add(vCol)

        'restante
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_restante"
            .HeaderText = "Restante"
            .Visible = True
            .ReadOnly = True
            .Width = 100
        End With

        dgvGrc.Columns.Add(vCol)

        'situação parcelamento
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_situacao"
            .HeaderText = "Situação"
            .Visible = True
            .ReadOnly = True
            .Width = 100
        End With

        dgvGrc.Columns.Add(vCol)

        'botão parcelas
        vColImg = New DataGridViewImageColumn

        With vColImg
            .Name = "col_parcela"
            .HeaderText = ""
            .Width = vColImgWidth
            .Image = img.Images().Item("parcela")
            .ReadOnly = True
            .Resizable = DataGridViewTriState.False
            .ToolTipText = "Parcelas"
        End With

        dgvGrc.Columns.Add(vColImg)

    End Sub

    Private Sub sb_Configura_Grc_Movimento()

        Dim vCol As DataGridViewTextBoxColumn
        Dim vColImgWidth As Integer = 30

        dgvGrc.Columns.Clear()

        'seq_movimento
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_seq_movimento"
            .Visible = False
            .ReadOnly = True
        End With

        dgvGrc.Columns.Add(vCol)

        'cartao
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_cartao"
            .HeaderText = "Cartao"
            .ReadOnly = True
        End With

        dgvGrc.Columns.Add(vCol)

        'conta
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_conta"
            .HeaderText = "Conta"
            .ReadOnly = True
            .Width = 100
        End With

        dgvGrc.Columns.Add(vCol)

        'titulo
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_titulo"
            .HeaderText = "Título"
            .ReadOnly = True
            .Width = 200
        End With

        dgvGrc.Columns.Add(vCol)

        'descricao
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_descricao"
            .HeaderText = "Descrição"
            .ReadOnly = True
            .Width = 200
        End With

        dgvGrc.Columns.Add(vCol)

        'data
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_data"
            .HeaderText = "Data"
            .ReadOnly = True
            .Width = 80
        End With

        dgvGrc.Columns.Add(vCol)

        'valor
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_valor"
            .HeaderText = "Valor"
            .ReadOnly = True
            .Width = 70
        End With

        dgvGrc.Columns.Add(vCol)

        'parcela
        vCol = New DataGridViewTextBoxColumn

        With vCol
            .Name = "col_parcela"
            .HeaderText = "Parcela"
            .ReadOnly = True
            .Width = 50
        End With

        dgvGrc.Columns.Add(vCol)

    End Sub

    Private Sub sb_Configura_Grc(ByVal nome_grc As grc)

        Dim vColImg As DataGridViewImageColumn
        Dim vColImgWidth As Integer = 30

        dgvGrc.Columns.Clear()

        Select Case nome_grc

            Case grc.conta

                sb_Configura_Grc_Conta()

            Case grc.titulo

                sb_Configura_Grc_Titulo()

            Case grc.lancamento

                sb_Configura_Grc_Lancamento()

            Case grc.cartao

                sb_Configura_Grc_Cartao()

            Case grc.movimento

                sb_Configura_Grc_Movimento()

            Case grc.parcelamento

                sb_Configura_Grc_Parcelamento()

        End Select

        'editar
        vColImg = New DataGridViewImageColumn

        With vColImg
            .Name = "col_editar"
            .HeaderText = ""
            .Width = vColImgWidth
            .Image = img.Images().Item("editar")
            .ReadOnly = True
            .Resizable = DataGridViewTriState.False
            .ToolTipText = "editar"
        End With

        dgvGrc.Columns.Add(vColImg)

        'excluir
        vColImg = New DataGridViewImageColumn

        With vColImg
            .Name = "col_excluir"
            .HeaderText = ""
            .Width = vColImgWidth
            .Image = img.Images().Item("excluir")
            .ReadOnly = True
            .Resizable = DataGridViewTriState.False
            .ToolTipText = "excluir"
        End With

        dgvGrc.Columns.Add(vColImg)

    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvGrc.Columns.Clear()

        sb_Configura_Menu_Grc(False)

        sb_Configura_Resumo()

        sb_Preenche_Arvore()

        lbl_dataval.Text = FormatDateTime(Now, DateFormat.ShortDate)

    End Sub

    Private Sub stbIncluir_Click(sender As Object, e As EventArgs) Handles stbIncluir.Click

        sb_Incluir()

    End Sub

    Private Sub sb_Preenche_Grc_Conta()

        Dim vLinha As String()

        Try

            sb_Configura_Resumo()

            Using ctx = New FINANCEIROEntities

                Dim vConta = (From conta In ctx.TB_CONTA Order By conta.TIPO, conta.NUM_ORDEM).ToList

                sb_Configura_Grc(grc.conta)

                For Each vReg As TB_CONTA In vConta

                    vLinha = {vReg.COD_CONTA, vReg.DESCRICAO, IIf(vReg.TIPO = "D", "Débito", "Crédito"), vReg.NUM_ORDEM.GetValueOrDefault}

                    If IsNothing(vReg.COD_CONTA_RAIZ) Then
                        dgvGrc.Rows.Add(vLinha)
                    End If

                Next

            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao preencher lista conta.", "Erro::sb_Preenche_Grc_Conta", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub sb_Preenche_Grc_Movimento()

        Dim vLinha As String()

        Try

            Using ctx = New FINANCEIROEntities

                Dim vMovimento = (From mov In ctx.TB_MOVIMENTO_CARTAO
                                  Join cartao In ctx.TB_CARTAO On cartao.COD_CARTAO Equals mov.COD_CARTAO
                                  Join conta In ctx.TB_CONTA On conta.COD_CONTA Equals mov.COD_CONTA
                                  Join tit In ctx.TB_TITULO On tit.COD_TITULO Equals mov.COD_TITULO
                                  Select mov.SEQ_MOVIMENTO, DESC_CARTAO = cartao.DESCRICAO, DESC_CONTA = conta.DESCRICAO, DESC_TITULO = tit.DESCRICAO, mov.DESCRICAO, mov.DAT_MOVIMENTO, mov.VALOR, mov.NUM_PARCELA).ToList

                sb_Configura_Grc(grc.movimento)

                For Each vReg In vMovimento

                    vLinha = {vReg.SEQ_MOVIMENTO, vReg.DESC_CARTAO, vReg.DESC_CONTA, vReg.DESC_TITULO, vReg.DESCRICAO, vReg.DAT_MOVIMENTO, FormatNumber(vReg.VALOR, 2), vReg.NUM_PARCELA.GetValueOrDefault}

                    dgvGrc.Rows.Add(vLinha)

                Next

            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao preencher lista movimento.", "Erro::sb_Preenche_Grc_Movimento", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub sb_Preenche_Grc_Cartao()

        Dim vLinha As String()

        Try

            Using ctx = New FINANCEIROEntities

                Dim vCartao = (From cartao In ctx.TB_CARTAO).ToList

                sb_Configura_Grc(grc.cartao)

                For Each vReg As TB_CARTAO In vCartao

                    vLinha = {vReg.COD_CARTAO, vReg.DESCRICAO, vReg.NUMERO, vReg.DIA_VENCIMENTO}

                    dgvGrc.Rows.Add(vLinha)

                Next

            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao preencher lista conta.", "Erro::sb_Preenche_Grc_Conta", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub sb_Preenche_Grc_Titulo()

        Dim vLinha As String()

        Try

            Using ctx = New FINANCEIROEntities

                Dim vTitulo = (From titulo In ctx.vw_titulo
                               Join conta In ctx.TB_CONTA On conta.COD_CONTA Equals titulo.COD_CONTA
                               Select titulo.COD_TITULO, NOME_CONTA = conta.DESCRICAO, titulo.DAT_VENCIMENTO, titulo.DESCRICAO, titulo.VALOR, titulo.DAT_PAGAMENTO).ToList

                sb_Configura_Grc(grc.titulo)

                For Each vReg In vTitulo

                    vLinha = {vReg.COD_TITULO, vReg.NOME_CONTA, vReg.DESCRICAO, vReg.DAT_VENCIMENTO, IIf(vReg.DAT_PAGAMENTO.GetValueOrDefault.Year = 0, "", vReg.DAT_PAGAMENTO), FormatNumber(vReg.VALOR, 2)}

                    dgvGrc.Rows.Add(vLinha)

                Next

            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao preencher lista des lançamentos.", "Erro::sb_Preenche_Grc_Titulo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub sb_Preenche_Grc_Lancamento()

        Dim vLinha As String()

        Try

            Using ctx = New FINANCEIROEntities

                Dim vLancamento = (From baixa In ctx.TB_LANCAMENTO
                                   Join titulo In ctx.TB_TITULO On titulo.COD_TITULO Equals baixa.COD_TITULO
                                   Join conta In ctx.TB_CONTA On conta.COD_CONTA Equals titulo.COD_CONTA
                                   Select baixa.COD_LANCAMENTO, titulo.COD_TITULO, titulo.DESCRICAO, DESC_CONTA = conta.DESCRICAO, VAL_TITULO = titulo.VALOR, titulo.DAT_VENCIMENTO, baixa.DATA, baixa.VALOR).ToList

                sb_Configura_Grc(grc.lancamento)

                For Each vReg In vLancamento

                    vLinha = {vReg.COD_LANCAMENTO, vReg.COD_TITULO, vReg.DESCRICAO, vReg.DESC_CONTA, FormatNumber(vReg.VAL_TITULO, 2), vReg.DAT_VENCIMENTO, vReg.DATA, FormatNumber(vReg.VALOR, 2)}

                    dgvGrc.Rows.Add(vLinha)

                Next

            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao preencher lista lançamento.", "Erro::sb_Preenche_Grc_Lancamento", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub stbEditar_Click(sender As Object, e As EventArgs) Handles stbEditar.Click

        sb_Editar()

    End Sub

    Private Sub dgvGrc_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGrc.CellContentClick

        Try

            If e.RowIndex = -1 Then
                Exit Sub
            End If

            If e.ColumnIndex = dgvGrc.Columns("col_editar").Index Then

                sb_Editar()

            ElseIf e.ColumnIndex = dgvGrc.Columns("col_excluir").Index Then

                sb_Excluir()

            Else

                If vForm.name = "frmConta" Then

                    If e.ColumnIndex = dgvGrc.Columns("col_subconta").Index Then

                        vForm.cod_conta_raiz = dgvGrc.CurrentRow.Cells("col_cod_conta").Value

                        sb_Incluir()

                    End If

                ElseIf vForm.name = "frmTitulo" Then

                    Dim vFormLanc As New frmLancamento

                    If e.ColumnIndex = dgvGrc.Columns("col_lancamento").Index And dgvGrc.CurrentRow.Cells("col_cod_lancamento").Value > 0 Then

                        vFormLanc.codigo = dgvGrc.CurrentRow.Cells("col_cod_lancamento").Value

                    ElseIf e.ColumnIndex = dgvGrc.Columns("col_lancamento").Index And dgvGrc.CurrentRow.Cells("col_cod_lancamento").Value = 0 Then

                        vFormLanc.codigo = 0

                        vFormLanc.titulo = dgvGrc.CurrentRow.Cells("col_cod_titulo").Value

                    ElseIf e.ColumnIndex = dgvGrc.Columns("col_planejamento").Index Then




                    Else

                        vFormLanc.codigo = 0

                        vFormLanc.titulo = 0

                    End If

                    If vFormLanc.codigo > 0 Or vFormLanc.titulo > 0 Then

                        vFormLanc.txtNumero.ReadOnly = True

                        vFormLanc.ShowDialog()

                        If vFormLanc.ok Then
                            sb_Pesquisa_Titulo()
                        End If

                    End If

                ElseIf vForm.name = "frmParcelamento" Then

                    Dim vFormParcela As New frmParcela

                    vFormParcela.SEQ_PARCELAMENTO = dgvGrc.CurrentRow.Cells("col_seq_parcelamento").Value
                    vFormParcela.DSC_PARCELAMENTO = dgvGrc.CurrentRow.Cells("col_descricao").Value

                    vFormParcela.ShowDialog()

                End If

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub stbExcluir_Click(sender As Object, e As EventArgs) Handles stbExcluir.Click

        sb_Excluir()

    End Sub

    Private Function fn_Excluir_Conta() As Boolean

        Dim vCodConta As Integer

        Try

            If IsNothing(dgvGrc.CurrentRow.Cells("col_cod_conta").Value) Then

                Return True

                Exit Function

            End If

            vCodConta = dgvGrc.CurrentRow.Cells("col_cod_conta").Value

            If (MessageBox.Show("Deseja excluir a conta?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No) Then

                Return True

                Exit Function

            End If

            Using ctx = New FINANCEIROEntities

                Dim vConta = ctx.TB_CONTA.Single(Function(c) c.COD_CONTA = vCodConta)

                ctx.TB_CONTA.Remove(vConta)

                ctx.SaveChanges()

            End Using

            MessageBox.Show("Conta excluída com sucesso.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return True

        Catch ex As Exception

            MessageBox.Show("Erro ao excluir conta.", "Erro::sb_Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return False

        End Try

    End Function

    Private Function fn_Excluir_Parcelamento() As Boolean

        Dim vSeq As Integer

        Try

            If IsNothing(dgvGrc.CurrentRow.Cells("col_seq_parcelamento").Value) Then

                Return True

                Exit Function

            End If

            vSeq = dgvGrc.CurrentRow.Cells("col_seq_parcelamento").Value

            If (MessageBox.Show("Deseja excluir o parcelamento?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No) Then

                Return True

                Exit Function

            End If

            Using ctx = New FINANCEIROEntities

                Dim vParc = ctx.TB_PARCELAMENTO.Single(Function(p) p.SEQ_PARCELAMENTO = vSeq)

                ctx.TB_PARCELAMENTO.Remove(vParc)

                ctx.SaveChanges()

            End Using

            MessageBox.Show("Parcelamento excluído com sucesso.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Return True

        Catch ex As Exception

            MessageBox.Show("Erro ao excluir Parcelamento.", "Erro::Fn_Excluir_Parcelamento", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return False

        End Try

    End Function

    Private Function fn_Excluir_Titulo() As Boolean

        Dim vCodTitulo As Integer

        Try

            If IsNothing(dgvGrc.CurrentRow.Cells("col_cod_titulo").Value) Then

                Return True

                Exit Function

            End If

            vCodTitulo = dgvGrc.CurrentRow.Cells("col_cod_titulo").Value

            If (MessageBox.Show("Deseja excluir o título?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No) Then

                Return True

                Exit Function

            End If

            Using ctx = New FINANCEIROEntities

                Dim vTitulo = ctx.TB_TITULO.Single(Function(t) t.COD_TITULO = vCodTitulo)

                ctx.TB_TITULO.Remove(vTitulo)

                ctx.SaveChanges()

            End Using

            MessageBox.Show("Título excluído com sucesso.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Return True

        Catch ex As Exception

            MessageBox.Show("Erro ao excluir Título.", "Erro::Fn_Excluir_Titulo", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return False

        End Try

    End Function

    Private Function fn_Excluir_Lancamento() As Boolean

        Dim v_cod_lancamento As Integer

        Try

            If IsNothing(dgvGrc.CurrentRow.Cells("col_cod_lancamento").Value) Then

                Return True

                Exit Function

            End If

            v_cod_lancamento = dgvGrc.CurrentRow.Cells("col_cod_lancamento").Value

            If (MessageBox.Show("Deseja excluir o lançamento?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No) Then

                Return True

                Exit Function

            End If

            Using ctx = New FINANCEIROEntities

                Dim vLancamento = ctx.TB_LANCAMENTO.Single(Function(l) l.COD_LANCAMENTO = v_cod_lancamento)

                ctx.TB_LANCAMENTO.Remove(vLancamento)

                ctx.SaveChanges()

            End Using

            MessageBox.Show("Lançamento excluído com sucesso.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Return True

        Catch ex As Exception

            MessageBox.Show("Erro ao excluir Lançamento.", "Erro::fn_Excluir_Lancamento", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return False

        End Try

    End Function

    Private Function fn_Excluir_Cartao() As Boolean

        Dim v_cod_cartao As Integer

        Try

            If IsNothing(dgvGrc.CurrentRow.Cells("col_cod_cartao").Value) Then

                Return True

                Exit Function

            End If

            v_cod_cartao = dgvGrc.CurrentRow.Cells("col_cod_cartao").Value

            If (MessageBox.Show("Deseja excluir o cartão?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No) Then

                Return True

                Exit Function

            End If

            Using ctx = New FINANCEIROEntities

                Dim vCartao = ctx.TB_CARTAO.Single(Function(c) c.COD_CARTAO = v_cod_cartao)

                ctx.TB_CARTAO.Remove(vCartao)

                ctx.SaveChanges()

            End Using

            MessageBox.Show("Cartão excluído com sucesso.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Return True

        Catch ex As Exception

            MessageBox.Show("Erro ao excluir Cartão.", "Erro::fn_Excluir_Cartao", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return False

        End Try

    End Function

    Private Function fn_Excluir_Movimento() As Boolean

        Dim v_seq_movimento As Integer

        Try

            If IsNothing(dgvGrc.CurrentRow.Cells("col_seq_movimento").Value) Then

                Return True

                Exit Function

            End If

            v_seq_movimento = dgvGrc.CurrentRow.Cells("col_seq_movimento").Value

            If (MessageBox.Show("Deseja excluir o movimento?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No) Then

                Return True

                Exit Function

            End If

            Using ctx = New FINANCEIROEntities

                Dim vMovimento = ctx.TB_MOVIMENTO_CARTAO.Single(Function(m) m.SEQ_MOVIMENTO = v_seq_movimento)

                ctx.TB_MOVIMENTO_CARTAO.Remove(vMovimento)

                ctx.SaveChanges()

            End Using

            MessageBox.Show("Movimento excluído com sucesso.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Return True

        Catch ex As Exception

            MessageBox.Show("Erro ao excluir Cartão.", "Erro::fn_Excluir_Cartao", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return False

        End Try

    End Function

    Private Sub sb_Incluir()

        Try

            If vForm.name = "frmConta" Then

                vForm.codconta = 0

                vForm.ShowDialog()

                If vForm.Ok Then
                    sb_Preenche_Grc_Conta()
                End If

            ElseIf vForm.name = "frmTitulo" Then

                vForm.codigo = 0

                If Not IsDate("01/" + sttMesAno.Text) Then
                    vForm.vencimento = Now
                Else
                    vForm.vencimento = "01/" + sttMesAno.Text
                End If


                vForm.ShowDialog()

                If vForm.Ok Then

                    If sttMesAno.Text <> "" Then

                        sb_Adiciona_Titulo_Lista(vForm.codigo)

                    Else

                        sb_Preenche_Grc_Titulo()

                    End If

                    sb_Preenche_Arvore()

                End If


            ElseIf vForm.name = "frmLancamento" Then

                vForm.codigo = 0

                vForm.ShowDialog()

                If vForm.Ok Then
                    sb_Preenche_Grc_Lancamento()
                End If

            ElseIf vForm.name = "frmCadastroCartao" Then

                vForm.codigo = 0

                vForm.ShowDialog()

                If vForm.Ok Then
                    sb_Preenche_Grc_Cartao()
                End If

            ElseIf vForm.name = "frmMovimentoCartao" Then

                vForm.codigo = 0

                vForm.cod_titulo = IIf(IsNumeric(sttTitulo.Text), sttTitulo.Text, 0)

                vForm.cartao = sttTitulo.Tag

                vForm.ShowDialog()

                If vForm.Ok Then
                    sb_Pesquisa_Movimento()
                End If

            ElseIf vForm.name = "frmParcelamento" Then

                vForm.SEQ_PARCELAMENTO = 0

                vForm.ShowDialog()

                If vForm.Ok Then
                    Sb_Pesquisa_Parcelamento()
                End If

            End If

        Catch ex As Exception

            MessageBox.Show("Erro ao incluir " + vForm.text + ".", "Erro::sb_Incluir", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub sb_Editar()

        Try

            If dgvGrc.Rows.Count = 0 Then
                Exit Sub
            End If

            If vForm.name = "frmConta" Then

                vForm.codconta = dgvGrc.CurrentRow.Cells("col_cod_conta").Value

                vForm.ShowDialog()

                If vForm.Ok Then
                    sb_Preenche_Grc_Conta()
                End If

            ElseIf vForm.name = "frmTitulo" Then

                vForm.codigo = dgvGrc.CurrentRow.Cells("col_cod_titulo").Value

                vForm.ShowDialog()

                If vForm.Ok Then

                    If Not vForm.item_cartao Then

                        If sttMesAno.Text <> "" Then

                            sb_Pesquisa_Titulo()

                        Else

                            sb_Preenche_Grc_Titulo()

                        End If

                    Else

                        sttTitulo.Text = vForm.codigo
                        sttTitulo.Tag = vForm.cartao

                        vForm = New frmMovimentoCartao

                        sb_Configura_Resumo(tbpCartao)

                        sb_Configura_Menu_Grc(True)

                        sb_Configura_Tool_Movimento()

                        sb_Pesquisa_Movimento()

                    End If

                End If

            ElseIf vForm.name = "frmLancamento" Then

                vForm.codigo = dgvGrc.CurrentRow.Cells("col_cod_lancamento").Value

                vForm.ShowDialog()

                If vForm.Ok Then
                    sb_Preenche_Grc_Lancamento()
                End If

            ElseIf vForm.name = "frmCadastroCartao" Then

                vForm.codigo = dgvGrc.CurrentRow.Cells("col_cod_cartao").Value

                vForm.ShowDialog()

                If vForm.Ok Then
                    sb_Preenche_Grc_Cartao()
                End If

            ElseIf vForm.name = "frmMovimentoCartao" Then

                vForm.codigo = dgvGrc.CurrentRow.Cells("col_seq_movimento").Value

                vForm.ShowDialog()

                If vForm.Ok Then
                    sb_Pesquisa_Movimento()
                End If

            ElseIf vForm.name = "frmParcelamento" Then

                vForm.SEQ_PARCELAMENTO = dgvGrc.CurrentRow.Cells("col_seq_parcelamento").Value

                vForm.showdialog()

                If vForm.Ok Then
                    Sb_Pesquisa_Parcelamento()
                End If

            End If

        Catch ex As Exception

            MessageBox.Show("Erro ao editar " + vForm.text + ".", "Erro::sb_Editar", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub sb_Excluir()

        Dim vSucesso As Boolean = False

        Try

            If dgvGrc.Rows.Count = 0 Then
                Exit Sub
            End If

            If vForm.name = "frmConta" Then

                vSucesso = fn_Excluir_Conta()

                If vSucesso Then
                    sb_Preenche_Grc_Conta()
                End If

            ElseIf vForm.name = "frmTitulo" Then

                vSucesso = fn_Excluir_Titulo()

                If vSucesso Then

                    If sttMesAno.Text <> "" Then

                        sb_Pesquisa_Titulo()

                    Else

                        sb_Preenche_Grc_Titulo()

                    End If

                End If

            ElseIf vForm.name = "frmLancamento" Then

                vSucesso = fn_Excluir_Lancamento()

                If vSucesso Then
                    sb_Preenche_Grc_Lancamento()
                End If

            ElseIf vForm.name = "frmCadastroCartao" Then

                vSucesso = fn_Excluir_Cartao()

                If vSucesso Then
                    sb_Preenche_Grc_Cartao()
                End If

            ElseIf vForm.name = "frmMovimentoCartao" Then

                vSucesso = fn_Excluir_Movimento()

                If vSucesso Then
                    sb_Preenche_Grc_Movimento()
                End If

            ElseIf vForm.name = "frmParcelamento" Then

                vSucesso = Fn_Excluir_Parcelamento()

                If vSucesso Then
                    Sb_Pesquisa_Parcelamento()
                End If

            End If

        Catch ex As Exception

            MessageBox.Show("Erro ao tentar excluir registro", "Erro::sb_Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub imnTitulo_Click(sender As Object, e As EventArgs) Handles imnTitulo.Click

        sb_Titulo()

    End Sub

    Private Sub sb_Titulo()

        vForm = New frmTitulo

        sb_Configura_Resumo(tbpTitulo)

        sb_Configura_Menu_Grc(True)

        sb_Configura_Tool_Titulo()

        sb_Pesquisa_Titulo()

    End Sub

    Private Sub sb_Parcelamento()

        vForm = New frmParcelamento

        sb_Configura_Menu_Grc(True)

        sb_Pesquisa_Parcelamento()

    End Sub

    Private Sub stbPesquisar_Click(sender As Object, e As EventArgs) Handles stbPesquisar.Click

        If Not IsDate("01/" + sttMesAno.Text) Then
            MessageBox.Show("Favor informar mês/ano.", "Pesquisar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        sb_Pesquisa_Titulo()

    End Sub

    Private Sub sb_Pesquisa_Parcelamento()

        Dim vLinha As String()
        Dim vSituacao As String

        Try

            Using ctx = New FINANCEIROEntities

                Dim vParc = (From p In ctx.vw_parcelamento
                             Select p.seq_parcelamento _
                                 , p.descricao _
                                 , p.qtd_parcela _
                                 , p.dat_inicio _
                                 , p.valor _
                                 , p.qtd_parcela_paga _
                                 , p.valor_pago _
                                 , p.qtd_mes _
                                 , p.situacao).ToList

                Sb_Configura_Grc(grc.parcelamento)

                For Each vReg In vParc

                    If vReg.situacao = 1 Then


                        vSituacao = "Em Dia"


                    ElseIf vReg.situacao = 2 Then


                        vSituacao = "Parcialmento Em Dia"


                    ElseIf vReg.situacao = 3 Then


                        vSituacao = "Parcialmente Quitado"


                    ElseIf vReg.situacao = 4 Then


                        vSituacao = "Atrasado"


                    ElseIf vReg.situacao = 5 Then


                        vSituacao = "Quitado"


                    ElseIf vReg.situacao = 6 Then


                        vSituacao = "Renegociado"


                    ElseIf vReg.situacao = 7 Then


                        vSituacao = "Cancelado"

                    Else


                        vSituacao = ""


                    End If

                    vLinha = {vReg.seq_parcelamento _
                        , vReg.descricao _
                        , FormatNumber(vReg.valor, 2) _
                        , vReg.qtd_parcela _
                        , vReg.dat_inicio _
                        , vReg.qtd_parcela_paga _
                        , FormatNumber(vReg.valor_pago, 2) _
                        , FormatNumber(vReg.valor - vReg.valor_pago, 2) _
                        , vSituacao}

                    dgvGrc.Rows.Add(vLinha)

                Next

            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao preencher a lista de parcelamentos.", "Erro::Sb_Pesquisa_Parcelamento", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub sb_Pesquisa_Titulo()

        Dim vLinha As String()
        Dim v_dat_inicio As Date = "01/" + sttMesAno.Text
        Dim v_dat_final As Date = fn_UltimoDia_Mes(v_dat_inicio)

        Try

            Using ctx = New FINANCEIROEntities

                Dim vTitulo = (From titulo In ctx.vw_titulo
                               Where ((titulo.DAT_PLANEJAMENTO >= v_dat_inicio And titulo.DAT_PLANEJAMENTO <= v_dat_final) And titulo.DAT_PAGAMENTO Is Nothing) _
                               Or (titulo.DAT_PAGAMENTO >= v_dat_inicio And titulo.DAT_PAGAMENTO <= v_dat_final)
                               Order By titulo.TIPO, titulo.NUM_ORDEM, titulo.DAT_PAGAMENTO, titulo.COD_TITULO
                               Select titulo.COD_TITULO _
                                , NOME_CONTA = titulo.DESC_RAIZ _
                                , titulo.DAT_VENCIMENTO _
                                , titulo.DAT_PAGAMENTO _
                                , titulo.DESCRICAO _
                                , titulo.VALOR _
                                , titulo.VAL_TITULO _
                                , titulo.VAL_RESTANTE _
                                , titulo.COD_LANCAMENTO _
                                , titulo.VAL_PAGO _
                                , titulo.TIPO _
                                , titulo.VAL_COR).ToList

                Sb_Configura_Grc(grc.titulo)

                For Each vReg In vTitulo

                    vLinha = {vReg.COD_TITULO _
                        , vReg.NOME_CONTA _
                        , vReg.TIPO _
                        , vReg.DESCRICAO _
                        , vReg.DAT_VENCIMENTO _
                        , IIf(vReg.DAT_PAGAMENTO.GetValueOrDefault.Year = 0, "", vReg.DAT_PAGAMENTO) _
                        , FormatNumber(vReg.VAL_TITULO, 2) _
                        , FormatNumber(vReg.VAL_PAGO, 2) _
                        , FormatNumber(vReg.VAL_RESTANTE, 2) _
                        , vReg.COD_LANCAMENTO.GetValueOrDefault _
                        , vReg.VAL_COR}

                    dgvGrc.Rows.Add(vLinha)

                Next

            End Using

            sb_Preenche_Resumo_Titulo_Geral()

            sb_Preenche_Resumo_Titulo_Mes(v_dat_inicio)

            sb_Preenche_Lista_Conta(v_dat_inicio)

        Catch ex As Exception
            MessageBox.Show("Erro ao preencher lista títulos.", "Erro::sb_Pesquisa_Titulo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub sb_Adiciona_Titulo_Lista(ByVal p_cod_titulo As Long)

        Dim vLinha As String()
        Dim v_dat_inicio As Date = "01/" + sttMesAno.Text
        Dim v_dat_final As Date = fn_UltimoDia_Mes(v_dat_inicio)

        Try

            Using ctx = New FINANCEIROEntities

                Dim vTitulo = (From titulo In ctx.vw_titulo
                               Where titulo.COD_TITULO = p_cod_titulo
                               Select titulo.COD_TITULO _
                                , NOME_CONTA = titulo.DESC_RAIZ _
                                , titulo.DAT_VENCIMENTO _
                                , titulo.DAT_PAGAMENTO _
                                , titulo.DESCRICAO _
                                , titulo.VALOR _
                                , titulo.VAL_TITULO _
                                , titulo.VAL_RESTANTE _
                                , titulo.COD_LANCAMENTO _
                                , titulo.VAL_PAGO _
                                , titulo.TIPO _
                                , titulo.VAL_COR).SingleOrDefault

                vLinha = {vTitulo.COD_TITULO _
                        , vTitulo.NOME_CONTA _
                        , vTitulo.TIPO _
                        , vTitulo.DESCRICAO _
                        , vTitulo.DAT_VENCIMENTO _
                        , IIf(vTitulo.DAT_PAGAMENTO.GetValueOrDefault.Year = 0, "", vTitulo.DAT_PAGAMENTO) _
                        , FormatNumber(vTitulo.VAL_TITULO, 2) _
                        , FormatNumber(vTitulo.VAL_PAGO, 2) _
                        , FormatNumber(vTitulo.VAL_RESTANTE, 2) _
                        , vTitulo.COD_LANCAMENTO.GetValueOrDefault _
                        , vTitulo.VAL_COR}

                dgvGrc.Rows.Add(vLinha)
                dgvGrc.FirstDisplayedScrollingRowIndex = dgvGrc.Rows.Count - 1

            End Using

            sb_Preenche_Resumo_Titulo_Geral()

            sb_Preenche_Resumo_Titulo_Mes(v_dat_inicio)

            sb_Preenche_Lista_Conta(v_dat_inicio)

        Catch ex As Exception
            MessageBox.Show("Erro ao adicionar título lista.", "Erro::sb_Adicionar_Titulo_Lista", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub sb_Preenche_Lista_Conta(ByVal p_data As Date)

        Dim vLinha As ListViewItem
        Dim v_dt_inicio As Date = fn_PrimeiroDia_Mes(p_data)
        Dim v_dt_final As Date = fn_UltimoDia_Mes(p_data)

        Try

            Using ctx = New FINANCEIROEntities

                Dim vGrupo = From titulo In ctx.vw_titulo
                             Where titulo.DAT_PAGAMENTO >= v_dt_inicio And titulo.DAT_PAGAMENTO <= v_dt_final
                             Group titulo By titulo.DESC_RAIZ, titulo.TIPO Into TotalValor = Sum(titulo.VAL_PAGO)
                             Order By TIPO, DESC_RAIZ
                             Select DESC_RAIZ, TIPO, TotalValor

                lstConta.Items.Clear()

                For Each vReg In vGrupo.ToList

                    vLinha = New ListViewItem(vReg.DESC_RAIZ)
                    vLinha.SubItems.Add(FormatNumber(vReg.TotalValor, 2))
                    vLinha.SubItems.Add(vReg.TIPO)
                    lstConta.Items.Add(vLinha)

                Next

                sb_Preenche_Grafico_Credito()

                sb_Preenche_Grafico_Debito()

            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao preencher lista conta.", "Erro::sb_Preenche_Lista_Conta", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub sb_Preenche_Grafico_Credito()
        Try

            Dim xConta As String()
            Dim yTotal As Double()
            Dim v_contador As Integer
            Dim v_linha As ListViewItem

            ReDim xConta(0)
            ReDim yTotal(0)

            For Each v_linha In lstConta.Items

                If v_linha.SubItems.Item(2).Text = "C" Then

                    xConta(v_contador) = v_linha.Text
                    yTotal(v_contador) = v_linha.SubItems.Item(1).Text

                    v_contador += 1

                    ReDim Preserve xConta(v_contador)
                    ReDim Preserve yTotal(v_contador)

                End If

            Next


            chtCredito.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie

            chtCredito.Titles.Clear()

            chtCredito.Titles.Add("Crédito")

            chtCredito.Palette = ChartColorPalette.BrightPastel

            chtCredito.Series(0).Points.DataBindXY(xConta, yTotal)

            chtCredito.Series(0).IsValueShownAsLabel = True

        Catch ex As Exception
            MessageBox.Show("Erro ao preencher gráfico crédito.", "Erro::sb_Preenche_Grafico_Credito", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub sb_Preenche_Grafico_Debito()
        Try

            Dim xConta As String()
            Dim yTotal As Double()
            Dim v_contador As Integer
            Dim v_linha As ListViewItem

            ReDim xConta(0)
            ReDim yTotal(0)

            For Each v_linha In lstConta.Items

                If v_linha.SubItems.Item(2).Text = "D" Then

                    xConta(v_contador) = v_linha.Text
                    yTotal(v_contador) = v_linha.SubItems.Item(1).Text

                    v_contador += 1

                    ReDim Preserve xConta(v_contador)
                    ReDim Preserve yTotal(v_contador)

                End If

            Next


            chtDebito.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie

            chtDebito.Titles.Clear()

            chtDebito.Titles.Add("Débito")

            chtDebito.Palette = ChartColorPalette.BrightPastel

            chtDebito.Series(0).Points.DataBindXY(xConta, yTotal)

            chtDebito.Series(0).IsValueShownAsLabel = True

        Catch ex As Exception
            MessageBox.Show("Erro ao preencher gráfico débito.", "Erro::sb_Preenche_Grafico_Debito", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub sb_Preenche_Resumo_Cartao(ByVal p_titulo As Long)

        Try

            Dim v_row As DataGridViewRow
            Dim v_total As Decimal

            For Each v_row In dgvGrc.Rows

                v_total += v_row.Cells("col_valor").Value

            Next

            txt_total_cartao.Text = v_total

        Catch ex As Exception
            MessageBox.Show("Erro ao preencher resumo cartão.", "Erro::sb_Preenche_Resumo_Cartao", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub sb_Preenche_Resumo_Titulo_Geral()
        Try

            Dim v_caixa As Decimal = fn_Credito() - fn_Pagamento()

            txt_caixa_geral.Text = FormatCurrency(v_caixa, 2)

        Catch ex As Exception
            MessageBox.Show("Erro ao preencher resumo título.", "Erro::sb_Preenche_Resumo_Titulo_Geral", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub sb_Preenche_Resumo_Titulo_Mes(ByVal p_data As Date)

        Try

            Dim v_dt_inicio As Date = fn_PrimeiroDia_Mes(p_data)
            Dim v_dt_final As Date = fn_UltimoDia_Mes(p_data)

            'valores
            Dim v_receita As Decimal = fn_Credito(v_dt_inicio, v_dt_final)
            Dim v_despesa As Decimal = fn_Debito(v_dt_inicio, v_dt_final)
            Dim v_pago As Decimal = fn_Pagamento(v_dt_inicio, v_dt_final)
            Dim v_apagar As Decimal = fn_APagar(v_dt_inicio, v_dt_final)
            Dim v_saldo As Decimal = v_receita - v_pago

            'receita
            txt_receita_mes.Text = FormatCurrency(v_receita, 2)

            'total despesas no mes
            txt_despesa_mes.Text = FormatCurrency(v_despesa, 2)

            'total pago mes
            txt_pago_mes.Text = FormatCurrency(v_pago, 2)

            'total a pagar
            txt_apagar_mes.Text = FormatCurrency(v_apagar, 2)

            'saldo
            txt_saldo_mes.Text = FormatCurrency(v_saldo, 2)

            'sobrando
            If v_saldo < 0 Then
                txt_saldo_mes.BackColor = Color.Red
                txt_saldo_mes.ForeColor = Color.White
            ElseIf v_saldo > 0 Then
                txt_saldo_mes.BackColor = Color.Blue
                txt_saldo_mes.ForeColor = Color.White
            Else
                txt_saldo_mes.BackColor = DefaultBackColor
                txt_saldo_mes.ForeColor = DefaultForeColor
            End If

            'planejamento
            txt_planejamento.Text = FormatCurrency(0, 2)

        Catch ex As Exception
            MessageBox.Show("Erro ao preencher resumo título.", "Erro::sb_Preenche_Resumo_Titulo_Mes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub sb_Pesquisa_Conta()

        Dim vLinha As String()
        Dim v_cod_conta As Integer = 0

        If IsNumeric(sttRaiz.Text) Then
            v_cod_conta = sttRaiz.Text
        End If

        Try

            Using ctx = New FINANCEIROEntities

                Dim vConta = (From conta In ctx.TB_CONTA Where conta.COD_CONTA_RAIZ = v_cod_conta Order By conta.NUM_ORDEM).ToList

                sb_Configura_Grc(grc.conta)

                For Each vReg As TB_CONTA In vConta

                    vLinha = {vReg.COD_CONTA, vReg.DESCRICAO, IIf(vReg.TIPO = "D", "Débito", "Crédito"), vReg.NUM_ORDEM.GetValueOrDefault}

                    dgvGrc.Rows.Add(vLinha)

                Next

            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao preencher lista conta.", "Erro::sb_Pesquisa_Conta", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub sb_Pesquisa_Movimento()

        Dim vLinha As String()
        Dim v_cod_titulo As Long = sttTitulo.Text

        Try

            Using ctx = New FINANCEIROEntities

                Dim vMovimento = (From mov In ctx.TB_MOVIMENTO_CARTAO
                                  Join cartao In ctx.TB_CARTAO On cartao.COD_CARTAO Equals mov.COD_CARTAO
                                  Join conta In ctx.TB_CONTA On conta.COD_CONTA Equals mov.COD_CONTA
                                  Join tit In ctx.TB_TITULO On tit.COD_TITULO Equals mov.COD_TITULO
                                  Where mov.COD_TITULO = v_cod_titulo
                                  Order By mov.DAT_MOVIMENTO
                                  Select mov.SEQ_MOVIMENTO, DESC_CARTAO = cartao.DESCRICAO, DESC_CONTA = conta.DESCRICAO, DESC_TITULO = tit.DESCRICAO, mov.DESCRICAO, mov.DAT_MOVIMENTO, mov.VALOR, mov.NUM_PARCELA).ToList

                sb_Configura_Grc(grc.movimento)

                For Each vReg In vMovimento

                    vLinha = {vReg.SEQ_MOVIMENTO, vReg.DESC_CARTAO, vReg.DESC_CONTA, vReg.DESC_TITULO, vReg.DESCRICAO, vReg.DAT_MOVIMENTO, FormatNumber(vReg.VALOR, 2), vReg.NUM_PARCELA.GetValueOrDefault}

                    dgvGrc.Rows.Add(vLinha)

                Next

                sb_Preenche_Resumo_Cartao(v_cod_titulo)

            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao pesquisar movimento.", "Erro::sb_Pesquisa_Movimento", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub stbPesquisarRaiz_Click(sender As Object, e As EventArgs) Handles stbPesquisarRaiz.Click
        sb_Pesquisa_Conta()
    End Sub

    Private Sub imnCartaoCadastro_Click(sender As Object, e As EventArgs) Handles imnCartaoCadastro.Click

        vForm = New frmCadastroCartao

        sb_Configura_Menu_Grc(True)

        sb_Preenche_Grc_Cartao()

    End Sub

    Private Sub imnCartaoMovimento_Click(sender As Object, e As EventArgs) Handles imnCartaoMovimento.Click

        vForm = New frmMovimentoCartao

        sb_Configura_Menu_Grc(True)

        sb_Configura_Tool_Movimento()

        sb_Preenche_Grc_Movimento()

    End Sub

    Private Sub dgvGrc_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvGrc.RowsAdded

        If vForm.name = "frmTitulo" Then

            If dgvGrc.Rows(e.RowIndex).Cells("col_cod_lancamento").Value > 0 Then
                dgvGrc.Rows(e.RowIndex).Cells("col_lancamento").Value = img.Images.Item("checked")
            End If

            dgvGrc.Rows(e.RowIndex).DefaultCellStyle.BackColor = ColorTranslator.FromHtml(dgvGrc.Rows(e.RowIndex).Cells("col_cor").Value)


        ElseIf vForm.name = "frmParcelamento" Then

            'to-do

        End If

    End Sub

    Private Sub stbPesquisarTitulo_Click(sender As Object, e As EventArgs) Handles stbPesquisarTitulo.Click

        If Not IsNumeric(sttTitulo.Text) Then
            MessageBox.Show("Favor informar um número.", "CFF", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        sb_Pesquisa_Movimento()

    End Sub

    Private Sub imnMovimento_Click(sender As Object, e As EventArgs) Handles imnMovimento.Click

        sb_Configura_Resumo(tbpCartao)

    End Sub

    Private Sub sb_Configura_Resumo(Optional ByVal pAba As TabPage = Nothing)


        tbpCartao.Visible = False

        tbpTitulo.Visible = False

        If Not pAba Is Nothing Then
            tbcResumo.SelectTab(pAba)
            pAba.Visible = True
        End If

    End Sub

    Private Sub sb_Preenche_Arvore()
        Try

            Dim v_node As TreeNode
            Dim v_node_child As TreeNode

            Using ctx = New FINANCEIROEntities

                Dim vGrupoMes = From titulo In ctx.TB_TITULO
                                Group titulo By ano = Year(titulo.DAT_VENCIMENTO), mes = Month(titulo.DAT_VENCIMENTO) Into Group
                                Order By ano, mes
                                Select ano, mes

                Dim vGrupoAno = From a In vGrupoMes
                                Group a By ga = a.ano Into Group
                                Select ga

                trwPrincipal.Nodes("nd_titulo").Nodes.Clear()

                'incluindo os anos
                For Each vAno In vGrupoAno.ToList

                    v_node = New TreeNode(vAno.ToString)

                    v_node.Name = vAno.ToString

                    'incluindo os meses
                    Dim vGrpMes = From m In vGrupoMes
                                  Where m.ano = vAno
                                  Select m.mes

                    For Each vMes In vGrpMes.ToList

                        v_node_child = New TreeNode(vMes.ToString)

                        v_node_child.Name = vMes.ToString

                        v_node_child.Tag = CInt(vMes).ToString + "/" + vAno.ToString

                        v_node.Nodes.Add(v_node_child)

                    Next

                    trwPrincipal.Nodes("nd_titulo").Nodes.Add(v_node)

                Next

            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao preencher árvore.", "Erro::sb_Preenche_Arvore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub trwPrincipal_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles trwPrincipal.AfterSelect

        Try

            If e.Node.Name = "nd_total_conta" Then

                sb_Relatorio_Total_Por_Conta()

            ElseIf e.Node.Parent.Parent.Name = "nd_titulo" Then

                sttMesAno.Text = e.Node.Tag

                sb_Titulo()

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub dgvGrc_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGrc.CellValueChanged


        Try


            If dgvGrc.Columns(dgvGrc.CurrentCell.ColumnIndex).Name = "col_planejamento" Then


                If dgvGrc.CurrentRow.Cells("col_planejamento").Value Then


                    txt_planejamento.Text = CDec(IIf(IsNumeric(txt_planejamento.Text), txt_planejamento.Text, 0)) + dgvGrc.CurrentRow.Cells("col_saldo").Value


                Else


                    txt_planejamento.Text = CDec(IIf(IsNumeric(txt_planejamento.Text), txt_planejamento.Text, 0)) - dgvGrc.CurrentRow.Cells("col_saldo").Value


                End If


                txt_planejamento.Text = FormatCurrency(txt_planejamento.Text)


            End If


        Catch ex As Exception


        End Try


    End Sub

    Private Sub dgvGrc_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvGrc.CurrentCellDirtyStateChanged


        If dgvGrc.Columns(dgvGrc.CurrentCell.ColumnIndex).Name = "col_planejamento" Then


            If dgvGrc.IsCurrentCellDirty Then


                dgvGrc.CommitEdit(DataGridViewDataErrorContexts.Commit)


            End If


        End If


    End Sub

    Private Sub dgvGrc_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvGrc.CellFormatting


        If dgvGrc.Columns(e.ColumnIndex).Name = "col_valor" Then


            If e.Value = 0 Then


                e.CellStyle.ForeColor = Color.Red


            End If


        End If


    End Sub

    Private Sub sb_Relatorio_Total_Por_Conta()

        'Dim vLinha As String()

        Try

            Using ctx = New FINANCEIROEntities

                'Dim vTitulo = (From tc In ctx.vw_total_conta
                '               Select tc.desc_raiz, tc.total).ToList

                'sb_Configura_Grc(grc.titulo)

                'For Each vReg In vTitulo

                '    vLinha = {vReg.desc_raiz _
                '        , vReg.total}

                '    dgvGrc.Rows.Add(vLinha)

                'Next

            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao preencher relatório.", "Erro::sb_Relatorio_Total_Por_Conta", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ImnParcelamento_Click(sender As Object, e As EventArgs) Handles ImnParcelamento.Click
        Call Sb_Parcelamento()
    End Sub
End Class
