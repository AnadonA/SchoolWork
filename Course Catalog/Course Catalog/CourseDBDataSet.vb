Partial Class CourseDBDataSet
   Partial Public Class tbCurrentOfferListDataTable
      Private Sub tbCurrentOfferListDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
         If (e.Column.ColumnName = Me.LinkColumn.ColumnName) Then
            'Add user code here
         End If

      End Sub

   End Class
End Class

Namespace CourseDBDataSetTableAdapters

   Partial Public Class tbCurrentOfferListTableAdapter
   End Class
End Namespace
