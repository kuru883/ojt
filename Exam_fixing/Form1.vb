Public Class Form1
    Dim str As String
    Dim a, s, m, d, n1, n2 As Integer

    Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        str = CheckedListBox1.SelectedItem.ToString()

        n1 = Val(TextBox2.Text)
        n2 = Val(TextBox3.Text)

        Select Case str
            Case "ADD"
                a = n1 + n2
                MsgBox("the sum is "  & a)



        End Select
    End Sub
End Class
