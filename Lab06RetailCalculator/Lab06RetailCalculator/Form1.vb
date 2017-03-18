Public Class Form1

    Private decWholesaleCost As Decimal
    Private decMarkupPercentage As Decimal

    Private Function ValidateInputFields() As Boolean 'Checks whether the variables are numeric and positive
        If Not Decimal.TryParse(txtWholesaleCost.Text, decWholesaleCost) Or decWholesaleCost < 0 Then
            lblMessage.Text = "*Wholesale cost must be numberic and not negative"
            Return False
        End If

        If Not Decimal.TryParse(txtMarkupPercentage.Text, decMarkupPercentage) Or decMarkupPercentage < 0 Then
            lblMessage.Text = "*Markup Percentage must be numberic and not negative"
            Return False
        End If

        Return True
    End Function

    Function CalculateRetail(ByVal decWholesaleCost As Decimal,
                             ByVal decMarkupPercentage As Decimal) As Decimal
        Dim decRetailPrice As Decimal
        decRetailPrice = decWholesaleCost + decMarkupPercentage / 100 * decWholesaleCost
        Return decRetailPrice
    End Function

    Private Sub btnGetRetail_Click(sender As Object, e As EventArgs) Handles btnGetRetail.Click
        Dim dectRetailPrice As Decimal

        'Clear any previous message.
        lblMessage.Text = String.Empty

        'If the input is valid, display the retail price.
        If ValidateInputFields() Then
            dectRetailPrice = CalculateRetail(decWholesaleCost, decMarkupPercentage)
            lblResult.Text = dectRetailPrice.ToString("c")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
