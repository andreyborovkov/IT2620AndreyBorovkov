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
        Me.btnEnterNumbers = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEnterNumbers
        '
        Me.btnEnterNumbers.Location = New System.Drawing.Point(32, 70)
        Me.btnEnterNumbers.Name = "btnEnterNumbers"
        Me.btnEnterNumbers.Size = New System.Drawing.Size(130, 64)
        Me.btnEnterNumbers.TabIndex = 0
        Me.btnEnterNumbers.Text = "Enter Numbers"
        Me.btnEnterNumbers.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(216, 70)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(130, 64)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 207)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEnterNumbers)
        Me.Name = "Form1"
        Me.Text = "Sum of Numbers"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEnterNumbers As Button
    Friend WithEvents btnExit As Button
End Class
