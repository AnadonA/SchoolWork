

Public Class cMaze
   Private mWall As Char = "█"      '[alt] + 219
   Private mCharacter As Char = "ø" '[alt] + 248

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <returns></returns>
   Public ReadOnly Property Wall
      Get
         Return mWall
      End Get
   End Property

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <returns></returns>
   Public ReadOnly Property Character
      Get
         Return mCharacter
      End Get
   End Property

End Class
