Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intCount As Integer
        Dim intDistance As Integer
        Dim intTotal As Integer
        Dim strTemp As String
        'For some reasons, although vbTab command works in my string objects, commands vbNewLine and vbCrLf do not, 
        'so I had to create objects for each line of my output description. 
        Dim strSpeedDescription As String
        Dim strTimeDescription As String
        Dim strColumns As String
        Dim strBreak As String

        Dim strTotal As String

        Try
            'Variables for Speed Input box
            Dim strSpeedInput As String
            Dim intSpeed As Integer
            strSpeedInput = InputBox("Enter the speed of the vehicle in miles per hour.", "Input Needed")
            intSpeed = CInt(strSpeedInput)

            'Variables for Time Input box
            Dim strTimeInput As String
            Dim intTime As Integer
            strTimeInput = InputBox("Enter the amount of time, in hours, that the vehicle has traveled", "Input Needed")
            intTime = CInt(strTimeInput)

            If Integer.TryParse(strSpeedInput, intSpeed) And intSpeed > 0 And Integer.TryParse(strTimeInput, intTime) And intTime > 0 Then


                'Display the description
                strSpeedDescription = "Vehicle Speed: " & intSpeed.ToString() & " MPH"
                strTimeDescription = "Time Traveled: " & intTime.ToString() & vbCrLf & " hours"
                strColumns = "Hours" & vbTab & "Distance Traveled"
                strBreak = "--------------------------------------------"

                lstOutput.Items.Add(strSpeedDescription)
                lstOutput.Items.Add(strTimeDescription)
                lstOutput.Items.Add(strColumns)
                lstOutput.Items.Add(strBreak)

                For intCount = 1 To intTime
                    intDistance = CInt(intCount * intSpeed)
                    intTotal += intDistance

                    'String to display
                    strTemp = intCount.ToString() & vbTab & intDistance.ToString()
                    lstOutput.Items.Add(strTemp)

                Next

                'Display Total

                strTotal = "Total Distance: " & intTotal.ToString()
                lstOutput.Items.Add(strTotal)

            Else
                MessageBox.Show("Invalid Data")
            End If


        Catch
            MessageBox.Show("Something went wrong")

        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
