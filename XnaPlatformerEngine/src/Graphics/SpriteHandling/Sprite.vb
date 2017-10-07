﻿Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public MustInherit Class Sprite
    Public Name As String
    Public Texture As Texture2D
    Public Position As Vector2
    Public Scale As Integer = 1
    Public Hitbox As Polygon

    Sub New(ByRef _name As String, ByRef _texture As Texture2D)
        Texture = _texture
        Name = _name
    End Sub

    Sub New()
    End Sub

    Public MustOverride Sub Update(gameTime As GameTime)

    Public Overridable Sub Draw(sb As SpriteBatch)
        If Texture IsNot Nothing Then
            sb.Draw(texture:=Texture,
                    position:=Position,
                    scale:=New Vector2(Scale, Scale))
        Else
            'sb.DrawString(FontKoot, Name, getScreenRect.Location.ToVector2, Color.Red)
            'Misc.DrawOutline(sb, getScreenRect, Color.Gold, 2)
        End If
    End Sub

    Public Overridable Function GetScreenRect() As Rectangle
        If Texture IsNot Nothing Then
            Return New Rectangle(CInt(Position.X - LevelCameraMatrix.Translation.X), CInt(Position.Y - LevelCameraMatrix.Translation.Y), CInt(Texture.Width * Scale), CInt(Texture.Height * Scale))
        Else
            Return New Rectangle(CInt(Position.X - LevelCameraMatrix.Translation.X), CInt(Position.Y - LevelCameraMatrix.Translation.Y), 0, 0)
        End If
    End Function

    Public Overridable Function GetTrueRect() As Rectangle
        If Texture IsNot Nothing Then
            Return New Rectangle(CInt(Position.X), CInt(Position.Y), CInt(Texture.Width * Scale), CInt(Texture.Height * Scale))
        Else
            Return New Rectangle(CInt(Position.X), CInt(Position.Y), 0, 0)
        End If
    End Function
End Class
