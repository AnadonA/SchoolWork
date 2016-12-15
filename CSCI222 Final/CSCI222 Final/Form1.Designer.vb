<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
      Me.mnuMain = New System.Windows.Forms.MenuStrip()
      Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.btnNewGame = New System.Windows.Forms.ToolStripMenuItem()
      Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
      Me.btnExitGame = New System.Windows.Forms.ToolStripMenuItem()
      Me.btnHelp = New System.Windows.Forms.ToolStripMenuItem()
      Me.btnTerminal = New System.Windows.Forms.ToolStripMenuItem()
      Me.pbxDefaultCard = New System.Windows.Forms.PictureBox()
      Me.mnuMain.SuspendLayout()
      CType(Me.pbxDefaultCard, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'mnuMain
      '
      Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.btnHelp})
      Me.mnuMain.Location = New System.Drawing.Point(0, 0)
      Me.mnuMain.Name = "mnuMain"
      Me.mnuMain.Size = New System.Drawing.Size(784, 24)
      Me.mnuMain.TabIndex = 0
      Me.mnuMain.Text = "MenuStrip1"
      '
      'FileToolStripMenuItem
      '
      Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNewGame, Me.ToolStripSeparator1, Me.btnExitGame})
      Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
      Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
      Me.FileToolStripMenuItem.Text = "&File"
      '
      'btnNewGame
      '
      Me.btnNewGame.Name = "btnNewGame"
      Me.btnNewGame.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
      Me.btnNewGame.Size = New System.Drawing.Size(175, 22)
      Me.btnNewGame.Text = "&New Game"
      '
      'ToolStripSeparator1
      '
      Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
      Me.ToolStripSeparator1.Size = New System.Drawing.Size(172, 6)
      '
      'btnExitGame
      '
      Me.btnExitGame.Name = "btnExitGame"
      Me.btnExitGame.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
      Me.btnExitGame.Size = New System.Drawing.Size(175, 22)
      Me.btnExitGame.Text = "E&xit Game"
      '
      'btnHelp
      '
      Me.btnHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnTerminal})
      Me.btnHelp.Name = "btnHelp"
      Me.btnHelp.Size = New System.Drawing.Size(44, 20)
      Me.btnHelp.Text = "&Help"
      '
      'btnTerminal
      '
      Me.btnTerminal.Name = "btnTerminal"
      Me.btnTerminal.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
      Me.btnTerminal.Size = New System.Drawing.Size(193, 22)
      Me.btnTerminal.Text = "&Terminal"
      Me.btnTerminal.Visible = False
      '
      'pbxDefaultCard
      '
      Me.pbxDefaultCard.Image = Global.CSCI222_Final.My.Resources.Resources.ME_Backs__4_
      Me.pbxDefaultCard.InitialImage = Global.CSCI222_Final.My.Resources.Resources.Mass_Effect_card_deck
      Me.pbxDefaultCard.Location = New System.Drawing.Point(11, 26)
      Me.pbxDefaultCard.Margin = New System.Windows.Forms.Padding(2)
      Me.pbxDefaultCard.Name = "pbxDefaultCard"
      Me.pbxDefaultCard.Size = New System.Drawing.Size(70, 102)
      Me.pbxDefaultCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
      Me.pbxDefaultCard.TabIndex = 1
      Me.pbxDefaultCard.TabStop = False
      '
      'frmMain
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
      Me.ClientSize = New System.Drawing.Size(784, 561)
      Me.Controls.Add(Me.pbxDefaultCard)
      Me.Controls.Add(Me.mnuMain)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.MainMenuStrip = Me.mnuMain
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmMain"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "CSCI222 Final Project AAnadon"
      Me.mnuMain.ResumeLayout(False)
      Me.mnuMain.PerformLayout()
      CType(Me.pbxDefaultCard, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents mnuMain As MenuStrip
   Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
   Friend WithEvents btnNewGame As ToolStripMenuItem
   Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
   Friend WithEvents btnExitGame As ToolStripMenuItem
   Friend WithEvents btnHelp As ToolStripMenuItem
   Friend WithEvents btnTerminal As ToolStripMenuItem
   Friend WithEvents pbxDefaultCard As PictureBox
End Class
