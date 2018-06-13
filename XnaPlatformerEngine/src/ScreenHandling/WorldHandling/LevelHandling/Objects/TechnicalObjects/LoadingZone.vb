Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class LoadingZone
    Inherits TechnicalObject

    Public TargetLevelName As String = ""

    Public Shared NotificationTexture As Texture2D

    Sub New()
        Name = "LoadingZone"
    End Sub

    Public Overrides Sub Update(gameTime As GameTime)
        MyBase.Update(gameTime)

    End Sub

    Public Overrides Sub Draw(sb As SpriteBatch)
        If IsPlayerInRange Then
            sb.Draw(NotificationTexture, New Rectangle(GetTrueRect.Location - New Point(0, 50), New Point(100, 70)), Color.White)
        End If
    End Sub

    Public Overrides Sub Interaction()

    End Sub
End Class
