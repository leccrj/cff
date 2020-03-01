<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLancamento
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtValorLancamento = New System.Windows.Forms.TextBox()
        Me.cmdGravar = New System.Windows.Forms.Button()
        Me.cmdSair = New System.Windows.Forms.Button()
        Me.txtObservacao = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtVencimento = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtConta = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdPesquisar = New System.Windows.Forms.Button()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdExcluir = New System.Windows.Forms.Button()
        Me.dtpData = New System.Windows.Forms.DateTimePicker()
        Me.chkPrevisao = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Data"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Valor pago"
        '
        'txtValorLancamento
        '
        Me.txtValorLancamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValorLancamento.Location = New System.Drawing.Point(74, 180)
        Me.txtValorLancamento.Name = "txtValorLancamento"
        Me.txtValorLancamento.Size = New System.Drawing.Size(100, 20)
        Me.txtValorLancamento.TabIndex = 1
        '
        'cmdGravar
        '
        Me.cmdGravar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdGravar.Location = New System.Drawing.Point(429, 304)
        Me.cmdGravar.Name = "cmdGravar"
        Me.cmdGravar.Size = New System.Drawing.Size(74, 21)
        Me.cmdGravar.TabIndex = 3
        Me.cmdGravar.Text = "Gravar"
        Me.cmdGravar.UseVisualStyleBackColor = True
        '
        'cmdSair
        '
        Me.cmdSair.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSair.Location = New System.Drawing.Point(509, 304)
        Me.cmdSair.Name = "cmdSair"
        Me.cmdSair.Size = New System.Drawing.Size(74, 21)
        Me.cmdSair.TabIndex = 4
        Me.cmdSair.Text = "Sair"
        Me.cmdSair.UseVisualStyleBackColor = True
        '
        'txtObservacao
        '
        Me.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservacao.Location = New System.Drawing.Point(9, 235)
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(574, 60)
        Me.txtObservacao.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Observação:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtVencimento)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtValor)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtConta)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtDescricao)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmdPesquisar)
        Me.GroupBox1.Controls.Add(Me.txtNumero)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 116)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'txtVencimento
        '
        Me.txtVencimento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVencimento.Location = New System.Drawing.Point(289, 75)
        Me.txtVencimento.Name = "txtVencimento"
        Me.txtVencimento.ReadOnly = True
        Me.txtVencimento.Size = New System.Drawing.Size(68, 13)
        Me.txtVencimento.TabIndex = 24
        Me.txtVencimento.TabStop = False
        Me.txtVencimento.Text = "00/00/0000"
        Me.txtVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(220, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Vencimento"
        '
        'txtValor
        '
        Me.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtValor.Location = New System.Drawing.Point(84, 75)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.ReadOnly = True
        Me.txtValor.Size = New System.Drawing.Size(100, 13)
        Me.txtValor.TabIndex = 22
        Me.txtValor.TabStop = False
        Me.txtValor.Text = "valor"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Valor"
        '
        'txtConta
        '
        Me.txtConta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConta.Location = New System.Drawing.Point(454, 48)
        Me.txtConta.Name = "txtConta"
        Me.txtConta.ReadOnly = True
        Me.txtConta.Size = New System.Drawing.Size(100, 13)
        Me.txtConta.TabIndex = 20
        Me.txtConta.TabStop = False
        Me.txtConta.Text = "conta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(413, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Conta"
        '
        'txtDescricao
        '
        Me.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescricao.Location = New System.Drawing.Point(84, 48)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ReadOnly = True
        Me.txtDescricao.Size = New System.Drawing.Size(312, 13)
        Me.txtDescricao.TabIndex = 18
        Me.txtDescricao.TabStop = False
        Me.txtDescricao.Text = "descrição"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Descrição"
        '
        'cmdPesquisar
        '
        Me.cmdPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPesquisar.Location = New System.Drawing.Point(190, 21)
        Me.cmdPesquisar.Name = "cmdPesquisar"
        Me.cmdPesquisar.Size = New System.Drawing.Size(74, 21)
        Me.cmdPesquisar.TabIndex = 16
        Me.cmdPesquisar.TabStop = False
        Me.cmdPesquisar.Text = "Pesquisar"
        Me.cmdPesquisar.UseVisualStyleBackColor = True
        Me.cmdPesquisar.Visible = False
        '
        'txtNumero
        '
        Me.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumero.Location = New System.Drawing.Point(84, 21)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.ReadOnly = True
        Me.txtNumero.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero.TabIndex = 1
        Me.txtNumero.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Título"
        '
        'cmdExcluir
        '
        Me.cmdExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdExcluir.ForeColor = System.Drawing.Color.Red
        Me.cmdExcluir.Location = New System.Drawing.Point(9, 304)
        Me.cmdExcluir.Name = "cmdExcluir"
        Me.cmdExcluir.Size = New System.Drawing.Size(135, 21)
        Me.cmdExcluir.TabIndex = 5
        Me.cmdExcluir.Text = "Excluir Pagamento"
        Me.cmdExcluir.UseVisualStyleBackColor = True
        '
        'dtpData
        '
        Me.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpData.Location = New System.Drawing.Point(74, 141)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Size = New System.Drawing.Size(100, 20)
        Me.dtpData.TabIndex = 0
        '
        'chkPrevisao
        '
        Me.chkPrevisao.AutoSize = True
        Me.chkPrevisao.Location = New System.Drawing.Point(255, 143)
        Me.chkPrevisao.Name = "chkPrevisao"
        Me.chkPrevisao.Size = New System.Drawing.Size(110, 17)
        Me.chkPrevisao.TabIndex = 20
        Me.chkPrevisao.Text = "Atualizar Previsão"
        Me.chkPrevisao.UseVisualStyleBackColor = True
        '
        'frmLancamento
        '
        Me.AcceptButton = Me.cmdGravar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdSair
        Me.ClientSize = New System.Drawing.Size(595, 336)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkPrevisao)
        Me.Controls.Add(Me.dtpData)
        Me.Controls.Add(Me.cmdExcluir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtObservacao)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdSair)
        Me.Controls.Add(Me.cmdGravar)
        Me.Controls.Add(Me.txtValorLancamento)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmLancamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagamento"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtValorLancamento As TextBox
    Friend WithEvents cmdGravar As Button
    Friend WithEvents cmdSair As Button
    Friend WithEvents txtObservacao As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtVencimento As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtConta As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmdPesquisar As Button
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdExcluir As Button
    Friend WithEvents dtpData As DateTimePicker
    Friend WithEvents chkPrevisao As CheckBox
End Class
