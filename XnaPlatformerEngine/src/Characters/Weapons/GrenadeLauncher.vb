Imports Microsoft.Xna.Framework

Public Class GrenadeLauncher
    Inherits Weapon

    Sub New()


        Projectilespeed = 180
    End Sub

    Public Overrides Sub SpawnBullet(_position As Vector2, _velocity As Vector2, _damage As Integer)
        Projectiles.Add(New Projectile(_position, _velocity, _damage) With {.Acceleration = New Vector2(-10, 80)})
    End Sub

    Public Overrides Sub OnProjectileImpact(ByRef sender As Projectile)
        DirectCast(ScreenHandler.GetSelectedScreen, World).GetSelectedLevel.Explode(sender.Position, 50)
    End Sub
End Class
