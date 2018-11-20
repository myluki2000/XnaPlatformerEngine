Public Class AR
    Inherits Weapon

    Sub New(_cType As Character.CharacterTypes)
        MyBase.New(_cType)

        Cooldown = 85
        ProjectileDamage = 10
        ProjectileSpeed = 400


    End Sub

    Private Sub AR_ShotFired() Handles MyBase.ShotFired
        Sounds.Weapons.Pistol.Shoot.CreateInstance.Play()
    End Sub

    Private Sub AR_ReloadStarted() Handles MyBase.ReloadStarted
        Sounds.Weapons.Pistol.Reload.CreateInstance.Play()
    End Sub
End Class
