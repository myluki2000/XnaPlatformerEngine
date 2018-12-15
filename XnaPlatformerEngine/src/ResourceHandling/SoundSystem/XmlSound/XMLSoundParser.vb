Imports System.Xml.Linq

Public Class XmlSoundParser
    Public Function ParseXmlFile(filePath As String) As NoteSong
        Dim root = XElement.Load(filePath)

        Dim resultSong As New NoteSong


        For Each noteEle In root.Elements("n")
            resultSong.Notes.Add(New Note() With {
                    .Duration = CInt(noteEle.Element("d")),
                    .Pitch = CInt(noteEle.Element("p"))
                })
        Next



        Return resultSong
    End Function
End Class
