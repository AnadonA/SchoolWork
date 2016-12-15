Imports System.Linq
Imports System.Net.Mail


Public Class frmCourseCatalog

   '  -------------------------------------------------------------------------
   '  CLASS VARIABLES   -------------------------------------------------------
   Dim SelectedCourse As String
   Dim CourseAddress(3) As String
   Dim SelectedDate As Date = Date.MinValue

   '  -------------------------------------------------------------------------
   '  EVENT HANDLERS ----------------------------------------------------------

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <param name="sender"></param>
   ''' <param name="e"></param>
   Private Sub Form1_Load(sender As Object, e As EventArgs) _
      Handles MyBase.Load

      '  Rename the window title
      Dim ThisYear = Today.Year
      Dim NextYear = Today.Year + 1
      Dim TitleString = ThisYear.ToString() & " - " & NextYear.ToString() & " Course Catalog"
      Me.Text = TitleString

      'TODO: This line of code loads data into the 'CourseDBDataSet.tbCurrentOfferList1' table. You can move, or remove it, as needed.
      Me.TbCurrentOfferList1TableAdapter.Fill(Me.CourseDBDataSet.tbCurrentOfferList1)

      'TODO: This line of code loads data into the 'CourseDBDataSet.tbCurrentOfferList' table. You can move, or remove it, as needed.
      Me.TbCurrentOfferListTableAdapter.Fill(Me.CourseDBDataSet.tbCurrentOfferList)
      '  Load the CompleteOfferList TableAdapter
      Me.TbCompleteOfferListTableAdapter.Fill(Me.CourseDBDataSet.tbCompleteOfferList)

      '  Create the course list
      ReloadCatalog()

   End Sub

   ''' <summary>
   ''' Handles the btnReloadCatalog Click event by performing the 
   ''' ReloadCatalog sub.
   ''' </summary>
   ''' <param name="sender">UNUSED</param>
   ''' <param name="e">UNUSED</param>
   Private Sub btnReloadCatalog_Click(sender As Object, e As EventArgs) _
      Handles btnReloadCatalog.Click
      ReloadCatalog()
      FilterCatalog()
   End Sub

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <param name="sender"></param>
   ''' <param name="e"></param>
   Private Sub tbxCourseFilter_Modified(sender As Object, e As EventArgs) _
      Handles tbxCourseFilter.KeyUp
      FilterCatalog()
   End Sub

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <param name="sender"></param>
   ''' <param name="e"></param>
   Private Sub tmrReload_Tick(sender As Object, e As EventArgs) _
      Handles tmrReload.Tick
      ReloadCatalog()
      FilterCatalog()
   End Sub


   ''' <summary>
   ''' 
   ''' </summary>
   ''' <param name="sender"></param>
   ''' <param name="e"></param>
   Private Sub lbxCourses_Selection(sender As Object, e As EventArgs) _
      Handles lbxCourses.SelectedIndexChanged
      If (SelectedCourse = lbxCourses.SelectedItem) Then
         SelectedCourse = String.Empty
         lbxCourses.SelectedIndex = -1
      Else
         SelectedCourse = lbxCourses.SelectedItem
      End If

      FilterDates()
   End Sub

   Private Sub lbxDates_Selection(sender As Object, e As EventArgs) _
      Handles lbxDates.SelectedIndexChanged

      '  
      If (lbxDates.SelectedIndex >= 0) Then
         SelectedDate = lbxDates.SelectedItem
      Else
         SelectedDate = Date.MinValue
      End If

      '  Display the course info
      DisplayCourseInfo()
   End Sub

   Private Sub dtpFilter_Changed(sender As Object, e As EventArgs) _
      Handles dtpStart.ValueChanged, dtpEnd.ValueChanged
      FilterDates()
   End Sub

   '  -------------------------------------------------------------------------
   '  CUSTOM METHODS ----------------------------------------------------------
   ''' <summary>
   ''' Clears the lbxCourses data list then adds
   ''' </summary>
   Private Sub ReloadCatalog()

      '  Retrieve the list of courses available and insert them into the 
      '  Course Selection Combobox
      lbxCourses.Items.Clear()
      For Each Course In CourseDBDataSet.tbCurrentOfferList
         Dim CourseName As String = Course.Name
         If Not lbxCourses.Items.Contains(CourseName) Then
            lbxCourses.Items.Add(Course.Name)
         End If
      Next

      '  Re-Apply the current selection (if one exists) and Re-Filter the Dates
      If (SelectedCourse <> String.Empty) Then
         lbxCourses.SelectedIndex = lbxCourses.Items.IndexOf(SelectedCourse)
         FilterDates()

         If (SelectedDate <> Date.MinValue) Then
            lbxDates.SelectedIndex = lbxDates.Items.IndexOf(SelectedDate)
         End If
      End If

   End Sub

   ''' <summary>
   ''' Retrieves and applies any filter text that applies in the tbxCourseFilter 
   ''' TextBox.
   ''' </summary>
   Private Sub FilterCatalog()

      Dim FilterText As String = tbxCourseFilter.Text

      lbxCourses.Items.Clear()
      Dim FilteredCourses As Array =
         Aggregate Course In CourseDBDataSet.tbCurrentOfferList
            Where Course.Name.ToLower() Like "*" & tbxCourseFilter.Text.ToLower() & "*"
               Into ToArray

      For Each Course In FilteredCourses
         Dim CourseName As String = Course.Name
         If Not lbxCourses.Items.Contains(CourseName) Then
            lbxCourses.Items.Add(CourseName)
         End If
      Next

   End Sub

   ''' <summary>
   ''' 
   ''' </summary>
   Private Sub FilterDates()

      Dim EndFilter As Date = dtpEnd.Value
      Dim StartFilter As Date = dtpStart.Value

      '  Clear the date list box
      lbxDates.Items.Clear()

      '  If there is a selected course, then retrieve its offer dates. 
      '  Otherwise, leave the ListBox empty
      If Not SelectedCourse = String.Empty Then
         Dim FilteredCourses As Array =
         Aggregate Course In CourseDBDataSet.tbCurrentOfferList
            Where Course.Name.ToLower() Like SelectedCourse.ToLower() And (Course.OfferDate >= StartFilter And Course.OfferDate <= EndFilter)
               Into ToArray

         For Each Course In FilteredCourses
            Dim CourseDate As Date = Course.OfferDate
            If Not lbxDates.Items.Contains(CourseDate) Then
               lbxDates.Items.Add(CourseDate.ToLongDateString())
            End If
         Next
      End If
   End Sub


   Private Sub DisplayCourseInfo()

      If (SelectedDate <> Date.MinValue) Then

         SelectedDate = lbxDates.SelectedItem


         Dim Course =
         Aggregate CourseRow In CourseDBDataSet.tbCurrentOfferList1
            Where CourseRow.Name Like SelectedCourse And CourseRow.OfferDate Like SelectedDate
               Into First()

         tbxCourseName.Text = Course.Name
         CourseAddress(0) = Course.StreedAddress & " " & Course.Suite
         CourseAddress(1) = Course.City & ", CA " & Course.ZipCode
         tbxAddress.Lines = CourseAddress

         Dim CourseInfo =
            Aggregate CourseRow In CourseDBDataSet.tbCourses
               Where CourseRow.Name Like SelectedCourse
                  Into First()

         tbxLink.Text = CourseInfo.Link
         tbxLength.Text = CourseInfo.Length.ToString()

      Else
         tbxCourseName.Clear()
         lblLink.Text = ""

         CourseAddress(0) = CourseAddress(1) = CourseAddress(2) = String.Empty
         tbxAddress.Lines = CourseAddress
      End If

   End Sub
End Class
