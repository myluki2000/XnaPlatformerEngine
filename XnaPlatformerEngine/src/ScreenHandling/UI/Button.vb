Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Input

Public Class Button
    Inherits UIElement

    Public Event Click(sender As Object)
    Public Event MouseEnter(sender As Object)
    Public Event MouseLeave(sender As Object)
    Public Text As String = ""
    Public BackgroundColor As Color = Color.Gray
    Public ButtonStyle As ButtonStyles = ButtonStyles.Simple
    Public ToggleButton As Boolean = False
    Public Checked As Boolean = False
    Public Enabled As Boolean = True
    Public TextAlignment As Alignments
    Public SidePadding As Integer = 5


    Public TextureNormal As Texture2D
    Public TextureHover As Texture2D
    Public TextureClicked As Texture2D
    Public TextureChecked As Texture2D

    Public Enum Alignments
        Left
        Center
        Right
    End Enum

    Public Enum ButtonStyles
        Simple
        Parallelogram
        Textured
    End Enum

    Sub New()
        Visible = True
    End Sub

    Dim MouseLastState As MouseState
    Public Overrides Sub Draw(sb As SpriteBatch)
        If Visible Then
            Select Case ButtonStyle
                Case ButtonStyles.Simple
                    DrawSimpleButton(sb)
                Case ButtonStyles.Textured
                    DrawTexturedButton(sb)
                Case ButtonStyles.Parallelogram
                    DrawParallelogramButton(sb)
            End Select
        End If

        If Enabled Then
            DetectButtonInteraction()
        End If

        MouseLastState = Mouse.GetState
    End Sub

    Private Sub DetectButtonInteraction()
        If rect.Contains(Mouse.GetState.Position) Then
            If Mouse.GetState.LeftButton = ButtonState.Pressed AndAlso MouseLastState.LeftButton = ButtonState.Released Then
                RaiseEvent Click(Me)

                ' Switch checked when button is ToggleButton and clicked
                If ToggleButton Then
                    Checked = Not Checked
                End If
            End If

            If Not rect.Contains(MouseLastState.Position) Then
                RaiseEvent MouseEnter(Me)
            End If
        End If

        ' Detect mouse leave button area
        If rect.Contains(MouseLastState.Position) AndAlso Not rect.Contains(Mouse.GetState.Position) Then
            RaiseEvent MouseLeave(Me)
        End If
    End Sub

    Private Sub DrawSimpleButton(sb As SpriteBatch)
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
    End Sub

    Private Sub DrawTexturedButton(sb As SpriteBatch)
        ' Draw checked button
        If Checked Then
            sb.Draw(TextureChecked, rect, Color.White)
        End If

        If rect.Contains(Mouse.GetState.Position) Then
            If Mouse.GetState.LeftButton = ButtonState.Pressed Then
                ' Draw clicked button
                sb.Draw(TextureClicked, rect, Color.White)
            Else
                ' Draw hovered button
                sb.Draw(TextureHover, rect, Color.White)
            End If
        Else
            ' Draw normal button
            sb.Draw(TextureNormal, rect, Color.White)
        End If
    End Sub

    Private Sub DrawParallelogramButton(sb As SpriteBatch)
        ' Draw checked button
        If Checked Then

        End If

        If rect.Contains(Mouse.GetState.Position) Then
            If Mouse.GetState.LeftButton = ButtonState.Pressed Then
                ' Draw clicked button

            Else
                ' Draw hovered button

            End If
        Else
            ' Draw normal button

        End If
    End Sub
End Class


' ------------TEMPLATE FOR BUTTON DRAW METHODS------------

'' Draw checked button
'If Checked Then

'End If

'If rect.Contains(Mouse.GetState.Position) Then
'If Mouse.GetState.LeftButton = ButtonState.Pressed Then
'' Draw clicked button

'Else
'' Draw hovered button

'End If
'Else
'' Draw normal button

'End If