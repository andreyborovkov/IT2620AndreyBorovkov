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
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.lblInstruction1 = New System.Windows.Forms.Label()
        Me.lblInstruction2 = New System.Windows.Forms.Label()
        Me.btnSignIn = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(173, 32)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(100, 22)
        Me.txtNewPassword.TabIndex = 0
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(173, 76)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(100, 22)
        Me.txtConfirmPassword.TabIndex = 1
        '
        'lblInstruction1
        '
        Me.lblInstruction1.Location = New System.Drawing.Point(49, 35)
        Me.lblInstruction1.Name = "lblInstruction1"
        Me.lblInstruction1.Size = New System.Drawing.Size(118, 22)
        Me.lblInstruction1.TabIndex = 2
        Me.lblInstruction1.Text = "New Password"
        '
        'lblInstruction2
        '
        Me.lblInstruction2.Location = New System.Drawing.Point(29, 79)
        Me.lblInstruction2.Name = "lblInstruction2"
        Me.lblInstruction2.Size = New System.Drawing.Size(138, 22)
        Me.lblInstruction2.TabIndex = 3
        Me.lblInstruction2.Text = "Confirm Password"
        '
        'btnSignIn
        '
        Me.btnSignIn.Location = New System.Drawing.Point(43, 124)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(113, 46)
        Me.btnSignIn.TabIndex = 4
        Me.btnSignIn.Text = "Sign In"
        Me.btnSignIn.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(173, 124)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(113, 46)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.ForeColor = System.Drawing.Color.Maroon
        Me.lblMessage.Location = New System.Drawing.Point(29, 180)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(0, 17)
        Me.lblMessage.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 247)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSignIn)
        Me.Controls.Add(Me.lblInstruction2)
        Me.Controls.Add(Me.lblInstruction1)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents lblInstruction1 As Label
    Friend WithEvents lblInstruction2 As Label
    Friend WithEvents btnSignIn As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblMessage As Label
End Class
