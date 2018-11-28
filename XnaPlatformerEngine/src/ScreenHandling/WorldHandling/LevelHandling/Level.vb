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

    Public Camera As New Camera

    ''' <summary>
    ''' An array of all WorldObjects placed in the level
    ''' </summary>
    Public Property PlacedObjects As WorldObject()
        Get
            Return _PlacedObjects
        End Get
        Set(value As WorldObject())
            _PlacedObjects = value
            Array.Sort(_PlacedObjects, Function(x, y) x.zIndex.CompareTo(y.zIndex))

            LevelMaxX = 0
            LevelMaxY = 0

            For Each wObj In _PlacedObjects
                If wObj.rect.X > LevelMaxX Then
                    LevelMaxX = wObj.rect.X
                End If

                If wObj.rect.Y > LevelMaxY Then
                    LevelMaxY = wObj.rect.Y
                End If
            Next
        End Set
    End Property
    Private _PlacedObjects() As WorldObject

    Private LevelMaxX As Integer
    Private LevelMaxY As Integer

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
    Private SkyColors(99) As Color
    Private BackgroundGradient As Texture2D

    Private ShadowOverlay As RenderTarget2D

    Sub New(_placedObjs As List(Of WorldObject))
        PlacedObjects = _placedObjs.ToArray
    End Sub

    Public Sub LoadContent(Content As ContentManager)
        LevelSpecificCode.LevelSpecificCode.SetCurrentLevel(Me, Props)

        LevelSpecificCode.LevelSpecificCode.ExecuteInitialization()

        Dim f As New Friendly(32) With {.Position = New Vector2(250, 50), .Animations = AnimationSets.Player}

        f.Dialogue = New Dialogue

        f.Dialogue.Segments = {New DialogueSegment With {.FaceSprite = TextureLoader.Load("Textures\Characters\Girl\Dialogue\idle"), .Text = "Hello"}, New DialogueSegment With {.Text = "This is an awesome" & vbNewLine & "and wholesome text", .FaceSprite = TextureLoader.Load("Textures\Characters\Girl\Dialogue\idle")}}
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
                ' Add all PlacedObjects with IsProp = True to the Props list
                If obj.IsProp Then
                    Props.Add(obj)
                End If
            End If
        Next

        LevelSpecificCode.LevelSpecificCode.ExecuteLoadContent(Content)
    End Sub

    Public Sub Draw(ByRef sb As SpriteBatch, ByRef player As Player)
        Dim selectedLevel = ScreenHandler.SelectedScreen.ToWorld().SelectedLevel

        If BackgroundImage IsNot Nothing Then
            sb.Begin(, BlendState.NonPremultiplied,,,,,)
            sb.Draw(BackgroundImage, New Rectangle(0, 0, graphics.PreferredBackBufferWidth, graphics.PreferredBackBufferHeight), Color.White)
            sb.End()
        End If


        DrawSky(sb)

        ' =====IMPORTANT=====
        ' We assume that the PlacedObjects array is sorted by the zIndex field of the objects
        ' (draw order might be wrong if array is not sorted after this)
        ' ===================

        Dim firstForegroundIndex As Integer = Array.FindIndex(PlacedObjects, Function(x) x.zIndex = 51)

        ' Draw tiles behind the characters
        For i As Integer = 0 To If(firstForegroundIndex <> -1, firstForegroundIndex - 2, PlacedObjects.Length - 1)
            Dim obj = PlacedObjects(i)
            If obj.ParallaxMultiplier <> 1.0F Then
                ' If object is parallax then begin spritebatch with special matrix

                Dim parallaxMatrix As New Matrix

                parallaxMatrix = selectedLevel.Camera.GetMatrix()
                parallaxMatrix += Matrix.CreateTranslation(selectedLevel.Camera.Translation.X / obj.ParallaxMultiplier,
                                                           selectedLevel.Camera.Translation.Y / obj.ParallaxMultiplier,
                                                           selectedLevel.Camera.Translation.Z / obj.ParallaxMultiplier)



                sb.Begin(Nothing, BlendState.NonPremultiplied, SamplerState.LinearClamp,
                         Nothing, Nothing, Nothing, parallaxMatrix)

            Else
                sb.Begin(Nothing, BlendState.NonPremultiplied, SamplerState.LinearClamp, Nothing, Nothing, Nothing, selectedLevel.Camera.GetMatrix())
            End If

            obj.Draw(sb)

            sb.End()
        Next

        sb.Begin(Nothing, BlendState.NonPremultiplied, SamplerState.LinearClamp, Nothing, Nothing, Nothing, selectedLevel.Camera.GetMatrix())

        player.Draw(sb)

        For Each NPC In NPCs
            NPC.Draw(sb)
        Next

        sb.End()


        ' Draw tiles in front of characters
        If firstForegroundIndex <> -1 Then

            For i As Integer = firstForegroundIndex - 1 To PlacedObjects.Length - 1
                MsgBox(i)
                Dim obj = PlacedObjects(i)
                If obj.ParallaxMultiplier <> 1.0F Then
                    ' If object is parallax then begin spritebatch with special matrix
                    sb.Begin(Nothing, BlendState.NonPremultiplied, SamplerState.LinearClamp,
                         Nothing, Nothing, Nothing,
                         Matrix.CreateTranslation(selectedLevel.Camera.Translation.X / obj.ParallaxMultiplier, selectedLevel.Camera.Translation.Y / obj.ParallaxMultiplier, selectedLevel.Camera.Translation.Z / obj.ParallaxMultiplier))
                Else
                    sb.Begin(Nothing, BlendState.NonPremultiplied, SamplerState.LinearClamp, Nothing, Nothing, Nothing, selectedLevel.Camera.GetMatrix())
                End If

                obj.Draw(sb)

                sb.End()
            Next
        End If

        LevelSpecificCode.LevelSpecificCode.ExecuteDraw(sb)


        DrawShadowOverlay(sb)



        ' DEBUG FEATURES
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


        sb.Begin(, BlendState.NonPremultiplied, SamplerState.PointClamp,,,,)
        ' Draw sky and sun
        Dim pixels(graphics.PreferredBackBufferHeight - 1) As Color

        For i As Integer = 0 To pixels.Length - 1
            pixels(i) = Color.Lerp(Misc.SubtractColors(SkyColors(CInt(TimeOfDay * 50)), New Color(100, 100, 100)), SkyColors(CInt(TimeOfDay * 50)), CSng(i / graphics.PreferredBackBufferHeight))
        Next

        BackgroundGradient = New Texture2D(graphics.GraphicsDevice, 1, graphics.PreferredBackBufferHeight)

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
        sb.Begin(, BlendState.NonPremultiplied,,,,, ScreenHandler.SelectedScreen.ToWorld.SelectedLevel.Camera.GetMatrix())
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
    ''' Creates explosion at position
    ''' </summary>
    ''' <param name="centerPos">Center position of the explosion</param>
    ''' <param name="radius">Radius of the explosion</param>
    Public Sub Explode(centerPos As Vector2, radius As Integer)
        Throw New NotImplementedException("Has to be changed to use one dimensional array of worldobjects")

        'For x As Integer = CInt(centerPos.X / 30 - radius) To CInt(centerPos.X / 30 + radius)
        '    For y As Integer = CInt(centerPos.Y / 30 - radius) To CInt(centerPos.Y / 30 + radius)
        '        ' Get distance of center of block to center of explosion
        '        If PlacedObjects.GetLowerBound(0) <= x AndAlso PlacedObjects.GetUpperBound(0) >= x AndAlso
        '            PlacedObjects.GetLowerBound(1) <= y AndAlso PlacedObjects.GetUpperBound(1) >= y AndAlso PlacedObjects(x, y, 50) IsNot Nothing Then
        '            Dim _dist As Single = Vector2.Distance(PlacedObjects(x, y, 50).GetTrueRect().Location.ToVector2, centerPos)
        '            If _dist < radius Then
        '                PlacedObjects(x, y, 50) = Nothing
        '            End If
        '        End If
        '    Next
        'Next
    End Sub

    Public Function GetLevelSize() As Point
        Return New Point(LevelMaxX, LevelMaxY)
    End Function

    Public Function GetScreenRect() As Rectangle
        Dim selectedLevel = ScreenHandler.SelectedScreen.ToWorld().SelectedLevel
        Return New Rectangle(CInt(selectedLevel.Camera.Translation.X),
                             CInt(selectedLevel.Camera.Translation.Y),
                             GetLevelSize().X, GetLevelSize().Y)
    End Function
End Class
