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
        Me.btnVA = New System.Windows.Forms.Button()
        Me.btnNC = New System.Windows.Forms.Button()
        Me.btnSC = New System.Windows.Forms.Button()
        Me.btnGA = New System.Windows.Forms.Button()
        Me.AL = New System.Windows.Forms.Button()
        Me.btnFL = New System.Windows.Forms.Button()
        Me.lblVA = New System.Windows.Forms.Label()
        Me.lblNC = New System.Windows.Forms.Label()
        Me.lblSC = New System.Windows.Forms.Label()
        Me.lblGA = New System.Windows.Forms.Label()
        Me.lblAL = New System.Windows.Forms.Label()
        Me.lblFL = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnVA
        '
        Me.btnVA.Location = New System.Drawing.Point(35, 12)
        Me.btnVA.Name = "btnVA"
        Me.btnVA.Size = New System.Drawing.Size(134, 41)
        Me.btnVA.TabIndex = 0
        Me.btnVA.Text = "Virginia"
        Me.btnVA.UseVisualStyleBackColor = True
        '
        'btnNC
        '
        Me.btnNC.Location = New System.Drawing.Point(35, 68)
        Me.btnNC.Name = "btnNC"
        Me.btnNC.Size = New System.Drawing.Size(134, 41)
        Me.btnNC.TabIndex = 1
        Me.btnNC.Text = "North Carolina"
        Me.btnNC.UseVisualStyleBackColor = True
        '
        'btnSC
        '
        Me.btnSC.Location = New System.Drawing.Point(35, 127)
        Me.btnSC.Name = "btnSC"
        Me.btnSC.Size = New System.Drawing.Size(134, 41)
        Me.btnSC.TabIndex = 2
        Me.btnSC.Text = "South Carolina"
        Me.btnSC.UseVisualStyleBackColor = True
        '
        'btnGA
        '
        Me.btnGA.Location = New System.Drawing.Point(35, 186)
        Me.btnGA.Name = "btnGA"
        Me.btnGA.Size = New System.Drawing.Size(134, 41)
        Me.btnGA.TabIndex = 3
        Me.btnGA.Text = "Georgia"
        Me.btnGA.UseVisualStyleBackColor = True
        '
        'AL
        '
        Me.AL.Location = New System.Drawing.Point(35, 248)
        Me.AL.Name = "AL"
        Me.AL.Size = New System.Drawing.Size(134, 41)
        Me.AL.TabIndex = 4
        Me.AL.Text = "Alabama"
        Me.AL.UseVisualStyleBackColor = True
        '
        'btnFL
        '
        Me.btnFL.Location = New System.Drawing.Point(35, 308)
        Me.btnFL.Name = "btnFL"
        Me.btnFL.Size = New System.Drawing.Size(134, 41)
        Me.btnFL.TabIndex = 5
        Me.btnFL.Text = "Florida"
        Me.btnFL.UseVisualStyleBackColor = True
        '
        'lblVA
        '
        Me.lblVA.AutoSize = True
        Me.lblVA.Location = New System.Drawing.Point(210, 24)
        Me.lblVA.Name = "lblVA"
        Me.lblVA.Size = New System.Drawing.Size(0, 17)
        Me.lblVA.TabIndex = 6
        '
        'lblNC
        '
        Me.lblNC.AutoSize = True
        Me.lblNC.Location = New System.Drawing.Point(210, 80)
        Me.lblNC.Name = "lblNC"
        Me.lblNC.Size = New System.Drawing.Size(0, 17)
        Me.lblNC.TabIndex = 7
        '
        'lblSC
        '
        Me.lblSC.AutoSize = True
        Me.lblSC.Location = New System.Drawing.Point(210, 139)
        Me.lblSC.Name = "lblSC"
        Me.lblSC.Size = New System.Drawing.Size(0, 17)
        Me.lblSC.TabIndex = 8
        '
        'lblGA
        '
        Me.lblGA.AutoSize = True
        Me.lblGA.Location = New System.Drawing.Point(210, 198)
        Me.lblGA.Name = "lblGA"
        Me.lblGA.Size = New System.Drawing.Size(0, 17)
        Me.lblGA.TabIndex = 9
        '
        'lblAL
        '
        Me.lblAL.AutoSize = True
        Me.lblAL.Location = New System.Drawing.Point(210, 260)
        Me.lblAL.Name = "lblAL"
        Me.lblAL.Size = New System.Drawing.Size(0, 17)
        Me.lblAL.TabIndex = 10
        '
        'lblFL
        '
        Me.lblFL.AutoSize = True
        Me.lblFL.Location = New System.Drawing.Point(210, 320)
        Me.lblFL.Name = "lblFL"
        Me.lblFL.Size = New System.Drawing.Size(0, 17)
        Me.lblFL.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 506)
        Me.Controls.Add(Me.lblFL)
        Me.Controls.Add(Me.lblAL)
        Me.Controls.Add(Me.lblGA)
        Me.Controls.Add(Me.lblSC)
        Me.Controls.Add(Me.lblNC)
        Me.Controls.Add(Me.lblVA)
        Me.Controls.Add(Me.btnFL)
        Me.Controls.Add(Me.AL)
        Me.Controls.Add(Me.btnGA)
        Me.Controls.Add(Me.btnSC)
        Me.Controls.Add(Me.btnNC)
        Me.Controls.Add(Me.btnVA)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVA As Button
    Friend WithEvents btnNC As Button
    Friend WithEvents btnSC As Button
    Friend WithEvents btnGA As Button
    Friend WithEvents AL As Button
    Friend WithEvents btnFL As Button
    Friend WithEvents lblVA As Label
    Friend WithEvents lblNC As Label
    Friend WithEvents lblSC As Label
    Friend WithEvents lblGA As Label
    Friend WithEvents lblAL As Label
    Friend WithEvents lblFL As Label
End Class
