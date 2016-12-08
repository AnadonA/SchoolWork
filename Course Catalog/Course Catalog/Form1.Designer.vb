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
      Me.CourseDBDataSet = New Course_Catalog.CourseDBDataSet()
      Me.TbCompleteOfferListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.TbCompleteOfferListTableAdapter = New Course_Catalog.CourseDBDataSetTableAdapters.tbCompleteOfferListTableAdapter()
      Me.TableAdapterManager = New Course_Catalog.CourseDBDataSetTableAdapters.TableAdapterManager()
      Me.mnuMain = New System.Windows.Forms.MenuStrip()
      Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.btnReloadCatalog = New System.Windows.Forms.ToolStripMenuItem()
      Me.cbxCourseSelection = New System.Windows.Forms.ComboBox()
      Me.gbxStep01 = New System.Windows.Forms.GroupBox()
      Me.gbxStep02 = New System.Windows.Forms.GroupBox()
      Me.TbCurrentOfferListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.TbCurrentOfferListTableAdapter = New Course_Catalog.CourseDBDataSetTableAdapters.tbCurrentOfferListTableAdapter()
      Me.cbxOfferSelection = New System.Windows.Forms.ComboBox()
      Me.GroupBox1 = New System.Windows.Forms.GroupBox()
      Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.lblLink = New System.Windows.Forms.Label()
      Me.tbxCourseName = New System.Windows.Forms.TextBox()
      Me.tbxLink = New System.Windows.Forms.LinkLabel()
      Me.TextBox1 = New System.Windows.Forms.TextBox()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.tbxAddress = New System.Windows.Forms.TextBox()
      CType(Me.CourseDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TbCompleteOfferListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.mnuMain.SuspendLayout()
      Me.gbxStep01.SuspendLayout()
      Me.gbxStep02.SuspendLayout()
      CType(Me.TbCurrentOfferListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.GroupBox1.SuspendLayout()
      Me.SuspendLayout()
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
      'mnuMain
      '
      Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
      Me.mnuMain.Location = New System.Drawing.Point(0, 0)
      Me.mnuMain.Name = "mnuMain"
      Me.mnuMain.Size = New System.Drawing.Size(540, 24)
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
      'cbxCourseSelection
      '
      Me.cbxCourseSelection.FormattingEnabled = True
      Me.cbxCourseSelection.Location = New System.Drawing.Point(12, 19)
      Me.cbxCourseSelection.Name = "cbxCourseSelection"
      Me.cbxCourseSelection.Size = New System.Drawing.Size(227, 21)
      Me.cbxCourseSelection.TabIndex = 5
      '
      'gbxStep01
      '
      Me.gbxStep01.Controls.Add(Me.cbxCourseSelection)
      Me.gbxStep01.Location = New System.Drawing.Point(12, 27)
      Me.gbxStep01.Name = "gbxStep01"
      Me.gbxStep01.Size = New System.Drawing.Size(254, 54)
      Me.gbxStep01.TabIndex = 6
      Me.gbxStep01.TabStop = False
      Me.gbxStep01.Text = "Step 1 (Course Selection)"
      '
      'gbxStep02
      '
      Me.gbxStep02.Controls.Add(Me.cbxOfferSelection)
      Me.gbxStep02.Location = New System.Drawing.Point(272, 27)
      Me.gbxStep02.Name = "gbxStep02"
      Me.gbxStep02.Size = New System.Drawing.Size(254, 54)
      Me.gbxStep02.TabIndex = 7
      Me.gbxStep02.TabStop = False
      Me.gbxStep02.Text = "Step 2 (Date Selection)"
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
      'cbxOfferSelection
      '
      Me.cbxOfferSelection.FormattingEnabled = True
      Me.cbxOfferSelection.Location = New System.Drawing.Point(12, 19)
      Me.cbxOfferSelection.Name = "cbxOfferSelection"
      Me.cbxOfferSelection.Size = New System.Drawing.Size(227, 21)
      Me.cbxOfferSelection.TabIndex = 6
      '
      'GroupBox1
      '
      Me.GroupBox1.Controls.Add(Me.tbxAddress)
      Me.GroupBox1.Controls.Add(Me.Label2)
      Me.GroupBox1.Controls.Add(Me.tbxLink)
      Me.GroupBox1.Controls.Add(Me.tbxCourseName)
      Me.GroupBox1.Controls.Add(Me.lblLink)
      Me.GroupBox1.Controls.Add(Me.Label1)
      Me.GroupBox1.Controls.Add(Me.TextBox1)
      Me.GroupBox1.Location = New System.Drawing.Point(12, 87)
      Me.GroupBox1.Name = "GroupBox1"
      Me.GroupBox1.Size = New System.Drawing.Size(514, 105)
      Me.GroupBox1.TabIndex = 8
      Me.GroupBox1.TabStop = False
      Me.GroupBox1.Text = "Course Information"
      '
      'ExitToolStripMenuItem
      '
      Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
      Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
      Me.ExitToolStripMenuItem.Text = "E&xit"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(9, 22)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(30, 13)
      Me.Label1.TabIndex = 0
      Me.Label1.Text = "Title:"
      '
      'lblLink
      '
      Me.lblLink.AutoSize = True
      Me.lblLink.Location = New System.Drawing.Point(9, 48)
      Me.lblLink.Name = "lblLink"
      Me.lblLink.Size = New System.Drawing.Size(54, 13)
      Me.lblLink.TabIndex = 1
      Me.lblLink.Text = "Hyperlink:"
      '
      'tbxCourseName
      '
      Me.tbxCourseName.Location = New System.Drawing.Point(69, 19)
      Me.tbxCourseName.Name = "tbxCourseName"
      Me.tbxCourseName.ReadOnly = True
      Me.tbxCourseName.Size = New System.Drawing.Size(430, 20)
      Me.tbxCourseName.TabIndex = 2
      '
      'tbxLink
      '
      Me.tbxLink.AutoSize = True
      Me.tbxLink.Location = New System.Drawing.Point(69, 48)
      Me.tbxLink.Name = "tbxLink"
      Me.tbxLink.Size = New System.Drawing.Size(51, 13)
      Me.tbxLink.TabIndex = 3
      Me.tbxLink.TabStop = True
      Me.tbxLink.Text = "Hyperlink"
      Me.tbxLink.Visible = False
      '
      'TextBox1
      '
      Me.TextBox1.Location = New System.Drawing.Point(69, 45)
      Me.TextBox1.Name = "TextBox1"
      Me.TextBox1.ReadOnly = True
      Me.TextBox1.Size = New System.Drawing.Size(430, 20)
      Me.TextBox1.TabIndex = 4
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(9, 74)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(51, 13)
      Me.Label2.TabIndex = 5
      Me.Label2.Text = "Location:"
      '
      'tbxAddress
      '
      Me.tbxAddress.Location = New System.Drawing.Point(69, 71)
      Me.tbxAddress.Name = "tbxAddress"
      Me.tbxAddress.ReadOnly = True
      Me.tbxAddress.Size = New System.Drawing.Size(430, 20)
      Me.tbxAddress.TabIndex = 6
      '
      'frmCourseCatalog
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(540, 207)
      Me.Controls.Add(Me.GroupBox1)
      Me.Controls.Add(Me.gbxStep02)
      Me.Controls.Add(Me.gbxStep01)
      Me.Controls.Add(Me.mnuMain)
      Me.MainMenuStrip = Me.mnuMain
      Me.MaximizeBox = False
      Me.Name = "frmCourseCatalog"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Course Catalog"
      CType(Me.CourseDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TbCompleteOfferListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      Me.mnuMain.ResumeLayout(False)
      Me.mnuMain.PerformLayout()
      Me.gbxStep01.ResumeLayout(False)
      Me.gbxStep02.ResumeLayout(False)
      CType(Me.TbCurrentOfferListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      Me.GroupBox1.ResumeLayout(False)
      Me.GroupBox1.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents CourseDBDataSet As CourseDBDataSet
   Friend WithEvents TbCompleteOfferListBindingSource As BindingSource
   Friend WithEvents TbCompleteOfferListTableAdapter As CourseDBDataSetTableAdapters.tbCompleteOfferListTableAdapter
   Friend WithEvents TableAdapterManager As CourseDBDataSetTableAdapters.TableAdapterManager
   Friend WithEvents mnuMain As MenuStrip
   Friend WithEvents cbxCourseSelection As ComboBox
   Friend WithEvents gbxStep01 As GroupBox
   Friend WithEvents gbxStep02 As GroupBox
   Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
   Friend WithEvents btnReloadCatalog As ToolStripMenuItem
   Friend WithEvents TbCurrentOfferListBindingSource As BindingSource
   Friend WithEvents TbCurrentOfferListTableAdapter As CourseDBDataSetTableAdapters.tbCurrentOfferListTableAdapter
   Friend WithEvents cbxOfferSelection As ComboBox
   Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
   Friend WithEvents GroupBox1 As GroupBox
   Friend WithEvents tbxAddress As TextBox
   Friend WithEvents Label2 As Label
   Friend WithEvents tbxLink As LinkLabel
   Friend WithEvents tbxCourseName As TextBox
   Friend WithEvents lblLink As Label
   Friend WithEvents Label1 As Label
   Friend WithEvents TextBox1 As TextBox
End Class
