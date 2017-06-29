Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Content
Imports Microsoft.Xna.Framework.Graphics

Public Class Bullet
    Inherits Sprite

    Public Position As Vector2
    Public Velocity As Vector2
    Public Existing As Boolean = True

    Sub New(_pos As Vector2, _vel As Vector2)
        Position = _pos
        Velocity = _vel
    End Sub

    Public Overrides Sub Update(gameTime As GameTime)
        Position += Velocity * CSng(gameTime.ElapsedGameTime.TotalSeconds)
        Existing = Not CheckCollision()
    End Sub

    Public Overrides Sub Draw(theSpriteBatch As SpriteBatch)
        theSpriteBatch.Draw(Textures.Bullet, Position, Color.White)
    End Sub

    Private Function CheckCollision() As Boolean
        Dim _centerPos As New Vector2(CSng(Position.X + Textures.Bullet.Width / 2), CSng(Position.Y + Textures.Bullet.Height / 2)) ' Get center pos of bullet

        Try
            If CType(ScreenHandler.GetSelectedScreen, World).GetSelectedLevel.PlacedObjects(CInt(Math.Floor(_centerPos.X / 30)), CInt(Math.Floor(_centerPos.Y / 30)), 50) IsNot Nothing Then
                ' Use center pos to check if block at position in level
                Return True
            Else
                Return False
            End If
        Catch ex As IndexOutOfRangeException
            Return True ' When bullet flies out of level return true so it gets deleted
        End Try
    End Function
End Class