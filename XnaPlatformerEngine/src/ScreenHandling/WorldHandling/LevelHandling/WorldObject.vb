Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class WorldObject
    Inherits Sprite

    Public zIndex As Integer = 0

    Sub New(ByRef _name As String, ByRef _texturePath As String)
        MyBase.New(_name, _texturePath)
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

    Public Overrides Sub Draw(theSpriteBatch As SpriteBatch)
        MyBase.Draw(theSpriteBatch)
    End Sub
End Class
