Imports Microsoft.Xna.Framework.Content
Imports Microsoft.Xna.Framework.Graphics

Public Class Animation
    Public Name As String
    Public FrameDuration As Integer
    Public Texture As Texture2D
    Public TexturePath As String
    Public IterationCount As Integer = -1 ' -1 = Repeat, other numbers = times it is played

    Sub New(_name As String, _texPath As String, _frameDur As Integer)
        Name = _name
        TexturePath = _texPath
        FrameDuration = _frameDur
    End Sub

    Public Sub LoadContent(_content As ContentManager)
        Texture = TextureLoader.Load(TexturePath)
        TexturePath = Nothing
    End Sub
End Class
