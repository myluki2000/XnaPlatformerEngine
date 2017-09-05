Imports Microsoft.Xna.Framework.Audio
Imports Microsoft.Xna.Framework.Content

Public Class Sounds
    Public Class World

    End Class

    Public Class Characters
        Public Class Player

        End Class
    End Class

    Public Class Music

    End Class

    Public Class Weapons
        Public Class AR

        End Class

        Public Class Pistol
            Public Shared Reload As SoundEffect
            Public Shared Shoot As SoundEffect
        End Class
    End Class

    Public Shared Sub LoadSounds(Content As ContentManager)
        Weapons.Pistol.Reload = Content.Load(Of SoundEffect)("Sounds/Weapons/Pistol/Pistol_Reload")
        Weapons.Pistol.Shoot = Content.Load(Of SoundEffect)("Sounds/Weapons/Pistol/Pistol_Shoot")
    End Sub
End Class
