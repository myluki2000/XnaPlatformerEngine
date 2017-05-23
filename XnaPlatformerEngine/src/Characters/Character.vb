﻿Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Partial Public Class Character
    Inherits AnimatedSprite

    Friend Velocity As New Vector2(0, 0)
    Friend Position As New Vector2(60, 100)
    Friend Acceleration As New Vector2(0, -15)

    Sub New(_frmWidth As Integer, _rect As Rectangle)
        MyBase.New(_frmWidth, _rect)

    End Sub

    Public Overrides Sub Update(gameTime As GameTime)
        MyBase.Update(gameTime)

        Dim _newPos As Vector2 = Velocity * CSng(gameTime.ElapsedGameTime.TotalSeconds)
        Diagnostics.Debug.WriteLine(_newPos.ToString)

        CollidingCheck(_newPos, gameTime)
    End Sub

    Public Overrides Sub Draw(theSpriteBatch As SpriteBatch)
        If SelectedAnimation IsNot Nothing Then
            theSpriteBatch.Draw(SelectedAnimation.Texture, New Rectangle(CInt(Position.X), CInt(Position.Y), FrameWidth, SelectedAnimation.Texture.Height), srcRect, Color.White)
        End If
    End Sub

    Public Overrides Function getTrueRect() As Rectangle
        Return New Rectangle(Position.ToPoint, getTextureSize.ToPoint)
    End Function
End Class
