Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Input

Public Class Button
    Inherits UIElement

    Public Event Click(sender As Object)
    Public text As String = "Button"
    Public BackgroundColor As Color = Color.Gray
    Public BackgroundTexture As Texture2D
    Public ClickEffect As ClickEffects = ClickEffects.None
    Public ToggleButton As Boolean = False
    Public Checked As Boolean = False
    Public Enabled As Boolean = True
    Public TextAlignment As Alignments
    Public SidePadding As Integer = 5

    Public Enum ClickEffects
        None
        BlueBorder
    End Enum

    Public Enum Alignments
        Left
        Center
        Right
    End Enum

    Sub New()
        Visible = True
    End Sub

    Dim MouseLastState As MouseState
    Public Overrides Sub Draw(sb As SpriteBatch)
        If Visible Then
            ' Click detection
            If rect.Contains(Mouse.GetState.Position) AndAlso Mouse.GetState.LeftButton = ButtonState.Released AndAlso MouseLastState.LeftButton = ButtonState.Pressed Then
                Select Case ClickEffect
                    Case ClickEffects.BlueBorder
                        Misc.DrawRectangle(sb, New Rectangle(rect.X - 2, rect.Y - 2, rect.Width + 4, rect.Height + 4), Color.Blue)
                End Select

                If Checked Then
                    Checked = False
                Else
                    Checked = True
                End If

                If Enabled Then
                    RaiseEvent Click(Me)
                End If
            End If

            If ToggleButton = True AndAlso Checked = True Then
                Misc.DrawRectangle(sb, New Rectangle(rect.X - 2, rect.Y - 2, rect.Width + 4, rect.Height + 4), Color.Blue)
            End If
            If rect.Contains(Mouse.GetState.Position) Then
                Misc.DrawRectangle(sb, rect, Misc.SubtractColors(BackgroundColor, New Color(30, 30, 30)))

                If Mouse.GetState.LeftButton = ButtonState.Pressed Then
                    Misc.DrawRectangle(sb, rect, Misc.SubtractColors(BackgroundColor, New Color(90, 90, 90)))
                End If
            Else
                Misc.DrawRectangle(sb, rect, BackgroundColor)
            End If
            ' Draw Background
            If BackgroundTexture IsNot Nothing Then
                If srcRect = Nothing Then
                    sb.Draw(BackgroundTexture, rect, Color.White)
                Else
                    sb.Draw(BackgroundTexture, rect, srcRect, Color.White)
                End If
            End If
            ' Draw Button label
            Select Case TextAlignment
                Case Alignments.Center
                    sb.DrawString(FontKoot, text, New Vector2(CSng(rect.X + rect.Width / 2 - FontKoot.MeasureString(text).X / 2), CSng(rect.Y + rect.Height / 2 - FontKoot.MeasureString(text).Y / 2)), Color.Black)
                Case Alignments.Left
                    sb.DrawString(FontKoot, text, New Vector2(rect.X + SidePadding, CSng(rect.Y + rect.Height / 2 - FontKoot.MeasureString(text).Y / 2)), Color.Black)
                Case Alignments.Right
                    sb.DrawString(FontKoot, text, New Vector2(rect.Right - FontKoot.MeasureString(text).X - SidePadding, CSng(rect.Y + rect.Height / 2 - FontKoot.MeasureString(text).Y / 2)), Color.Black)
            End Select
        End If

        MouseLastState = Mouse.GetState
    End Sub
End Class
