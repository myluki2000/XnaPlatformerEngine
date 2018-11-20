Imports System.Collections.Generic
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class Weapon
    ''' <summary>
    ''' List of all projectiles originating from this weapon currently existing in this world
    ''' </summary>
    Public Projectiles As New List(Of Projectile)
    ''' <summary>
    ''' Cooldown between shooting two consecutive projectiles
    ''' </summary>
    Public Cooldown As Integer = 200
    ''' <summary>
    ''' The damage the projectile causes at impact
    ''' </summary>
    Public ProjectileDamage As Integer = 5
    ''' <summary>
    ''' Speed of the projectiles of the weapon in ???
    ''' </summary>
    Public ProjectileSpeed As Integer = 200
    ''' <summary>
    ''' Position of the weapon in the world
    ''' </summary>
    Public Position As Vector2
    ''' <summary>
    ''' Amount of projectiles that are currently in the magazine
    ''' </summary>
    Public ProjectilesInMag As Integer
    ''' <summary>
    ''' Amount of projectiles that fit into the magazine
    ''' </summary>
    Public ProjectilesMagMax As Integer = 20
    ''' <summary>
    ''' Reload time of the weapon in milliseconds
    ''' </summary>
    Public ReloadTime As Integer = 2000
    ''' <summary>
    ''' The type of the character this weapon belongs to
    ''' </summary>
    Public CharacterType As Character.CharacterTypes
    ''' <summary>
    ''' True when the weapon is currently reloading
    ''' </summary>
    Public CurrentlyReloading As Boolean = False
    ''' <summary>
    ''' Raised when weapon starts reloading
    ''' </summary>
    Public Event ReloadStarted()
    ''' <summary>
    ''' Raised when shot is fired from weapon
    ''' </summary>
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
    ''' <summary>
    ''' Lets the character shoot at a target
    ''' </summary>
    ''' <param name="_target">target to shoot at, coordinate in world space</param>
    Public Sub ShootAt(_target As Vector2)
        If BulletCooldownCounter > Cooldown Then
            If ProjectilesInMag > 0 Then
                RaiseEvent ShotFired()

                SpawProjectile(Position, Vector2.Normalize(_target - Position) * ProjectileSpeed, 10)
                ProjectilesInMag -= 1

                AddHandler Projectiles(Projectiles.Count - 1).ProjectileImpact, AddressOf OnProjectileImpact

                BulletCooldownCounter = 0
            Else
                CurrentlyReloading = True
            End If
        End If
    End Sub

    ''' <summary>
    ''' Lets the character shoot in the general direction left
    ''' </summary>
    Public Sub ShootLeft()
        ShootAt(Position + New Vector2(-1, 0))
    End Sub

    ''' <summary>
    ''' Lets the character shoot in the general direction right
    ''' </summary>
    Public Sub ShootRight()
        ShootAt(Position + New Vector2(1, 0))
    End Sub

    ''' <summary>
    ''' Manually spawn a projectile associated with the weapon
    ''' </summary>
    ''' <param name="_position">Initial position of the projectile</param>
    ''' <param name="_velocity">Initial velocity of the projectile</param>
    ''' <param name="_damage">Damage of the projectile</param>
    Friend Overridable Sub SpawProjectile(position As Vector2, velocity As Vector2, damage As Integer)
        Projectiles.Add(New Projectile(position, velocity, damage, CharacterType))
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
    ''' <summary>
    ''' Reloads the weapon's magazine
    ''' </summary>
    ''' <param name="gameTime">gameTime object to know if time it takes to reload has passed</param>
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
