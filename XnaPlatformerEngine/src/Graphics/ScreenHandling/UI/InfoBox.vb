Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Input

Public Class InfoBox
    Public Shared Texture As Texture2D
    Public Shared ReadOnly Property Active As Boolean = False
    Shared Text As String

    Public Shared Sub Show(_text As String)
        Text = _text
        _Active = True
    End Sub

    Shared SpacePressedLast As Boolean = False
    Public Shared Sub Draw(sb As SpriteBatch)
        If Active Then
            sb.Draw(Texture, New Rectangle(CInt(graphics.PreferredBackBufferWidth / 2 - 200), CInt(graphics.PreferredBackBufferHeight / 2 - 300), 400, 600), Color.White)
            FontHand.DrawString(sb, New Vector2(CSng(graphics.PreferredBackBufferWidth / 2 - 150), CSng(graphics.PreferredBackBufferHeight / 2 - 250)), Text, 0.2)

            If SpacePressedLast AndAlso Keyboard.GetState.IsKeyUp(Keys.Space) Then
                _Active = False
            End If

            SpacePressedLast = Keyboard.GetState.IsKeyDown(Keys.Space)
        End If
    End Sub
End Class
