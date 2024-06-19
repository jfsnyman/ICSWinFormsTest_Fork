Imports TaskManager.Core
Imports TaskManager.Data

Public Class AddContact
  Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

    Dim CanAdd As Boolean = True
    Dim Message As String = ""

    If ValidateForm() Then
      Dim contact As New Contact() With {
            .Name = txtName.Text,
            .Email = txtEmail.Text,
            .Phone = txtPhone.Text,
            .Active = Math.Abs(CInt(CheckActive.Checked))
        }

      Try
        Using contactRepo As New ContactRepository()
          contactRepo.InsertContact(contact)
        End Using

      Catch ex As Exception
        Message = "Failed to add contact." & vbCrLf & vbCrLf & ex.ToString()
        CanAdd = False
      End Try

      If CanAdd Then
        Me.DialogResult = DialogResult.OK

        ClearTextBoxes()
        Close()
      End If
    End If

  End Sub

  Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    Me.DialogResult = DialogResult.Cancel

    ClearTextBoxes()
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

  Private Sub AddContact_Load(sender As Object, e As EventArgs) Handles MyBase.Load

  End Sub
End Class
