''' <summary>
''' 
''' </summary>
Friend Class cGameTile

   Friend Enum eTileState
      COVERED
      QUESTIONED
      FLAGGED
      REMOVED
   End Enum

   ''' <summary>
   ''' 
   ''' </summary>
   Friend IsBomb As Boolean

   ''' <summary>
   ''' 
   ''' </summary>
   Friend Position As Point

   ''' <summary>
   ''' 
   ''' </summary>
   Friend Siblings(8) As Integer

   ''' <summary>
   ''' 
   ''' </summary>
   Friend Button As Button

End Class
