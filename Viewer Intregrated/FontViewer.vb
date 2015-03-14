Public Class FontViewer

    ''' <summary>
    ''' Load Items:
    ''' Font list, sentence sample text and others
    ''' </summary>
    Private Sub FontViewer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ifc As New Drawing.Text.InstalledFontCollection()
        addFontnames(ifc.Families)
        FontNameList.Items(0).Selected = True
    End Sub

    Sub addFontnames(ByVal family() As System.Drawing.FontFamily)
        FontNameList.Items.Clear()
        For Each fnt As FontFamily In family
            Dim listitm As New ListViewItem(New String() {fnt.Name, "Sample Text"})
            Dim itmfnt As Font = FontNameList.Font
            If fnt.IsStyleAvailable(FontStyle.Regular) Then
                itmfnt = New Font(fnt.Name, itmfnt.Size, FontStyle.Regular)
            ElseIf fnt.IsStyleAvailable(FontStyle.Bold) Then
                itmfnt = New Font(fnt.Name, itmfnt.Size, FontStyle.Bold)
            ElseIf fnt.IsStyleAvailable(FontStyle.Italic) Then
                itmfnt = New Font(fnt.Name, itmfnt.Size, FontStyle.Italic)
            End If
            listitm.UseItemStyleForSubItems = False
            listitm.SubItems(1).Font = itmfnt
            FontNameList.Items.Add(listitm)
        Next
    End Sub

    Sub addSample(ByVal txt As String)
        SampleSentenceView.Items.Clear()
        For Each itm As ListViewItem In FontNameList.Items
            Dim fnt As New Font(itm.SubItems(1).Font.FontFamily, 14, itm.SubItems(1).Font.Style, GraphicsUnit.Point)
            Dim litm As New ListViewItem(txt)
            litm.Font = fnt
            SampleSentenceView.Items.Add(litm).ToolTipText = fnt.Name
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SenteceViewButton.Click
        If sentenceText.Text.Trim = "" Then Exit Sub
        SampleSentenceView.View = View.Details
        addSample(sentenceText.Text.Trim)
        SampleSentenceView.Columns(0).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
    End Sub
    Private Sub sentenceText_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sentenceText.KeyDown
        If e.KeyCode = Keys.Enter Then SenteceViewButton.PerformClick()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WordSelection.SelectedIndexChanged
        SampleSentenceView.View = View.LargeIcon
        addSample(WordSelection.SelectedItem.ToString)
    End Sub

    ''' <summary>
    ''' Sample text view properties
    ''' </summary>  
    Private Sub DefaultToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefaultToolStripMenuItem.Click
        SampleTextView.Text = My.Resources.a0
    End Sub 'default

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        SampleTextView.Text = My.Resources.a1
    End Sub 'lorem ipsum

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        SampleTextView.Text = My.Resources.a2
    End Sub 'ascii

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        SampleTextView.Text = My.Resources.a3
    End Sub 'greek

    Private Sub BanglaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BanglaToolStripMenuItem.Click
        SampleTextView.Text = My.Resources.a4
    End Sub 'bangla

    'styles
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegularStyle.Click
        BoldStyle.Checked = False
        ItallicStyle.Checked = False
        UnderlineStyle.Checked = False
        StrikeoutStyle.Checked = False
        SampleTextView.Font = New Font(SampleTextView.Font.Name, NumericUpDown1.Value, FontStyle.Regular, GraphicsUnit.Pixel)
    End Sub

    Private Sub BoldStyle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoldStyle.Click
        Dim style As FontStyle = Nothing
        If BoldStyle.Checked Then style = FontStyle.Bold
        If ItallicStyle.Checked Then style = style Or FontStyle.Italic
        If StrikeoutStyle.Checked Then style = style Or FontStyle.Strikeout
        If UnderlineStyle.Checked Then style = style Or FontStyle.Underline
        SampleTextView.Font = New Font(SampleTextView.Font.Name, NumericUpDown1.Value, CType(style, FontStyle), GraphicsUnit.Pixel)
    End Sub

    Private Sub ItallicStyle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItallicStyle.Click
        Dim style As FontStyle = Nothing
        If ItallicStyle.Checked Then style = FontStyle.Italic
        If BoldStyle.Checked Then style = style Or FontStyle.Bold
        If StrikeoutStyle.Checked Then style = style Or FontStyle.Strikeout
        If UnderlineStyle.Checked Then style = style Or FontStyle.Underline
        SampleTextView.Font = New Font(SampleTextView.Font.Name, NumericUpDown1.Value, CType(style, FontStyle), GraphicsUnit.Pixel)
    End Sub

    Private Sub UnderlineStyle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnderlineStyle.Click
        Dim style As FontStyle = Nothing
        If UnderlineStyle.Checked Then style = FontStyle.Underline
        If BoldStyle.Checked Then style = style Or FontStyle.Bold
        If ItallicStyle.Checked Then style = style Or FontStyle.Italic
        If StrikeoutStyle.Checked Then style = style Or FontStyle.Strikeout
        SampleTextView.Font = New Font(SampleTextView.Font.Name, NumericUpDown1.Value, CType(style, FontStyle), GraphicsUnit.Pixel)
    End Sub

    Private Sub StrikeoutStyle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StrikeoutStyle.Click
        Dim style As FontStyle = Nothing
        If StrikeoutStyle.Checked Then style = FontStyle.Strikeout
        If BoldStyle.Checked Then style = style Or FontStyle.Bold
        If ItallicStyle.Checked Then style = style Or FontStyle.Italic
        If UnderlineStyle.Checked Then style = style Or FontStyle.Underline
        SampleTextView.Font = New Font(SampleTextView.Font.Name, NumericUpDown1.Value, CType(style, FontStyle), GraphicsUnit.Pixel)
    End Sub

    'font size
    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        Dim fnt As Font = New Font(SampleTextView.Font.Name, NumericUpDown1.Value, SampleTextView.Font.Style, GraphicsUnit.Pixel)
        SampleTextView.Font = fnt
    End Sub
    'End of style control

    'show font
    Private Sub SampleSentenceView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SampleSentenceView.SelectedIndexChanged
        If SampleSentenceView.Items.Count = 0 Then Exit Sub
        Try
            Dim indx As Integer = SampleSentenceView.SelectedItems(0).Index
            If Not FontNameList.Items(indx).Selected Then
                FontNameList.Items(indx).Selected = True
                FontNameList.EnsureVisible(indx)
            End If
        Catch : End Try
    End Sub

    'show font properties
    Private Sub FontNameList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontNameList.SelectedIndexChanged
        Try
            Dim siz As Integer = NumericUpDown1.Value
            Dim fnt As Font = FontNameList.SelectedItems(0).SubItems(1).Font
            Dim family As FontFamily = fnt.FontFamily
            RegularStyle.Enabled = family.IsStyleAvailable(FontStyle.Regular)
            BoldStyle.Enabled = family.IsStyleAvailable(FontStyle.Bold) : BoldStyle.Checked = False
            ItallicStyle.Enabled = family.IsStyleAvailable(FontStyle.Italic) : ItallicStyle.Checked = False
            StrikeoutStyle.Enabled = family.IsStyleAvailable(FontStyle.Strikeout) : StrikeoutStyle.Checked = False
            UnderlineStyle.Enabled = family.IsStyleAvailable(FontStyle.Underline) : UnderlineStyle.Checked = False
            SampleTextView.Font = New Font(fnt.Name, siz, fnt.Style, GraphicsUnit.Pixel)
            'select sample sentence
            If SampleSentenceView.Items.Count = 0 Then Exit Sub
            Dim indx As Integer = FontNameList.SelectedItems(0).Index
            If Not SampleSentenceView.Items(indx).Selected Then
                SampleSentenceView.Items(indx).Selected = True
                SampleSentenceView.EnsureVisible(indx)
            End If
        Catch : End Try
    End Sub

    Private Sub SampleTextView_FontChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SampleTextView.FontChanged
        Dim fnt As Font = SampleTextView.Font
        Dim family As FontFamily = fnt.FontFamily
        FontName.Text = fnt.Name
        With ListView1
            .Items(0).SubItems(1).Text = fnt.OriginalFontName
            .Items(1).SubItems(1).Text = fnt.IsSystemFont
            .Items(2).SubItems(1).Text = fnt.SystemFontName
            .Items(3).SubItems(1).Text = fnt.GdiCharSet
            .Items(4).SubItems(1).Text = fnt.GdiVerticalFont
            .Items(5).SubItems(1).Text = fnt.Height
            .Items(6).SubItems(1).Text = family.GetCellAscent(fnt.Style)
            .Items(7).SubItems(1).Text = family.GetCellDescent(fnt.Style)
            .Items(8).SubItems(1).Text = family.GetEmHeight(fnt.Style)
            .Items(9).SubItems(1).Text = family.GetLineSpacing(fnt.Style)
            'available styles
            Dim txt As String = ""
            If family.IsStyleAvailable(FontStyle.Regular) Then txt &= "Regular,"
            If family.IsStyleAvailable(FontStyle.Bold) Then txt &= "Bold,"
            If family.IsStyleAvailable(FontStyle.Italic) Then txt &= "Italic,"
            If family.IsStyleAvailable(FontStyle.Strikeout) Then txt &= "Strikeout,"
            If family.IsStyleAvailable(FontStyle.Underline) Then txt &= "Underline,"
            Dim sts() As String = txt.Split(New String() {","}, StringSplitOptions.RemoveEmptyEntries)
            .Items(10).SubItems(1).Text = String.Join(", ", sts) & "."
        End With
        For Each itm As ListViewItem In ListView1.Items
            itm.ToolTipText = itm.Text & vbCrLf & itm.SubItems(1).Text
        Next
    End Sub

    ''' <summary>
    ''' Search Functions
    ''' </summary>
    Private Sub SearchBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SearchBox.GotFocus
        If SearchBox.Text = "Search" Then
            SearchBox.ForeColor = Color.Black
            SearchBox.Text = ""
        End If
    End Sub

    Private Sub SearchBox_TextChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles SearchBox.TextChanged
        Try
            Dim txt As String = SearchBox.Text.Trim.ToLower()
            For Each itm As ListViewItem In FontNameList.Items
                If itm.Text.ToLower.Contains(txt) Then
                    itm.Selected = True
                    itm.EnsureVisible()
                    Exit For
                End If
            Next
        Catch : End Try
    End Sub

    Private Sub SearchBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SearchBox.LostFocus
        If SearchBox.Text.Trim = "" Then
            SearchBox.ForeColor = Color.Gray
            SearchBox.Text = "Search"
        End If
    End Sub

    Private Sub ListView1_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles ListView1.ColumnClick
        ListView1.Columns(e.Column).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ifc As New Drawing.Text.InstalledFontCollection
        addFontnames(ifc.Families)
        Button1.FlatStyle = FlatStyle.Popup
        Button2.FlatStyle = FlatStyle.Standard
        FontNameList.ContextMenuStrip = Nothing
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'show open file dialogue
        Dim pfc As New Drawing.Text.PrivateFontCollection
        Dim ofd As New OpenFileDialog
        ofd.Multiselect = True
        ofd.Filter = "Font Files|*.ttf;*.otf|True Type Fonts|*.ttf|Open Type Fonts|*.otf"
        If ofd.ShowDialog = 1 Then
            Button1.FlatStyle = FlatStyle.Standard
            Button2.FlatStyle = FlatStyle.Popup
            For Each file As String In ofd.FileNames
                pfc.AddFontFile(file)
            Next
            addFontnames(pfc.Families)
        End If
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            Process.Start("C:\Windows\Fonts")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Background1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Background1.Click
        Dim cd As New ColorDialog
        cd.FullOpen = True
        cd.Color = SampleTextView.BackColor
        If cd.ShowDialog = 1 Then
            SampleTextView.BackColor = cd.Color
            Background1.BackColor = cd.Color
        End If
    End Sub

    Private Sub Foreground1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Foreground1.Click
        Dim cd As New ColorDialog
        cd.FullOpen = True
        cd.Color = SampleTextView.ForeColor
        If cd.ShowDialog = 1 Then
            SampleTextView.ForeColor = cd.Color
            Foreground1.BackColor = cd.Color
        End If
    End Sub

End Class
