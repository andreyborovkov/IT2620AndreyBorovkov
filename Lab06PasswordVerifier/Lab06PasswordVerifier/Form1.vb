Public Class Form1

    Private strNewPassword As String
    Private strConfirmPassword As String




    'Private Function ValidateInputFields() As Boolean
    'If System.Text.RegularExpressions.Regex.Match(strNewPassword, "\d").Success Then
    ' txtNewPassword.Text.Length <6 Or  Then
    '       lblMessage.Text = "The password should be at least six characters long"
    'Return False
    'End If


    'Return True
    'End Function

    Private Function ValidateInputFields() As Boolean
        If System.Text.RegularExpressions.Regex.Match(strNewPassword, "[0-9]").Success And
                (System.Text.RegularExpressions.Regex.Match(strNewPassword, "[a-z]").Success Or
                System.Text.RegularExpressions.Regex.Match(strNewPassword, "[A-Z]").Success) And
                txtNewPassword.Text.Length > 6 Then
            Return True
        Else
            Return False
        End If
    End Function



    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        'Clear any previous message.
        lblMessage.Text = String.Empty

        strNewPassword = txtNewPassword.Text
        strConfirmPassword = txtConfirmPassword.Text


        If ValidateInputFields() Then
            If strNewPassword = strConfirmPassword Then
                lblMessage.Text = "You've been signed in"
            Else
                lblMessage.Text = "*Passwords do not match"
            End If
        Else
            lblMessage.Text = "*The password should be at least six characters
long and contain at least one numeric digit and 
at least one alphabetic character"
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
