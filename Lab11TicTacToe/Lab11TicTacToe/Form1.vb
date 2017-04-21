Public Class Form1
    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click


        Dim strTicTacToe(2, 2) As String ' 3 columns and 3 rows array
        Dim rand As New Random()

        'Assigning random values to the objects in the array
        strTicTacToe(0, 0) = rand.Next(0, 2)
        strTicTacToe(0, 1) = rand.Next(0, 2)
        strTicTacToe(0, 2) = rand.Next(0, 2)
        strTicTacToe(1, 0) = rand.Next(0, 2)
        strTicTacToe(1, 1) = rand.Next(0, 2)
        strTicTacToe(1, 2) = rand.Next(0, 2)
        strTicTacToe(2, 0) = rand.Next(0, 2)
        strTicTacToe(2, 1) = rand.Next(0, 2)
        strTicTacToe(2, 2) = rand.Next(0, 2)

        'Sending the objects' values to the labels
        Label1.Text = strTicTacToe(0, 0)
        Label2.Text = strTicTacToe(0, 1)
        Label3.Text = strTicTacToe(0, 2)
        Label4.Text = strTicTacToe(1, 0)
        Label5.Text = strTicTacToe(1, 1)
        Label6.Text = strTicTacToe(1, 2)
        Label7.Text = strTicTacToe(2, 0)
        Label8.Text = strTicTacToe(2, 1)
        Label9.Text = strTicTacToe(2, 2)


        'X is more likely to win because usually it goes first

        'X wins
        If (strTicTacToe(0, 0) = 1 And strTicTacToe(0, 1) = 1 And strTicTacToe(0, 2) = 1) Or 'First Row
           (strTicTacToe(1, 0) = 1 And strTicTacToe(1, 1) = 1 And strTicTacToe(1, 2) = 1) Or 'Second Row
           (strTicTacToe(2, 0) = 1 And strTicTacToe(2, 1) = 1 And strTicTacToe(2, 2) = 1) Or 'Third Row
           (strTicTacToe(0, 0) = 1 And strTicTacToe(1, 0) = 1 And strTicTacToe(2, 0) = 1) Or 'First Column
           (strTicTacToe(0, 1) = 1 And strTicTacToe(1, 1) = 1 And strTicTacToe(2, 1) = 1) Or 'Second Column
           (strTicTacToe(0, 2) = 1 And strTicTacToe(1, 2) = 1 And strTicTacToe(2, 2) = 1) Or 'Third Column
           (strTicTacToe(0, 0) = 1 And strTicTacToe(1, 1) = 1 And strTicTacToe(2, 2) = 1) Or 'First Diagonal
           (strTicTacToe(0, 2) = 1 And strTicTacToe(1, 1) = 1 And strTicTacToe(2, 0) = 1) Then 'Second Diagonal

            lblResult.Text = "X Wins!"

            'O Wins
        ElseIf (strTicTacToe(0, 0) = 0 And strTicTacToe(0, 1) = 0 And strTicTacToe(0, 2) = 0) Or 'First Row
               (strTicTacToe(1, 0) = 0 And strTicTacToe(1, 1) = 0 And strTicTacToe(1, 2) = 0) Or 'Second Row
               (strTicTacToe(2, 0) = 0 And strTicTacToe(2, 1) = 0 And strTicTacToe(2, 2) = 0) Or 'Third Row
               (strTicTacToe(0, 0) = 0 And strTicTacToe(1, 0) = 0 And strTicTacToe(2, 0) = 0) Or 'First Column
               (strTicTacToe(0, 1) = 0 And strTicTacToe(1, 1) = 0 And strTicTacToe(2, 1) = 0) Or 'Second Column
               (strTicTacToe(0, 2) = 0 And strTicTacToe(1, 2) = 0 And strTicTacToe(2, 2) = 0) Or 'Third Column
               (strTicTacToe(0, 0) = 0 And strTicTacToe(1, 1) = 0 And strTicTacToe(2, 2) = 0) Or 'First Diagonal
               (strTicTacToe(0, 2) = 0 And strTicTacToe(1, 1) = 0 And strTicTacToe(2, 0) = 0) Then 'Second Diagonal

            lblResult.Text = "O Wins!"

            'Nobody Wins
        Else
            lblResult.Text = "Nobody wins"
        End If



        'Changing values of 0 and 1 to coresponding O and X
        If Label1.Text = 0 Then
            Label1.Text = "O"
        Else
            Label1.Text = "X"
        End If
        If Label2.Text = 0 Then
            Label2.Text = "O"
        Else
            Label2.Text = "X"
        End If
        If Label3.Text = 0 Then
            Label3.Text = "O"
        Else
            Label3.Text = "X"
        End If
        If Label4.Text = 0 Then
            Label4.Text = "O"
        Else
            Label4.Text = "X"
        End If
        If Label5.Text = 0 Then
            Label5.Text = "O"
        Else
            Label5.Text = "X"
        End If
        If Label6.Text = 0 Then
            Label6.Text = "O"
        Else
            Label6.Text = "X"
        End If
        If Label7.Text = 0 Then
            Label7.Text = "O"
        Else
            Label7.Text = "X"
        End If
        If Label8.Text = 0 Then
            Label8.Text = "O"
        Else
            Label8.Text = "X"
        End If
        If Label9.Text = 0 Then
            Label9.Text = "O"
        Else
            Label9.Text = "X"
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
