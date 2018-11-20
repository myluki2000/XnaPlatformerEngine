Imports Microsoft.Xna.Framework

Public Class GrenadeLauncher
    Inherits Weapon

    Sub New(_cType As Character.CharacterTypes)
        MyBase.New(_cType)

        ProjectileSpeed = 180
    End Sub

    Friend Overrides Sub SpawProjectile(_position As Vector2, _velocity As Vector2, _damage As Integer)
        Projectiles.Add(New Projectile(_position, _velocity, _damage, CharacterType) With {.Acceleration = New Vector2(-10, 80)})
    End Sub

    Public Overrides Sub OnProjectileImpact(ByRef sender As Projectile)
        ScreenHandler.SelectedScreen.ToWorld.SelectedLevel.Explode(sender.Position, 50)
    End Sub
End Class
