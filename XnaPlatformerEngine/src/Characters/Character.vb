Imports System.Collections.Generic
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Input

Partial Public Class Character
    Inherits AnimatedSprite

    Friend Velocity As New Vector2(0, 0)
    Friend Position As New Vector2(300, 320)
    Friend Acceleration As New Vector2(0, 0)
    Public IsGrounded As Boolean = True
    Public Alive As Boolean = True
    Public Bullets As New List(Of Bullet)
    Public BulletCooldown As Integer = 200

    Sub New(_frmWidth As Integer, _rect As Rectangle)
        MyBase.New(_frmWidth, _rect)

    End Sub

    Dim BulletCooldownCounter As Integer = 0
    Public Sub ShootAt(_target As Vector2)
        If BulletCooldownCounter > BulletCooldown Then
            Bullets.Add(New Bullet(Position, Vector2.Normalize(_target - Position) * 200))
            BulletCooldownCounter = 0
        End If
    End Sub

    Public Sub Jump()
        If IsGrounded Then
            Velocity.Y = -120
        End If
    End Sub

    Public Overrides Sub Update(gameTime As GameTime)
        MyBase.Update(gameTime)

        Dim _newPos As Vector2 = Velocity * CSng(gameTime.ElapsedGameTime.TotalSeconds)

        CollidingCheck(_newPos, gameTime)


        For Each _bul In Bullets
            _bul.Update(gameTime)
        Next

        Bullets.RemoveAll(Function(x) x.Existing = False)

        BulletCooldownCounter += CInt(gameTime.ElapsedGameTime.TotalMilliseconds)
    End Sub

    Public Overrides Sub Draw(theSpriteBatch As SpriteBatch)
        If SelectedAnimation IsNot Nothing Then
            theSpriteBatch.Draw(SelectedAnimation.Texture, New Rectangle(CInt(Position.X), CInt(Position.Y), FrameWidth, SelectedAnimation.Texture.Height), srcRect, Color.White)
        End If

        For Each _bul In Bullets
            _bul.Draw(theSpriteBatch)
        Next
    End Sub

    Public Overrides Function getTrueRect() As Rectangle
        Return New Rectangle(Position.ToPoint, getTextureSize.ToPoint)
    End Function

    Public Overrides Function getScreenRect() As Rectangle
        Return New Rectangle(Position.ToPoint - New Point(CInt(LevelCameraMatrix.Translation.X), CInt(LevelCameraMatrix.Translation.Y)), getTextureSize.ToPoint)
    End Function
End Class
