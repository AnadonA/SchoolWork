Imports FinalProjectLib

Public Class frmMain

   Private mMaze As cMaze = New cMaze()

   Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

      tbxMaze.Lines = mMaze.MazeData

   End Sub
End Class
