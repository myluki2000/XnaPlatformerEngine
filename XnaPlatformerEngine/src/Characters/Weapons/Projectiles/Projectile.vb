Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class Projectile
    Inherits Sprite

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


                ' Make it so particles don't spawn with the velocity in the direction of the wall
                If Velocity.X > 0 Then
                    ps = New ParticleSystem(Position) With {.ParticleFadeTime = 200, .ParticleLifetime = 2000, .PossibleTextures = {Textures.ParticleSpark},
                .ParticleVelocityLowest = New Point(-20, -20), .ParticleVelocityHighest = New Point(0, 20)}
                Else
                    ps = New ParticleSystem(Position) With {.ParticleFadeTime = 200, .ParticleLifetime = 2000, .PossibleTextures = {Textures.ParticleSpark},
                .ParticleVelocityLowest = New Point(0, -20), .ParticleVelocityHighest = New Point(20, 20)}
                End If


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
        Dim selectedLevel = ScreenHandler.SelectedScreen.ToWorld.SelectedLevel

        ' Check if projectile is out of level bounds horizonally or vertically
        If (CInt(Math.Floor(Position.X / 30)) > 0 AndAlso CInt(Math.Floor(Position.X / 30)) < selectedLevel.PlacedObjects.GetUpperBound(0)) AndAlso
            (CInt(Math.Floor(Position.Y / 30)) > 0 AndAlso CInt(Math.Floor(Position.Y / 30)) < selectedLevel.PlacedObjects.GetUpperBound(1)) Then

            Dim _wObj As WorldObject = selectedLevel.PlacedObjects(CInt(Math.Floor(Position.X / 30)), CInt(Math.Floor(Position.Y / 30)), 50)
            If _wObj IsNot Nothing AndAlso _wObj.GetType Is GetType(WorldObject) Then
                ' check if block at position in level
                Return True
            End If

        Else
            Return True
        End If


        Dim rect As New Rectangle(CInt(Position.X), CInt(Position.Y), Textures.Bullet.Width, Textures.Bullet.Height)
        Select Case Origin
            Case Character.CharacterTypes.Player
                    For Each character As Character In selectedLevel.NPCs
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
