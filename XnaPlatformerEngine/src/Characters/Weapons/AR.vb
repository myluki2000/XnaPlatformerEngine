Public Class AR
    Inherits Weapon

    Sub New(_cType As Character.CharacterTypes)
        MyBase.New(_cType)

        BulletCooldown = 85
        BulletDamage = 10
        Projectilespeed = 400


    End Sub

    Private Sub AR_ShotFired() Handles MyBase.ShotFired
        Sounds.Weapons.Pistol.Shoot.CreateInstance.Play()
    End Sub

    Private Sub AR_ReloadStarted() Handles MyBase.ReloadStarted
        Sounds.Weapons.Pistol.Reload.CreateInstance.Play()
    End Sub
End Class
