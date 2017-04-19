<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AudioBooksOptionsForm
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAddAudioBook = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListBoxAudioBooksSelected = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(319, 260)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(136, 57)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAddAudioBook
        '
        Me.btnAddAudioBook.Location = New System.Drawing.Point(125, 260)
        Me.btnAddAudioBook.Name = "btnAddAudioBook"
        Me.btnAddAudioBook.Size = New System.Drawing.Size(175, 57)
        Me.btnAddAudioBook.TabIndex = 4
        Me.btnAddAudioBook.Text = "Add Book to Cart"
        Me.btnAddAudioBook.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBoxAudioBooksSelected)
        Me.GroupBox1.Location = New System.Drawing.Point(66, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(471, 206)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select an Audio Book"
        '
        'ListBoxAudioBooksSelected
        '
        Me.ListBoxAudioBooksSelected.FormattingEnabled = True
        Me.ListBoxAudioBooksSelected.ItemHeight = 16
        Me.ListBoxAudioBooksSelected.Items.AddRange(New Object() {"Learn Calculus in One Day (Audio)", "Relaxation Techniques (Audio)", "The History of Scotland (Audio)", "The Science of Body Language (Audio)"})
        Me.ListBoxAudioBooksSelected.Location = New System.Drawing.Point(29, 32)
        Me.ListBoxAudioBooksSelected.Name = "ListBoxAudioBooksSelected"
        Me.ListBoxAudioBooksSelected.Size = New System.Drawing.Size(416, 132)
        Me.ListBoxAudioBooksSelected.TabIndex = 0
        '
        'AudioBooksOptionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 368)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddAudioBook)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AudioBooksOptionsForm"
        Me.Text = "Audio Books"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnAddAudioBook As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListBoxAudioBooksSelected As ListBox
End Class
