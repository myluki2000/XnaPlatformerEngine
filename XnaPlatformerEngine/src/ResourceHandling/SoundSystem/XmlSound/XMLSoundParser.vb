Imports System.Xml.Linq

Public Class XmlSoundParser
    Public Function ParseXmlFile(filePath As String) As NoteSong
        Dim root = XElement.Load(filePath)

        Dim resultSong As New NoteSong

        For Each trackEles In root.Elements("Track")
            Dim tmpTrack As New Track

            For Each noteEle In trackEles.Elements("n")
                tmpTrack.Notes.Add(New Note() With {
                    .Duration = CInt(noteEle.Element("d")),
                    .Pitch = CInt(noteEle.Element("p"))
                })
            Next

            resultSong.Tracks.Add(tmpTrack)
        Next

        Return resultSong
    End Function
End Class
