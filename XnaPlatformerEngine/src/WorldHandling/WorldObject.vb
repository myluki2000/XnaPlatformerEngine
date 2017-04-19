Public Class WorldObject
    Inherits Sprite

    Public zIndex As Integer = 0

    Sub New(ByRef _name As String, ByRef _texturePath As String)
        MyBase.New(_name, _texturePath)
    End Sub

    Sub New()

    End Sub

    Public Function ShallowCopy() As WorldObject
        Return DirectCast(Me.MemberwiseClone, WorldObject)
    End Function
End Class
