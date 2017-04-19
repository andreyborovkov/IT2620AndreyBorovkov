<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintBooksOptionsForm
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
        Me.ListBoxPrintBooksSelected = New System.Windows.Forms.ListBox()
        Me.btnAddPrintedBook = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBoxPrintBooksSelected)
        Me.GroupBox1.Location = New System.Drawing.Point(65, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(471, 206)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Print Book"
        '
        'ListBoxPrintBooksSelected
        '
        Me.ListBoxPrintBooksSelected.FormattingEnabled = True
        Me.ListBoxPrintBooksSelected.ItemHeight = 16
        Me.ListBoxPrintBooksSelected.Items.AddRange(New Object() {"I Did It Your Way (Print)", "The History of Scotland (Print)", "Learn Calculus in One Day (Print)", "Feel the Stress (Print)"})
        Me.ListBoxPrintBooksSelected.Location = New System.Drawing.Point(29, 32)
        Me.ListBoxPrintBooksSelected.Name = "ListBoxPrintBooksSelected"
        Me.ListBoxPrintBooksSelected.Size = New System.Drawing.Size(416, 132)
        Me.ListBoxPrintBooksSelected.TabIndex = 0
        '
        'btnAddPrintedBook
        '
        Me.btnAddPrintedBook.Location = New System.Drawing.Point(124, 260)
        Me.btnAddPrintedBook.Name = "btnAddPrintedBook"
        Me.btnAddPrintedBook.Size = New System.Drawing.Size(175, 57)
        Me.btnAddPrintedBook.TabIndex = 1
        Me.btnAddPrintedBook.Text = "Add Book to Cart"
        Me.btnAddPrintedBook.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(318, 260)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(136, 57)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'PrintBooksOptionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 372)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddPrintedBook)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PrintBooksOptionsForm"
        Me.Text = "Print Books"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListBoxPrintBooksSelected As ListBox
    Friend WithEvents btnAddPrintedBook As Button
    Friend WithEvents btnClose As Button
End Class
