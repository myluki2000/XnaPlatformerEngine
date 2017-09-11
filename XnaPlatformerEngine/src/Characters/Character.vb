﻿Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Partial Public Class Character
    Inherits AnimatedSprite

    Friend Velocity As New Vector2(0, 0)
    Friend Position As New Vector2(300, 320)
    Friend Acceleration As New Vector2(0, 0)
    Public IsGrounded As Boolean = True
    Public Alive As Boolean = True

    Public CharacterType As CharacterTypes

    Public HealthPoints As Integer = 100

    Public Weapon As Weapon

    Public Enum CharacterTypes
        Player
        Enemy
    End Enum

    Sub New(_frmWidth As Integer, _rect As Rectangle, _cType As CharacterTypes)
        MyBase.New(_frmWidth, _rect)

        CharacterType = _cType
        Weapon = New AR(CharacterType)
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

        Weapon.Position = Position
        Weapon.Update(gameTime)

        If HealthPoints < 1 Then
            Alive = False
        End If

    End Sub

    Public Overrides Sub Draw(theSpriteBatch As SpriteBatch)
        If SelectedAnimation IsNot Nothing Then
            theSpriteBatch.Draw(SelectedAnimation.Texture, New Rectangle(CInt(Position.X), CInt(Position.Y), FrameWidth, SelectedAnimation.Texture.Height), srcRect, Color.White)
        End If

        Weapon.Draw(theSpriteBatch, Me)
    End Sub

    Public Overrides Function getTrueRect() As Rectangle
        Return New Rectangle(Position.ToPoint, getTextureSize.ToPoint)
    End Function

    Public Overrides Function getScreenRect() As Rectangle
        Return New Rectangle(Position.ToPoint - New Point(CInt(LevelCameraMatrix.Translation.X), CInt(LevelCameraMatrix.Translation.Y)), getTextureSize.ToPoint)
    End Function
End Class
