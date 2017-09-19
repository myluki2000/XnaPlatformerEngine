Imports Microsoft.Xna.Framework.Content
Imports Microsoft.Xna.Framework.Graphics

Public Class Textures
    Public Shared Bullet As Texture2D
    Public Shared ParticleSpark As Texture2D

    Public Shared Sub LoadTextures(Content As ContentManager)
        Bullet = Content.Load(Of Texture2D)("Textures/Bullet")
        ParticleSpark = Content.Load(Of Texture2D)("Textures/Spark")
    End Sub
End Class
