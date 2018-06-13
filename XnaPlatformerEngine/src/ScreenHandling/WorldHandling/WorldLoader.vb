Imports System.IO
Imports System.Xml.Linq
Imports Microsoft.Xna.Framework.Content

Public Class WorldLoader
    Public Shared Function LoadWorld(_path As String, Content As ContentManager) As World
        Dim resultWorld As New World

        Dim file As XElement = XElement.Load(_path)

        Dim levelsFolderPath As String = Path.Combine(Path.GetDirectoryName(_path), "Levels")

        For Each xele As XElement In file.Element("Levels").Elements
            resultWorld.LoadLevel(Path.Combine(levelsFolderPath, xele.Element("Name").Value & ".plvl"), xele.Element("Name").Value, Content)
        Next

        Return resultWorld
    End Function
End Class
