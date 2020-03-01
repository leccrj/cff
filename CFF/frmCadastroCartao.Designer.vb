<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroCartao
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.mskNumero = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDiaVencimento = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtObservacao = New System.Windows.Forms.TextBox()
        Me.cmdSair = New System.Windows.Forms.Button()
        Me.cmdGravar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_conta = New System.Windows.Forms.ComboBox()
        Me.cmb_subconta = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtCodigo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(386, 51)
        Me.Panel1.TabIndex = 0
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.Silver
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigo.ForeColor = System.Drawing.Color.White
        Me.txtCodigo.Location = New System.Drawing.Point(64, 18)
        Me.txtCodigo.MaxLength = 3
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(38, 13)
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.TabStop = False
        Me.txtCodigo.Text = "000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descrição*:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Número*:"
        '
        'txtDescricao
        '
        Me.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescricao.Location = New System.Drawing.Point(102, 78)
        Me.txtDescricao.MaxLength = 50
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(249, 20)
        Me.txtDescricao.TabIndex = 0
        '
        'mskNumero
        '
        Me.mskNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskNumero.Location = New System.Drawing.Point(102, 104)
        Me.mskNumero.Mask = "9999.9999.9999.9999"
        Me.mskNumero.Name = "mskNumero"
        Me.mskNumero.Size = New System.Drawing.Size(118, 20)
        Me.mskNumero.TabIndex = 1
        Me.mskNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mskNumero.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Dia Vencimento*:"
        '
        'txtDiaVencimento
        '
        Me.txtDiaVencimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiaVencimento.Location = New System.Drawing.Point(102, 130)
        Me.txtDiaVencimento.MaxLength = 2
        Me.txtDiaVencimento.Name = "txtDiaVencimento"
        Me.txtDiaVencimento.Size = New System.Drawing.Size(39, 20)
        Me.txtDiaVencimento.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Observação:"
        '
        'txtObservacao
        '
        Me.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservacao.Location = New System.Drawing.Point(13, 247)
        Me.txtObservacao.MaxLength = 150
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(364, 65)
        Me.txtObservacao.TabIndex = 3
        '
        'cmdSair
        '
        Me.cmdSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSair.Location = New System.Drawing.Point(298, 321)
        Me.cmdSair.Name = "cmdSair"
        Me.cmdSair.Size = New System.Drawing.Size(74, 21)
        Me.cmdSair.TabIndex = 5
        Me.cmdSair.Text = "Sair"
        Me.cmdSair.UseVisualStyleBackColor = True
        '
        'cmdGravar
        '
        Me.cmdGravar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdGravar.Location = New System.Drawing.Point(218, 321)
        Me.cmdGravar.Name = "cmdGravar"
        Me.cmdGravar.Size = New System.Drawing.Size(74, 21)
        Me.cmdGravar.TabIndex = 4
        Me.cmdGravar.Text = "Gravar"
        Me.cmdGravar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Conta:"
        '
        'cmb_conta
        '
        Me.cmb_conta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_conta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_conta.FormattingEnabled = True
        Me.cmb_conta.Location = New System.Drawing.Point(102, 156)
        Me.cmb_conta.Name = "cmb_conta"
        Me.cmb_conta.Size = New System.Drawing.Size(121, 21)
        Me.cmb_conta.TabIndex = 10
        '
        'cmb_subconta
        '
        Me.cmb_subconta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_subconta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_subconta.FormattingEnabled = True
        Me.cmb_subconta.Location = New System.Drawing.Point(102, 183)
        Me.cmb_subconta.Name = "cmb_subconta"
        Me.cmb_subconta.Size = New System.Drawing.Size(121, 21)
        Me.cmb_subconta.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 187)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "SubConta:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmCadastroCartao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 367)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmb_subconta)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmb_conta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdSair)
        Me.Controls.Add(Me.cmdGravar)
        Me.Controls.Add(Me.txtObservacao)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDiaVencimento)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.mskNumero)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCadastroCartao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cartão"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents mskNumero As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDiaVencimento As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtObservacao As TextBox
    Friend WithEvents cmdSair As Button
    Friend WithEvents cmdGravar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_conta As ComboBox
    Friend WithEvents cmb_subconta As ComboBox
    Friend WithEvents Label10 As Label
End Class
