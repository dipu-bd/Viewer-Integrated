Imports System
Imports System.Drawing
Public Class ColorChooser
    ''' <summary>
    ''' User Assist Functions
    ''' </summary>
    Function getHTMLCode(ByVal [color] As Color)
        Dim red As String = Hex(color.R)
        Dim green As String = Hex(color.G)
        Dim blue As String = Hex(color.B)
        While red.Length < 2
            red = "0" & red
        End While
        While green.Length < 2
            green = "0" & green
        End While
        While blue.Length < 2
            blue = "0" & blue
        End While
        Return "#" & red & green & blue
    End Function

    ''' <summary>
    ''' On Load
    ''' </summary>
    Private Sub ColorChooser_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        For Each itm In [Enum].GetValues(GetType(KnownColor))
            Dim clr As Color = Color.FromName(itm.ToString())
            Dim litm As New ListViewItem
            litm.UseItemStyleForSubItems = False
            litm.SubItems(0).BackColor = clr
            litm.SubItems.Add(itm.ToString())
            litm.SubItems.Add(getHTMLCode(clr))
            litm.SubItems(1).Font = New Font(ColorList.Font.FontFamily, 9)
            litm.SubItems(2).Font = New Font("Courier New", 9)
            litm.ToolTipText = litm.SubItems(1).Text
            ColorList.Items.Add(litm)
        Next
        ColorList.Items(0).Selected = True
    End Sub

    ''' <summary>
    ''' Search Functions
    ''' </summary>
    Private Sub SearchBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SearchBox.GotFocus
        If SearchBox.Text = "Search" Then
            SearchBox.ForeColor = Color.Black
            SearchBox.Text = ""
        Else
            SearchBox.SelectAll()
        End If
    End Sub

    Private Sub SearchBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SearchBox.LostFocus
        If SearchBox.Text.Trim = "" Then
            SearchBox.ForeColor = Color.Gray
            SearchBox.Text = "Search"
        End If
    End Sub

    Private Sub SearchBox_TextChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles SearchBox.TextChanged
        Dim txt As String = SearchBox.Text.Trim.ToLower()
        For Each itm As ListViewItem In ColorList.Items
            If itm.SubItems(1).Text.ToLower.StartsWith(txt) Then
                itm.Selected = True
                itm.EnsureVisible()
                Exit For
            End If
        Next
    End Sub

    Private Sub SearchBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SearchBox.KeyUp
        If e.KeyCode = Keys.Enter Then
            If ColorList.SelectedItems.Count > 0 Then Exit Sub
            Dim srctxt As String = SearchBox.Text.Trim.ToLower()
            For Each itm As ListViewItem In ColorList.Items
                Dim txt As String = itm.SubItems(1).Text.ToLower & " " & itm.SubItems(2).Text.ToLower
                If txt.Contains(srctxt) Then
                    itm.Selected = True
                    itm.EnsureVisible()
                    Exit For
                End If
            Next
        End If
    End Sub
End Class
