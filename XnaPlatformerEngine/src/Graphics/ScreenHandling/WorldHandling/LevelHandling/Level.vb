Imports System.Collections.Generic
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Content
Imports Microsoft.Xna.Framework.Graphics

Public Class Level
    Public Name As String = ""
    Public PlacedObjects(,,) As WorldObject
    Public NPCs As New List(Of NPC)

    Sub New(_placedObjs As List(Of WorldObject))
        PlacedObjects = Misc.WObjListTo3DArray(_placedObjs)



    End Sub

    Public Sub LoadContent(Content As ContentManager)
        Dim f As New Friendly(32) With {.Position = New Vector2(250, 50), .Animations = AnimationSets.Player}

        f.Dialogue = New Dialogue

        f.Dialogue.Segments = {New DialogueSegment With {.FaceSprite = Content.Load(Of Texture2D)("Textures\Characters\Girl\Dialogue\idle"), .Text = "Hello"}, New DialogueSegment With {.Text = "This is an awesome" & vbNewLine & "and wholesome text", .FaceSprite = Content.Load(Of Texture2D)("Textures\Characters\Girl\Dialogue\idle")}}
        f.SetSelectedAnimation("idle")
        NPCs.Add(f)

        InfoBox.Show("You can interact" & vbNewLine & "with NPCs and" & vbNewLine & "objects using the " & vbNewLine & "'E' button")
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
