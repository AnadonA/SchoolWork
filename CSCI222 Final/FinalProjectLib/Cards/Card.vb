Imports System.Drawing

Public Class cCard

   '  CONSTANT DEFINITIONS ----------------------------------------------------
   Private Const CardRatio As Single = 1.3

   '  ATTRIBUTE DECLERATIONS  -------------------------------------------------
   Private mSize As Point
   Private mPosition As Point

   Private mFace As Bitmap

   Private mSuit As eSuits
   Private mValue As eValues

   Private mIsUsed As Boolean

   '  PROPERTY DEFINITIONS ----------------------------------------------------
   ''' <summary>
   ''' 
   ''' </summary>
   ''' <returns></returns>
   Public ReadOnly Property Size
      Get
         Return mSize
      End Get
   End Property

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <returns></returns>
   Public ReadOnly Property Face
      Get
         Return mFace
      End Get
   End Property

   ''' <summary>
   ''' 
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

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <returns></returns>
   Public ReadOnly Property IsUsed
      Get
         Return mIsUsed
      End Get
   End Property

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <returns></returns>
   Public ReadOnly Property Position
      Get
         Return mPosition
      End Get
   End Property

   '  SUB|FUNCTION DEFINITIONS   ----------------------------------------------
   ''' <summary>
   ''' 
   ''' </summary>
   ''' <param name="pFace"></param>
   ''' <param name="pSuit"></param>
   ''' <param name="pValue"></param>
   Friend Sub New(pFace As Image, pSuit As eSuits, pValue As eValues)
      mFace = pFace
      mSuit = pSuit
      mValue = pValue

      mSize = New Point(20, 20)
      mPosition = New Point(0, 0)
   End Sub

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <param name="pNewSize"></param>
   Friend Sub SetSize(pNewSize As Point)
      If (pNewSize.X > 0) Then

         '  Ensure the cards' aspect ratio is applied then store the requested
         '  card size
         pNewSize.Y = pNewSize.X * CardRatio
         mSize = pNewSize
      End If
   End Sub

   Friend Sub SetPosition(pX As Integer, pY As Integer)
      mPosition.X = pX
      mPosition.Y = pY

   End Sub

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <param name="pIsUsed"></param>
   Friend Sub SetUsage(pIsUsed As Boolean)
      mIsUsed = pIsUsed
   End Sub

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <param name="obj"></param>
   ''' <returns></returns>
   Public Overrides Function Equals(obj As Object) As Boolean
      Dim OtherCard As cCard = TryCast(obj, cCard)

      If (OtherCard IsNot Nothing) Then
         Return ((mFace.Equals(OtherCard.Face)) And (mSuit.Equals(OtherCard.Suit)))
      End If

      Return False
   End Function

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <param name="pCard"></param>
   ''' <returns></returns>
   Public Function TestSuit(ByVal pCard As cCard) As Boolean
      Return mSuit.Equals(pCard.Suit)
   End Function

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <param name="pCard"></param>
   ''' <returns></returns>
   Public Function TestValue(ByVal pCard As cCard) As Boolean
      Return mValue.Equals(pCard.Value)
   End Function

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <returns></returns>
   Public Function GetCardIndex() As Integer
      Return (DirectCast(mSuit, Integer) * 14) + (DirectCast(mValue, Integer) + 1)
   End Function
End Class
