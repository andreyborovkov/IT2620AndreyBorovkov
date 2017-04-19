Public Class PrintBooksOptionsForm
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAddPrintedBook_Click(sender As Object, e As EventArgs) Handles btnAddPrintedBook.Click
        If ListBoxPrintBooksSelected.SelectedItems.Count > 0 Then

            If ListBoxPrintBooksSelected.SelectedIndex = 0 Then
                price = price + 11.95
            ElseIf ListBoxPrintBooksSelected.SelectedIndex = 1
                price = price + 14.5
            ElseIf ListBoxPrintBooksSelected.SelectedIndex = 2
                price = price + 29.95
            ElseIf ListBoxPrintBooksSelected.SelectedIndex = 3
                price = price + 18.5
            End If


            My.Forms.Form1.lblSubtotal.Text = price
            itemName = ListBoxPrintBooksSelected.SelectedItem.ToString()
            My.Forms.Form1.ListBoxProductsSelected.Items.Add(itemName)

            'Update values in all labels
            My.Forms.Form1.lblShipping.Text = My.Forms.Form1.ListBoxProductsSelected.Items.Count * 2
            My.Forms.Form1.lblTax.Text = My.Forms.Form1.lblSubtotal.Text * 0.6
            My.Forms.Form1.lblTotal.Text = My.Forms.Form1.lblSubtotal.Text + My.Forms.Form1.lblShipping.Text + My.Forms.Form1.lblTax.Text
            Me.Close()

        End If
    End Sub
End Class