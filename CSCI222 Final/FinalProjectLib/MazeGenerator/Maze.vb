Public Class cMaze
   Public Const MAX_ROWS As Integer = 84
   Public Const MAX_COLS As Integer = 38

   Public Const mWallChar As Char = "█"     '[alt] + 219
   Public Const mCharChar As Char = "ø"     '[alt] + 248
   Public Const mPathChar As Char = " "     'Space

   Private mRand As Random

   Private mEndWall As eWalls
   Private mStartWall As eWalls
   Private mCurrDirection As Integer

   Private mShiftPercent As Double = 0.0
   Private mMazeData(0 To MAX_COLS) As String

   ''' <summary>
   ''' Returns the compiled string array that will be used to display\draw the
   ''' maze.
   ''' </summary>
   ''' <returns>The compiled string array</returns>
   Public ReadOnly Property MazeData
      Get
         Return mMazeData
      End Get
   End Property



   Public Sub New()
      For Y As Integer = 0 To MAX_COLS
         For X As Integer = 0 To MAX_ROWS
            mMazeData(Y) += mWallChar
         Next
      Next
   End Sub

   Public Function CreateMaze() As Boolean

      '  Re-Seed the randomize functionalities
      mRand = New Random()

      '  Re-Dimension the maze data string array and ensure it's clear
      ReDim mMazeData(0 To MAX_ROWS)

      '  Decide on the starting and ending points of the maze
      Dim RandomValue As Integer = mRand.Next(0, 100)
      If (RandomValue < 50) Then
         mEndWall = eWalls.RIGHT
         mStartWall = eWalls.LEFT
      Else
         mStartWall = eWalls.TOP
         mEndWall = eWalls.BOTTOM
      End If

      '  
      Do While Not CreateNextPath(New cVector2(Of Integer)(0, 0))
      Loop

      Return False
   End Function

   Public Function CreateNextPath(ByVal pCurrentPosition As cVector2(Of Integer)) As Boolean

      Dim PathOkay As Boolean = False
      Static Dim RandomValue As Integer = 0
      Static Dim ShiftPercent As Integer = 0
      Static Dim CurrentDirection As Integer = 0

      '  Decide on the next path
      Do While Not PathOkay
         RandomValue = mRand.Next(0, 100)
         If (RandomValue <= ShiftPercent) Then

            '  The path HAS TO shift. Loop until it has selected an appropriate 
            '  direction.
            RandomValue = mRand.Next(0, 3)
            Do While RandomValue.Equals(CurrentDirection)
               RandomValue = mRand.Next(0, 3)
            Loop
            ShiftPercent = 0

         Else

            '  The path MAY shift but is not required to
            RandomValue = mRand.Next(0, 3)
            If (RandomValue.Equals(CurrentDirection)) Then
               ShiftPercent += 10
            End If

         End If

         Select Case RandomValue
            Case 0
               If Not pCurrentPosition.X.Equals(0) Then
                  PathOkay = True
               End If
            Case 1
               If Not pCurrentPosition.Y.Equals(MAX_ROWS) Then
                  PathOkay = True
               End If
         End Select
      Loop

      '  Apply the selected path

      Return False
   End Function

End Class
