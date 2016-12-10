Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Content
Imports Microsoft.Xna.Framework.Graphics

Namespace TestWorld
    Public Class Textures
        Public Shared Dirt As Texture2D
        Public Shared Grass As Texture2D
        Public Shared Tree As Texture2D

        Public Shared Sub LoadContent(_content As ContentManager)
            Dirt = _content.Load(Of Texture2D)("devpurple")
        End Sub
    End Class
End Namespace
