<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSobre
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmSobre))
        pnCentral = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label2 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        lblTitulo = New Label()
        blProduto = New Label()
        lblCopy = New Label()
        lblEmpresa = New Label()
        lblDescricao = New Label()
        Label9 = New Label()
        Button2 = New Button()
        pnCentral.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnCentral
        ' 
        pnCentral.AutoScroll = True
        pnCentral.BackColor = SystemColors.ControlLight
        pnCentral.Controls.Add(Label4)
        pnCentral.Controls.Add(Label3)
        pnCentral.Dock = DockStyle.Top
        pnCentral.Location = New Point(0, 0)
        pnCentral.Name = "pnCentral"
        pnCentral.Size = New Size(800, 50)
        pnCentral.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Corbel", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(28, 26)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 18)
        Label4.TabIndex = 0
        Label4.Text = "Painel / Sobre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(28, 3)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 24)
        Label3.TabIndex = 0
        Label3.Text = "Painel"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Window
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(TableLayoutPanel1)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(15, 58)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(773, 380)
        Panel1.TabIndex = 4
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.system_applications_thesource_thebook_13028
        PictureBox1.Location = New Point(691, 15)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(64, 64)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(32, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(182, 41)
        Label1.TabIndex = 1
        Label1.Text = "Informações"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15.11254F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 84.88746F))
        TableLayoutPanel1.Controls.Add(Label2, 0, 0)
        TableLayoutPanel1.Controls.Add(Label5, 0, 1)
        TableLayoutPanel1.Controls.Add(Label6, 0, 2)
        TableLayoutPanel1.Controls.Add(Label7, 0, 3)
        TableLayoutPanel1.Controls.Add(Label8, 0, 4)
        TableLayoutPanel1.Controls.Add(lblTitulo, 1, 0)
        TableLayoutPanel1.Controls.Add(lblDescricao, 1, 1)
        TableLayoutPanel1.Controls.Add(lblEmpresa, 1, 2)
        TableLayoutPanel1.Controls.Add(blProduto, 1, 3)
        TableLayoutPanel1.Controls.Add(lblCopy, 1, 4)
        TableLayoutPanel1.Location = New Point(43, 68)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 5
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.Size = New Size(622, 200)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Fill
        Label2.Location = New Point(3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 40)
        Label2.TabIndex = 0
        Label2.Text = "Titulo"
        Label2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Dock = DockStyle.Fill
        Label5.Location = New Point(3, 40)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 40)
        Label5.TabIndex = 0
        Label5.Text = "Descrição"
        Label5.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Dock = DockStyle.Fill
        Label6.Location = New Point(3, 80)
        Label6.Name = "Label6"
        Label6.Size = New Size(88, 40)
        Label6.TabIndex = 0
        Label6.Text = "Empresa"
        Label6.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Dock = DockStyle.Fill
        Label7.Location = New Point(3, 120)
        Label7.Name = "Label7"
        Label7.Size = New Size(88, 40)
        Label7.TabIndex = 0
        Label7.Text = "Produto"
        Label7.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Dock = DockStyle.Fill
        Label8.Location = New Point(3, 160)
        Label8.Name = "Label8"
        Label8.Size = New Size(88, 40)
        Label8.TabIndex = 0
        Label8.Text = "Copyright"
        Label8.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Dock = DockStyle.Left
        lblTitulo.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitulo.Location = New Point(97, 0)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(50, 40)
        lblTitulo.TabIndex = 1
        lblTitulo.Text = "Titulo"
        lblTitulo.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' blProduto
        ' 
        blProduto.AutoSize = True
        blProduto.Dock = DockStyle.Left
        blProduto.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        blProduto.Location = New Point(97, 120)
        blProduto.Name = "blProduto"
        blProduto.Size = New Size(66, 40)
        blProduto.TabIndex = 1
        blProduto.Text = "Produto"
        blProduto.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblCopy
        ' 
        lblCopy.AutoSize = True
        lblCopy.Dock = DockStyle.Left
        lblCopy.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblCopy.Location = New Point(97, 160)
        lblCopy.Name = "lblCopy"
        lblCopy.Size = New Size(44, 40)
        lblCopy.TabIndex = 1
        lblCopy.Text = "Copy"
        lblCopy.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblEmpresa
        ' 
        lblEmpresa.AutoSize = True
        lblEmpresa.Dock = DockStyle.Left
        lblEmpresa.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblEmpresa.Location = New Point(97, 80)
        lblEmpresa.Name = "lblEmpresa"
        lblEmpresa.Size = New Size(69, 40)
        lblEmpresa.TabIndex = 1
        lblEmpresa.Text = "Empresa"
        lblEmpresa.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblDescricao
        ' 
        lblDescricao.AutoSize = True
        lblDescricao.Dock = DockStyle.Left
        lblDescricao.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblDescricao.Location = New Point(97, 40)
        lblDescricao.Name = "lblDescricao"
        lblDescricao.Size = New Size(76, 40)
        lblDescricao.TabIndex = 1
        lblDescricao.Text = "Descricao"
        lblDescricao.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(32, 281)
        Label9.Name = "Label9"
        Label9.Size = New Size(331, 41)
        Label9.TabIndex = 1
        Label9.Text = "Gostaria de saber mais?"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(94), CByte(186), CByte(149))
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = SystemColors.Window
        Button2.Location = New Point(32, 325)
        Button2.Name = "Button2"
        Button2.Size = New Size(723, 52)
        Button2.TabIndex = 5
        Button2.Text = "Entre em contato para maiores informações"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' frmSobre
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(pnCentral)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmSobre"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sobre"
        pnCentral.ResumeLayout(False)
        pnCentral.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnCentral As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblCopy As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblEmpresa As Label
    Friend WithEvents lblDescricao As Label
    Friend WithEvents blProduto As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button
End Class
