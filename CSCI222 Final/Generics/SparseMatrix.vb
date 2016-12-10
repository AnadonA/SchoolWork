'  NAME: SparseMatrix.vb
'  AUTH: Anthony Anadon (c) 2016
'  DESC: Defines the required objects and methods necessary for a simplified
'        Sparse Matrix. 

''' <summary>
''' Defines the SparseMatrixEntry structure (sSMEntry2D): its required attributes 
''' and methods. Because this structure is used ONLY within its SparseMatrix
''' parent(s), it is defined as a friend.
''' 
''' NOTES:  1) For this to function correctly, the ObjectType data type must 
'''         be a comparable data type (include methods for Equals and LessThan)
''' </summary>
''' <typeparam name="ObjectType">Any Comparable Data Type</typeparam>
Friend Structure sSMEntry2D(Of ObjectType)

   ''' <summary>
   ''' The X-Position of the entry
   ''' </summary>
   Public X As Integer

   ''' <summary>
   ''' The Y-Position of the entry
   ''' </summary>
   Public Y As Integer

   ''' <summary>
   ''' The Data of the entry
   ''' </summary>
   Public Data As ObjectType
End Structure


''' <summary>
''' Defines the SparseMatrix class (cSparseMatrix): its required attributes and
''' methods. 
''' 
''' SparseMatrices are used to save memory on objects that may have many 
''' duplicate data objects. The assumed duplicate data is stored as the 
''' mDefaultValue (during construction). Only objects that deviate from the
''' stored mDefaultValue are stored.
''' </summary>
''' <typeparam name="ObjectType">Any Comparable Data Type</typeparam>
Public Class cSparseMatrix2D(Of ObjectType)

   Private mTotalEntries As Integer
   Private mDefaultValue As ObjectType

   Private mData As List(Of List(Of sSMEntry2D(Of ObjectType)))

   ''' <summary>
   ''' Retrieves the entire SparseMatrix Data.
   ''' </summary>
   ''' <returns>List(Of List(Of sSMEntry2D(Of ObjectType)))</returns>
   Public ReadOnly Property Data
      Get
         Return mData
      End Get
   End Property

   ''' <summary>
   ''' Retrieves the default ObjectType value. 
   ''' 
   ''' NOTES:  1) This value is set during SparseMatrix construction. Failure
   '''         to appropriately set this value will cause the program to crash
   ''' </summary>
   ''' <returns>The Default ObjectType Value</returns>
   Public ReadOnly Property DefaultValue
      Get
         Return mDefaultValue
      End Get
   End Property

   ''' <summary>
   ''' Retrieves the Total Count of entries stored in the SparseMatrix object.
   ''' </summary>
   ''' <returns></returns>
   Public ReadOnly Property TotalEntries
      Get
         Return mTotalEntries
      End Get
   End Property

   ''' <summary>
   ''' The ONLY class constructor. Requires that the default [generic] 
   ''' ObjectType value is set. This value will be returned in lieu of EVERY
   ''' un-specified address in the SparseMatrix.
   ''' 
   ''' This constructor also defaults the SparseMatrix values and prepares it
   ''' for future use.
   ''' </summary>
   ''' <param name="pDefaultValue">A Valid ObjectType Value</param>
   Public Sub New(ByVal pDefaultValue As ObjectType)

      '  Store the default value
      mDefaultValue = pDefaultValue

      '  Create the primary data list
      mTotalEntries = 0
      mData = New List(Of List(Of sSMEntry2D(Of ObjectType)))

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
   ''' <param name="pX">The requested X-Address</param>
   ''' <param name="pY">The requested Y-Address</param>
   ''' <returns>The Data found at the requested (pX,pY) address. If no data is
   ''' specified in the requested address then the DefaultValue is returned</returns>
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
   ''' <param name="pX">The X-Position of the Data</param>
   ''' <param name="pY">The Y-Position of the Data</param>
   ''' <param name="pData">The Data that will be stored at the (pX,pY) location</param>
   ''' <returns></returns>
   Public Function Insert(ByVal pX As Integer, ByVal pY As Integer, ByVal pData As ObjectType) As Boolean

      Dim IndexX As Integer = 0
      Dim IndexY As Integer = 0
      Dim Inserted As Boolean = False

      '  Enter the OUTER loop. The goal of this loop is to locate the requested
      '  pX address. The loop is broken if: 1) the pX address is located and 
      '  the requested pData is successfully inserted (or removed) OR 2) each
      '  of the stored addresses are iterated through.
      Do While (Not Inserted And IndexX < mData.Count)

         '  Retrieve the X-Address of the first entry in this List(Of 
         '  sSMEntry2D(Of ObjectType)) and test it against the requested pX
         '  address. 
         Dim X As Integer = mData(IndexX).First().X
         If (X.Equals(pX)) Then

            '  The requested pX address has been located. Enter the INNER loop. 
            '  The goal of this loop is to locate the requested pY address. The
            '  loop is broken if: 1) the pY address is located and the requested
            '  pData is successfully inserted (or removed) OR 2) each of the 
            '  stored addresses are iterated through.
            Do While (Not Inserted And IndexY < mData(IndexX).Count)

               '  Retrieve the Y-Address of the current entry in this sSMEntry2D(Of
               '  ObjectType) and test it against the requested pY address.
               Dim Y As Integer = mData(IndexX)(IndexY).Y
               If (Y.Equals(pY)) Then

                  '  The requested pY address has been located. Process the 
                  '  pData request.
                  Dim Obj = mData(IndexX)(IndexY)
                  If (pData.Equals(mDefaultValue)) Then

                     '  The requested pData value EQUALS the mDefaultValue. 
                     '  Remove the sSMEntry2D(Of ObjectType) located at (IndexX)
                     '  (IndexY) and decrement the mTotalEntries value.
                     mData(IndexX).RemoveAt(IndexY)
                     mTotalEntries -= 1
                  Else

                     '  The requested pData value DOES NOT equal the 
                     '  mDefaultValue. Overwrite the sSMEntry2D(Of ObjectType)
                     '  Data value. Because there was already a specified 
                     '  sSMEntry2D(Of ObjectType) existing at the (IndexX)
                     '  (IndexY) address, this does not increment the 
                     '  mTotalEntries value.
                     Obj.Data = pData
                  End If

                  '  The insertion request was successfully completed. Set
                  '  the Inserted flag to true and EXIT the INNER loop. The
                  '  OUTER loop will be EXITed once it sees the Inserted flag.
                  Inserted = True
                  Exit Do
               ElseIf (Y < pY) Then

                  '  The requested pY address was skipped. This infers that 
                  '  there are no specified values that exist for that pY 
                  '  address. Create a new sSMEntry2D(Of ObjectType) object and
                  '  insert it at the current IndexY. By using the Insert
                  '  function, we insert it without compromising the data
                  '  that is stored after it.
                  Dim NewObject As sSMEntry2D(Of ObjectType) = New sSMEntry2D(Of ObjectType)()
                  NewObject.X = pX
                  NewObject.Y = pY
                  NewObject.Data = pData
                  mData(IndexX).Insert(IndexY, NewObject)

                  '  The insertion request was successfully completed. Set
                  '  the Inserted flag to true and EXIT the INNER loop. The
                  '  OUTER loop will be EXITed once it sees the Inserted flag.
                  Insert = True
                  mTotalEntries += 1
                  Exit Do
               End If

               '  Increment the IndexY value so that the next object can be
               '  tested against.
               IndexY += 1
            Loop
            If (Not Inserted) Then

               '  If the requested pY address hasn't been either located or passed
               '  by, then it doesn't exist. Create a new sSMEntry2D(Of ObjectType)
               '  and add it to the end of the current List(Of sSMEntry2D(Of ObjectType))
               Dim NewObject As sSMEntry2D(Of ObjectType) = New sSMEntry2D(Of ObjectType)()
               NewObject.X = pX
               NewObject.Y = pY
               NewObject.Data = pData
               mData(IndexX).Add(NewObject)

               '  The insertion request was successfully completed. Set
               '  the Inserted flag to true and EXIT the INNER loop. The
               '  OUTER loop will be EXITed once it sees the Inserted flag.
               Insert = True
               mTotalEntries += 1
            End If
         ElseIf (X < pX) Then

            '  The requested pX address was passed. This infers that a List(Of
            '  sSMEntry2D(Of ObjectType)) does not exist at the requested pX 
            '  address. Create a new List(Of sSMEntry2D(Of ObjectType)) and an
            '  sSMEntry2D(Of ObjectType). Add the sSMEntry2D object into the List(Of
            '  sSMEntry2D) object and insert the List into mData at the IndexX
            '  location.
            Dim NewList As List(Of sSMEntry2D(Of ObjectType)) = New List(Of sSMEntry2D(Of ObjectType))()
            Dim NewObject As sSMEntry2D(Of ObjectType) = New sSMEntry2D(Of ObjectType)()
            NewObject.X = pX
            NewObject.Y = pY
            NewObject.Data = pData
            NewList.Add(NewObject)
            mData.Insert(IndexX, NewList)


            '  The insertion request was successfully completed. Set
            '  the Inserted flag to true and EXIT the OUTER loop.
            Insert = True
            mTotalEntries += 1
            Exit Do
         End If

         '  Increment the IndexX value so that we may continue iterating
         IndexX += 1
      Loop
      If (Not Inserted) Then

         '  The end of the list was reached without inserting the requested 
         '  object. Create a new sSMEntry2D object, insert it into a new 
         '  List(of sSMEntry2D) object, and insert that list into the mData 
         '  List(of List(of sSMEntry2D)) object.
         Dim NewList As List(Of sSMEntry2D(Of ObjectType)) = New List(Of sSMEntry2D(Of ObjectType))()
         Dim NewObject As sSMEntry2D(Of ObjectType) = New sSMEntry2D(Of ObjectType)()
         NewObject.X = pX
         NewObject.Y = pY
         NewObject.Data = pData
         NewList.Add(NewObject)
         mData.Add(NewList)

         '  Increment the total entry count
         Insert = True
         mTotalEntries += 1
      End If

      Return Inserted
   End Function
End Class
