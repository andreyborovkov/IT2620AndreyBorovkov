Public Class ConferenceOptionsForm
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        totalCost = 0



        If CheckBox1.Checked = True Then
            totalCost = 895
            If ListBox1.SelectedIndex = 0 Then
                totalCost = totalCost + 295
            ElseIf ListBox1.SelectedIndex = 1
                totalCost = totalCost + 295
            ElseIf ListBox1.SelectedIndex = 2
                totalCost = totalCost + 395
            ElseIf ListBox1.SelectedIndex = 3
                totalCost = totalCost + 395
            Else totalCost = totalCost
            End If

            If CheckBox2.Checked = True Then
                totalCost = totalCost + 30
            End If

            My.Forms.Form1.lblTotal.Text = totalCost.ToString("c")
            Me.Close()

        ElseIf (ListBox1.SelectedIndex > -1 And ListBox1.SelectedIndex < 4) Or (CheckBox1.Checked = False And CheckBox2.Checked = True) Then
            ListBox1.ClearSelected()
            CheckBox2.Checked = False
            MsgBox("Cannot register for the optional events without selecting the conference registration.")

        Else
            My.Forms.Form1.lblTotal.Text = totalCost.ToString("c")
            Me.Close()
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        totalCost = 0
        ListBox1.ClearSelected()
    End Sub
End Class