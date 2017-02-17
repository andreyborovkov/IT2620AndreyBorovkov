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
        Me.lblInstruction = New System.Windows.Forms.Label()
        Me.lblResultDescription = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInstruction
        '
        Me.lblInstruction.Location = New System.Drawing.Point(26, 68)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(154, 39)
        Me.lblInstruction.TabIndex = 0
        Me.lblInstruction.Text = "Enter a decimal integer in the range 1 - 10:"
        Me.lblInstruction.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblResultDescription
        '
        Me.lblResultDescription.Location = New System.Drawing.Point(26, 127)
        Me.lblResultDescription.Name = "lblResultDescription"
        Me.lblResultDescription.Size = New System.Drawing.Size(154, 39)
        Me.lblResultDescription.TabIndex = 1
        Me.lblResultDescription.Text = "Equivalent Roman Numeral:"
        Me.lblResultDescription.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(210, 127)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(151, 28)
        Me.lblResult.TabIndex = 2
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(210, 68)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(151, 28)
        Me.txtInput.TabIndex = 3
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(71, 190)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(109, 39)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(197, 190)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(109, 39)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 281)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblResultDescription)
        Me.Controls.Add(Me.lblInstruction)
        Me.Name = "Form1"
        Me.Text = "Roman Numeral Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInstruction As Label
    Friend WithEvents lblResultDescription As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnExit As Button
End Class
