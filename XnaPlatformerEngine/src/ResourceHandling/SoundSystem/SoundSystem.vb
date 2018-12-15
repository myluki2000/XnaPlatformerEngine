Imports System.ComponentModel

Public Class SoundSystem

    Public Shared BeepModeActivated As Boolean = False

    Private Shared PCSpeaker As PCSpeaker
    Private Shared ReadOnly BgWorker As New BackgroundWorker

    Public Shared Sub Play(soundEffect As ExtendedSoundEffect)
        If Not BeepModeActivated Then
            soundEffect.SoundEffect.CreateInstance.Play()
            ' TODO: Make this more advanced!
        Else
            If PCSpeaker Is Nothing Then
                PCSpeaker = New PCSpeaker
            End If

            PCSpeaker.PlaySong(soundEffect.BeepSong)
        End If
    End Sub
End Class
