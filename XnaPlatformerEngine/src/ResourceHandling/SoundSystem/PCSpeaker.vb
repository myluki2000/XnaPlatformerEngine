Imports System.Collections.Generic
Imports System.Runtime.InteropServices

Public Class PCSpeaker

    Private CurrentNotes As New List(Of Note)
    Private CurrentlyPlayingNote As Note

    Private WithEvents BeepTimer As New Windows.Forms.Timer With {.Enabled = True, .Interval = 5}

    Public Sub PlaySong(song As NoteSong)
        CurrentNotes.AddRange(song.Notes)
    End Sub

    Private Sub BeepDuration(freq As Integer, time As Integer)
        Dim div As Short = CShort(1193180 / freq)

        Out32(&H43, &HB6)
        Out32(&H42, div)
        Out32(&H42, div >> 8)

        Dim tmp = Inp32(&H61)
        If tmp <> (tmp Or 3) Then
            Out32(&H61, CShort(tmp Or 3))
        End If

        tmp = CShort(Inp32(&H61) And &HFC)

        Out32(&H61, tmp)
    End Sub

    Private Sub Beep(freq As Integer)
        Dim div As Short = CShort(1193180 / freq)

        Out32(&H43, &HB6)
        Out32(&H42, div)
        Out32(&H42, div >> 8)

        Dim tmp = Inp32(&H61)
        If tmp <> (tmp Or 3) Then
            Out32(&H61, CShort(tmp Or 3))
        End If
    End Sub

    Private Sub StopBeep()
        Dim tmp = CShort(Inp32(&H61) And &HFC)

        Out32(&H61, tmp)
    End Sub

    Private Sub BeepTimer_Tick() Handles BeepTimer.Tick
        For Each note In CurrentNotes
            note.DurationPlayed += BeepTimer.Interval
            note.TimeUntilPlaying -= BeepTimer.Interval
        Next

        SelectNextNote()

        While (CurrentlyPlayingNote.TimeUntilPlaying > 0)
            SelectNextNote()
        End While

        ' Play the next note
        Beep(CurrentlyPlayingNote.Pitch)

        ' Remove notes which have played for their duration
        CurrentNotes.RemoveAll(Function(x) x.DurationPlayed >= x.Duration)

        ' Stop beeping if there are no notes to be played
        If CurrentNotes.Count = 0 Then
            StopBeep()
        End If
    End Sub

    Private Sub SelectNextNote()
        If CurrentNotes.Count > 0 Then
            CurrentlyPlayingNote = CurrentNotes((CurrentNotes.IndexOf(CurrentlyPlayingNote) + 1) Mod CurrentNotes.Count)
        End If
    End Sub

    <DllImport("InpOut32/InpOut32.dll", CharSet:=CharSet.Auto, EntryPoint:="Out32")>
    Private Shared Sub Out32(ByVal PortAddress As Short, ByVal Data As Short)
    End Sub

    <DllImport("InpOut32/InpOut32.dll", CharSet:=CharSet.Auto, EntryPoint:="Inp32")>
    Private Shared Function Inp32(ByVal PortAddress As Short) As Short
    End Function
End Class
