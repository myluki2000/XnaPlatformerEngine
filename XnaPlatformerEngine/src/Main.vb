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
    Dim MainMenu As New MainMenu
    Dim LoadingScreen As New LoadingScreen


    Dim LoadingThread As New Threading.Thread(AddressOf LoadWorldContentBackground)
    Public Shared worldFilePath As String = ""

    Public Shared LoadWorldOnNextUpdate As Boolean = False
    Public Shared BackColor As Color = Color.CornflowerBlue

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

        ScreenHandler.SelectedScreen = MainMenu


        graphics.PreferredBackBufferHeight = 1080
        graphics.PreferredBackBufferWidth = 1920
        graphics.IsFullScreen = False
        graphics.ApplyChanges()

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
        FontKoot = Content.Load(Of SpriteFont)("Koot")
        FontHand.LoadContent(Content, "Fonts/FontSheet", 70)

        LoadingScreen.LoadContent(Content)
        MainMenu.LoadContent(Content)
    End Sub

    Private Sub LoadWorldContentBackground()
        InfoBox.Texture = Content.Load(Of Texture2D)("UI/Textures/info_box")

        Dialogue.SpeechBox = Content.Load(Of Texture2D)("UI/Textures/speech_box")

        TestWorld1 = WorldLoader.LoadWorld(worldFilePath, Content)


        TestWorld1.LoadContent(Content)
        TestWorld1.SelectedLevel = TestWorld1.Levels(0)
        ScreenHandler.SelectedScreen = TestWorld1


        AnimationSets.LoadContent(Content)

        Textures.LoadTextures(Content)

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



        If LoadWorldOnNextUpdate Then
            LoadWorldOnNextUpdate = False

            LoadingThread.IsBackground = True

            LoadingThread.Start()
        End If

        If LoadingThread.IsAlive Then ' if thread is loading
            LoadingScreen.Update(gameTime)

        Else ' if not do normal game update

            If Not InfoBox.Active Then
                ScreenHandler.Update(gameTime)
            End If
        End If

            MyBase.Update(gameTime)
    End Sub

    ''' <summary>
    ''' This is called when the game should draw itself.
    ''' </summary>
    ''' <param name="gameTime">Provides a snapshot of timing values.</param>
    Protected Overrides Sub Draw(gameTime As GameTime)
        InfoBox.DrawRT(spriteBatch, gameTime)

        If LoadingThread.IsAlive Then ' If thread is loading
            GraphicsDevice.Clear(Color.White)

            LoadingScreen.Draw(spriteBatch)

        Else ' Else do normal game draw
            GraphicsDevice.Clear(BackColor)

            ScreenHandler.Draw(spriteBatch)
        End If

        InfoBox.Draw(spriteBatch)

        MyBase.Draw(gameTime)
    End Sub
End Class
