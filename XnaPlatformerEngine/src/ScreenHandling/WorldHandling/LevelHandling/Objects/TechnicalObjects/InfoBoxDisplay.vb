Public Class InfoBoxDisplay
    Inherits TechnicalObject

    Public Text As String = ""

    Sub New()
        Name = "InfoBoxDisplay"
    End Sub

    Public Overrides Sub Interaction()
        MyBase.Interaction()

        InfoBox.Show(Text)
    End Sub
End Class
