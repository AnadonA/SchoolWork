Public Class cGameTile

   Dim _IsBomb As Boolean
   Dim _IsLeftWall As Boolean
   Dim _IsRightWall As Boolean
   Dim _IsFirstRow As Boolean
   Dim _IsLastRow As Boolean


   Dim _Siblings(0 To 8) As cGameTile

   Public Property IsBomb
      Get
         Return _IsBomb
      End Get
      Set(value)

      End Set
   End Property

   Public ReadOnly Property Siblings
      Get
         Return _Siblings
      End Get
   End Property



   ''' <summary>
   ''' 
   ''' </summary>
   ''' <param name="pTileNum"></param>
   ''' <param name="pBoardSize"></param>
   Public Sub CalcSiblings(pTileNum As Integer, pBoardSize As Integer)

      '  Calculate the siblings of the tile

      '  Test for First Row position
      If (pTileNum <= pBoardSize) Then
         _IsFirstRow = True
      Else
         _IsFirstRow = False
      End If

      '  Test for Last Row position
      If () Then



   End Sub
End Class

' 01 02 03 04 05
' 06 07 08 09 10
' 11 12 13 14 15
' 16 17 18 19 20
' 21 22 23 24 25
