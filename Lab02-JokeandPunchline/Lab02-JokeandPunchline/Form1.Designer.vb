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
        Me.lblJoke = New System.Windows.Forms.Label()
        Me.BtnSetup = New System.Windows.Forms.Button()
        Me.BtnPunchLine = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblJoke
        '
        Me.lblJoke.AutoSize = True
        Me.lblJoke.Location = New System.Drawing.Point(154, 58)
        Me.lblJoke.Name = "lblJoke"
        Me.lblJoke.Size = New System.Drawing.Size(12, 17)
        Me.lblJoke.TabIndex = 0
        Me.lblJoke.Text = " "
        '
        'BtnSetup
        '
        Me.BtnSetup.Location = New System.Drawing.Point(126, 98)
        Me.BtnSetup.Name = "BtnSetup"
        Me.BtnSetup.Size = New System.Drawing.Size(124, 38)
        Me.BtnSetup.TabIndex = 2
        Me.BtnSetup.Text = "Setup"
        Me.BtnSetup.UseVisualStyleBackColor = True
        '
        'BtnPunchLine
        '
        Me.BtnPunchLine.Location = New System.Drawing.Point(283, 98)
        Me.BtnPunchLine.Name = "BtnPunchLine"
        Me.BtnPunchLine.Size = New System.Drawing.Size(124, 38)
        Me.BtnPunchLine.TabIndex = 3
        Me.BtnPunchLine.Text = "Punch Line"
        Me.BtnPunchLine.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 207)
        Me.Controls.Add(Me.BtnPunchLine)
        Me.Controls.Add(Me.BtnSetup)
        Me.Controls.Add(Me.lblJoke)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblJoke As Label
    Friend WithEvents BtnSetup As Button
    Friend WithEvents BtnPunchLine As Button
End Class
