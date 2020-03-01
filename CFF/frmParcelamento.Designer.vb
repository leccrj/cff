<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParcelamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParcelamento))
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblDescricao = New System.Windows.Forms.Label()
        Me.TxtDescricao = New System.Windows.Forms.TextBox()
        Me.lblQtdParcelas = New System.Windows.Forms.Label()
        Me.TxtQtdParcela = New System.Windows.Forms.TextBox()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.TxtTitulo = New System.Windows.Forms.TextBox()
        Me.LblValor = New System.Windows.Forms.Label()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtpDataInicio = New System.Windows.Forms.DateTimePicker()
        Me.img = New System.Windows.Forms.ImageList(Me.components)
        Me.LblObservacao = New System.Windows.Forms.Label()
        Me.TxtObservacao = New System.Windows.Forms.TextBox()
        Me.CmdSair = New System.Windows.Forms.Button()
        Me.CmdGravar = New System.Windows.Forms.Button()
        Me.ChkGerarParcela = New System.Windows.Forms.CheckBox()
        Me.CmdPesquisaTitulo = New System.Windows.Forms.Button()
        Me.ChkEntrada = New System.Windows.Forms.CheckBox()
        Me.TxtEntrada = New System.Windows.Forms.TextBox()
        Me.ChkGerarTitulo = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtCodigo
        '
        Me.TxtCodigo.BackColor = System.Drawing.Color.Silver
        Me.TxtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCodigo.ForeColor = System.Drawing.Color.White
        resources.ApplyResources(Me.TxtCodigo, "TxtCodigo")
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.ReadOnly = True
        Me.TxtCodigo.TabStop = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TxtCodigo)
        Me.Panel1.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Name = "Panel1"
        '
        'LblDescricao
        '
        resources.ApplyResources(Me.LblDescricao, "LblDescricao")
        Me.LblDescricao.Name = "LblDescricao"
        '
        'TxtDescricao
        '
        Me.TxtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.TxtDescricao, "TxtDescricao")
        Me.TxtDescricao.Name = "TxtDescricao"
        '
        'lblQtdParcelas
        '
        resources.ApplyResources(Me.lblQtdParcelas, "lblQtdParcelas")
        Me.lblQtdParcelas.Name = "lblQtdParcelas"
        '
        'TxtQtdParcela
        '
        Me.TxtQtdParcela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.TxtQtdParcela, "TxtQtdParcela")
        Me.TxtQtdParcela.Name = "TxtQtdParcela"
        '
        'LblTitulo
        '
        resources.ApplyResources(Me.LblTitulo, "LblTitulo")
        Me.LblTitulo.Name = "LblTitulo"
        '
        'TxtTitulo
        '
        Me.TxtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.TxtTitulo, "TxtTitulo")
        Me.TxtTitulo.Name = "TxtTitulo"
        Me.TxtTitulo.TabStop = False
        '
        'LblValor
        '
        resources.ApplyResources(Me.LblValor, "LblValor")
        Me.LblValor.Name = "LblValor"
        '
        'TxtValor
        '
        Me.TxtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.TxtValor, "TxtValor")
        Me.TxtValor.Name = "TxtValor"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'DtpDataInicio
        '
        Me.DtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        resources.ApplyResources(Me.DtpDataInicio, "DtpDataInicio")
        Me.DtpDataInicio.Name = "DtpDataInicio"
        '
        'img
        '
        Me.img.ImageStream = CType(resources.GetObject("img.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img.TransparentColor = System.Drawing.Color.Transparent
        Me.img.Images.SetKeyName(0, "pesquisar")
        Me.img.Images.SetKeyName(1, "gravar")
        Me.img.Images.SetKeyName(2, "sair")
        '
        'LblObservacao
        '
        resources.ApplyResources(Me.LblObservacao, "LblObservacao")
        Me.LblObservacao.Name = "LblObservacao"
        '
        'TxtObservacao
        '
        Me.TxtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.TxtObservacao, "TxtObservacao")
        Me.TxtObservacao.Name = "TxtObservacao"
        '
        'CmdSair
        '
        Me.CmdSair.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdSair.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.CmdSair, "CmdSair")
        Me.CmdSair.ImageList = Me.img
        Me.CmdSair.Name = "CmdSair"
        Me.CmdSair.UseVisualStyleBackColor = True
        '
        'CmdGravar
        '
        Me.CmdGravar.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.CmdGravar, "CmdGravar")
        Me.CmdGravar.ImageList = Me.img
        Me.CmdGravar.Name = "CmdGravar"
        Me.CmdGravar.UseVisualStyleBackColor = True
        '
        'ChkGerarParcela
        '
        resources.ApplyResources(Me.ChkGerarParcela, "ChkGerarParcela")
        Me.ChkGerarParcela.Name = "ChkGerarParcela"
        Me.ChkGerarParcela.TabStop = False
        Me.ChkGerarParcela.UseVisualStyleBackColor = True
        '
        'CmdPesquisaTitulo
        '
        Me.CmdPesquisaTitulo.BackColor = System.Drawing.SystemColors.Control
        Me.CmdPesquisaTitulo.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.CmdPesquisaTitulo, "CmdPesquisaTitulo")
        Me.CmdPesquisaTitulo.ImageList = Me.img
        Me.CmdPesquisaTitulo.Name = "CmdPesquisaTitulo"
        Me.CmdPesquisaTitulo.TabStop = False
        Me.CmdPesquisaTitulo.UseVisualStyleBackColor = False
        '
        'ChkEntrada
        '
        resources.ApplyResources(Me.ChkEntrada, "ChkEntrada")
        Me.ChkEntrada.Name = "ChkEntrada"
        Me.ChkEntrada.TabStop = False
        Me.ChkEntrada.UseVisualStyleBackColor = True
        '
        'TxtEntrada
        '
        Me.TxtEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.TxtEntrada, "TxtEntrada")
        Me.TxtEntrada.Name = "TxtEntrada"
        Me.TxtEntrada.ReadOnly = True
        '
        'ChkGerarTitulo
        '
        resources.ApplyResources(Me.ChkGerarTitulo, "ChkGerarTitulo")
        Me.ChkGerarTitulo.Name = "ChkGerarTitulo"
        Me.ChkGerarTitulo.TabStop = False
        Me.ChkGerarTitulo.UseVisualStyleBackColor = True
        '
        'frmParcelamento
        '
        Me.AcceptButton = Me.CmdGravar
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CmdSair
        Me.ControlBox = False
        Me.Controls.Add(Me.ChkGerarTitulo)
        Me.Controls.Add(Me.TxtEntrada)
        Me.Controls.Add(Me.ChkEntrada)
        Me.Controls.Add(Me.ChkGerarParcela)
        Me.Controls.Add(Me.CmdSair)
        Me.Controls.Add(Me.CmdGravar)
        Me.Controls.Add(Me.TxtObservacao)
        Me.Controls.Add(Me.LblObservacao)
        Me.Controls.Add(Me.CmdPesquisaTitulo)
        Me.Controls.Add(Me.DtpDataInicio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtValor)
        Me.Controls.Add(Me.LblValor)
        Me.Controls.Add(Me.TxtTitulo)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.TxtQtdParcela)
        Me.Controls.Add(Me.lblQtdParcelas)
        Me.Controls.Add(Me.TxtDescricao)
        Me.Controls.Add(Me.LblDescricao)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmParcelamento"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblDescricao As Label
    Friend WithEvents TxtDescricao As TextBox
    Friend WithEvents lblQtdParcelas As Label
    Friend WithEvents TxtQtdParcela As TextBox
    Friend WithEvents LblTitulo As Label
    Friend WithEvents TxtTitulo As TextBox
    Friend WithEvents LblValor As Label
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DtpDataInicio As DateTimePicker
    Friend WithEvents CmdPesquisaTitulo As Button
    Friend WithEvents img As ImageList
    Friend WithEvents LblObservacao As Label
    Friend WithEvents TxtObservacao As TextBox
    Friend WithEvents CmdSair As Button
    Friend WithEvents CmdGravar As Button
    Friend WithEvents ChkGerarParcela As CheckBox
    Friend WithEvents ChkEntrada As CheckBox
    Friend WithEvents TxtEntrada As TextBox
    Friend WithEvents ChkGerarTitulo As CheckBox
End Class
