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
            Velocity.X = -100
        ElseIf Keyboard.GetState.IsKeyDown(Keys.D) Then
            Velocity.X = 100
        Else
            Velocity.X = 0
        End If
        If Keyboard.GetState.IsKeyDown(Keys.Space) Then
            Jump()
        End If

        If Mouse.GetState.LeftButton = ButtonState.Pressed AndAlso Not Weapon.CurrentlyReloading Then
            ShootAtMouse()
        End If

        If Keyboard.GetState.IsKeyDown(Keys.R) OrElse Weapon.CurrentlyReloading OrElse Weapon.ProjectilesInMag < 1 Then
            Weapon.ReloadWeapon(gameTime)
        End If

        MyBase.Update(gameTime)
    End Sub

    Private Sub ShootAtMouse()
        Weapon.ShootAt(Misc.ScreenPosToWorldPos(Mouse.GetState.Position))
    End Sub
End Class
