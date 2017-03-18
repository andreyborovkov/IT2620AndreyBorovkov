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
        Me.lblInstruction1 = New System.Windows.Forms.Label()
        Me.lblInstruction2 = New System.Windows.Forms.Label()
        Me.lblInstruction3 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtMarkupPercentage = New System.Windows.Forms.TextBox()
        Me.txtWholesaleCost = New System.Windows.Forms.TextBox()
        Me.btnGetRetail = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblInstruction1
        '
        Me.lblInstruction1.AutoSize = True
        Me.lblInstruction1.Location = New System.Drawing.Point(67, 39)
        Me.lblInstruction1.Name = "lblInstruction1"
        Me.lblInstruction1.Size = New System.Drawing.Size(152, 17)
        Me.lblInstruction1.TabIndex = 0
        Me.lblInstruction1.Text = "Wholesale Cost of Item"
        Me.lblInstruction1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblInstruction2
        '
        Me.lblInstruction2.AutoSize = True
        Me.lblInstruction2.Location = New System.Drawing.Point(148, 77)
        Me.lblInstruction2.Name = "lblInstruction2"
        Me.lblInstruction2.Size = New System.Drawing.Size(71, 17)
        Me.lblInstruction2.TabIndex = 1
        Me.lblInstruction2.Text = "Markup %"
        Me.lblInstruction2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblInstruction3
        '
        Me.lblInstruction3.AutoSize = True
        Me.lblInstruction3.Location = New System.Drawing.Point(139, 112)
        Me.lblInstruction3.Name = "lblInstruction3"
        Me.lblInstruction3.Size = New System.Drawing.Size(80, 17)
        Me.lblInstruction3.TabIndex = 2
        Me.lblInstruction3.Text = "Retail Price"
        Me.lblInstruction3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(247, 112)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(74, 22)
        Me.lblResult.TabIndex = 3
        '
        'txtMarkupPercentage
        '
        Me.txtMarkupPercentage.Location = New System.Drawing.Point(247, 71)
        Me.txtMarkupPercentage.Multiline = True
        Me.txtMarkupPercentage.Name = "txtMarkupPercentage"
        Me.txtMarkupPercentage.Size = New System.Drawing.Size(74, 22)
        Me.txtMarkupPercentage.TabIndex = 4
        '
        'txtWholesaleCost
        '
        Me.txtWholesaleCost.Location = New System.Drawing.Point(247, 36)
        Me.txtWholesaleCost.Multiline = True
        Me.txtWholesaleCost.Name = "txtWholesaleCost"
        Me.txtWholesaleCost.Size = New System.Drawing.Size(74, 22)
        Me.txtWholesaleCost.TabIndex = 5
        '
        'btnGetRetail
        '
        Me.btnGetRetail.Location = New System.Drawing.Point(70, 162)
        Me.btnGetRetail.Name = "btnGetRetail"
        Me.btnGetRetail.Size = New System.Drawing.Size(116, 47)
        Me.btnGetRetail.TabIndex = 6
        Me.btnGetRetail.Text = "Get Retail"
        Me.btnGetRetail.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(205, 162)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(116, 47)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.AllowDrop = True
        Me.lblMessage.AutoSize = True
        Me.lblMessage.ForeColor = System.Drawing.Color.Maroon
        Me.lblMessage.Location = New System.Drawing.Point(12, 219)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(0, 17)
        Me.lblMessage.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 245)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGetRetail)
        Me.Controls.Add(Me.txtWholesaleCost)
        Me.Controls.Add(Me.txtMarkupPercentage)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblInstruction3)
        Me.Controls.Add(Me.lblInstruction2)
        Me.Controls.Add(Me.lblInstruction1)
        Me.Name = "Form1"
        Me.Text = "Retail Price Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInstruction1 As Label
    Friend WithEvents lblInstruction2 As Label
    Friend WithEvents lblInstruction3 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents txtMarkupPercentage As TextBox
    Friend WithEvents txtWholesaleCost As TextBox
    Friend WithEvents btnGetRetail As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblMessage As Label
End Class
