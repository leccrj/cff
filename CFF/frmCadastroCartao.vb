Public Class frmCadastroCartao
    Private m_empty As String = String.Empty
    Private m_cod_cartao As Double
    Private m_ok As Boolean

    Public Property ok
        Get
            Return m_ok
        End Get
        Set(value)
            'm_ok = value 
        End Set
    End Property

    Public Property codigo
        Get
            Return m_cod_cartao
        End Get
        Set(value)
            m_cod_cartao = value
        End Set
    End Property

    Private Sub sb_Limpa_Tela()

        cmb_conta.SelectedIndex = -1
        cmb_subconta.DataSource = Nothing
        txtCodigo.Text = m_empty
        txtDescricao.Text = m_empty
        mskNumero.Text = m_empty
        txtDiaVencimento.Text = m_empty
        txtObservacao.Text = m_empty

    End Sub

    Private Sub sb_Preenche_Tela()

        Try

            Using ctx = New FINANCEIROEntities

                Dim vCartao = (From cartao In ctx.TB_CARTAO
                               Join conta In ctx.TB_CONTA On conta.COD_CONTA Equals cartao.COD_CONTA
                               Where cartao.COD_CARTAO = m_cod_cartao
                               Select cartao.COD_CARTAO, cartao.DESCRICAO, cartao.NUMERO, cartao.DIA_VENCIMENTO, cartao.OBSERVACAO, cartao.COD_CONTA, conta.COD_CONTA_RAIZ).SingleOrDefault

                txtCodigo.Text = vCartao.COD_CARTAO
                txtDescricao.Text = vCartao.DESCRICAO
                mskNumero.Text = vCartao.NUMERO
                txtDiaVencimento.Text = vCartao.DIA_VENCIMENTO
                txtObservacao.Text = vCartao.OBSERVACAO

                If vCartao.COD_CONTA_RAIZ IsNot Nothing Then

                    cmb_conta.SelectedValue = vCartao.COD_CONTA_RAIZ

                    sb_Preenche_Conta(cmb_subconta, Convert.ToDecimal(vCartao.COD_CONTA_RAIZ))

                    cmb_subconta.SelectedValue = vCartao.COD_CONTA

                Else

                    cmb_conta.SelectedValue = vCartao.COD_CONTA

                End If

            End Using

        Catch ex As Exception

            MessageBox.Show("Erro ao preencher tela.", "Erro::sb_Preenche_Tela", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub


    Private Sub frmCadastroCartao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToParent()

        sb_Preenche_Conta(cmb_conta)

        If m_cod_cartao > 0 Then

            sb_Preenche_Tela()

        Else

            sb_Limpa_Tela()

        End If

    End Sub


    Private Sub sb_Gravar()

        If Not fn_Valida() Then
            Exit Sub
        End If

        If m_cod_cartao > 0 Then

            sb_Alterar()

        Else

            sb_Incluir()

        End If

        Me.Close()

    End Sub

    Private Sub sb_Incluir()

        Try

            Using ctx = New FINANCEIROEntities

                Dim vCartao As New TB_CARTAO

                vCartao.DESCRICAO = txtDescricao.Text.Trim.ToUpper
                vCartao.NUMERO = mskNumero.Text
                vCartao.DIA_VENCIMENTO = txtDiaVencimento.Text
                vCartao.OBSERVACAO = txtObservacao.Text.Trim
                vCartao.DAT_CADASTRO = Now

                If cmb_subconta.SelectedValue = Nothing Then
                    vCartao.COD_CONTA = cmb_conta.SelectedValue
                Else
                    vCartao.COD_CONTA = cmb_subconta.SelectedValue
                End If


                ctx.TB_CARTAO.Add(vCartao)

                ctx.SaveChanges()

            End Using

            m_ok = True

            MessageBox.Show("Cartão gravado com sucesso.", "CFF", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            m_ok = False

            MessageBox.Show("Erro ao gravar Cartão.", "Erro::sb_Incluir", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub sb_Alterar()

        Try

            Using ctx = New FINANCEIROEntities

                Dim vCartao = (From cartao In ctx.TB_CARTAO Where cartao.COD_CARTAO = m_cod_cartao).SingleOrDefault

                vCartao.DESCRICAO = txtDescricao.Text.Trim.ToUpper
                vCartao.NUMERO = mskNumero.Text
                vCartao.DIA_VENCIMENTO = txtDiaVencimento.Text
                vCartao.OBSERVACAO = txtObservacao.Text.Trim

                If cmb_subconta.SelectedValue = Nothing Then
                    vCartao.COD_CONTA = cmb_conta.SelectedValue
                Else
                    vCartao.COD_CONTA = cmb_subconta.SelectedValue
                End If

                ctx.SaveChanges()

            End Using

            m_ok = True

            MessageBox.Show("Cartão gravado com sucesso.", "CFF", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            m_ok = False

            MessageBox.Show("Erro ao gravar Cartão.", "Erro::sb_Alterar", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click

        sb_Gravar()

    End Sub

    Private Sub cmdSair_Click(sender As Object, e As EventArgs) Handles cmdSair.Click

        m_ok = False

        Me.Close()

    End Sub

    Private Sub cmb_conta_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_conta.SelectionChangeCommitted
        sb_Preenche_Conta(cmb_subconta, cmb_conta.SelectedValue)
    End Sub

    Private Function fn_Valida() As Boolean

        If txtDescricao.Text = m_empty Then
            MessageBox.Show("O campo descrição é obrigatório.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If mskNumero.Text = m_empty Then
            MessageBox.Show("O campo número é obrigatório.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If Not IsNumeric(txtDiaVencimento.Text) Then
            MessageBox.Show("O campo dia vencimento é obrigatório.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        Return True

    End Function

    'Private Sub sb_Preenche_Conta()

    '    Try

    '        Using ctx = New FINANCEIROEntities

    '            cmb_conta.DataSource = (From conta In ctx.TB_CONTA Where conta.TIPO = "D" And Not conta.COD_CONTA_RAIZ.HasValue).ToList

    '            cmb_conta.DisplayMember = "DESCRICAO"

    '            cmb_conta.ValueMember = "COD_CONTA"

    '        End Using

    '    Catch ex As Exception

    '        MessageBox.Show("Erro " + ex.Message, "Erro::sb_Preenche_Conta", MessageBoxButtons.OK, MessageBoxIcon.Error)

    '    End Try

    'End Sub

End Class