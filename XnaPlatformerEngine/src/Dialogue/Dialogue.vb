Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Input

Public Class Dialogue
    Public Segments As DialogueSegment()

    Public Active As Boolean = False

    Private SegmentIndex As Integer = 0

    Public Shared SpeechBox As Texture2D

    Dim KeyboardLastState As KeyboardState
    Public Sub Update(gameTime As GameTime)
        If Active Then
            If KeyboardLastState.IsKeyDown(Keys.Space) AndAlso Keyboard.GetState.IsKeyUp(Keys.Space) Then
                If SegmentIndex < Segments.Length - 1 Then
                    SegmentIndex += 1

                    If Segments(SegmentIndex).DeactivateAfterSegment Then
                        Active = False
                    End If
                End If
            End If

            KeyboardLastState = Keyboard.GetState
        End If
    End Sub

    Public Sub Draw(sb As SpriteBatch)
        If Active Then
            sb.Draw(Segments(SegmentIndex).FaceSprite, New Rectangle(0, graphics.PreferredBackBufferHeight - 400, 330, 400), Color.White)

            sb.Draw(SpeechBox, New Rectangle(300, graphics.PreferredBackBufferHeight - 250, graphics.PreferredBackBufferWidth - 500, 230), Color.White)
            FontHand.DrawString(sb, New Vector2(450, graphics.PreferredBackBufferHeight - 220), Segments(0).Text, 0.3)
        End If
    End Sub
End Class
