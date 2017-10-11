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

        If Dialogue IsNot Nothing Then
            Dialogue.Update(gameTime)
        End If
    End Sub

    Public Overrides Sub Draw(sb As SpriteBatch)
        MyBase.Draw(sb)
    End Sub

    Public Sub DrawDialogue(sb As SpriteBatch)
        If Dialogue IsNot Nothing Then
            Dialogue.Draw(sb)
        End If
    End Sub

    Public Overrides Sub Interaction()
        MyBase.Interaction()

        If Dialogue IsNot Nothing Then
            ScreenHandler.SelectedScreen.ToWorld.Player.IsInDialogue = True
            Dialogue.Active = True
        End If
    End Sub
End Class
