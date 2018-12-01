Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Content
Imports Microsoft.Xna.Framework.Graphics

Public Class LoadingScreen
    Inherits Screen

#Region "Content"
    Dim Cassette As Texture2D
    Dim CassetteReel As Texture2D
#End Region

    Dim TransparencyCounter As Integer = -300
    Dim ReelRoation As Single = 0

    Public Overrides Sub Update(gameTime As GameTime)
        ReelRoation += CSng(4 * gameTime.ElapsedGameTime.TotalSeconds)

        TransparencyCounter += CInt(gameTime.ElapsedGameTime.TotalMilliseconds)
    End Sub

    Public Overrides Sub Draw(sb As SpriteBatch)

        sb.Begin()

        Dim transparency As Single
        transparency = 1 - CSng(TransparencyCounter / 400)

        sb.Draw(texture:=CassetteReel,
                                position:=New Vector2(CSng(graphics.PreferredBackBufferWidth / 2 - 141), CSng(graphics.PreferredBackBufferHeight / 2 + 15)),
                                rotation:=ReelRoation,
                                origin:=New Vector2(88 / 2, 88 / 2))

        sb.Draw(texture:=CassetteReel,
                            position:=New Vector2(CSng(graphics.PreferredBackBufferWidth / 2 + 141), CSng(graphics.PreferredBackBufferHeight / 2 + 15)),
                            rotation:=ReelRoation + 1,
                            origin:=New Vector2(88 / 2, 88 / 2))

        sb.Draw(texture:=Cassette,
                            position:=New Vector2(CSng(graphics.PreferredBackBufferWidth / 2 - Cassette.Width / 2), CSng(graphics.PreferredBackBufferHeight / 2 - Cassette.Height / 2)))


        ' Using black rect overlay instead of making textures transparent because otherwise the reel parts that are normally behind the cassette are visible when blending in
        Misc.DrawRectangle(sb, New Rectangle(0, 0, graphics.PreferredBackBufferWidth, graphics.PreferredBackBufferHeight), Color.Black * transparency)


        sb.End()

    End Sub

    Public Sub LoadContent(Content As ContentManager)
        Cassette = TextureLoader.Load("LoadingScreen\cassette")
        CassetteReel = TextureLoader.Load("LoadingScreen\cassette_reel")
    End Sub
End Class
