Option Infer On

Public Class cMaze
   Public Const MAX_ROWS As Integer = 128
   Public Const MAX_COLS As Integer = 48

   Private mRand As Random
   Private mCharPos As cPoint

   Private mWall As Char = "█"      '[alt] + 219
   Private mCharacter As Char = "ø" '[alt] + 248

   Private mMazeStrings(0 To MAX_COLS) As String
   Private mMazeData As cSparseMatrix(Of eTileTypes)

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <returns></returns>
   Public ReadOnly Property DataStrings
      Get
         Return mMazeStrings
      End Get
   End Property

   Public Sub New()

      '  Seed the randomizer
      Randomize()

      '  Create the sparse matrix of maze data
      mMazeData = New cSparseMatrix(Of eTileTypes)(eTileTypes.WALL)

      '  Reset all data to nothingness
      ResetMaze()
   End Sub

   ''' <summary>
   ''' Resets the maze data to be a complete wall
   ''' </summary>
   Private Sub ResetMaze()
      mMazeData.Clear()

      CreateMaze()
   End Sub

   Private Sub CreateMaze()

      For i As Integer = 0 To 1000
         Dim X As Integer = mRand.Next(0, 128)
         Dim Y As Integer = mRand.Next(0, 48)
         mMazeData.SetValue(X, Y, eTileTypes.PATH)
      Next


      CreateStringData()
   End Sub

   ''' <summary>
   ''' Responsible for converting the sparse matrix maze data into the strings
   ''' that are used to display it.
   ''' </summary>
   Private Sub CreateStringData()
      ReDim mMazeStrings(0 To MAX_COLS)

      For y As Integer = 0 To MAX_ROWS
         For x As Integer = 0 To MAX_COLS
            Select Case mMazeData.GetValue(x, y)
               Case eTileTypes.CHARACTER
                  mMazeStrings(x) += mCharacter
               Case eTileTypes.PATH
                  mMazeStrings(x) += " "
               Case Else
                  mMazeStrings(x) += mWall
            End Select
         Next
      Next
   End Sub
End Class
