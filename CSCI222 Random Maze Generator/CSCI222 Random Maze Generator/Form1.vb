Imports MazeLib
Imports MemoryLib
Imports System.Drawing


Public Class Form1

   Private Cards(0 To 56) As cCard

   Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


      Dim Test As cSparseMatrix(Of Integer) = New cSparseMatrix(Of Integer)(0)

      Test.SetValue(1, 3, 30)
      Test.SetValue(0, 5, 20)
      Test.SetValue(1, 1, 5)
      Test.SetValue(1, 2, 10)
      Test.SetValue(1, 0, 0)
      Test.SetValue(0, 3, 30)

      Dim TestVal As Integer = -1
      TestVal = Test.GetValue(1, 1)
      TestVal = Test.GetValue(300, 300)

      '  Fills the maze with █ text
      Dim Maze(0 To 128, 0 To 48) As Char
      For y As Integer = 0 To 48
         For x As Integer = 0 To 128
            Maze(x, y) = "█"
         Next
      Next

      Dim MazeText(0 To 48) As String
      For y As Integer = 0 To 48
         MazeText(y) = ""
         For x As Integer = 0 To 128
            MazeText(y) &= Maze(x, y)
         Next
      Next

      TBX_MAZE.Lines = MazeText
   End Sub
End Class
