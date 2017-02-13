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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureOne = New System.Windows.Forms.PictureBox()
        Me.PictureThree = New System.Windows.Forms.PictureBox()
        Me.PictureFour = New System.Windows.Forms.PictureBox()
        Me.PictureTwo = New System.Windows.Forms.PictureBox()
        Me.PictureFive = New System.Windows.Forms.PictureBox()
        CType(Me.PictureOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureThree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureFour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureFive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureOne
        '
        Me.PictureOne.Image = CType(resources.GetObject("PictureOne.Image"), System.Drawing.Image)
        Me.PictureOne.Location = New System.Drawing.Point(113, 49)
        Me.PictureOne.Name = "PictureOne"
        Me.PictureOne.Size = New System.Drawing.Size(80, 144)
        Me.PictureOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureOne.TabIndex = 0
        Me.PictureOne.TabStop = False
        '
        'PictureThree
        '
        Me.PictureThree.Image = CType(resources.GetObject("PictureThree.Image"), System.Drawing.Image)
        Me.PictureThree.Location = New System.Drawing.Point(381, 49)
        Me.PictureThree.Name = "PictureThree"
        Me.PictureThree.Size = New System.Drawing.Size(80, 144)
        Me.PictureThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureThree.TabIndex = 1
        Me.PictureThree.TabStop = False
        '
        'PictureFour
        '
        Me.PictureFour.Image = CType(resources.GetObject("PictureFour.Image"), System.Drawing.Image)
        Me.PictureFour.Location = New System.Drawing.Point(517, 49)
        Me.PictureFour.Name = "PictureFour"
        Me.PictureFour.Size = New System.Drawing.Size(80, 144)
        Me.PictureFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureFour.TabIndex = 2
        Me.PictureFour.TabStop = False
        '
        'PictureTwo
        '
        Me.PictureTwo.Image = CType(resources.GetObject("PictureTwo.Image"), System.Drawing.Image)
        Me.PictureTwo.Location = New System.Drawing.Point(246, 49)
        Me.PictureTwo.Name = "PictureTwo"
        Me.PictureTwo.Size = New System.Drawing.Size(80, 144)
        Me.PictureTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureTwo.TabIndex = 3
        Me.PictureTwo.TabStop = False
        '
        'PictureFive
        '
        Me.PictureFive.Image = CType(resources.GetObject("PictureFive.Image"), System.Drawing.Image)
        Me.PictureFive.Location = New System.Drawing.Point(655, 49)
        Me.PictureFive.Name = "PictureFive"
        Me.PictureFive.Size = New System.Drawing.Size(80, 144)
        Me.PictureFive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureFive.TabIndex = 4
        Me.PictureFive.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 446)
        Me.Controls.Add(Me.PictureFive)
        Me.Controls.Add(Me.PictureTwo)
        Me.Controls.Add(Me.PictureFour)
        Me.Controls.Add(Me.PictureThree)
        Me.Controls.Add(Me.PictureOne)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureThree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureFour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureFive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureOne As PictureBox
    Friend WithEvents PictureThree As PictureBox
    Friend WithEvents PictureFour As PictureBox
    Friend WithEvents PictureTwo As PictureBox
    Friend WithEvents PictureFive As PictureBox

    Private Sub PictureOne_Click(sender As Object, e As EventArgs) Handles PictureOne.Click
        MsgBox("One")
    End Sub


    Private Sub PictureTwo_Click(sender As Object, e As EventArgs) Handles PictureTwo.Click
        MsgBox("Two")
    End Sub

    Private Sub PictureThree_Click(sender As Object, e As EventArgs) Handles PictureThree.Click
        MsgBox("Three")
    End Sub

    Private Sub PictureFour_Click(sender As Object, e As EventArgs) Handles PictureFour.Click
        MsgBox("Four")
    End Sub

    Private Sub PictureFive_Click(sender As Object, e As EventArgs) Handles PictureFive.Click
        MsgBox("Five")
    End Sub
End Class
