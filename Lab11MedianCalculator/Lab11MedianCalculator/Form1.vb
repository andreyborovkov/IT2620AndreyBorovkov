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


        If intArray.Length Mod 2 <> 0 Then 'odd number of values
            lblMedian.Text = "Median = " & intArray(intArray.GetUpperBound(0) / 2).ToString
        Else 'Even number of values
            Dim num1 As Integer = intArray(intArray.Count / 2)
            Dim num2 As Integer = intArray((intArray.Count / 2) - 1)
            Dim median As Decimal = (num1 + num2) \ 2
            lblMedian.Text = "Median = " & median.ToString

        End If


    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs)

    End Sub
End Class
