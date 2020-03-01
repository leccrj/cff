<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConta
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.txtObservacao = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdGravar = New System.Windows.Forms.Button()
        Me.cmdSair = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtOrdem = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.corDlg = New System.Windows.Forms.ColorDialog()
        Me.cmdCor = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Descrição: *"
        '
        'txtDescricao
        '
        Me.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescricao.Location = New System.Drawing.Point(79, 67)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(288, 20)
        Me.txtDescricao.TabIndex = 1
        '
        'txtObservacao
        '
        Me.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservacao.Location = New System.Drawing.Point(12, 177)
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(485, 60)
        Me.txtObservacao.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Observação:"
        '
        'cmdGravar
        '
        Me.cmdGravar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdGravar.Location = New System.Drawing.Point(343, 253)
        Me.cmdGravar.Name = "cmdGravar"
        Me.cmdGravar.Size = New System.Drawing.Size(74, 21)
        Me.cmdGravar.TabIndex = 6
        Me.cmdGravar.Text = "Gravar"
        Me.cmdGravar.UseVisualStyleBackColor = True
        '
        'cmdSair
        '
        Me.cmdSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSair.Location = New System.Drawing.Point(423, 253)
        Me.cmdSair.Name = "cmdSair"
        Me.cmdSair.Size = New System.Drawing.Size(74, 21)
        Me.cmdSair.TabIndex = 7
        Me.cmdSair.Text = "Sair"
        Me.cmdSair.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Tipo: *"
        '
        'cmbTipo
        '
        Me.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Items.AddRange(New Object() {"Débito", "Crédito"})
        Me.cmbTipo.Location = New System.Drawing.Point(79, 93)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(126, 21)
        Me.cmbTipo.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Ordem:"
        '
        'txtOrdem
        '
        Me.txtOrdem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrdem.Location = New System.Drawing.Point(79, 120)
        Me.txtOrdem.Name = "txtOrdem"
        Me.txtOrdem.Size = New System.Drawing.Size(33, 20)
        Me.txtOrdem.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtCodigo)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(509, 51)
        Me.Panel1.TabIndex = 12
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
        Me.txtCodigo.Text = " "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Código:"
        '
        'cmdCor
        '
        Me.cmdCor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCor.Location = New System.Drawing.Point(384, 67)
        Me.cmdCor.Name = "cmdCor"
        Me.cmdCor.Size = New System.Drawing.Size(52, 20)
        Me.cmdCor.TabIndex = 15
        Me.cmdCor.Text = "Cor"
        Me.cmdCor.UseVisualStyleBackColor = True
        '
        'frmConta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 286)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCor)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtOrdem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdSair)
        Me.Controls.Add(Me.cmdGravar)
        Me.Controls.Add(Me.txtObservacao)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmConta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "conta"
        Me.Text = "Conta"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents txtObservacao As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdGravar As Button
    Friend WithEvents cmdSair As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtOrdem As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents corDlg As ColorDialog
    Friend WithEvents cmdCor As Button
End Class
