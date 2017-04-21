<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblNumbers = New System.Windows.Forms.Label()
        Me.btnExample = New System.Windows.Forms.Button()
        Me.lblMedian = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNumbers
        '
        Me.lblNumbers.Location = New System.Drawing.Point(118, 102)
        Me.lblNumbers.Name = "lblNumbers"
        Me.lblNumbers.Size = New System.Drawing.Size(332, 23)
        Me.lblNumbers.TabIndex = 0
        '
        'btnExample
        '
        Me.btnExample.Location = New System.Drawing.Point(118, 197)
        Me.btnExample.Name = "btnExample"
        Me.btnExample.Size = New System.Drawing.Size(136, 41)
        Me.btnExample.TabIndex = 1
        Me.btnExample.Text = "Calculate"
        Me.btnExample.UseVisualStyleBackColor = True
        '
        'lblMedian
        '
        Me.lblMedian.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMedian.Location = New System.Drawing.Point(456, 209)
        Me.lblMedian.Name = "lblMedian"
        Me.lblMedian.Size = New System.Drawing.Size(102, 23)
        Me.lblMedian.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(115, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Randomly generated integer array:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(352, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Median Value:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 315)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMedian)
        Me.Controls.Add(Me.btnExample)
        Me.Controls.Add(Me.lblNumbers)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumbers As Label
    Friend WithEvents btnExample As Button
    Friend WithEvents lblMedian As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
