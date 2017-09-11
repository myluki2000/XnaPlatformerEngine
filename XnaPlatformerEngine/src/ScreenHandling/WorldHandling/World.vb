Imports System.Collections.Generic
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Content
Imports Microsoft.Xna.Framework.Graphics

Public Class World
    Inherits Screen

    Public Levels As New List(Of Level)
    Private SelectedLevel As Level
    Public Player As New Player With {.Scale = 2}

    Sub New()
        Matrix.CreateTranslation(0, 0, 0, LevelCameraMatrix)
    End Sub

    Public Sub LoadContent(Content As ContentManager)
        For Each _level In Levels
            _level.LoadContent(Content)
        Next

        PostContentLoad()
    End Sub

    Public Overrides Sub PostContentLoad()

    End Sub

    Public Sub SetSelectedLevel(index As Integer)
        SelectedLevel = Levels(index)

        For x As Integer = 0 To SelectedLevel.PlacedObjects.GetLength(0) - 1
            For y As Integer = 0 To SelectedLevel.PlacedObjects.GetLength(1) - 1
                If SelectedLevel.PlacedObjects(x, y, 50) IsNot Nothing AndAlso SelectedLevel.PlacedObjects(x, y, 50).GetType = GetType(PlayerSpawn) Then
                    Player.Position = SelectedLevel.PlacedObjects(x, y, 50).getTrueRect.Location.ToVector2
                End If
            Next
        Next
    End Sub

    Public Function GetSelectedLevel() As Level
        Return SelectedLevel
    End Function

    Public Overrides Sub Draw(sb As SpriteBatch)

        sb.Begin(Nothing, Nothing, SamplerState.PointClamp, Nothing, Nothing, Nothing, LevelCameraMatrix)

        If SelectedLevel IsNot Nothing Then
            SelectedLevel.Draw(sb, Player)
        End If
        sb.End()


        sb.Begin()

        DrawUI(sb)

        sb.End()

        CameraFocusOnObject(Player)
    End Sub

    Public Overrides Sub Update(gameTime As GameTime)
        If SelectedLevel IsNot Nothing Then
            SelectedLevel.Update(gameTime)
            Player.Update(gameTime)

            If Player.HealthPoints < 1 Then
                MsgBox("omae wa shindeiru")
                End
            End If
        End If
    End Sub

    Private Sub CameraFocusOnObject(_obj As Sprite)
        LevelCameraMatrix.Translation = New Vector3(-CInt(_obj.getTrueRect.X - graphics.PreferredBackBufferWidth / 2), -CInt(_obj.getTrueRect.Y - graphics.PreferredBackBufferHeight / 2), 0)
    End Sub

    Public Sub LoadLevel()

    End Sub

    Public Sub DrawUI(_sb As SpriteBatch)
        _sb.DrawString(FontKoot, Player.Weapon.ProjectilesInMag & "/" & Player.Weapon.ProjectilesMagMax, New Vector2(10, 10), Color.Black)
    End Sub
End Class
