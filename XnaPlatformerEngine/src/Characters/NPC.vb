Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class NPC
    Inherits Character

    Public Dialogue As Dialogue = Nothing

    Sub New(_frmWidth As Integer, _cType As CharacterTypes)
        MyBase.New(_frmWidth, _cType)
    End Sub

    Public Overrides Sub Update(gameTime As GameTime)
        MyBase.Update(gameTime)

        Dialogue.Update(gameTime)
    End Sub

    Public Overrides Sub Draw(sb As SpriteBatch)
        MyBase.Draw(sb)

        Dialogue.Draw(sb)
    End Sub

    Public Overrides Sub Interaction()
        MyBase.Interaction()

        Dialogue.Active = True

    End Sub
End Class
