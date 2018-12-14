Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Input

Public Class ParallelogramButton
    Inherits Button

    Private Tilt As Integer = 30 ' Other values are set exactly for this tilt value! Don't change!

    Private SweepPosition As Integer = -60
    Private Iteration As Integer = 0

    Public Overrides Sub Draw(sb As SpriteBatch)

        If Visible Then

            If rect.Contains(Mouse.GetState.Position) Then
                DrawFilledParallelogram(sb, New Color(186, 186, 186), rect)
            Else
                DrawFilledParallelogram(sb, Color.White, rect)
            End If

            Dim textPos As New Vector2(rect.Center.X - Fonts.ChakraPetch.Large.MeasureString(Text).X / 2, rect.Center.Y - Fonts.ChakraPetch.Large.MeasureString(Text).Y / 2)
            sb.DrawString(Fonts.ChakraPetch.Large, Text, textPos, Color.Black)

            ' Draw checked button
            If Checked Then

            End If

            If rect.Contains(Mouse.GetState.Position) OrElse SweepPosition > -30 Then
                If Mouse.GetState.LeftButton = ButtonState.Pressed Then
                    ' Draw clicked button

                Else
                    ' Draw hovered button

                    DrawFilledParallelogram(sb,
                                            Color.Black,
                                            New Rectangle(rect.X + Math.Max(SweepPosition, 0),
                                                          rect.Top,
                                                          Math.Min(90 + Math.Min(SweepPosition, 0), rect.Width - SweepPosition),
                                                          rect.Height))

                    DrawOverlayTextTexture(sb, textPos, SweepPosition, 60)

                    SweepPosition += 16

                    If Iteration >= 1 Then
                        If SweepPosition > rect.Width + 300 Then
                            SweepPosition = -60
                            Iteration = 0
                        End If
                    Else
                        If SweepPosition > rect.Width Then
                            SweepPosition = -60
                            Iteration += 1
                        End If
                    End If
                End If
            Else
                ' Draw normal button
                sb.DrawString(Fonts.ChakraPetch.Large, Text, textPos, Color.Black)
            End If


            DrawOutlines(sb, Color.Black)


            MyBase.Draw(sb)
        End If
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

    Private Sub DrawOverlayTextTexture(sb As SpriteBatch, textPos As Vector2, startPos As Integer, width As Integer)

        ' TODO: This method could probably be optimized, but I can't be arsed to find out how exactly render targets behave for spritebatches with begin() called

        Dim rt As New RenderTarget2D(graphics.GraphicsDevice, 500, 150)

        Dim tmpSb As New SpriteBatch(graphics.GraphicsDevice)

        graphics.GraphicsDevice.SetRenderTarget(rt)
        graphics.GraphicsDevice.Clear(Color.Transparent)
        graphics.GraphicsDevice.ScissorRectangle = New Rectangle(startPos - 20, 0, width, rt.Height)
        tmpSb.Begin(,,,, New RasterizerState With {.ScissorTestEnable = True},,)

        tmpSb.DrawString(Fonts.ChakraPetch.Large, Text, New Vector2(0, 100), Color.White, -CSng(Math.Atan(Tilt / rect.Height)), Nothing, 1, Nothing, Nothing)

        tmpSb.End()
        graphics.GraphicsDevice.ScissorRectangle = Nothing
        graphics.GraphicsDevice.SetRenderTarget(Nothing)
        graphics.GraphicsDevice.Clear(Color.CornflowerBlue)

        sb.Draw(rt, New Vector2(textPos.X + 22, textPos.Y - 98), Nothing, Color.White, CSng(Math.Atan(Tilt / rect.Height)), Nothing, 1, Nothing, Nothing)
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
