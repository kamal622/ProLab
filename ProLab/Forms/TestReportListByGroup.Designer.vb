<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestReportListByGroup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TestReportListByGroup))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.gbPatientBillSearch = New System.Windows.Forms.GroupBox()
        Me.dtToDate = New System.Windows.Forms.DateTimePicker()
        Me.dtFromDate = New System.Windows.Forms.DateTimePicker()
        Me.btnSearchTestList = New System.Windows.Forms.Button()
        Me.lblToDate = New System.Windows.Forms.Label()
        Me.lblFromDate = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gbPatientBillSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.gbPatientBillSearch, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ReportViewer1, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.31967!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.68033!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(649, 546)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'gbPatientBillSearch
        '
        Me.gbPatientBillSearch.BackColor = System.Drawing.Color.Transparent
        Me.gbPatientBillSearch.Controls.Add(Me.dtToDate)
        Me.gbPatientBillSearch.Controls.Add(Me.dtFromDate)
        Me.gbPatientBillSearch.Controls.Add(Me.btnSearchTestList)
        Me.gbPatientBillSearch.Controls.Add(Me.lblToDate)
        Me.gbPatientBillSearch.Controls.Add(Me.lblFromDate)
        Me.gbPatientBillSearch.Location = New System.Drawing.Point(3, 3)
        Me.gbPatientBillSearch.Name = "gbPatientBillSearch"
        Me.gbPatientBillSearch.Size = New System.Drawing.Size(643, 56)
        Me.gbPatientBillSearch.TabIndex = 7
        Me.gbPatientBillSearch.TabStop = False
        Me.gbPatientBillSearch.Text = "Search"
        '
        'dtToDate
        '
        Me.dtToDate.CustomFormat = "dd-MM-yyyy"
        Me.dtToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtToDate.Location = New System.Drawing.Point(285, 20)
        Me.dtToDate.MinDate = New Date(2018, 1, 1, 0, 0, 0, 0)
        Me.dtToDate.Name = "dtToDate"
        Me.dtToDate.Size = New System.Drawing.Size(128, 20)
        Me.dtToDate.TabIndex = 7
        '
        'dtFromDate
        '
        Me.dtFromDate.CustomFormat = "dd-MM-yyyy"
        Me.dtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFromDate.Location = New System.Drawing.Point(81, 20)
        Me.dtFromDate.MinDate = New Date(2018, 1, 1, 0, 0, 0, 0)
        Me.dtFromDate.Name = "dtFromDate"
        Me.dtFromDate.Size = New System.Drawing.Size(126, 20)
        Me.dtFromDate.TabIndex = 6
        '
        'btnSearchTestList
        '
        Me.btnSearchTestList.BackgroundImage = Global.ProLab.My.Resources.Resources.F2_Button
        Me.btnSearchTestList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchTestList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchTestList.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSearchTestList.Location = New System.Drawing.Point(449, 20)
        Me.btnSearchTestList.Name = "btnSearchTestList"
        Me.btnSearchTestList.Size = New System.Drawing.Size(72, 20)
        Me.btnSearchTestList.TabIndex = 5
        Me.btnSearchTestList.Text = "Search"
        Me.btnSearchTestList.UseVisualStyleBackColor = True
        '
        'lblToDate
        '
        Me.lblToDate.AutoSize = True
        Me.lblToDate.Location = New System.Drawing.Point(230, 25)
        Me.lblToDate.Name = "lblToDate"
        Me.lblToDate.Size = New System.Drawing.Size(43, 13)
        Me.lblToDate.TabIndex = 3
        Me.lblToDate.Text = "ToDate"
        '
        'lblFromDate
        '
        Me.lblFromDate.AutoSize = True
        Me.lblFromDate.Location = New System.Drawing.Point(15, 25)
        Me.lblFromDate.Name = "lblFromDate"
        Me.lblFromDate.Size = New System.Drawing.Size(56, 13)
        Me.lblFromDate.TabIndex = 0
        Me.lblFromDate.Text = "From Date"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ProLab.ReportListByGroup.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 75)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(643, 468)
        Me.ReportViewer1.TabIndex = 8
        '
        'TestReportListByGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProLab.My.Resources.Resources.LeftGradiant
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(679, 570)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TestReportListByGroup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TestReportListByGroup"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.gbPatientBillSearch.ResumeLayout(False)
        Me.gbPatientBillSearch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents gbPatientBillSearch As GroupBox
    Friend WithEvents dtToDate As DateTimePicker
    Friend WithEvents dtFromDate As DateTimePicker
    Friend WithEvents btnSearchTestList As Button
    Friend WithEvents lblToDate As Label
    Friend WithEvents lblFromDate As Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
