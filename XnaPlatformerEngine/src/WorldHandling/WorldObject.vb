Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class WorldObject
    Inherits Sprite

    Public zIndex As Integer = 0
    Public ps As ParticleSystem

    Sub New(ByRef _name As String, ByRef _texturePath As String)
        MyBase.New(_name, _texturePath)
    End Sub

    Sub New()

    End Sub

    Public Overrides Sub Update(gameTime As GameTime)
        If ps IsNot Nothing Then
            ps.Update(gameTime)
        End If
    End Sub

    Public Function ShallowCopy() As WorldObject
        Return DirectCast(Me.MemberwiseClone, WorldObject)
    End Function

    Public Overrides Sub Draw(theSpriteBatch As SpriteBatch)
        MyBase.Draw(theSpriteBatch)

        If ps IsNot Nothing Then
            ps.Draw(theSpriteBatch)
        End If
    End Sub
End Class
