Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnExample_Click(sender As Object, e As EventArgs) Handles btnExample.Click

        Dim rand As New Random()
        Dim arraySize = rand.Next(0, 5)
        Dim intArray(arraySize) As Integer
        Dim intCount As Integer = 0
        lblNumbers.Text = ""
        For intCount = 0 To arraySize
            intArray(intCount) = rand.Next(1, 100)
            Array.Sort(intArray)
            lblNumbers.Text += intArray(intCount).ToString() & ", "
        Next


        'Any formulas for finding a median for odd size of the array I tried to use do not work the way I want them too for some reasons. 
        'Even the following basic code for odd size of the array gives me the wrong result if I keep clicking the calculate button.
        Dim medianOdd As Decimal
        If intArray.Count = 1 Then
            medianOdd = intArray(0)
            lblMedian.Text = medianOdd.ToString("F2")
        ElseIf intArray.Count = 3 Then
            medianOdd = intArray(1)
            lblMedian.Text = medianOdd.ToString("F2")
        ElseIf intArray.Count = 5 Then
            medianOdd = intArray(2)
            lblMedian.Text = medianOdd.ToString("F2")
        Else 'Even number of values

            Dim medianEven As Decimal = (intArray(intArray.Count / 2) + intArray(intArray.Count / 2 - 1)) / 2
            lblMedian.Text = medianEven.ToString("F2")

        End If


    End Sub
End Class
