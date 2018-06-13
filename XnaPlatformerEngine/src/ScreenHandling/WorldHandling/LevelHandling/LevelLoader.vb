Imports System.Collections.Generic
Imports System.Xml.Linq
Imports Microsoft.Xna.Framework.Content
Imports Microsoft.Xna.Framework.Graphics

Public Class LevelLoader
    Shared TextureObjs As List(Of TextureObject)

    Public Shared Function LoadLevel(_path As String, Content As ContentManager) As List(Of WorldObject)
        Dim _placedObjects As New List(Of WorldObject)

        Dim lvlXEle = XElement.Load(_path)

        For Each xele In lvlXEle.Element("WorldObjects").Elements
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

        LoadTextures(Content, lvlXEle)

        For Each wObj In _placedObjects
            For Each tObj In TextureObjs
                If wObj.Name = tObj.Name Then
                    wObj.Texture = tObj.Texture

                    wObj.HasRandomTextureRotation = tObj.HasRandomTextureRotation
                    wObj.IsFoliage = tObj.IsFoliage

                    wObj.RotateRandomly()
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

                Case "InfoBoxDisplay"
                    Dim tObj As New InfoBoxDisplay
                    tObj.Name = xele.Attribute("Name").Value
                    tObj.rect.X = CInt(xele.Element("X").Value)
                    tObj.rect.Y = CInt(xele.Element("Y").Value)
                    tObj.Text = xele.Element("Text").Value.Replace("\n", vbNewLine)

                    _placedObjects.Add(tObj)

                Case "LoadingZone"
                    Dim tObj As New LoadingZone
                    tObj.Name = xele.Attribute("Name").Value
                    tObj.rect.X = CInt(xele.Element("X").Value)
                    tObj.rect.Y = CInt(xele.Element("Y").Value)
                    tObj.TargetLevelName = xele.Element("TargetLevelName").Value

                    _placedObjects.Add(tObj)
            End Select
        Next

        Return _placedObjects
    End Function

    Shared Sub LoadTextures(Content As ContentManager, lvlXEle As XElement)
        Dim resultObjs As New List(Of TextureObject)

        'Load WorldObjects from XML

        For Each _tObj In lvlXEle.Element("Textures").Elements
            resultObjs.Add(New TextureObject(_tObj.Element("Name").Value,
                                             Content.Load(Of Texture2D)(_tObj.Element("TexturePath").Value),
                                             Convert.ToBoolean(_tObj.Element("RandomTextureRotation").Value),
                                             Convert.ToBoolean(_tObj.Element("IsFoliage").Value)))
        Next

        TextureObjs = resultObjs
    End Sub
End Class
