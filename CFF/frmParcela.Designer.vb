<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParcela
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParcela))
        Me.dgvParcela = New System.Windows.Forms.DataGridView()
        Me.col_seq_parcela = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_numero_parcela = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_vencimento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_data_pagamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtDscParcelamento = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtValorParcela = New System.Windows.Forms.TextBox()
        Me.txtNumeroParcela = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtVencimentoParcela = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdPesquisaTitulo = New System.Windows.Forms.Button()
        Me.img = New System.Windows.Forms.ImageList(Me.components)
        Me.txtDataPagamento = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtValorPago = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSubGrupo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtGrupo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtVencimentoTitulo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtValorTitulo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNumeroTitulo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdSair = New System.Windows.Forms.Button()
        Me.cmdAtualizarParcela = New System.Windows.Forms.Button()
        Me.cmdBaixarTitulo = New System.Windows.Forms.Button()
        Me.cmdCriarParcela = New System.Windows.Forms.Button()
        CType(Me.dgvParcela, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvParcela
        '
        Me.dgvParcela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvParcela.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_seq_parcela, Me.col_numero_parcela, Me.col_valor, Me.col_vencimento, Me.col_data_pagamento})
        Me.dgvParcela.Location = New System.Drawing.Point(12, 79)
        Me.dgvParcela.MultiSelect = False
        Me.dgvParcela.Name = "dgvParcela"
        Me.dgvParcela.ReadOnly = True
        Me.dgvParcela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvParcela.Size = New System.Drawing.Size(470, 479)
        Me.dgvParcela.TabIndex = 0
        '
        'col_seq_parcela
        '
        Me.col_seq_parcela.Frozen = True
        Me.col_seq_parcela.HeaderText = "seq_parcela"
        Me.col_seq_parcela.Name = "col_seq_parcela"
        Me.col_seq_parcela.ReadOnly = True
        Me.col_seq_parcela.Visible = False
        '
        'col_numero_parcela
        '
        Me.col_numero_parcela.HeaderText = "Parcela"
        Me.col_numero_parcela.Name = "col_numero_parcela"
        Me.col_numero_parcela.ReadOnly = True
        Me.col_numero_parcela.Width = 68
        '
        'col_valor
        '
        Me.col_valor.HeaderText = "Valor (R$)"
        Me.col_valor.Name = "col_valor"
        Me.col_valor.ReadOnly = True
        '
        'col_vencimento
        '
        Me.col_vencimento.HeaderText = "Vencimento"
        Me.col_vencimento.Name = "col_vencimento"
        Me.col_vencimento.ReadOnly = True
        '
        'col_data_pagamento
        '
        Me.col_data_pagamento.HeaderText = "Data Pagamento"
        Me.col_data_pagamento.Name = "col_data_pagamento"
        Me.col_data_pagamento.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtDscParcelamento)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.TxtCodigo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(987, 51)
        Me.Panel1.TabIndex = 30
        '
        'txtDscParcelamento
        '
        Me.txtDscParcelamento.BackColor = System.Drawing.Color.Silver
        Me.txtDscParcelamento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDscParcelamento.ForeColor = System.Drawing.Color.White
        Me.txtDscParcelamento.Location = New System.Drawing.Point(499, 18)
        Me.txtDscParcelamento.Name = "txtDscParcelamento"
        Me.txtDscParcelamento.ReadOnly = True
        Me.txtDscParcelamento.Size = New System.Drawing.Size(471, 13)
        Me.txtDscParcelamento.TabIndex = 31
        Me.txtDscParcelamento.TabStop = False
        Me.txtDscParcelamento.Text = "00000"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(418, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 13)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Parcelamento:"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.BackColor = System.Drawing.Color.Silver
        Me.TxtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCodigo.ForeColor = System.Drawing.Color.White
        Me.TxtCodigo.Location = New System.Drawing.Point(64, 18)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.ReadOnly = True
        Me.TxtCodigo.Size = New System.Drawing.Size(100, 13)
        Me.TxtCodigo.TabIndex = 29
        Me.TxtCodigo.TabStop = False
        Me.TxtCodigo.Text = "00000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(15, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Código:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Parcelas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(516, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Parcela:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(516, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Valor:"
        '
        'txtValorParcela
        '
        Me.txtValorParcela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValorParcela.Location = New System.Drawing.Point(590, 102)
        Me.txtValorParcela.Name = "txtValorParcela"
        Me.txtValorParcela.Size = New System.Drawing.Size(100, 20)
        Me.txtValorParcela.TabIndex = 35
        '
        'txtNumeroParcela
        '
        Me.txtNumeroParcela.BackColor = System.Drawing.SystemColors.Control
        Me.txtNumeroParcela.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNumeroParcela.ForeColor = System.Drawing.Color.Blue
        Me.txtNumeroParcela.Location = New System.Drawing.Point(590, 76)
        Me.txtNumeroParcela.Name = "txtNumeroParcela"
        Me.txtNumeroParcela.ReadOnly = True
        Me.txtNumeroParcela.Size = New System.Drawing.Size(100, 13)
        Me.txtNumeroParcela.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(516, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Vencimento:"
        '
        'txtVencimentoParcela
        '
        Me.txtVencimentoParcela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVencimentoParcela.Location = New System.Drawing.Point(590, 128)
        Me.txtVencimentoParcela.Name = "txtVencimentoParcela"
        Me.txtVencimentoParcela.Size = New System.Drawing.Size(100, 20)
        Me.txtVencimentoParcela.TabIndex = 38
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdPesquisaTitulo)
        Me.GroupBox1.Controls.Add(Me.txtDataPagamento)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtValorPago)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtSubGrupo)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtGrupo)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtVencimentoTitulo)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtValorTitulo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtNumeroTitulo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(718, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(253, 213)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Título"
        '
        'cmdPesquisaTitulo
        '
        Me.cmdPesquisaTitulo.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPesquisaTitulo.FlatAppearance.BorderSize = 0
        Me.cmdPesquisaTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPesquisaTitulo.ImageIndex = 0
        Me.cmdPesquisaTitulo.ImageList = Me.img
        Me.cmdPesquisaTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPesquisaTitulo.Location = New System.Drawing.Point(212, 21)
        Me.cmdPesquisaTitulo.Name = "cmdPesquisaTitulo"
        Me.cmdPesquisaTitulo.Size = New System.Drawing.Size(28, 22)
        Me.cmdPesquisaTitulo.TabIndex = 14
        Me.cmdPesquisaTitulo.TabStop = False
        Me.cmdPesquisaTitulo.UseVisualStyleBackColor = False
        '
        'img
        '
        Me.img.ImageStream = CType(resources.GetObject("img.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img.TransparentColor = System.Drawing.Color.Transparent
        Me.img.Images.SetKeyName(0, "pesquisar")
        Me.img.Images.SetKeyName(1, "gravar")
        Me.img.Images.SetKeyName(2, "sair")
        '
        'txtDataPagamento
        '
        Me.txtDataPagamento.BackColor = System.Drawing.SystemColors.Control
        Me.txtDataPagamento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDataPagamento.ForeColor = System.Drawing.Color.Red
        Me.txtDataPagamento.Location = New System.Drawing.Point(106, 184)
        Me.txtDataPagamento.Name = "txtDataPagamento"
        Me.txtDataPagamento.ReadOnly = True
        Me.txtDataPagamento.Size = New System.Drawing.Size(100, 13)
        Me.txtDataPagamento.TabIndex = 13
        Me.txtDataPagamento.Text = "00/00/0000"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 184)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Data Pagamento:"
        '
        'txtValorPago
        '
        Me.txtValorPago.BackColor = System.Drawing.SystemColors.Control
        Me.txtValorPago.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtValorPago.ForeColor = System.Drawing.Color.Red
        Me.txtValorPago.Location = New System.Drawing.Point(106, 158)
        Me.txtValorPago.Name = "txtValorPago"
        Me.txtValorPago.ReadOnly = True
        Me.txtValorPago.Size = New System.Drawing.Size(100, 13)
        Me.txtValorPago.TabIndex = 11
        Me.txtValorPago.Text = "0,00"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 158)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Valor Pago:"
        '
        'txtSubGrupo
        '
        Me.txtSubGrupo.BackColor = System.Drawing.SystemColors.Control
        Me.txtSubGrupo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSubGrupo.ForeColor = System.Drawing.Color.Red
        Me.txtSubGrupo.Location = New System.Drawing.Point(106, 131)
        Me.txtSubGrupo.Name = "txtSubGrupo"
        Me.txtSubGrupo.ReadOnly = True
        Me.txtSubGrupo.Size = New System.Drawing.Size(134, 13)
        Me.txtSubGrupo.TabIndex = 9
        Me.txtSubGrupo.Text = "subgrupo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 131)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "SubGrupo:"
        '
        'txtGrupo
        '
        Me.txtGrupo.BackColor = System.Drawing.SystemColors.Control
        Me.txtGrupo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGrupo.ForeColor = System.Drawing.Color.Red
        Me.txtGrupo.Location = New System.Drawing.Point(106, 105)
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.ReadOnly = True
        Me.txtGrupo.Size = New System.Drawing.Size(134, 13)
        Me.txtGrupo.TabIndex = 7
        Me.txtGrupo.Text = "grupo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Grupo:"
        '
        'txtVencimentoTitulo
        '
        Me.txtVencimentoTitulo.BackColor = System.Drawing.SystemColors.Control
        Me.txtVencimentoTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVencimentoTitulo.ForeColor = System.Drawing.Color.Red
        Me.txtVencimentoTitulo.Location = New System.Drawing.Point(106, 79)
        Me.txtVencimentoTitulo.Name = "txtVencimentoTitulo"
        Me.txtVencimentoTitulo.ReadOnly = True
        Me.txtVencimentoTitulo.Size = New System.Drawing.Size(100, 13)
        Me.txtVencimentoTitulo.TabIndex = 5
        Me.txtVencimentoTitulo.Text = "00/00/0000"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Vencimento:"
        '
        'txtValorTitulo
        '
        Me.txtValorTitulo.BackColor = System.Drawing.SystemColors.Control
        Me.txtValorTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtValorTitulo.ForeColor = System.Drawing.Color.Red
        Me.txtValorTitulo.Location = New System.Drawing.Point(106, 53)
        Me.txtValorTitulo.Name = "txtValorTitulo"
        Me.txtValorTitulo.ReadOnly = True
        Me.txtValorTitulo.Size = New System.Drawing.Size(100, 13)
        Me.txtValorTitulo.TabIndex = 3
        Me.txtValorTitulo.Text = "0,00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Valor:"
        '
        'txtNumeroTitulo
        '
        Me.txtNumeroTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumeroTitulo.Location = New System.Drawing.Point(106, 22)
        Me.txtNumeroTitulo.Name = "txtNumeroTitulo"
        Me.txtNumeroTitulo.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroTitulo.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Número:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(508, 333)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = " "
        '
        'cmdSair
        '
        Me.cmdSair.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSair.Location = New System.Drawing.Point(896, 535)
        Me.cmdSair.Name = "cmdSair"
        Me.cmdSair.Size = New System.Drawing.Size(75, 23)
        Me.cmdSair.TabIndex = 41
        Me.cmdSair.Text = "Sair"
        Me.cmdSair.UseVisualStyleBackColor = True
        '
        'cmdAtualizarParcela
        '
        Me.cmdAtualizarParcela.Location = New System.Drawing.Point(523, 184)
        Me.cmdAtualizarParcela.Name = "cmdAtualizarParcela"
        Me.cmdAtualizarParcela.Size = New System.Drawing.Size(111, 23)
        Me.cmdAtualizarParcela.TabIndex = 42
        Me.cmdAtualizarParcela.Text = "Atualizar Parcela"
        Me.cmdAtualizarParcela.UseVisualStyleBackColor = True
        '
        'cmdBaixarTitulo
        '
        Me.cmdBaixarTitulo.Location = New System.Drawing.Point(523, 221)
        Me.cmdBaixarTitulo.Name = "cmdBaixarTitulo"
        Me.cmdBaixarTitulo.Size = New System.Drawing.Size(111, 23)
        Me.cmdBaixarTitulo.TabIndex = 43
        Me.cmdBaixarTitulo.Text = "Pagar Parcela"
        Me.cmdBaixarTitulo.UseVisualStyleBackColor = True
        '
        'cmdCriarParcela
        '
        Me.cmdCriarParcela.Location = New System.Drawing.Point(523, 257)
        Me.cmdCriarParcela.Name = "cmdCriarParcela"
        Me.cmdCriarParcela.Size = New System.Drawing.Size(111, 23)
        Me.cmdCriarParcela.TabIndex = 44
        Me.cmdCriarParcela.Text = "Criar Título"
        Me.cmdCriarParcela.UseVisualStyleBackColor = True
        '
        'frmParcela
        '
        Me.AcceptButton = Me.cmdSair
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdSair
        Me.ClientSize = New System.Drawing.Size(987, 570)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCriarParcela)
        Me.Controls.Add(Me.cmdBaixarTitulo)
        Me.Controls.Add(Me.cmdAtualizarParcela)
        Me.Controls.Add(Me.cmdSair)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtVencimentoParcela)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNumeroParcela)
        Me.Controls.Add(Me.txtValorParcela)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvParcela)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmParcela"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parcela"
        CType(Me.dgvParcela, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvParcela As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtValorParcela As TextBox
    Friend WithEvents txtNumeroParcela As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtVencimentoParcela As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDataPagamento As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtValorPago As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtSubGrupo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtGrupo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtVencimentoTitulo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtValorTitulo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNumeroTitulo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmdPesquisaTitulo As Button
    Friend WithEvents img As ImageList
    Friend WithEvents cmdSair As Button
    Friend WithEvents cmdAtualizarParcela As Button
    Friend WithEvents cmdBaixarTitulo As Button
    Friend WithEvents col_seq_parcela As DataGridViewTextBoxColumn
    Friend WithEvents col_numero_parcela As DataGridViewTextBoxColumn
    Friend WithEvents col_valor As DataGridViewTextBoxColumn
    Friend WithEvents col_vencimento As DataGridViewTextBoxColumn
    Friend WithEvents col_data_pagamento As DataGridViewTextBoxColumn
    Friend WithEvents txtDscParcelamento As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cmdCriarParcela As Button
End Class
