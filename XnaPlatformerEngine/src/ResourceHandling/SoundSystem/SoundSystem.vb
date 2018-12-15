Imports System.ComponentModel

Public Class SoundSystem

    Public Shared BeepModeActivated As Boolean = False

    Private Shared ReadOnly PCSpeaker As New PCSpeaker()
    Private Shared ReadOnly BgWorker As New BackgroundWorker

    Public Shared Sub Play(soundEffect As ExtendedSoundEffect)
        If Not BeepModeActivated Then
            soundEffect.SoundEffect.CreateInstance.Play()
            ' TODO: Make this more advanced!
        Else
            PCSpeaker.PlaySong(soundEffect.BeepSong)
        End If
    End Sub
End Class
