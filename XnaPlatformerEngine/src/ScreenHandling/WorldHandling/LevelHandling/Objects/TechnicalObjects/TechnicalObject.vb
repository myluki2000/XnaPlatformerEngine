Imports Microsoft.Xna.Framework.Graphics

Public Class TechnicalObject
    Inherits WorldObject
    Public Activated As Boolean = True

    Public Overrides Sub Draw(sb As SpriteBatch)
        MyBase.Draw(sb)
    End Sub
End Class
