Public Class AudioBooksOptionsForm
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAddAudioBook_Click(sender As Object, e As EventArgs) Handles btnAddAudioBook.Click
        If ListBoxAudioBooksSelected.SelectedItems.Count > 0 Then

            If ListBoxAudioBooksSelected.SelectedIndex = 0 Then
                price = price + 29.95
            ElseIf ListBoxAudioBooksSelected.SelectedIndex = 1
                price = price + 14.5
            ElseIf ListBoxAudioBooksSelected.SelectedIndex = 2
                price = price + 12.95
            ElseIf ListBoxAudioBooksSelected.SelectedIndex = 3
                price = price + 11.5
            End If


            My.Forms.Form1.lblSubtotal.Text = price
            itemName = ListBoxAudioBooksSelected.SelectedItem.ToString()
            My.Forms.Form1.ListBoxProductsSelected.Items.Add(itemName)

            'Update values in all labels
            My.Forms.Form1.lblShipping.Text = My.Forms.Form1.ListBoxProductsSelected.Items.Count * 2
            My.Forms.Form1.lblTax.Text = My.Forms.Form1.lblSubtotal.Text * 0.6
            My.Forms.Form1.lblTotal.Text = My.Forms.Form1.lblSubtotal.Text + My.Forms.Form1.lblShipping.Text + My.Forms.Form1.lblTax.Text
            Me.Close()

        End If
    End Sub
End Class