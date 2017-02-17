Public Class Form1
    Private Sub btnCompare_Click(sender As Object, e As EventArgs) Handles btnCompare.Click

        'Declaring variables
        Dim intA As Integer
        Dim intB As Integer

        'Checking whether the variables in the text boxes are integers and assigning them to the variables if they are
        If Integer.TryParse(txtA.Text, intA) And Integer.TryParse(txtB.Text, intB) Then
            Try

                If intA > intB Then
                    lblResult.Text = "Values A is greatest"
                ElseIf intA < intB Then
                    lblResult.Text = "Value B is greatest"
                Else
                    lblResult.Text = "Values are equal"
                End If

            Catch
                lblResult.Text = "Something went wrong"
            End Try


        Else
            lblResult.Text = "Invalid Data" 'Displays the message if any of the variables is not an integer
        End If


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
