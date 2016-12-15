<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCourseCatalog
   Inherits System.Windows.Forms.Form

   'Form overrides dispose to clean up the component list.
   <System.Diagnostics.DebuggerNonUserCode()> _
   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
      Try
         If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
         End If
      Finally
         MyBase.Dispose(disposing)
      End Try
   End Sub

   'Required by the Windows Form Designer
   Private components As System.ComponentModel.IContainer

   'NOTE: The following procedure is required by the Windows Form Designer
   'It can be modified using the Windows Form Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCourseCatalog))
      Me.mnuMain = New System.Windows.Forms.MenuStrip()
      Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.btnReloadCatalog = New System.Windows.Forms.ToolStripMenuItem()
      Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.gbxStep01 = New System.Windows.Forms.GroupBox()
      Me.lblCourseFilter = New System.Windows.Forms.Label()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.tbxCourseFilter = New System.Windows.Forms.TextBox()
      Me.lbxCourses = New System.Windows.Forms.ListBox()
      Me.gbxStep02 = New System.Windows.Forms.GroupBox()
      Me.Label5 = New System.Windows.Forms.Label()
      Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.dtpStart = New System.Windows.Forms.DateTimePicker()
      Me.lbxDates = New System.Windows.Forms.ListBox()
      Me.GroupBox1 = New System.Windows.Forms.GroupBox()
      Me.tbxLength = New System.Windows.Forms.TextBox()
      Me.Label6 = New System.Windows.Forms.Label()
      Me.tbxAddress = New System.Windows.Forms.TextBox()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.tbxLink = New System.Windows.Forms.LinkLabel()
      Me.tbxCourseName = New System.Windows.Forms.TextBox()
      Me.lblLink = New System.Windows.Forms.Label()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.TextBox1 = New System.Windows.Forms.TextBox()
      Me.tmrReload = New System.Windows.Forms.Timer(Me.components)
      Me.CourseDBDataSet = New Course_Catalog.CourseDBDataSet()
      Me.TbCompleteOfferListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.TbCompleteOfferListTableAdapter = New Course_Catalog.CourseDBDataSetTableAdapters.tbCompleteOfferListTableAdapter()
      Me.TableAdapterManager = New Course_Catalog.CourseDBDataSetTableAdapters.TableAdapterManager()
      Me.TbCurrentOfferListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.TbCurrentOfferListTableAdapter = New Course_Catalog.CourseDBDataSetTableAdapters.tbCurrentOfferListTableAdapter()
      Me.TbCoursesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.TbCoursesTableAdapter = New Course_Catalog.CourseDBDataSetTableAdapters.tbCoursesTableAdapter()
      Me.TbCurrentOfferList1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.TbCurrentOfferList1TableAdapter = New Course_Catalog.CourseDBDataSetTableAdapters.tbCurrentOfferList1TableAdapter()
      Me.mnuMain.SuspendLayout()
      Me.gbxStep01.SuspendLayout()
      Me.gbxStep02.SuspendLayout()
      Me.GroupBox1.SuspendLayout()
      CType(Me.CourseDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TbCompleteOfferListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TbCurrentOfferListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TbCoursesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TbCurrentOfferList1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'mnuMain
      '
      Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
      Me.mnuMain.Location = New System.Drawing.Point(0, 0)
      Me.mnuMain.Name = "mnuMain"
      Me.mnuMain.Size = New System.Drawing.Size(735, 24)
      Me.mnuMain.TabIndex = 2
      Me.mnuMain.Text = "MenuStrip1"
      '
      'FileToolStripMenuItem
      '
      Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnReloadCatalog, Me.ExitToolStripMenuItem})
      Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
      Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
      Me.FileToolStripMenuItem.Text = "&File"
      '
      'btnReloadCatalog
      '
      Me.btnReloadCatalog.Name = "btnReloadCatalog"
      Me.btnReloadCatalog.Size = New System.Drawing.Size(154, 22)
      Me.btnReloadCatalog.Text = "&Reload Catalog"
      '
      'ExitToolStripMenuItem
      '
      Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
      Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
      Me.ExitToolStripMenuItem.Text = "E&xit"
      '
      'gbxStep01
      '
      Me.gbxStep01.Controls.Add(Me.lblCourseFilter)
      Me.gbxStep01.Controls.Add(Me.Label3)
      Me.gbxStep01.Controls.Add(Me.tbxCourseFilter)
      Me.gbxStep01.Controls.Add(Me.lbxCourses)
      Me.gbxStep01.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.gbxStep01.Location = New System.Drawing.Point(12, 27)
      Me.gbxStep01.Name = "gbxStep01"
      Me.gbxStep01.Size = New System.Drawing.Size(332, 276)
      Me.gbxStep01.TabIndex = 6
      Me.gbxStep01.TabStop = False
      Me.gbxStep01.Text = "Step 1 (Course Selection)"
      '
      'lblCourseFilter
      '
      Me.lblCourseFilter.AutoSize = True
      Me.lblCourseFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblCourseFilter.Location = New System.Drawing.Point(9, 23)
      Me.lblCourseFilter.Name = "lblCourseFilter"
      Me.lblCourseFilter.Size = New System.Drawing.Size(65, 13)
      Me.lblCourseFilter.TabIndex = 9
      Me.lblCourseFilter.Text = "Course Filter"
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(9, 23)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(0, 13)
      Me.Label3.TabIndex = 8
      '
      'tbxCourseFilter
      '
      Me.tbxCourseFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.tbxCourseFilter.Location = New System.Drawing.Point(92, 20)
      Me.tbxCourseFilter.Name = "tbxCourseFilter"
      Me.tbxCourseFilter.Size = New System.Drawing.Size(237, 20)
      Me.tbxCourseFilter.TabIndex = 7
      '
      'lbxCourses
      '
      Me.lbxCourses.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.lbxCourses.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lbxCourses.FormattingEnabled = True
      Me.lbxCourses.Location = New System.Drawing.Point(3, 48)
      Me.lbxCourses.Name = "lbxCourses"
      Me.lbxCourses.Size = New System.Drawing.Size(326, 225)
      Me.lbxCourses.TabIndex = 6
      '
      'gbxStep02
      '
      Me.gbxStep02.Controls.Add(Me.Label5)
      Me.gbxStep02.Controls.Add(Me.dtpEnd)
      Me.gbxStep02.Controls.Add(Me.Label4)
      Me.gbxStep02.Controls.Add(Me.dtpStart)
      Me.gbxStep02.Controls.Add(Me.lbxDates)
      Me.gbxStep02.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.gbxStep02.Location = New System.Drawing.Point(350, 27)
      Me.gbxStep02.Name = "gbxStep02"
      Me.gbxStep02.Size = New System.Drawing.Size(375, 276)
      Me.gbxStep02.TabIndex = 7
      Me.gbxStep02.TabStop = False
      Me.gbxStep02.Text = "Step 2 (Date Selection)"
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(206, 23)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(26, 13)
      Me.Label5.TabIndex = 12
      Me.Label5.Text = "And"
      '
      'dtpEnd
      '
      Me.dtpEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpEnd.Location = New System.Drawing.Point(243, 20)
      Me.dtpEnd.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
      Me.dtpEnd.Name = "dtpEnd"
      Me.dtpEnd.Size = New System.Drawing.Size(130, 20)
      Me.dtpEnd.TabIndex = 11
      Me.dtpEnd.Value = New Date(2017, 12, 31, 0, 0, 0, 0)
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(15, 23)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(49, 13)
      Me.Label4.TabIndex = 10
      Me.Label4.Text = "Between"
      '
      'dtpStart
      '
      Me.dtpStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpStart.Location = New System.Drawing.Point(70, 20)
      Me.dtpStart.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
      Me.dtpStart.Name = "dtpStart"
      Me.dtpStart.Size = New System.Drawing.Size(130, 20)
      Me.dtpStart.TabIndex = 8
      Me.dtpStart.Value = New Date(2017, 1, 1, 0, 0, 0, 0)
      '
      'lbxDates
      '
      Me.lbxDates.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.lbxDates.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lbxDates.FormattingEnabled = True
      Me.lbxDates.Location = New System.Drawing.Point(3, 48)
      Me.lbxDates.Name = "lbxDates"
      Me.lbxDates.Size = New System.Drawing.Size(369, 225)
      Me.lbxDates.TabIndex = 7
      '
      'GroupBox1
      '
      Me.GroupBox1.Controls.Add(Me.tbxLength)
      Me.GroupBox1.Controls.Add(Me.Label6)
      Me.GroupBox1.Controls.Add(Me.tbxAddress)
      Me.GroupBox1.Controls.Add(Me.Label2)
      Me.GroupBox1.Controls.Add(Me.tbxLink)
      Me.GroupBox1.Controls.Add(Me.tbxCourseName)
      Me.GroupBox1.Controls.Add(Me.lblLink)
      Me.GroupBox1.Controls.Add(Me.Label1)
      Me.GroupBox1.Controls.Add(Me.TextBox1)
      Me.GroupBox1.Location = New System.Drawing.Point(12, 309)
      Me.GroupBox1.Name = "GroupBox1"
      Me.GroupBox1.Size = New System.Drawing.Size(713, 164)
      Me.GroupBox1.TabIndex = 8
      Me.GroupBox1.TabStop = False
      Me.GroupBox1.Text = "Course Information"
      '
      'tbxLength
      '
      Me.tbxLength.Location = New System.Drawing.Point(86, 71)
      Me.tbxLength.Multiline = True
      Me.tbxLength.Name = "tbxLength"
      Me.tbxLength.ReadOnly = True
      Me.tbxLength.Size = New System.Drawing.Size(621, 23)
      Me.tbxLength.TabIndex = 8
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.Location = New System.Drawing.Point(4, 74)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(76, 13)
      Me.Label6.TabIndex = 7
      Me.Label6.Text = "Length (Days):"
      '
      'tbxAddress
      '
      Me.tbxAddress.Location = New System.Drawing.Point(86, 100)
      Me.tbxAddress.Multiline = True
      Me.tbxAddress.Name = "tbxAddress"
      Me.tbxAddress.ReadOnly = True
      Me.tbxAddress.Size = New System.Drawing.Size(621, 39)
      Me.tbxAddress.TabIndex = 6
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(29, 100)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(51, 13)
      Me.Label2.TabIndex = 5
      Me.Label2.Text = "Location:"
      '
      'tbxLink
      '
      Me.tbxLink.AutoSize = True
      Me.tbxLink.Location = New System.Drawing.Point(86, 48)
      Me.tbxLink.Name = "tbxLink"
      Me.tbxLink.Size = New System.Drawing.Size(51, 13)
      Me.tbxLink.TabIndex = 3
      Me.tbxLink.TabStop = True
      Me.tbxLink.Text = "Hyperlink"
      Me.tbxLink.Visible = False
      '
      'tbxCourseName
      '
      Me.tbxCourseName.Location = New System.Drawing.Point(86, 19)
      Me.tbxCourseName.Name = "tbxCourseName"
      Me.tbxCourseName.ReadOnly = True
      Me.tbxCourseName.Size = New System.Drawing.Size(621, 20)
      Me.tbxCourseName.TabIndex = 2
      '
      'lblLink
      '
      Me.lblLink.AutoSize = True
      Me.lblLink.Location = New System.Drawing.Point(26, 48)
      Me.lblLink.Name = "lblLink"
      Me.lblLink.Size = New System.Drawing.Size(54, 13)
      Me.lblLink.TabIndex = 1
      Me.lblLink.Text = "Hyperlink:"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(50, 22)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(30, 13)
      Me.Label1.TabIndex = 0
      Me.Label1.Text = "Title:"
      '
      'TextBox1
      '
      Me.TextBox1.Location = New System.Drawing.Point(86, 45)
      Me.TextBox1.Name = "TextBox1"
      Me.TextBox1.ReadOnly = True
      Me.TextBox1.Size = New System.Drawing.Size(621, 20)
      Me.TextBox1.TabIndex = 4
      '
      'tmrReload
      '
      Me.tmrReload.Enabled = True
      Me.tmrReload.Interval = 60000
      '
      'CourseDBDataSet
      '
      Me.CourseDBDataSet.DataSetName = "CourseDBDataSet"
      Me.CourseDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
      '
      'TbCompleteOfferListBindingSource
      '
      Me.TbCompleteOfferListBindingSource.DataMember = "tbCompleteOfferList"
      Me.TbCompleteOfferListBindingSource.DataSource = Me.CourseDBDataSet
      '
      'TbCompleteOfferListTableAdapter
      '
      Me.TbCompleteOfferListTableAdapter.ClearBeforeFill = True
      '
      'TableAdapterManager
      '
      Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
      Me.TableAdapterManager.Connection = Nothing
      Me.TableAdapterManager.tbCoursesTableAdapter = Nothing
      Me.TableAdapterManager.tbDatesTableAdapter = Nothing
      Me.TableAdapterManager.tbLocationsTableAdapter = Nothing
      Me.TableAdapterManager.UpdateOrder = Course_Catalog.CourseDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
      '
      'TbCurrentOfferListBindingSource
      '
      Me.TbCurrentOfferListBindingSource.DataMember = "tbCurrentOfferList"
      Me.TbCurrentOfferListBindingSource.DataSource = Me.CourseDBDataSet
      '
      'TbCurrentOfferListTableAdapter
      '
      Me.TbCurrentOfferListTableAdapter.ClearBeforeFill = True
      '
      'TbCoursesBindingSource
      '
      Me.TbCoursesBindingSource.DataMember = "tbCourses"
      Me.TbCoursesBindingSource.DataSource = Me.CourseDBDataSet
      '
      'TbCoursesTableAdapter
      '
      Me.TbCoursesTableAdapter.ClearBeforeFill = True
      '
      'TbCurrentOfferList1BindingSource
      '
      Me.TbCurrentOfferList1BindingSource.DataMember = "tbCurrentOfferList1"
      Me.TbCurrentOfferList1BindingSource.DataSource = Me.CourseDBDataSet
      '
      'TbCurrentOfferList1TableAdapter
      '
      Me.TbCurrentOfferList1TableAdapter.ClearBeforeFill = True
      '
      'frmCourseCatalog
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(735, 481)
      Me.Controls.Add(Me.GroupBox1)
      Me.Controls.Add(Me.gbxStep02)
      Me.Controls.Add(Me.gbxStep01)
      Me.Controls.Add(Me.mnuMain)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MainMenuStrip = Me.mnuMain
      Me.MaximizeBox = False
      Me.Name = "frmCourseCatalog"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Course Catalog"
      Me.mnuMain.ResumeLayout(False)
      Me.mnuMain.PerformLayout()
      Me.gbxStep01.ResumeLayout(False)
      Me.gbxStep01.PerformLayout()
      Me.gbxStep02.ResumeLayout(False)
      Me.gbxStep02.PerformLayout()
      Me.GroupBox1.ResumeLayout(False)
      Me.GroupBox1.PerformLayout()
      CType(Me.CourseDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TbCompleteOfferListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TbCurrentOfferListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TbCoursesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TbCurrentOfferList1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents CourseDBDataSet As CourseDBDataSet
   Friend WithEvents TbCompleteOfferListBindingSource As BindingSource
   Friend WithEvents TbCompleteOfferListTableAdapter As CourseDBDataSetTableAdapters.tbCompleteOfferListTableAdapter
   Friend WithEvents TableAdapterManager As CourseDBDataSetTableAdapters.TableAdapterManager
   Friend WithEvents mnuMain As MenuStrip
   Friend WithEvents gbxStep01 As GroupBox
   Friend WithEvents gbxStep02 As GroupBox
   Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
   Friend WithEvents btnReloadCatalog As ToolStripMenuItem
   Friend WithEvents TbCurrentOfferListBindingSource As BindingSource
   Friend WithEvents TbCurrentOfferListTableAdapter As CourseDBDataSetTableAdapters.tbCurrentOfferListTableAdapter
   Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
   Friend WithEvents GroupBox1 As GroupBox
   Friend WithEvents tbxAddress As TextBox
   Friend WithEvents Label2 As Label
   Friend WithEvents tbxLink As LinkLabel
   Friend WithEvents tbxCourseName As TextBox
   Friend WithEvents lblLink As Label
   Friend WithEvents Label1 As Label
   Friend WithEvents TextBox1 As TextBox
   Friend WithEvents lbxCourses As ListBox
   Friend WithEvents Label3 As Label
   Friend WithEvents tbxCourseFilter As TextBox
   Friend WithEvents lblCourseFilter As Label
   Friend WithEvents Label5 As Label
   Friend WithEvents dtpEnd As DateTimePicker
   Friend WithEvents Label4 As Label
   Friend WithEvents dtpStart As DateTimePicker
   Friend WithEvents lbxDates As ListBox
   Friend WithEvents tmrReload As Timer
   Friend WithEvents tbxLength As TextBox
   Friend WithEvents Label6 As Label
   Friend WithEvents TbCoursesBindingSource As BindingSource
   Friend WithEvents TbCoursesTableAdapter As CourseDBDataSetTableAdapters.tbCoursesTableAdapter
   Friend WithEvents TbCurrentOfferList1BindingSource As BindingSource
   Friend WithEvents TbCurrentOfferList1TableAdapter As CourseDBDataSetTableAdapters.tbCurrentOfferList1TableAdapter
End Class
