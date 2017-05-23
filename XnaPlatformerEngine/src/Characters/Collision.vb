Imports Microsoft.Xna.Framework

Partial Public Class Character
    Private Sub CollidingCheck(displacement As Vector2, gameTime As GameTime)
        Dim _rect As New Rectangle(CInt(getTrueRect.X + displacement.X) - 1, CInt(getTrueRect.Y + displacement.Y) - 1, getTrueRect.Width + 2, getTrueRect.Height + 2) ' 1 Pixel border

        Acceleration.Y += CSng(9.81 * gameTime.ElapsedGameTime.TotalSeconds)
        Velocity += Acceleration * CSng(gameTime.ElapsedGameTime.TotalSeconds)

        If ScreenHandler.GetSelectedScreen.GetType() = GetType(World) Then
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

    Private Function CheckCollidingVertical(displacement As Vector2) As Boolean
        If displacement.Y < 0 Then
            IsGrounded = False
            Dim _rect = New Rectangle(getTrueRect.X, CInt(getTrueRect.Y + displacement.Y - 1), getTrueRect.Width, getTrueRect.Height)
            For Each _wObj In CType(ScreenHandler.GetSelectedScreen, World).GetSelectedLevel.PlacedObjects
                If _rect.Intersects(_wObj.getTrueRect) Then
                    Position.Y = _wObj.getTrueRect.Y + _wObj.getTrueRect.Height
                    Acceleration.Y = 0
                    Velocity.Y = 0
                    Return True
                End If
            Next
            Return False

        ElseIf displacement.Y > 0 Then
            Dim _rect = New Rectangle(getTrueRect.X, CInt(getTrueRect.Y + displacement.Y + 1), getTrueRect.Width, getTrueRect.Height)
            For Each _wObj In CType(ScreenHandler.GetSelectedScreen, World).GetSelectedLevel.PlacedObjects
                If _rect.Intersects(_wObj.getTrueRect) Then
                    Position.Y = _wObj.getTrueRect.Y - getTrueRect.Height
                    Acceleration.Y = 0
                    Velocity.Y = 0
                    IsGrounded = True
                    Return True
                End If
            Next
            IsGrounded = False
            Return False

        Else
            Return False
        End If
    End Function

    Private Function CheckCollidingSides(displacement As Vector2) As Boolean
        If displacement.X < 0 Then
            Dim _rect = New Rectangle(CInt(getTrueRect.X + displacement.X - 1), getTrueRect.Y, getTrueRect.Width, getTrueRect.Height)
            For Each _wObj In CType(ScreenHandler.GetSelectedScreen, World).GetSelectedLevel.PlacedObjects
                If _rect.Intersects(_wObj.getTrueRect) Then
                    Position.X = _wObj.getTrueRect.X + _wObj.getTrueRect.Width
                    Acceleration.X = 0
                    Velocity.X = 0
                    Return True
                End If
            Next
            Return False

        ElseIf displacement.X > 0 Then
            Dim _rect = New Rectangle(CInt(getTrueRect.X + displacement.X + 1), getTrueRect.Y, getTrueRect.Width, getTrueRect.Height)
            For Each _wObj In CType(ScreenHandler.GetSelectedScreen, World).GetSelectedLevel.PlacedObjects
                If _rect.Intersects(_wObj.getTrueRect) Then
                    Position.X = _wObj.getTrueRect.X - getTrueRect.Width
                    Acceleration.X = 0
                    Velocity.X = 0
                    Return True
                End If
            Next
            Return False

        Else
            Return False ' If sideway velocity is 0 it can't collide on sides
        End If
    End Function
End Class
