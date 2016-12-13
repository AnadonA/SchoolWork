Imports FinalProjectLib

Public Class frmMain

   Private mMaze As cMaze = New cMaze()

   Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

      tbxMaze.Lines = mMaze.MazeData

      Dim pic As PictureBox
      CreateWallPic(pic, 20)

      Dim str As String = ""
      For Each Control In tbGraphic.Controls
         str &= Control.ToString() & " "
      Next
      MessageBox.Show(str)

   End Sub

   Private Sub CreateWallPic(ByRef pPBX As PictureBox, ByVal pSize As Integer)
      pPBX = New PictureBox()
      pPBX.SizeMode = pbx1.SizeMode
      pPBX.Image = pbx1.Image
      pPBX.ImageLocation = pbx1.ImageLocation
      pPBX.Size = New Point(pSize, pSize)
      pPBX.Location = pbx1.Location
      pPBX.Visible = True
      tbGraphic.Controls.Add(pPBX)
   End Sub
End Class
