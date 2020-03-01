<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimentoCartao
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
        Me.cmbSubConta = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbConta = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtObservacao = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdSair = New System.Windows.Forms.Button()
        Me.cmdGravar = New System.Windows.Forms.Button()
        Me.gbxGerarDebito = New System.Windows.Forms.GroupBox()
        Me.lblQtdParcela = New System.Windows.Forms.Label()
        Me.txtQtdParcela = New System.Windows.Forms.TextBox()
        Me.rdoCopiar = New System.Windows.Forms.RadioButton()
        Me.rdoParcelar = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.txtNumeroTitulo = New System.Windows.Forms.TextBox()
        Me.txtParcela = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbCartao = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpData = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTituloDespesa = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.gbxGerarDebito.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbSubConta
        '
        Me.cmbSubConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubConta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbSubConta.FormattingEnabled = True
        Me.cmbSubConta.Location = New System.Drawing.Point(401, 185)
        Me.cmbSubConta.Name = "cmbSubConta"
        Me.cmbSubConta.Size = New System.Drawing.Size(121, 21)
        Me.cmbSubConta.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(339, 189)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "SubConta"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbConta
        '
        Me.cmbConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbConta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbConta.FormattingEnabled = True
        Me.cmbConta.Location = New System.Drawing.Point(401, 158)
        Me.cmbConta.Name = "cmbConta"
        Me.cmbConta.Size = New System.Drawing.Size(121, 21)
        Me.cmbConta.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(339, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Conta"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Descrição"
        '
        'txtDescricao
        '
        Me.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescricao.Location = New System.Drawing.Point(104, 150)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(214, 20)
        Me.txtDescricao.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Data"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Valor"
        '
        'txtObservacao
        '
        Me.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservacao.Location = New System.Drawing.Point(12, 321)
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(542, 77)
        Me.txtObservacao.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 303)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Observação"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdSair
        '
        Me.cmdSair.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSair.Location = New System.Drawing.Point(475, 406)
        Me.cmdSair.Name = "cmdSair"
        Me.cmdSair.Size = New System.Drawing.Size(74, 21)
        Me.cmdSair.TabIndex = 11
        Me.cmdSair.Text = "Sair"
        Me.cmdSair.UseVisualStyleBackColor = True
        '
        'cmdGravar
        '
        Me.cmdGravar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdGravar.Location = New System.Drawing.Point(395, 406)
        Me.cmdGravar.Name = "cmdGravar"
        Me.cmdGravar.Size = New System.Drawing.Size(74, 21)
        Me.cmdGravar.TabIndex = 10
        Me.cmdGravar.Text = "Gravar"
        Me.cmdGravar.UseVisualStyleBackColor = True
        '
        'gbxGerarDebito
        '
        Me.gbxGerarDebito.Controls.Add(Me.lblQtdParcela)
        Me.gbxGerarDebito.Controls.Add(Me.txtQtdParcela)
        Me.gbxGerarDebito.Controls.Add(Me.rdoCopiar)
        Me.gbxGerarDebito.Controls.Add(Me.rdoParcelar)
        Me.gbxGerarDebito.Enabled = False
        Me.gbxGerarDebito.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbxGerarDebito.Location = New System.Drawing.Point(343, 74)
        Me.gbxGerarDebito.Name = "gbxGerarDebito"
        Me.gbxGerarDebito.Size = New System.Drawing.Size(212, 68)
        Me.gbxGerarDebito.TabIndex = 12
        Me.gbxGerarDebito.TabStop = False
        Me.gbxGerarDebito.Text = "Gerar Movimento Futuro"
        '
        'lblQtdParcela
        '
        Me.lblQtdParcela.AutoSize = True
        Me.lblQtdParcela.Location = New System.Drawing.Point(143, 42)
        Me.lblQtdParcela.Name = "lblQtdParcela"
        Me.lblQtdParcela.Size = New System.Drawing.Size(53, 13)
        Me.lblQtdParcela.TabIndex = 4
        Me.lblQtdParcela.Text = "parcela(s)"
        '
        'txtQtdParcela
        '
        Me.txtQtdParcela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQtdParcela.Location = New System.Drawing.Point(103, 37)
        Me.txtQtdParcela.Name = "txtQtdParcela"
        Me.txtQtdParcela.Size = New System.Drawing.Size(34, 20)
        Me.txtQtdParcela.TabIndex = 7
        Me.txtQtdParcela.TabStop = False
        '
        'rdoCopiar
        '
        Me.rdoCopiar.AutoSize = True
        Me.rdoCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoCopiar.Location = New System.Drawing.Point(24, 42)
        Me.rdoCopiar.Name = "rdoCopiar"
        Me.rdoCopiar.Size = New System.Drawing.Size(54, 17)
        Me.rdoCopiar.TabIndex = 6
        Me.rdoCopiar.Text = "Copiar"
        Me.rdoCopiar.UseVisualStyleBackColor = True
        '
        'rdoParcelar
        '
        Me.rdoParcelar.AutoSize = True
        Me.rdoParcelar.Checked = True
        Me.rdoParcelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoParcelar.Location = New System.Drawing.Point(24, 19)
        Me.rdoParcelar.Name = "rdoParcelar"
        Me.rdoParcelar.Size = New System.Drawing.Size(63, 17)
        Me.rdoParcelar.TabIndex = 5
        Me.rdoParcelar.TabStop = True
        Me.rdoParcelar.Text = "Parcelar"
        Me.rdoParcelar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Título"
        '
        'txtValor
        '
        Me.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValor.Location = New System.Drawing.Point(104, 183)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(79, 20)
        Me.txtValor.TabIndex = 3
        '
        'txtNumeroTitulo
        '
        Me.txtNumeroTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumeroTitulo.Location = New System.Drawing.Point(104, 117)
        Me.txtNumeroTitulo.MaxLength = 6
        Me.txtNumeroTitulo.Name = "txtNumeroTitulo"
        Me.txtNumeroTitulo.Size = New System.Drawing.Size(79, 20)
        Me.txtNumeroTitulo.TabIndex = 1
        '
        'txtParcela
        '
        Me.txtParcela.BackColor = System.Drawing.Color.White
        Me.txtParcela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtParcela.Location = New System.Drawing.Point(275, 216)
        Me.txtParcela.MaxLength = 5
        Me.txtParcela.Name = "txtParcela"
        Me.txtParcela.Size = New System.Drawing.Size(41, 20)
        Me.txtParcela.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(226, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Parcela"
        '
        'cmbCartao
        '
        Me.cmbCartao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCartao.Enabled = False
        Me.cmbCartao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbCartao.FormattingEnabled = True
        Me.cmbCartao.Location = New System.Drawing.Point(104, 80)
        Me.cmbCartao.Name = "cmbCartao"
        Me.cmbCartao.Size = New System.Drawing.Size(152, 21)
        Me.cmbCartao.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Cartão"
        '
        'dtpData
        '
        Me.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpData.Location = New System.Drawing.Point(104, 216)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Size = New System.Drawing.Size(104, 20)
        Me.dtpData.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtCodigo)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(566, 51)
        Me.Panel1.TabIndex = 50
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.Silver
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigo.ForeColor = System.Drawing.Color.White
        Me.txtCodigo.Location = New System.Drawing.Point(64, 18)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(100, 13)
        Me.txtCodigo.TabIndex = 29
        Me.txtCodigo.TabStop = False
        Me.txtCodigo.Text = "00000"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Código:"
        '
        'txtTituloDespesa
        '
        Me.txtTituloDespesa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTituloDespesa.Location = New System.Drawing.Point(104, 249)
        Me.txtTituloDespesa.Name = "txtTituloDespesa"
        Me.txtTituloDespesa.Size = New System.Drawing.Size(79, 20)
        Me.txtTituloDespesa.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 253)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 13)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Título Despesa"
        '
        'frmMovimentoCartao
        '
        Me.AcceptButton = Me.cmdGravar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdSair
        Me.ClientSize = New System.Drawing.Size(566, 435)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtTituloDespesa)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dtpData)
        Me.Controls.Add(Me.cmbCartao)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtParcela)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNumeroTitulo)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gbxGerarDebito)
        Me.Controls.Add(Me.cmdSair)
        Me.Controls.Add(Me.cmdGravar)
        Me.Controls.Add(Me.txtObservacao)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbSubConta)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbConta)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMovimentoCartao"
        Me.Text = "Movimento Cartão"
        Me.gbxGerarDebito.ResumeLayout(False)
        Me.gbxGerarDebito.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbSubConta As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbConta As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtObservacao As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmdSair As Button
    Friend WithEvents cmdGravar As Button
    Friend WithEvents gbxGerarDebito As GroupBox
    Friend WithEvents lblQtdParcela As Label
    Friend WithEvents txtQtdParcela As TextBox
    Friend WithEvents rdoCopiar As RadioButton
    Friend WithEvents rdoParcelar As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents txtNumeroTitulo As TextBox
    Friend WithEvents txtParcela As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbCartao As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpData As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTituloDespesa As TextBox
    Friend WithEvents Label11 As Label
End Class
