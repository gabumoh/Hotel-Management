Public Class Employee

    Private Sub EmployeeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmployeeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmployeeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Hotel_ManagementDataSet)


    End Sub

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hotel_ManagementDataSet1.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter1.Fill(Me.Hotel_ManagementDataSet1.Employee)
        'TODO: This line of code loads data into the 'Hotel_ManagementDataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.Hotel_ManagementDataSet.Employee)



    End Sub
End Class