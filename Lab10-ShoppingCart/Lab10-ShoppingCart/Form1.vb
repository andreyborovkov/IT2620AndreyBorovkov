Public Class Form1


    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub mnuFileReset_Click(sender As Object, e As EventArgs) Handles mnuFileReset.Click
        ListBoxProductsSelected.Items.Clear()
        lblSubtotal.Text = 0
        lblTax.Text = 0
        lblShipping.Text = 0
        lblTotal.Text = 0
        price = 0
        itemName = ""

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        If ListBoxProductsSelected.SelectedItems.Count > 0 Then

            Dim itemToRemove As String
            itemToRemove = ListBoxProductsSelected.SelectedItem.ToString()


            If itemToRemove = "Learn Calculus in One Day (Audio)" Then
                price = price - 29.95
            ElseIf itemToRemove = "Relaxation Techniques (Audio)"
                price = price - 14.5
            ElseIf itemToRemove = "The History of Scotland (Audio)"
                price = price - 12.95
            ElseIf itemToRemove = "The Science of Body Language (Audio)"
                price = price - 11.5
            ElseIf itemToRemove = "I Did It Your Way (Print)"
                price = price - 11.95
            ElseIf itemToRemove = "The History of Scotland (Print)"
                price = price - 14.5
            ElseIf itemToRemove = "Learn Calculus in One Day (Print)"
                price = price - 29.95
            ElseIf itemToRemove = "Feel the Stress (Print)"
                price = price - 18.5
            End If

            lblSubtotal.Text = price
            ListBoxProductsSelected.Items.Remove(ListBoxProductsSelected.SelectedItem)
        End If

        lblShipping.Text = ListBoxProductsSelected.Items.Count * 2
        lblTax.Text = lblSubtotal.Text * 0.6
        lblTotal.Text = lblSubtotal.Text + lblShipping.Text + lblTax.Text


    End Sub

    Private Sub mnuProductsPrintBooks_Click(sender As Object, e As EventArgs) Handles mnuProductsPrintBooks.Click
        Dim frmPrintBooksOptions As New PrintBooksOptionsForm
        frmPrintBooksOptions.ShowDialog()
    End Sub

    Private Sub mnuProductsAudioBooks_Click(sender As Object, e As EventArgs) Handles mnuProductsAudioBooks.Click
        Dim frmAudioBooksOptions As New AudioBooksOptionsForm
        frmAudioBooksOptions.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotal.Text = itemName
    End Sub

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        Dim frmAbout As New AboutForm
        frmAbout.ShowDialog()
    End Sub
End Class

Public Module GlobalVariables
    Public itemName As String
    Public price As Double
End Module
