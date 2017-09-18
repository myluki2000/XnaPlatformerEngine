Imports Microsoft.Xna.Framework

Partial Public Class Character
    Private Sub CollidingCheck(displacement As Vector2, gameTime As GameTime)
        Dim _rect As New Rectangle(CInt(getTrueRect.X + displacement.X) - 1, CInt(getTrueRect.Y + displacement.Y) - 1, getTrueRect.Width + 2, getTrueRect.Height + 2) ' 1 Pixel border

        Acceleration.Y += CSng(320 * gameTime.ElapsedGameTime.TotalSeconds + 0.01)
        Velocity += Acceleration * CSng(gameTime.ElapsedGameTime.TotalSeconds)

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

    Private Function CheckCollidingVertical(displacement As Vector2) As Boolean
        Try
            Dim SelectedLevel As Level = ScreenHandler.SelectedScreen.ToWorld.SelectedLevel
            If displacement.Y < 0 Then
                IsGrounded = False
                Dim _rect = New Rectangle(getTrueRect.X, CInt(getTrueRect.Y + displacement.Y - 1), getTrueRect.Width, getTrueRect.Height)
                For ind As Integer = 0 To SelectedLevel.PlacedObjects.GetLength(0) - 1
                    Dim _wObj As WorldObject = SelectedLevel.PlacedObjects(ind, CInt(Math.Floor(_rect.Top / 30)), 50) ' Z = 50 because z-index = 0 is 50 in the array
                    If _wObj IsNot Nothing AndAlso _wObj.GetType = GetType(WorldObject) Then
                        If _rect.Intersects(_wObj.getTrueRect) Then
                            Position.Y = _wObj.getTrueRect.Y + _wObj.getTrueRect.Height
                            Acceleration.Y = 0
                            Velocity.Y = 0
                            Return True
                        End If
                    End If
                Next
                Return False

            ElseIf displacement.Y > 0 Then
                Dim _rect = New Rectangle(getTrueRect.X, CInt(getTrueRect.Y + displacement.Y + 1), getTrueRect.Width, getTrueRect.Height)
                For ind As Integer = 0 To SelectedLevel.PlacedObjects.GetLength(0) - 1
                    Dim _wObj As WorldObject = SelectedLevel.PlacedObjects(ind, CInt(Math.Floor(_rect.Bottom / 30)), 50) ' Z = 50 because z-index = 0 is 50 in the array
                    If _wObj IsNot Nothing AndAlso _wObj.GetType = GetType(WorldObject) Then
                        If _rect.Intersects(_wObj.getTrueRect) Then
                            Position.Y = _wObj.getTrueRect.Y - getTrueRect.Height
                            Acceleration.Y = 0
                            Velocity.Y = 0
                            IsGrounded = True
                            Return True
                        End If
                    End If
                Next

                Dim sideRectRight As New Rectangle(getTrueRect.Right, CInt(getTrueRect.Y), 10, 5)
                For ind As Integer = 0 To SelectedLevel.PlacedObjects.GetLength(1) - 1
                    Dim _wObj As WorldObject = SelectedLevel.PlacedObjects(CInt(Math.Floor(sideRectRight.Right / 30)), ind, 50)
                    If _wObj IsNot Nothing AndAlso _wObj.GetType = GetType(WorldObject) Then
                        If sideRectRight.Intersects(_wObj.getTrueRect) Then
                            Acceleration.Y = 0
                            Velocity.Y = 0
                            IsGrounded = True
                            Return True
                        End If
                    End If
                Next

                Dim sideRectLeft As New Rectangle(getTrueRect.Left - 10, CInt(getTrueRect.Y), 10, 5)
                For ind As Integer = 0 To SelectedLevel.PlacedObjects.GetLength(1) - 1
                    Dim _wObj As WorldObject = SelectedLevel.PlacedObjects(CInt(Math.Floor(sideRectLeft.Left / 30)), ind, 50)
                    If _wObj IsNot Nothing AndAlso _wObj.GetType = GetType(WorldObject) Then
                        If sideRectLeft.Intersects(_wObj.getTrueRect) Then
                            Acceleration.Y = 0
                            Velocity.Y = 0
                            IsGrounded = True
                            Return True
                        End If
                    End If
                Next

                IsGrounded = False
                Return False

            Else
                Return False
            End If
        Catch ex As IndexOutOfRangeException
            Return False
        End Try
    End Function

    Private Function CheckCollidingSides(displacement As Vector2) As Boolean
        Try
            If displacement.X < 0 Then
                Dim _rect = New Rectangle(CInt(getTrueRect.X + displacement.X - 1), getTrueRect.Y, getTrueRect.Width, getTrueRect.Height)
                For ind As Integer = 0 To ScreenHandler.SelectedScreen.ToWorld.SelectedLevel.PlacedObjects.GetLength(1) - 1
                    Dim _wObj As WorldObject = ScreenHandler.SelectedScreen.ToWorld.SelectedLevel.PlacedObjects(CInt(Math.Floor(_rect.Left / 30)), ind, 50) ' Z = 50 because z-index = 0 is 50 in the array
                    If _wObj IsNot Nothing AndAlso _wObj.GetType = GetType(WorldObject) Then
                        If _rect.Intersects(_wObj.getTrueRect) AndAlso _wObj.zIndex = 0 Then
                            Position.X = _wObj.getTrueRect.X + _wObj.getTrueRect.Width
                            Acceleration.X = 0
                            Velocity.X = 0
                            Return True
                        End If
                    End If
                Next
                Return False

            ElseIf displacement.X > 0 Then
                Dim _rect = New Rectangle(CInt(getTrueRect.X + displacement.X + 1), getTrueRect.Y, getTrueRect.Width, getTrueRect.Height)
                For ind As Integer = 0 To ScreenHandler.SelectedScreen.ToWorld.SelectedLevel.PlacedObjects.GetLength(1) - 1
                    Dim _wObj As WorldObject = ScreenHandler.SelectedScreen.ToWorld.SelectedLevel.PlacedObjects(CInt(Math.Floor(_rect.Right / 30)), ind, 50) ' Z = 50 because z-index = 0 is 50 in the array
                    If _wObj IsNot Nothing AndAlso _wObj.GetType = GetType(WorldObject) Then
                        If _rect.Intersects(_wObj.getTrueRect) AndAlso _wObj.zIndex = 0 Then
                            Position.X = _wObj.getTrueRect.X - getTrueRect.Width
                            Acceleration.X = 0
                            Velocity.X = 0
                            Return True
                        End If
                    End If
                Next
                Return False

            Else
                Return False ' If sideway velocity is 0 it can't collide on sides
            End If
        Catch ex As IndexOutOfRangeException
            Return False
        End Try
    End Function
End Class
