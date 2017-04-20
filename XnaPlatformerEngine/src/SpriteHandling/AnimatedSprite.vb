Imports System.Collections.Generic
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Content
Imports Microsoft.Xna.Framework.Graphics

Public Class AnimatedSprite
    Inherits Sprite

    Public Animations As New List(Of Animation)
    Private srcRect As New Rectangle(0, 0, 0, 0)
    Private SelectedAnimation As Animation
    Private FrameWidth As Integer
    Private ElapsedTime As Integer = 0

    Public Overrides Sub LoadContent(_content As ContentManager)
        rect = New Rectangle(0, 0, 32, 32)
        FrameWidth = 32
        For Each _anim In Animations
            _anim.LoadContent(_content)
        Next
    End Sub

    Public Overrides Sub Draw(theSpriteBatch As SpriteBatch)
        If SelectedAnimation IsNot Nothing Then
            theSpriteBatch.Draw(SelectedAnimation.Texture, New Rectangle(CInt(rect.X * 30), CInt(rect.Y * 30), CInt(rect.Width * Scale), CInt(rect.Height * Scale)), srcRect, Color.White)
        End If
    End Sub

    Public Overrides Sub Update(gameTime As GameTime)
        srcRect.Width = FrameWidth
        srcRect.Height = SelectedAnimation.Texture.Height
        srcRect.Y = 0
        srcRect.X = CInt(Math.Floor(ElapsedTime / SelectedAnimation.FrameDuration)) * FrameWidth

        ElapsedTime += CInt(gameTime.ElapsedGameTime.TotalMilliseconds)

        If ElapsedTime >= SelectedAnimation.FrameDuration * SelectedAnimation.Texture.Width / FrameWidth AndAlso SelectedAnimation.IterationCount <> 0 Then
            ElapsedTime = 0

            If SelectedAnimation.IterationCount > 0 Then
                SelectedAnimation.IterationCount -= 1
            End If
        End If
    End Sub

    Public Sub SetSelectedAnimation(_animName As String)
        For Each _anim In Animations
            If _anim.Name = _animName Then
                SelectedAnimation = _anim
            End If
        Next
    End Sub
End Class

