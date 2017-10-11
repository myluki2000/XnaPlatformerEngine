Imports System.Collections.Generic
Imports System.Xml.Linq
Imports Microsoft.Xna.Framework.Content
Imports Microsoft.Xna.Framework.Graphics

Public Class LevelLoader
    Shared TextureObjs As List(Of TextureObject)

    Public Shared Function LoadLevel(_path As String) As List(Of WorldObject)
        Dim _placedObjects As New List(Of WorldObject)


        For Each xele In XElement.Load(_path).Element("WorldObjects").Elements
            Dim _placedObj As New WorldObject
            _placedObj.Name = xele.Attribute("Name").Value
            _placedObj.rect.X = CInt(xele.Element("X").Value)
            _placedObj.rect.Y = CInt(xele.Element("Y").Value)
            _placedObj.rect.Width = CInt(xele.Element("Width").Value)
            _placedObj.rect.Height = CInt(xele.Element("Height").Value)
            _placedObj.Scale = CInt(xele.Element("Scale").Value)
            _placedObj.zIndex = CInt(xele.Element("Z-Index").Value)

            _placedObjects.Add(_placedObj)
        Next

        For Each _wObj In _placedObjects
            For Each _tObj In TextureObjs
                If _wObj.Name = _tObj.Name Then
                    _wObj.Texture = _tObj.Texture
                End If
            Next
        Next


        ' Load technical objects
        For Each xele In XElement.Load(_path).Element("TechnicalObjects").Elements
            Select Case xele.Attribute("Name").Value
                Case "PlayerSpawn"
                    Dim tObj As New PlayerSpawn
                    tObj.Name = xele.Attribute("Name").Value
                    tObj.rect.X = CInt(xele.Element("X").Value)
                    tObj.rect.Y = CInt(xele.Element("Y").Value)

                    _placedObjects.Add(tObj)

                Case "Spawner"
                    Dim tObj As New Spawner
                    tObj.Name = xele.Attribute("Name").Value
                    tObj.rect.X = CInt(xele.Element("X").Value)
                    tObj.rect.Y = CInt(xele.Element("Y").Value)
                    tObj.ID = xele.Element("ID").Value

                    _placedObjects.Add(tObj)

            End Select
        Next

        Return _placedObjects
    End Function

    Shared Sub LoadTextures(Content As ContentManager)
        Dim resultObjs As New List(Of TextureObject)

        'Load WorldObjects from XML
        Dim xele As XElement = XElement.Load("tes.xml")
        For Each _tObj In xele.Elements
            resultObjs.Add(New TextureObject(_tObj.Attribute("Name").Value, Content.Load(Of Texture2D)(_tObj.Element("TexturePath").Value)))
        Next

        TextureObjs = resultObjs
    End Sub
End Class
