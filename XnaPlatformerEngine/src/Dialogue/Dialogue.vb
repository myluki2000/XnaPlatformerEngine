Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class Dialogue
    Public Segments As DialogueSegment()

    Public Sub Draw(sb As SpriteBatch)
        sb.Draw(Segments(0).FaceSprite, New Rectangle(0, graphics.PreferredBackBufferHeight - 400, 330, 400), Color.White)

        FontHand.DrawString(sb, New Vector2(370, graphics.PreferredBackBufferHeight - 250), Segments(0).Text, 0.4)
    End Sub
End Class
