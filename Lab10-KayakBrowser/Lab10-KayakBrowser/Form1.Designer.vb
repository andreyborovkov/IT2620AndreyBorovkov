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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lstKayakTypes = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.KayaksDataSet = New Lab10_KayakBrowser.KayaksDataSet()
        Me.KayakTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KayakTypesTableAdapter = New Lab10_KayakBrowser.KayaksDataSetTableAdapters.KayakTypesTableAdapter()
        Me.TableAdapterManager = New Lab10_KayakBrowser.KayaksDataSetTableAdapters.TableAdapterManager()
        Me.KayakTypesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.KayakTypesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.KayaksDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KayakTypesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.KayaksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayakTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayakTypesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KayakTypesBindingNavigator.SuspendLayout()
        CType(Me.KayaksDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayakTypesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstKayakTypes
        '
        Me.lstKayakTypes.DataSource = Me.KayakTypesBindingSource1
        Me.lstKayakTypes.DisplayMember = "Name"
        Me.lstKayakTypes.FormattingEnabled = True
        Me.lstKayakTypes.ItemHeight = 16
        Me.lstKayakTypes.Location = New System.Drawing.Point(29, 86)
        Me.lstKayakTypes.Name = "lstKayakTypes"
        Me.lstKayakTypes.Size = New System.Drawing.Size(218, 148)
        Me.lstKayakTypes.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KayakTypesBindingSource1, "Description", True))
        Me.Label1.Location = New System.Drawing.Point(286, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(481, 148)
        Me.Label1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Select a kayak to view a description"
        '
        'KayaksDataSet
        '
        Me.KayaksDataSet.DataSetName = "KayaksDataSet"
        Me.KayaksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KayakTypesBindingSource
        '
        Me.KayakTypesBindingSource.DataMember = "KayakTypes"
        Me.KayakTypesBindingSource.DataSource = Me.KayaksDataSet
        '
        'KayakTypesTableAdapter
        '
        Me.KayakTypesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.KayakTypesTableAdapter = Me.KayakTypesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Lab10_KayakBrowser.KayaksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'KayakTypesBindingNavigator
        '
        Me.KayakTypesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.KayakTypesBindingNavigator.BindingSource = Me.KayakTypesBindingSource
        Me.KayakTypesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.KayakTypesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.KayakTypesBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.KayakTypesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.KayakTypesBindingNavigatorSaveItem})
        Me.KayakTypesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.KayakTypesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.KayakTypesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.KayakTypesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.KayakTypesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.KayakTypesBindingNavigator.Name = "KayakTypesBindingNavigator"
        Me.KayakTypesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.KayakTypesBindingNavigator.Size = New System.Drawing.Size(803, 27)
        Me.KayakTypesBindingNavigator.TabIndex = 3
        Me.KayakTypesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'KayakTypesBindingNavigatorSaveItem
        '
        Me.KayakTypesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.KayakTypesBindingNavigatorSaveItem.Image = CType(resources.GetObject("KayakTypesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.KayakTypesBindingNavigatorSaveItem.Name = "KayakTypesBindingNavigatorSaveItem"
        Me.KayakTypesBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.KayakTypesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'KayaksDataSetBindingSource
        '
        Me.KayaksDataSetBindingSource.DataSource = Me.KayaksDataSet
        Me.KayaksDataSetBindingSource.Position = 0
        '
        'KayakTypesBindingSource1
        '
        Me.KayakTypesBindingSource1.DataMember = "KayakTypes"
        Me.KayakTypesBindingSource1.DataSource = Me.KayaksDataSet
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 277)
        Me.Controls.Add(Me.KayakTypesBindingNavigator)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstKayakTypes)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.KayaksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayakTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayakTypesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KayakTypesBindingNavigator.ResumeLayout(False)
        Me.KayakTypesBindingNavigator.PerformLayout()
        CType(Me.KayaksDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayakTypesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstKayakTypes As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents KayaksDataSet As KayaksDataSet
    Friend WithEvents KayakTypesBindingSource As BindingSource
    Friend WithEvents KayakTypesTableAdapter As KayaksDataSetTableAdapters.KayakTypesTableAdapter
    Friend WithEvents TableAdapterManager As KayaksDataSetTableAdapters.TableAdapterManager
    Friend WithEvents KayakTypesBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents KayakTypesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents KayaksDataSetBindingSource As BindingSource
    Friend WithEvents KayakTypesBindingSource1 As BindingSource
End Class
