<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Login
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
        Me.grpbox_loginPane = New System.Windows.Forms.GroupBox()
        Me.lnklbl_ForgotPassword = New System.Windows.Forms.LinkLabel()
        Me.btn_Login = New System.Windows.Forms.Button()
        Me.lbl_Password = New System.Windows.Forms.Label()
        Me.lbl_Username = New System.Windows.Forms.Label()
        Me.txt_Password = New System.Windows.Forms.TextBox()
        Me.txt_Username = New System.Windows.Forms.TextBox()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.grpbox_loginPane.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpbox_loginPane
        '
        Me.grpbox_loginPane.Controls.Add(Me.lnklbl_ForgotPassword)
        Me.grpbox_loginPane.Controls.Add(Me.btn_Login)
        Me.grpbox_loginPane.Controls.Add(Me.lbl_Password)
        Me.grpbox_loginPane.Controls.Add(Me.lbl_Username)
        Me.grpbox_loginPane.Controls.Add(Me.txt_Password)
        Me.grpbox_loginPane.Controls.Add(Me.txt_Username)
        Me.grpbox_loginPane.Location = New System.Drawing.Point(162, 47)
        Me.grpbox_loginPane.Name = "grpbox_loginPane"
        Me.grpbox_loginPane.Size = New System.Drawing.Size(301, 164)
        Me.grpbox_loginPane.TabIndex = 0
        Me.grpbox_loginPane.TabStop = False
        Me.grpbox_loginPane.Text = "Login Pane"
        '
        'lnklbl_ForgotPassword
        '
        Me.lnklbl_ForgotPassword.AutoSize = True
        Me.lnklbl_ForgotPassword.Location = New System.Drawing.Point(175, 143)
        Me.lnklbl_ForgotPassword.Name = "lnklbl_ForgotPassword"
        Me.lnklbl_ForgotPassword.Size = New System.Drawing.Size(86, 13)
        Me.lnklbl_ForgotPassword.TabIndex = 5
        Me.lnklbl_ForgotPassword.TabStop = True
        Me.lnklbl_ForgotPassword.Text = "Forgot Password"
        Me.lnklbl_ForgotPassword.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'btn_Login
        '
        Me.btn_Login.Location = New System.Drawing.Point(76, 112)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.Size = New System.Drawing.Size(130, 23)
        Me.btn_Login.TabIndex = 4
        Me.btn_Login.Text = "Login"
        Me.btn_Login.UseVisualStyleBackColor = True
        '
        'lbl_Password
        '
        Me.lbl_Password.AutoSize = True
        Me.lbl_Password.Location = New System.Drawing.Point(34, 80)
        Me.lbl_Password.Name = "lbl_Password"
        Me.lbl_Password.Size = New System.Drawing.Size(53, 13)
        Me.lbl_Password.TabIndex = 3
        Me.lbl_Password.Text = "Password"
        '
        'lbl_Username
        '
        Me.lbl_Username.AutoSize = True
        Me.lbl_Username.Location = New System.Drawing.Point(31, 38)
        Me.lbl_Username.Name = "lbl_Username"
        Me.lbl_Username.Size = New System.Drawing.Size(55, 13)
        Me.lbl_Username.TabIndex = 2
        Me.lbl_Username.Text = "Username"
        '
        'txt_Password
        '
        Me.txt_Password.Location = New System.Drawing.Point(111, 80)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Password.Size = New System.Drawing.Size(142, 20)
        Me.txt_Password.TabIndex = 1
        '
        'txt_Username
        '
        Me.txt_Username.Location = New System.Drawing.Point(111, 38)
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.Size = New System.Drawing.Size(142, 20)
        Me.txt_Username.TabIndex = 0
        '
        'btn_Close
        '
        Me.btn_Close.Location = New System.Drawing.Point(499, 229)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(75, 23)
        Me.btn_Close.TabIndex = 1
        Me.btn_Close.Text = "Close"
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 264)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.grpbox_loginPane)
        Me.Name = "frm_Login"
        Me.Text = "Login"
        Me.grpbox_loginPane.ResumeLayout(False)
        Me.grpbox_loginPane.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpbox_loginPane As System.Windows.Forms.GroupBox
    Friend WithEvents lnklbl_ForgotPassword As System.Windows.Forms.LinkLabel
    Friend WithEvents btn_Login As System.Windows.Forms.Button
    Friend WithEvents lbl_Password As System.Windows.Forms.Label
    Friend WithEvents lbl_Username As System.Windows.Forms.Label
    Friend WithEvents txt_Password As System.Windows.Forms.TextBox
    Friend WithEvents txt_Username As System.Windows.Forms.TextBox
    Friend WithEvents btn_Close As System.Windows.Forms.Button
End Class
