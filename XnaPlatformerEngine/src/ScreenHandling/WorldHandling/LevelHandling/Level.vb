Imports System.Collections.Generic
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Content
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Input

Public Class Level
    Public Name As String = ""
    Public PlacedObjects(,,) As WorldObject
    Public NPCs As New List(Of NPC)

    Private Clouds(20) As Sprite
    Private SkyColors(100) As Color
    Private BackgroundGradient As New Texture2D(graphics.GraphicsDevice, 1, graphics.PreferredBackBufferHeight)

    '''<summary>
    '''Represents the time of day. 0 = morning, 0.5 = noon, 1 = evening, 1.5 = midnight
    '''</summary>
    Public TimeOfDay As Single = 0

    Sub New(_placedObjs As List(Of WorldObject))
        PlacedObjects = Misc.WObjListTo3DArray(_placedObjs)



    End Sub

    Public Sub LoadContent(Content As ContentManager)
        Dim f As New Friendly(32) With {.Position = New Vector2(250, 50), .Animations = AnimationSets.Player}

        f.Dialogue = New Dialogue

        f.Dialogue.Segments = {New DialogueSegment With {.FaceSprite = Content.Load(Of Texture2D)("Textures\Characters\Girl\Dialogue\idle"), .Text = "Hello"}, New DialogueSegment With {.Text = "This is an awesome" & vbNewLine & "and wholesome text", .FaceSprite = Content.Load(Of Texture2D)("Textures\Characters\Girl\Dialogue\idle")}}
        f.SetSelectedAnimation("idle")
        NPCs.Add(f)


        Textures.SkyGradient.GetData(SkyColors)

        For i As Integer = 0 To Clouds.Length - 1
            Clouds(i) = New Sprite() With {
                .Texture = Textures.Clouds(Random.Next(0, Textures.Clouds.Length)),
                .Position = New Vector2(Random.Next(-200, graphics.PreferredBackBufferWidth), Random.Next(85, 115)),
                .Scale = 0.5}
        Next
    End Sub

    Public Sub Draw(ByRef sb As SpriteBatch, ByRef Player As Player)

        sb.Begin(,, SamplerState.PointClamp,,,,)
        ' Draw sky and sun
        Dim pixels(graphics.PreferredBackBufferHeight) As Color

        For i As Integer = 0 To pixels.Length - 1
            pixels(i) = Color.Lerp(Misc.SubtractColors(SkyColors(CInt(TimeOfDay * 50)), New Color(100, 100, 100)), SkyColors(CInt(TimeOfDay * 50)), CSng(i / graphics.PreferredBackBufferHeight))
        Next

        BackgroundGradient.SetData(pixels)

        sb.Draw(BackgroundGradient, New Rectangle(0, 0, graphics.PreferredBackBufferWidth, graphics.PreferredBackBufferHeight), Color.White)

        Dim sunPos As New Point
        sunPos.X = CInt(TimeOfDay * graphics.PreferredBackBufferWidth)
        sunPos.Y = CInt(((TimeOfDay * 2 - 1) ^ 2 + 0.1) * graphics.PreferredBackBufferHeight)

        sb.Draw(Textures.Sun, New Rectangle(sunPos, New Point(100, 100)), Color.White)


        ' Draw clouds
        For i As Integer = 0 To Clouds.Length - 1
            Clouds(i).Draw(sb)
            Clouds(i).Position.X += 0.2F

            If Clouds(i).Position.X > graphics.PreferredBackBufferWidth Then
                Clouds(i).Position.X = Random.Next(CInt(-Clouds(i).Texture.Width * Clouds(i).Scale * 2), CInt(-Clouds(i).Texture.Width * Clouds(i).Scale))
                Clouds(i).Position.Y = Random.Next(85, 115)
            End If
        Next
        sb.End()

        sb.Begin(Nothing, Nothing, SamplerState.PointClamp, Nothing, Nothing, Nothing, LevelCameraMatrix)
        ' Draw tiles behind the characters
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

        ' Draw tiles in front of characters
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
        sb.End()

        If Keyboard.GetState.IsKeyDown(Keys.O) Then
            TimeOfDay += 0.01F
            TimeOfDay = TimeOfDay Mod 2
        End If

        ' Draw overlay to darken world when it's nighttime
        sb.Begin()
        Dim alpha As Single = 1 - CSng(-(TimeOfDay * 2 - 1) ^ 6 + 1)
        If alpha > 0.5 Then
            alpha = 0.5
        End If
        Misc.DrawRectangle(sb, New Rectangle(0, 0, graphics.PreferredBackBufferWidth, graphics.PreferredBackBufferHeight), Color.Black * alpha)
        sb.End()
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
                    Dim _dist As Single = Vector2.Distance(PlacedObjects(x, y, 50).GetTrueRect().Location.ToVector2, _centerPos)
                    If _dist < _radius Then
                        PlacedObjects(x, y, 50) = Nothing
                    End If
                End If
            Next
        Next
    End Sub
End Class
