Imports FinalProjectLib


Public Class frmMain

   Private mCardImages(60) As Bitmap
   Private mCardPlaces(56) As PictureBox

   Dim mGame As cMemory

   '  EVENT HANDLER DEFINITIONS -----------------------------------------------
   ''' <summary>
   ''' 
   ''' </summary>
   ''' <param name="sender"></param>
   ''' <param name="e"></param>
   Private Sub frmMain_Load(sender As Object, e As EventArgs) _
      Handles MyBase.Load

      '  
      LoadImages()

      '  Load the card values
      mGame = New cMemory()
      mGame.LoadCards(mCardImages)
      mGame.ResetGame(eDifficulties.EASY, New Point(800, 600))

      CreatePictures()
      tmrTime.Enabled = True
   End Sub

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <param name="sender"></param>
   ''' <param name="e"></param>
   Private Sub NewGame_Click(sender As Object, e As EventArgs) _
      Handles btnNewGame.Click
      mGame.ResetGame(eDifficulties.EASY, New Point(800, 600))
      CreatePictures()
      tmrTime.Enabled = True
   End Sub

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <param name="sender"></param>
   ''' <param name="e"></param>
   Private Sub HideCards_Tick(sender As Object, e As EventArgs) _
      Handles tmrTime.Tick
      tmrTime.Enabled = False
      tmrFlipper.Enabled = True
   End Sub

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <param name="sender"></param>
   ''' <param name="e"></param>
   Private Sub FlipCards_Tick(sender As Object, e As EventArgs) _
      Handles tmrFlipper.Tick
      FlipPictures()
   End Sub


   ''' <summary>
   ''' 
   ''' </summary>
   Private Sub LoadImages()

      '  Create the Heart Suit Faces
      mCardImages(1) = My.Resources.ME_Hearts__1_     'Ace
      mCardImages(2) = My.Resources.ME_Hearts__2_     'Two
      mCardImages(3) = My.Resources.ME_Hearts__3_     'Three
      mCardImages(4) = My.Resources.ME_Hearts__4_     'Four
      mCardImages(5) = My.Resources.ME_Hearts__5_     'Five
      mCardImages(6) = My.Resources.ME_Hearts__6_     'Six
      mCardImages(7) = My.Resources.ME_Hearts__7_     'Seven
      mCardImages(8) = My.Resources.ME_Hearts__8_     'Eight
      mCardImages(9) = My.Resources.ME_Hearts__9_     'Nine
      mCardImages(10) = My.Resources.ME_Hearts__10_   'Ten
      mCardImages(11) = My.Resources.ME_Hearts__11_   'Jack
      mCardImages(12) = My.Resources.ME_Hearts__12_   'Queen
      mCardImages(13) = My.Resources.ME_Hearts__13_   'King

      '  Create the Spade Suit Faces
      mCardImages(14) = My.Resources.ME_Spades__1_
      mCardImages(15) = My.Resources.ME_Spades__2_
      mCardImages(16) = My.Resources.ME_Spades__3_
      mCardImages(17) = My.Resources.ME_Spades__4_
      mCardImages(18) = My.Resources.ME_Spades__5_
      mCardImages(19) = My.Resources.ME_Spades__6_
      mCardImages(20) = My.Resources.ME_Spades__7_
      mCardImages(21) = My.Resources.ME_Spades__8_
      mCardImages(22) = My.Resources.ME_Spades__9_
      mCardImages(23) = My.Resources.ME_Spades__10_
      mCardImages(24) = My.Resources.ME_Spades__11_
      mCardImages(25) = My.Resources.ME_Spades__12_
      mCardImages(26) = My.Resources.ME_Spades__13_

      '  Create the Diamond Suit Faces
      mCardImages(27) = My.Resources.ME_Diamonds__1_
      mCardImages(28) = My.Resources.ME_Diamonds__2_
      mCardImages(29) = My.Resources.ME_Diamonds__3_
      mCardImages(30) = My.Resources.ME_Diamonds__4_
      mCardImages(31) = My.Resources.ME_Diamonds__5_
      mCardImages(32) = My.Resources.ME_Diamonds__6_
      mCardImages(33) = My.Resources.ME_Diamonds__7_
      mCardImages(34) = My.Resources.ME_Diamonds__8_
      mCardImages(35) = My.Resources.ME_Diamonds__9_
      mCardImages(36) = My.Resources.ME_Diamonds__10_
      mCardImages(37) = My.Resources.ME_Diamonds__11_
      mCardImages(38) = My.Resources.ME_Diamonds__12_
      mCardImages(39) = My.Resources.ME_Diamonds__13_

      '  Create the Club Suit Faces
      mCardImages(40) = My.Resources.ME_Clubs__1_
      mCardImages(41) = My.Resources.ME_Clubs__2_
      mCardImages(42) = My.Resources.ME_Clubs__3_
      mCardImages(43) = My.Resources.ME_Clubs__4_
      mCardImages(44) = My.Resources.ME_Clubs__5_
      mCardImages(45) = My.Resources.ME_Clubs__6_
      mCardImages(46) = My.Resources.ME_Clubs__7_
      mCardImages(47) = My.Resources.ME_Clubs__8_
      mCardImages(48) = My.Resources.ME_Clubs__9_
      mCardImages(49) = My.Resources.ME_Clubs__10_
      mCardImages(50) = My.Resources.ME_Clubs__11_
      mCardImages(51) = My.Resources.ME_Clubs__12_
      mCardImages(52) = My.Resources.ME_Clubs__13_

      '  Create the Joker Faces
      mCardImages(53) = My.Resources.ME_Jokers__1_
      mCardImages(54) = My.Resources.ME_Jokers__2_
      mCardImages(55) = My.Resources.ME_Jokers__3_
      mCardImages(56) = My.Resources.ME_Jokers__4_

      '  Create the Back Faces
      mCardImages(57) = My.Resources.ME_Backs__1_
      mCardImages(58) = My.Resources.ME_Backs__2_
      mCardImages(59) = My.Resources.ME_Backs__3_
      mCardImages(60) = My.Resources.ME_Backs__4_

   End Sub

   ''' <summary>
   ''' 
   ''' </summary>
   Private Sub FlipPictures()
      Static Dim Index = 1

      mCardPlaces(Index).Image = mCardImages(53)

      Index += 1

      If Index >= 60 Then
         tmrFlipper.Enabled = False
      End If
   End Sub

   ''' <summary>
   ''' 
   ''' </summary>
   Private Sub CreatePictures()
      For i As Integer = 1 To 56
         If (mCardPlaces(i) Is Nothing) Then
            mCardPlaces(i) = New PictureBox()
         End If

         Dim Size As Point = mGame.Cards(i).Size

         mCardPlaces(i).Size = Size
         mCardPlaces(i).Image = mGame.Cards(i).Face
         mCardPlaces(i).Visible = mGame.Cards(i).IsUsed
         mCardPlaces(i).Location = mGame.Cards(i).Position
         mCardPlaces(i).BorderStyle = BorderStyle.FixedSingle
         mCardPlaces(i).SizeMode = PictureBoxSizeMode.StretchImage
         Me.Controls.Add(mCardPlaces(i))
      Next
   End Sub
End Class
