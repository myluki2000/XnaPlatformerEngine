Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Input

Public Class InfoBox
    Public Shared Texture As Texture2D
    Public Shared ReadOnly Property Active As Boolean = False
    Shared Text As String

    Public Shared BoxRT As New RenderTarget2D(graphics.GraphicsDevice, 400, 600)

    Public Shared Sub Show(_text As String)
        Text = _text
        _Active = True
    End Sub

    Shared Opacity As Single = 0.0F
    Shared SpacePressedLast As Boolean = False

    Public Shared Sub DrawRT(sb As SpriteBatch, gameTime As GameTime)
        graphics.GraphicsDevice.SetRenderTarget(BoxRT)
        graphics.GraphicsDevice.Clear(Color.Transparent)

        sb.Begin()
        If Opacity > 0.0F OrElse Active Then

            sb.Draw(Texture, New Rectangle(0, 0, 400, 600), Color.White)
            FontHand.DrawString(sb, New Vector2(60, 60), Text, Color.White, 0.2)

            If Active Then
                If Opacity < 1.0F Then
                    Opacity += CSng(2.0F * gameTime.ElapsedGameTime.TotalSeconds)
                End If

                If SpacePressedLast AndAlso Keyboard.GetState.IsKeyUp(Keys.Space) Then
                    _Active = False
                End If

                SpacePressedLast = Keyboard.GetState.IsKeyDown(Keys.Space)
            Else
                Opacity += CSng(-2.0F * gameTime.ElapsedGameTime.TotalSeconds)
            End If
        End If
        sb.End()
        graphics.GraphicsDevice.SetRenderTarget(Nothing)
    End Sub

    Public Shared Sub Draw(sb As SpriteBatch)
        sb.Begin()
        sb.Draw(BoxRT, New Rectangle(CInt(graphics.PreferredBackBufferWidth / 2 - 200), CInt(graphics.PreferredBackBufferHeight / 2 - 300), 400, 600), Color.White * Opacity)
        sb.End()
    End Sub
End Class
