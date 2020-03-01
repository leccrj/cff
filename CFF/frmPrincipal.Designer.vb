<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cartão")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Conta")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Título")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Lançamento")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Total por conta principal")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Relatório", New System.Windows.Forms.TreeNode() {TreeNode5})
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.mnuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.imnConta = New System.Windows.Forms.ToolStripMenuItem()
        Me.imnTitulo = New System.Windows.Forms.ToolStripMenuItem()
        Me.imnMovimento = New System.Windows.Forms.ToolStripMenuItem()
        Me.imnCartaoCadastro = New System.Windows.Forms.ToolStripMenuItem()
        Me.imnCartaoMovimento = New System.Windows.Forms.ToolStripMenuItem()
        Me.imnLancamento = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImnParcelamento = New System.Windows.Forms.ToolStripMenuItem()
        Me.imnSair = New System.Windows.Forms.ToolStripMenuItem()
        Me.sstTitulo = New System.Windows.Forms.StatusStrip()
        Me.lbl_datatit = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_dataval = New System.Windows.Forms.ToolStripStatusLabel()
        Me.splPrincipal = New System.Windows.Forms.SplitContainer()
        Me.trwPrincipal = New System.Windows.Forms.TreeView()
        Me.splExibicao = New System.Windows.Forms.SplitContainer()
        Me.dgvGrc = New System.Windows.Forms.DataGridView()
        Me.tbcResumo = New System.Windows.Forms.TabControl()
        Me.tbpCartao = New System.Windows.Forms.TabPage()
        Me.tlpResumoCartao = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_vencimento_cartao = New System.Windows.Forms.TextBox()
        Me.txt_total_cartao = New System.Windows.Forms.TextBox()
        Me.lbl_vencimento_cartao = New System.Windows.Forms.Label()
        Me.lbl_total_cartao = New System.Windows.Forms.Label()
        Me.tbpTitulo = New System.Windows.Forms.TabPage()
        Me.tlpResumoTitulo = New System.Windows.Forms.TableLayoutPanel()
        Me.chtDebito = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chtCredito = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lstConta = New System.Windows.Forms.ListView()
        Me.col_conta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_total = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_tipo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblGeral = New System.Windows.Forms.Label()
        Me.txt_caixa_geral = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_planejamento = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_saldo_mes = New System.Windows.Forms.TextBox()
        Me.txt_apagar_mes = New System.Windows.Forms.TextBox()
        Me.txt_pago_mes = New System.Windows.Forms.TextBox()
        Me.txt_despesa_mes = New System.Windows.Forms.TextBox()
        Me.txt_receita_mes = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tspGrc = New System.Windows.Forms.ToolStrip()
        Me.stbIncluir = New System.Windows.Forms.ToolStripButton()
        Me.stbEditar = New System.Windows.Forms.ToolStripButton()
        Me.stbExcluir = New System.Windows.Forms.ToolStripButton()
        Me.stsSeparador1 = New System.Windows.Forms.ToolStripSeparator()
        Me.stlMesAno = New System.Windows.Forms.ToolStripLabel()
        Me.sttMesAno = New System.Windows.Forms.ToolStripTextBox()
        Me.stbPesquisar = New System.Windows.Forms.ToolStripButton()
        Me.stlRaiz = New System.Windows.Forms.ToolStripLabel()
        Me.sttRaiz = New System.Windows.Forms.ToolStripTextBox()
        Me.stbPesquisarRaiz = New System.Windows.Forms.ToolStripButton()
        Me.stlTitulo = New System.Windows.Forms.ToolStripLabel()
        Me.sttTitulo = New System.Windows.Forms.ToolStripTextBox()
        Me.stbPesquisarTitulo = New System.Windows.Forms.ToolStripButton()
        Me.img = New System.Windows.Forms.ImageList(Me.components)
        Me.mnuPrincipal.SuspendLayout()
        Me.sstTitulo.SuspendLayout()
        CType(Me.splPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splPrincipal.Panel1.SuspendLayout()
        Me.splPrincipal.Panel2.SuspendLayout()
        Me.splPrincipal.SuspendLayout()
        CType(Me.splExibicao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splExibicao.Panel1.SuspendLayout()
        Me.splExibicao.Panel2.SuspendLayout()
        Me.splExibicao.SuspendLayout()
        CType(Me.dgvGrc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcResumo.SuspendLayout()
        Me.tbpCartao.SuspendLayout()
        Me.tlpResumoCartao.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.tbpTitulo.SuspendLayout()
        Me.tlpResumoTitulo.SuspendLayout()
        CType(Me.chtDebito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.tspGrc.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuPrincipal
        '
        Me.mnuPrincipal.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.mnuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.imnConta, Me.imnTitulo, Me.imnMovimento, Me.imnLancamento, Me.ImnParcelamento, Me.imnSair})
        Me.mnuPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.mnuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mnuPrincipal.Name = "mnuPrincipal"
        Me.mnuPrincipal.Size = New System.Drawing.Size(1331, 55)
        Me.mnuPrincipal.TabIndex = 0
        Me.mnuPrincipal.Text = "mnuPrincipal"
        '
        'imnConta
        '
        Me.imnConta.Image = Global.CFF.My.Resources.Resources._1_128
        Me.imnConta.Name = "imnConta"
        Me.imnConta.Size = New System.Drawing.Size(51, 51)
        Me.imnConta.Text = "Conta"
        Me.imnConta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'imnTitulo
        '
        Me.imnTitulo.Image = Global.CFF.My.Resources.Resources._1_075
        Me.imnTitulo.Name = "imnTitulo"
        Me.imnTitulo.Size = New System.Drawing.Size(49, 51)
        Me.imnTitulo.Text = "Título"
        Me.imnTitulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'imnMovimento
        '
        Me.imnMovimento.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.imnCartaoCadastro, Me.imnCartaoMovimento})
        Me.imnMovimento.Image = Global.CFF.My.Resources.Resources._1_070
        Me.imnMovimento.Name = "imnMovimento"
        Me.imnMovimento.Size = New System.Drawing.Size(54, 51)
        Me.imnMovimento.Text = "Cartão"
        Me.imnMovimento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'imnCartaoCadastro
        '
        Me.imnCartaoCadastro.Name = "imnCartaoCadastro"
        Me.imnCartaoCadastro.Size = New System.Drawing.Size(136, 22)
        Me.imnCartaoCadastro.Text = "Cadastro"
        '
        'imnCartaoMovimento
        '
        Me.imnCartaoMovimento.Name = "imnCartaoMovimento"
        Me.imnCartaoMovimento.Size = New System.Drawing.Size(136, 22)
        Me.imnCartaoMovimento.Text = "Movimento"
        '
        'imnLancamento
        '
        Me.imnLancamento.Image = Global.CFF.My.Resources.Resources._1_074
        Me.imnLancamento.Name = "imnLancamento"
        Me.imnLancamento.Size = New System.Drawing.Size(80, 51)
        Me.imnLancamento.Text = "Pagamento"
        Me.imnLancamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.imnLancamento.Visible = False
        '
        'ImnParcelamento
        '
        Me.ImnParcelamento.Image = Global.CFF.My.Resources.Resources._1_055
        Me.ImnParcelamento.Name = "ImnParcelamento"
        Me.ImnParcelamento.Size = New System.Drawing.Size(92, 51)
        Me.ImnParcelamento.Text = "Parcelamento"
        Me.ImnParcelamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'imnSair
        '
        Me.imnSair.Image = Global.CFF.My.Resources.Resources._1_046
        Me.imnSair.Name = "imnSair"
        Me.imnSair.Size = New System.Drawing.Size(44, 51)
        Me.imnSair.Text = "Sair"
        Me.imnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'sstTitulo
        '
        Me.sstTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.sstTitulo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_datatit, Me.lbl_dataval})
        Me.sstTitulo.Location = New System.Drawing.Point(0, 702)
        Me.sstTitulo.Name = "sstTitulo"
        Me.sstTitulo.Size = New System.Drawing.Size(1331, 22)
        Me.sstTitulo.TabIndex = 4
        '
        'lbl_datatit
        '
        Me.lbl_datatit.Name = "lbl_datatit"
        Me.lbl_datatit.Size = New System.Drawing.Size(34, 17)
        Me.lbl_datatit.Text = "Data:"
        '
        'lbl_dataval
        '
        Me.lbl_dataval.Name = "lbl_dataval"
        Me.lbl_dataval.Size = New System.Drawing.Size(0, 17)
        '
        'splPrincipal
        '
        Me.splPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splPrincipal.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splPrincipal.Location = New System.Drawing.Point(0, 55)
        Me.splPrincipal.Name = "splPrincipal"
        '
        'splPrincipal.Panel1
        '
        Me.splPrincipal.Panel1.Controls.Add(Me.trwPrincipal)
        '
        'splPrincipal.Panel2
        '
        Me.splPrincipal.Panel2.Controls.Add(Me.splExibicao)
        Me.splPrincipal.Panel2.Controls.Add(Me.tspGrc)
        Me.splPrincipal.Size = New System.Drawing.Size(1331, 647)
        Me.splPrincipal.SplitterDistance = 197
        Me.splPrincipal.TabIndex = 5
        '
        'trwPrincipal
        '
        Me.trwPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.trwPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.trwPrincipal.Name = "trwPrincipal"
        TreeNode1.Name = "nd_cartao"
        TreeNode1.Text = "Cartão"
        TreeNode2.Name = "nd_conta"
        TreeNode2.Text = "Conta"
        TreeNode3.Name = "nd_titulo"
        TreeNode3.Text = "Título"
        TreeNode4.Name = "nd_lancamento"
        TreeNode4.Text = "Lançamento"
        TreeNode5.Name = "nd_total_conta"
        TreeNode5.Text = "Total por conta principal"
        TreeNode6.Name = "nd_relatorio"
        TreeNode6.Text = "Relatório"
        Me.trwPrincipal.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode6})
        Me.trwPrincipal.Size = New System.Drawing.Size(197, 647)
        Me.trwPrincipal.TabIndex = 0
        '
        'splExibicao
        '
        Me.splExibicao.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splExibicao.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.splExibicao.Location = New System.Drawing.Point(0, 25)
        Me.splExibicao.Name = "splExibicao"
        '
        'splExibicao.Panel1
        '
        Me.splExibicao.Panel1.Controls.Add(Me.dgvGrc)
        '
        'splExibicao.Panel2
        '
        Me.splExibicao.Panel2.Controls.Add(Me.tbcResumo)
        Me.splExibicao.Size = New System.Drawing.Size(1130, 622)
        Me.splExibicao.SplitterDistance = 713
        Me.splExibicao.TabIndex = 1
        '
        'dgvGrc
        '
        Me.dgvGrc.AllowUserToAddRows = False
        Me.dgvGrc.AllowUserToDeleteRows = False
        Me.dgvGrc.AllowUserToResizeRows = False
        Me.dgvGrc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvGrc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvGrc.Location = New System.Drawing.Point(0, 0)
        Me.dgvGrc.Name = "dgvGrc"
        Me.dgvGrc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvGrc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGrc.Size = New System.Drawing.Size(713, 622)
        Me.dgvGrc.TabIndex = 2
        '
        'tbcResumo
        '
        Me.tbcResumo.Controls.Add(Me.tbpCartao)
        Me.tbcResumo.Controls.Add(Me.tbpTitulo)
        Me.tbcResumo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcResumo.Location = New System.Drawing.Point(0, 0)
        Me.tbcResumo.Name = "tbcResumo"
        Me.tbcResumo.SelectedIndex = 0
        Me.tbcResumo.Size = New System.Drawing.Size(413, 622)
        Me.tbcResumo.TabIndex = 0
        '
        'tbpCartao
        '
        Me.tbpCartao.Controls.Add(Me.tlpResumoCartao)
        Me.tbpCartao.Location = New System.Drawing.Point(4, 22)
        Me.tbpCartao.Name = "tbpCartao"
        Me.tbpCartao.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpCartao.Size = New System.Drawing.Size(405, 596)
        Me.tbpCartao.TabIndex = 1
        Me.tbpCartao.Text = "Cartão"
        '
        'tlpResumoCartao
        '
        Me.tlpResumoCartao.ColumnCount = 1
        Me.tlpResumoCartao.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpResumoCartao.Controls.Add(Me.Panel2, 0, 0)
        Me.tlpResumoCartao.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpResumoCartao.Location = New System.Drawing.Point(3, 3)
        Me.tlpResumoCartao.Name = "tlpResumoCartao"
        Me.tlpResumoCartao.RowCount = 2
        Me.tlpResumoCartao.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93.0!))
        Me.tlpResumoCartao.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpResumoCartao.Size = New System.Drawing.Size(399, 590)
        Me.tlpResumoCartao.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txt_vencimento_cartao)
        Me.Panel2.Controls.Add(Me.txt_total_cartao)
        Me.Panel2.Controls.Add(Me.lbl_vencimento_cartao)
        Me.Panel2.Controls.Add(Me.lbl_total_cartao)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(393, 87)
        Me.Panel2.TabIndex = 5
        '
        'txt_vencimento_cartao
        '
        Me.txt_vencimento_cartao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_vencimento_cartao.Location = New System.Drawing.Point(77, 31)
        Me.txt_vencimento_cartao.Name = "txt_vencimento_cartao"
        Me.txt_vencimento_cartao.ReadOnly = True
        Me.txt_vencimento_cartao.Size = New System.Drawing.Size(65, 13)
        Me.txt_vencimento_cartao.TabIndex = 13
        Me.txt_vencimento_cartao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_total_cartao
        '
        Me.txt_total_cartao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_total_cartao.Location = New System.Drawing.Point(77, 12)
        Me.txt_total_cartao.Name = "txt_total_cartao"
        Me.txt_total_cartao.ReadOnly = True
        Me.txt_total_cartao.Size = New System.Drawing.Size(65, 13)
        Me.txt_total_cartao.TabIndex = 10
        Me.txt_total_cartao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_vencimento_cartao
        '
        Me.lbl_vencimento_cartao.AutoSize = True
        Me.lbl_vencimento_cartao.Location = New System.Drawing.Point(8, 31)
        Me.lbl_vencimento_cartao.Name = "lbl_vencimento_cartao"
        Me.lbl_vencimento_cartao.Size = New System.Drawing.Size(66, 13)
        Me.lbl_vencimento_cartao.TabIndex = 6
        Me.lbl_vencimento_cartao.Text = "Vencimento:"
        '
        'lbl_total_cartao
        '
        Me.lbl_total_cartao.AutoSize = True
        Me.lbl_total_cartao.Location = New System.Drawing.Point(7, 12)
        Me.lbl_total_cartao.Name = "lbl_total_cartao"
        Me.lbl_total_cartao.Size = New System.Drawing.Size(34, 13)
        Me.lbl_total_cartao.TabIndex = 3
        Me.lbl_total_cartao.Text = "Total:"
        '
        'tbpTitulo
        '
        Me.tbpTitulo.Controls.Add(Me.tlpResumoTitulo)
        Me.tbpTitulo.Location = New System.Drawing.Point(4, 22)
        Me.tbpTitulo.Name = "tbpTitulo"
        Me.tbpTitulo.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpTitulo.Size = New System.Drawing.Size(405, 596)
        Me.tbpTitulo.TabIndex = 0
        Me.tbpTitulo.Text = "Título"
        '
        'tlpResumoTitulo
        '
        Me.tlpResumoTitulo.ColumnCount = 1
        Me.tlpResumoTitulo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpResumoTitulo.Controls.Add(Me.chtDebito, 0, 4)
        Me.tlpResumoTitulo.Controls.Add(Me.chtCredito, 0, 3)
        Me.tlpResumoTitulo.Controls.Add(Me.lstConta, 0, 2)
        Me.tlpResumoTitulo.Controls.Add(Me.Panel1, 0, 0)
        Me.tlpResumoTitulo.Controls.Add(Me.Panel3, 0, 1)
        Me.tlpResumoTitulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpResumoTitulo.Location = New System.Drawing.Point(3, 3)
        Me.tlpResumoTitulo.Name = "tlpResumoTitulo"
        Me.tlpResumoTitulo.RowCount = 5
        Me.tlpResumoTitulo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93.0!))
        Me.tlpResumoTitulo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93.0!))
        Me.tlpResumoTitulo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33444!))
        Me.tlpResumoTitulo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33444!))
        Me.tlpResumoTitulo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33112!))
        Me.tlpResumoTitulo.Size = New System.Drawing.Size(399, 590)
        Me.tlpResumoTitulo.TabIndex = 1
        '
        'chtDebito
        '
        ChartArea1.Name = "ChartArea1"
        Me.chtDebito.ChartAreas.Add(ChartArea1)
        Me.chtDebito.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.chtDebito.Legends.Add(Legend1)
        Me.chtDebito.Location = New System.Drawing.Point(3, 457)
        Me.chtDebito.Name = "chtDebito"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chtDebito.Series.Add(Series1)
        Me.chtDebito.Size = New System.Drawing.Size(393, 130)
        Me.chtDebito.TabIndex = 5
        Me.chtDebito.Text = "Conta"
        '
        'chtCredito
        '
        ChartArea2.Name = "ChartArea1"
        Me.chtCredito.ChartAreas.Add(ChartArea2)
        Me.chtCredito.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Name = "Legend1"
        Me.chtCredito.Legends.Add(Legend2)
        Me.chtCredito.Location = New System.Drawing.Point(3, 323)
        Me.chtCredito.Name = "chtCredito"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chtCredito.Series.Add(Series2)
        Me.chtCredito.Size = New System.Drawing.Size(393, 128)
        Me.chtCredito.TabIndex = 2
        Me.chtCredito.Text = "Conta"
        '
        'lstConta
        '
        Me.lstConta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lstConta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstConta.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_conta, Me.col_total, Me.col_tipo})
        Me.lstConta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstConta.HideSelection = False
        Me.lstConta.Location = New System.Drawing.Point(3, 189)
        Me.lstConta.MultiSelect = False
        Me.lstConta.Name = "lstConta"
        Me.lstConta.Size = New System.Drawing.Size(393, 128)
        Me.lstConta.TabIndex = 1
        Me.lstConta.UseCompatibleStateImageBehavior = False
        Me.lstConta.View = System.Windows.Forms.View.Details
        '
        'col_conta
        '
        Me.col_conta.Tag = "col_conta"
        Me.col_conta.Text = "Conta"
        Me.col_conta.Width = 199
        '
        'col_total
        '
        Me.col_total.Tag = "col_total"
        Me.col_total.Text = "Total"
        Me.col_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'col_tipo
        '
        Me.col_tipo.Tag = "col_tipo"
        Me.col_tipo.Text = "Tipo"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblGeral)
        Me.Panel1.Controls.Add(Me.txt_caixa_geral)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(393, 87)
        Me.Panel1.TabIndex = 4
        '
        'lblGeral
        '
        Me.lblGeral.AutoSize = True
        Me.lblGeral.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblGeral.ForeColor = System.Drawing.Color.White
        Me.lblGeral.Location = New System.Drawing.Point(1, 1)
        Me.lblGeral.Name = "lblGeral"
        Me.lblGeral.Size = New System.Drawing.Size(33, 13)
        Me.lblGeral.TabIndex = 16
        Me.lblGeral.Text = "Caixa"
        '
        'txt_caixa_geral
        '
        Me.txt_caixa_geral.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_caixa_geral.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_caixa_geral.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_caixa_geral.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_caixa_geral.ForeColor = System.Drawing.Color.Maroon
        Me.txt_caixa_geral.Location = New System.Drawing.Point(5, 23)
        Me.txt_caixa_geral.Name = "txt_caixa_geral"
        Me.txt_caixa_geral.ReadOnly = True
        Me.txt_caixa_geral.Size = New System.Drawing.Size(385, 40)
        Me.txt_caixa_geral.TabIndex = 13
        Me.txt_caixa_geral.Text = "0,00"
        Me.txt_caixa_geral.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Green
        Me.Panel3.Controls.Add(Me.txt_planejamento)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.txt_saldo_mes)
        Me.Panel3.Controls.Add(Me.txt_apagar_mes)
        Me.Panel3.Controls.Add(Me.txt_pago_mes)
        Me.Panel3.Controls.Add(Me.txt_despesa_mes)
        Me.Panel3.Controls.Add(Me.txt_receita_mes)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 96)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(393, 87)
        Me.Panel3.TabIndex = 6
        '
        'txt_planejamento
        '
        Me.txt_planejamento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_planejamento.Location = New System.Drawing.Point(267, 58)
        Me.txt_planejamento.Name = "txt_planejamento"
        Me.txt_planejamento.ReadOnly = True
        Me.txt_planejamento.Size = New System.Drawing.Size(65, 13)
        Me.txt_planejamento.TabIndex = 31
        Me.txt_planejamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(192, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Planejamento:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Green
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Mês"
        '
        'txt_saldo_mes
        '
        Me.txt_saldo_mes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_saldo_mes.Location = New System.Drawing.Point(267, 37)
        Me.txt_saldo_mes.Name = "txt_saldo_mes"
        Me.txt_saldo_mes.ReadOnly = True
        Me.txt_saldo_mes.Size = New System.Drawing.Size(65, 13)
        Me.txt_saldo_mes.TabIndex = 28
        Me.txt_saldo_mes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_apagar_mes
        '
        Me.txt_apagar_mes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_apagar_mes.Location = New System.Drawing.Point(267, 15)
        Me.txt_apagar_mes.Name = "txt_apagar_mes"
        Me.txt_apagar_mes.ReadOnly = True
        Me.txt_apagar_mes.Size = New System.Drawing.Size(65, 13)
        Me.txt_apagar_mes.TabIndex = 27
        Me.txt_apagar_mes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_pago_mes
        '
        Me.txt_pago_mes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_pago_mes.Location = New System.Drawing.Point(114, 58)
        Me.txt_pago_mes.Name = "txt_pago_mes"
        Me.txt_pago_mes.ReadOnly = True
        Me.txt_pago_mes.Size = New System.Drawing.Size(65, 13)
        Me.txt_pago_mes.TabIndex = 25
        Me.txt_pago_mes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_despesa_mes
        '
        Me.txt_despesa_mes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_despesa_mes.Location = New System.Drawing.Point(114, 37)
        Me.txt_despesa_mes.Name = "txt_despesa_mes"
        Me.txt_despesa_mes.ReadOnly = True
        Me.txt_despesa_mes.Size = New System.Drawing.Size(65, 13)
        Me.txt_despesa_mes.TabIndex = 24
        Me.txt_despesa_mes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_receita_mes
        '
        Me.txt_receita_mes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_receita_mes.Location = New System.Drawing.Point(114, 15)
        Me.txt_receita_mes.Name = "txt_receita_mes"
        Me.txt_receita_mes.ReadOnly = True
        Me.txt_receita_mes.Size = New System.Drawing.Size(65, 13)
        Me.txt_receita_mes.TabIndex = 23
        Me.txt_receita_mes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(192, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Saldo:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(192, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "A Pagar:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Pago:"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(61, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Despesa:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(61, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Receita:"
        '
        'tspGrc
        '
        Me.tspGrc.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stbIncluir, Me.stbEditar, Me.stbExcluir, Me.stsSeparador1, Me.stlMesAno, Me.sttMesAno, Me.stbPesquisar, Me.stlRaiz, Me.sttRaiz, Me.stbPesquisarRaiz, Me.stlTitulo, Me.sttTitulo, Me.stbPesquisarTitulo})
        Me.tspGrc.Location = New System.Drawing.Point(0, 0)
        Me.tspGrc.Name = "tspGrc"
        Me.tspGrc.Size = New System.Drawing.Size(1130, 25)
        Me.tspGrc.TabIndex = 0
        '
        'stbIncluir
        '
        Me.stbIncluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.stbIncluir.Image = CType(resources.GetObject("stbIncluir.Image"), System.Drawing.Image)
        Me.stbIncluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.stbIncluir.Name = "stbIncluir"
        Me.stbIncluir.Size = New System.Drawing.Size(23, 22)
        Me.stbIncluir.Text = "Incluir"
        Me.stbIncluir.ToolTipText = "Incluir"
        Me.stbIncluir.Visible = False
        '
        'stbEditar
        '
        Me.stbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.stbEditar.Image = CType(resources.GetObject("stbEditar.Image"), System.Drawing.Image)
        Me.stbEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.stbEditar.Name = "stbEditar"
        Me.stbEditar.Size = New System.Drawing.Size(23, 22)
        Me.stbEditar.Text = "Editar"
        Me.stbEditar.ToolTipText = "Editar"
        Me.stbEditar.Visible = False
        '
        'stbExcluir
        '
        Me.stbExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.stbExcluir.Image = CType(resources.GetObject("stbExcluir.Image"), System.Drawing.Image)
        Me.stbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.stbExcluir.Name = "stbExcluir"
        Me.stbExcluir.Size = New System.Drawing.Size(23, 22)
        Me.stbExcluir.Text = "Excluir"
        Me.stbExcluir.ToolTipText = "Excluir"
        Me.stbExcluir.Visible = False
        '
        'stsSeparador1
        '
        Me.stsSeparador1.Name = "stsSeparador1"
        Me.stsSeparador1.Size = New System.Drawing.Size(6, 25)
        Me.stsSeparador1.Visible = False
        '
        'stlMesAno
        '
        Me.stlMesAno.Name = "stlMesAno"
        Me.stlMesAno.Size = New System.Drawing.Size(59, 22)
        Me.stlMesAno.Text = "Mês/Ano:"
        Me.stlMesAno.Visible = False
        '
        'sttMesAno
        '
        Me.sttMesAno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.sttMesAno.Name = "sttMesAno"
        Me.sttMesAno.Size = New System.Drawing.Size(100, 25)
        Me.sttMesAno.Visible = False
        '
        'stbPesquisar
        '
        Me.stbPesquisar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.stbPesquisar.Image = CType(resources.GetObject("stbPesquisar.Image"), System.Drawing.Image)
        Me.stbPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.stbPesquisar.Name = "stbPesquisar"
        Me.stbPesquisar.Size = New System.Drawing.Size(23, 22)
        Me.stbPesquisar.ToolTipText = "Pesquisar"
        Me.stbPesquisar.Visible = False
        '
        'stlRaiz
        '
        Me.stlRaiz.Name = "stlRaiz"
        Me.stlRaiz.Size = New System.Drawing.Size(31, 22)
        Me.stlRaiz.Text = "Raiz:"
        Me.stlRaiz.Visible = False
        '
        'sttRaiz
        '
        Me.sttRaiz.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.sttRaiz.Name = "sttRaiz"
        Me.sttRaiz.Size = New System.Drawing.Size(100, 25)
        Me.sttRaiz.Visible = False
        '
        'stbPesquisarRaiz
        '
        Me.stbPesquisarRaiz.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.stbPesquisarRaiz.Image = CType(resources.GetObject("stbPesquisarRaiz.Image"), System.Drawing.Image)
        Me.stbPesquisarRaiz.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.stbPesquisarRaiz.Name = "stbPesquisarRaiz"
        Me.stbPesquisarRaiz.Size = New System.Drawing.Size(23, 22)
        Me.stbPesquisarRaiz.Visible = False
        '
        'stlTitulo
        '
        Me.stlTitulo.Name = "stlTitulo"
        Me.stlTitulo.Size = New System.Drawing.Size(40, 22)
        Me.stlTitulo.Text = "Título:"
        Me.stlTitulo.Visible = False
        '
        'sttTitulo
        '
        Me.sttTitulo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.sttTitulo.Name = "sttTitulo"
        Me.sttTitulo.Size = New System.Drawing.Size(100, 25)
        Me.sttTitulo.Visible = False
        '
        'stbPesquisarTitulo
        '
        Me.stbPesquisarTitulo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.stbPesquisarTitulo.Image = CType(resources.GetObject("stbPesquisarTitulo.Image"), System.Drawing.Image)
        Me.stbPesquisarTitulo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.stbPesquisarTitulo.Name = "stbPesquisarTitulo"
        Me.stbPesquisarTitulo.Size = New System.Drawing.Size(23, 22)
        Me.stbPesquisarTitulo.Text = "ToolStripButton1"
        Me.stbPesquisarTitulo.Visible = False
        '
        'img
        '
        Me.img.ImageStream = CType(resources.GetObject("img.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img.TransparentColor = System.Drawing.Color.Transparent
        Me.img.Images.SetKeyName(0, "incluir")
        Me.img.Images.SetKeyName(1, "excluir")
        Me.img.Images.SetKeyName(2, "editar")
        Me.img.Images.SetKeyName(3, "pesquisar")
        Me.img.Images.SetKeyName(4, "pagar")
        Me.img.Images.SetKeyName(5, "conta")
        Me.img.Images.SetKeyName(6, "movimento")
        Me.img.Images.SetKeyName(7, "checked")
        Me.img.Images.SetKeyName(8, "cartao")
        Me.img.Images.SetKeyName(9, "titulo")
        Me.img.Images.SetKeyName(10, "parcela")
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1331, 724)
        Me.Controls.Add(Me.splPrincipal)
        Me.Controls.Add(Me.sstTitulo)
        Me.Controls.Add(Me.mnuPrincipal)
        Me.MainMenuStrip = Me.mnuPrincipal
        Me.Name = "frmPrincipal"
        Me.Text = "CFF"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuPrincipal.ResumeLayout(False)
        Me.mnuPrincipal.PerformLayout()
        Me.sstTitulo.ResumeLayout(False)
        Me.sstTitulo.PerformLayout()
        Me.splPrincipal.Panel1.ResumeLayout(False)
        Me.splPrincipal.Panel2.ResumeLayout(False)
        Me.splPrincipal.Panel2.PerformLayout()
        CType(Me.splPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splPrincipal.ResumeLayout(False)
        Me.splExibicao.Panel1.ResumeLayout(False)
        Me.splExibicao.Panel2.ResumeLayout(False)
        CType(Me.splExibicao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splExibicao.ResumeLayout(False)
        CType(Me.dgvGrc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbcResumo.ResumeLayout(False)
        Me.tbpCartao.ResumeLayout(False)
        Me.tlpResumoCartao.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.tbpTitulo.ResumeLayout(False)
        Me.tlpResumoTitulo.ResumeLayout(False)
        CType(Me.chtDebito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtCredito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.tspGrc.ResumeLayout(False)
        Me.tspGrc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imnMovimento As ToolStripMenuItem
    Friend WithEvents imnConta As ToolStripMenuItem
    Friend WithEvents imnLancamento As ToolStripMenuItem
    Friend WithEvents imnSair As ToolStripMenuItem
    Friend WithEvents mnuPrincipal As MenuStrip
    Friend WithEvents sstTitulo As StatusStrip
    Friend WithEvents splPrincipal As SplitContainer
    Friend WithEvents trwPrincipal As TreeView
    Friend WithEvents tspGrc As ToolStrip
    Friend WithEvents stbIncluir As ToolStripButton
    Friend WithEvents stbEditar As ToolStripButton
    Friend WithEvents stbExcluir As ToolStripButton
    Friend WithEvents img As ImageList
    Friend WithEvents imnTitulo As ToolStripMenuItem
    Friend WithEvents stsSeparador1 As ToolStripSeparator
    Friend WithEvents sttMesAno As ToolStripTextBox
    Friend WithEvents stbPesquisar As ToolStripButton
    Friend WithEvents stlRaiz As ToolStripLabel
    Friend WithEvents sttRaiz As ToolStripTextBox
    Friend WithEvents stbPesquisarRaiz As ToolStripButton
    Friend WithEvents imnCartaoCadastro As ToolStripMenuItem
    Friend WithEvents imnCartaoMovimento As ToolStripMenuItem
    Friend WithEvents stlTitulo As ToolStripLabel
    Friend WithEvents sttTitulo As ToolStripTextBox
    Friend WithEvents stbPesquisarTitulo As ToolStripButton
    Friend WithEvents stlMesAno As ToolStripLabel
    Friend WithEvents splExibicao As SplitContainer
    Friend WithEvents dgvGrc As DataGridView
    Friend WithEvents lbl_datatit As ToolStripStatusLabel
    Friend WithEvents lbl_dataval As ToolStripStatusLabel
    Friend WithEvents tbcResumo As TabControl
    Friend WithEvents tbpTitulo As TabPage
    Friend WithEvents tlpResumoTitulo As TableLayoutPanel
    Friend WithEvents lstConta As ListView
    Friend WithEvents col_conta As ColumnHeader
    Friend WithEvents col_total As ColumnHeader
    Friend WithEvents col_tipo As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_caixa_geral As TextBox
    Friend WithEvents tbpCartao As TabPage
    Friend WithEvents tlpResumoCartao As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_vencimento_cartao As TextBox
    Friend WithEvents txt_total_cartao As TextBox
    Friend WithEvents lbl_vencimento_cartao As Label
    Friend WithEvents lbl_total_cartao As Label
    Friend WithEvents chtDebito As DataVisualization.Charting.Chart
    Friend WithEvents chtCredito As DataVisualization.Charting.Chart
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblGeral As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_saldo_mes As TextBox
    Friend WithEvents txt_apagar_mes As TextBox
    Friend WithEvents txt_pago_mes As TextBox
    Friend WithEvents txt_despesa_mes As TextBox
    Friend WithEvents txt_receita_mes As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_planejamento As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ImnParcelamento As ToolStripMenuItem
End Class
