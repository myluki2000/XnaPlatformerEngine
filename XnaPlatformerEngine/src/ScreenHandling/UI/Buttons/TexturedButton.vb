Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Input

Public Class TexturedButton
    Inherits Button
    Public TextureNormal As Texture2D
    Public TextureHover As Texture2D
    Public TextureClicked As Texture2D
    Public TextureChecked As Texture2D

    Public Overrides Sub Draw(sb As SpriteBatch)
        If Visible Then
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

            MyBase.Draw(sb)
        End If
    End Sub
End Class
