Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public MustInherit Class Screen
    Public Overridable Sub Inititialize()

    End Sub

    Public Overridable Sub PostContentLoad()

    End Sub

    Public Overridable Sub Update(gameTime As GameTime)

    End Sub

    Public Overridable Sub Draw(theSpriteBatch As SpriteBatch)
        theSpriteBatch.Begin()
        theSpriteBatch.DrawString(FontKoot, "Default Screen", New Vector2(100, 100), Color.Black)
        theSpriteBatch.End()
    End Sub
End Class
