Imports System.Collections.Generic
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Content
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Input

''' <summary>
''' Represents a level in the game and all it's contents
''' </summary>
Public Class Level
    ''' <summary>
    ''' The name of the level
    ''' </summary>
    Public Name As String = ""

    ''' <summary>
    ''' A two-dimensional array (x, y) of all WorldObjects placed in the level
    ''' </summary>
    Public PlacedObjects(,,) As WorldObject

    ''' <summary>
    ''' A list with WorldObjects with IsProp = True for faster access for level specific code
    ''' </summary>
    Public Props As New List(Of WorldObject)

    ''' <summary>
    ''' A list of polygons representing parts of the map that should be lit up
    ''' </summary>
    Public LightPolygons As New List(Of Polygon)

    ''' <summary>
    ''' A list of all NPCs present in the level
    ''' </summary>
    Public NPCs As New List(Of NPC)

    '''<summary>
    '''Represents the time of day. 0 = morning, 0.5 = noon, 1 = evening, 1.5 = midnight
    '''</summary>
    Public TimeOfDay As Single = 0

    Public BackgroundImage As Texture2D

    Private Clouds(20) As Sprite
    Private SkyColors(100) As Color
    Private BackgroundGradient As New Texture2D(graphics.GraphicsDevice, 1, graphics.PreferredBackBufferHeight)

    Private ShadowOverlay As RenderTarget2D

    Private MinZIndex As Integer = 50
    Private MaxZIndex As Integer = 50

    Sub New(_placedObjs As List(Of WorldObject))
        PlacedObjects = Misc.WObjListTo3DArray(_placedObjs)
    End Sub

    Public Sub LoadContent(Content As ContentManager)
        LevelSpecificCode.LevelSpecificCode.SetCurrentLevel(Name, Props)

        LevelSpecificCode.LevelSpecificCode.ExecuteInitialization()

        Dim f As New Friendly(32) With {.Position = New Vector2(250, 50), .Animations = AnimationSets.Player}

        f.Dialogue = New Dialogue

        f.Dialogue.Segments = {New DialogueSegment With {.FaceSprite = Content.Load(Of Texture2D)("Textures\Characters\Girl\Dialogue\idle"), .Text = "Hello"}, New DialogueSegment With {.Text = "This is an awesome" & vbNewLine & "and wholesome text", .FaceSprite = Content.Load(Of Texture2D)("Textures\Characters\Girl\Dialogue\idle")}}
        f.SetSelectedAnimation("idle")
        NPCs.Add(f)

        Textures.SkyGradient.GetData(SkyColors)

        For i As Integer = 0 To Clouds.Length - 1
            Clouds(i) = New Sprite() With {
                .Texture = Textures.Clouds(Random.Next(0, Textures.Clouds.Length)),
                .Scale = 0.5}
            Clouds(i).Position = New Vector2(Random.Next(CInt(-Clouds(i).Texture.Width * Clouds(i).Scale * 2), graphics.PreferredBackBufferWidth), Random.Next(85, 115))
        Next


        ' Add all PlacedObjects with IsProp = True to the Props list
        For Each obj In PlacedObjects
            If obj IsNot Nothing Then
                ' Find the highest zindex of all objects
                If obj.zIndex > 50 AndAlso obj.zIndex > MaxZIndex Then
                    MaxZIndex = obj.zIndex
                End If

                ' Find the lowest zindex of all objects
                If obj.zIndex <= 50 AndAlso obj.zIndex < MinZIndex Then
                    MinZIndex = obj.zIndex
                End If


                ' Add all PlacedObjects with IsProp = True to the Props list
                If obj.IsProp Then
                    Props.Add(obj)
                End If
            End If
        Next

        LevelSpecificCode.LevelSpecificCode.ExecuteLoadContent(Content)
    End Sub

    Public Sub Draw(ByRef sb As SpriteBatch, ByRef player As Player)
        If BackgroundImage IsNot Nothing Then
            sb.Begin()
            sb.Draw(BackgroundImage, New Rectangle(0, 0, graphics.PreferredBackBufferWidth, graphics.PreferredBackBufferHeight), Color.White)
            sb.End()
        End If


        DrawSky(sb)


        ' Draw tiles behind the characters
        For z As Integer = 40 To 50
            For x As Integer = 0 To PlacedObjects.GetUpperBound(0)
                For y As Integer = 0 To PlacedObjects.GetUpperBound(1)

                    Dim obj = PlacedObjects(x, y, z)
                    If obj IsNot Nothing Then

                        If obj.ParallaxMultiplier <> 1.0F Then
                            ' If object is parallax then begin spritebatch with special matrix

                            Dim parallaxMatrix As New Matrix
                            parallaxMatrix = LevelCameraMatrix
                            parallaxMatrix += Matrix.CreateTranslation(LevelCameraMatrix.Translation.X / obj.ParallaxMultiplier, LevelCameraMatrix.Translation.Y / obj.ParallaxMultiplier, LevelCameraMatrix.Translation.Z / obj.ParallaxMultiplier)



                            sb.Begin(Nothing, Nothing, SamplerState.LinearClamp,
                                     Nothing, Nothing, Nothing, parallaxMatrix)

                        Else
                            sb.Begin(Nothing, Nothing, SamplerState.LinearClamp, Nothing, Nothing, Nothing, LevelCameraMatrix)
                        End If

                        obj.Draw(sb)

                        sb.End()
                    End If
                Next
            Next
        Next

        sb.Begin(Nothing, Nothing, SamplerState.LinearClamp, Nothing, Nothing, Nothing, LevelCameraMatrix)

        player.Draw(sb)

        For Each NPC In NPCs
            NPC.Draw(sb)
        Next

        sb.End()


        ' Draw tiles in front of characters
        For x As Integer = 0 To PlacedObjects.GetUpperBound(0)
            For y As Integer = 0 To PlacedObjects.GetUpperBound(1)
                For z As Integer = 51 To 60
                    Dim obj = PlacedObjects(x, y, z)
                    If obj IsNot Nothing Then

                        If obj.ParallaxMultiplier <> 1.0F Then
                            ' If object is parallax then begin spritebatch with special matrix
                            sb.Begin(Nothing, Nothing, SamplerState.LinearClamp,
                                     Nothing, Nothing, Nothing,
                                     Matrix.CreateTranslation(LevelCameraMatrix.Translation.X / obj.ParallaxMultiplier, LevelCameraMatrix.Translation.Y / obj.ParallaxMultiplier, LevelCameraMatrix.Translation.Z / obj.ParallaxMultiplier))
                        Else
                            sb.Begin(Nothing, Nothing, SamplerState.LinearClamp, Nothing, Nothing, Nothing, LevelCameraMatrix)
                        End If

                        obj.Draw(sb)

                        sb.End()
                    End If
                Next
            Next
        Next

        LevelSpecificCode.LevelSpecificCode.ExecuteDraw(sb)


        DrawShadowOverlay(sb)



        ' DEBUG FEATURE
        If Keyboard.GetState.IsKeyDown(Keys.O) Then
            TimeOfDay += 0.01F
            TimeOfDay = TimeOfDay Mod 2
        End If
    End Sub

    Private Sub DrawSky(sb As SpriteBatch)
        If ShadowOverlay Is Nothing Then
            ShadowOverlay = New RenderTarget2D(graphics.GraphicsDevice, GetLevelSize().X, GetLevelSize().Y)
            ShadowOverlayRenderer.RenderShadowOverlay(sb, ShadowOverlay, LightPolygons)
        End If


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
    End Sub

    Private Sub DrawShadowOverlay(sb As SpriteBatch)
        ' Draw overlay to darken world when it's nighttime
        sb.Begin(,,,,,, LevelCameraMatrix)
        Dim alpha As Single = 1 - CSng(-(TimeOfDay * 2 - 1) ^ 6 + 1)
        If alpha > 0.5 Then
            alpha = 0.5
        End If
        sb.Draw(ShadowOverlay, New Vector2(0, 0), Color.White * alpha)

        ' Draw parts of the overlay not in level boundries
        Misc.DrawRectangle(sb, New Rectangle(GetLevelSize().X, 0, 15000, 5000), Color.Black * alpha) ' Right
        Misc.DrawRectangle(sb, New Rectangle(0, -5000, 15000, 5000), Color.Black * alpha) ' Top
        Misc.DrawRectangle(sb, New Rectangle(-5000, -5000, 5000, 10000), Color.Black * alpha) ' Left
        Misc.DrawRectangle(sb, New Rectangle(0, GetLevelSize().Y, GetLevelSize().X, 5000), Color.Black * alpha) ' Bottom
        sb.End()
    End Sub

    Dim updatingWorldObjects As List(Of WorldObject)
    Public Sub Update(gameTime As GameTime, player As Player)

        LevelSpecificCode.LevelSpecificCode.ExecuteUpdate(gameTime)

        If updatingWorldObjects Is Nothing Then
            updatingWorldObjects = New List(Of WorldObject)

            For Each wObj In PlacedObjects
                If wObj IsNot Nothing Then
                    ' TODO: Optimize this dumpster fire of a code, only add worldobjects with an update loop which isn't empty (i.e. TechnicalObjects) to the list

                    updatingWorldObjects.Add(wObj)
                End If
            Next
        End If

        For Each wObj In updatingWorldObjects
            wObj.Update(gameTime)
        Next


        For Each NPC In NPCs
            NPC.Update(gameTime)
        Next

        NPCs.RemoveAll(Function(x) x.Alive = False)
    End Sub

    ''' <summary>
    ''' Created explosion at position
    ''' </summary>
    ''' <param name="centerPos">Center position of the explosion</param>
    ''' <param name="radius">Radius of the explosion</param>
    Public Sub Explode(centerPos As Vector2, radius As Integer)
        For x As Integer = CInt(centerPos.X / 30 - radius) To CInt(centerPos.X / 30 + radius)
            For y As Integer = CInt(centerPos.Y / 30 - radius) To CInt(centerPos.Y / 30 + radius)
                ' Get distance of center of block to center of explosion
                If PlacedObjects.GetLowerBound(0) <= x AndAlso PlacedObjects.GetUpperBound(0) >= x AndAlso
                    PlacedObjects.GetLowerBound(1) <= y AndAlso PlacedObjects.GetUpperBound(1) >= y AndAlso PlacedObjects(x, y, 50) IsNot Nothing Then
                    Dim _dist As Single = Vector2.Distance(PlacedObjects(x, y, 50).GetTrueRect().Location.ToVector2, centerPos)
                    If _dist < radius Then
                        PlacedObjects(x, y, 50) = Nothing
                    End If
                End If
            Next
        Next
    End Sub

    Public Function GetLevelSize() As Point
        'Return New Point(PlacedObjects(PlacedObjects.GetUpperBound(0), PlacedObjects.GetUpperBound(1), 50).GetTrueRect().Right, PlacedObjects(PlacedObjects.GetUpperBound(0), PlacedObjects.GetUpperBound(1), 50).GetTrueRect().Bottom)
        Return New Point(1, 1)
        ' TODO: WHAT THE F*CK IS THIS?!
    End Function

    Public Function GetScreenRect() As Rectangle
        Return New Rectangle(CInt(LevelCameraMatrix.Translation.X), CInt(LevelCameraMatrix.Translation.Y), GetLevelSize().X, GetLevelSize().Y)
    End Function
End Class
