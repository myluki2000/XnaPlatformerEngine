Imports Microsoft.Xna.Framework

Public Class Enemy
    Inherits Character

    Sub New(_frmWidth As Integer, _rect As Rectangle)
        MyBase.New(_frmWidth, _rect)
    End Sub

    Public Overrides Sub Update(gameTime As GameTime)
        MyBase.Update(gameTime)
    End Sub
End Class
