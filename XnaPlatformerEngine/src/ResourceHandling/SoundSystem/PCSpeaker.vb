Imports System.Runtime.InteropServices

Public Class PCSpeaker
    Public Shared Sub BeepDuration(freq As Integer, time As Integer)
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

    Public Shared Sub Beep(freq As Integer)
        Dim div As Short = CShort(1193180 / freq)

        Out32(&H43, &HB6)
        Out32(&H42, div)
        Out32(&H42, div >> 8)

        Dim tmp = Inp32(&H61)
        If tmp <> (tmp Or 3) Then
            Out32(&H61, CShort(tmp Or 3))
        End If
    End Sub

    Public Shared Sub StopBeep()
        Dim tmp = CShort(Inp32(&H61) And &HFC)

        Out32(&H61, tmp)
    End Sub

    <DllImport("InpOut32/InpOut32.dll", CharSet:=CharSet.Auto, EntryPoint:="Out32")>
    Private Shared Sub Out32(ByVal PortAddress As Short, ByVal Data As Short)
    End Sub

    <DllImport("InpOut32/InpOut32.dll", CharSet:=CharSet.Auto, EntryPoint:="Inp32")>
    Private Shared Function Inp32(ByVal PortAddress As Short) As Short
    End Function
End Class
