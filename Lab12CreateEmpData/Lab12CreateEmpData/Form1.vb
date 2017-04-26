Imports System.IO

Public Module GlobalVariables
    Public employeeFile As StreamWriter
End Module


Public Class Form1
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strFilename As String
        strFilename = InputBox("Enter the filename.")

        Try
            'Open the file
            employeeFile = File.CreateText(strFilename)

        Catch
            MessageBox.Show("That file cannot be created")
        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtFirstName.Text = "" Or
            txtMiddleName.Text = "" Or
            txtLastName.Text = "" Or
            txtEmployeeNumber.Text = "" Or
            ComboBoxDepartment.SelectedIndex < 0 Or
            txtTelephone.Text = "" Or
            txtExtension.Text = "" Or
            txtEmailAddress.Text = "" Then
            MessageBox.Show("At least one field is empty.")
        Else 'Save data only if there is no empty fields.

            employeeFile.WriteLine(txtFirstName.Text)
            employeeFile.WriteLine(txtMiddleName.Text)
            employeeFile.WriteLine(txtLastName.Text)
            employeeFile.WriteLine(txtEmployeeNumber.Text)
            employeeFile.WriteLine(ComboBoxDepartment.SelectedItem.ToString())
            employeeFile.WriteLine(txtTelephone.Text)
            employeeFile.WriteLine(txtExtension.Text)
            employeeFile.WriteLine(txtEmailAddress.Text)
            MessageBox.Show("Record is saved.")
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        employeeFile.Close() 'The data will be saved only if the app closed with an exit button
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstName.Text = ""
        txtMiddleName.Text = ""
        txtLastName.Text = ""
        txtEmployeeNumber.Text = ""
        ComboBoxDepartment.SelectedIndex = -1
        txtTelephone.Text = ""
        txtExtension.Text = ""
        txtEmailAddress.Text = ""
    End Sub

End Class
