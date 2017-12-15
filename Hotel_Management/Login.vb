Imports System.Data.OleDb



Public Class frm_Login
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnnection As OleDbConnection = New OleDbConnection

    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        provider = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "C:\Users\Gabriel2\Documents\Hotel Management.accdb"
        connString = provider & dataFile
        myConnnection.ConnectionString = connString
        myConnnection.Open()

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Employee_User_Accounts WHERE Emp_User_Name = '" & txt_Username.Text & "' AND Emp_Pass = '" & txt_Password.Text & "'", myConnnection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        Dim userFound As Boolean = False

        While dr.Read
            userFound = True
        End While

        If userFound = True Then
            Frm_Customer.Show()
            Me.Hide()
        Else
            MsgBox("Sorry incorrect username or password", MsgBoxStyle.OkOnly, "Invalid Login")

        End If


    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Application.Exit()
    End Sub
End Class