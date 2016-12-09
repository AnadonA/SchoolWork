'  NAME: 
'  INST: CVaughn CSCI222
'  AUTH: Anthony Anadon (c) 2016
'  DESC:

''' <summary>
''' 
''' </summary>
''' <typeparam name="ObjectType"></typeparam>
Public Structure cVector2(Of ObjectType)
   Public X As ObjectType
   Public Y As ObjectType

   Public Sub New(ByVal pX As ObjectType, ByVal pY As ObjectType)
      X = pX
      Y = pY
   End Sub
End Structure

''' <summary>
''' 
''' </summary>
''' <typeparam name="ObjectType"></typeparam>
Public Structure cVector3(Of ObjectType)
   Public X As ObjectType
   Public Y As ObjectType
   Public Z As ObjectType

   Public Sub New(ByVal pX As ObjectType, ByVal pY As ObjectType, ByVal pZ As ObjectType)
      X = pX
      Y = pY
      Z = pZ
   End Sub
End Structure
