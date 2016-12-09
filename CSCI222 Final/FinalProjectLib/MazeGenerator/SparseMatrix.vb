'  NAME: SparseMatrix.vb
'  INST: CVaughn CSCI222
'  AUTH: Anthony Anadon (c) 2016
'  DESC: Defines the required objects and methods necessary for a simplified
'        Sparse Matrix. 

''' <summary>
''' 
''' </summary>
''' <typeparam name="ObjectType"></typeparam>
Public Structure cSMEntry(Of ObjectType)
   Public X As Integer
   Public Y As Integer
   Public Data As ObjectType
End Structure

Public Class cSparseMatrix(Of ObjectType)

   Private mTotalEntries As Integer
   Private mDefaultValue As ObjectType

   Private mData As List(Of List(Of cSMEntry(Of ObjectType)))

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <returns></returns>
   Public ReadOnly Property Data
      Get
         Return mData
      End Get
   End Property

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <returns></returns>
   Public ReadOnly Property DefaultValue
      Get
         Return mDefaultValue
      End Get
   End Property

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <returns></returns>
   Public ReadOnly Property TotalEntries
      Get
         Return mTotalEntries
      End Get
   End Property

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <param name="pDefaultValue"></param>
   Public Sub New(ByVal pDefaultValue As ObjectType)

      '  Store the default value
      mDefaultValue = pDefaultValue

      '  Create the primary data list
      mTotalEntries = 0
      mData = New List(Of List(Of cSMEntry(Of ObjectType)))

      '  Ensure the data lists are ready for use
      Reset()
   End Sub

   ''' <summary>
   ''' Clears all SparseMatrix data and prepares it for use
   ''' </summary>
   Public Sub Reset()

      '  Clear the entire data list and reset the totalizer
      For Each List In mData
         List.Clear()
      Next
      mData.Clear()
      mTotalEntries = 0

   End Sub

   ''' <summary>
   ''' Reads the ObjectType data stored at the (pX, pY) location.
   ''' 
   ''' NOTES:  1) If there is no data specified at the requested (pX, pY) 
   '''         location the mDefaultValue is returned
   ''' </summary>
   ''' <param name="pX"></param>
   ''' <param name="pY"></param>
   ''' <returns></returns>
   Public Function ReadData(ByVal pX As Integer, ByVal pY As Integer) As ObjectType

      For Each Line In mData

         '  Get the current X index and test against it
         Dim X = Line.First().X
         If (X.Equals(pX)) Then

            For Each MazeObject In Line

               '  Get the current Y index and test against it
               Dim Y = MazeObject.Y
               If (Y.Equals(pY)) Then

                  '  Return the data stored at the requested location (pX, pY)
                  Return MazeObject.Data
               ElseIf (Y < pY) Then

                  '  There is no data specified at the requested pY index
                  Return mDefaultValue
               End If
            Next

         ElseIf (X < pX) Then

            '  There is no data specified at the requested pX index
            Return mDefaultValue
         End If
      Next

      Return mDefaultValue
   End Function

   ''' <summary>
   ''' Attempts to insert pData at the (pX,pY) coordinates. 
   ''' 
   ''' NOTES:  1) If an object already exists at that location it will be 
   '''         overwritten.
   '''         2) If the requested data is equal to mDefaulValue (set during
   '''         construction) then the data at location (pX, pY) is removed.
   ''' </summary>
   ''' <param name="pX"></param>
   ''' <param name="pY"></param>
   ''' <param name="pData"></param>
   ''' <returns></returns>
   Public Function Insert(ByVal pX As Integer, ByVal pY As Integer, ByVal pData As ObjectType) As Boolean



      Return False
   End Function


End Class
