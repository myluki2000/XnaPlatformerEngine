Imports System.IO
Imports System.Xml.Linq

Public Class WorldLoader
    Public Shared Function LoadWorld(_path As String) As World
        Dim resultWorld As New World

        Dim file As XElement = XElement.Load(_path)

        Dim levelsFolderPath As String = Path.Combine(Path.GetDirectoryName(_path), "Levels")

        For Each xele As XElement In file.Element("Levels").Elements
            resultWorld.LoadLevel(Path.Combine(levelsFolderPath, xele.Element("FileName").Value), xele.Element("Name").Value)
        Next

        Return resultWorld
    End Function
End Class
