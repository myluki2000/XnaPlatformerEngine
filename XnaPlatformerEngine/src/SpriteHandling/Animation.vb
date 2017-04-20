Imports Microsoft.Xna.Framework.Content
Imports Microsoft.Xna.Framework.Graphics

Public Class Animation
    Public Name As String
    Public FrameDuration As Integer
    Public Texture As Texture2D
    Public TexturePath As String

    Sub New(_name As String, _texPath As String)
        Name = _name
        TexturePath = _texPath
    End Sub

    Public Sub LoadContent(_content As ContentManager)
        Texture = _content.Load(Of Texture2D)(TexturePath)
        TexturePath = Nothing
    End Sub
End Class
