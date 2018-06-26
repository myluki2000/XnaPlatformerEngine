Imports Microsoft.Xna.Framework.Content
Imports Microsoft.Xna.Framework.Graphics

Public Class Textures
    Public Shared Bullet As Texture2D
    Public Shared ParticleSpark As Texture2D
    Public Shared Sun As Texture2D
    Public Shared SkyGradient As Texture2D

    Public Shared Sub LoadTextures(Content As ContentManager)
        Bullet = Content.Load(Of Texture2D)("Textures/bullet")
        ParticleSpark = Content.Load(Of Texture2D)("Textures/spark")
        Sun = Content.Load(Of Texture2D)("Textures/sun")
        SkyGradient = Content.Load(Of Texture2D)("Textures/sky_gradient")

        LoadingZone.NotificationTexture = Content.Load(Of Texture2D)("UI/Textures/interact_notification")
    End Sub
End Class
