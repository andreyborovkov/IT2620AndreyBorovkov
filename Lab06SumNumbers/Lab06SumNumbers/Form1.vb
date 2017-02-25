Public Class Form1
    Private Sub btnEnterNumbers_Click(sender As Object, e As EventArgs) Handles btnEnterNumbers.Click
        Dim strUserInput As String
        Dim intCount As Integer
        Dim intInputNumber As Integer
        Dim intTotal As Integer

        Try
            strUserInput = InputBox("Enter a positive integer value", "Input Needed", "10")
            intInputNumber = CInt(strUserInput)

            If Integer.TryParse(strUserInput, intInputNumber) And intInputNumber > 0 Then
                For intCount = 1 To intInputNumber
                    intTotal += intCount
                Next

                MessageBox.Show("The sum of numbers 1 through " & intInputNumber & " is " & intTotal)
            Else
                MessageBox.Show("Invalid Input")
            End If
        Catch
            MessageBox.Show("Invalid Input")
        End Try


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
