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

    Public Sub LoadContent(_content As ContentManager)
        For Each _level In Levels
            _level.LoadContent(_content)
        Next

        Player.LoadContent(_content)

        PostContentLoad()
    End Sub

    Public Overrides Sub PostContentLoad()

    End Sub

    Public Sub SetSelectedLevel(index As Integer)
        SelectedLevel = Levels(index)
    End Sub

    Public Function GetSelectedLevel() As Level
        Return SelectedLevel
    End Function

    Public Overrides Sub Draw(theSpriteBatch As SpriteBatch)




        theSpriteBatch.Begin(Nothing, Nothing, SamplerState.PointClamp, Nothing, Nothing, Nothing, LevelCameraMatrix)

        If SelectedLevel IsNot Nothing Then
            For Each _object In SelectedLevel.PlacedObjects
                _object.Draw(theSpriteBatch)
            Next

            Player.Draw(theSpriteBatch)
        End If
        theSpriteBatch.End()

        CameraFocusOnObject(Player)
    End Sub

    Public Overrides Sub Update(gameTime As GameTime)
        If SelectedLevel IsNot Nothing Then
            SelectedLevel.Update(gameTime)
            Player.Update(gameTime)
        End If
    End Sub

    Private Sub CameraFocusOnObject(_obj As Sprite)
        LevelCameraMatrix.Translation = New Vector3(-CInt(_obj.getTrueRect.X - graphics.PreferredBackBufferWidth / 2), -CInt(_obj.getTrueRect.Y - graphics.PreferredBackBufferHeight / 2), 0)
    End Sub

    Public Sub LoadLevel()

    End Sub
End Class
