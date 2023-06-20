
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAjuda
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnCentral = New Panel()
        MenuStrip2 = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        ToolStripMenuItem3 = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        ToolStripMenuItem4 = New ToolStripMenuItem()
        Label4 = New Label()
        Label3 = New Label()
        Panel1 = New Panel()
        Button2 = New Button()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Label7 = New Label()
        Label5 = New Label()
        Panel3 = New Panel()
        Label8 = New Label()
        Label6 = New Label()
        pnCentral.SuspendLayout()
        MenuStrip2.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnCentral
        ' 
        pnCentral.BackColor = SystemColors.ControlLight
        pnCentral.Controls.Add(MenuStrip2)
        pnCentral.Controls.Add(Label4)
        pnCentral.Controls.Add(Label3)
        pnCentral.Dock = DockStyle.Top
        pnCentral.Location = New Point(0, 0)
        pnCentral.Name = "pnCentral"
        pnCentral.Size = New Size(800, 50)
        pnCentral.TabIndex = 3
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        MenuStrip2.AutoSize = False
        MenuStrip2.BackColor = Color.Transparent
        MenuStrip2.Dock = DockStyle.None
        MenuStrip2.ImageScalingSize = New Size(20, 20)
        MenuStrip2.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1})
        MenuStrip2.Location = New Point(1245, 16)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Size = New Size(113, 24)
        MenuStrip2.TabIndex = 5
        MenuStrip2.Text = "MenuStrip2"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem2, ToolStripMenuItem3, ToolStripSeparator1, ToolStripMenuItem4})
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(130, 20)
        ToolStripMenuItem1.Text = "Opções Rapidas"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Image = My.Resources.Resources.user_icon_icons_com_57997
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(208, 26)
        ToolStripMenuItem2.Text = "Opções"
        ToolStripMenuItem2.TextImageRelation = TextImageRelation.TextBeforeImage
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.Image = My.Resources.Resources.fullconfiguration_settings_4501
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.Size = New Size(208, 26)
        ToolStripMenuItem3.Text = "Configurações"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(205, 6)
        ' 
        ' ToolStripMenuItem4
        ' 
        ToolStripMenuItem4.Image = My.Resources.Resources.lock_padlock_symbol_for_protect_icon_icons_com_56926
        ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        ToolStripMenuItem4.Size = New Size(208, 26)
        ToolStripMenuItem4.Text = "Bloquear Sistema"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Corbel", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(28, 26)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 18)
        Label4.TabIndex = 0
        Label4.Text = "Painel / Ajuda"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Corbel", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
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
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(12, 56)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(407, 485)
        Panel1.TabIndex = 4
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(94), CByte(186), CByte(149))
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = SystemColors.Window
        Button2.Location = New Point(30, 81)
        Button2.Name = "Button2"
        Button2.Size = New Size(332, 52)
        Button2.TabIndex = 1
        Button2.Text = "Duvidas? Entre em contato."
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(30, 155)
        Label2.Name = "Label2"
        Label2.Size = New Size(243, 37)
        Label2.TabIndex = 0
        Label2.Text = "Algumas Questões."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(30, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(332, 37)
        Label1.TabIndex = 0
        Label1.Text = "Como podemos te ajudar?"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(94), CByte(186), CByte(149))
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label5)
        Panel2.Location = New Point(425, 56)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(363, 226)
        Panel2.TabIndex = 5
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = SystemColors.Window
        Label7.Location = New Point(24, 81)
        Label7.Name = "Label7"
        Label7.Size = New Size(312, 52)
        Label7.TabIndex = 0
        Label7.Text = "O Sistema está atualizado para pagamento mensal."
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 16.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.Window
        Label5.Location = New Point(24, 32)
        Label5.Name = "Label5"
        Label5.Size = New Size(194, 37)
        Label5.TabIndex = 0
        Label5.Text = "Licença de Uso"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(94), CByte(186), CByte(149))
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(Label6)
        Panel3.Location = New Point(425, 288)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(363, 226)
        Panel3.TabIndex = 6
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = SystemColors.Window
        Label8.Location = New Point(24, 86)
        Label8.Name = "Label8"
        Label8.Size = New Size(312, 52)
        Label8.TabIndex = 0
        Label8.Text = "Toda para relacionada a atualização do ssitema será avisada antes."
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 16.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.Window
        Label6.Location = New Point(24, 32)
        Label6.Name = "Label6"
        Label6.Size = New Size(264, 37)
        Label6.TabIndex = 0
        Label6.Text = "Updates & Downloads"
        ' 
        ' frmAjuda
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 553)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(pnCentral)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmAjuda"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Ajuda"
        pnCentral.ResumeLayout(False)
        pnCentral.PerformLayout()
        MenuStrip2.ResumeLayout(False)
        MenuStrip2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnCentral As Panel
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
End Class
