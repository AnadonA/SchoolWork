Public Class cVector(Of ObjectType)

   Private mX As Integer = 0
   Private mY As Integer = 0
   Private mZ As ObjectType

   ''' <summary>
   ''' </summary>
   ''' <returns>X Position of the cVector object</returns>
   Public ReadOnly Property X
      Get
         Return mX
      End Get
   End Property

   ''' <summary>
   ''' </summary>
   ''' <returns>Y Position of the cVector object</returns>
   Public ReadOnly Property Y
      Get
         Return mY
      End Get
   End Property

   ''' <summary>
   ''' </summary>
   ''' <returns>Data (of ObjectType) stored in the cVector object</returns>
   Public ReadOnly Property Data
      Get
         Return mZ
      End Get
   End Property


   ''' <summary>
   ''' cVector object constructor
   ''' </summary>
   ''' <param name="pX">X Position of the cVector Object</param>
   ''' <param name="pY">Y Position of the cVector Object</param>
   ''' <param name="pData">Data (of ObjectType) stored in the cVector Object</param>
   Public Sub New(ByVal pX As Integer, ByVal pY As Integer, ByVal pData As ObjectType)
      mX = pX
      mY = pY
      mZ = pData
   End Sub

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <param name="pData"></param>
   Friend Sub SetData(ByVal pData As ObjectType)
      mZ = pData
   End Sub


   Public Function LessThanX(ByRef pVector As cVector(Of ObjectType)) As Boolean
      Return X < pVector.X
   End Function

   Public Function LessThanY(ByRef pVector As cVector(Of ObjectType)) As Boolean
      Return Y < pVector.Y
   End Function


   Public Shared Operator =(ByVal pVector1 As cVector(Of ObjectType), ByVal pVector2 As cVector(Of ObjectType))
      Return pVector1.Data.Equals(pVector2)
   End Operator

   Public Shared Operator <>(ByVal pVector1 As cVector(Of ObjectType), ByVal pVector2 As cVector(Of ObjectType))
      Return pVector1.Data <> pVector2.Data
   End Operator

   Public Shared Operator <(ByVal pVector1 As cVector(Of ObjectType), ByVal pVector2 As cVector(Of ObjectType))
      Return pVector1.Data < pVector2.Data
   End Operator

   Public Shared Operator >(ByVal pVector1 As cVector(Of ObjectType), ByVal pVector2 As cVector(Of ObjectType))
      Return pVector1.Data > pVector2.Data
   End Operator

End Class
