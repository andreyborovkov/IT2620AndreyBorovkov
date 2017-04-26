Imports System.IO

Public Module GlobalVariables
    Public employeeFile As StreamReader
    Public recordNumber As Integer
End Module

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strFilename As String
        strFilename = InputBox("Enter the filename.")

        Try
            'Open the file
            employeeFile = File.OpenText(strFilename)

        Catch
            MessageBox.Show("That file cannot be opened")
            Me.Close()
        End Try
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        recordNumber = recordNumber + 1
        lblFirstName.Text = employeeFile.ReadLine()
        lblMiddleName.Text = employeeFile.ReadLine()
        lblLastName.Text = employeeFile.ReadLine()
        lblEmployeeNumber.Text = employeeFile.ReadLine()
        lblDepartment.Text = employeeFile.ReadLine()
        lblTelephone.Text = employeeFile.ReadLine()
        lblExtension.Text = employeeFile.ReadLine()
        lblEmailAddress.Text = employeeFile.ReadLine()
        lblRecordNumber.Text = recordNumber

        If lblFirstName.Text = "" Then
            MessageBox.Show("The end of the file is encountered")
        End If


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        employeeFile.Close()
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblFirstName.Text = ""
        lblMiddleName.Text = ""
        lblLastName.Text = ""
        lblEmployeeNumber.Text = ""
        lblDepartment.Text = ""
        lblTelephone.Text = ""
        lblExtension.Text = ""
        lblEmailAddress.Text = ""
        lblRecordNumber.Text = ""
    End Sub
End Class
