Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class ManagedSelectList

    Private _Table As String = ""
    Private _IdentifierField As String = ""
    Private _SearchField As String = ""
    Private _DataConn As New DataHandler.db
    Private _Value As String
    Private _BaseWidth As Integer = 0
    Private _DroppedDown As Boolean = False

    Private pageSize As Integer = 20
    Private dstSearch As DataSet

    Private da As SqlDataAdapter
    Private dtSource As DataTable
    Private PageCount As Integer = 0
    Private maxRec As Integer = 0
    Private currentPage As Integer = 1
    Private recNo As Integer = 0
    Private MaxColumnWidth As Integer = 200
    Private SuspendActions As Boolean = False

    Public Property Table() As String
        Get
            Return _Table
        End Get
        Set(ByVal Value As String)
            _Table = Value
        End Set
    End Property

    Public Property IdentifierField() As String
        Get
            Return _IdentifierField
        End Get
        Set(ByVal Value As String)
            _IdentifierField = Value
        End Set
    End Property

    Public Property SearchField() As String
        Get
            Return _SearchField
        End Get
        Set(ByVal Value As String)
            _SearchField = Value
        End Set
    End Property

    Public Property DataConn() As DataHandler.db
        Get
            Return _DataConn
        End Get
        Set(ByVal Value As DataHandler.db)
            _DataConn = Value
        End Set
    End Property

    Public Property Value() As String
        Get
            Return _Value
        End Get
        Set(ByVal Value As String)
            _Value = Value
        End Set
    End Property

    Public Overrides Property Text() As String
        Get
            Return txtSearch.Text
        End Get
        Set(ByVal Value As String)
            txtSearch.Text = Value
        End Set
    End Property

    Public Overrides Property BackColor() As Color
        Get
            Return txtSearch.BackColor
        End Get
        Set(ByVal Value As Color)
            Resetcolors(Me)
            txtSearch.BackColor = Value
        End Set
    End Property

    Public Property BaseWidth() As Integer
        Get
            Return _BaseWidth
        End Get
        Set(ByVal Value As Integer)
            _BaseWidth = Value
        End Set
    End Property

    Public Property DroppedDown() As Boolean
        Get
            Return _DroppedDown
        End Get
        Set(ByVal Value As Boolean)
            _DroppedDown = Value
        End Set
    End Property

    Public Event ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Public Shadows Event TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    Private Sub ManagedSelectList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'SetDefaults()
        If DroppedDown = True Then DropDown(3, False)
    End Sub

    Friend Sub SetDefaults()
        DataConn.LoginMethod = "WINDOWS"
        DataConn.LoginName = "User"
        DataConn.Password = "Password"
        DataConn.DataLocation = Environment.MachineName & "\SQLEXPRESS"
        DataConn.DatabaseName = "SelectList"
        'DataConn.DatabaseName = "sequenchel_all"
        DataConn.DataProvider = "SQL"
        'Table = "tbl_Servers"
        'IdentifierField = "ServerID"
        'SearchField = "datasource"
    End Sub

    Private Sub Resetcolors(BaseControl As Control)
        'BaseControl.BackColor = SystemColors.Control
        If BaseControl.HasChildren = True Then
            For Each ctrl As Control In BaseControl.Controls
                If ctrl.Name.Length > 3 AndAlso ctrl.Name.Substring(0, 3) = "txt" Then
                    ctrl.BackColor = SystemColors.Window
                Else
                    ctrl.BackColor = SystemColors.Control
                End If
                'If ctrl.HasChildren Then Resetcolors(ctrl)
            Next
        End If
    End Sub

    Private Function QueryDb(ByVal strQueryData As String) As DataSet
        DataConn.CheckDB()
        If DataConn.DataBaseOnline = False Then
            lblStatus.Text = "Database not found"
            Return Nothing
        End If
        Dim dtsData As DataSet
        Try
            lblStatus.Text = "Searching..."
            dtsData = DataConn.QueryDatabase(strQueryData, True)
            Return dtsData
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub DataSearch(Optional blnUseSearchText As Boolean = True)
        Dim strSearchQuery As String = ""
        Dim strQuerySelect As String = "SELECT DISTINCT "
        Dim strQueryFrom As String = "FROM "
        Dim strQueryWhere As String = "WHERE "
        Dim strQueryLike As String = "LIKE N'"
        Dim strQueryOrder As String = "ORDER BY "

        If chkLimitResults.Checked = True And IsNumeric(txtTop.Text) = True Then strQuerySelect &= "TOP " & txtTop.Text & " "
        If IdentifierField.Length > 0 Then strQuerySelect &= "[" & IdentifierField.Replace(".", "].[") & "],"
        strQuerySelect &= "COALESCE([" & SearchField.Replace(".", "].[") & "],'') AS [" & SearchField.Substring(SearchField.LastIndexOf(".") + 1, SearchField.Length - (SearchField.LastIndexOf(".") + 1)) & "] "
        strQueryFrom &= "[" & Table.Replace(".", "].[") & "] "
        strQueryWhere &= " [" & SearchField.Replace(".", "].[") & "] "
        If tbrSearchMethod.Value = 1 Or tbrSearchMethod.Value = 2 Then strQueryLike &= "%"
        strQueryLike &= txtSearch.Text
        If tbrSearchMethod.Value = 0 Or tbrSearchMethod.Value = 1 Then strQueryLike &= "%"
        strQueryLike &= "' "
        strQueryOrder &= "[" & SearchField.Substring(SearchField.LastIndexOf(".") + 1, SearchField.Length - (SearchField.LastIndexOf(".") + 1)) & "] "

        strSearchQuery = strQuerySelect & strQueryFrom
        If txtSearch.Text.Length > 0 And blnUseSearchText = True Then strSearchQuery &= strQueryWhere & strQueryLike
        strSearchQuery &= strQueryOrder
        If strSearchQuery.Contains("[]") Then
            dstSearch = Nothing
        Else
            dstSearch = QueryDb(strSearchQuery)
        End If
    End Sub

    Private Sub DataFilter()

    End Sub

    Private Sub FillDataSet2()
        'Open Connection.
        Dim conn As SqlConnection = New SqlConnection("Server=(local)\sqlexpress;uid=sa;pwd=F@ccess99;database=sequenchel_all")

        'Set the DataAdapter's query.
        da = New SqlDataAdapter("select datasource from tbl_Servers", conn)
        dstSearch = New DataSet()

        ' Fill the DataSet.
        da.Fill(dstSearch, "Servers")

        ' Set the source table.
        dtSource = dstSearch.Tables("Servers")
    End Sub

    Private Sub LoadData()
        'Set the start and max records. 
        If IsNumeric(txtPageSize.Text) = False Then txtPageSize.Text = 20
        If txtPageSize.Text < 5 Then txtPageSize.Text = 20

        pageSize = txtPageSize.Text
        maxRec = dtSource.Rows.Count
        PageCount = maxRec \ pageSize

        ' Adjust the page number if the last page contains a partial page.
        If (maxRec Mod pageSize) > 0 Then
            PageCount = PageCount + 1
        End If

        'Initial seeings
        currentPage = 1
        recNo = 0

        ' Display the content of the current page.
        lblStatus.Text = "Data prepared"

        LoadPage()
    End Sub

    Private Sub btnFirstPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirstPage.Click
        If CheckPage() = False Then Return
        ' Check if you are already at the first page.
        If currentPage = 1 Then
            Return
        End If

        currentPage = 1
        recNo = 0

        LoadPage()
    End Sub

    Private Sub btnPreviousPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreviousPage.Click
        If CheckPage() = False Then Return
        If currentPage = PageCount Then
            recNo = pageSize * (currentPage - 2)
        End If

        currentPage = currentPage - 1

        'Check if you are already at the first page.
        If currentPage < 1 Then
            currentPage = 1
            Return
        Else
            recNo = pageSize * (currentPage - 1)
        End If

        LoadPage()
    End Sub

    Private Sub btnNextPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextPage.Click
        If CheckPage() = False Then Return

        currentPage = currentPage + 1

        If currentPage > PageCount Then
            currentPage = PageCount
            If recNo = maxRec Then
                Return
            End If
        End If

        LoadPage()
    End Sub

    Private Sub btnLastPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLastPage.Click
        If CheckPage() = False Then Return
        ' Check if you are already at the last page.
        If recNo = maxRec Then
            Return
        End If

        currentPage = PageCount
        recNo = pageSize * (currentPage - 1)
        LoadPage()
    End Sub

    Private Function CheckPage() As Boolean
        If maxRec = 0 Then Return False
        If PageCount = 0 Then Return False
        If pageSize < 1 Then Return False
        Return True
    End Function

    Private Sub LoadPage()
        Dim i As Integer
        Dim startRec As Integer
        Dim endRec As Integer
        Dim dtTemp As DataTable
        'Dim dr As DataRow

        'Duplicate or clone the source table to create the temporary table.
        dtTemp = dtSource.Clone

        If currentPage = PageCount Then
            endRec = maxRec
        Else
            endRec = pageSize * currentPage
        End If

        startRec = recNo

        'Copy the rows from the source table to fill the temporary table.
        If dtSource.Rows.Count > 0 Then
            For i = startRec To endRec - 1
                dtTemp.ImportRow(dtSource.Rows(i))
                recNo = recNo + 1
            Next
        End If

        dgvSearchResults.DataSource = dtTemp
        lblStatus.Text = "Page Loaded"

        DisplayPageInfo()
    End Sub

    Private Sub DisplayPageInfo()
        txtDisplayPageNo.Text = currentPage.ToString & " / " & PageCount.ToString
    End Sub

    'Private Sub btnFillGrid_Click(ByVal sender As System.Object, _
    '    ByVal e As System.EventArgs)

    '    'Set the start and max records. 
    '    pageSize = txtPageSize.Text
    '    maxRec = dtSource.Rows.Count
    '    PageCount = maxRec \ pageSize

    '    ' Adjust the page number if the last page contains a partial page.
    '    If (maxRec Mod pageSize) > 0 Then
    '        PageCount = PageCount + 1
    '    End If

    '    'Initial seeings
    '    currentPage = 1
    '    recNo = 0

    '    ' Display the content of the current page.
    '    LoadPage()

    'End Sub

    'Private Function CheckFillButton() As Boolean

    '    'Check if the user clicks the "Fill Grid" button.
    '    If pageSize = 0 Then
    '        MessageBox.Show("Set the Page Size, and then click the ""Fill Grid"" button!")
    '        CheckFillButton = False
    '    Else
    '        CheckFillButton = True
    '    End If
    'End Function

    'Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
    '    MessageBox.Show(_DataConn.DataConnectionString.ToString & Environment.NewLine & _
    '                    _DataConn.DatabaseName & Environment.NewLine & _
    '                    _Table & Environment.NewLine & _
    '                    _SearchField & Environment.NewLine & _
    '                    _IdentifierField)
    'End Sub

    Public Sub RunSearch(Optional blnUseSearchText As Boolean = True)
        DataSearch(blnUseSearchText)
        lblStatus.Text = "Dataset Received"
        If dstSearch Is Nothing Then Exit Sub
        lblStatus.Text = "Dataset OK"
        If dstSearch.Tables.Count = 0 Then Exit Sub
        lblStatus.Text = "Data OK"
        'If dstSearch.Tables(0).Rows.Count = 0 Then Exit Sub
        dtSource = dstSearch.Tables(0)
        lblStatus.Text = "Datasource Set"
        LoadData()
        DataGridViewColumnSize(dgvSearchResults)
    End Sub

    Private Sub btnDropDown_Click(sender As Object, e As EventArgs) Handles btnDropDown.Click
        DropDown(0, True)
    End Sub

    Public Sub DropDown(Optional ForceDropDown As Integer = 0, Optional UseSearchText As Boolean = True)
        If (DroppedDown = False And (ForceDropDown = 0 Or ForceDropDown = 1)) Or ForceDropDown = 3 Then
            Me.BaseWidth = Me.Width
            Me.Height = 275
            DroppedDown = True
            If Me.Width < 225 Then Me.Width = 225
            If Me.Width + Me.Left > Me.Parent.Width - 25 Then Me.Width = Me.Parent.Width - Me.Left - 25
            btnDropDown.Image = My.Resources.Resources.button_up
            'If UseSearchText = False Then
            RunSearch(UseSearchText)
            'End If
        ElseIf (DroppedDown = True And (ForceDropDown = 0 Or ForceDropDown = 2)) Or ForceDropDown = -1 Then
            Me.Height = txtSearch.Height
            DroppedDown = False
            If Me.BaseWidth = 0 Then Me.BaseWidth = Me.Width
            Me.Width = Me.BaseWidth
            If Me.Width + Me.Left > Me.Parent.Width - 25 Then Me.Width = Me.Parent.Width - Me.Left - 25
            btnDropDown.Image = My.Resources.Resources.button_down
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        RaiseEvent TextChanged(Me, e)
        Me.Refresh()
        If SuspendActions = False Then
            If tmrSuspendLookup.Enabled = False Then
                tmrSuspendLookup.Enabled = True
                tmrSuspendLookup.Start()
            Else
                tmrSuspendLookup.Stop()
                tmrSuspendLookup.Enabled = False
                tmrSuspendLookup.Enabled = True
                tmrSuspendLookup.Start()
            End If
            If txtSearch.Text.Length > 0 Then DropDown(1)
        End If
    End Sub

    Private Sub tmrSuspendLookup_Tick(sender As Object, e As EventArgs) Handles tmrSuspendLookup.Tick
        tmrSuspendLookup.Stop()
        tmrSuspendLookup.Enabled = False
        RunSearch(True)
    End Sub

    Friend Sub DataGridViewColumnSize(dgvTarget As DataGridView)
        'grd.DataSource = DT

        'set autosize mode
        For Each dgvColumn As DataGridViewTextBoxColumn In dgvTarget.Columns
            dgvColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Next
        'dgvTarget.Columns(dgvTarget.Columns.Count - 1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        'datagrid has calculated it's widths so we can store them
        For i = 0 To dgvTarget.Columns.Count - 1
            'store autosized widths
            Dim colw As Integer = dgvTarget.Columns(i).Width
            If colw > MaxColumnWidth Then colw = MaxColumnWidth
            'remove autosizing
            dgvTarget.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            'set width to calculated by autosize
            dgvTarget.Columns(i).Width = colw
            If i = dgvTarget.Columns.Count - 1 Then
                dgvTarget.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End If
        Next
    End Sub

    Private Sub dgvSearchResults_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearchResults.CellClick
        SuspendActions = True
        Me.Value = dgvSearchResults.SelectedCells(0).OwningRow.Cells(0).Value.ToString
        txtSearch.Text = dgvSearchResults.SelectedCells(0).OwningRow.Cells(dgvSearchResults.SelectedCells(0).OwningRow.Cells.Count - 1).Value.ToString
        DropDown(False)
        RaiseEvent ValueChanged(Me, e)
        SuspendActions = False
    End Sub

    'Private Sub dgvSearchResults_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearchResults.CellContentClick
    '    SuspendActions = True
    '    Value = dgvSearchResults.SelectedCells(0).OwningRow.Cells(0).Value.ToString
    '    txtSearch.Text = dgvSearchResults.SelectedCells(0).OwningRow.Cells(dgvSearchResults.SelectedCells(0).OwningRow.Cells.Count - 1).Value.ToString
    '    DropDown(False)
    '    RaiseEvent ValueChanged(Me, e)
    '    SuspendActions = False
    'End Sub

    'Private Sub dgvSearchResults_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearchResults.CellContentDoubleClick
    '    Value = dgvSearchResults.SelectedCells(0).OwningRow.Cells(0).Value.ToString
    '    txtSearch.Text = dgvSearchResults.SelectedCells(0).OwningRow.Cells(dgvSearchResults.SelectedCells(0).OwningRow.Cells.Count - 1).Value.ToString
    '    tmrSuspendLookup.Stop()
    '    tmrSuspendLookup.Enabled = False
    '    DropDown(False)
    '    RaiseEvent ValueChanged(sender, e)
    'End Sub

    Private Sub tbrSearchMethod_Scroll(sender As Object, e As EventArgs) Handles tbrSearchMethod.Scroll
        RunSearch()
    End Sub

    Private Sub ManagedSelectList_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        DropDown(2)
    End Sub
End Class
