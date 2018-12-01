Public Class Pistol
    Inherits Weapon

    Sub New(_cType As Character.CharacterTypes)
        MyBase.New(_cType)

        Cooldown = 500
        ProjectileDamage = 5
    End Sub

    Private Sub Pistol_ShotFired() Handles MyBase.ShotFired
        SoundSystem.Play(Sounds.Weapons.Pistol.Shoot)
    End Sub

    Private Sub Pistol_ReloadStarted() Handles MyBase.ReloadStarted
        SoundSystem.Play(Sounds.Weapons.Pistol.Reload)
    End Sub
End Class
