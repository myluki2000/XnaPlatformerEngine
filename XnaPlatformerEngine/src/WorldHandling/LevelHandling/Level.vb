Imports System.Collections.Generic
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Content

Public Class Level
    Public PlacedObjects(,) As WorldObject

    Sub New(_placedObjs As List(Of WorldObject))
        PlacedObjects = Misc.WObjListTo2DArray(_placedObjs)
    End Sub

    Public Sub LoadContent(_content As ContentManager)
        For Each _wObj In PlacedObjects
            If _wObj IsNot Nothing Then
                _wObj.LoadContent(_content)
            End If
        Next
    End Sub

    Public Sub Update(gameTime As GameTime)
        For Each _wObj In PlacedObjects
            If _wObj IsNot Nothing Then
                _wObj.Update(gameTime)
            End If
        Next
    End Sub
End Class
