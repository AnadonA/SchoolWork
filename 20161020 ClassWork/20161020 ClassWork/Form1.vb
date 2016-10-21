Public Class Form1

    Structure Student
        Public stuID As String
        Public firstName As String
        Public lastName As String
        Public birthDate As Date
    End Structure

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim myStudent As Student
        With myStudent
            .firstName = "Anthony"
            .lastName = "Anadon"
            .stuID = "w0823899"
            .birthDate = New Date(1891, 12, 4)
        End With

    End Sub
End Class
