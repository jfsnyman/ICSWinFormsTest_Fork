<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContactListing
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
        Me.grdContacts = New System.Windows.Forms.DataGridView()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonImport = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.edtFilter = New System.Windows.Forms.TextBox()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.chkShowOnlyActive = New System.Windows.Forms.CheckBox()
        Me.ButtonClose = New System.Windows.Forms.Button()
        CType(Me.grdContacts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdContacts
        '
        Me.grdContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdContacts.Location = New System.Drawing.Point(12, 112)
        Me.grdContacts.MultiSelect = False
        Me.grdContacts.Name = "grdContacts"
        Me.grdContacts.Size = New System.Drawing.Size(448, 343)
        Me.grdContacts.TabIndex = 3
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(12, 467)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAdd.TabIndex = 4
        Me.ButtonAdd.Text = "Add Contact"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(193, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(71, 17)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Contacts"
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Location = New System.Drawing.Point(93, 467)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEdit.TabIndex = 5
        Me.ButtonEdit.Text = "Edit Contact"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'ButtonImport
        '
        Me.ButtonImport.Location = New System.Drawing.Point(174, 467)
        Me.ButtonImport.Name = "ButtonImport"
        Me.ButtonImport.Size = New System.Drawing.Size(99, 23)
        Me.ButtonImport.TabIndex = 6
        Me.ButtonImport.Text = "Import Contacts"
        Me.ButtonImport.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "json"
        Me.OpenFileDialog1.Filter = "JSON Files|*.json|All Files|*.*"
        Me.OpenFileDialog1.Title = "Select JSON file to import"
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Location = New System.Drawing.Point(12, 37)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(29, 13)
        Me.lblFilter.TabIndex = 1
        Me.lblFilter.Text = "Filter"
        '
        'edtFilter
        '
        Me.edtFilter.Location = New System.Drawing.Point(12, 56)
        Me.edtFilter.Name = "edtFilter"
        Me.edtFilter.Size = New System.Drawing.Size(359, 20)
        Me.edtFilter.TabIndex = 2
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(377, 55)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(83, 23)
        Me.ButtonRefresh.TabIndex = 7
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'chkShowOnlyActive
        '
        Me.chkShowOnlyActive.AutoSize = True
        Me.chkShowOnlyActive.Location = New System.Drawing.Point(13, 86)
        Me.chkShowOnlyActive.Name = "chkShowOnlyActive"
        Me.chkShowOnlyActive.Size = New System.Drawing.Size(138, 17)
        Me.chkShowOnlyActive.TabIndex = 8
        Me.chkShowOnlyActive.Text = "Show ACTIVE contacts"
        Me.chkShowOnlyActive.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(377, 467)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(83, 23)
        Me.ButtonClose.TabIndex = 9
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ContactListing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 508)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.chkShowOnlyActive)
        Me.Controls.Add(Me.ButtonRefresh)
        Me.Controls.Add(Me.edtFilter)
        Me.Controls.Add(Me.lblFilter)
        Me.Controls.Add(Me.ButtonImport)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.grdContacts)
        Me.Name = "ContactListing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contact Listing"
        CType(Me.grdContacts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdContacts As DataGridView
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents lblHeader As Label
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents ButtonImport As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lblFilter As Label
    Friend WithEvents edtFilter As TextBox
    Friend WithEvents ButtonRefresh As Button
    Friend WithEvents chkShowOnlyActive As CheckBox
    Friend WithEvents ButtonClose As Button
End Class
