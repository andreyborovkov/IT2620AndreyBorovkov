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
        Me.lblGallons = New System.Windows.Forms.Label()
        Me.lblMiles = New System.Windows.Forms.Label()
        Me.lblMPG = New System.Windows.Forms.Label()
        Me.txtGallons = New System.Windows.Forms.TextBox()
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.btnCalculateMPG = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblGallons
        '
        Me.lblGallons.Location = New System.Drawing.Point(44, 62)
        Me.lblGallons.Name = "lblGallons"
        Me.lblGallons.Size = New System.Drawing.Size(141, 40)
        Me.lblGallons.TabIndex = 0
        Me.lblGallons.Text = "Gallons of gas the car can hold:"
        '
        'lblMiles
        '
        Me.lblMiles.Location = New System.Drawing.Point(44, 126)
        Me.lblMiles.Name = "lblMiles"
        Me.lblMiles.Size = New System.Drawing.Size(131, 72)
        Me.lblMiles.TabIndex = 1
        Me.lblMiles.Text = "Number of miles it can be driven on a full tank:"
        '
        'lblMPG
        '
        Me.lblMPG.AutoSize = True
        Me.lblMPG.Location = New System.Drawing.Point(44, 213)
        Me.lblMPG.Name = "lblMPG"
        Me.lblMPG.Size = New System.Drawing.Size(111, 17)
        Me.lblMPG.TabIndex = 2
        Me.lblMPG.Text = "Miles per gallon:"
        '
        'txtGallons
        '
        Me.txtGallons.Location = New System.Drawing.Point(217, 62)
        Me.txtGallons.Multiline = True
        Me.txtGallons.Name = "txtGallons"
        Me.txtGallons.Size = New System.Drawing.Size(100, 27)
        Me.txtGallons.TabIndex = 3
        '
        'txtMiles
        '
        Me.txtMiles.Location = New System.Drawing.Point(217, 135)
        Me.txtMiles.Multiline = True
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(121, 27)
        Me.txtMiles.TabIndex = 4
        '
        'btnCalculateMPG
        '
        Me.btnCalculateMPG.Location = New System.Drawing.Point(32, 266)
        Me.btnCalculateMPG.Name = "btnCalculateMPG"
        Me.btnCalculateMPG.Size = New System.Drawing.Size(97, 59)
        Me.btnCalculateMPG.TabIndex = 6
        Me.btnCalculateMPG.Text = "Calculate MPG"
        Me.btnCalculateMPG.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(150, 266)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(97, 59)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(276, 266)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(97, 59)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(217, 212)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(121, 27)
        Me.lblResult.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 372)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateMPG)
        Me.Controls.Add(Me.txtMiles)
        Me.Controls.Add(Me.txtGallons)
        Me.Controls.Add(Me.lblMPG)
        Me.Controls.Add(Me.lblMiles)
        Me.Controls.Add(Me.lblGallons)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGallons As Label
    Friend WithEvents lblMiles As Label
    Friend WithEvents lblMPG As Label
    Friend WithEvents txtGallons As TextBox
    Friend WithEvents txtMiles As TextBox
    Friend WithEvents btnCalculateMPG As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button

    Private Sub btnCalculateMPG_Click(sender As Object, e As EventArgs) Handles btnCalculateMPG.Click
        ' Declare variables for the calculations.
        Dim decMPG As Decimal ' MPG

        Try
            'Calculate and display MPG.
            decMPG = CDec(txtMiles.Text) / CDec(txtGallons.Text)
            lblResult.Text = decMPG.ToString()
        Catch
            'Error message
            MessageBox.Show("All input must be valid numeric values.")
        End Try
    End Sub

    Friend WithEvents lblResult As Label

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the text boxes
        txtGallons.Clear()
        txtMiles.Clear()

        ' Clear the result
        lblResult.Text = String.Empty

        'Reset the focus to the first field
        txtGallons.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form
        Me.Close()
    End Sub
End Class
