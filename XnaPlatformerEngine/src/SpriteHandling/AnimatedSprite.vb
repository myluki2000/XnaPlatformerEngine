Imports System.Collections.Generic
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class AnimatedSprite
    Inherits Sprite

    Private Animations As New List(Of Animation)
    Private srcRect As New Rectangle(0, 0, 0, 0)
    Private SelectedAnimation As Animation
    Private FrameWidth As Integer
    Private ElapsedTime As Integer

    Public Overrides Sub Draw(theSpriteBatch As SpriteBatch)
        If Texture IsNot Nothing Then
            theSpriteBatch.Draw(Texture, New Rectangle(CInt(rect.X * 30), CInt(rect.Y * 30), CInt(rect.Width * Scale), CInt(rect.Height * Scale)), srcRect, Color.White)
        Else
            theSpriteBatch.DrawString(FontKoot, Name, getScreenRect.Location.ToVector2, Color.Red)
            Misc.DrawOutline(theSpriteBatch, getScreenRect, Color.Gold, 2)
        End If
    End Sub

    Public Overrides Sub Update(gameTime As GameTime)
        srcRect.Width = FrameWidth
        srcRect.Height = SelectedAnimation.Texture.Height
        srcRect.Y = 0
        srcRect.X = CInt(Math.Floor(ElapsedTime / SelectedAnimation.FrameDuration)) * FrameWidth

        ElapsedTime += CInt(gameTime.ElapsedGameTime.TotalMilliseconds)
    End Sub

    Public Sub SetSelectedAnimation(_animName As String)
        For Each _anim In Animations
            If _anim.Name = _animName Then
                SelectedAnimation = _anim
            End If
        Next
    End Sub
End Class

