﻿Imports System.Data.SQLite
Imports TaskManager.Core

Public Class ContactRepository
    Implements IDisposable

    Public Sub Dispose() Implements IDisposable.Dispose
    End Sub

    Public Function InsertContact(contact As Contact) As Boolean
        Using connection As New SQLiteConnection(SQLiteHelper.DBPath)
            connection.Open()

      ' FIX ISSUE #1: The query was inserting the values in the wrong order
      Dim insertQuery As String = "INSERT INTO Contact (Name, Email, Phone) VALUES (@Name, @Email, @Phone)"
            Using command As New SQLiteCommand(insertQuery, connection)
                command.Parameters.AddWithValue("@Name", contact.Name)
                command.Parameters.AddWithValue("@Email", contact.Email)
                command.Parameters.AddWithValue("@Phone", contact.Phone)
                command.ExecuteNonQuery()
            End Using
        End Using

        Return False
    End Function

    Public Function GetContacts() As List(Of Contact)
        Dim contacts As New List(Of Contact)

        Using connection As New SQLiteConnection(SQLiteHelper.DBPath)
            connection.Open()
      'Dim selectQuery As String = "SELECT Name, Email, 0 AS Phone FROM Contact WHERE 1 = 0"

      ' FIX ISSUE #3: Problem with the SQL Query
      Dim selectQuery As String = "SELECT Name, Email, Phone FROM Contact"
            Using command As New SQLiteCommand(selectQuery, connection)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        contacts.Add(New Contact() With {.Name = reader("Name"), .Email = reader("Email"), .Phone = reader("Phone")})
                    End While
                End Using
            End Using
        End Using

        Return contacts
    End Function

End Class
