Public Class frmCourseCatalog

   Dim CourseDates(10) As Date

   Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      'TODO: This line of code loads data into the 'CourseDBDataSet.tbCurrentOfferList' table. You can move, or remove it, as needed.
      Me.TbCurrentOfferListTableAdapter.Fill(Me.CourseDBDataSet.tbCurrentOfferList)
      '  Load the CompleteOfferList TableAdapter
      Me.TbCompleteOfferListTableAdapter.Fill(Me.CourseDBDataSet.tbCompleteOfferList)

      '  Create the course list
      ReloadCatalog()

   End Sub

   Private Sub btnReloadCatalog_Click(sender As Object, e As EventArgs) Handles btnReloadCatalog.Click
      ReloadCatalog()
   End Sub

   Private Sub ReloadCatalog()
      '  Retrieve the list of courses available and insert them into the 
      '  Course Selection Combobox
      cbxCourseSelection.Items.Clear()
      For Each Course In CourseDBDataSet.tbCurrentOfferList
         Dim CourseName As String = Course.Name
         If Not cbxCourseSelection.Items.Contains(CourseName) Then
            cbxCourseSelection.Items.Add(Course.Name)
         End If
      Next
   End Sub

   Private Sub cbxCourseSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCourseSelection.SelectedIndexChanged

      '  Get the Offered Dates
      Dim CurrentOffers As Array =
         Aggregate Course In CourseDBDataSet.tbCurrentOfferList
            Where Course.Name Like cbxCourseSelection.SelectedItem
               Select Course.OfferDate
                  Into ToArray

      cbxOfferSelection.Items.Clear()
      For Each Offer In CurrentOffers
         cbxOfferSelection.Items.Add(Format(Offer, "D"))
      Next
      cbxOfferSelection.SelectedIndex = 0

   End Sub

   Private Sub cbxOfferSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxOfferSelection.SelectedIndexChanged
      Dim SelectedCourse As CourseDBDataSet.tbCurrentOfferListRow =
         Aggregate Course In CourseDBDataSet.tbCurrentOfferList
            Where Course.Name Like cbxCourseSelection.SelectedItem And Course.OfferDate Like cbxOfferSelection.SelectedItem
               Select Course
                  Into FirstOrDefault


      tbxCourseName.Text = SelectedCourse.Name
      'tbxLink.Text = SelectedCourse.Link
      tbxAddress.Text = SelectedCourse.StreedAddress & " " & SelectedCourse.Suite & " " _
         & SelectedCourse.City & SelectedCourse.ZipCode


   End Sub

End Class
