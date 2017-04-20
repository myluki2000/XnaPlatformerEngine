Imports Microsoft.Xna.Framework

Public Class Player
    Inherits Character

    Sub New()
        MyBase.New(32, New Rectangle(0, 0, 32, 32))
        Animations.Add(New Animation("idle", "Characters/Player/idle", 500))
        SetSelectedAnimation("idle")
    End Sub
End Class
