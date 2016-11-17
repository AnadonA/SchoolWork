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
      Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
      Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.btnNewGame = New System.Windows.Forms.ToolStripMenuItem()
      Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
      Me.btnExitGame = New System.Windows.Forms.ToolStripMenuItem()
      Me.GameOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.BoardSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.btnTinyBoard = New System.Windows.Forms.ToolStripMenuItem()
      Me.btnSmallBoard = New System.Windows.Forms.ToolStripMenuItem()
      Me.btnAverageBoard = New System.Windows.Forms.ToolStripMenuItem()
      Me.btnLargeBoard = New System.Windows.Forms.ToolStripMenuItem()
      Me.btnSuperBoard = New System.Windows.Forms.ToolStripMenuItem()
      Me.DifficultyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.btnBeginnerDifficulty = New System.Windows.Forms.ToolStripMenuItem()
      Me.btnNoviceDifficulty = New System.Windows.Forms.ToolStripMenuItem()
      Me.btnAdvancedDifficulty = New System.Windows.Forms.ToolStripMenuItem()
      Me.btnExpertDifficulty = New System.Windows.Forms.ToolStripMenuItem()
      Me.btnHelp = New System.Windows.Forms.ToolStripMenuItem()
      Me.btnTerminal = New System.Windows.Forms.ToolStripMenuItem()
      Me.gbxHighScores = New System.Windows.Forms.GroupBox()
      Me.tblHighScores = New System.Windows.Forms.TableLayoutPanel()
      Me.gbxGameBoard = New System.Windows.Forms.GroupBox()
      Me.Button5 = New System.Windows.Forms.Button()
      Me.Button4 = New System.Windows.Forms.Button()
      Me.Button3 = New System.Windows.Forms.Button()
      Me.Button2 = New System.Windows.Forms.Button()
      Me.Button1 = New System.Windows.Forms.Button()
      Me.btnPiece01 = New System.Windows.Forms.Button()
      Me.Button6 = New System.Windows.Forms.Button()
      Me.Button7 = New System.Windows.Forms.Button()
      Me.Button8 = New System.Windows.Forms.Button()
      Me.Button9 = New System.Windows.Forms.Button()
      Me.Button10 = New System.Windows.Forms.Button()
      Me.Button11 = New System.Windows.Forms.Button()
      Me.Button12 = New System.Windows.Forms.Button()
      Me.Button13 = New System.Windows.Forms.Button()
      Me.Button14 = New System.Windows.Forms.Button()
      Me.Button15 = New System.Windows.Forms.Button()
      Me.Button16 = New System.Windows.Forms.Button()
      Me.Button17 = New System.Windows.Forms.Button()
      Me.Button18 = New System.Windows.Forms.Button()
      Me.Button19 = New System.Windows.Forms.Button()
      Me.Button20 = New System.Windows.Forms.Button()
      Me.Button21 = New System.Windows.Forms.Button()
      Me.Button22 = New System.Windows.Forms.Button()
      Me.Button23 = New System.Windows.Forms.Button()
      Me.MenuStrip1.SuspendLayout()
      Me.gbxHighScores.SuspendLayout()
      Me.gbxGameBoard.SuspendLayout()
      Me.SuspendLayout()
      '
      'MenuStrip1
      '
      Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.GameOptionsToolStripMenuItem, Me.btnHelp})
      Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
      Me.MenuStrip1.Name = "MenuStrip1"
      Me.MenuStrip1.Size = New System.Drawing.Size(751, 24)
      Me.MenuStrip1.TabIndex = 0
      Me.MenuStrip1.Text = "MenuStrip1"
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
      'GameOptionsToolStripMenuItem
      '
      Me.GameOptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BoardSizeToolStripMenuItem, Me.DifficultyToolStripMenuItem})
      Me.GameOptionsToolStripMenuItem.Name = "GameOptionsToolStripMenuItem"
      Me.GameOptionsToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
      Me.GameOptionsToolStripMenuItem.Text = "Game &Options"
      '
      'BoardSizeToolStripMenuItem
      '
      Me.BoardSizeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnTinyBoard, Me.btnSmallBoard, Me.btnAverageBoard, Me.btnLargeBoard, Me.btnSuperBoard})
      Me.BoardSizeToolStripMenuItem.Name = "BoardSizeToolStripMenuItem"
      Me.BoardSizeToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
      Me.BoardSizeToolStripMenuItem.Text = "Board &Size"
      '
      'btnTinyBoard
      '
      Me.btnTinyBoard.CheckOnClick = True
      Me.btnTinyBoard.Name = "btnTinyBoard"
      Me.btnTinyBoard.Size = New System.Drawing.Size(167, 22)
      Me.btnTinyBoard.Text = "Tiny (5x5)"
      '
      'btnSmallBoard
      '
      Me.btnSmallBoard.CheckOnClick = True
      Me.btnSmallBoard.Name = "btnSmallBoard"
      Me.btnSmallBoard.Size = New System.Drawing.Size(167, 22)
      Me.btnSmallBoard.Text = "Small (7x7)"
      '
      'btnAverageBoard
      '
      Me.btnAverageBoard.Checked = True
      Me.btnAverageBoard.CheckOnClick = True
      Me.btnAverageBoard.CheckState = System.Windows.Forms.CheckState.Checked
      Me.btnAverageBoard.Name = "btnAverageBoard"
      Me.btnAverageBoard.Size = New System.Drawing.Size(167, 22)
      Me.btnAverageBoard.Text = "Average (10x10)"
      '
      'btnLargeBoard
      '
      Me.btnLargeBoard.CheckOnClick = True
      Me.btnLargeBoard.Name = "btnLargeBoard"
      Me.btnLargeBoard.Size = New System.Drawing.Size(167, 22)
      Me.btnLargeBoard.Text = "Large (15x15)"
      '
      'btnSuperBoard
      '
      Me.btnSuperBoard.CheckOnClick = True
      Me.btnSuperBoard.Name = "btnSuperBoard"
      Me.btnSuperBoard.Size = New System.Drawing.Size(167, 22)
      Me.btnSuperBoard.Text = "Super Size (20x20)"
      '
      'DifficultyToolStripMenuItem
      '
      Me.DifficultyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBeginnerDifficulty, Me.btnNoviceDifficulty, Me.btnAdvancedDifficulty, Me.btnExpertDifficulty})
      Me.DifficultyToolStripMenuItem.Name = "DifficultyToolStripMenuItem"
      Me.DifficultyToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
      Me.DifficultyToolStripMenuItem.Text = "&Difficulty"
      '
      'btnBeginnerDifficulty
      '
      Me.btnBeginnerDifficulty.CheckOnClick = True
      Me.btnBeginnerDifficulty.Name = "btnBeginnerDifficulty"
      Me.btnBeginnerDifficulty.Size = New System.Drawing.Size(127, 22)
      Me.btnBeginnerDifficulty.Text = "&Beginner"
      '
      'btnNoviceDifficulty
      '
      Me.btnNoviceDifficulty.Checked = True
      Me.btnNoviceDifficulty.CheckOnClick = True
      Me.btnNoviceDifficulty.CheckState = System.Windows.Forms.CheckState.Checked
      Me.btnNoviceDifficulty.Name = "btnNoviceDifficulty"
      Me.btnNoviceDifficulty.Size = New System.Drawing.Size(127, 22)
      Me.btnNoviceDifficulty.Text = "&Novice"
      '
      'btnAdvancedDifficulty
      '
      Me.btnAdvancedDifficulty.CheckOnClick = True
      Me.btnAdvancedDifficulty.Name = "btnAdvancedDifficulty"
      Me.btnAdvancedDifficulty.Size = New System.Drawing.Size(127, 22)
      Me.btnAdvancedDifficulty.Text = "&Advanced"
      '
      'btnExpertDifficulty
      '
      Me.btnExpertDifficulty.CheckOnClick = True
      Me.btnExpertDifficulty.Name = "btnExpertDifficulty"
      Me.btnExpertDifficulty.Size = New System.Drawing.Size(127, 22)
      Me.btnExpertDifficulty.Text = "&Expert"
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
      Me.btnTerminal.Size = New System.Drawing.Size(194, 22)
      Me.btnTerminal.Text = "&Terminal"
      Me.btnTerminal.Visible = False
      '
      'gbxHighScores
      '
      Me.gbxHighScores.Controls.Add(Me.tblHighScores)
      Me.gbxHighScores.Location = New System.Drawing.Point(496, 27)
      Me.gbxHighScores.Name = "gbxHighScores"
      Me.gbxHighScores.Size = New System.Drawing.Size(241, 480)
      Me.gbxHighScores.TabIndex = 1
      Me.gbxHighScores.TabStop = False
      Me.gbxHighScores.Text = "High Scores"
      '
      'tblHighScores
      '
      Me.tblHighScores.ColumnCount = 3
      Me.tblHighScores.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.21519!))
      Me.tblHighScores.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.78481!))
      Me.tblHighScores.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
      Me.tblHighScores.Dock = System.Windows.Forms.DockStyle.Fill
      Me.tblHighScores.Location = New System.Drawing.Point(3, 16)
      Me.tblHighScores.Name = "tblHighScores"
      Me.tblHighScores.RowCount = 11
      Me.tblHighScores.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
      Me.tblHighScores.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
      Me.tblHighScores.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
      Me.tblHighScores.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
      Me.tblHighScores.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
      Me.tblHighScores.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
      Me.tblHighScores.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
      Me.tblHighScores.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
      Me.tblHighScores.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
      Me.tblHighScores.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
      Me.tblHighScores.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
      Me.tblHighScores.Size = New System.Drawing.Size(235, 461)
      Me.tblHighScores.TabIndex = 0
      '
      'gbxGameBoard
      '
      Me.gbxGameBoard.Controls.Add(Me.Button23)
      Me.gbxGameBoard.Controls.Add(Me.Button22)
      Me.gbxGameBoard.Controls.Add(Me.Button21)
      Me.gbxGameBoard.Controls.Add(Me.Button20)
      Me.gbxGameBoard.Controls.Add(Me.Button19)
      Me.gbxGameBoard.Controls.Add(Me.Button18)
      Me.gbxGameBoard.Controls.Add(Me.Button17)
      Me.gbxGameBoard.Controls.Add(Me.Button16)
      Me.gbxGameBoard.Controls.Add(Me.Button15)
      Me.gbxGameBoard.Controls.Add(Me.Button14)
      Me.gbxGameBoard.Controls.Add(Me.Button13)
      Me.gbxGameBoard.Controls.Add(Me.Button12)
      Me.gbxGameBoard.Controls.Add(Me.Button11)
      Me.gbxGameBoard.Controls.Add(Me.Button10)
      Me.gbxGameBoard.Controls.Add(Me.Button9)
      Me.gbxGameBoard.Controls.Add(Me.Button8)
      Me.gbxGameBoard.Controls.Add(Me.Button7)
      Me.gbxGameBoard.Controls.Add(Me.Button6)
      Me.gbxGameBoard.Controls.Add(Me.Button5)
      Me.gbxGameBoard.Controls.Add(Me.Button4)
      Me.gbxGameBoard.Controls.Add(Me.Button3)
      Me.gbxGameBoard.Controls.Add(Me.Button2)
      Me.gbxGameBoard.Controls.Add(Me.Button1)
      Me.gbxGameBoard.Controls.Add(Me.btnPiece01)
      Me.gbxGameBoard.Location = New System.Drawing.Point(12, 27)
      Me.gbxGameBoard.Margin = New System.Windows.Forms.Padding(1)
      Me.gbxGameBoard.Name = "gbxGameBoard"
      Me.gbxGameBoard.Padding = New System.Windows.Forms.Padding(1)
      Me.gbxGameBoard.Size = New System.Drawing.Size(480, 485)
      Me.gbxGameBoard.TabIndex = 2
      Me.gbxGameBoard.TabStop = False
      '
      'Button5
      '
      Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.Button5.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Button5.Location = New System.Drawing.Point(194, 9)
      Me.Button5.Margin = New System.Windows.Forms.Padding(1)
      Me.Button5.Name = "Button5"
      Me.Button5.Padding = New System.Windows.Forms.Padding(1)
      Me.Button5.Size = New System.Drawing.Size(46, 46)
      Me.Button5.TabIndex = 23
      Me.Button5.Text = "?"
      Me.Button5.UseVisualStyleBackColor = True
      '
      'Button4
      '
      Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.Button4.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Button4.Location = New System.Drawing.Point(146, 9)
      Me.Button4.Margin = New System.Windows.Forms.Padding(1)
      Me.Button4.Name = "Button4"
      Me.Button4.Padding = New System.Windows.Forms.Padding(1)
      Me.Button4.Size = New System.Drawing.Size(46, 46)
      Me.Button4.TabIndex = 22
      Me.Button4.Text = "?"
      Me.Button4.UseVisualStyleBackColor = True
      '
      'Button3
      '
      Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.Button3.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Button3.Location = New System.Drawing.Point(98, 9)
      Me.Button3.Margin = New System.Windows.Forms.Padding(1)
      Me.Button3.Name = "Button3"
      Me.Button3.Padding = New System.Windows.Forms.Padding(1)
      Me.Button3.Size = New System.Drawing.Size(46, 46)
      Me.Button3.TabIndex = 21
      Me.Button3.Text = "?"
      Me.Button3.UseVisualStyleBackColor = True
      '
      'Button2
      '
      Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.Button2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Button2.Location = New System.Drawing.Point(50, 9)
      Me.Button2.Margin = New System.Windows.Forms.Padding(1)
      Me.Button2.Name = "Button2"
      Me.Button2.Padding = New System.Windows.Forms.Padding(1)
      Me.Button2.Size = New System.Drawing.Size(46, 46)
      Me.Button2.TabIndex = 20
      Me.Button2.Text = "?"
      Me.Button2.UseVisualStyleBackColor = True
      '
      'Button1
      '
      Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.Button1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Button1.Location = New System.Drawing.Point(2, 9)
      Me.Button1.Margin = New System.Windows.Forms.Padding(1)
      Me.Button1.Name = "Button1"
      Me.Button1.Padding = New System.Windows.Forms.Padding(1)
      Me.Button1.Size = New System.Drawing.Size(46, 46)
      Me.Button1.TabIndex = 19
      Me.Button1.Text = "?"
      Me.Button1.UseVisualStyleBackColor = True
      '
      'btnPiece01
      '
      Me.btnPiece01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.btnPiece01.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnPiece01.Location = New System.Drawing.Point(278, 225)
      Me.btnPiece01.Margin = New System.Windows.Forms.Padding(1)
      Me.btnPiece01.Name = "btnPiece01"
      Me.btnPiece01.Padding = New System.Windows.Forms.Padding(1)
      Me.btnPiece01.Size = New System.Drawing.Size(20, 20)
      Me.btnPiece01.TabIndex = 18
      Me.btnPiece01.Text = "?"
      Me.btnPiece01.UseVisualStyleBackColor = True
      '
      'Button6
      '
      Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.Button6.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Button6.Location = New System.Drawing.Point(241, 9)
      Me.Button6.Margin = New System.Windows.Forms.Padding(1)
      Me.Button6.Name = "Button6"
      Me.Button6.Padding = New System.Windows.Forms.Padding(1)
      Me.Button6.Size = New System.Drawing.Size(46, 46)
      Me.Button6.TabIndex = 24
      Me.Button6.Text = "?"
      Me.Button6.UseVisualStyleBackColor = True
      '
      'Button7
      '
      Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.Button7.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Button7.Location = New System.Drawing.Point(289, 9)
      Me.Button7.Margin = New System.Windows.Forms.Padding(1)
      Me.Button7.Name = "Button7"
      Me.Button7.Padding = New System.Windows.Forms.Padding(1)
      Me.Button7.Size = New System.Drawing.Size(46, 46)
      Me.Button7.TabIndex = 25
      Me.Button7.Text = "?"
      Me.Button7.UseVisualStyleBackColor = True
      '
      'Button8
      '
      Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.Button8.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Button8.Location = New System.Drawing.Point(337, 9)
      Me.Button8.Margin = New System.Windows.Forms.Padding(1)
      Me.Button8.Name = "Button8"
      Me.Button8.Padding = New System.Windows.Forms.Padding(1)
      Me.Button8.Size = New System.Drawing.Size(46, 46)
      Me.Button8.TabIndex = 26
      Me.Button8.Text = "?"
      Me.Button8.UseVisualStyleBackColor = True
      '
      'Button9
      '
      Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.Button9.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Button9.Location = New System.Drawing.Point(385, 9)
      Me.Button9.Margin = New System.Windows.Forms.Padding(1)
      Me.Button9.Name = "Button9"
      Me.Button9.Padding = New System.Windows.Forms.Padding(1)
      Me.Button9.Size = New System.Drawing.Size(46, 46)
      Me.Button9.TabIndex = 27
      Me.Button9.Text = "?"
      Me.Button9.UseVisualStyleBackColor = True
      '
      'Button10
      '
      Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.Button10.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Button10.Location = New System.Drawing.Point(432, 9)
      Me.Button10.Margin = New System.Windows.Forms.Padding(1)
      Me.Button10.Name = "Button10"
      Me.Button10.Padding = New System.Windows.Forms.Padding(1)
      Me.Button10.Size = New System.Drawing.Size(46, 46)
      Me.Button10.TabIndex = 28
      Me.Button10.Text = "?"
      Me.Button10.UseVisualStyleBackColor = True
      '
      'Button11
      '
      Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.Button11.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Button11.Location = New System.Drawing.Point(2, 57)
      Me.Button11.Margin = New System.Windows.Forms.Padding(1)
      Me.Button11.Name = "Button11"
      Me.Button11.Padding = New System.Windows.Forms.Padding(1)
      Me.Button11.Size = New System.Drawing.Size(34, 34)
      Me.Button11.TabIndex = 29
      Me.Button11.Text = "?"
      Me.Button11.UseVisualStyleBackColor = True
      '
      'Button12
      '
      Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.Button12.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Button12.Location = New System.Drawing.Point(38, 57)
      Me.Button12.Margin = New System.Windows.Forms.Padding(1)
      Me.Button12.Name = "Button12"
      Me.Button12.Padding = New System.Windows.Forms.Padding(1)
      Me.Button12.Size = New System.Drawing.Size(34, 34)
      Me.Button12.TabIndex = 30
      Me.Button12.Text = "?"
      Me.Button12.UseVisualStyleBackColor = True
      '
      'Button13
      '
      Me.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.Button13.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Button13.Location = New System.Drawing.Point(74, 57)
      Me.Button13.Margin = New System.Windows.Forms.Padding(1)
      Me.Button13.Name = "Button13"
      Me.Button13.Padding = New System.Windows.Forms.Padding(1)
      Me.Button13.Size = New System.Drawing.Size(34, 34)
      Me.Button13.TabIndex = 31
      Me.Button13.Text = "?"
      Me.Button13.UseVisualStyleBackColor = True
      '
      'Button14
      '
      Me.Button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.Button14.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Button14.Location = New System.Drawing.Point(110, 57)
      Me.Button14.Margin = New System.Windows.Forms.Padding(1)
      Me.Button14.Name = "Button14"
      Me.Button14.Padding = New System.Windows.Forms.Padding(1)
      Me.Button14.Size = New System.Drawing.Size(34, 34)
      Me.Button14.TabIndex = 32
      Me.Button14.Text = "?"
      Me.Button14.UseVisualStyleBackColor = True
      '
      'Button15
      '
      Me.Button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.Button15.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Button15.Location = New System.Drawing.Point(146, 57)
      Me.Button15.Margin = New System.Windows.Forms.Padding(1)
      Me.Button15.Name = "Button15"
      Me.Button15.Padding = New System.Windows.Forms.Padding(1)
      Me.Button15.Size = New System.Drawing.Size(34, 34)
      Me.Button15.TabIndex = 33
      Me.Button15.Text = "?"
      Me.Button15.UseVisualStyleBackColor = True
      '
      'Button16
      '
      Me.Button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.Button16.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Button16.Location = New System.Drawing.Point(182, 57)
      Me.Button16.Margin = New System.Windows.Forms.Padding(1)
      Me.Button16.Name = "Button16"
      Me.Button16.Padding = New System.Windows.Forms.Padding(1)
      Me.Button16.Size = New System.Drawing.Size(34, 34)
      Me.Button16.TabIndex = 34
      Me.Button16.Text = "?"
      Me.Button16.UseVisualStyleBackColor = True
      '
      'Button17
      '
      Me.Button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.Button17.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Button17.Location = New System.Drawing.Point(218, 57)
      Me.Button17.Margin = New System.Windows.Forms.Padding(1)
      Me.Button17.Name = "Button17"
      Me.Button17.Padding = New System.Windows.Forms.Padding(1)
      Me.Button17.Size = New System.Drawing.Size(34, 34)
      Me.Button17.TabIndex = 35
      Me.Button17.Text = "?"
      Me.Button17.UseVisualStyleBackColor = True
      '
      'Button18
      '
      Me.Button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.Button18.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Button18.Location = New System.Drawing.Point(254, 57)
      Me.Button18.Margin = New System.Windows.Forms.Padding(1)
      Me.Button18.Name = "Button18"
      Me.Button18.Padding = New System.Windows.Forms.Padding(1)
      Me.Button18.Size = New System.Drawing.Size(34, 34)
      Me.Button18.TabIndex = 36
      Me.Button18.Text = "?"
      Me.Button18.UseVisualStyleBackColor = True
      '
      'Button19
      '
      Me.Button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.Button19.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Button19.Location = New System.Drawing.Point(289, 57)
      Me.Button19.Margin = New System.Windows.Forms.Padding(1)
      Me.Button19.Name = "Button19"
      Me.Button19.Padding = New System.Windows.Forms.Padding(1)
      Me.Button19.Size = New System.Drawing.Size(34, 34)
      Me.Button19.TabIndex = 37
      Me.Button19.Text = "?"
      Me.Button19.UseVisualStyleBackColor = True
      '
      'Button20
      '
      Me.Button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.Button20.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Button20.Location = New System.Drawing.Point(325, 57)
      Me.Button20.Margin = New System.Windows.Forms.Padding(1)
      Me.Button20.Name = "Button20"
      Me.Button20.Padding = New System.Windows.Forms.Padding(1)
      Me.Button20.Size = New System.Drawing.Size(34, 34)
      Me.Button20.TabIndex = 38
      Me.Button20.Text = "?"
      Me.Button20.UseVisualStyleBackColor = True
      '
      'Button21
      '
      Me.Button21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.Button21.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Button21.Location = New System.Drawing.Point(361, 57)
      Me.Button21.Margin = New System.Windows.Forms.Padding(1)
      Me.Button21.Name = "Button21"
      Me.Button21.Padding = New System.Windows.Forms.Padding(1)
      Me.Button21.Size = New System.Drawing.Size(34, 34)
      Me.Button21.TabIndex = 39
      Me.Button21.Text = "?"
      Me.Button21.UseVisualStyleBackColor = True
      '
      'Button22
      '
      Me.Button22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.Button22.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Button22.Location = New System.Drawing.Point(432, 57)
      Me.Button22.Margin = New System.Windows.Forms.Padding(1)
      Me.Button22.Name = "Button22"
      Me.Button22.Padding = New System.Windows.Forms.Padding(1)
      Me.Button22.Size = New System.Drawing.Size(34, 34)
      Me.Button22.TabIndex = 40
      Me.Button22.Text = "?"
      Me.Button22.UseVisualStyleBackColor = True
      '
      'Button23
      '
      Me.Button23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.Button23.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Button23.Location = New System.Drawing.Point(397, 57)
      Me.Button23.Margin = New System.Windows.Forms.Padding(1)
      Me.Button23.Name = "Button23"
      Me.Button23.Padding = New System.Windows.Forms.Padding(1)
      Me.Button23.Size = New System.Drawing.Size(34, 34)
      Me.Button23.TabIndex = 41
      Me.Button23.Text = "?"
      Me.Button23.UseVisualStyleBackColor = True
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(751, 522)
      Me.Controls.Add(Me.gbxGameBoard)
      Me.Controls.Add(Me.gbxHighScores)
      Me.Controls.Add(Me.MenuStrip1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.MainMenuStrip = Me.MenuStrip1
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "Form1"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "MineSweeper"
      Me.MenuStrip1.ResumeLayout(False)
      Me.MenuStrip1.PerformLayout()
      Me.gbxHighScores.ResumeLayout(False)
      Me.gbxGameBoard.ResumeLayout(False)
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents MenuStrip1 As MenuStrip
   Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
   Friend WithEvents btnNewGame As ToolStripMenuItem
   Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
   Friend WithEvents btnExitGame As ToolStripMenuItem
   Friend WithEvents btnHelp As ToolStripMenuItem
   Friend WithEvents btnTerminal As ToolStripMenuItem
   Friend WithEvents gbxHighScores As GroupBox
   Friend WithEvents tblHighScores As TableLayoutPanel
   Friend WithEvents gbxGameBoard As GroupBox
   Friend WithEvents btnPiece01 As Button
   Friend WithEvents GameOptionsToolStripMenuItem As ToolStripMenuItem
   Friend WithEvents BoardSizeToolStripMenuItem As ToolStripMenuItem
   Friend WithEvents btnTinyBoard As ToolStripMenuItem
   Friend WithEvents btnSmallBoard As ToolStripMenuItem
   Friend WithEvents btnAverageBoard As ToolStripMenuItem
   Friend WithEvents btnLargeBoard As ToolStripMenuItem
   Friend WithEvents btnSuperBoard As ToolStripMenuItem
   Friend WithEvents DifficultyToolStripMenuItem As ToolStripMenuItem
   Friend WithEvents btnBeginnerDifficulty As ToolStripMenuItem
   Friend WithEvents btnNoviceDifficulty As ToolStripMenuItem
   Friend WithEvents btnAdvancedDifficulty As ToolStripMenuItem
   Friend WithEvents btnExpertDifficulty As ToolStripMenuItem
   Friend WithEvents Button5 As Button
   Friend WithEvents Button4 As Button
   Friend WithEvents Button3 As Button
   Friend WithEvents Button2 As Button
   Friend WithEvents Button1 As Button
   Friend WithEvents Button23 As Button
   Friend WithEvents Button22 As Button
   Friend WithEvents Button21 As Button
   Friend WithEvents Button20 As Button
   Friend WithEvents Button19 As Button
   Friend WithEvents Button18 As Button
   Friend WithEvents Button17 As Button
   Friend WithEvents Button16 As Button
   Friend WithEvents Button15 As Button
   Friend WithEvents Button14 As Button
   Friend WithEvents Button13 As Button
   Friend WithEvents Button12 As Button
   Friend WithEvents Button11 As Button
   Friend WithEvents Button10 As Button
   Friend WithEvents Button9 As Button
   Friend WithEvents Button8 As Button
   Friend WithEvents Button7 As Button
   Friend WithEvents Button6 As Button
End Class
