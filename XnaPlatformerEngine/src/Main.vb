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
    Dim LoadingThread As Threading.Thread

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
        IsMouseVisible = True


        ScreenHandler.SelectedScreen = TestWorld1

        MyBase.Initialize()
    End Sub

    ''' <summary>
    ''' LoadContent will be called once per game and is the place to load
    ''' all of your content.
    ''' </summary>
    Protected Overrides Sub LoadContent()
        ' Create a new SpriteBatch, which can be used to draw textures.
        spriteBatch = New SpriteBatch(GraphicsDevice)

        ' Load important stuff before we switch to the background loading thread
        TestWorld1.Levels.Add(New Level(LevelLoader.LoadLevel()))
        FontKoot = Content.Load(Of SpriteFont)("Koot")


        LoadingThread = New Threading.Thread(AddressOf LoadContentBackground)
        LoadingThread.IsBackground = True

        LoadingThread.Start()
    End Sub

    Private Sub LoadContentBackground()
        AnimationSets.LoadContent(Content)



        TestWorld1.LoadContent(Content)
        TestWorld1.SetSelectedLevel(0)

        Textures.Bullet = Content.Load(Of Texture2D)("Textures/Bullet")
        Textures.ParticleSpark = Content.Load(Of Texture2D)("Textures/Spark")


        DevPurple = Content.Load(Of Texture2D)("devpurple")

        Sounds.LoadSounds(Content)
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
        If Keyboard.GetState().IsKeyDown(Keys.Escape) Then
            [Exit]()
        End If

        If LoadingThread.IsAlive Then ' if thread is loading


        Else ' if not do normal game update
            ScreenHandler.Update(gameTime)
        End If


        MyBase.Update(gameTime)
    End Sub

    ''' <summary>
    ''' This is called when the game should draw itself.
    ''' </summary>
    ''' <param name="gameTime">Provides a snapshot of timing values.</param>
    Protected Overrides Sub Draw(gameTime As GameTime)
        GraphicsDevice.Clear(Color.CornflowerBlue)

        If LoadingThread.IsAlive Then ' If thread is loading
            spriteBatch.Begin()

            spriteBatch.DrawString(FontKoot, "Loading...", New Vector2(100, 100), Color.Black)

            spriteBatch.End()
        Else ' Else do normal game draw
            ScreenHandler.Draw(spriteBatch)
        End If

        MyBase.Draw(gameTime)
    End Sub

End Class
