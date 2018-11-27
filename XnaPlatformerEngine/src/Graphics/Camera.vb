Imports Microsoft.Xna.Framework

Public Class Camera
    Public Translation As New Vector3(0, 0, 0)
    Public Scale As New Vector3(1, 1, 1)

    Public Function GetMatrix() As Matrix
        Return Matrix.CreateTranslation(Translation) * Matrix.CreateScale(Scale)
    End Function


End Class
