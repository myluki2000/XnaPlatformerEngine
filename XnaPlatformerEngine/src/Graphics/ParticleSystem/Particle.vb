﻿Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class Particle
    Inherits Sprite

    Public Velocity As Vector2
    Public LifetimeCounter As Integer
    Public Lifetime As Integer
    Public Alive As Boolean = True
    Public Opacity As Single = 1
    Public FadeTime As Integer
    Public GravityAffected As Boolean = True

    Sub New(_tex As Texture2D, _pos As Vector2, _vel As Vector2, _ltime As Integer, _fTime As Integer)
        Texture = _tex
        Position = _pos
        Velocity = _vel
        Lifetime = _ltime
        FadeTime = _fTime
    End Sub

    Public Overrides Sub Update(gameTime As GameTime)
        LifetimeCounter += CInt(gameTime.ElapsedGameTime.TotalMilliseconds)

        If GravityAffected Then
            Velocity.Y += CSng(15 * gameTime.ElapsedGameTime.TotalSeconds)
        End If

        Position += Velocity * CSng(gameTime.ElapsedGameTime.TotalSeconds)

        If LifetimeCounter > Lifetime Then
            Alive = False
        End If

        If LifetimeCounter > Lifetime - FadeTime AndAlso FadeTime <> 0 Then
            Opacity += -CSng(1 / FadeTime * gameTime.ElapsedGameTime.TotalMilliseconds)
        End If
    End Sub

    Public Overrides Sub Draw(sb As SpriteBatch)
        sb.Draw(Texture, New Rectangle(Position.ToPoint, New Point(CInt(Texture.Width * Scale), CInt(Texture.Height * Scale))), Color.White * Opacity)
    End Sub
End Class
