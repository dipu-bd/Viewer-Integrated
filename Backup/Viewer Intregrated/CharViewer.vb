Imports System.Xml
Public Class CharViewer

#Region "User Method"
    Property EditMode() As Boolean
        Get
            Return Not CharName.ReadOnly
        End Get
        Set(ByVal value As Boolean)
            If Not value Then
                CharName.Location = New Point(105, 10)
                CharName.BorderStyle = Windows.Forms.BorderStyle.None
                CharName.ReadOnly = True
            Else
                CharName.Location = New Point(103, 8)
                CharName.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
                CharName.ReadOnly = False
            End If
        End Set
    End Property

    Sub addRange(ByVal range() As String)
        Dim start, _end As Integer
        start = CInt(range(0)) : _end = CInt(range(1))
        If start > _end Then
            Dim p As Integer = _end
            _end = start
            start = p
        End If
        ListBox1.Items.Clear()
        For i = start To _end
            ListBox1.Items.Add(ChrW(i))
        Next
        ListBox1.SelectedIndex = 0
    End Sub

    Function GetHex(ByVal code As Integer) As String
        Dim p As String = Hex(code)
        Do While p.Length < 4
            p = "0" & p
        Loop
        Return "U+" & p
    End Function
#End Region

    Dim data() As String
    Private Sub CharViewer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'load settings
        SplitContainer1.SplitterDistance = My.Settings.chviewSp1Ln
        SplitContainer2.Panel1Collapsed = My.Settings.chviewPanel1Collasped
        SplitContainer2.Panel2Collapsed = My.Settings.chviewPanel2Collasped
        ListView1.Columns(0).Width = My.Settings.chviewColsize.X
        ListView1.Columns(1).Width = My.Settings.chviewColsize.Y
        ListView1.Columns(0).DisplayIndex = My.Settings.chviewCol1indx
        For Each i In My.Settings.chviewSearchStr
            If i.Trim = "" Then Continue For
            SearchBox.Items.Add(i)
        Next
        'check file
        If Not My.Computer.FileSystem.DirectoryExists("Data") Then My.Computer.FileSystem.CreateDirectory("Data")
        Dim file As String = "Data\CharNames.txt"
        If Not My.Computer.FileSystem.FileExists(file) Then
            Dim txt As String = ""
            For i = 0 To 65535
                txt &= vbCrLf
            Next
            My.Computer.FileSystem.WriteAllText(file, txt, False)
            data = Split(txt, vbCrLf)
        Else
            data = Split(My.Computer.FileSystem.ReadAllText(file), vbCrLf)
        End If
        'load unicode items
        For Each itms In Split(My.Computer.FileSystem.ReadAllText("Data\CharRange.txt"), vbCrLf)
            Dim itm() As String = Split(itms, ";")
            ListView1.Items.Add(New ListViewItem(New String() {itm(0).Trim, itm(1).Trim}))
        Next
        ListView1.Items(1).Selected = True
    End Sub

    Private Sub ListView1_ColumnReordered(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnReorderedEventArgs) Handles ListView1.ColumnReordered
        My.Settings.chviewCol1indx = ListView1.Columns(0).DisplayIndex
    End Sub

    Private Sub ListView1_ColumnWidthChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnWidthChangedEventArgs) Handles ListView1.ColumnWidthChanged
        My.Settings.chviewColsize = New Point(ListView1.Columns(0).Width, ListView1.Columns(1).Width)
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count = 0 Then Exit Sub
        Dim itm As ListViewItem = ListView1.SelectedItems(0)
        RangeName.Text = itm.Text
        Dim range() As String = Split(itm.SubItems(1).Text, "to")
        addRange(range)
        startCode.Text = range(0)
        EndCode.Text = range(1)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        MaxView.Text = ListBox1.SelectedItem
    End Sub

    Private Sub MaxView_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaxView.TextChanged
        Try
            Dim code As Integer = AscW(MaxView.Text)
            CharName.Text = data(code)
            DeciCode.Text = code
            HexCode.Text = GetHex(code)
        Catch : End Try
        If CharName.Text = "" Then
            CharName.Text = "[add name]"
            CharName.ForeColor = Color.Gray
        Else
            CharName.ForeColor = Color.Firebrick
        End If
    End Sub

    ''' <summary>
    ''' Search code. Search Listview, Show range and show character.
    ''' </summary>
#Region "Search Function"

    Enum ViewType
        ViewCode
        ViewChar
        NamedChars
        NamedCharRange
        UserDefinedRange
    End Enum

    Sub ViewChar(ByVal ch As String)
        MaxView.Text = ch
    End Sub

    Sub ViewCode(ByVal code As Integer)
        If code > -1 And code < 65536 Then MaxView.Text = ChrW(code)
    End Sub

    Sub NamedChars(ByVal srcTxt As String)
        ListBox1.Items.Clear()
        For i = 0 To data.Length - 1
            If data(i).ToLower.Contains(srcTxt) Then
                ListBox1.Items.Add(ChrW(i).ToString())
            End If
        Next
    End Sub

    Function NamedCharRange(ByVal srcTxt As String) As Boolean
        For Each itm As ListViewItem In ListView1.Items
            If itm.Index = 0 Then Continue For
            Dim txt As String = itm.Text.ToLower
            If txt.ToLower.Contains(srcTxt) Then
                itm.Selected = True
                itm.EnsureVisible()
                Return True
            End If
        Next
    End Function

    Function UserDefinedRange(ByVal a As Integer, ByVal b As Integer, ByVal range() As String) As Boolean
        Try
            'retrieve range name
            Dim rrnam As String = ""
            For Each itm As ListViewItem In ListView1.Items
                If itm.Index = 0 Then Continue For
                Dim rr() As String = Split(itm.SubItems(1).Text, "to")
                If a > rr(0) And b < rr(1) Then
                    rrnam = itm.Text
                ElseIf a = rr(0) And b = rr(1) Then
                    itm.Selected = True
                    itm.EnsureVisible()
                    Return True
                End If
            Next
            'Show range
            If rrnam = "" Then rrnam = "Unknown Range"
            RangeName.Text = rrnam
            addRange(range)
            startCode.Text = a
            EndCode.Text = b
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Sub SimpleSearch(ByVal srcTxt As String)
        'Charcter view
        If srcTxt.Length = 1 Then
            ViewChar(srcTxt) : Exit Sub
        End If
        'Code view
        If IsNumeric(srcTxt) Then
            ViewCode(CInt(srcTxt)) : Exit Sub
        End If
        'User defined range
        If srcTxt.Contains("-") Or srcTxt.Contains("to") Then
            Dim txt As String = Replace(srcTxt, "-", "to").Trim
            Dim range() As String = Split(txt, "to")
            If UserDefinedRange(range(0), range(1), range) Then Exit Sub
        End If
        'search in listview
        If NamedCharRange(srcTxt) Then Exit Sub
        'search in character names
        NamedChars(srcTxt)
    End Sub

    Sub xmlSearch(ByVal doc As XmlDocument)
        Dim vt As ViewType = doc.DocumentElement.Attributes("type").ToString()
        Select Case vt
            Case ViewType.ViewCode  'code view
                ViewCode(doc.DocumentElement.InnerXml)
            Case ViewType.ViewChar  'character view
                ViewChar(doc.DocumentElement.InnerXml)
            Case ViewType.NamedChars    'named characters
                NamedChars(doc.DocumentElement.InnerXml)
            Case ViewType.UserDefinedRange  'user defined range
                Dim range() As String = {doc.DocumentElement.FirstChild.InnerXml, doc.DocumentElement.LastChild.InnerXml}
                UserDefinedRange(range(0), range(1), range)
            Case ViewType.NamedCharRange    'named char range
                NamedCharRange(doc.DocumentElement.InnerXml)
        End Select
    End Sub
#End Region
#Region "SearchBox"
    Private Sub SearchBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchBox.SelectedIndexChanged
        If SearchBox.SelectedIndex = -1 Then Exit Sub
        ListView1.SelectedItems.Clear()
        'dim srctxt
        Dim srcTxt As String = SearchBox.SelectedItem
        If srcTxt.Contains("<?xml version='1.0'?>") Then
            Dim xdoc As New XmlDocument
            xdoc.LoadXml(srcTxt)
        Else
            SimpleSearch(srcTxt)
        End If
    End Sub

    Private Sub SearchBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SearchBox.KeyUp
        If e.KeyCode = Keys.Enter Then
            SearchBox.SelectedIndex = -1
            Dim txt As String = SearchBox.Text.Trim.ToLower
            If txt = "" Then Exit Sub
            SearchBox.Items.Insert(0, txt)
            My.Settings.chviewSearchStr.Insert(0, txt)
            If My.Settings.chviewSearchStr.Count > 32 Then
                My.Settings.chviewSearchStr.RemoveAt(32)
            End If
            SearchBox.SelectedIndex = 0
        End If
    End Sub

    Private Sub SearchBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SearchBox.GotFocus
        If SearchBox.Text = "Search" Then
            SearchBox.Text = ""
            SearchBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub SearchBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SearchBox.LostFocus
        If SearchBox.Text.Trim = "" Then
            SearchBox.ForeColor = Color.Gray
            SearchBox.Text = "Search"
        End If
    End Sub
#End Region '' End search

    ''' <summary>
    ''' Extra Apps
    ''' </summary>
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            System.Diagnostics.Process.Start("C:\Windows\system32\charmap.exe")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Copy on click
    ''' </summary>
    Private Sub MaxView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaxView.Click
        Try : My.Computer.Clipboard.SetText(MaxView.Text, 1) : Catch : End Try
    End Sub

    Private Sub HexCode_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HexCode.Click
        My.Computer.Clipboard.SetText(HexCode.Text)
    End Sub

    Private Sub DeciCode_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DeciCode.Click
        My.Computer.Clipboard.SetText(DeciCode.Text)
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        System.Diagnostics.Process.Start("C:\Windows\Fonts")
    End Sub

    Private Sub CharName_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CharName.Click
        Try
            My.Computer.Clipboard.SetText(CharName.Text)
        Catch : End Try
    End Sub

#Region "Char Name"

    Sub saveData()
        Try
            Dim txt As String = CharName.Text
            If txt = "[add name]" Then txt = ""
            Dim code As String = AscW(MaxView.Text)
            If data(code) = txt Then Exit Sub
            If txt = "" Then
                If MsgBox("Sure to delete data?", 4) = 7 Then Exit Sub
            End If
            data(code) = txt
            Dim ftxt As String = String.Join(vbCrLf, data)
            My.Computer.FileSystem.WriteAllText("Data\CharNames.txt", ftxt, False)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CharName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CharName.LostFocus
        'save data
        If EditMode Then
            Dim txt As String = CharName.Text
            Dim prev As String = data(AscW(MaxView.Text))
            If prev = txt Then Exit Sub
            Dim p As DialogResult = MsgBox("Some data is not saved. Do you want to Replace '" & prev & "' with '" & txt & "'?", 4)
            If p = 6 Then saveData()
            EditMode = False
        End If
        'set style
        If CharName.Text = "" Then
            CharName.Text = "[add name]"
            CharName.ForeColor = Color.Gray
        ElseIf EditMode Then
            CharName.ForeColor = Color.Black
        Else
            CharName.ForeColor = Color.Firebrick
        End If
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CharName.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not EditMode Then
                EditMode = True
                If CharName.Text = "[add name]" Then CharName.Text = ""
                CharName.ForeColor = Color.Black
            Else
                saveData()
                EditMode = False
                ListBox1.Focus()
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            EditMode = False
            ListBox1.Focus()
        End If
    End Sub
#End Region

#Region "Context Menu"
    Private Sub CopyCharacterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyCharacterToolStripMenuItem.Click
        My.Computer.Clipboard.SetText(MaxView.Text, 1)
    End Sub

    Private Sub CopyUnicodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyUnicodeToolStripMenuItem.Click
        My.Computer.Clipboard.SetText(HexCode.Text)
    End Sub

    Private Sub CopyDecimalCodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyDecimalCodeToolStripMenuItem.Click
        My.Computer.Clipboard.SetText(DeciCode.Text)
    End Sub

    Private Sub CopyNameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyNameToolStripMenuItem.Click
        My.Computer.Clipboard.SetText(CharName.Text)
    End Sub

    Private Sub EditNameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditNameToolStripMenuItem.Click
        EditMode = True
        CharName.Focus()
        If CharName.Text = "[add name]" Then CharName.Text = ""
        CharName.ForeColor = Color.Black
    End Sub
#End Region

    Private Sub HidePanel1(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MaxView.MouseDoubleClick, CharName.MouseDoubleClick, Panel1.MouseDoubleClick
        SplitContainer2.Panel1Collapsed = Not SplitContainer2.Panel1Collapsed
        My.Settings.chviewPanel1Collasped = SplitContainer2.Panel1Collapsed
    End Sub

    Private Sub HidePanel2(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SplitContainer2.MouseClick, Panel1.MouseDoubleClick, RangeName.MouseDoubleClick, FlowLayoutPanel1.MouseDoubleClick
        SplitContainer2.Panel2Collapsed = Not SplitContainer2.Panel2Collapsed
        My.Settings.chviewPanel2Collasped = SplitContainer2.Panel2Collapsed
    End Sub

    Private Sub EditRangeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditRangeToolStripMenuItem.Click
        Dim file As String = "Data\CharNames.txt"
        My.Computer.FileSystem.CopyFile(file, "CharNames.bkp", True)
        Process.Start(file)
    End Sub

    Private Sub ViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewToolStripMenuItem.Click
        If ListView1.SelectedItems.Count = 0 Then Exit Sub
        Dim itm As ListViewItem = ListView1.SelectedItems(0)
        RangeName.Text = itm.Text
        Dim range() As String = Split(itm.SubItems(1).Text, "to")
        addRange(range)
        startCode.Text = range(0)
        EndCode.Text = range(1)
    End Sub

    Private Sub SplitContainer1_SplitterMoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.SplitterEventArgs) Handles SplitContainer1.SplitterMoved
        My.Settings.chviewSp1Ln = SplitContainer1.SplitterDistance
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Try
            Process.Start("C:\Windows\System32\eudcedit.exe")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
