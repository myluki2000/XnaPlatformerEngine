Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

''' <summary>
''' A class which provides basic sprite drawing functionality
''' </summary>
Public Class Sprite
    ''' <summary>
    ''' The texture of the sprite. It gets drawn when .draw is called
    ''' </summary>
    Public Texture As Texture2D
    ''' <summary>
    ''' The position of the sprite
    ''' </summary>
    Public Position As Vector2
    ''' <summary>
    ''' The scale of the sprite. Default = 1.0
    ''' </summary>
    Public Scale As Single = 1.0F
    ''' <summary>
    ''' A polygon which represents the hitbox of the sprite. Currently unused
    ''' </summary>
    Public Hitbox As Polygon

    Sub New()
    End Sub

    Public Overridable Sub Update(gameTime As GameTime)

    End Sub

    Public Overridable Sub Draw(sb As SpriteBatch)
        If Texture IsNot Nothing Then
            sb.Draw(texture:=Texture,
                    position:=Position,
                    scale:=New Vector2(Scale, Scale))
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
