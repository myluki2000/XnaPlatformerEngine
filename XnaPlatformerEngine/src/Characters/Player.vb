Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Input

Public Class Player
    Inherits Character

    Public IsInDialogue As Boolean = False

    Sub New()
        MyBase.New(32, CharacterTypes.Player)

        Animations = AnimationSets.Player

        SetSelectedAnimation("idle")
    End Sub


    Public Overrides Sub Update(gameTime As GameTime)
        Dim maxSpeed = 150

        If Not IsInDialogue Then
            If Keyboard.GetState.IsKeyDown(Keys.A) Then
                If Velocity.X > 0 Then
                    Velocity.X += -16 ' Slowing down quicker if trying to move in opposite direction
                ElseIf Velocity.X > -maxSpeed Then
                    Velocity.X += -8
                End If
            ElseIf Keyboard.GetState.IsKeyDown(Keys.D) Then
                If Velocity.X < 0 Then
                    Velocity.X += 16
                ElseIf Velocity.X < maxSpeed Then
                    Velocity.X += 8
                End If
            Else
                If IsGrounded Then
                    If Velocity.X > 0 Then
                        Velocity.X += -12
                    ElseIf Velocity.X < 0 Then
                        Velocity.X += 12
                    End If

                Else
                    ' Less friction if in the air
                    If Velocity.X > 0 Then
                        Velocity.X += -2
                    ElseIf Velocity.X < 0 Then
                        Velocity.X += 2
                    End If
                End If

                If Velocity.X < 13 AndAlso Velocity.X > -13 Then
                    Velocity.X = 0 ' Make sure that character can stop completely and doesn't get stuck with a small velocity in some direction
                End If
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

            ActivateWorldObjectsInRange()

            MyBase.Update(gameTime)
        End If
    End Sub

    Public Sub ActivateWorldObjectsInRange()
        For Each wObj In ScreenHandler.SelectedScreen.ToWorld.SelectedLevel.PlacedObjects
            If wObj IsNot Nothing Then
                If Vector2.Distance(wObj.GetTrueRect.Location.ToVector2, Me.Position) < 10 Then
                    wObj.IsPlayerInRange = True
                Else
                    wObj.IsPlayerInRange = False
                End If
            End If
        Next
    End Sub

    Public Sub Interact()
        Dim SelectedLevel = ScreenHandler.SelectedScreen.ToWorld.SelectedLevel

        For Each NPC In SelectedLevel.NPCs
            If NPC.GetTrueRect.Intersects(Me.GetTrueRect) Then
                NPC.Interaction()
                Return
            End If
        Next

        For Each wObj In SelectedLevel.PlacedObjects
            If wObj IsNot Nothing AndAlso wObj.GetTrueRect.Intersects(New Rectangle(GetTrueRect.Left - 10, GetTrueRect.Top, GetTrueRect.Width + 20, GetTrueRect.Height)) Then
                wObj.Interaction()
                Return
            End If
        Next
    End Sub

    Private Sub ShootAtMouse()
        Weapon.ShootAt(Misc.ScreenPosToWorldPos(Mouse.GetState.Position))
    End Sub
End Class
