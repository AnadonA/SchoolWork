<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
      Me.MNU_MAIN = New System.Windows.Forms.MenuStrip()
      Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.TabControl1 = New System.Windows.Forms.TabControl()
      Me.TabPage1 = New System.Windows.Forms.TabPage()
      Me.TabPage2 = New System.Windows.Forms.TabPage()
      Me.TBX_MAZE = New System.Windows.Forms.TextBox()
      Me.MNU_MAIN.SuspendLayout()
      Me.TabControl1.SuspendLayout()
      Me.TabPage2.SuspendLayout()
      Me.SuspendLayout()
      '
      'MNU_MAIN
      '
      Me.MNU_MAIN.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
      Me.MNU_MAIN.Location = New System.Drawing.Point(0, 0)
      Me.MNU_MAIN.Name = "MNU_MAIN"
      Me.MNU_MAIN.Size = New System.Drawing.Size(1010, 24)
      Me.MNU_MAIN.TabIndex = 0
      Me.MNU_MAIN.Text = "MenuStrip1"
      '
      'FileToolStripMenuItem
      '
      Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
      Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
      Me.FileToolStripMenuItem.Text = "&File"
      '
      'TabControl1
      '
      Me.TabControl1.Controls.Add(Me.TabPage1)
      Me.TabControl1.Controls.Add(Me.TabPage2)
      Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.TabControl1.Location = New System.Drawing.Point(0, 24)
      Me.TabControl1.Name = "TabControl1"
      Me.TabControl1.SelectedIndex = 0
      Me.TabControl1.Size = New System.Drawing.Size(1010, 799)
      Me.TabControl1.TabIndex = 1
      '
      'TabPage1
      '
      Me.TabPage1.Location = New System.Drawing.Point(4, 22)
      Me.TabPage1.Name = "TabPage1"
      Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
      Me.TabPage1.Size = New System.Drawing.Size(1002, 773)
      Me.TabPage1.TabIndex = 0
      Me.TabPage1.Text = "TabPage1"
      Me.TabPage1.UseVisualStyleBackColor = True
      '
      'TabPage2
      '
      Me.TabPage2.Controls.Add(Me.TBX_MAZE)
      Me.TabPage2.Location = New System.Drawing.Point(4, 22)
      Me.TabPage2.Name = "TabPage2"
      Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
      Me.TabPage2.Size = New System.Drawing.Size(1002, 773)
      Me.TabPage2.TabIndex = 1
      Me.TabPage2.Text = "TabPage2"
      Me.TabPage2.UseVisualStyleBackColor = True
      '
      'TBX_MAZE
      '
      Me.TBX_MAZE.Dock = System.Windows.Forms.DockStyle.Fill
      Me.TBX_MAZE.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.TBX_MAZE.Location = New System.Drawing.Point(3, 3)
      Me.TBX_MAZE.Multiline = True
      Me.TBX_MAZE.Name = "TBX_MAZE"
      Me.TBX_MAZE.Size = New System.Drawing.Size(996, 767)
      Me.TBX_MAZE.TabIndex = 1
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(1010, 823)
      Me.Controls.Add(Me.TabControl1)
      Me.Controls.Add(Me.MNU_MAIN)
      Me.MainMenuStrip = Me.MNU_MAIN
      Me.Name = "Form1"
      Me.Text = "Form1"
      Me.MNU_MAIN.ResumeLayout(False)
      Me.MNU_MAIN.PerformLayout()
      Me.TabControl1.ResumeLayout(False)
      Me.TabPage2.ResumeLayout(False)
      Me.TabPage2.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents MNU_MAIN As MenuStrip
   Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
   Friend WithEvents TabControl1 As TabControl
   Friend WithEvents TabPage1 As TabPage
   Friend WithEvents TabPage2 As TabPage
   Friend WithEvents TBX_MAZE As TextBox
End Class
