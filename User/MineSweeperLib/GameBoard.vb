Public Class cGameBoard

   ''' <summary>
   ''' Defines whether or not the MineSweeper game board is set up as a square. 
   ''' This is defaulted to true. If there's time, I'll program it for non-square
   ''' games.
   ''' </summary>
   Dim _IsSquare As Boolean = True

   ''' <summary>
   ''' Defines the number of rows of cGameTile objects that will be available on 
   ''' the GameBoard
   ''' </summary>
   Dim _Rows As Integer = 5

   ''' <summary>
   ''' Defines the number of cols of cGameTile objects that will be available on
   ''' the GameBoard
   ''' </summary>
   Dim _Cols As Integer = 5

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <returns></returns>
   Public ReadOnly Property IsSquare
      Get
         Return _IsSquare
      End Get
   End Property

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <returns></returns>
   Public ReadOnly Property Rows
      Get
         Return _Rows
      End Get
   End Property

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <returns></returns>
   Public ReadOnly Property Cols
      Get
         Return _Cols
      End Get
   End Property


End Class
