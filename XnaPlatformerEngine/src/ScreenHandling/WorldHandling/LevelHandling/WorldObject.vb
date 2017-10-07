Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class WorldObject
    Inherits Sprite

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

    Public Function ShallowCopy() As WorldObject
        Return DirectCast(Me.MemberwiseClone, WorldObject)
    End Function

    Public Overrides Sub Draw(sb As SpriteBatch)
        MyBase.Draw(sb)
    End Sub
End Class
