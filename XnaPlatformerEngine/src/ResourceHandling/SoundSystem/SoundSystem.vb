Imports Microsoft.Xna.Framework.Audio

Public Class SoundSystem

    Public Shared BeepModeActivated As Boolean = False

    Private Shared WithEvents BeepTimer As New Windows.Forms.Timer

    Public Shared Sub Play(soundEffect As SoundEffect)
        If Not BeepModeActivated Then
            soundEffect.CreateInstance.Play()
            ' TODO: Make this more advanced!
        Else
            ' Placeholder
            PCSpeaker.Beep(1000)
            BeepTimer.Interval = 200
            BeepTimer.Start()
        End If
    End Sub

    Private Shared Sub BeepTimer_Tick() Handles BeepTimer.Tick
        PCSpeaker.StopBeep()
        BeepTimer.Stop()
    End Sub
End Class
