<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblusername = New Label()
        lblfavouratecolour = New Label()
        lblage = New Label()
        txtfavouratecolour = New TextBox()
        txtage = New TextBox()
        txtusername = New TextBox()
        btnlogin = New Button()
        SuspendLayout()
        ' 
        ' lblusername
        ' 
        lblusername.AutoSize = True
        lblusername.Location = New Point(160, 91)
        lblusername.Name = "lblusername"
        lblusername.Size = New Size(60, 15)
        lblusername.TabIndex = 0
        lblusername.Text = "Username"
        ' 
        ' lblfavouratecolour
        ' 
        lblfavouratecolour.AutoSize = True
        lblfavouratecolour.Location = New Point(160, 244)
        lblfavouratecolour.Name = "lblfavouratecolour"
        lblfavouratecolour.Size = New Size(96, 15)
        lblfavouratecolour.TabIndex = 1
        lblfavouratecolour.Text = "Favourate colour"
        ' 
        ' lblage
        ' 
        lblage.AutoSize = True
        lblage.Location = New Point(160, 171)
        lblage.Name = "lblage"
        lblage.Size = New Size(28, 15)
        lblage.TabIndex = 2
        lblage.Text = "Age"
        ' 
        ' txtfavouratecolour
        ' 
        txtfavouratecolour.BackColor = SystemColors.InactiveBorder
        txtfavouratecolour.Location = New Point(274, 244)
        txtfavouratecolour.Name = "txtfavouratecolour"
        txtfavouratecolour.Size = New Size(100, 23)
        txtfavouratecolour.TabIndex = 3
        ' 
        ' txtage
        ' 
        txtage.Location = New Point(274, 171)
        txtage.Name = "txtage"
        txtage.Size = New Size(100, 23)
        txtage.TabIndex = 4
        ' 
        ' txtusername
        ' 
        txtusername.Location = New Point(274, 91)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(100, 23)
        txtusername.TabIndex = 5
        ' 
        ' btnlogin
        ' 
        btnlogin.Location = New Point(222, 311)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(75, 23)
        btnlogin.TabIndex = 6
        btnlogin.Text = "Log in"
        btnlogin.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(btnlogin)
        Controls.Add(txtusername)
        Controls.Add(txtage)
        Controls.Add(txtfavouratecolour)
        Controls.Add(lblage)
        Controls.Add(lblfavouratecolour)
        Controls.Add(lblusername)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblusername As Label
    Friend WithEvents lblfavouratecolour As Label
    Friend WithEvents lblage As Label
    Friend WithEvents txtfavouratecolour As TextBox
    Friend WithEvents txtage As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents btnlogin As Button

End Class
