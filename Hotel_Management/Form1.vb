Public Class Frm_Customer

    Private Sub Customer_DetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Customer_DetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Customer_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Hotel_ManagementDataSet)


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hotel_ManagementDataSet.Customer_Details' table. You can move, or remove it, as needed.
        Me.Customer_DetailsTableAdapter.Fill(Me.Hotel_ManagementDataSet.Customer_Details)


    End Sub

    Private Sub btn_htrmf_Click(sender As Object, e As EventArgs) Handles btn_htrmf.Click
        Me.Hide()
        Hotel_Room_Facilities.Show()
    End Sub

    Private Sub lnklbl_Signout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklbl_Signout.LinkClicked
        Me.Close()
        frm_Login.Show()
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Application.Exit()
    End Sub
End Class
