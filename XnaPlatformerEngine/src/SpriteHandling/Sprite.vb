Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class Sprite
    Public Texture As Texture2D
    Public Position As New Vector2(0, 0)

    Public Sub Draw(theSpriteBatch As SpriteBatch)
        theSpriteBatch.Draw(Texture, Position)
    End Sub
End Class
