Public Class Form1
   ' Board Size: (476, 467)

   ' Tile Positions
   ' (026, 015), (440, 015)
   ' (006, 433), (440, 433)

   '  Create and default the Game Difficulty and BoardSize variables
   Private mBoardSize As eBoardSize = eBoardSize.MEDIUM
   Private mDifficulty As eGameDifficulty = eGameDifficulty.NOVICE
   Private mTiles(400) As cGameTile

   ''' <summary>
   ''' This enumeration is used to determine the game board size. All game 
   ''' boards will be square.
   ''' </summary>
   Enum eBoardSize
      TINY     ' 05x05
      SMALL    ' 06x06
      MEDIUM   ' 07x07
      LARGE    ' 10x10
      SUPER    ' 20x20
   End Enum

   ''' <summary>
   ''' This enumeration is used to determine the following:
   ''' 1) The # of bombs placed in the field; and the
   ''' 2) Distribution of the placed bombs (nearness to other bombs).
   ''' </summary>
   Enum eGameDifficulty
      BEGINNER ' 15%
      NOVICE   ' 30%
      ADVANCED ' 45%
      EXPERT   ' 60%
   End Enum

   Private Sub OnInitialLoad(sender As Object, e As EventArgs) Handles Me.Load
      For Each Tile As cGameTile In mTiles
         Tile = New cGameTile()
      Next

   End Sub

   ''' <summary>
   ''' Closes the game when the Exit menu item is clicked or when its shortcut 
   ''' keys are used.
   ''' </summary>
   ''' <param name="sender">UNUSED</param>
   ''' <param name="e">UNUSED</param>
   Private Sub ExitGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnExitGame.Click
      Me.Close()
   End Sub

   ''' <summary>
   ''' Creates a new game when the New Game menu item is clicked or its respective
   ''' shortcut command is used.
   ''' </summary>
   ''' <param name="sender">UNUSED</param>
   ''' <param name="e">UNUSED</param>
   Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
      NewGame()
   End Sub

   ''' <summary>
   ''' Manages the user's selection of the Game Board size. 
   ''' </summary>
   ''' <param name="sender">The ToolStripMenuItem that was clicked. This 
   ''' parameter is used to ensure the selected size is the one that is checked.</param>
   ''' <param name="e">UNUSED</param>
   Private Sub SelectBoardSize(sender As Object, e As EventArgs) Handles btnTinyBoard.Click, btnSmallBoard.Click,
      btnAverageBoard.Click, btnLargeBoard.Click, btnSuperBoard.Click

      '  Retrieve the clicked board size selection
      Dim CurrentSelection As ToolStripMenuItem
      CurrentSelection = TryCast(sender, ToolStripMenuItem)

      '  Clear all previous checks
      btnTinyBoard.Checked = False
      btnSmallBoard.Checked = False
      btnAverageBoard.Checked = False
      btnLargeBoard.Checked = False
      btnSuperBoard.Checked = False

      '  Ensure the selected board size is 
      CurrentSelection.Checked = True

      '  Alert the user
      MsgBox("Changes to the size of the game board will take effect during the next 'New Game'.")

   End Sub

   ''' <summary>
   ''' Manages the user's selection of the Game difficulty.
   ''' </summary>
   ''' <param name="sender">The ToolStripMenuItem that was clicked. This
   ''' parameter is used to ensure the selected difficulty is the one that is checked.</param>
   ''' <param name="e">UNUSED</param>
   Private Sub SelectDifficulty(sender As Object, e As EventArgs) Handles btnBeginnerDifficulty.Click, btnNoviceDifficulty.Click,
         btnAdvancedDifficulty.Click, btnExpertDifficulty.Click

      '  Retrieve the current difficulty selection
      Dim CurrentSelection As ToolStripMenuItem
      CurrentSelection = TryCast(sender, ToolStripMenuItem)

      '  Clear the previous difficulties
      btnBeginnerDifficulty.Checked = False
      btnNoviceDifficulty.Checked = False
      btnAdvancedDifficulty.Checked = False
      btnExpertDifficulty.Checked = False

      '  Check the requested difficulty
      CurrentSelection.Checked = True

      '  Alert the user
      MsgBox("Changes to the size of the games Difficulty will take effect during the next 'New Game'.")
   End Sub

   ''' <summary>
   ''' Opens the command terminal and processs the user input
   ''' </summary>
   ''' <param name="sender">UNUSED</param>
   ''' <param name="e">UNUSED</param>
   Private Sub TerminalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnTerminal.Click

      btnPiece01.Padding = New Padding(1)
      btnPiece01.Margin = New Padding(1)


      Dim myValue As Object

      '  Get the cmd
      myValue = InputBox("Type your Terminal Command:", "MineSweeper Terminal", "").ToLower


      Select Case myValue
         Case "exit"
            Me.Close()

         Case "new game"
            NewGame()

         Case "show solution"
            Dim NewVal As Integer = 0

         Case Else
      End Select



   End Sub

   ''' <summary>
   ''' 
   ''' </summary>
   Private Sub NewGame()

   End Sub
End Class
