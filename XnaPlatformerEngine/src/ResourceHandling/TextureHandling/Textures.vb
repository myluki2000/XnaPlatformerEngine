Imports Microsoft.Xna.Framework.Content
Imports Microsoft.Xna.Framework.Graphics

Public Class Textures
    Public Shared Bullet As Texture2D
    Public Shared ParticleSpark As Texture2D
    Public Shared Sun As Texture2D
    Public Shared SkyGradient As Texture2D
    Public Shared Clouds(1) As Texture2D

    Public Shared Sub LoadTextures(Content As ContentManager)
        Bullet = TextureLoader.Load("Content/Textures/bullet")
        ParticleSpark = TextureLoader.Load("Content/Textures/spark")
        Sun = TextureLoader.Load("Content/Textures/Environment/sun")
        SkyGradient = TextureLoader.Load("Content/Textures/Environment/sky_gradient")
        Clouds(0) = TextureLoader.Load("Content/Textures/Environment/Clouds/cloud0")
        Clouds(1) = TextureLoader.Load("Content/Textures/Environment/Clouds/cloud1")

        LoadingZone.NotificationTexture = TextureLoader.Load("Content/UI/Textures/interact_notification")
    End Sub
End Class
