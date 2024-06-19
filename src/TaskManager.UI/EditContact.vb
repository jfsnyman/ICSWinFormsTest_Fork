Imports TaskManager.Core
Imports TaskManager.Data

Public Class EditContact

  Friend Id As Integer

  Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    Dim CanSave As Boolean = True
    Dim Message As String = ""

    If ValidateForm() Then
      Dim contact As New Contact() With {
            .Id = Id,
            .Name = txtName.Text,
            .Email = txtEmail.Text,
            .Phone = txtPhone.Text,
            .Active = Math.Abs(CInt(CheckActive.Checked))
        }

      Try
        Using contactRepo As New ContactRepository()
          contactRepo.UpdateContact(contact)
        End Using

      Catch ex As Exception
        Message = "Failed to update contact." & vbCrLf & vbCrLf & ex.ToString()
        CanSave = False
      End Try

      If CanSave Then
        ClearTextBoxes()

        Me.DialogResult = DialogResult.OK
        Close()
      Else
        MessageBox.Show(Message, "Contact Manager", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If

    End If

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
    CheckActive.Checked = False
  End Sub

  Private Function ValidateForm() As Boolean

    Dim Result As Boolean = True
    Dim Message As String = ""

    If txtName.Text = "" Then
      Message &= "Please enter a name." & vbCrLf
      Result = False
    End If

    If txtEmail.Text = "" Then
      Message &= "Please enter an email." & vbCrLf
      Result = False
    End If

    If txtPhone.Text = "" Then
      Message &= "Please enter a phone number." & vbCrLf
      Result = False
    End If

    If Not IsNumeric(txtPhone.Text) Then
      Message &= "Phone number must be numeric." & vbCrLf
      Result = False
    End If

    If Not Result Then
      MessageBox.Show(Message, "Contact Manager", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If

    Return Result

  End Function

End Class