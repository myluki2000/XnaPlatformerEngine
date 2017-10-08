Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Content
Imports Microsoft.Xna.Framework.Graphics

Public Class LoadingScreen
    Inherits Screen

#Region "Content"
    Dim Cassette As Texture2D
    Dim CassetteReel As Texture2D

    Dim Logo As Texture2D
#End Region

    Dim DisplayLogoCounter As Integer = 0
    Dim ReelRoation As Single = 0

    Public Overrides Sub Update(gameTime As GameTime)
        ReelRoation += CSng(4 * gameTime.ElapsedGameTime.TotalSeconds)

        DisplayLogoCounter += CInt(gameTime.ElapsedGameTime.TotalMilliseconds)
    End Sub

    Public Overrides Sub Draw(sb As SpriteBatch)
        sb.Begin()

        If DisplayLogoCounter < 3000 Then
            Dim transparency As Single
            If DisplayLogoCounter < 1500 Then
                transparency = CSng(DisplayLogoCounter / 600)
            Else
                transparency = CSng((2800 - DisplayLogoCounter) / 800)
            End If

            sb.Draw(texture:=Logo,
                                position:=New Vector2(CSng(graphics.PreferredBackBufferWidth / 2 - Logo.Width / 2), CSng(graphics.PreferredBackBufferHeight / 2 - Logo.Height / 2)),
                                color:=Color.White * transparency)
        Else

            Dim transparency As Single
            transparency = CSng((5500 - DisplayLogoCounter) / 2000)

            sb.Draw(texture:=CassetteReel,
                                position:=New Vector2(CSng(graphics.PreferredBackBufferWidth / 2 - 141), CSng(graphics.PreferredBackBufferHeight / 2 + 15)),
                                rotation:=ReelRoation,
                                origin:=New Vector2(88 / 2, 88 / 2))

            sb.Draw(texture:=CassetteReel,
                                position:=New Vector2(CSng(graphics.PreferredBackBufferWidth / 2 + 150), CSng(graphics.PreferredBackBufferHeight / 2 + 15)),
                                rotation:=ReelRoation + 1,
                                origin:=New Vector2(88 / 2, 88 / 2))

            sb.Draw(texture:=Cassette,
                                position:=New Vector2(CSng(graphics.PreferredBackBufferWidth / 2 - Cassette.Width / 2), CSng(graphics.PreferredBackBufferHeight / 2 - Cassette.Height / 2)))


            ' Using white rect overlay instead of making textures transparent because otherwise the reel parts that are normally behind the cassette are visible when blending in
            Misc.DrawRectangle(sb, New Rectangle(0, 0, graphics.PreferredBackBufferWidth, graphics.PreferredBackBufferHeight), Color.White * transparency)

        End If

        sb.End()
    End Sub

    Public Sub LoadContent(Content As ContentManager)
        Cassette = Content.Load(Of Texture2D)("LoadingScreen\cassette")
        CassetteReel = Content.Load(Of Texture2D)("LoadingScreen\cassette_reel")
        Logo = Content.Load(Of Texture2D)("LoadingScreen\logo")
    End Sub
End Class
