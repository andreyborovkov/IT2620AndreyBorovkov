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
        Me.SuspendLayout()
        '
        'lblNumbers
        '
        Me.lblNumbers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumbers.Location = New System.Drawing.Point(118, 58)
        Me.lblNumbers.Name = "lblNumbers"
        Me.lblNumbers.Size = New System.Drawing.Size(332, 23)
        Me.lblNumbers.TabIndex = 0
        '
        'btnExample
        '
        Me.btnExample.Location = New System.Drawing.Point(214, 180)
        Me.btnExample.Name = "btnExample"
        Me.btnExample.Size = New System.Drawing.Size(166, 79)
        Me.btnExample.TabIndex = 1
        Me.btnExample.Text = "Button1"
        Me.btnExample.UseVisualStyleBackColor = True
        '
        'lblMedian
        '
        Me.lblMedian.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMedian.Location = New System.Drawing.Point(118, 105)
        Me.lblMedian.Name = "lblMedian"
        Me.lblMedian.Size = New System.Drawing.Size(332, 23)
        Me.lblMedian.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 315)
        Me.Controls.Add(Me.lblMedian)
        Me.Controls.Add(Me.btnExample)
        Me.Controls.Add(Me.lblNumbers)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblNumbers As Label
    Friend WithEvents btnExample As Button
    Friend WithEvents lblMedian As Label
End Class
