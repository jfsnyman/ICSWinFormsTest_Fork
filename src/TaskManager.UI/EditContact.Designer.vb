<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditContact
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
    Me.btnSave = New System.Windows.Forms.Button()
    Me.lblEmail = New System.Windows.Forms.Label()
    Me.lblPhone = New System.Windows.Forms.Label()
    Me.lblName = New System.Windows.Forms.Label()
    Me.txtPhone = New System.Windows.Forms.TextBox()
    Me.txtEmail = New System.Windows.Forms.TextBox()
    Me.txtName = New System.Windows.Forms.TextBox()
    Me.btnCancel = New System.Windows.Forms.Button()
    Me.CheckActive = New System.Windows.Forms.CheckBox()
    Me.SuspendLayout()
    '
    'btnSave
    '
    Me.btnSave.Location = New System.Drawing.Point(152, 231)
    Me.btnSave.Name = "btnSave"
    Me.btnSave.Size = New System.Drawing.Size(70, 23)
    Me.btnSave.TabIndex = 7
    Me.btnSave.Text = "Save"
    Me.btnSave.UseVisualStyleBackColor = True
    '
    'lblEmail
    '
    Me.lblEmail.AutoSize = True
    Me.lblEmail.Location = New System.Drawing.Point(43, 97)
    Me.lblEmail.Name = "lblEmail"
    Me.lblEmail.Size = New System.Drawing.Size(32, 13)
    Me.lblEmail.TabIndex = 2
    Me.lblEmail.Text = "Email"
    '
    'lblPhone
    '
    Me.lblPhone.AutoSize = True
    Me.lblPhone.Location = New System.Drawing.Point(43, 150)
    Me.lblPhone.Name = "lblPhone"
    Me.lblPhone.Size = New System.Drawing.Size(38, 13)
    Me.lblPhone.TabIndex = 4
    Me.lblPhone.Text = "Phone"
    '
    'lblName
    '
    Me.lblName.AutoSize = True
    Me.lblName.Location = New System.Drawing.Point(43, 44)
    Me.lblName.Name = "lblName"
    Me.lblName.Size = New System.Drawing.Size(35, 13)
    Me.lblName.TabIndex = 0
    Me.lblName.Text = "Name"
    '
    'txtPhone
    '
    Me.txtPhone.Location = New System.Drawing.Point(98, 143)
    Me.txtPhone.Name = "txtPhone"
    Me.txtPhone.Size = New System.Drawing.Size(200, 20)
    Me.txtPhone.TabIndex = 5
    '
    'txtEmail
    '
    Me.txtEmail.Location = New System.Drawing.Point(98, 94)
    Me.txtEmail.Name = "txtEmail"
    Me.txtEmail.Size = New System.Drawing.Size(200, 20)
    Me.txtEmail.TabIndex = 3
    '
    'txtName
    '
    Me.txtName.Location = New System.Drawing.Point(98, 44)
    Me.txtName.Name = "txtName"
    Me.txtName.Size = New System.Drawing.Size(200, 20)
    Me.txtName.TabIndex = 1
    '
    'btnCancel
    '
    Me.btnCancel.Location = New System.Drawing.Point(228, 231)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(70, 23)
    Me.btnCancel.TabIndex = 8
    Me.btnCancel.Text = "Cancel"
    Me.btnCancel.UseVisualStyleBackColor = True
    '
    'CheckActive
    '
    Me.CheckActive.AutoSize = True
    Me.CheckActive.Location = New System.Drawing.Point(46, 189)
    Me.CheckActive.Name = "CheckActive"
    Me.CheckActive.Size = New System.Drawing.Size(56, 17)
    Me.CheckActive.TabIndex = 6
    Me.CheckActive.Text = "Active"
    Me.CheckActive.UseVisualStyleBackColor = True
    '
    'EditContact
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(341, 280)
    Me.Controls.Add(Me.CheckActive)
    Me.Controls.Add(Me.btnCancel)
    Me.Controls.Add(Me.btnSave)
    Me.Controls.Add(Me.lblEmail)
    Me.Controls.Add(Me.lblPhone)
    Me.Controls.Add(Me.lblName)
    Me.Controls.Add(Me.txtPhone)
    Me.Controls.Add(Me.txtEmail)
    Me.Controls.Add(Me.txtName)
    Me.Name = "EditContact"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Edit Contact"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents btnSave As Button
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents CheckActive As CheckBox
End Class
