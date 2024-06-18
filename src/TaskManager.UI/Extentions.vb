Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Module Extentions

  <System.Runtime.CompilerServices.Extension>
  Public Function ValidJSon(json As String) As Boolean

    Try
      '1st check
      Dim Token = JToken.Parse(json)

      '2nd check
      Dim obj = JsonConvert.DeserializeObject(json)

      Return True

    Catch ex As Exception
      ' Invalid json
      Return False
    End Try

  End Function

End Module
