Public Class Form1



    Private Sub btnSelectOptions_Click_1(sender As Object, e As EventArgs) Handles btnSelectOptions.Click
        Dim frmConferenceOptions As New ConferenceOptionsForm
        frmConferenceOptions.ShowDialog()
    End Sub


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtName.Clear()
        txtCompany.Clear()
        txtAddress.Clear()
        txtCity.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        txtState.Clear()
        txtZip.Clear()
        lblTotal.Text = 0.ToString("c")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class


Public Module GlobalVariables
    Public totalCost As Double
End Module
