Imports System.Collections.Generic
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Content

Public Class Level
    Public PlacedObjects(,,) As WorldObject

    Sub New(_placedObjs As List(Of WorldObject))
        PlacedObjects = Misc.WObjListTo3DArray(_placedObjs)
    End Sub

    Public Sub LoadContent(_content As ContentManager)
        For Each _wObj In PlacedObjects
            If _wObj IsNot Nothing AndAlso _wObj.GetType() = GetType(WorldObject) Then
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

    Public Sub Explode(_centerPos As Vector2, _radius As Integer)
        For x As Integer = CInt(_centerPos.X / 30 - _radius) To CInt(_centerPos.X / 30 + _radius)
            For y As Integer = CInt(_centerPos.Y / 30 - _radius) To CInt(_centerPos.Y / 30 + _radius)
                ' Get distance of center of block to center of explosion
                If PlacedObjects.GetLowerBound(0) <= x AndAlso PlacedObjects.GetUpperBound(0) >= x AndAlso
                    PlacedObjects.GetLowerBound(1) <= y AndAlso PlacedObjects.GetUpperBound(1) >= y AndAlso PlacedObjects(x, y, 50) IsNot Nothing Then
                    Dim _dist As Single = Vector2.Distance(PlacedObjects(x, y, 50).getTrueRect().Location.ToVector2, _centerPos)
                    If _dist < _radius Then
                        PlacedObjects(x, y, 50) = Nothing
                    End If
                End If
            Next
        Next
    End Sub
End Class
