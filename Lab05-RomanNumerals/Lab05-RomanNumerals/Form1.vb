Public Class Form1
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        'Declaring an input variable, so that it could be used in TryParse method
        Dim intInput As Integer


        'Checking whether the input is an integer between numbers 1 and 10
        If Integer.TryParse(txtInput.Text, intInput) And intInput > 0 And intInput < 11 Then

            Try
                Select Case CInt(txtInput.Text)
                    Case 1
                        lblResult.Text = "I"
                    Case 2
                        lblResult.Text = "II"
                    Case 3
                        lblResult.Text = "III"
                    Case 4
                        lblResult.Text = "VI"
                    Case 5
                        lblResult.Text = "V"
                    Case 6
                        lblResult.Text = "VI"
                    Case 7
                        lblResult.Text = "VII"
                    Case 8
                        lblResult.Text = "VIII"
                    Case 9
                        lblResult.Text = "IX"
                    Case 10
                        lblResult.Text = "X"
                End Select
            Catch
                MessageBox.Show("Something went wrong")
            End Try
        Else
            MessageBox.Show("Invalid Data")
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
