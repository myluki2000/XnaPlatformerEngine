Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class TestScreen
    Inherits Screen

    Public Overrides Sub Inititialize()
        MsgBox("Testscreen initialized")
    End Sub

    Public Overrides Sub Update(gameTime As GameTime)
        Diagnostics.Debug.WriteLine("Update happened after " & gameTime.ElapsedGameTime.Milliseconds & " milliseconds")
    End Sub

    Public Overrides Sub Draw(theSpriteBatch As SpriteBatch)
        theSpriteBatch.Begin()

        theSpriteBatch.End()
    End Sub
End Class
