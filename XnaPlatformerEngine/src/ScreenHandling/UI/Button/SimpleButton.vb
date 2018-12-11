Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Input

Public Class SimpleButton
    Inherits Button

    Public BackgroundColor As Color = Color.Gray

    Public Overrides Sub Draw(sb As SpriteBatch)
        If Visible Then
            ' Draw checked button
            If Checked Then
                Misc.DrawRectangle(sb, New Rectangle(rect.X - 2, rect.Y - 2, rect.Width + 4, rect.Height + 4), Color.Blue)
            End If

            If rect.Contains(Mouse.GetState.Position) Then
                If Mouse.GetState.LeftButton = ButtonState.Pressed Then
                    ' Draw clicked button
                    Misc.DrawRectangle(sb, rect, Misc.SubtractColors(BackgroundColor, New Color(90, 90, 90)))
                Else
                    ' Draw hovered button
                    Misc.DrawRectangle(sb, rect, Misc.SubtractColors(BackgroundColor, New Color(30, 30, 30)))
                End If
            Else
                ' Draw normal button
                Misc.DrawRectangle(sb, rect, BackgroundColor)
            End If


            ' Draw Button label
            Select Case TextAlignment
                Case Alignments.Center
                    sb.DrawString(Fonts.ChakraPetch.Normal, Text, New Vector2(CSng(rect.X + rect.Width / 2 - Fonts.ChakraPetch.Normal.MeasureString(Text).X / 2), CSng(rect.Y + rect.Height / 2 - Fonts.ChakraPetch.Normal.MeasureString(Text).Y / 2)), Color.Black)
                Case Alignments.Left
                    sb.DrawString(Fonts.ChakraPetch.Normal, Text, New Vector2(rect.X + SidePadding, CSng(rect.Y + rect.Height / 2 - Fonts.ChakraPetch.Normal.MeasureString(Text).Y / 2)), Color.Black)
                Case Alignments.Right
                    sb.DrawString(Fonts.ChakraPetch.Normal, Text, New Vector2(rect.Right - Fonts.ChakraPetch.Normal.MeasureString(Text).X - SidePadding, CSng(rect.Y + rect.Height / 2 - Fonts.ChakraPetch.Normal.MeasureString(Text).Y / 2)), Color.Black)
            End Select

            MyBase.Draw(sb)
        End If
    End Sub
End Class
