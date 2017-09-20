Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Content
Imports Microsoft.Xna.Framework.Graphics

Public MustInherit Class Sprite
    Public Name As String
    Public Texture As Texture2D
    Public rect As Rectangle
    Public Scale As Integer = 1
    Public Hitbox As Polygon

    Sub New(ByRef _name As String, ByRef _texture As Texture2D)
        Texture = _texture
        Name = _name
    End Sub

    Sub New()
    End Sub

    Public MustOverride Sub Update(gameTime As GameTime)

    Public Overridable Sub Draw(theSpriteBatch As SpriteBatch)
        If Texture IsNot Nothing Then
            theSpriteBatch.Draw(Texture, New Rectangle(CInt(rect.X * 30), CInt(rect.Y * 30), CInt(rect.Width * Scale), CInt(rect.Height * Scale)), Color.White)
        Else
            'theSpriteBatch.DrawString(FontKoot, Name, getScreenRect.Location.ToVector2, Color.Red)
            'Misc.DrawOutline(theSpriteBatch, getScreenRect, Color.Gold, 2)
        End If
    End Sub

    Public Overridable Function getScreenRect() As Rectangle
        Return New Rectangle(CInt(rect.X * 30 - LevelCameraMatrix.Translation.X), CInt(rect.Y * 30 - LevelCameraMatrix.Translation.Y), CInt(rect.Width * Scale), CInt(rect.Height * Scale))
    End Function

    Public Overridable Function getTrueRect() As Rectangle
        Return New Rectangle(rect.X * 30, rect.Y * 30, CInt(rect.Width * Scale), CInt(rect.Height * Scale))
    End Function
End Class
