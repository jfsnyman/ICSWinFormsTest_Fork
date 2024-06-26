﻿Imports System.Data.SQLite
Imports TaskManager.Core

Public Class ContactRepository
  Implements IDisposable

  Public Sub Dispose() Implements IDisposable.Dispose
  End Sub

  Public Function InsertContact(contact As Contact) As Boolean
    Using connection As New SQLiteConnection(SQLiteHelper.DBPath)
      connection.Open()

      ' --------------------------------------------------------------------------------------
      ' FIX ISSUE: The query was inserting the values in the wrong order
      ' --------------------------------------------------------------------------------------
      Dim insertQuery As String = "INSERT INTO Contact (Name, Email, Phone) VALUES (@Name, @Email, @Phone)"

      Using command As New SQLiteCommand(insertQuery, connection)
        command.Parameters.AddWithValue("@Name", contact.Name)
        command.Parameters.AddWithValue("@Email", contact.Email)
        command.Parameters.AddWithValue("@Phone", contact.Phone)
        command.ExecuteNonQuery()
      End Using
    End Using

    Return True
  End Function

  Public Function UpdateContact(contact As Contact) As Boolean
    Using connection As New SQLiteConnection(SQLiteHelper.DBPath)
      connection.Open()

      Dim updateQuery As String = "UPDATE Contact SET Name = @Name, Email = @Email, Phone = @Phone WHERE Id = @Id"

      Using command As New SQLiteCommand(updateQuery, connection)
        command.Parameters.AddWithValue("@Id", contact.Id)
        command.Parameters.AddWithValue("@Name", contact.Name)
        command.Parameters.AddWithValue("@Email", contact.Email)
        command.Parameters.AddWithValue("@Phone", contact.Phone)
        command.ExecuteNonQuery()
      End Using
    End Using

    Return True
  End Function

  Public Function GetContacts() As List(Of Contact)
    Dim contacts As New List(Of Contact)

    Using connection As New SQLiteConnection(SQLiteHelper.DBPath)
      connection.Open()

      ' --------------------------------------------------------------------------------------
      ' FIX ISSUE: Problem with the SQL Query
      ' --------------------------------------------------------------------------------------
      'Dim selectQuery As String = "SELECT Name, Email, 0 AS Phone FROM Contact WHERE 1 = 0"
      Dim selectQuery As String = "SELECT Id, Name, Email, Phone FROM Contact"

      Using command As New SQLiteCommand(selectQuery, connection)
        Using reader As SQLiteDataReader = command.ExecuteReader()
          While reader.Read()
            contacts.Add(New Contact() With {.Id = reader("Id"), .Name = reader("Name"), .Email = reader("Email"), .Phone = reader("Phone")})
          End While
        End Using
      End Using
    End Using

    Return contacts
  End Function

End Class

