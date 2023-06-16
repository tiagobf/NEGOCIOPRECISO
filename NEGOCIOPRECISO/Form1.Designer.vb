<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        Button3 = New Button()
        StatusStrip1 = New StatusStrip()
        ToolStripDropDownButton1 = New ToolStripDropDownButton()
        PerfilToolStripMenuItem = New ToolStripMenuItem()
        ConfiguraçõesToolStripMenuItem = New ToolStripMenuItem()
        BloquearSistemaToolStripMenuItem = New ToolStripMenuItem()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        Panel4 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        Panel3 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        ToolTip1 = New ToolTip(components)
        Panel1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(StatusStrip1)
        Panel1.Controls.Add(PictureBox5)
        Panel1.Controls.Add(PictureBox6)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1033, 88)
        Panel1.TabIndex = 0
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button3.Location = New Point(928, 34)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 4
        Button3.Text = "Sair"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        StatusStrip1.BackColor = SystemColors.ActiveCaption
        StatusStrip1.Dock = DockStyle.None
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripDropDownButton1})
        StatusStrip1.Location = New Point(702, 29)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode
        StatusStrip1.Size = New Size(156, 38)
        StatusStrip1.TabIndex = 3
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripDropDownButton1
        ' 
        ToolStripDropDownButton1.DropDownItems.AddRange(New ToolStripItem() {PerfilToolStripMenuItem, ConfiguraçõesToolStripMenuItem, BloquearSistemaToolStripMenuItem})
        ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), Image)
        ToolStripDropDownButton1.ImageScaling = ToolStripItemImageScaling.None
        ToolStripDropDownButton1.ImageTransparentColor = Color.Magenta
        ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        ToolStripDropDownButton1.Size = New Size(139, 36)
        ToolStripDropDownButton1.Text = "Tiago Barreto"
        ToolStripDropDownButton1.TextImageRelation = TextImageRelation.TextBeforeImage
        ' 
        ' PerfilToolStripMenuItem
        ' 
        PerfilToolStripMenuItem.Name = "PerfilToolStripMenuItem"
        PerfilToolStripMenuItem.Size = New Size(208, 26)
        PerfilToolStripMenuItem.Text = "Perfil"
        ' 
        ' ConfiguraçõesToolStripMenuItem
        ' 
        ConfiguraçõesToolStripMenuItem.Name = "ConfiguraçõesToolStripMenuItem"
        ConfiguraçõesToolStripMenuItem.Size = New Size(208, 26)
        ConfiguraçõesToolStripMenuItem.Text = "Configurações"
        ' 
        ' BloquearSistemaToolStripMenuItem
        ' 
        BloquearSistemaToolStripMenuItem.Name = "BloquearSistemaToolStripMenuItem"
        BloquearSistemaToolStripMenuItem.Size = New Size(208, 26)
        BloquearSistemaToolStripMenuItem.Text = "Bloquear Sistema"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(518, 16)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(125, 62)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 1
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox6.Image = My.Resources.Resources.avatardefault_92824
        PictureBox6.Location = New Point(870, 23)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(50, 50)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 0
        PictureBox6.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(387, 16)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(125, 62)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 1
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(256, 16)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(125, 62)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 1
        PictureBox3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        PictureBox1.Image = My.Resources.Resources.logo_transparent
        PictureBox1.Location = New Point(-1, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(251, 88)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.GradientActiveCaption
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Panel4)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 88)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(250, 601)
        Panel2.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.GradientActiveCaption
        Button2.Cursor = Cursors.Hand
        Button2.Dock = DockStyle.Top
        Button2.FlatAppearance.BorderColor = SystemColors.GradientActiveCaption
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption
        Button2.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Corbel", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.ActiveCaptionText
        Button2.Image = My.Resources.Resources.users_clients_group_16774__1_
        Button2.ImageAlign = ContentAlignment.MiddleRight
        Button2.Location = New Point(0, 221)
        Button2.Name = "Button2"
        Button2.Size = New Size(250, 29)
        Button2.TabIndex = 2
        Button2.Text = "Clientes"
        Button2.TextImageRelation = TextImageRelation.ImageBeforeText
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Dock = DockStyle.Top
        Button1.FlatAppearance.BorderColor = SystemColors.ActiveCaption
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption
        Button1.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Corbel", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(0, 192)
        Button1.Name = "Button1"
        Button1.Size = New Size(250, 29)
        Button1.TabIndex = 1
        Button1.Text = "Navegação"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Label2)
        Panel4.Controls.Add(Label1)
        Panel4.Controls.Add(PictureBox2)
        Panel4.Dock = DockStyle.Top
        Panel4.Font = New Font("Corbel", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(250, 192)
        Panel4.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Corbel", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(97, 163)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 15)
        Label2.TabIndex = 1
        Label2.Text = "Gerente"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Corbel", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(80, 143)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 15)
        Label1.TabIndex = 1
        Label1.Text = "Tiago Barreto"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.avatardefault_92824
        PictureBox2.Location = New Point(44, 5)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(163, 122)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ControlLight
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label3)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(250, 88)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(783, 97)
        Panel3.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Corbel", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(27, 55)
        Label4.Name = "Label4"
        Label4.Size = New Size(186, 15)
        Label4.TabIndex = 0
        Label4.Text = "Painel / Resumo Geral do Sistema"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Corbel", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(27, 22)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 15)
        Label3.TabIndex = 0
        Label3.Text = "Painel"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1033, 689)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Footlight MT Light", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Negócio Preciso"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents PerfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguraçõesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BloquearSistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Button3 As Button
End Class
