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
      contacts = contactRepo.GetContacts()
      grdContacts.DataSource = contacts
    End Using
  End Sub

  Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
    Using editContactForm As New EditContact()

      Dim RowIndex As Integer = grdContacts.CurrentRow.Index

      If RowIndex < 0 Then
        MessageBox.Show("Please select a contact to edit.")
        Return
      End If

      editContactForm.Id = contacts(RowIndex).Id
      editContactForm.txtName.Text = contacts(RowIndex).Name
      editContactForm.txtEmail.Text = contacts(RowIndex).Email
      editContactForm.txtPhone.Text = contacts(RowIndex).Phone

      If editContactForm.ShowDialog() = DialogResult.OK Then
        GetContacts()
      End If
    End Using
  End Sub

  Private Sub ButtonImport_Click(sender As Object, e As EventArgs) Handles ButtonImport.Click
    If ImportContacts() Then
      MessageBox.Show("New contacts imported successfully.")
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
        MessageBox.Show("JSON file could not be imported. Please check the file contents.")
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
        MessageBox.Show("JSON file could not be imported. Please check the file contents." & vbCrLf & vbCrLf & ex.ToString())
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
End Class
