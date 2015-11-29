<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagedSelectList
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Me.chkLimitResults = New System.Windows.Forms.CheckBox()
        Me.txtTop = New System.Windows.Forms.TextBox()
        Me.tbrSearchMethod = New System.Windows.Forms.TrackBar()
        Me.btnFirstPage = New System.Windows.Forms.Button()
        Me.btnLastPage = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.txtDisplayPageNo = New System.Windows.Forms.TextBox()
        Me.txtPageSize = New System.Windows.Forms.TextBox()
        Me.dgvSearchResults = New System.Windows.Forms.DataGridView()
        Me.tmrSuspendLookup = New System.Windows.Forms.Timer(Me.components)
        Me.lblResultsPerPage = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblStatusLabel = New System.Windows.Forms.Label()
        Me.rbnFilterSearch = New System.Windows.Forms.RadioButton()
        Me.rbnNewSearch = New System.Windows.Forms.RadioButton()
        Me.btnNextPage = New System.Windows.Forms.Button()
        Me.btnPreviousPage = New System.Windows.Forms.Button()
        Me.btnDropDown = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.pbxSearch = New System.Windows.Forms.PictureBox()
        Me.pbxFilter = New System.Windows.Forms.PictureBox()
        Me.pnlNavigate = New System.Windows.Forms.Panel()
        Me.pnlScrollNavigate = New System.Windows.Forms.Panel()
        Me.pnlToolbar = New System.Windows.Forms.Panel()
        Me.pnlScrollToolbar = New System.Windows.Forms.Panel()
        CType(Me.tbrSearchMethod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSearchResults, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNavigate.SuspendLayout()
        Me.pnlScrollNavigate.SuspendLayout()
        Me.pnlToolbar.SuspendLayout()
        Me.pnlScrollToolbar.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkLimitResults
        '
        Me.chkLimitResults.AutoSize = True
        Me.chkLimitResults.Checked = True
        Me.chkLimitResults.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLimitResults.Location = New System.Drawing.Point(2, 4)
        Me.chkLimitResults.Name = "chkLimitResults"
        Me.chkLimitResults.Size = New System.Drawing.Size(62, 17)
        Me.chkLimitResults.TabIndex = 3
        Me.chkLimitResults.Text = "Limit to:"
        Me.chkLimitResults.UseVisualStyleBackColor = True
        '
        'txtTop
        '
        Me.txtTop.Location = New System.Drawing.Point(59, 1)
        Me.txtTop.Name = "txtTop"
        Me.txtTop.Size = New System.Drawing.Size(34, 20)
        Me.txtTop.TabIndex = 4
        Me.txtTop.Text = "1000"
        '
        'tbrSearchMethod
        '
        Me.tbrSearchMethod.AutoSize = False
        Me.tbrSearchMethod.LargeChange = 1
        Me.tbrSearchMethod.Location = New System.Drawing.Point(163, 1)
        Me.tbrSearchMethod.Maximum = 2
        Me.tbrSearchMethod.Name = "tbrSearchMethod"
        Me.tbrSearchMethod.Size = New System.Drawing.Size(65, 25)
        Me.tbrSearchMethod.TabIndex = 5
        Me.tbrSearchMethod.Value = 1
        '
        'btnFirstPage
        '
        Me.btnFirstPage.Location = New System.Drawing.Point(2, 2)
        Me.btnFirstPage.Name = "btnFirstPage"
        Me.btnFirstPage.Size = New System.Drawing.Size(28, 23)
        Me.btnFirstPage.TabIndex = 6
        Me.btnFirstPage.Text = "<<"
        Me.btnFirstPage.UseVisualStyleBackColor = True
        '
        'btnLastPage
        '
        Me.btnLastPage.Location = New System.Drawing.Point(121, 2)
        Me.btnLastPage.Name = "btnLastPage"
        Me.btnLastPage.Size = New System.Drawing.Size(28, 23)
        Me.btnLastPage.TabIndex = 9
        Me.btnLastPage.Text = ">>"
        Me.btnLastPage.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Location = New System.Drawing.Point(0, 0)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(203, 20)
        Me.txtSearch.TabIndex = 0
        '
        'txtDisplayPageNo
        '
        Me.txtDisplayPageNo.Location = New System.Drawing.Point(55, 4)
        Me.txtDisplayPageNo.Name = "txtDisplayPageNo"
        Me.txtDisplayPageNo.Size = New System.Drawing.Size(41, 20)
        Me.txtDisplayPageNo.TabIndex = 10
        '
        'txtPageSize
        '
        Me.txtPageSize.Location = New System.Drawing.Point(195, 4)
        Me.txtPageSize.Name = "txtPageSize"
        Me.txtPageSize.Size = New System.Drawing.Size(27, 20)
        Me.txtPageSize.TabIndex = 11
        Me.txtPageSize.Text = "20"
        '
        'dgvSearchResults
        '
        Me.dgvSearchResults.AllowUserToAddRows = False
        Me.dgvSearchResults.AllowUserToDeleteRows = False
        Me.dgvSearchResults.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearchResults.Location = New System.Drawing.Point(0, 48)
        Me.dgvSearchResults.MultiSelect = False
        Me.dgvSearchResults.Name = "dgvSearchResults"
        Me.dgvSearchResults.ReadOnly = True
        Me.dgvSearchResults.Size = New System.Drawing.Size(224, 181)
        Me.dgvSearchResults.TabIndex = 13
        '
        'tmrSuspendLookup
        '
        Me.tmrSuspendLookup.Interval = 500
        '
        'lblResultsPerPage
        '
        Me.lblResultsPerPage.AutoSize = True
        Me.lblResultsPerPage.Location = New System.Drawing.Point(164, 7)
        Me.lblResultsPerPage.Name = "lblResultsPerPage"
        Me.lblResultsPerPage.Size = New System.Drawing.Size(30, 13)
        Me.lblResultsPerPage.TabIndex = 14
        Me.lblResultsPerPage.Text = "R/P:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(2, 259)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(40, 13)
        Me.lblStatus.TabIndex = 15
        Me.lblStatus.Text = "Status:"
        '
        'lblStatusLabel
        '
        Me.lblStatusLabel.AutoSize = True
        Me.lblStatusLabel.Location = New System.Drawing.Point(51, 270)
        Me.lblStatusLabel.Name = "lblStatusLabel"
        Me.lblStatusLabel.Size = New System.Drawing.Size(0, 13)
        Me.lblStatusLabel.TabIndex = 16
        '
        'rbnFilterSearch
        '
        Me.rbnFilterSearch.AutoSize = True
        Me.rbnFilterSearch.Enabled = False
        Me.rbnFilterSearch.Location = New System.Drawing.Point(149, 5)
        Me.rbnFilterSearch.Name = "rbnFilterSearch"
        Me.rbnFilterSearch.Size = New System.Drawing.Size(14, 13)
        Me.rbnFilterSearch.TabIndex = 18
        Me.rbnFilterSearch.UseVisualStyleBackColor = True
        '
        'rbnNewSearch
        '
        Me.rbnNewSearch.AutoSize = True
        Me.rbnNewSearch.Checked = True
        Me.rbnNewSearch.Enabled = False
        Me.rbnNewSearch.Location = New System.Drawing.Point(115, 5)
        Me.rbnNewSearch.Name = "rbnNewSearch"
        Me.rbnNewSearch.Size = New System.Drawing.Size(14, 13)
        Me.rbnNewSearch.TabIndex = 17
        Me.rbnNewSearch.TabStop = True
        Me.rbnNewSearch.UseVisualStyleBackColor = True
        '
        'btnNextPage
        '
        Me.btnNextPage.Image = Global.ManagedSelectList.My.Resources.Resources.button_right
        Me.btnNextPage.Location = New System.Drawing.Point(97, 2)
        Me.btnNextPage.Name = "btnNextPage"
        Me.btnNextPage.Size = New System.Drawing.Size(24, 23)
        Me.btnNextPage.TabIndex = 8
        Me.btnNextPage.UseVisualStyleBackColor = True
        '
        'btnPreviousPage
        '
        Me.btnPreviousPage.Image = Global.ManagedSelectList.My.Resources.Resources.button_left
        Me.btnPreviousPage.Location = New System.Drawing.Point(30, 2)
        Me.btnPreviousPage.Name = "btnPreviousPage"
        Me.btnPreviousPage.Size = New System.Drawing.Size(24, 23)
        Me.btnPreviousPage.TabIndex = 7
        Me.btnPreviousPage.UseVisualStyleBackColor = True
        '
        'btnDropDown
        '
        Me.btnDropDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDropDown.Image = Global.ManagedSelectList.My.Resources.Resources.button_down
        Me.btnDropDown.Location = New System.Drawing.Point(204, 0)
        Me.btnDropDown.Name = "btnDropDown"
        Me.btnDropDown.Size = New System.Drawing.Size(20, 20)
        Me.btnDropDown.TabIndex = 2
        Me.btnDropDown.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Image = Global.ManagedSelectList.My.Resources.Resources.Zoom_icon
        Me.btnSearch.Location = New System.Drawing.Point(199, 252)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 23)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.UseVisualStyleBackColor = True
        Me.btnSearch.Visible = False
        '
        'pbxSearch
        '
        Me.pbxSearch.Enabled = False
        Me.pbxSearch.Image = Global.ManagedSelectList.My.Resources.Resources.Zoom_icon
        Me.pbxSearch.Location = New System.Drawing.Point(97, 3)
        Me.pbxSearch.Name = "pbxSearch"
        Me.pbxSearch.Size = New System.Drawing.Size(18, 18)
        Me.pbxSearch.TabIndex = 19
        Me.pbxSearch.TabStop = False
        '
        'pbxFilter
        '
        Me.pbxFilter.Enabled = False
        Me.pbxFilter.Image = Global.ManagedSelectList.My.Resources.Resources.Funnel_icon
        Me.pbxFilter.Location = New System.Drawing.Point(133, 3)
        Me.pbxFilter.Name = "pbxFilter"
        Me.pbxFilter.Size = New System.Drawing.Size(18, 18)
        Me.pbxFilter.TabIndex = 20
        Me.pbxFilter.TabStop = False
        '
        'pnlNavigate
        '
        Me.pnlNavigate.Controls.Add(Me.btnFirstPage)
        Me.pnlNavigate.Controls.Add(Me.lblResultsPerPage)
        Me.pnlNavigate.Controls.Add(Me.btnPreviousPage)
        Me.pnlNavigate.Controls.Add(Me.btnNextPage)
        Me.pnlNavigate.Controls.Add(Me.btnLastPage)
        Me.pnlNavigate.Controls.Add(Me.txtDisplayPageNo)
        Me.pnlNavigate.Controls.Add(Me.txtPageSize)
        Me.pnlNavigate.Location = New System.Drawing.Point(0, 0)
        Me.pnlNavigate.Name = "pnlNavigate"
        Me.pnlNavigate.Size = New System.Drawing.Size(225, 25)
        Me.pnlNavigate.TabIndex = 21
        '
        'pnlScrollNavigate
        '
        Me.pnlScrollNavigate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlScrollNavigate.AutoScroll = True
        Me.pnlScrollNavigate.BackColor = System.Drawing.Color.Transparent
        Me.pnlScrollNavigate.Controls.Add(Me.pnlNavigate)
        Me.pnlScrollNavigate.Location = New System.Drawing.Point(0, 230)
        Me.pnlScrollNavigate.Name = "pnlScrollNavigate"
        Me.pnlScrollNavigate.Size = New System.Drawing.Size(225, 45)
        Me.pnlScrollNavigate.TabIndex = 22
        '
        'pnlToolbar
        '
        Me.pnlToolbar.Controls.Add(Me.txtTop)
        Me.pnlToolbar.Controls.Add(Me.chkLimitResults)
        Me.pnlToolbar.Controls.Add(Me.rbnFilterSearch)
        Me.pnlToolbar.Controls.Add(Me.tbrSearchMethod)
        Me.pnlToolbar.Controls.Add(Me.pbxFilter)
        Me.pnlToolbar.Controls.Add(Me.rbnNewSearch)
        Me.pnlToolbar.Controls.Add(Me.pbxSearch)
        Me.pnlToolbar.Location = New System.Drawing.Point(0, 0)
        Me.pnlToolbar.Name = "pnlToolbar"
        Me.pnlToolbar.Size = New System.Drawing.Size(225, 30)
        Me.pnlToolbar.TabIndex = 23
        '
        'pnlScrollToolbar
        '
        Me.pnlScrollToolbar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlScrollToolbar.AutoScroll = True
        Me.pnlScrollToolbar.Controls.Add(Me.pnlToolbar)
        Me.pnlScrollToolbar.Location = New System.Drawing.Point(0, 21)
        Me.pnlScrollToolbar.Name = "pnlScrollToolbar"
        Me.pnlScrollToolbar.Size = New System.Drawing.Size(225, 35)
        Me.pnlScrollToolbar.TabIndex = 24
        '
        'ManagedSelectList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvSearchResults)
        Me.Controls.Add(Me.pnlScrollToolbar)
        Me.Controls.Add(Me.lblStatusLabel)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnDropDown)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.pnlScrollNavigate)
        Me.Name = "ManagedSelectList"
        Me.Size = New System.Drawing.Size(225, 20)
        CType(Me.tbrSearchMethod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSearchResults, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxFilter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNavigate.ResumeLayout(False)
        Me.pnlNavigate.PerformLayout()
        Me.pnlScrollNavigate.ResumeLayout(False)
        Me.pnlToolbar.ResumeLayout(False)
        Me.pnlToolbar.PerformLayout()
        Me.pnlScrollToolbar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnDropDown As System.Windows.Forms.Button
    Friend WithEvents chkLimitResults As System.Windows.Forms.CheckBox
    Friend WithEvents txtTop As System.Windows.Forms.TextBox
    Friend WithEvents tbrSearchMethod As System.Windows.Forms.TrackBar
    Friend WithEvents btnFirstPage As System.Windows.Forms.Button
    Friend WithEvents btnPreviousPage As System.Windows.Forms.Button
    Friend WithEvents btnNextPage As System.Windows.Forms.Button
    Friend WithEvents btnLastPage As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents txtDisplayPageNo As System.Windows.Forms.TextBox
    Friend WithEvents txtPageSize As System.Windows.Forms.TextBox
    Friend WithEvents dgvSearchResults As System.Windows.Forms.DataGridView
    Friend WithEvents tmrSuspendLookup As System.Windows.Forms.Timer
    Friend WithEvents lblResultsPerPage As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblStatusLabel As System.Windows.Forms.Label
    Friend WithEvents rbnNewSearch As System.Windows.Forms.RadioButton
    Friend WithEvents rbnFilterSearch As System.Windows.Forms.RadioButton
    Friend WithEvents pbxSearch As System.Windows.Forms.PictureBox
    Friend WithEvents pbxFilter As System.Windows.Forms.PictureBox
    Friend WithEvents pnlNavigate As System.Windows.Forms.Panel
    Friend WithEvents pnlScrollNavigate As System.Windows.Forms.Panel
    Friend WithEvents pnlToolbar As System.Windows.Forms.Panel
    Friend WithEvents pnlScrollToolbar As System.Windows.Forms.Panel

End Class
