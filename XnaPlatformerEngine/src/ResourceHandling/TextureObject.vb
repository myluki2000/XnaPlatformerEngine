Imports Microsoft.Xna.Framework.Graphics

Public Class TextureObject
    Public Name As String
    Public Texture As Texture2D

    Sub New(ByRef _name As String, ByRef _texture As Texture2D)
        Name = _name
        Texture = _texture
    End Sub
End Class
