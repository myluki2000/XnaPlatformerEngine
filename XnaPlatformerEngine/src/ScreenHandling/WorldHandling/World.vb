Imports System.Collections.Generic
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Content
Imports Microsoft.Xna.Framework.Graphics

Public Class World
    Inherits Screen

    ''' <summary>
    ''' A list of all levels that are part of this world
    ''' </summary>
    Public Levels As New List(Of Level)
    Private _selectedLevel As Level
    ''' <summary>
    ''' The player in this world
    ''' </summary>
    Public Player As New Player With {.Scale = 2, .Position = New Vector2(200, 0)}

    ''' <summary>
    ''' Gets or sets the level of the world which is currently being run
    ''' </summary>
    Public Property SelectedLevel As Level
        Get
            Return _selectedLevel
        End Get
        Set(value As Level)

            _selectedLevel = value

            ' Sets the player's position to that of the player spawner
            For Each wObj In value.PlacedObjects
                If wObj.GetType = GetType(PlayerSpawn) Then
                    Player.Position = wObj.GetTrueRect.Location.ToVector2
                End If
            Next
        End Set
    End Property

    ''' <summary>
    ''' Loads a level from a level file and adds it to the Levels list
    ''' </summary>
    ''' <param name="path">Path to the level file</param>
    ''' <param name="name">Unique name of the level</param>
    ''' <param name="Content">Content manager of the game</param>
    Public Sub LoadLevel(path As String, name As String, Content As ContentManager)
        'Levels.Add(New Level(LevelLoader.LoadLevel(_path, Content)) With {.Name = _name, .LightPolygons = LevelLoader.LightPolygons})
        Dim lvl = LevelLoader.LoadLevel(path, Content)
        lvl.Name = name

        Levels.Add(lvl)
    End Sub

    ''' <summary>
    ''' Loads the content for all levels in this world.
    ''' MUST BE RUN ONLY AFTER ALL LEVELS HAVE BEEN LOADED, OTHERWISE RESOURCES MAY NOT BE LOADED
    ''' </summary>
    ''' <param name="Content"></param>
    Public Sub LoadContent(Content As ContentManager)
        For Each _level In Levels
            _level.LoadContent(Content)
        Next
    End Sub

    Public Overrides Sub Draw(sb As SpriteBatch)

        If SelectedLevel IsNot Nothing Then
            SelectedLevel.Draw(sb, Player)
        End If


        sb.Begin()

        DrawUI(sb)

        For Each NPC In SelectedLevel.NPCs
            NPC.DrawDialogue(sb)
        Next

        sb.End()

        CameraFocusOnObject(Player)
    End Sub

    Public Overrides Sub Update(gameTime As GameTime)
        If SelectedLevel IsNot Nothing Then
            SelectedLevel.Update(gameTime, Player)
            Player.Update(gameTime)

            If Player.HealthPoints < 1 Then
                MsgBox("Omae Wa Mou Shindeiru")
                ' TODO: Change this to a proper death scene
            End If
        End If
    End Sub

    Private Sub CameraFocusOnObject(_obj As Sprite)
        ScreenHandler.SelectedScreen.ToWorld.SelectedLevel.Camera.Translation = New Vector3(-CInt(_obj.GetTrueRect.X - graphics.PreferredBackBufferWidth / 2), -CInt(_obj.GetTrueRect.Y - graphics.PreferredBackBufferHeight / 2) + 200, 0)
    End Sub

    Public Sub DrawUI(_sb As SpriteBatch)
        _sb.DrawString(Fonts.ChakraPetch, Player.Weapon.ProjectilesInMag & "/" & Player.Weapon.ProjectilesMagMax, New Vector2(10, 10), Color.Black)
    End Sub
End Class
