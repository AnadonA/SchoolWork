Public Class cCard

   '  CLASS ENUMERATIONS ------------------------------------------------------
   ''' <summary>
   ''' 
   ''' </summary>
   Public Enum eSuits
      HEARTS
      SPADES
      DIAMONDS
      CLUBS
   End Enum

   ''' <summary>
   ''' 
   ''' </summary>
   Public Enum eValues
      TWO
      THREE
      FOUR
      FIVE
      SIX
      SEVEN
      EIGHT
      NINE
      TEN
      JACK
      QUEEN
      KING
      ACE
      JOKER
   End Enum
   '  END OF CLASS ENUMERATIONS   ---------------------------------------------

   '  CLASS VARIABLES   -------------------------------------------------------
   Private mSuit As eSuits
   Private mValue As eValues
   '  END OF CLASS VARIABLES  -------------------------------------------------

   '  CLASS PROPERTIES  -------------------------------------------------------
   ''' <summary>
   ''' Returns the 
   ''' </summary>
   ''' <returns></returns>
   Public ReadOnly Property Suit
      Get
         Return mSuit
      End Get
   End Property

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <returns></returns>
   Public ReadOnly Property Value
      Get
         Return mValue
      End Get
   End Property
   '  END OF CLASS PROPERTIES -------------------------------------------------

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <param name="pCard"></param>
   ''' <returns></returns>
   Overloads Function Equals(ByRef pCard As cCard) As Boolean
      If (pCard.Suit Is Suit) AndAlso (pCard.Value Is Value) Then
         Return True
      End If

      Return False
   End Function

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <param name="pSuit"></param>
   ''' <param name="pValue"></param>
   Public Sub SetCard(pSuit As eSuits, pValue As eValues)
      mSuit = pSuit
      mValue = pValue
   End Sub

End Class
