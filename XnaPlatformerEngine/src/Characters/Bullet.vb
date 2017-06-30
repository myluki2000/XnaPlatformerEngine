Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Content
Imports Microsoft.Xna.Framework.Graphics

Public Class Bullet
    Inherits Sprite

    Public Position As Vector2
    Public Velocity As Vector2
    Public Existing As Boolean = True
    Public Landed As Boolean = False
    Public ps As ParticleSystem
    Dim Rotation As Single

    Sub New(_pos As Vector2, _vel As Vector2)
        Position = _pos
        Velocity = _vel
        Rotation = CSng(Math.Atan2(Velocity.Y, Velocity.X))
    End Sub

    Dim counter As Integer = 0
    Public Overrides Sub Update(gameTime As GameTime)
        If Not Landed Then
            Position += Velocity * CSng(gameTime.ElapsedGameTime.TotalSeconds)
            If CheckCollision() Then
                Landed = True
                ps = New ParticleSystem(Position) With {.ParticleFadeTime = 200, .ParticleLifetime = 700, .PossibleTextures = {Textures.ParticleSpark},
                    .ParticleVelocityLowest = New Point(-20, -20), .ParticleVelocityHighest = New Point(20, 20)}
                ps.SpawnParticles(5)
            End If
        Else
            ps.Update(gameTime)
            counter += CInt(gameTime.ElapsedGameTime.TotalMilliseconds)
            If counter = 700 Then
                Existing = False
            End If
        End If
    End Sub

    Public Overrides Sub Draw(theSpriteBatch As SpriteBatch)
        If Not Landed Then
            theSpriteBatch.Draw(Textures.Bullet, Position, Nothing, Color.White, Rotation, New Vector2(Textures.Bullet.Width / 2, Textures.Bullet.Height / 2), 1, Nothing, Nothing)
        End If

        If ps IsNot Nothing Then
            ps.Draw(theSpriteBatch)
        End If
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