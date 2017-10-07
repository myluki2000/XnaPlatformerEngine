Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Content
Imports Microsoft.Xna.Framework.Graphics

Public Class AnimatedSprite
    Inherits Sprite

    Public Animations As AnimationSet
    Protected srcRect As New Rectangle(0, 0, 0, 0)
    Protected SelectedAnimation As Animation
    Protected FrameWidth As Integer
    Private ElapsedTime As Integer = 0

    Sub New(_frmWidth As Integer)
        FrameWidth = _frmWidth
    End Sub

    Public Overrides Sub Draw(sb As SpriteBatch)
        If SelectedAnimation IsNot Nothing Then
            sb.Draw(texture:=SelectedAnimation.Texture,
                    position:=Position,
                    sourceRectangle:=srcRect,
                    scale:=New Vector2(Scale, Scale))
        End If
    End Sub

    Public Overrides Sub Update(gameTime As GameTime)
        srcRect.Width = FrameWidth
        srcRect.Height = SelectedAnimation.Texture.Height
        srcRect.Y = 0
        srcRect.X = CInt(Math.Floor(ElapsedTime / SelectedAnimation.FrameDuration)) * FrameWidth

        ElapsedTime += CInt(gameTime.ElapsedGameTime.TotalMilliseconds)


        If ElapsedTime >= SelectedAnimation.FrameDuration * SelectedAnimation.Texture.Width / FrameWidth Then
            If SelectedAnimation.IterationCount > 0 Then
                SelectedAnimation.IterationCount -= 1
            End If
            If SelectedAnimation.IterationCount <> 0 Then
                ElapsedTime = 0
            End If

        End If
    End Sub

    Public Sub SetSelectedAnimation(_animName As String)
        For Each _anim In Animations.Animations
            If _anim.Name = _animName Then
                SelectedAnimation = _anim
            End If
        Next
    End Sub

    Public Function getTextureSize() As Vector2
        Return New Vector2(FrameWidth, Animations.Animations(0).Texture.Height)
    End Function
End Class

