Imports System.Collections.Generic
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Content
Imports Microsoft.Xna.Framework.Graphics

Public Class Level
    Public Name As String = ""
    Public PlacedObjects(,,) As WorldObject
    Public NPCs As New List(Of Character)

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

    Public Sub Draw(ByRef sb As SpriteBatch, ByRef Player As Player)
        For x As Integer = 0 To PlacedObjects.GetUpperBound(0)
            For y As Integer = 0 To PlacedObjects.GetUpperBound(1)
                For z As Integer = 0 To 50
                    Dim _object = PlacedObjects(x, y, z)
                    If _object IsNot Nothing Then
                        _object.Draw(sb)
                    End If
                Next
            Next
        Next

        Player.Draw(sb)

        For Each NPC In NPCs
            NPC.Draw(sb)
        Next

        For x As Integer = 0 To PlacedObjects.GetUpperBound(0)
            For y As Integer = 0 To PlacedObjects.GetUpperBound(1)
                For z As Integer = 51 To 100
                    Dim _object = PlacedObjects(x, y, z)
                    If _object IsNot Nothing Then
                        _object.Draw(sb)
                    End If
                Next
            Next
        Next
    End Sub

    Public Sub Update(gameTime As GameTime)
        For Each _wObj In PlacedObjects
            If _wObj IsNot Nothing Then
                If _wObj.rect.Location = New Point(20, 12) Then
                End If

                _wObj.Update(gameTime)
            End If
        Next

        For Each NPC In NPCs
            NPC.Update(gameTime)
        Next

        NPCs.RemoveAll(Function(x) x.Alive = False)
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
