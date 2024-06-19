Imports System.ComponentModel
Imports TaskManager.Core
Imports TaskManager.Data
Imports System.IO
Imports Newtonsoft.Json


Public Class ContactListing
  Private contacts As New List(Of Contact)()

  Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    SQLiteHelper.SetupConnection()

    GetContacts()
  End Sub

  Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
    Using addContactForm As New AddContact()
      If addContactForm.ShowDialog() = DialogResult.OK Then
        GetContacts()
      End If
    End Using
  End Sub

  Private Sub GetContacts() Handles ButtonAdd.Click
    Using contactRepo As New ContactRepository()

      Dim Filter As String = edtFilter.Text.Trim

      Try
        If chkShowOnlyActive.Checked Then
          If Filter = "" Then
            Filter = "Active = 1"
          Else
            Filter = Filter & " AND Active = 1"
          End If
        End If

        contacts = contactRepo.GetContacts(Filter)
        grdContacts.DataSource = contacts

      Catch ex As Exception
        MessageBox.Show("Contatcs failed to load from the database. Please check the FILTER" & vbCrLf & vbCrLf & ex.ToString(), "Contact Manager", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
    End Using
  End Sub

  Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
    Using editContactForm As New EditContact()

      Dim RowIndex As Integer

      Try
        RowIndex = grdContacts.CurrentRow.Index
      Catch ex As Exception
        RowIndex = -1
      End Try

      If RowIndex < 0 Then
        MessageBox.Show("Please select a contact to edit.", "Contact Manager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return
      End If

      editContactForm.Id = contacts(RowIndex).Id
      editContactForm.txtName.Text = contacts(RowIndex).Name
      editContactForm.txtEmail.Text = contacts(RowIndex).Email
      editContactForm.txtPhone.Text = contacts(RowIndex).Phone
      editContactForm.CheckActive.Checked = (contacts(RowIndex).Active = 1)

      If editContactForm.ShowDialog() = DialogResult.OK Then
        GetContacts()
      End If
    End Using
  End Sub

  Private Sub ButtonImport_Click(sender As Object, e As EventArgs) Handles ButtonImport.Click
    If ImportContacts() Then
      MessageBox.Show("New contacts imported successfully.", "Contact Manager", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

  'Function to import json file with list of contacts
  Private Function ImportContacts() As Boolean
    Dim jsonFile As String
    Dim json As String
    Dim contacts As List(Of Contact)

    If OpenFileDialog1.ShowDialog = DialogResult.OK Then
      jsonFile = OpenFileDialog1.FileName
      json = File.ReadAllText(jsonFile)

      If json.ValidJSon() = False Then
        MessageBox.Show("JSON file could not be imported. Please check the file contents.", "Contact Manager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
      End If

      Try
        contacts = JsonConvert.DeserializeObject(Of List(Of Contact))(json)

        Using contactRepo As New ContactRepository()
          For Each contact As Contact In contacts
            contactRepo.InsertContact(contact)
          Next
        End Using

        GetContacts()

      Catch ex As Exception
        ' Invalid json - just in case ValidJson did not catch the error
        MessageBox.Show("JSON file could not be imported. Please check the file contents." & vbCrLf & vbCrLf & ex.ToString(), "Contact Manager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
      End Try

      Return True

    End If

    Return False

  End Function

  'Only used for creating test data
  Private Sub ExportContacts()
    Dim json As String = JsonConvert.SerializeObject(contacts)

    Debug.Print("-----------------------------------------------------------")
    Debug.Print(json)
    Debug.Print("-----------------------------------------------------------")

  End Sub

  Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
    GetContacts()
  End Sub

  Private Sub chkShowOnlyActive_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowOnlyActive.CheckedChanged
    GetContacts()
  End Sub

  Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
    Me.Close()
  End Sub
End Class
