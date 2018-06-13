Imports Microsoft.Xna.Framework.Graphics

Public Class TextureObject
    Public Name As String
    Public Texture As Texture2D
    Public HasRandomTextureRotation As Boolean = False
    Public IsFoliage As Boolean = False

    Sub New(ByRef _name As String, ByRef _texture As Texture2D, _randtexrot As Boolean, _foliage As Boolean)
        Name = _name
        Texture = _texture
        HasRandomTextureRotation = _randtexrot
        IsFoliage = _foliage
    End Sub
End Class
