<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnEnterNumbers = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnEnterNumbers
        '
        Me.BtnEnterNumbers.Location = New System.Drawing.Point(74, 50)
        Me.BtnEnterNumbers.Name = "BtnEnterNumbers"
        Me.BtnEnterNumbers.Size = New System.Drawing.Size(143, 72)
        Me.BtnEnterNumbers.TabIndex = 0
        Me.BtnEnterNumbers.Text = "Enter Numbers"
        Me.BtnEnterNumbers.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(248, 50)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(143, 72)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 186)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.BtnEnterNumbers)
        Me.Name = "Form1"
        Me.Text = "Sum of Numbers"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnEnterNumbers As Button
    Friend WithEvents btnExit As Button

    Private Sub btnEnterNumbers_Click(sender As Object, e As EventArgs) Handles BtnEnterNumbers.Click
        Dim strUserInput As String
        Dim intCount As Integer
        Dim intInputNumber As Integer
        Dim intTotal As Integer

        Try
            strUserInput = InputBox("Enter a positive integer value", "Input Needed", "10")
            intInputNumber = CInt(strUserInput)

            If Integer.TryParse(strUserInput, intInputNumber) And intInputNumber > 0 Then
                For intCount = 1 To intInputNumber
                    intTotal += intCount
                Next

                MessageBox.Show("The sum of numbers 1 through " & intInputNumber & " is " & intTotal)
            Else
                MessageBox.Show("Invalid Input")
            End If
        Catch
            MessageBox.Show("Invalid Input")
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
