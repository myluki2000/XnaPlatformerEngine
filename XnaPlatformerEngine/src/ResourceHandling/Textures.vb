Imports Microsoft.Xna.Framework.Content
Imports Microsoft.Xna.Framework.Graphics

Public Class Textures
    Public Shared Bullet As Texture2D
    Public Shared ParticleSpark As Texture2D
    Public Shared Sun As Texture2D
    Public Shared SkyGradient As Texture2D
    Public Shared Clouds(1) As Texture2D

    Public Shared Sub LoadTextures(Content As ContentManager)
        Bullet = Content.Load(Of Texture2D)("Textures/bullet")
        ParticleSpark = Content.Load(Of Texture2D)("Textures/spark")
        Sun = Content.Load(Of Texture2D)("World/Textures/Environment/sun")
        SkyGradient = Content.Load(Of Texture2D)("World/Textures/Environment/sky_gradient")
        Clouds(0) = Content.Load(Of Texture2D)("World/Textures/Environment/Clouds/cloud0")
        Clouds(1) = Content.Load(Of Texture2D)("World/Textures/Environment/Clouds/cloud1")

        LoadingZone.NotificationTexture = Content.Load(Of Texture2D)("UI/Textures/interact_notification")
    End Sub
End Class
