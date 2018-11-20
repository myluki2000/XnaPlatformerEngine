Imports Microsoft.Xna.Framework

Public Class Pistol
    Inherits Weapon

    Sub New(_cType As Character.CharacterTypes)
        MyBase.New(_cType)

        Cooldown = 500
        ProjectileDamage = 5
    End Sub

    Private Sub Pistol_ShotFired() Handles MyBase.ShotFired
        Sounds.Weapons.Pistol.Shoot.CreateInstance.Play()
    End Sub

    Private Sub Pistol_ReloadStarted() Handles MyBase.ReloadStarted
        Sounds.Weapons.Pistol.Reload.CreateInstance.Play()
    End Sub
End Class
