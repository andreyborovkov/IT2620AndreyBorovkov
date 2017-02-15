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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.txtClassC = New System.Windows.Forms.TextBox()
        Me.txtClassB = New System.Windows.Forms.TextBox()
        Me.txtClassA = New System.Windows.Forms.TextBox()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl7 = New System.Windows.Forms.Label()
        Me.lblTotalRevenue = New System.Windows.Forms.Label()
        Me.lblClassC = New System.Windows.Forms.Label()
        Me.lblClassB = New System.Windows.Forms.Label()
        Me.lblClassA = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblInstructions)
        Me.GroupBox1.Controls.Add(Me.txtClassC)
        Me.GroupBox1.Controls.Add(Me.txtClassB)
        Me.GroupBox1.Controls.Add(Me.txtClassA)
        Me.GroupBox1.Controls.Add(Me.lbl3)
        Me.GroupBox1.Controls.Add(Me.lbl2)
        Me.GroupBox1.Controls.Add(Me.lbl1)
        Me.GroupBox1.Location = New System.Drawing.Point(51, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(276, 253)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tickets Sold"
        '
        'lblInstructions
        '
        Me.lblInstructions.Location = New System.Drawing.Point(48, 30)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(224, 37)
        Me.lblInstructions.TabIndex = 5
        Me.lblInstructions.Text = "Enter the number of tickets sold for each class of seats"
        '
        'txtClassC
        '
        Me.txtClassC.Location = New System.Drawing.Point(138, 208)
        Me.txtClassC.Name = "txtClassC"
        Me.txtClassC.Size = New System.Drawing.Size(100, 22)
        Me.txtClassC.TabIndex = 3
        '
        'txtClassB
        '
        Me.txtClassB.Location = New System.Drawing.Point(138, 149)
        Me.txtClassB.Name = "txtClassB"
        Me.txtClassB.Size = New System.Drawing.Size(100, 22)
        Me.txtClassB.TabIndex = 4
        '
        'txtClassA
        '
        Me.txtClassA.Location = New System.Drawing.Point(138, 90)
        Me.txtClassA.Name = "txtClassA"
        Me.txtClassA.Size = New System.Drawing.Size(100, 22)
        Me.txtClassA.TabIndex = 2
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(48, 213)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(59, 17)
        Me.lbl3.TabIndex = 3
        Me.lbl3.Text = "Class C:"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(48, 149)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(59, 17)
        Me.lbl2.TabIndex = 3
        Me.lbl2.Text = "Class B:"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(48, 90)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(59, 17)
        Me.lbl1.TabIndex = 2
        Me.lbl1.Text = "Class A:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl7)
        Me.GroupBox2.Controls.Add(Me.lblTotalRevenue)
        Me.GroupBox2.Controls.Add(Me.lblClassC)
        Me.GroupBox2.Controls.Add(Me.lblClassB)
        Me.GroupBox2.Controls.Add(Me.lblClassA)
        Me.GroupBox2.Controls.Add(Me.lbl6)
        Me.GroupBox2.Controls.Add(Me.lbl5)
        Me.GroupBox2.Controls.Add(Me.lbl4)
        Me.GroupBox2.Location = New System.Drawing.Point(355, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(287, 253)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Revenue Generated"
        '
        'lbl7
        '
        Me.lbl7.AutoSize = True
        Me.lbl7.Location = New System.Drawing.Point(24, 213)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(105, 17)
        Me.lbl7.TabIndex = 11
        Me.lbl7.Text = "Total Revenue:"
        '
        'lblTotalRevenue
        '
        Me.lblTotalRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalRevenue.Location = New System.Drawing.Point(153, 208)
        Me.lblTotalRevenue.Name = "lblTotalRevenue"
        Me.lblTotalRevenue.Size = New System.Drawing.Size(100, 22)
        Me.lblTotalRevenue.TabIndex = 10
        '
        'lblClassC
        '
        Me.lblClassC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassC.Location = New System.Drawing.Point(153, 152)
        Me.lblClassC.Name = "lblClassC"
        Me.lblClassC.Size = New System.Drawing.Size(100, 22)
        Me.lblClassC.TabIndex = 9
        '
        'lblClassB
        '
        Me.lblClassB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassB.Location = New System.Drawing.Point(153, 92)
        Me.lblClassB.Name = "lblClassB"
        Me.lblClassB.Size = New System.Drawing.Size(100, 22)
        Me.lblClassB.TabIndex = 8
        '
        'lblClassA
        '
        Me.lblClassA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassA.Location = New System.Drawing.Point(153, 30)
        Me.lblClassA.Name = "lblClassA"
        Me.lblClassA.Size = New System.Drawing.Size(100, 22)
        Me.lblClassA.TabIndex = 7
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Location = New System.Drawing.Point(70, 153)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(59, 17)
        Me.lbl6.TabIndex = 6
        Me.lbl6.Text = "Class C:"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Location = New System.Drawing.Point(70, 89)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(59, 17)
        Me.lbl5.TabIndex = 5
        Me.lbl5.Text = "Class B:"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Location = New System.Drawing.Point(70, 30)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(59, 17)
        Me.lbl4.TabIndex = 4
        Me.lbl4.Text = "Class A:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(156, 332)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(152, 37)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate Revenue"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(337, 332)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(99, 37)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(460, 332)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(81, 37)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 446)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblInstructions As Label
    Friend WithEvents txtClassC As TextBox
    Friend WithEvents txtClassB As TextBox
    Friend WithEvents txtClassA As TextBox
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblClassA As Label
    Friend WithEvents lbl6 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl7 As Label
    Friend WithEvents lblTotalRevenue As Label
    Friend WithEvents lblClassC As Label
    Friend WithEvents lblClassB As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Declare variables for the calculations
        Dim intClassA As Integer 'Class A tickets total
        Dim intClassB As Integer 'Class B tickets total
        Dim intClassC As Integer 'Class C tickets total
        Dim intTotalRevenue As Integer 'Total Revenue

        Try
            intClassA = CInt(txtClassA.Text) * 15 'One Class A ticket costs $15
            lblClassA.Text = intClassA.ToString("c")

            intClassB = CInt(txtClassB.Text) * 12 'One Class A ticket costs $12
            lblClassB.Text = intClassB.ToString("c")

            intClassC = CInt(txtClassC.Text) * 9 'One Class A ticket costs $9
            lblClassC.Text = intClassC.ToString("c")

            intTotalRevenue = intClassA + intClassB + intClassC
            lblTotalRevenue.Text = intTotalRevenue.ToString("c")

        Catch
            ' Error Message
            MessageBox.Show("All input must be valid numeric values")

        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtClassA.Clear()
        txtClassB.Clear()
        txtClassC.Clear()
        lblClassA.Text = String.Empty
        lblClassB.Text = String.Empty
        lblClassC.Text = String.Empty
        lblTotalRevenue.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
