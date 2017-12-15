<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hotel_Room_Facilities
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
        Dim Room_NumberLabel As System.Windows.Forms.Label
        Dim TelevisionLabel As System.Windows.Forms.Label
        Dim Sound_SystemLabel As System.Windows.Forms.Label
        Dim Type_Of_BedLabel As System.Windows.Forms.Label
        Dim ShowerLabel As System.Windows.Forms.Label
        Dim BathLabel As System.Windows.Forms.Label
        Dim A_C_TypeLabel As System.Windows.Forms.Label
        Dim Carpet_TypeLabel As System.Windows.Forms.Label
        Dim Heated_FloorLabel As System.Windows.Forms.Label
        Dim Ambient_LEDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hotel_Room_Facilities))
        Me.Hotel_ManagementDataSet = New Hotel_Management.Hotel_ManagementDataSet()
        Me.Hotel_Room_FacilitiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hotel_Room_FacilitiesTableAdapter = New Hotel_Management.Hotel_ManagementDataSetTableAdapters.Hotel_Room_FacilitiesTableAdapter()
        Me.TableAdapterManager = New Hotel_Management.Hotel_ManagementDataSetTableAdapters.TableAdapterManager()
        Me.Hotel_Room_FacilitiesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Hotel_Room_FacilitiesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Room_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.TelevisionCheckBox = New System.Windows.Forms.CheckBox()
        Me.Sound_SystemCheckBox = New System.Windows.Forms.CheckBox()
        Me.Type_Of_BedTextBox = New System.Windows.Forms.TextBox()
        Me.ShowerCheckBox = New System.Windows.Forms.CheckBox()
        Me.BathCheckBox = New System.Windows.Forms.CheckBox()
        Me.A_C_TypeTextBox = New System.Windows.Forms.TextBox()
        Me.Carpet_TypeTextBox = New System.Windows.Forms.TextBox()
        Me.Heated_FloorCheckBox = New System.Windows.Forms.CheckBox()
        Me.Ambient_LEDCheckBox = New System.Windows.Forms.CheckBox()
        Me.lnklbl_Signout = New System.Windows.Forms.LinkLabel()
        Me.btn_Close = New System.Windows.Forms.Button()
        Room_NumberLabel = New System.Windows.Forms.Label()
        TelevisionLabel = New System.Windows.Forms.Label()
        Sound_SystemLabel = New System.Windows.Forms.Label()
        Type_Of_BedLabel = New System.Windows.Forms.Label()
        ShowerLabel = New System.Windows.Forms.Label()
        BathLabel = New System.Windows.Forms.Label()
        A_C_TypeLabel = New System.Windows.Forms.Label()
        Carpet_TypeLabel = New System.Windows.Forms.Label()
        Heated_FloorLabel = New System.Windows.Forms.Label()
        Ambient_LEDLabel = New System.Windows.Forms.Label()
        CType(Me.Hotel_ManagementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hotel_Room_FacilitiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hotel_Room_FacilitiesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Hotel_Room_FacilitiesBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Room_NumberLabel
        '
        Room_NumberLabel.AutoSize = True
        Room_NumberLabel.Location = New System.Drawing.Point(38, 50)
        Room_NumberLabel.Name = "Room_NumberLabel"
        Room_NumberLabel.Size = New System.Drawing.Size(78, 13)
        Room_NumberLabel.TabIndex = 1
        Room_NumberLabel.Text = "Room Number:"
        '
        'TelevisionLabel
        '
        TelevisionLabel.AutoSize = True
        TelevisionLabel.Location = New System.Drawing.Point(38, 78)
        TelevisionLabel.Name = "TelevisionLabel"
        TelevisionLabel.Size = New System.Drawing.Size(58, 13)
        TelevisionLabel.TabIndex = 3
        TelevisionLabel.Text = "Television:"
        '
        'Sound_SystemLabel
        '
        Sound_SystemLabel.AutoSize = True
        Sound_SystemLabel.Location = New System.Drawing.Point(38, 108)
        Sound_SystemLabel.Name = "Sound_SystemLabel"
        Sound_SystemLabel.Size = New System.Drawing.Size(78, 13)
        Sound_SystemLabel.TabIndex = 5
        Sound_SystemLabel.Text = "Sound System:"
        '
        'Type_Of_BedLabel
        '
        Type_Of_BedLabel.AutoSize = True
        Type_Of_BedLabel.Location = New System.Drawing.Point(38, 136)
        Type_Of_BedLabel.Name = "Type_Of_BedLabel"
        Type_Of_BedLabel.Size = New System.Drawing.Size(70, 13)
        Type_Of_BedLabel.TabIndex = 7
        Type_Of_BedLabel.Text = "Type Of Bed:"
        '
        'ShowerLabel
        '
        ShowerLabel.AutoSize = True
        ShowerLabel.Location = New System.Drawing.Point(38, 164)
        ShowerLabel.Name = "ShowerLabel"
        ShowerLabel.Size = New System.Drawing.Size(46, 13)
        ShowerLabel.TabIndex = 9
        ShowerLabel.Text = "Shower:"
        '
        'BathLabel
        '
        BathLabel.AutoSize = True
        BathLabel.Location = New System.Drawing.Point(38, 194)
        BathLabel.Name = "BathLabel"
        BathLabel.Size = New System.Drawing.Size(32, 13)
        BathLabel.TabIndex = 11
        BathLabel.Text = "Bath:"
        '
        'A_C_TypeLabel
        '
        A_C_TypeLabel.AutoSize = True
        A_C_TypeLabel.Location = New System.Drawing.Point(38, 222)
        A_C_TypeLabel.Name = "A_C_TypeLabel"
        A_C_TypeLabel.Size = New System.Drawing.Size(56, 13)
        A_C_TypeLabel.TabIndex = 13
        A_C_TypeLabel.Text = "A/C Type:"
        '
        'Carpet_TypeLabel
        '
        Carpet_TypeLabel.AutoSize = True
        Carpet_TypeLabel.Location = New System.Drawing.Point(38, 248)
        Carpet_TypeLabel.Name = "Carpet_TypeLabel"
        Carpet_TypeLabel.Size = New System.Drawing.Size(68, 13)
        Carpet_TypeLabel.TabIndex = 15
        Carpet_TypeLabel.Text = "Carpet Type:"
        '
        'Heated_FloorLabel
        '
        Heated_FloorLabel.AutoSize = True
        Heated_FloorLabel.Location = New System.Drawing.Point(38, 276)
        Heated_FloorLabel.Name = "Heated_FloorLabel"
        Heated_FloorLabel.Size = New System.Drawing.Size(71, 13)
        Heated_FloorLabel.TabIndex = 17
        Heated_FloorLabel.Text = "Heated Floor:"
        '
        'Ambient_LEDLabel
        '
        Ambient_LEDLabel.AutoSize = True
        Ambient_LEDLabel.Location = New System.Drawing.Point(38, 306)
        Ambient_LEDLabel.Name = "Ambient_LEDLabel"
        Ambient_LEDLabel.Size = New System.Drawing.Size(72, 13)
        Ambient_LEDLabel.TabIndex = 19
        Ambient_LEDLabel.Text = "Ambient LED:"
        '
        'Hotel_ManagementDataSet
        '
        Me.Hotel_ManagementDataSet.DataSetName = "Hotel_ManagementDataSet"
        Me.Hotel_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Hotel_Room_FacilitiesBindingSource
        '
        Me.Hotel_Room_FacilitiesBindingSource.DataMember = "Hotel Room Facilities"
        Me.Hotel_Room_FacilitiesBindingSource.DataSource = Me.Hotel_ManagementDataSet
        '
        'Hotel_Room_FacilitiesTableAdapter
        '
        Me.Hotel_Room_FacilitiesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Customer_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.Hotel_Room_FacilitiesTableAdapter = Me.Hotel_Room_FacilitiesTableAdapter
        Me.TableAdapterManager.Hotel_RoomsTableAdapter = Nothing
        Me.TableAdapterManager.PaymentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Hotel_Management.Hotel_ManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Hotel_Room_FacilitiesBindingNavigator
        '
        Me.Hotel_Room_FacilitiesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Hotel_Room_FacilitiesBindingNavigator.BindingSource = Me.Hotel_Room_FacilitiesBindingSource
        Me.Hotel_Room_FacilitiesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Hotel_Room_FacilitiesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Hotel_Room_FacilitiesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Hotel_Room_FacilitiesBindingNavigatorSaveItem})
        Me.Hotel_Room_FacilitiesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Hotel_Room_FacilitiesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Hotel_Room_FacilitiesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Hotel_Room_FacilitiesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Hotel_Room_FacilitiesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Hotel_Room_FacilitiesBindingNavigator.Name = "Hotel_Room_FacilitiesBindingNavigator"
        Me.Hotel_Room_FacilitiesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Hotel_Room_FacilitiesBindingNavigator.Size = New System.Drawing.Size(289, 25)
        Me.Hotel_Room_FacilitiesBindingNavigator.TabIndex = 0
        Me.Hotel_Room_FacilitiesBindingNavigator.Text = "BindingNavigator1"
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
        'Hotel_Room_FacilitiesBindingNavigatorSaveItem
        '
        Me.Hotel_Room_FacilitiesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Hotel_Room_FacilitiesBindingNavigatorSaveItem.Image = CType(resources.GetObject("Hotel_Room_FacilitiesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Hotel_Room_FacilitiesBindingNavigatorSaveItem.Name = "Hotel_Room_FacilitiesBindingNavigatorSaveItem"
        Me.Hotel_Room_FacilitiesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Hotel_Room_FacilitiesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Room_NumberTextBox
        '
        Me.Room_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Hotel_Room_FacilitiesBindingSource, "Room_Number", True))
        Me.Room_NumberTextBox.Location = New System.Drawing.Point(122, 47)
        Me.Room_NumberTextBox.Name = "Room_NumberTextBox"
        Me.Room_NumberTextBox.Size = New System.Drawing.Size(104, 20)
        Me.Room_NumberTextBox.TabIndex = 2
        '
        'TelevisionCheckBox
        '
        Me.TelevisionCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Hotel_Room_FacilitiesBindingSource, "Television", True))
        Me.TelevisionCheckBox.Location = New System.Drawing.Point(122, 73)
        Me.TelevisionCheckBox.Name = "TelevisionCheckBox"
        Me.TelevisionCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.TelevisionCheckBox.TabIndex = 4
        Me.TelevisionCheckBox.Text = "Available"
        Me.TelevisionCheckBox.UseVisualStyleBackColor = True
        '
        'Sound_SystemCheckBox
        '
        Me.Sound_SystemCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Hotel_Room_FacilitiesBindingSource, "Sound_System", True))
        Me.Sound_SystemCheckBox.Location = New System.Drawing.Point(122, 103)
        Me.Sound_SystemCheckBox.Name = "Sound_SystemCheckBox"
        Me.Sound_SystemCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Sound_SystemCheckBox.TabIndex = 6
        Me.Sound_SystemCheckBox.Text = "Available"
        Me.Sound_SystemCheckBox.UseVisualStyleBackColor = True
        '
        'Type_Of_BedTextBox
        '
        Me.Type_Of_BedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Hotel_Room_FacilitiesBindingSource, "Type_Of_Bed", True))
        Me.Type_Of_BedTextBox.Location = New System.Drawing.Point(122, 133)
        Me.Type_Of_BedTextBox.Name = "Type_Of_BedTextBox"
        Me.Type_Of_BedTextBox.Size = New System.Drawing.Size(104, 20)
        Me.Type_Of_BedTextBox.TabIndex = 8
        '
        'ShowerCheckBox
        '
        Me.ShowerCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Hotel_Room_FacilitiesBindingSource, "Shower", True))
        Me.ShowerCheckBox.Location = New System.Drawing.Point(122, 159)
        Me.ShowerCheckBox.Name = "ShowerCheckBox"
        Me.ShowerCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.ShowerCheckBox.TabIndex = 10
        Me.ShowerCheckBox.Text = "Available"
        Me.ShowerCheckBox.UseVisualStyleBackColor = True
        '
        'BathCheckBox
        '
        Me.BathCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Hotel_Room_FacilitiesBindingSource, "Bath", True))
        Me.BathCheckBox.Location = New System.Drawing.Point(122, 189)
        Me.BathCheckBox.Name = "BathCheckBox"
        Me.BathCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.BathCheckBox.TabIndex = 12
        Me.BathCheckBox.Text = "Available"
        Me.BathCheckBox.UseVisualStyleBackColor = True
        '
        'A_C_TypeTextBox
        '
        Me.A_C_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Hotel_Room_FacilitiesBindingSource, "A/C Type", True))
        Me.A_C_TypeTextBox.Location = New System.Drawing.Point(122, 219)
        Me.A_C_TypeTextBox.Name = "A_C_TypeTextBox"
        Me.A_C_TypeTextBox.Size = New System.Drawing.Size(104, 20)
        Me.A_C_TypeTextBox.TabIndex = 14
        '
        'Carpet_TypeTextBox
        '
        Me.Carpet_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Hotel_Room_FacilitiesBindingSource, "Carpet_Type", True))
        Me.Carpet_TypeTextBox.Location = New System.Drawing.Point(122, 245)
        Me.Carpet_TypeTextBox.Name = "Carpet_TypeTextBox"
        Me.Carpet_TypeTextBox.Size = New System.Drawing.Size(104, 20)
        Me.Carpet_TypeTextBox.TabIndex = 16
        '
        'Heated_FloorCheckBox
        '
        Me.Heated_FloorCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Hotel_Room_FacilitiesBindingSource, "Heated_Floor", True))
        Me.Heated_FloorCheckBox.Location = New System.Drawing.Point(122, 271)
        Me.Heated_FloorCheckBox.Name = "Heated_FloorCheckBox"
        Me.Heated_FloorCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Heated_FloorCheckBox.TabIndex = 18
        Me.Heated_FloorCheckBox.Text = "Available"
        Me.Heated_FloorCheckBox.UseVisualStyleBackColor = True
        '
        'Ambient_LEDCheckBox
        '
        Me.Ambient_LEDCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Hotel_Room_FacilitiesBindingSource, "Ambient_LED", True))
        Me.Ambient_LEDCheckBox.Location = New System.Drawing.Point(122, 301)
        Me.Ambient_LEDCheckBox.Name = "Ambient_LEDCheckBox"
        Me.Ambient_LEDCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Ambient_LEDCheckBox.TabIndex = 20
        Me.Ambient_LEDCheckBox.Text = "Available"
        Me.Ambient_LEDCheckBox.UseVisualStyleBackColor = True
        '
        'lnklbl_Signout
        '
        Me.lnklbl_Signout.AutoSize = True
        Me.lnklbl_Signout.Location = New System.Drawing.Point(218, 29)
        Me.lnklbl_Signout.Name = "lnklbl_Signout"
        Me.lnklbl_Signout.Size = New System.Drawing.Size(48, 13)
        Me.lnklbl_Signout.TabIndex = 21
        Me.lnklbl_Signout.TabStop = True
        Me.lnklbl_Signout.Text = "Sign Out"
        '
        'btn_Close
        '
        Me.btn_Close.Location = New System.Drawing.Point(202, 357)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(75, 23)
        Me.btn_Close.TabIndex = 22
        Me.btn_Close.Text = "Close"
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'Hotel_Room_Facilities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 392)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.lnklbl_Signout)
        Me.Controls.Add(Room_NumberLabel)
        Me.Controls.Add(Me.Room_NumberTextBox)
        Me.Controls.Add(TelevisionLabel)
        Me.Controls.Add(Me.TelevisionCheckBox)
        Me.Controls.Add(Sound_SystemLabel)
        Me.Controls.Add(Me.Sound_SystemCheckBox)
        Me.Controls.Add(Type_Of_BedLabel)
        Me.Controls.Add(Me.Type_Of_BedTextBox)
        Me.Controls.Add(ShowerLabel)
        Me.Controls.Add(Me.ShowerCheckBox)
        Me.Controls.Add(BathLabel)
        Me.Controls.Add(Me.BathCheckBox)
        Me.Controls.Add(A_C_TypeLabel)
        Me.Controls.Add(Me.A_C_TypeTextBox)
        Me.Controls.Add(Carpet_TypeLabel)
        Me.Controls.Add(Me.Carpet_TypeTextBox)
        Me.Controls.Add(Heated_FloorLabel)
        Me.Controls.Add(Me.Heated_FloorCheckBox)
        Me.Controls.Add(Ambient_LEDLabel)
        Me.Controls.Add(Me.Ambient_LEDCheckBox)
        Me.Controls.Add(Me.Hotel_Room_FacilitiesBindingNavigator)
        Me.Name = "Hotel_Room_Facilities"
        Me.Text = "Hotel_Room_Facilities"
        CType(Me.Hotel_ManagementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hotel_Room_FacilitiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hotel_Room_FacilitiesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Hotel_Room_FacilitiesBindingNavigator.ResumeLayout(False)
        Me.Hotel_Room_FacilitiesBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Hotel_ManagementDataSet As Hotel_Management.Hotel_ManagementDataSet
    Friend WithEvents Hotel_Room_FacilitiesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Hotel_Room_FacilitiesTableAdapter As Hotel_Management.Hotel_ManagementDataSetTableAdapters.Hotel_Room_FacilitiesTableAdapter
    Friend WithEvents TableAdapterManager As Hotel_Management.Hotel_ManagementDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Hotel_Room_FacilitiesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Hotel_Room_FacilitiesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Room_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelevisionCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Sound_SystemCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Type_Of_BedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShowerCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BathCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents A_C_TypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Carpet_TypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Heated_FloorCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Ambient_LEDCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents lnklbl_Signout As System.Windows.Forms.LinkLabel
    Friend WithEvents btn_Close As System.Windows.Forms.Button
End Class
