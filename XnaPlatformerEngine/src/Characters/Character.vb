Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class Character
    Inherits AnimatedSprite

    Sub New()
        Animations.Add(New Animation("idle", "Characters/Player/idle", 400))
    End Sub

    Public Overrides Sub Update(gameTime As GameTime)
        MyBase.Update(gameTime)
    End Sub

    Private Function IsColliding(displacement As Vector2) As Boolean
        Dim _rect As New Rectangle(CInt(getTrueRect.X + displacement.X), CInt(getTrueRect.Y + displacement.Y), getTrueRect.Width, getTrueRect.Height)

        If ScreenHandler.GetSelectedScreen.GetType() = GetType(World) Then
            For Each _wObj In CType(ScreenHandler.GetSelectedScreen, World).GetSelectedLevel.PlacedObjects
                If _rect.Intersects(_wObj.getTrueRect) Then
                    Return True
                End If
            Next
        End If

        Return False
    End Function
End Class
