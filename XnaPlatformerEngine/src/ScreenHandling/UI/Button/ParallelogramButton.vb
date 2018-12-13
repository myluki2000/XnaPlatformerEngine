Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Input

Public Class ParallelogramButton
    Inherits Button

    Public Tilt As Integer = 30

    Private SweepPosition As Integer = -30

    Public Overrides Sub Draw(sb As SpriteBatch)
        If Visible Then

            DrawFilledParallelogram(sb, Color.Red, rect)


            ' Draw checked button
            If Checked Then

            End If

            If rect.Contains(Mouse.GetState.Position) Then
                If Mouse.GetState.LeftButton = ButtonState.Pressed Then
                    ' Draw clicked button

                Else
                    ' Draw hovered button
                    DrawFilledParallelogram(sb,
                                            Color.Blue,
                                            New Rectangle(rect.X + Math.Max(SweepPosition, 0),
                                                          rect.Top,
                                                          Math.Min(60 + Math.Min(SweepPosition, 0), rect.Width - SweepPosition),
                                                          rect.Height))
                    SweepPosition += 1

                    If SweepPosition = rect.Width - 30 Then
                        SweepPosition = -30
                    End If
                End If
            Else
                ' Draw normal button

            End If


            DrawOutlines(sb, Color.Black)


            MyBase.Draw(sb)
        End If
    End Sub

    Private Sub OnMouseLeave(sender As Object) Handles Me.MouseLeave
        SweepPosition = -30
    End Sub

    Private Sub DrawOutlines(sb As SpriteBatch, color As Color)
        ' Left outline
        Misc.DrawLine(sb,
                      New Vector2(rect.Left, rect.Bottom),
                      New Vector2(rect.Left + Tilt, rect.Top),
                      color,
                      5)

        ' Right outline
        Misc.DrawLine(sb,
                      New Vector2(rect.Right, rect.Top + 3),
                      New Vector2(rect.Right - Tilt, rect.Bottom + 2),
                      color,
                      5)

        ' Bottom outline
        Misc.DrawLine(sb,
                      New Vector2(rect.Left, rect.Bottom - 1),
                      New Vector2(rect.Right - Tilt, rect.Bottom - 1),
                      color,
                      5)

        ' Top outline
        Misc.DrawLine(sb,
                      New Vector2(rect.Left + Tilt, rect.Top),
                      New Vector2(rect.Right, rect.Top),
                      color,
                      5)
    End Sub

    Private Sub DrawFilledParallelogram(sb As SpriteBatch, color As Color, rect As Rectangle)
        For x As Integer = rect.Left To rect.Right - Tilt - 2
            Misc.DrawLine(sb,
                      New Vector2(x, rect.Bottom),
                      New Vector2(x + Tilt, rect.Top),
                      color)
        Next
    End Sub
End Class
