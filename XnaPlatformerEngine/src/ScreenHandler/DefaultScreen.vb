Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class DefaultScreen
    Inherits Screen

    Public Overrides Sub Draw(theSpriteBatch As SpriteBatch)
        theSpriteBatch.Begin()
        theSpriteBatch.Draw(DevPurple, New Vector2(0, 0))
        theSpriteBatch.End()
    End Sub
End Class
