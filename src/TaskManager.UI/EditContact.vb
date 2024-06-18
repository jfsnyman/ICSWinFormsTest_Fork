Imports TaskManager.Core
Imports TaskManager.Data

Public Class EditContact

  Friend Id As Integer

  Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    Dim contact As New Contact() With {
            .Id = Id,
            .Name = txtName.Text,
            .Email = txtEmail.Text,
            .Phone = txtPhone.Text
        }

    Using contactRepo As New ContactRepository()
      contactRepo.UpdateContact(contact)
    End Using

    ClearTextBoxes()

    Me.DialogResult = DialogResult.OK
    Close()
  End Sub

  Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
    ClearTextBoxes()

    Me.DialogResult = DialogResult.Cancel
    Close()
  End Sub

  Private Sub ClearTextBoxes()
    txtName.Clear()
    txtEmail.Clear()
    txtPhone.Clear()
  End Sub

End Class