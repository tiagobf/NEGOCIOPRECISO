﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAjuda
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
        Label1 = New Label()
        pnCentral.SuspendLayout()
        MenuStrip2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnCentral
        ' 
        pnCentral.AutoScroll = True
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
        Label4.Font = New Font("Corbel", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(28, 26)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 18)
        Label4.TabIndex = 0
        Label4.Text = "Painel / Ajuda"
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
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(12, 56)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(776, 382)
        Panel1.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(30, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 37)
        Label1.TabIndex = 0
        Label1.Text = "Label1"
        ' 
        ' frmAjuda
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(pnCentral)
        Name = "frmAjuda"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Ajuda"
        pnCentral.ResumeLayout(False)
        pnCentral.PerformLayout()
        MenuStrip2.ResumeLayout(False)
        MenuStrip2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
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
End Class
