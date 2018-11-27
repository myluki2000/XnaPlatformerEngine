Imports Microsoft.Xna.Framework.Graphics

Public Class TextureObject
    ''' <summary>
    ''' Unique name of the texture object
    ''' </summary>
    Public Name As String
    ''' <summary>
    ''' Texture of the object
    ''' </summary>
    Public Texture As Texture2D
    ''' <summary>
    ''' If set to true the texture will be randomly rotated for each object it is used on
    ''' </summary>
    Public HasRandomTextureRotation As Boolean = False
    ''' <summary>
    ''' If set to true objects with this texture won't have collision
    ''' </summary>
    Public IsFoliage As Boolean = False

    Sub New(ByRef _name As String, ByRef _texture As Texture2D, _randtexrot As Boolean, _foliage As Boolean)
        Name = _name
        Texture = _texture
        HasRandomTextureRotation = _randtexrot
        IsFoliage = _foliage
    End Sub
End Class
