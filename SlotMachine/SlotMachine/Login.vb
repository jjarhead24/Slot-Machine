Public Class Login
    Private Sub lbUsers_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lbUsers.MouseDoubleClick
        If lbUsers.SelectedIndex >= 0 Then
            Dim item = lbUsers.Items(lbUsers.SelectedIndex)
            Form1.CurrentUser = item
            Me.Hide()
            Form1.Show()
        End If
    End Sub

    Private Sub SelectUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.LoadFromFile()
        For Each keypair In Form1.Bankrupcys
            lbUsers.Items.Add(keypair.Key)
        Next
        If Not Form1.Bankrupcys.ContainsKey(Environment.UserName) Then
            lbUsers.Items.Add(Environment.UserName)
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim input = InputBox("Enter new username", "New Username", Environment.UserName)
        If Not String.IsNullOrWhiteSpace(input) Then
            If input.Contains(" ") OrElse input.Contains(":") Then
                MsgBox("Invalid name")
                Return
            End If
            lbUsers.Items.Add(input)
            Form1.CurrentUser = input
            Form1.Bankrupcys(input) = 0
            Form1.SaveToFile()
        End If
    End Sub
End Class
