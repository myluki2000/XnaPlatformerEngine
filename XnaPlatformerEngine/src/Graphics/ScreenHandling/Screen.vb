Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public MustInherit Class Screen
    Public Overridable Sub Inititialize()
    End Sub

    Public Overridable Sub Update(gameTime As GameTime)
    End Sub

    Public Overridable Sub Draw(sb As SpriteBatch)
        sb.Begin()
        sb.DrawString(FontKoot, "Default Screen", New Vector2(100, 100), Color.Black)
        sb.End()
    End Sub

    Public Function ToWorld() As World
        Return DirectCast(Me, World)
    End Function
End Class
