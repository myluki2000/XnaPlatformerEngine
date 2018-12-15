Imports System.IO
Imports Microsoft.Xna.Framework.Audio
Imports Microsoft.Xna.Framework.Content
Imports Microsoft.Xna.Framework.Media

Public Class Sounds
    Public Class World

    End Class

    Public Class Characters
        Public Class Player

        End Class
    End Class

    Public Class Weapons
        Public Class AR

        End Class

        Public Class Pistol
            Public Shared Reload As New ExtendedSoundEffect
            Public Shared Shoot As New ExtendedSoundEffect
        End Class
    End Class

    Public Class Music
        Public Shared ReadOnly Property SweetYou As Song
            Get
                Return Song.FromUri("Sweet You", New Uri(Path.Combine(Windows.Forms.Application.StartupPath, "Content/Sounds/Music/Loyalty_Freak_Music-Sweet_You.mp3")))
            End Get
        End Property
    End Class

    Public Shared Sub LoadSounds(Content As ContentManager)
        Weapons.Pistol.Reload.SoundEffect = Content.Load(Of SoundEffect)("Sounds/Weapons/Pistol/Pistol_Reload")
        Weapons.Pistol.Shoot.SoundEffect = Content.Load(Of SoundEffect)("Sounds/Weapons/Pistol/Pistol_Shoot")
    End Sub
End Class
