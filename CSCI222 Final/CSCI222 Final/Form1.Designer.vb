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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
      Me.mnuMain = New System.Windows.Forms.MenuStrip()
      Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.btnNewGame = New System.Windows.Forms.ToolStripMenuItem()
      Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
      Me.btnExitGame = New System.Windows.Forms.ToolStripMenuItem()
      Me.btnHelp = New System.Windows.Forms.ToolStripMenuItem()
      Me.btnTerminal = New System.Windows.Forms.ToolStripMenuItem()
      Me.tbxMaze = New System.Windows.Forms.TextBox()
      Me.tabGroup = New System.Windows.Forms.TabControl()
      Me.tbTextual = New System.Windows.Forms.TabPage()
      Me.tbGraphic = New System.Windows.Forms.TabPage()
      Me.PictureBox2 = New System.Windows.Forms.PictureBox()
      Me.pbx1 = New System.Windows.Forms.PictureBox()
      Me.mnuMain.SuspendLayout()
      Me.tabGroup.SuspendLayout()
      Me.tbTextual.SuspendLayout()
      Me.tbGraphic.SuspendLayout()
      CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.pbx1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'mnuMain
      '
      Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.btnHelp})
      Me.mnuMain.Location = New System.Drawing.Point(0, 0)
      Me.mnuMain.Name = "mnuMain"
      Me.mnuMain.Size = New System.Drawing.Size(547, 24)
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
      'tbxMaze
      '
      Me.tbxMaze.Dock = System.Windows.Forms.DockStyle.Fill
      Me.tbxMaze.Enabled = False
      Me.tbxMaze.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.tbxMaze.HideSelection = False
      Me.tbxMaze.Location = New System.Drawing.Point(3, 3)
      Me.tbxMaze.MaxLength = 300
      Me.tbxMaze.Multiline = True
      Me.tbxMaze.Name = "tbxMaze"
      Me.tbxMaze.ReadOnly = True
      Me.tbxMaze.Size = New System.Drawing.Size(544, 483)
      Me.tbxMaze.TabIndex = 1
      '
      'tabGroup
      '
      Me.tabGroup.Controls.Add(Me.tbTextual)
      Me.tabGroup.Controls.Add(Me.tbGraphic)
      Me.tabGroup.Dock = System.Windows.Forms.DockStyle.Fill
      Me.tabGroup.Location = New System.Drawing.Point(0, 24)
      Me.tabGroup.Name = "tabGroup"
      Me.tabGroup.SelectedIndex = 0
      Me.tabGroup.Size = New System.Drawing.Size(547, 517)
      Me.tabGroup.TabIndex = 2
      '
      'tbTextual
      '
      Me.tbTextual.Controls.Add(Me.tbxMaze)
      Me.tbTextual.Location = New System.Drawing.Point(4, 22)
      Me.tbTextual.Name = "tbTextual"
      Me.tbTextual.Padding = New System.Windows.Forms.Padding(3)
      Me.tbTextual.Size = New System.Drawing.Size(550, 489)
      Me.tbTextual.TabIndex = 0
      Me.tbTextual.Text = "Textual"
      Me.tbTextual.UseVisualStyleBackColor = True
      '
      'tbGraphic
      '
      Me.tbGraphic.Controls.Add(Me.PictureBox2)
      Me.tbGraphic.Controls.Add(Me.pbx1)
      Me.tbGraphic.Location = New System.Drawing.Point(4, 22)
      Me.tbGraphic.Name = "tbGraphic"
      Me.tbGraphic.Padding = New System.Windows.Forms.Padding(3)
      Me.tbGraphic.Size = New System.Drawing.Size(539, 491)
      Me.tbGraphic.TabIndex = 1
      Me.tbGraphic.Text = "Graphical"
      Me.tbGraphic.UseVisualStyleBackColor = True
      '
      'PictureBox2
      '
      Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
      Me.PictureBox2.Location = New System.Drawing.Point(20, 0)
      Me.PictureBox2.Margin = New System.Windows.Forms.Padding(0)
      Me.PictureBox2.Name = "PictureBox2"
      Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
      Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
      Me.PictureBox2.TabIndex = 1
      Me.PictureBox2.TabStop = False
      '
      'pbx1
      '
      Me.pbx1.Image = CType(resources.GetObject("pbx1.Image"), System.Drawing.Image)
      Me.pbx1.Location = New System.Drawing.Point(0, 0)
      Me.pbx1.Margin = New System.Windows.Forms.Padding(0)
      Me.pbx1.Name = "pbx1"
      Me.pbx1.Size = New System.Drawing.Size(20, 20)
      Me.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
      Me.pbx1.TabIndex = 0
      Me.pbx1.TabStop = False
      '
      'frmMain
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(547, 541)
      Me.Controls.Add(Me.tabGroup)
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
      Me.tabGroup.ResumeLayout(False)
      Me.tbTextual.ResumeLayout(False)
      Me.tbTextual.PerformLayout()
      Me.tbGraphic.ResumeLayout(False)
      CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.pbx1, System.ComponentModel.ISupportInitialize).EndInit()
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
   Friend WithEvents tbxMaze As TextBox
   Friend WithEvents tabGroup As TabControl
   Friend WithEvents tbTextual As TabPage
   Friend WithEvents tbGraphic As TabPage
   Friend WithEvents pbx1 As PictureBox
   Friend WithEvents PictureBox2 As PictureBox
End Class
