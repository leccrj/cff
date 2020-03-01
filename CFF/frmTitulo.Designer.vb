<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTitulo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbConta = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mskValor = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtObservacao = New System.Windows.Forms.TextBox()
        Me.cmdSair = New System.Windows.Forms.Button()
        Me.cmdGravar = New System.Windows.Forms.Button()
        Me.lblTipoConta = New System.Windows.Forms.Label()
        Me.gbxGerarDebito = New System.Windows.Forms.GroupBox()
        Me.lblTipoContaFutura = New System.Windows.Forms.Label()
        Me.cmbSubContaTituloFuturo = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbContaTituloFuturo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblQtdParcela = New System.Windows.Forms.Label()
        Me.txtQtdParcela = New System.Windows.Forms.TextBox()
        Me.rdoCopiar = New System.Windows.Forms.RadioButton()
        Me.rdoParcelar = New System.Windows.Forms.RadioButton()
        Me.chkGerarDebito = New System.Windows.Forms.CheckBox()
        Me.cmbSubConta = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtParcela = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkBaixarTitulo = New System.Windows.Forms.CheckBox()
        Me.cmd_itemcartao = New System.Windows.Forms.Button()
        Me.dtpVencimento = New System.Windows.Forms.DateTimePicker()
        Me.dtpPlanejamento = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.gbxGerarDebito.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Conta"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbConta
        '
        Me.cmbConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbConta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbConta.FormattingEnabled = True
        Me.cmbConta.Location = New System.Drawing.Point(77, 174)
        Me.cmbConta.Name = "cmbConta"
        Me.cmbConta.Size = New System.Drawing.Size(153, 21)
        Me.cmbConta.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Descrição"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescricao
        '
        Me.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescricao.Location = New System.Drawing.Point(77, 70)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(226, 20)
        Me.txtDescricao.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Vencimento"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mskValor
        '
        Me.mskValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskValor.Location = New System.Drawing.Point(77, 96)
        Me.mskValor.Name = "mskValor"
        Me.mskValor.Size = New System.Drawing.Size(74, 20)
        Me.mskValor.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Valor"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 234)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Observação"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtObservacao
        '
        Me.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservacao.Location = New System.Drawing.Point(7, 251)
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(585, 77)
        Me.txtObservacao.TabIndex = 12
        '
        'cmdSair
        '
        Me.cmdSair.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSair.Location = New System.Drawing.Point(518, 335)
        Me.cmdSair.Name = "cmdSair"
        Me.cmdSair.Size = New System.Drawing.Size(74, 21)
        Me.cmdSair.TabIndex = 14
        Me.cmdSair.Text = "Sair"
        Me.cmdSair.UseVisualStyleBackColor = True
        '
        'cmdGravar
        '
        Me.cmdGravar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdGravar.Location = New System.Drawing.Point(438, 335)
        Me.cmdGravar.Name = "cmdGravar"
        Me.cmdGravar.Size = New System.Drawing.Size(74, 21)
        Me.cmdGravar.TabIndex = 13
        Me.cmdGravar.Text = "Gravar"
        Me.cmdGravar.UseVisualStyleBackColor = True
        '
        'lblTipoConta
        '
        Me.lblTipoConta.AutoSize = True
        Me.lblTipoConta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTipoConta.Location = New System.Drawing.Point(236, 178)
        Me.lblTipoConta.Name = "lblTipoConta"
        Me.lblTipoConta.Size = New System.Drawing.Size(40, 13)
        Me.lblTipoConta.TabIndex = 18
        Me.lblTipoConta.Text = "Crédito"
        '
        'gbxGerarDebito
        '
        Me.gbxGerarDebito.Controls.Add(Me.lblTipoContaFutura)
        Me.gbxGerarDebito.Controls.Add(Me.cmbSubContaTituloFuturo)
        Me.gbxGerarDebito.Controls.Add(Me.Label9)
        Me.gbxGerarDebito.Controls.Add(Me.cmbContaTituloFuturo)
        Me.gbxGerarDebito.Controls.Add(Me.Label8)
        Me.gbxGerarDebito.Controls.Add(Me.lblQtdParcela)
        Me.gbxGerarDebito.Controls.Add(Me.txtQtdParcela)
        Me.gbxGerarDebito.Controls.Add(Me.rdoCopiar)
        Me.gbxGerarDebito.Controls.Add(Me.rdoParcelar)
        Me.gbxGerarDebito.Enabled = False
        Me.gbxGerarDebito.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbxGerarDebito.Location = New System.Drawing.Point(329, 70)
        Me.gbxGerarDebito.Name = "gbxGerarDebito"
        Me.gbxGerarDebito.Size = New System.Drawing.Size(263, 113)
        Me.gbxGerarDebito.TabIndex = 20
        Me.gbxGerarDebito.TabStop = False
        Me.gbxGerarDebito.Text = "Gerar Título Futuro"
        '
        'lblTipoContaFutura
        '
        Me.lblTipoContaFutura.AutoSize = True
        Me.lblTipoContaFutura.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTipoContaFutura.Location = New System.Drawing.Point(210, 55)
        Me.lblTipoContaFutura.Name = "lblTipoContaFutura"
        Me.lblTipoContaFutura.Size = New System.Drawing.Size(14, 13)
        Me.lblTipoContaFutura.TabIndex = 19
        Me.lblTipoContaFutura.Text = "C"
        Me.lblTipoContaFutura.Visible = False
        '
        'cmbSubContaTituloFuturo
        '
        Me.cmbSubContaTituloFuturo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubContaTituloFuturo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbSubContaTituloFuturo.FormattingEnabled = True
        Me.cmbSubContaTituloFuturo.Location = New System.Drawing.Point(74, 78)
        Me.cmbSubContaTituloFuturo.Name = "cmbSubContaTituloFuturo"
        Me.cmbSubContaTituloFuturo.Size = New System.Drawing.Size(130, 21)
        Me.cmbSubContaTituloFuturo.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "SubConta"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbContaTituloFuturo
        '
        Me.cmbContaTituloFuturo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbContaTituloFuturo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbContaTituloFuturo.FormattingEnabled = True
        Me.cmbContaTituloFuturo.Location = New System.Drawing.Point(74, 51)
        Me.cmbContaTituloFuturo.Name = "cmbContaTituloFuturo"
        Me.cmbContaTituloFuturo.Size = New System.Drawing.Size(130, 21)
        Me.cmbContaTituloFuturo.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Conta"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblQtdParcela
        '
        Me.lblQtdParcela.AutoSize = True
        Me.lblQtdParcela.Location = New System.Drawing.Point(193, 26)
        Me.lblQtdParcela.Name = "lblQtdParcela"
        Me.lblQtdParcela.Size = New System.Drawing.Size(53, 13)
        Me.lblQtdParcela.TabIndex = 4
        Me.lblQtdParcela.Text = "parcela(s)"
        '
        'txtQtdParcela
        '
        Me.txtQtdParcela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQtdParcela.Location = New System.Drawing.Point(156, 22)
        Me.txtQtdParcela.Name = "txtQtdParcela"
        Me.txtQtdParcela.Size = New System.Drawing.Size(34, 20)
        Me.txtQtdParcela.TabIndex = 9
        '
        'rdoCopiar
        '
        Me.rdoCopiar.AutoSize = True
        Me.rdoCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoCopiar.Location = New System.Drawing.Point(91, 24)
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
        Me.rdoParcelar.Location = New System.Drawing.Point(17, 24)
        Me.rdoParcelar.Name = "rdoParcelar"
        Me.rdoParcelar.Size = New System.Drawing.Size(63, 17)
        Me.rdoParcelar.TabIndex = 6
        Me.rdoParcelar.TabStop = True
        Me.rdoParcelar.Text = "Parcelar"
        Me.rdoParcelar.UseVisualStyleBackColor = True
        '
        'chkGerarDebito
        '
        Me.chkGerarDebito.AutoSize = True
        Me.chkGerarDebito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkGerarDebito.Location = New System.Drawing.Point(441, 71)
        Me.chkGerarDebito.Name = "chkGerarDebito"
        Me.chkGerarDebito.Size = New System.Drawing.Size(12, 11)
        Me.chkGerarDebito.TabIndex = 6
        Me.chkGerarDebito.UseVisualStyleBackColor = True
        '
        'cmbSubConta
        '
        Me.cmbSubConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubConta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbSubConta.FormattingEnabled = True
        Me.cmbSubConta.Location = New System.Drawing.Point(77, 201)
        Me.cmbSubConta.Name = "cmbSubConta"
        Me.cmbSubConta.Size = New System.Drawing.Size(153, 21)
        Me.cmbSubConta.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 205)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "SubConta"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Parcela"
        '
        'txtParcela
        '
        Me.txtParcela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtParcela.Location = New System.Drawing.Point(77, 122)
        Me.txtParcela.Name = "txtParcela"
        Me.txtParcela.Size = New System.Drawing.Size(37, 20)
        Me.txtParcela.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtCodigo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(599, 51)
        Me.Panel1.TabIndex = 28
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Código:"
        '
        'chkBaixarTitulo
        '
        Me.chkBaixarTitulo.AutoSize = True
        Me.chkBaixarTitulo.Checked = True
        Me.chkBaixarTitulo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBaixarTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBaixarTitulo.Location = New System.Drawing.Point(334, 201)
        Me.chkBaixarTitulo.Name = "chkBaixarTitulo"
        Me.chkBaixarTitulo.Size = New System.Drawing.Size(83, 17)
        Me.chkBaixarTitulo.TabIndex = 29
        Me.chkBaixarTitulo.Text = "Baixar Título"
        Me.chkBaixarTitulo.UseVisualStyleBackColor = True
        '
        'cmd_itemcartao
        '
        Me.cmd_itemcartao.Enabled = False
        Me.cmd_itemcartao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_itemcartao.Location = New System.Drawing.Point(7, 335)
        Me.cmd_itemcartao.Name = "cmd_itemcartao"
        Me.cmd_itemcartao.Size = New System.Drawing.Size(99, 21)
        Me.cmd_itemcartao.TabIndex = 30
        Me.cmd_itemcartao.Text = "Item Cartão"
        Me.cmd_itemcartao.UseVisualStyleBackColor = True
        Me.cmd_itemcartao.Visible = False
        '
        'dtpVencimento
        '
        Me.dtpVencimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVencimento.Location = New System.Drawing.Point(77, 148)
        Me.dtpVencimento.Name = "dtpVencimento"
        Me.dtpVencimento.Size = New System.Drawing.Size(88, 20)
        Me.dtpVencimento.TabIndex = 3
        '
        'dtpPlanejamento
        '
        Me.dtpPlanejamento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPlanejamento.Location = New System.Drawing.Point(171, 148)
        Me.dtpPlanejamento.Name = "dtpPlanejamento"
        Me.dtpPlanejamento.Size = New System.Drawing.Size(88, 20)
        Me.dtpPlanejamento.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(168, 131)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Planejamento"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmTitulo
        '
        Me.AcceptButton = Me.cmdGravar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdSair
        Me.ClientSize = New System.Drawing.Size(599, 365)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dtpPlanejamento)
        Me.Controls.Add(Me.dtpVencimento)
        Me.Controls.Add(Me.cmd_itemcartao)
        Me.Controls.Add(Me.chkBaixarTitulo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtParcela)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkGerarDebito)
        Me.Controls.Add(Me.cmbSubConta)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.gbxGerarDebito)
        Me.Controls.Add(Me.lblTipoConta)
        Me.Controls.Add(Me.cmdSair)
        Me.Controls.Add(Me.cmdGravar)
        Me.Controls.Add(Me.txtObservacao)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.mskValor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbConta)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmTitulo"
        Me.Text = "Título"
        Me.gbxGerarDebito.ResumeLayout(False)
        Me.gbxGerarDebito.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents cmbConta As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents mskValor As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtObservacao As TextBox
    Friend WithEvents cmdSair As Button
    Friend WithEvents cmdGravar As Button
    Friend WithEvents lblTipoConta As Label
    Friend WithEvents gbxGerarDebito As GroupBox
    Friend WithEvents txtQtdParcela As TextBox
    Friend WithEvents rdoCopiar As RadioButton
    Friend WithEvents rdoParcelar As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbContaTituloFuturo As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblQtdParcela As Label
    Friend WithEvents cmbSubConta As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents chkGerarDebito As CheckBox
    Friend WithEvents cmbSubContaTituloFuturo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtParcela As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTipoContaFutura As Label
    Friend WithEvents chkBaixarTitulo As CheckBox
    Friend WithEvents cmd_itemcartao As Button
    Friend WithEvents dtpVencimento As DateTimePicker
    Friend WithEvents dtpPlanejamento As DateTimePicker
    Friend WithEvents Label11 As Label
End Class
