Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class Projectile
    Inherits Sprite

    Public Position As Vector2
    Public Velocity As Vector2
    Public Acceleration As New Vector2(0, 0)
    Public Damage As Integer
    Public Existing As Boolean = True
    Public Landed As Boolean = False
    Public WithEvents ps As ParticleSystem

    Public Origin As Character.CharacterTypes

    Dim Rotation As Single

    Public Event ProjectileImpact(ByRef sender As Projectile)




    Sub New(_pos As Vector2, _vel As Vector2, _dmg As Integer, _origin As Character.CharacterTypes)
        Position = _pos
        Velocity = _vel
        Damage = _dmg
        Rotation = CSng(Math.Atan2(Velocity.Y, Velocity.X))
        Origin = _origin
    End Sub

    Dim counter As Integer = 0
    Public Overrides Sub Update(gameTime As GameTime)
        If Not Landed Then
            Velocity.Y += Acceleration.Y * CSng(gameTime.ElapsedGameTime.TotalSeconds)
            Velocity.X = (Math.Abs(Velocity.X) + Acceleration.X * CSng(gameTime.ElapsedGameTime.TotalSeconds)) * Math.Sign(Velocity.X)

            Position += Velocity * CSng(gameTime.ElapsedGameTime.TotalSeconds)
            If CheckCollision() Then
                Landed = True

                RaiseEvent ProjectileImpact(Me)

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

    Public Overrides Sub Draw(sb As SpriteBatch)
        If Not Landed Then
            sb.Draw(Textures.Bullet, Position, Nothing, Color.White, Rotation, New Vector2(CSng(Textures.Bullet.Width / 2), CSng(Textures.Bullet.Height / 2)), 1, Nothing, Nothing)
        End If

        If ps IsNot Nothing Then
            ps.Draw(sb)
        End If
    End Sub

    Private Function CheckCollision() As Boolean
        Try
            Dim _wObj As WorldObject = ScreenHandler.SelectedScreen.ToWorld.SelectedLevel.PlacedObjects(CInt(Math.Floor(Position.X / 30)), CInt(Math.Floor(Position.Y / 30)), 50)
            If _wObj IsNot Nothing AndAlso _wObj.GetType Is GetType(WorldObject) Then
                ' check if block at position in level
                Return True
            End If



        Catch ex As IndexOutOfRangeException
            Return True ' When bullet flies out of level return true so it gets deleted
        End Try


        Dim rect As New Rectangle(CInt(Position.X), CInt(Position.Y), Textures.Bullet.Width, Textures.Bullet.Height)
        Select Case Origin
            Case Character.CharacterTypes.Player
                For Each character As Character In ScreenHandler.SelectedScreen.ToWorld.SelectedLevel.NPCs
                    If rect.Intersects(character.getTrueRect) Then
                        character.HealthPoints -= Me.Damage
                        Return True
                    End If
                Next

            Case Character.CharacterTypes.Enemy
                Dim Player As Player = ScreenHandler.SelectedScreen.ToWorld.Player

                If rect.Intersects(Player.getTrueRect) Then
                    Player.HealthPoints -= Me.Damage
                    Return True
                End If
        End Select

        Return False
    End Function

    Private Sub DeleteProjectile() Handles ps.ParticlesDespawned
        If Landed Then
            Existing = False
        End If
    End Sub
End Class
