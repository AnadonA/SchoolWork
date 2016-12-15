Imports FinalProjectLib

Public Class frmMain

   Private Const CardRatio As Single = 1.3

   Dim mTest As cCard
   Dim mCardFaces(60) As Bitmap

   '  EVENT HANDLER DEFINITIONS -----------------------------------------------
   ''' <summary>
   ''' 
   ''' </summary>
   ''' <param name="sender"></param>
   ''' <param name="e"></param>
   Private Sub frmMain_Load(sender As Object, e As EventArgs) _
      Handles MyBase.Load

      LoadCards()

      mTest = New cCard(My.Resources.ME_Backs__1_)
   End Sub



   '  CUSTOM SUB|FUNCTION DEFINITIONS  ----------------------------------------
   ''' <summary>
   ''' 
   ''' </summary>
   Private Sub LoadCards()
      '  Create the Heart Suit Faces
      mCardFaces(1) = My.Resources.ME_Hearts__1_
      mCardFaces(2) = My.Resources.ME_Hearts__2_
      mCardFaces(3) = My.Resources.ME_Hearts__3_
      mCardFaces(4) = My.Resources.ME_Hearts__4_
      mCardFaces(5) = My.Resources.ME_Hearts__5_
      mCardFaces(6) = My.Resources.ME_Hearts__6_
      mCardFaces(7) = My.Resources.ME_Hearts__7_
      mCardFaces(8) = My.Resources.ME_Hearts__8_
      mCardFaces(9) = My.Resources.ME_Hearts__9_
      mCardFaces(10) = My.Resources.ME_Hearts__10_
      mCardFaces(11) = My.Resources.ME_Hearts__11_
      mCardFaces(12) = My.Resources.ME_Hearts__12_
      mCardFaces(13) = My.Resources.ME_Hearts__13_

      '  Create the Spade Suit Faces
      mCardFaces(14) = My.Resources.ME_Spades__1_
      mCardFaces(15) = My.Resources.ME_Spades__2_
      mCardFaces(16) = My.Resources.ME_Spades__3_
      mCardFaces(17) = My.Resources.ME_Spades__4_
      mCardFaces(18) = My.Resources.ME_Spades__5_
      mCardFaces(19) = My.Resources.ME_Spades__6_
      mCardFaces(20) = My.Resources.ME_Spades__7_
      mCardFaces(21) = My.Resources.ME_Spades__8_
      mCardFaces(22) = My.Resources.ME_Spades__9_
      mCardFaces(23) = My.Resources.ME_Spades__10_
      mCardFaces(24) = My.Resources.ME_Spades__11_
      mCardFaces(25) = My.Resources.ME_Spades__12_
      mCardFaces(26) = My.Resources.ME_Spades__13_

      '  Create the Diamond Suit Faces
      mCardFaces(27) = My.Resources.ME_Diamonds__1_
      mCardFaces(28) = My.Resources.ME_Diamonds__2_
      mCardFaces(29) = My.Resources.ME_Diamonds__3_
      mCardFaces(30) = My.Resources.ME_Diamonds__4_
      mCardFaces(31) = My.Resources.ME_Diamonds__5_
      mCardFaces(32) = My.Resources.ME_Diamonds__6_
      mCardFaces(33) = My.Resources.ME_Diamonds__7_
      mCardFaces(34) = My.Resources.ME_Diamonds__8_
      mCardFaces(35) = My.Resources.ME_Diamonds__9_
      mCardFaces(36) = My.Resources.ME_Diamonds__10_
      mCardFaces(37) = My.Resources.ME_Diamonds__11_
      mCardFaces(38) = My.Resources.ME_Diamonds__12_
      mCardFaces(39) = My.Resources.ME_Diamonds__13_

      '  Create the Club Suit Faces
      mCardFaces(40) = My.Resources.ME_Clubs__1_
      mCardFaces(41) = My.Resources.ME_Clubs__2_
      mCardFaces(42) = My.Resources.ME_Clubs__3_
      mCardFaces(43) = My.Resources.ME_Clubs__4_
      mCardFaces(44) = My.Resources.ME_Clubs__5_
      mCardFaces(45) = My.Resources.ME_Clubs__6_
      mCardFaces(46) = My.Resources.ME_Clubs__7_
      mCardFaces(47) = My.Resources.ME_Clubs__8_
      mCardFaces(48) = My.Resources.ME_Clubs__9_
      mCardFaces(49) = My.Resources.ME_Clubs__10_
      mCardFaces(50) = My.Resources.ME_Clubs__11_
      mCardFaces(51) = My.Resources.ME_Clubs__12_
      mCardFaces(52) = My.Resources.ME_Clubs__13_

      '  Create the Joker Faces
      mCardFaces(53) = My.Resources.ME_Jokers__1_
      mCardFaces(54) = My.Resources.ME_Jokers__2_
      mCardFaces(55) = My.Resources.ME_Jokers__3_
      mCardFaces(56) = My.Resources.ME_Jokers__4_

      '  Create the Card Backs
      mCardFaces(57) = My.Resources.ME_Backs__1_
      mCardFaces(58) = My.Resources.ME_Backs__2_
      mCardFaces(59) = My.Resources.ME_Backs__3_
      mCardFaces(60) = My.Resources.ME_Backs__4_
   End Sub
End Class
