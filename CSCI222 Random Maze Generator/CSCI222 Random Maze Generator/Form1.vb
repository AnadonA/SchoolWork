Imports MemoryLib
Imports System.Drawing


Public Class Form1

   Private Cards(0 To 56) As cCard

   Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
