#Region "Using Statements"
Imports System.Collections.Generic
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Content
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Input
Imports Microsoft.Xna.Framework.Storage
#End Region

''' <summary>
''' This is the main type for your game
''' </summary>
Public Class Main
    Inherits Game
    Private spriteBatch As SpriteBatch

    Dim TestWorld1 As New World
    Dim ps As New ParticleSystem(New Vector2(100, 100)) With {.ParticleVelocityLowest = New Point(-10, -10), .ParticleVelocityHighest = New Point(10, 10)}

    Public Sub New()
        MyBase.New()
        graphics = New GraphicsDeviceManager(Me)
        Content.RootDirectory = "Content"
    End Sub

    ''' <summary>
    ''' Allows the game to perform any initialization it needs to before starting to run.
    ''' This is where it can query for any required services and load any non-graphic
    ''' related content.  Calling base.Initialize will enumerate through any components
    ''' and initialize them as well.
    ''' </summary>
    Protected Overrides Sub Initialize()

        ScreenHandler.SetSelectedScreen(TestWorld1)

        MyBase.Initialize()
    End Sub

    ''' <summary>
    ''' LoadContent will be called once per game and is the place to load
    ''' all of your content.
    ''' </summary>
    Protected Overrides Sub LoadContent()
        ' Create a new SpriteBatch, which can be used to draw textures.
        spriteBatch = New SpriteBatch(GraphicsDevice)

        TestWorld1.Levels.Add(New Level(LevelLoader.LoadLevel()))

        TestWorld1.LoadContent(Content)
        TestWorld1.SetSelectedLevel(0)

        Textures.Bullet = Content.Load(Of Texture2D)("Textures/Bullet")

        FontKoot = Content.Load(Of SpriteFont)("Koot")
        DevPurple = Content.Load(Of Texture2D)("devpurple")

        ps.PossibleTextures = {DevPurple, Textures.Bullet}
        ' TODO: use this.Content to load your game content here
    End Sub

    ''' <summary>
    ''' UnloadContent will be called once per game and is the place to unload
    ''' all content.
    ''' </summary>
    Protected Overrides Sub UnloadContent()
        ' TODO: Unload any non ContentManager content here
    End Sub

    ''' <summary>
    ''' Allows the game to run logic such as updating the world,
    ''' checking for collisions, gathering input, and playing audio.
    ''' </summary>
    ''' <param name="gameTime">Provides a snapshot of timing values.</param>
    Protected Overrides Sub Update(gameTime As GameTime)
        If GamePad.GetState(PlayerIndex.One).Buttons.Back = ButtonState.Pressed OrElse Keyboard.GetState().IsKeyDown(Keys.Escape) Then
            [Exit]()
        End If

        If Keyboard.GetState.IsKeyDown(Keys.K) Then
            ps.SpawnParticles(1)
        End If

        ScreenHandler.Update(gameTime)

        ps.Update(gameTime)

        MyBase.Update(gameTime)
    End Sub

    ''' <summary>
    ''' This is called when the game should draw itself.
    ''' </summary>
    ''' <param name="gameTime">Provides a snapshot of timing values.</param>
    Protected Overrides Sub Draw(gameTime As GameTime)
        GraphicsDevice.Clear(Color.CornflowerBlue)

        ScreenHandler.Draw(spriteBatch)

        spriteBatch.Begin()
        ps.Draw(spriteBatch)
        spriteBatch.End()

        MyBase.Draw(gameTime)
    End Sub
End Class
