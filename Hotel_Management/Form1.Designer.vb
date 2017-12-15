<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Customer
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
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim Valid_IdentificationLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Middle_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim Phone_NumberLabel As System.Windows.Forms.Label
        Dim Email_AddressLabel As System.Windows.Forms.Label
        Dim Home_Address_Line_1Label As System.Windows.Forms.Label
        Dim Home_Address_Line_2Label As System.Windows.Forms.Label
        Dim Room_NumberLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Customer))
        Me.Hotel_ManagementDataSet = New Hotel_Management.Hotel_ManagementDataSet()
        Me.Customer_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Customer_DetailsTableAdapter = New Hotel_Management.Hotel_ManagementDataSetTableAdapters.Customer_DetailsTableAdapter()
        Me.TableAdapterManager = New Hotel_Management.Hotel_ManagementDataSetTableAdapters.TableAdapterManager()
        Me.Customer_DetailsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Customer_DetailsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.Valid_IdentificationTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Middle_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Email_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Home_Address_Line_1TextBox = New System.Windows.Forms.TextBox()
        Me.Home_Address_Line_2TextBox = New System.Windows.Forms.TextBox()
        Me.Room_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.btn_htrmf = New System.Windows.Forms.Button()
        Me.lnklbl_Signout = New System.Windows.Forms.LinkLabel()
        Me.btn_Close = New System.Windows.Forms.Button()
        CustomerIDLabel = New System.Windows.Forms.Label()
        Valid_IdentificationLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Middle_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        Phone_NumberLabel = New System.Windows.Forms.Label()
        Email_AddressLabel = New System.Windows.Forms.Label()
        Home_Address_Line_1Label = New System.Windows.Forms.Label()
        Home_Address_Line_2Label = New System.Windows.Forms.Label()
        Room_NumberLabel = New System.Windows.Forms.Label()
        CType(Me.Hotel_ManagementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customer_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customer_DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Customer_DetailsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(12, 35)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(68, 13)
        CustomerIDLabel.TabIndex = 1
        CustomerIDLabel.Text = "Customer ID:"
        '
        'Valid_IdentificationLabel
        '
        Valid_IdentificationLabel.AutoSize = True
        Valid_IdentificationLabel.Location = New System.Drawing.Point(12, 61)
        Valid_IdentificationLabel.Name = "Valid_IdentificationLabel"
        Valid_IdentificationLabel.Size = New System.Drawing.Size(99, 17)
        Valid_IdentificationLabel.TabIndex = 3
        Valid_IdentificationLabel.Text = "Valid Identification:"
        Valid_IdentificationLabel.UseCompatibleTextRendering = True
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(12, 87)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(60, 13)
        First_NameLabel.TabIndex = 5
        First_NameLabel.Text = "First Name:"
        '
        'Middle_NameLabel
        '
        Middle_NameLabel.AutoSize = True
        Middle_NameLabel.Location = New System.Drawing.Point(12, 113)
        Middle_NameLabel.Name = "Middle_NameLabel"
        Middle_NameLabel.Size = New System.Drawing.Size(72, 13)
        Middle_NameLabel.TabIndex = 7
        Middle_NameLabel.Text = "Middle Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(12, 139)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(61, 13)
        Last_NameLabel.TabIndex = 9
        Last_NameLabel.Text = "Last Name:"
        '
        'Phone_NumberLabel
        '
        Phone_NumberLabel.AutoSize = True
        Phone_NumberLabel.Location = New System.Drawing.Point(12, 165)
        Phone_NumberLabel.Name = "Phone_NumberLabel"
        Phone_NumberLabel.Size = New System.Drawing.Size(81, 13)
        Phone_NumberLabel.TabIndex = 11
        Phone_NumberLabel.Text = "Phone Number:"
        '
        'Email_AddressLabel
        '
        Email_AddressLabel.AutoSize = True
        Email_AddressLabel.Location = New System.Drawing.Point(12, 191)
        Email_AddressLabel.Name = "Email_AddressLabel"
        Email_AddressLabel.Size = New System.Drawing.Size(76, 13)
        Email_AddressLabel.TabIndex = 13
        Email_AddressLabel.Text = "Email Address:"
        '
        'Home_Address_Line_1Label
        '
        Home_Address_Line_1Label.AutoSize = True
        Home_Address_Line_1Label.Location = New System.Drawing.Point(12, 217)
        Home_Address_Line_1Label.Name = "Home_Address_Line_1Label"
        Home_Address_Line_1Label.Size = New System.Drawing.Size(111, 13)
        Home_Address_Line_1Label.TabIndex = 15
        Home_Address_Line_1Label.Text = "Home Address Line 1:"
        '
        'Home_Address_Line_2Label
        '
        Home_Address_Line_2Label.AutoSize = True
        Home_Address_Line_2Label.Location = New System.Drawing.Point(12, 243)
        Home_Address_Line_2Label.Name = "Home_Address_Line_2Label"
        Home_Address_Line_2Label.Size = New System.Drawing.Size(111, 13)
        Home_Address_Line_2Label.TabIndex = 17
        Home_Address_Line_2Label.Text = "Home Address Line 2:"
        '
        'Room_NumberLabel
        '
        Room_NumberLabel.AutoSize = True
        Room_NumberLabel.Location = New System.Drawing.Point(12, 269)
        Room_NumberLabel.Name = "Room_NumberLabel"
        Room_NumberLabel.Size = New System.Drawing.Size(78, 13)
        Room_NumberLabel.TabIndex = 19
        Room_NumberLabel.Text = "Room Number:"
        '
        'Hotel_ManagementDataSet
        '
        Me.Hotel_ManagementDataSet.DataSetName = "Hotel_ManagementDataSet"
        Me.Hotel_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Customer_DetailsBindingSource
        '
        Me.Customer_DetailsBindingSource.DataMember = "Customer Details"
        Me.Customer_DetailsBindingSource.DataSource = Me.Hotel_ManagementDataSet
        '
        'Customer_DetailsTableAdapter
        '
        Me.Customer_DetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Customer_DetailsTableAdapter = Me.Customer_DetailsTableAdapter
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.Hotel_Room_FacilitiesTableAdapter = Nothing
        Me.TableAdapterManager.Hotel_RoomsTableAdapter = Nothing
        Me.TableAdapterManager.PaymentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Hotel_Management.Hotel_ManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Customer_DetailsBindingNavigator
        '
        Me.Customer_DetailsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Customer_DetailsBindingNavigator.BindingSource = Me.Customer_DetailsBindingSource
        Me.Customer_DetailsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Customer_DetailsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Customer_DetailsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Customer_DetailsBindingNavigatorSaveItem})
        Me.Customer_DetailsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Customer_DetailsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Customer_DetailsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Customer_DetailsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Customer_DetailsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Customer_DetailsBindingNavigator.Name = "Customer_DetailsBindingNavigator"
        Me.Customer_DetailsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Customer_DetailsBindingNavigator.Size = New System.Drawing.Size(398, 25)
        Me.Customer_DetailsBindingNavigator.TabIndex = 0
        Me.Customer_DetailsBindingNavigator.Text = "BindingNavigator1"
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
        'Customer_DetailsBindingNavigatorSaveItem
        '
        Me.Customer_DetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Customer_DetailsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Customer_DetailsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Customer_DetailsBindingNavigatorSaveItem.Name = "Customer_DetailsBindingNavigatorSaveItem"
        Me.Customer_DetailsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Customer_DetailsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_DetailsBindingSource, "CustomerID", True))
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(129, 32)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(145, 20)
        Me.CustomerIDTextBox.TabIndex = 2
        '
        'Valid_IdentificationTextBox
        '
        Me.Valid_IdentificationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_DetailsBindingSource, "Valid_Identification", True))
        Me.Valid_IdentificationTextBox.Location = New System.Drawing.Point(129, 58)
        Me.Valid_IdentificationTextBox.Name = "Valid_IdentificationTextBox"
        Me.Valid_IdentificationTextBox.Size = New System.Drawing.Size(145, 20)
        Me.Valid_IdentificationTextBox.TabIndex = 4
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_DetailsBindingSource, "First_Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(129, 84)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(145, 20)
        Me.First_NameTextBox.TabIndex = 6
        '
        'Middle_NameTextBox
        '
        Me.Middle_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_DetailsBindingSource, "Middle_Name", True))
        Me.Middle_NameTextBox.Location = New System.Drawing.Point(129, 110)
        Me.Middle_NameTextBox.Name = "Middle_NameTextBox"
        Me.Middle_NameTextBox.Size = New System.Drawing.Size(145, 20)
        Me.Middle_NameTextBox.TabIndex = 8
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_DetailsBindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(129, 136)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(145, 20)
        Me.Last_NameTextBox.TabIndex = 10
        '
        'Phone_NumberTextBox
        '
        Me.Phone_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_DetailsBindingSource, "Phone_Number", True))
        Me.Phone_NumberTextBox.Location = New System.Drawing.Point(129, 162)
        Me.Phone_NumberTextBox.Name = "Phone_NumberTextBox"
        Me.Phone_NumberTextBox.Size = New System.Drawing.Size(176, 20)
        Me.Phone_NumberTextBox.TabIndex = 12
        '
        'Email_AddressTextBox
        '
        Me.Email_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_DetailsBindingSource, "Email_Address", True))
        Me.Email_AddressTextBox.Location = New System.Drawing.Point(129, 188)
        Me.Email_AddressTextBox.Name = "Email_AddressTextBox"
        Me.Email_AddressTextBox.Size = New System.Drawing.Size(176, 20)
        Me.Email_AddressTextBox.TabIndex = 14
        '
        'Home_Address_Line_1TextBox
        '
        Me.Home_Address_Line_1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_DetailsBindingSource, "Home Address Line 1", True))
        Me.Home_Address_Line_1TextBox.Location = New System.Drawing.Point(129, 214)
        Me.Home_Address_Line_1TextBox.Name = "Home_Address_Line_1TextBox"
        Me.Home_Address_Line_1TextBox.Size = New System.Drawing.Size(257, 20)
        Me.Home_Address_Line_1TextBox.TabIndex = 16
        '
        'Home_Address_Line_2TextBox
        '
        Me.Home_Address_Line_2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_DetailsBindingSource, "Home Address Line 2", True))
        Me.Home_Address_Line_2TextBox.Location = New System.Drawing.Point(129, 240)
        Me.Home_Address_Line_2TextBox.Name = "Home_Address_Line_2TextBox"
        Me.Home_Address_Line_2TextBox.Size = New System.Drawing.Size(257, 20)
        Me.Home_Address_Line_2TextBox.TabIndex = 18
        '
        'Room_NumberTextBox
        '
        Me.Room_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_DetailsBindingSource, "Room_Number", True))
        Me.Room_NumberTextBox.Location = New System.Drawing.Point(129, 266)
        Me.Room_NumberTextBox.Name = "Room_NumberTextBox"
        Me.Room_NumberTextBox.Size = New System.Drawing.Size(41, 20)
        Me.Room_NumberTextBox.TabIndex = 20
        '
        'btn_htrmf
        '
        Me.btn_htrmf.Location = New System.Drawing.Point(256, 292)
        Me.btn_htrmf.Name = "btn_htrmf"
        Me.btn_htrmf.Size = New System.Drawing.Size(130, 23)
        Me.btn_htrmf.TabIndex = 22
        Me.btn_htrmf.Text = "Hotel Room Facilties"
        Me.btn_htrmf.UseVisualStyleBackColor = True
        '
        'lnklbl_Signout
        '
        Me.lnklbl_Signout.AutoSize = True
        Me.lnklbl_Signout.Location = New System.Drawing.Point(327, 29)
        Me.lnklbl_Signout.Name = "lnklbl_Signout"
        Me.lnklbl_Signout.Size = New System.Drawing.Size(48, 13)
        Me.lnklbl_Signout.TabIndex = 23
        Me.lnklbl_Signout.TabStop = True
        Me.lnklbl_Signout.Text = "Sign Out"
        '
        'btn_Close
        '
        Me.btn_Close.Location = New System.Drawing.Point(12, 292)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(75, 23)
        Me.btn_Close.TabIndex = 24
        Me.btn_Close.Text = "Close"
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'Frm_Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(398, 327)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.lnklbl_Signout)
        Me.Controls.Add(Me.btn_htrmf)
        Me.Controls.Add(CustomerIDLabel)
        Me.Controls.Add(Me.CustomerIDTextBox)
        Me.Controls.Add(Valid_IdentificationLabel)
        Me.Controls.Add(Me.Valid_IdentificationTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Middle_NameLabel)
        Me.Controls.Add(Me.Middle_NameTextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(Phone_NumberLabel)
        Me.Controls.Add(Me.Phone_NumberTextBox)
        Me.Controls.Add(Email_AddressLabel)
        Me.Controls.Add(Me.Email_AddressTextBox)
        Me.Controls.Add(Home_Address_Line_1Label)
        Me.Controls.Add(Me.Home_Address_Line_1TextBox)
        Me.Controls.Add(Home_Address_Line_2Label)
        Me.Controls.Add(Me.Home_Address_Line_2TextBox)
        Me.Controls.Add(Room_NumberLabel)
        Me.Controls.Add(Me.Room_NumberTextBox)
        Me.Controls.Add(Me.Customer_DetailsBindingNavigator)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Name = "Frm_Customer"
        Me.Text = "Customer Details"
        CType(Me.Hotel_ManagementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customer_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customer_DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Customer_DetailsBindingNavigator.ResumeLayout(False)
        Me.Customer_DetailsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Hotel_ManagementDataSet As Hotel_Management.Hotel_ManagementDataSet
    Friend WithEvents Customer_DetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Customer_DetailsTableAdapter As Hotel_Management.Hotel_ManagementDataSetTableAdapters.Customer_DetailsTableAdapter
    Friend WithEvents TableAdapterManager As Hotel_Management.Hotel_ManagementDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Customer_DetailsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Customer_DetailsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CustomerIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Valid_IdentificationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents First_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Middle_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Last_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Phone_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Email_AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Home_Address_Line_1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Home_Address_Line_2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Room_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btn_htrmf As System.Windows.Forms.Button
    Friend WithEvents lnklbl_Signout As System.Windows.Forms.LinkLabel
    Friend WithEvents btn_Close As System.Windows.Forms.Button

End Class
