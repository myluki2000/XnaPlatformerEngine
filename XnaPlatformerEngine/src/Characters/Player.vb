Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Input

Public Class Player
    Inherits Character

    Sub New()
        MyBase.New(32, New Rectangle(0, 0, 32, 32), CharacterTypes.Player)

        Animations = AnimationSets.Player

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

        If Keyboard.GetState.IsKeyDown(Keys.E) Then
            Interact()
        End If

        If Mouse.GetState.LeftButton = ButtonState.Pressed AndAlso Not Weapon.CurrentlyReloading Then
            ShootAtMouse()
        End If

        If Keyboard.GetState.IsKeyDown(Keys.R) AndAlso Not Weapon.CurrentlyReloading AndAlso Weapon.ProjectilesInMag < Weapon.ProjectilesMagMax Then
            Weapon.ReloadWeapon(gameTime)
        End If

        MyBase.Update(gameTime)
    End Sub

    Public Sub Interact()
        Dim SelectedLevel = ScreenHandler.SelectedScreen.ToWorld.SelectedLevel

        For Each NPC In SelectedLevel.NPCs
            If NPC.getTrueRect.Intersects(Me.getTrueRect) Then
                NPC.Interaction()
                Return
            End If
        Next

        For x As Integer = 0 To SelectedLevel.PlacedObjects.GetUpperBound(0)
            Dim _wObj As WorldObject = SelectedLevel.PlacedObjects(x, CInt(Me.getTrueRect.Center.Y / 30), 50)

            If _wObj IsNot Nothing AndAlso _wObj.getTrueRect.Intersects(New Rectangle(Me.getTrueRect.Left - 10, Me.getTrueRect.Top, Me.getTrueRect.Width + 20, Me.getTrueRect.Height)) Then
                _wObj.Interaction()
                Return
            End If
        Next
    End Sub

    Private Sub ShootAtMouse()
        Weapon.ShootAt(Misc.ScreenPosToWorldPos(Mouse.GetState.Position))
    End Sub
End Class
