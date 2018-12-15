Public Class AR
    Inherits Weapon

    Sub New(_cType As Character.CharacterTypes)
        MyBase.New(_cType)

        Cooldown = 85
        ProjectileDamage = 10
        ProjectileSpeed = 400


    End Sub

    Private Sub AR_ShotFired() Handles MyBase.ShotFired

    End Sub

    Private Sub AR_ReloadStarted() Handles MyBase.ReloadStarted

    End Sub
End Class
