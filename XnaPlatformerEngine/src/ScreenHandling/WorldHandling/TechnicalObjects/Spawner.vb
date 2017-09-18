Imports Microsoft.Xna.Framework

Public Class Spawner
    Inherits TechnicalObject

    Public ID As String

    Public EnemySpawned As Boolean = False

    'Public EnemyTypeToSpawn As Enemy = New DebugEnemy

    Sub New()
        Name = "Spawner"
    End Sub

    Public Overrides Sub Update(gameTime As GameTime)
        MyBase.Update(gameTime)

        If Not EnemySpawned Then
            SpawnEnemy()
            EnemySpawned = True
        End If
    End Sub

    Public Sub SpawnEnemy()
        Dim _e As New Enemy(32, New Rectangle(0, 0, 32, 32)) With {.Position = Me.getTrueRect.Location.ToVector2, .Animations = AnimationSets.Player}
        _e.SetSelectedAnimation("idle")

        ScreenHandler.SelectedScreen.ToWorld.SelectedLevel.NPCs.Add(_e)
    End Sub
End Class
