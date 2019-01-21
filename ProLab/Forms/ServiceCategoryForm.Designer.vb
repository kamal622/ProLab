<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ServiceCategoryForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ServiceCategoryForm))
        Me.tblServiceCategoryHeader = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlCategoryHeader = New System.Windows.Forms.Panel()
        Me.lblCategoryMode = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbCategory = New System.Windows.Forms.GroupBox()
        Me.btnFindCategory = New System.Windows.Forms.Button()
        Me.txtFindCategory = New System.Windows.Forms.TextBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.tblServiceCategory = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCategoryName = New System.Windows.Forms.Label()
        Me.txtServiceCategoryName = New System.Windows.Forms.TextBox()
        Me.lblCategoryDesc = New System.Windows.Forms.Label()
        Me.txtServiceDescription = New System.Windows.Forms.TextBox()
        Me.lblCatoryReq = New System.Windows.Forms.Label()
        Me.tabServicecategory = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.pnlServiceCategory = New System.Windows.Forms.Panel()
        Me.btnCategoryClear = New System.Windows.Forms.Button()
        Me.btnCategoryClose = New System.Windows.Forms.Button()
        Me.btnCategoryDelete = New System.Windows.Forms.Button()
        Me.btnCategorySave = New System.Windows.Forms.Button()
        Me.tblServiceCategoryHeader.SuspendLayout()
        Me.pnlCategoryHeader.SuspendLayout()
        Me.gbCategory.SuspendLayout()
        Me.tblServiceCategory.SuspendLayout()
        Me.tabServicecategory.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.pnlServiceCategory.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblServiceCategoryHeader
        '
        Me.tblServiceCategoryHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.tblServiceCategoryHeader.ColumnCount = 1
        Me.tblServiceCategoryHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblServiceCategoryHeader.Controls.Add(Me.pnlCategoryHeader, 0, 0)
        Me.tblServiceCategoryHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblServiceCategoryHeader.Location = New System.Drawing.Point(0, 0)
        Me.tblServiceCategoryHeader.Name = "tblServiceCategoryHeader"
        Me.tblServiceCategoryHeader.RowCount = 1
        Me.tblServiceCategoryHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblServiceCategoryHeader.Size = New System.Drawing.Size(417, 40)
        Me.tblServiceCategoryHeader.TabIndex = 0
        '
        'pnlCategoryHeader
        '
        Me.pnlCategoryHeader.Controls.Add(Me.lblCategoryMode)
        Me.pnlCategoryHeader.Controls.Add(Me.Label1)
        Me.pnlCategoryHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCategoryHeader.Location = New System.Drawing.Point(3, 3)
        Me.pnlCategoryHeader.Name = "pnlCategoryHeader"
        Me.pnlCategoryHeader.Size = New System.Drawing.Size(411, 34)
        Me.pnlCategoryHeader.TabIndex = 0
        '
        'lblCategoryMode
        '
        Me.lblCategoryMode.AutoSize = True
        Me.lblCategoryMode.BackColor = System.Drawing.Color.Maroon
        Me.lblCategoryMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCategoryMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoryMode.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblCategoryMode.Location = New System.Drawing.Point(319, 7)
        Me.lblCategoryMode.Name = "lblCategoryMode"
        Me.lblCategoryMode.Size = New System.Drawing.Size(76, 19)
        Me.lblCategoryMode.TabIndex = 1
        Me.lblCategoryMode.Text = "New Mode"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Service Category"
        '
        'gbCategory
        '
        Me.gbCategory.BackColor = System.Drawing.Color.Transparent
        Me.gbCategory.BackgroundImage = Global.ProLab.My.Resources.Resources.LeftGradiant
        Me.gbCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gbCategory.Controls.Add(Me.btnFindCategory)
        Me.gbCategory.Controls.Add(Me.txtFindCategory)
        Me.gbCategory.Controls.Add(Me.lblCategory)
        Me.gbCategory.Location = New System.Drawing.Point(15, 60)
        Me.gbCategory.Name = "gbCategory"
        Me.gbCategory.Size = New System.Drawing.Size(387, 57)
        Me.gbCategory.TabIndex = 1
        Me.gbCategory.TabStop = False
        Me.gbCategory.Text = "Search"
        '
        'btnFindCategory
        '
        Me.btnFindCategory.BackgroundImage = Global.ProLab.My.Resources.Resources.F2_Button
        Me.btnFindCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFindCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindCategory.ForeColor = System.Drawing.Color.White
        Me.btnFindCategory.Location = New System.Drawing.Point(342, 22)
        Me.btnFindCategory.Name = "btnFindCategory"
        Me.btnFindCategory.Size = New System.Drawing.Size(30, 20)
        Me.btnFindCategory.TabIndex = 2
        Me.btnFindCategory.Text = "F2"
        Me.btnFindCategory.UseVisualStyleBackColor = True
        '
        'txtFindCategory
        '
        Me.txtFindCategory.Location = New System.Drawing.Point(86, 22)
        Me.txtFindCategory.Name = "txtFindCategory"
        Me.txtFindCategory.Size = New System.Drawing.Size(250, 20)
        Me.txtFindCategory.TabIndex = 1
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(21, 22)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(49, 13)
        Me.lblCategory.TabIndex = 0
        Me.lblCategory.Text = "Category"
        '
        'tblServiceCategory
        '
        Me.tblServiceCategory.ColumnCount = 3
        Me.tblServiceCategory.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblServiceCategory.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.97319!))
        Me.tblServiceCategory.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.18767!))
        Me.tblServiceCategory.Controls.Add(Me.lblCategoryName, 0, 0)
        Me.tblServiceCategory.Controls.Add(Me.txtServiceCategoryName, 1, 0)
        Me.tblServiceCategory.Controls.Add(Me.lblCategoryDesc, 0, 1)
        Me.tblServiceCategory.Controls.Add(Me.txtServiceDescription, 1, 1)
        Me.tblServiceCategory.Controls.Add(Me.lblCatoryReq, 2, 0)
        Me.tblServiceCategory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblServiceCategory.Location = New System.Drawing.Point(3, 3)
        Me.tblServiceCategory.Name = "tblServiceCategory"
        Me.tblServiceCategory.RowCount = 2
        Me.tblServiceCategory.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tblServiceCategory.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tblServiceCategory.Size = New System.Drawing.Size(373, 69)
        Me.tblServiceCategory.TabIndex = 2
        '
        'lblCategoryName
        '
        Me.lblCategoryName.Location = New System.Drawing.Point(5, 5)
        Me.lblCategoryName.Margin = New System.Windows.Forms.Padding(5)
        Me.lblCategoryName.Name = "lblCategoryName"
        Me.lblCategoryName.Size = New System.Drawing.Size(64, 13)
        Me.lblCategoryName.TabIndex = 0
        Me.lblCategoryName.Text = "Category Name"
        '
        'txtServiceCategoryName
        '
        Me.txtServiceCategoryName.Location = New System.Drawing.Point(79, 5)
        Me.txtServiceCategoryName.Margin = New System.Windows.Forms.Padding(5)
        Me.txtServiceCategoryName.Name = "txtServiceCategoryName"
        Me.txtServiceCategoryName.Size = New System.Drawing.Size(250, 20)
        Me.txtServiceCategoryName.TabIndex = 1
        '
        'lblCategoryDesc
        '
        Me.lblCategoryDesc.Location = New System.Drawing.Point(5, 32)
        Me.lblCategoryDesc.Margin = New System.Windows.Forms.Padding(5)
        Me.lblCategoryDesc.Name = "lblCategoryDesc"
        Me.lblCategoryDesc.Size = New System.Drawing.Size(60, 13)
        Me.lblCategoryDesc.TabIndex = 2
        Me.lblCategoryDesc.Text = "Description"
        '
        'txtServiceDescription
        '
        Me.txtServiceDescription.Location = New System.Drawing.Point(79, 32)
        Me.txtServiceDescription.Margin = New System.Windows.Forms.Padding(5)
        Me.txtServiceDescription.Multiline = True
        Me.txtServiceDescription.Name = "txtServiceDescription"
        Me.txtServiceDescription.Size = New System.Drawing.Size(250, 32)
        Me.txtServiceDescription.TabIndex = 3
        '
        'lblCatoryReq
        '
        Me.lblCatoryReq.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCatoryReq.ForeColor = System.Drawing.Color.Red
        Me.lblCatoryReq.Location = New System.Drawing.Point(337, 0)
        Me.lblCatoryReq.Name = "lblCatoryReq"
        Me.lblCatoryReq.Size = New System.Drawing.Size(9, 27)
        Me.lblCatoryReq.TabIndex = 4
        Me.lblCatoryReq.Text = "*"
        Me.lblCatoryReq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabServicecategory
        '
        Me.tabServicecategory.Controls.Add(Me.TabPage1)
        Me.tabServicecategory.Location = New System.Drawing.Point(15, 123)
        Me.tabServicecategory.Name = "tabServicecategory"
        Me.tabServicecategory.SelectedIndex = 0
        Me.tabServicecategory.Size = New System.Drawing.Size(387, 101)
        Me.tabServicecategory.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.tblServiceCategory)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(379, 75)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Service Category"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'pnlServiceCategory
        '
        Me.pnlServiceCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.pnlServiceCategory.Controls.Add(Me.btnCategoryClear)
        Me.pnlServiceCategory.Controls.Add(Me.btnCategoryClose)
        Me.pnlServiceCategory.Controls.Add(Me.btnCategoryDelete)
        Me.pnlServiceCategory.Controls.Add(Me.btnCategorySave)
        Me.pnlServiceCategory.Location = New System.Drawing.Point(171, 230)
        Me.pnlServiceCategory.Name = "pnlServiceCategory"
        Me.pnlServiceCategory.Size = New System.Drawing.Size(231, 35)
        Me.pnlServiceCategory.TabIndex = 5
        '
        'btnCategoryClear
        '
        Me.btnCategoryClear.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnCategoryClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategoryClear.ForeColor = System.Drawing.Color.White
        Me.btnCategoryClear.Location = New System.Drawing.Point(115, 3)
        Me.btnCategoryClear.Name = "btnCategoryClear"
        Me.btnCategoryClear.Size = New System.Drawing.Size(56, 30)
        Me.btnCategoryClear.TabIndex = 6
        Me.btnCategoryClear.Text = "C&lear"
        Me.btnCategoryClear.UseVisualStyleBackColor = True
        '
        'btnCategoryClose
        '
        Me.btnCategoryClose.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnCategoryClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategoryClose.ForeColor = System.Drawing.Color.White
        Me.btnCategoryClose.Location = New System.Drawing.Point(171, 3)
        Me.btnCategoryClose.Name = "btnCategoryClose"
        Me.btnCategoryClose.Size = New System.Drawing.Size(56, 30)
        Me.btnCategoryClose.TabIndex = 6
        Me.btnCategoryClose.Text = "&Close"
        Me.btnCategoryClose.UseVisualStyleBackColor = True
        '
        'btnCategoryDelete
        '
        Me.btnCategoryDelete.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnCategoryDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategoryDelete.ForeColor = System.Drawing.Color.White
        Me.btnCategoryDelete.Location = New System.Drawing.Point(59, 3)
        Me.btnCategoryDelete.Name = "btnCategoryDelete"
        Me.btnCategoryDelete.Size = New System.Drawing.Size(56, 30)
        Me.btnCategoryDelete.TabIndex = 1
        Me.btnCategoryDelete.Text = "&Delete"
        Me.btnCategoryDelete.UseVisualStyleBackColor = True
        '
        'btnCategorySave
        '
        Me.btnCategorySave.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnCategorySave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategorySave.ForeColor = System.Drawing.Color.White
        Me.btnCategorySave.Location = New System.Drawing.Point(3, 3)
        Me.btnCategorySave.Name = "btnCategorySave"
        Me.btnCategorySave.Size = New System.Drawing.Size(56, 30)
        Me.btnCategorySave.TabIndex = 0
        Me.btnCategorySave.Text = "&Save"
        Me.btnCategorySave.UseVisualStyleBackColor = True
        '
        'ServiceCategoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProLab.My.Resources.Resources.LeftGradiant
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(417, 270)
        Me.Controls.Add(Me.pnlServiceCategory)
        Me.Controls.Add(Me.tabServicecategory)
        Me.Controls.Add(Me.gbCategory)
        Me.Controls.Add(Me.tblServiceCategoryHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ServiceCategoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Service Category"
        Me.tblServiceCategoryHeader.ResumeLayout(False)
        Me.pnlCategoryHeader.ResumeLayout(False)
        Me.pnlCategoryHeader.PerformLayout()
        Me.gbCategory.ResumeLayout(False)
        Me.gbCategory.PerformLayout()
        Me.tblServiceCategory.ResumeLayout(False)
        Me.tblServiceCategory.PerformLayout()
        Me.tabServicecategory.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.pnlServiceCategory.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tblServiceCategoryHeader As TableLayoutPanel
    Friend WithEvents pnlCategoryHeader As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCategoryMode As Label
    Friend WithEvents gbCategory As GroupBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents txtFindCategory As TextBox
    Friend WithEvents btnFindCategory As Button
    Friend WithEvents tblServiceCategory As TableLayoutPanel
    Friend WithEvents lblCategoryName As Label
    Friend WithEvents txtServiceCategoryName As TextBox
    Friend WithEvents lblCategoryDesc As Label
    Friend WithEvents txtServiceDescription As TextBox
    Friend WithEvents tabServicecategory As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lblCatoryReq As Label
    Friend WithEvents pnlServiceCategory As Panel
    Friend WithEvents btnCategorySave As Button
    Friend WithEvents btnCategoryClear As Button
    Friend WithEvents btnCategoryClose As Button
    Friend WithEvents btnCategoryDelete As Button
End Class
