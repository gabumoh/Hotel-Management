<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee))
        Dim EmployeeIdLabel As System.Windows.Forms.Label
        Dim Employee_NameLabel As System.Windows.Forms.Label
        Dim Employee_AddressLabel As System.Windows.Forms.Label
        Dim SocialSecNoLabel As System.Windows.Forms.Label
        Dim Employee_EmailLabel As System.Windows.Forms.Label
        Me.Hotel_ManagementDataSet = New Hotel_Management.Hotel_ManagementDataSet()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTableAdapter = New Hotel_Management.Hotel_ManagementDataSetTableAdapters.EmployeeTableAdapter()
        Me.TableAdapterManager = New Hotel_Management.Hotel_ManagementDataSetTableAdapters.TableAdapterManager()
        Me.EmployeeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EmployeeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Hotel_ManagementDataSet1 = New Hotel_Management.Hotel_ManagementDataSet1()
        Me.EmployeeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTableAdapter1 = New Hotel_Management.Hotel_ManagementDataSet1TableAdapters.EmployeeTableAdapter()
        Me.TableAdapterManager1 = New Hotel_Management.Hotel_ManagementDataSet1TableAdapters.TableAdapterManager()
        Me.EmployeeIdTextBox = New System.Windows.Forms.TextBox()
        Me.Employee_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Employee_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.SocialSecNoTextBox = New System.Windows.Forms.TextBox()
        Me.Employee_EmailTextBox = New System.Windows.Forms.TextBox()
        EmployeeIdLabel = New System.Windows.Forms.Label()
        Employee_NameLabel = New System.Windows.Forms.Label()
        Employee_AddressLabel = New System.Windows.Forms.Label()
        SocialSecNoLabel = New System.Windows.Forms.Label()
        Employee_EmailLabel = New System.Windows.Forms.Label()
        CType(Me.Hotel_ManagementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmployeeBindingNavigator.SuspendLayout()
        CType(Me.Hotel_ManagementDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Hotel_ManagementDataSet
        '
        Me.Hotel_ManagementDataSet.DataSetName = "Hotel_ManagementDataSet"
        Me.Hotel_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.Hotel_ManagementDataSet
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Customer_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Me.EmployeeTableAdapter
        Me.TableAdapterManager.Hotel_Room_FacilitiesTableAdapter = Nothing
        Me.TableAdapterManager.Hotel_RoomsTableAdapter = Nothing
        Me.TableAdapterManager.PaymentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Hotel_Management.Hotel_ManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmployeeBindingNavigator
        '
        Me.EmployeeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmployeeBindingNavigator.BindingSource = Me.EmployeeBindingSource
        Me.EmployeeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmployeeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmployeeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmployeeBindingNavigatorSaveItem})
        Me.EmployeeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmployeeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmployeeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmployeeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmployeeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmployeeBindingNavigator.Name = "EmployeeBindingNavigator"
        Me.EmployeeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmployeeBindingNavigator.Size = New System.Drawing.Size(295, 25)
        Me.EmployeeBindingNavigator.TabIndex = 0
        Me.EmployeeBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'EmployeeBindingNavigatorSaveItem
        '
        Me.EmployeeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmployeeBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmployeeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmployeeBindingNavigatorSaveItem.Name = "EmployeeBindingNavigatorSaveItem"
        Me.EmployeeBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EmployeeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Hotel_ManagementDataSet1
        '
        Me.Hotel_ManagementDataSet1.DataSetName = "Hotel_ManagementDataSet1"
        Me.Hotel_ManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeBindingSource1
        '
        Me.EmployeeBindingSource1.DataMember = "Employee"
        Me.EmployeeBindingSource1.DataSource = Me.Hotel_ManagementDataSet1
        '
        'EmployeeTableAdapter1
        '
        Me.EmployeeTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Customer_DetailsTableAdapter = Nothing
        Me.TableAdapterManager1.Employee_User_AccountsTableAdapter = Nothing
        Me.TableAdapterManager1.EmployeeTableAdapter = Me.EmployeeTableAdapter1
        Me.TableAdapterManager1.Hotel_Room_FacilitiesTableAdapter = Nothing
        Me.TableAdapterManager1.Hotel_RoomsTableAdapter = Nothing
        Me.TableAdapterManager1.PaymentTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = Hotel_Management.Hotel_ManagementDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmployeeIdLabel
        '
        EmployeeIdLabel.AutoSize = True
        EmployeeIdLabel.Location = New System.Drawing.Point(12, 51)
        EmployeeIdLabel.Name = "EmployeeIdLabel"
        EmployeeIdLabel.Size = New System.Drawing.Size(68, 13)
        EmployeeIdLabel.TabIndex = 1
        EmployeeIdLabel.Text = "Employee Id:"
        '
        'EmployeeIdTextBox
        '
        Me.EmployeeIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource1, "EmployeeId", True))
        Me.EmployeeIdTextBox.Location = New System.Drawing.Point(115, 48)
        Me.EmployeeIdTextBox.Name = "EmployeeIdTextBox"
        Me.EmployeeIdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmployeeIdTextBox.TabIndex = 2
        '
        'Employee_NameLabel
        '
        Employee_NameLabel.AutoSize = True
        Employee_NameLabel.Location = New System.Drawing.Point(12, 77)
        Employee_NameLabel.Name = "Employee_NameLabel"
        Employee_NameLabel.Size = New System.Drawing.Size(87, 13)
        Employee_NameLabel.TabIndex = 3
        Employee_NameLabel.Text = "Employee Name:"
        '
        'Employee_NameTextBox
        '
        Me.Employee_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource1, "Employee_Name", True))
        Me.Employee_NameTextBox.Location = New System.Drawing.Point(115, 74)
        Me.Employee_NameTextBox.Name = "Employee_NameTextBox"
        Me.Employee_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Employee_NameTextBox.TabIndex = 4
        '
        'Employee_AddressLabel
        '
        Employee_AddressLabel.AutoSize = True
        Employee_AddressLabel.Location = New System.Drawing.Point(12, 103)
        Employee_AddressLabel.Name = "Employee_AddressLabel"
        Employee_AddressLabel.Size = New System.Drawing.Size(97, 13)
        Employee_AddressLabel.TabIndex = 5
        Employee_AddressLabel.Text = "Employee Address:"
        '
        'Employee_AddressTextBox
        '
        Me.Employee_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource1, "Employee_Address", True))
        Me.Employee_AddressTextBox.Location = New System.Drawing.Point(115, 100)
        Me.Employee_AddressTextBox.Name = "Employee_AddressTextBox"
        Me.Employee_AddressTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Employee_AddressTextBox.TabIndex = 6
        '
        'SocialSecNoLabel
        '
        SocialSecNoLabel.AutoSize = True
        SocialSecNoLabel.Location = New System.Drawing.Point(12, 129)
        SocialSecNoLabel.Name = "SocialSecNoLabel"
        SocialSecNoLabel.Size = New System.Drawing.Size(78, 13)
        SocialSecNoLabel.TabIndex = 7
        SocialSecNoLabel.Text = "Social Sec No:"
        '
        'SocialSecNoTextBox
        '
        Me.SocialSecNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource1, "SocialSecNo", True))
        Me.SocialSecNoTextBox.Location = New System.Drawing.Point(115, 126)
        Me.SocialSecNoTextBox.Name = "SocialSecNoTextBox"
        Me.SocialSecNoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SocialSecNoTextBox.TabIndex = 8
        '
        'Employee_EmailLabel
        '
        Employee_EmailLabel.AutoSize = True
        Employee_EmailLabel.Location = New System.Drawing.Point(12, 155)
        Employee_EmailLabel.Name = "Employee_EmailLabel"
        Employee_EmailLabel.Size = New System.Drawing.Size(84, 13)
        Employee_EmailLabel.TabIndex = 9
        Employee_EmailLabel.Text = "Employee Email:"
        '
        'Employee_EmailTextBox
        '
        Me.Employee_EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource1, "Employee_Email", True))
        Me.Employee_EmailTextBox.Location = New System.Drawing.Point(115, 152)
        Me.Employee_EmailTextBox.Name = "Employee_EmailTextBox"
        Me.Employee_EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Employee_EmailTextBox.TabIndex = 10
        '
        'Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 206)
        Me.Controls.Add(EmployeeIdLabel)
        Me.Controls.Add(Me.EmployeeIdTextBox)
        Me.Controls.Add(Employee_NameLabel)
        Me.Controls.Add(Me.Employee_NameTextBox)
        Me.Controls.Add(Employee_AddressLabel)
        Me.Controls.Add(Me.Employee_AddressTextBox)
        Me.Controls.Add(SocialSecNoLabel)
        Me.Controls.Add(Me.SocialSecNoTextBox)
        Me.Controls.Add(Employee_EmailLabel)
        Me.Controls.Add(Me.Employee_EmailTextBox)
        Me.Controls.Add(Me.EmployeeBindingNavigator)
        Me.Name = "Employee"
        Me.Text = "Employee"
        CType(Me.Hotel_ManagementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmployeeBindingNavigator.ResumeLayout(False)
        Me.EmployeeBindingNavigator.PerformLayout()
        CType(Me.Hotel_ManagementDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Hotel_ManagementDataSet As Hotel_Management.Hotel_ManagementDataSet
    Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeTableAdapter As Hotel_Management.Hotel_ManagementDataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents TableAdapterManager As Hotel_Management.Hotel_ManagementDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmployeeBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EmployeeBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Hotel_ManagementDataSet1 As Hotel_Management.Hotel_ManagementDataSet1
    Friend WithEvents EmployeeBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeTableAdapter1 As Hotel_Management.Hotel_ManagementDataSet1TableAdapters.EmployeeTableAdapter
    Friend WithEvents TableAdapterManager1 As Hotel_Management.Hotel_ManagementDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents EmployeeIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Employee_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Employee_AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SocialSecNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Employee_EmailTextBox As System.Windows.Forms.TextBox
End Class
