Imports Microsoft.Xna.Framework

Public Class Pistol
    Inherits Weapon

    Sub New(_cType As Character.CharacterTypes)
        MyBase.New(_cType)

        BulletCooldown = 500
        BulletDamage = 5
    End Sub

    Public Overrides Sub SpawnBullet(_position As Vector2, _velocity As Vector2, _damage As Integer)

    End Sub

    Private Sub Pistol_ShotFired() Handles MyBase.ShotFired
        Sounds.Weapons.Pistol.Shoot.CreateInstance.Play()
    End Sub

    Private Sub Pistol_ReloadStarted() Handles MyBase.ReloadStarted
        Sounds.Weapons.Pistol.Reload.CreateInstance.Play()
    End Sub
End Class
