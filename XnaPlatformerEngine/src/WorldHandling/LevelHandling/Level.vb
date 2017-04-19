Imports System.Collections.Generic
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Content

Public Class Level
    Public PlacedObjects As New List(Of WorldObject)

    Sub New(_placedObjs As List(Of WorldObject))
        PlacedObjects = _placedObjs
    End Sub

    Public Sub LoadContent(_content As ContentManager)
        For Each _obj In PlacedObjects
            _obj.LoadContent(_content)
        Next
    End Sub

    Public Sub Update(gameTime As GameTime)
        For Each _wObj In PlacedObjects
            _wObj.Update(gameTime)
        Next
    End Sub
End Class
