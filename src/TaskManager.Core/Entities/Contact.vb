Imports System.ComponentModel

Public Class Contact

  Private _id As String

  <Browsable(False)>
  Public Property Id() As Integer
    Get
      Return _id
    End Get

    Set(ByVal value As Integer)
      _id = value
    End Set
  End Property

  Private _name As String
  Public Property Name() As String
    Get
      Return _name
    End Get

    Set(ByVal value As String)
      _name = value
    End Set
  End Property

  Private _email As String
  Public Property Email() As String
    Get
      Return _email
    End Get

    Set(ByVal value As String)
      'Fix ISSUE: the _name was set instead of _email
      _email = value
    End Set
  End Property

  Private _phone As String
  Public Property Phone() As String
    Get
      Return _phone
    End Get

    Set(ByVal value As String)
      _phone = value
    End Set
  End Property

End Class
