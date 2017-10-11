Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class WorldObject
    Inherits Sprite

    Public rect As Rectangle

    Public zIndex As Integer = 0

    Sub New(ByRef _name As String, ByRef _texture As Texture2D)
        MyBase.New(_name, _texture)
    End Sub

    Sub New()

    End Sub

    Public Overrides Sub Update(gameTime As GameTime)

    End Sub

    Public Overridable Sub Interaction()
    End Sub

    Public Overrides Sub Draw(sb As SpriteBatch)
        If Texture IsNot Nothing Then
            sb.Draw(Texture, New Rectangle(CInt(rect.X * 30), CInt(rect.Y * 30), CInt(rect.Width * Scale), CInt(rect.Height * Scale)), Color.White)
        End If
    End Sub

    Public Function ShallowCopy() As WorldObject
        Return DirectCast(Me.MemberwiseClone, WorldObject)
    End Function

    Public Overrides Function GetScreenRect() As Rectangle
        Return New Rectangle(CInt(rect.X * 30 - LevelCameraMatrix.Translation.X), CInt(rect.Y * 30 - LevelCameraMatrix.Translation.Y), rect.Width, rect.Height)
    End Function

    Public Overrides Function GetTrueRect() As Rectangle
        Return New Rectangle(rect.X * 30, rect.Y * 30, rect.Width, rect.Height)
    End Function
End Class
