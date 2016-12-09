Public Class cSparseMatrix(Of ObjectType)

   Private mTotalObjects As Integer
   Private mDefaultValue As ObjectType
   Private mData As List(Of List(Of cVector(Of ObjectType)))



   ''' <summary>
   ''' Clears the sparse matrix of values (which, infers that all addresses 
   ''' will return the default value
   ''' </summary>
   Public Sub Clear()
      For Each Row In mData
         Row.Clear()
      Next
      mData.Clear()
   End Sub

   Public Sub PrintMatrix()
      For x As Integer = 0 To mData.Count - 1
         Debug.Write(mData(x).First().X & ":")

         For y As Integer = 0 To mData(x).Count - 1
            Debug.Write(mData(x)(y).Y & " ")
         Next

         Debug.WriteLine("")
      Next

   End Sub

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <param name="pDefaultValue"></param>
   Public Sub New(pDefaultValue As ObjectType)
      mTotalObjects = 0
      mDefaultValue = pDefaultValue
      mData = New List(Of List(Of cVector(Of ObjectType)))
   End Sub

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <param name="pX"></param>
   ''' <param name="pY"></param>
   ''' <param name="pData"></param>
   Public Sub SetValue(pX As Integer, pY As Integer, pData As ObjectType)

      Dim Inserted As Boolean = False
      Dim IndexX As Integer = 0
      Dim TotalX As Integer = mData.Count

      If (mData.Count < 1) Then

         mData.Add(New List(Of cVector(Of ObjectType)))
         Dim Vector As cVector(Of ObjectType) = New cVector(Of ObjectType)(pX, pY, pData)
         mData(0).Add(Vector)

         Inserted = True
      End If


      '  Enter the outer X loop to search for the correct row
      Do While (IndexX < TotalX And Not Inserted)

         '  Retrieve the first item in the current row
         Dim First = mData(IndexX).First()

         If (pX.Equals(First.X)) Then

            '  The correct row has been identified. Begin searching for the 
            '  correct inner Y column
            Dim IndexY As Integer = 0
            Dim TotalY As Integer = mData(IndexX).Count
            Do While (IndexY < TotalY And Not Inserted)

               If (pY.Equals(mData(IndexX)(IndexY).Y)) Then
                  If (Not pData.Equals(mDefaultValue)) Then
                     '  The correct column has been identified. Simply save the
                     '  requested value
                     mData(IndexX)(IndexY).SetData(pData)
                  Else
                     '  If the requested set value is the default value then DO
                     '  NOT set the data, simply remove it.
                     mData(IndexX).RemoveAt(IndexY)

                     '  Because the object was deleted, decrement the total 
                     '  object counter
                     mTotalObjects -= 1
                  End If

                  '  By setting this value to true, the loop will break before
                  '  its next iteration.
                  Inserted = True
               ElseIf (pY < mData(IndexX)(IndexY).Y) Then

                  '  The correct column has been skipped. This *should* infer 
                  '  that the correct column does not exist. Create and insert
                  '  the cVector object at the current position.
                  If (Not pData.Equals(mDefaultValue)) Then
                     Dim Data As cVector(Of ObjectType) = New cVector(Of ObjectType)(pX, pY, pData)
                     mData(IndexX).Insert(IndexY, Data)

                     '  Increment the number of total objects stored
                     mTotalObjects += 1
                  End If

                  '  By setting this value to true, the loop will break before
                  '  its next iteration.
                  Inserted = True
               End If

               '  Increment the innter Y loop
               IndexY += 1
            Loop

         ElseIf (pX < First.X) Then

            '  The correct row has been skipped. This *should* infer that it 
            '  does not exist. Create and insert the List(of cVector) objects 
            '  at the current position
            If (Not pData.Equals(mDefaultValue)) Then
               Dim Vector As cVector(Of ObjectType) = New cVector(Of ObjectType)(pX, pY, pData)
               Dim List As List(Of cVector(Of ObjectType)) = New List(Of cVector(Of ObjectType))
               List.Add(Vector)
               mData.Insert(IndexX, List)

               '  Increment the number of total objects stored
               mTotalObjects += 1
            End If


            '  By setting this value to true, the loop will break before its 
            '  next iteration
            Inserted = True
            End If

            '  Increment the outer X loop
            IndexX += 1
      Loop

   End Sub

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <param name="pX"></param>
   ''' <param name="pY"></param>
   ''' <returns></returns>
   Public Function GetValue(pX As Integer, pY As Integer) As ObjectType
      '  Test for an empty matrix
      If (mTotalObjects < 1) Then
         Return mDefaultValue
      End If

      Dim IndexX As Integer = 0
      Dim TotalX As Integer = mData.Count

      Do While (IndexX < TotalX)

         Dim First = mData(IndexX).First()
         If (pX.Equals(First.X)) Then

            '  Iterate through the inner (column) data
            Dim IndexY As Integer = 0
            Dim TotalY As Integer = mData(IndexX).Count
            Do While (IndexY < TotalY)

               If (pY.Equals(mData(IndexX)(IndexY).Y)) Then

                  '  The requested location exists; return it
                  Return mData(IndexX)(IndexY).Data
               ElseIf (pY < mData(IndexX)(IndexY).Y) Then

                  '  There was no stored data for the requested inner (column)
                  '  value. Return the default value
                  Return mDefaultValue
               End If

               '  Increment the inner (column) loop
               IndexY += 1
            Loop
         ElseIf (pX < First.X) Then

            '  There was no stored data at all for the requested outer (row) 
            '  value. Return the default object value
            Return mDefaultValue
         End If

         '  Increment the outer (row) loop
         IndexX += 1
      Loop

      '  If the loops have made it this far, then there is no data for the
      '  requested address. Return the default value
      Return mDefaultValue

   End Function
End Class
