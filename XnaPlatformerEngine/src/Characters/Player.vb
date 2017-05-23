Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Input

Public Class Player
    Inherits Character

    Sub New()
        MyBase.New(32, New Rectangle(0, 0, 32, 32))
        Animations.Add(New Animation("idle", "Characters/Player/idle", 500))
        SetSelectedAnimation("idle")
    End Sub

    Public Overrides Sub Update(gameTime As GameTime)
        If Keyboard.GetState.IsKeyDown(Keys.A) Then
            Velocity.X = -20
        ElseIf Keyboard.GetState.IsKeyDown(Keys.D) Then
            Velocity.X = 20
        Else
            Velocity.X = 0
        End If

        MyBase.Update(gameTime)
    End Sub
End Class
