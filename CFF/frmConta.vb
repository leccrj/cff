Public Class frmConta

    Private mOk As Boolean
    Private mCodConta As Integer
    Private mCodContaRaiz As Integer

    Public Property cod_conta_raiz
        Get
            Return mCodContaRaiz
        End Get
        Set(value)
            mCodContaRaiz = value
        End Set
    End Property

    Public Property CodConta
        Get
            Return mCodConta
        End Get
        Set(value)
            mCodConta = value
        End Set
    End Property

    Public Property Ok
        Get
            Return mOk
        End Get
        Set(value)
            'mOk = value
        End Set
    End Property

    Private Sub frmConta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()

        If mCodConta > 0 Then
            sb_Carrega_Conta()
        Else
            sb_Limpa_Campos()
        End If

    End Sub

    Private Sub cmdSair_Click(sender As Object, e As EventArgs) Handles cmdSair.Click

        mOk = False

        Me.Close()

    End Sub

    Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click

        Dim vCampo As String = fn_Valida()

        If Not vCampo = "" Then
            MessageBox.Show("O campo " + vCampo + " é obrigatório.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        mOk = True

        If Not fn_Gravar() Then

            mOk = False

            MessageBox.Show("Erro ao gravar conta.", "Erro::cmdGravar_Click", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            MessageBox.Show("Conta gravada com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        Me.Close()

    End Sub

    Private Function fn_Incluir() As Boolean

        Try

            Using ctx = New FINANCEIROEntities

                Dim vConta As New TB_CONTA

                vConta.DESCRICAO = txtDescricao.Text.Trim.ToUpper
                vConta.TIPO = cmbTipo.Text.Substring(0, 1)
                vConta.OBSERVACAO = txtObservacao.Text.Trim
                vConta.NUM_ORDEM = txtOrdem.Text
                vConta.VAL_COR = ColorTranslator.ToHtml(cmdCor.BackColor)

                If mCodContaRaiz > 0 Then
                    vConta.COD_CONTA_RAIZ = mCodContaRaiz
                End If

                ctx.TB_CONTA.Add(vConta)

                ctx.SaveChanges()

            End Using

            Return True

        Catch ex As Exception

            Return False

        End Try

    End Function

    Private Function fn_Alterar() As Boolean

        Try

            Using ctx = New FINANCEIROEntities

                Dim vConta = (From conta In ctx.TB_CONTA Where conta.COD_CONTA = mCodConta).SingleOrDefault

                vConta.DESCRICAO = txtDescricao.Text.Trim.ToUpper
                vConta.TIPO = cmbTipo.Text.Substring(0, 1)
                vConta.OBSERVACAO = txtObservacao.Text.Trim
                vConta.NUM_ORDEM = txtOrdem.Text
                vConta.VAL_COR = ColorTranslator.ToHtml(cmdCor.BackColor)

                ctx.SaveChanges()

            End Using

            Return True

        Catch ex As Exception

            Return False

        End Try

    End Function

    Private Function fn_Gravar() As Boolean

        If mCodConta > 0 Then

            Return fn_Alterar()

        Else

            Return fn_Incluir()

        End If

    End Function

    Private Function fn_Valida() As String

        Dim vRetorno As String = ""

        If txtDescricao.Text.Trim = "" Then

            vRetorno = "Descrição"

        End If

        If cmbTipo.Text = "" Then

            vRetorno = "Tipo"

        End If

        If Not IsNumeric(txtOrdem.Text) Then

            vRetorno = "Ordem"

        End If

        Return vRetorno

    End Function

    Private Sub sb_Carrega_Conta()

        Try

            Using ctx = New FINANCEIROEntities

                Dim vConta = (From conta In ctx.TB_CONTA Where conta.COD_CONTA = mCodConta).SingleOrDefault

                txtDescricao.Text = vConta.DESCRICAO

                cmbTipo.Text = IIf(vConta.TIPO = "D", "Débito", "Crédito")

                txtOrdem.Text = vConta.NUM_ORDEM.GetValueOrDefault

                txtObservacao.Text = vConta.OBSERVACAO

                txtCodigo.Text = Format(vConta.COD_CONTA, "000")

                cmdCor.BackColor = ColorTranslator.FromHtml(vConta.VAL_COR)

            End Using

        Catch ex As Exception

            MessageBox.Show("Erro ao carregar conta.", "Erro::sb_Carrega_Conta", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub frmConta_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        sb_Limpa_Campos()
    End Sub

    Private Sub sb_Limpa_Campos()
        txtDescricao.Text = String.Empty
        txtObservacao.Text = String.Empty
        cmbTipo.SelectedIndex = -1
        txtOrdem.Text = 0
        cmdCor.BackColor = BackColor
        txtCodigo.Text = String.Empty
        mCodConta = 0
    End Sub

    Private Sub cmdCor_Click(sender As Object, e As EventArgs) Handles cmdCor.Click
        corDlg.Color = cmdCor.BackColor
        corDlg.ShowDialog()
        cmdCor.BackColor = corDlg.Color
    End Sub
End Class