﻿Imports System.Collections.Generic
Imports System.Xml.Linq
Imports System.Windows.Forms

Public Class LevelLoader
    Public Shared Function LoadLevel() As List(Of WorldObject)
        Dim _placedObjects As New List(Of WorldObject)
        Dim dlgLoad As New OpenFileDialog
        dlgLoad.Filter = "Platformer level | *.plvl"
        dlgLoad.Multiselect = False
        dlgLoad.ShowDialog()

        If dlgLoad.FileName IsNot "" Then
            For Each xele In XElement.Load(dlgLoad.FileName).Element("WorldObjects").Elements
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

            Dim _worldObjs = LoadTextures()
            For Each _pObj In _placedObjects
                For Each _wObj In _worldObjs
                    If _pObj.Name = _wObj.Name Then
                        _pObj.TexturePath = _wObj.TexturePath
                    End If
                Next
            Next


            ' Load technical objects
            For Each xele In XElement.Load(dlgLoad.FileName).Element("TechnicalObjects").Elements
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

            MsgBox("Level has been loaded." & vbNewLine & _placedObjects.Count & " objects have been loaded.")
            Return _placedObjects
        Else
            Return LoadLevel()
        End If
    End Function

    Shared Function LoadTextures() As List(Of WorldObject)
        Dim _objs As New List(Of WorldObject)

        'Load WorldObjects from XML
        Dim xele As XElement = XElement.Load("tes.xml")
        For Each _wObj In xele.Elements
            _objs.Add(New WorldObject(_wObj.Attribute("Name").Value, _wObj.Element("TexturePath").Value))
        Next

        Return _objs
    End Function
End Class
