Public Class Hotel_Room_Facilities

    Private Sub Hotel_Room_FacilitiesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Hotel_Room_FacilitiesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Hotel_Room_FacilitiesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Hotel_ManagementDataSet)

    End Sub

    Private Sub Hotel_Room_Facilities_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hotel_ManagementDataSet.Hotel_Room_Facilities' table. You can move, or remove it, as needed.
        Me.Hotel_Room_FacilitiesTableAdapter.Fill(Me.Hotel_ManagementDataSet.Hotel_Room_Facilities)
        Me.Hide()

    End Sub

    Private Sub lnklbl_Signout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklbl_Signout.LinkClicked
        Me.Close()
        frm_Login.Show()

    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Application.Exit()
    End Sub
End Class