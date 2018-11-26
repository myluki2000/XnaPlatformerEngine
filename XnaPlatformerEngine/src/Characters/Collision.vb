Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Input

Partial Public Class Character
    Private Sub CollidingCheck(displacement As Vector2, gameTime As GameTime)
        Dim _rect As New Rectangle(CInt(GetTrueRect.X + displacement.X) - 1, CInt(GetTrueRect.Y + displacement.Y) - 1, GetTrueRect.Width + 2, GetTrueRect.Height + 2) ' 1 Pixel border

        Acceleration.Y += CSng(700 * gameTime.ElapsedGameTime.TotalSeconds + 0.01)

        Velocity += Acceleration * CSng(gameTime.ElapsedGameTime.TotalSeconds)

        If Velocity.Y < 0 AndAlso Not Keyboard.GetState.IsKeyDown(Keys.Space) Then
            Velocity += Acceleration * CSng(gameTime.ElapsedGameTime.TotalSeconds) ' Variable jump hight by adding acceleration again if not pressing jump button
        End If

        If ScreenHandler.SelectedScreen.GetType() = GetType(World) Then
            Dim colBot As Boolean = CheckCollidingVertical(displacement)


            If colBot Then

            Else
                Position.Y += CSng(Velocity.Y * gameTime.ElapsedGameTime.TotalSeconds)
            End If

            If CheckCollidingSides(displacement) Then

            Else
                Position.X += CSng(Velocity.X * gameTime.ElapsedGameTime.TotalSeconds)
            End If

        End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="displacement"></param>
    ''' <returns>True = Is Colliding, False = Is Not Colliding</returns>
    Private Function CheckCollidingVertical(displacement As Vector2) As Boolean
        Try
            If displacement.Y < 0 Then
                ' Ceiling collision detection
                IsGrounded = False
                Dim playerRect = New Rectangle(GetTrueRect.X, CInt(GetTrueRect.Y + displacement.Y - 1), GetTrueRect.Width, GetTrueRect.Height)

                Dim wObjColliding = GetWorldObjectRectIsColliding(playerRect)
                If wObjColliding IsNot Nothing Then
                    Position.Y = wObjColliding.GetTrueRect.Y + wObjColliding.GetTrueRect.Height
                    Acceleration.Y = 0
                    Velocity.Y = 0
                    Return True
                Else
                    Return False
                End If


            ElseIf displacement.Y > 0 Then
                ' Floor collision detection
                Dim playerRect = New Rectangle(GetTrueRect.X, CInt(GetTrueRect.Y + displacement.Y + 1), GetTrueRect.Width, GetTrueRect.Height)

                Dim wObjColliding = GetWorldObjectRectIsColliding(playerRect)
                If wObjColliding IsNot Nothing Then
                    Position.Y = wObjColliding.GetTrueRect.Y - GetTrueRect.Height
                    Acceleration.Y = 0
                    Velocity.Y = 0
                    IsGrounded = True
                    Return True
                Else
                    IsGrounded = False
                    Return False
                End If



            Else
                Return False
            End If
        Catch ex As IndexOutOfRangeException
            Return False
        End Try
    End Function

    Private Function CheckCollidingSides(displacement As Vector2) As Boolean
        Try
            If displacement.X < 0 Then ' collision check on left side
                Dim playerRect = New Rectangle(CInt(GetTrueRect.X + displacement.X - 1), GetTrueRect.Y, GetTrueRect.Width, GetTrueRect.Height)

                Dim wObjColliding = GetWorldObjectRectIsColliding(playerRect)
                If wObjColliding IsNot Nothing Then
                    Position.X = wObjColliding.GetTrueRect.X + wObjColliding.GetTrueRect.Width
                    Acceleration.X = 0
                    Velocity.X = 0
                    Return True
                Else
                    Return False
                End If


            ElseIf displacement.X > 0 Then ' collision check on right side
                Dim playerRect = New Rectangle(CInt(GetTrueRect.X + displacement.X + 1), GetTrueRect.Y, GetTrueRect.Width, GetTrueRect.Height)

                Dim wObjColliding = GetWorldObjectRectIsColliding(playerRect)
                If wObjColliding IsNot Nothing Then
                    Position.X = wObjColliding.GetTrueRect.X - GetTrueRect.Width
                    Acceleration.X = 0
                    Velocity.X = 0
                    Return True
                Else
                    Return False
                End If

            Else
                Return False ' If sideway velocity is 0 it can't collide on sides
            End If
        Catch ex As IndexOutOfRangeException
            Return False
        End Try
    End Function

    Private Function GetWorldObjectRectIsColliding(rect As Rectangle) As WorldObject
        For Each wObj In ScreenHandler.SelectedScreen.ToWorld.SelectedLevel.PlacedObjects
            If rect.Intersects(wObj.GetTrueRect) AndAlso wObj.zIndex = 0 Then
                Return wObj
            End If
        Next
        Return Nothing
    End Function
End Class
