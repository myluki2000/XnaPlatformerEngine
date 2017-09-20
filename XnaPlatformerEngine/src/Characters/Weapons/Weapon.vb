Imports System.Collections.Generic
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class Weapon

    Public Projectiles As New List(Of Projectile)
    Public BulletCooldown As Integer = 200
    Public BulletDamage As Integer = 5
    Public Projectilespeed As Integer = 200
    Public Position As Vector2
    Public ProjectilesInMag As Integer
    Public ProjectilesMagMax As Integer = 20
    Public ReloadTime As Integer = 2000

    Public CharacterType As Character.CharacterTypes

    Public CurrentlyReloading As Boolean = False

    Public Event ReloadStarted()
    Public Event ShotFired()

    Sub New(_cType As Character.CharacterTypes)
        ProjectilesInMag = ProjectilesMagMax

        CharacterType = _cType
    End Sub

    Public Overridable Sub Update(gameTime As GameTime)
        For Each _bul In Projectiles
            _bul.Update(gameTime)
        Next

        If CurrentlyReloading Then
            ReloadWeapon(gameTime)
        End If

        Projectiles.RemoveAll(Function(x) x.Existing = False)

        BulletCooldownCounter += CInt(gameTime.ElapsedGameTime.TotalMilliseconds)
    End Sub

    Dim BulletCooldownCounter As Integer = 0
    Public Sub ShootAt(_target As Vector2)
        If BulletCooldownCounter > BulletCooldown Then
            If ProjectilesInMag > 0 Then
                RaiseEvent ShotFired()

                SpawnBullet(Position, Vector2.Normalize(_target - Position) * Projectilespeed, 10)
                ProjectilesInMag -= 1

                AddHandler Projectiles(Projectiles.Count - 1).ProjectileImpact, AddressOf OnProjectileImpact

                BulletCooldownCounter = 0
            Else
                CurrentlyReloading = True
            End If
        End If
    End Sub

    Public Sub ShootLeft()
        ShootAt(Position + New Vector2(-1, 0))
    End Sub

    Public Sub ShootRight()
        ShootAt(Position + New Vector2(1, 0))
    End Sub

    Public Overridable Sub SpawnBullet(_position As Vector2, _velocity As Vector2, _damage As Integer)
        Projectiles.Add(New Projectile(_position, _velocity, _damage, CharacterType))
    End Sub

    Public Overridable Sub Draw(_sb As SpriteBatch, Optional _parent As Character = Nothing)
        If _parent IsNot Nothing AndAlso TypeOf (_parent) Is Player Then
            If CurrentlyReloading Then
                ' Draw horizontal line
                Misc.DrawRectangle(_sb, New Rectangle(_parent.Position.ToPoint + New Point(0, -20), New Point(CInt(_parent.getTextureSize.X), 2)), Color.Black)

                ' Draw moving vertical line
                Misc.DrawRectangle(_sb, New Rectangle(_parent.Position.ToPoint + New Point(CInt(_parent.getTextureSize.X * ReloadCounter / ReloadTime - 2), -24), New Point(4, 10)), Color.Black)
            End If
        End If

        For Each _bul In Projectiles
            _bul.Draw(_sb)
        Next
    End Sub

    Public Overridable Sub OnProjectileImpact(ByRef sender As Projectile)
    End Sub

    Dim ReloadCounter As Integer = 0
    Public Sub ReloadWeapon(gameTime As GameTime)
        If ReloadCounter = 0 Then
            RaiseEvent ReloadStarted()
        End If
        If ReloadCounter >= ReloadTime Then
                ReloadCounter = 0
                ProjectilesInMag = ProjectilesMagMax
                CurrentlyReloading = False
            Else
                ReloadCounter += CInt(gameTime.ElapsedGameTime.TotalMilliseconds)
            CurrentlyReloading = True
        End If
    End Sub
End Class
