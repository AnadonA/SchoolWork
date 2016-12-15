Imports System.Drawing

Public Class cMemory

   Private mRand As Random
   Private mCardSize As Point
   Private mCards(56) As cCard

   Public ReadOnly Property Cards
      Get
         Return mCards
      End Get
   End Property

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <returns></returns>
   Public ReadOnly Property CardSize
      Get
         Return mCardSize
      End Get
   End Property

   '  CUSTOM SUB|FUNCTION DEFINITIONS  ----------------------------------------
   ''' <summary>
   ''' Loads each of the card faces as an image in the mCards array.
   ''' </summary>
   Public Sub LoadCards(ByRef pBitmapList() As Bitmap)

      Dim Index, Suit, Values As Integer
      Suit = 0
      Index = 1
      Values = 0

      Do While Index <= 56

         If Values >= 14 Then
            Suit += 1
            Values = 0
         End If

         mCards(Index) = New cCard(pBitmapList(Index), DirectCast(Suit, eSuits), DirectCast(Values, eValues))

         Index += 1
         Values += 1
      Loop

   End Sub

   Public Sub ResetGame(pDifficulty As eDifficulties, pBoardSize As Point)

      Dim Index01 As Integer = 0
      Dim index02 As Integer = 0
      Dim CardIndex As Integer = 0
      Dim CardCount As Integer = 20
      Dim CardSize As Point = New Point(20, 20)
      Dim CardPosition As Point = New Point(0, 0)

      mRand = New Random()

      Select Case pDifficulty
         Case eDifficulties.EASY
            CardCount = 8
         Case eDifficulties.MEDIUM
            CardCount = 10
         Case eDifficulties.HARD
            CardCount = 12
         Case eDifficulties.EGREGIOUS
            CardCount = 14
      End Select

      CardSize.X = (pBoardSize.X - 5) / (CardCount) - 5
      CardSize.Y = CardSize.X * 1.3
      mCardSize = New Point(CardSize.X, CardSize.Y)

      For Each card In mCards
         If (card IsNot Nothing) Then
            card.SetSize(CardSize)
         End If
      Next

      '  Perform a deep shuffle of the cards
      For i As Integer = 0 To 1000
         Index01 = mRand.Next(0, 4) * 13 + mRand.Next(1, CardCount + 1)
         index02 = mRand.Next(0, 4) * 13 + mRand.Next(1, CardCount + 1)
         SwapCards(Index01, index02)
      Next

      Index01 = 1
      For y As Integer = 0 To 3
         For x As Integer = 0 To 12
            If (x < CardCount) Then
               mCards(Index01).SetUsage(True)
               mCards(Index01).SetPosition(2 + x * CardSize.X + 4 * x, y * CardSize.Y + 5 * y + 30)
            Else
               mCards(Index01).SetUsage(False)
            End If

            Index01 += 1
         Next
      Next
   End Sub

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <param name="pCardIndex01"></param>
   ''' <param name="pCardIndex02"></param>
   Private Sub SwapCards(pCardIndex01 As Integer, pCardIndex02 As Integer)
      Dim TempCard As cCard = mCards(pCardIndex01)
      mCards(pCardIndex01) = mCards(pCardIndex02)
      mCards(pCardIndex02) = TempCard
   End Sub
End Class
