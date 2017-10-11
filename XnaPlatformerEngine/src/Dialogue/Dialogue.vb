Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Input

Public Class Dialogue
    Public Segments As DialogueSegment()

    Public _Active As Boolean = False

    Private SegmentIndex As Integer = 0

    Public Shared SpeechBox As Texture2D

    Dim KeyboardLastState As KeyboardState

    Dim DisplayingTextLength As Single = 0.0F

    Public Property Active As Boolean
        Get
            Return _Active
        End Get
        Set(value As Boolean)
            _Active = value
            srcRect.Y = 0
        End Set
    End Property

    Dim counter As Integer
    Public Sub Update(gameTime As GameTime)
        If Active Then
            If KeyboardLastState.IsKeyDown(Keys.Space) AndAlso Keyboard.GetState.IsKeyUp(Keys.Space) Then
                If SegmentIndex < Segments.Length - 1 Then
                    If Segments(SegmentIndex).DeactivateAfterSegment Then
                        Active = False
                        ScreenHandler.SelectedScreen.ToWorld.Player.IsInDialogue = False
                    End If

                    If Segments(SegmentIndex).ResetAfterSegment Then
                        SegmentIndex = 0
                        DisplayingTextLength = 0
                    Else
                        SegmentIndex += 1
                        DisplayingTextLength = 0
                    End If

                Else

                    ScreenHandler.SelectedScreen.ToWorld.Player.IsInDialogue = False
                    Active = False
                    SegmentIndex = 0
                    DisplayingTextLength = 0
                End If
            End If

            If srcRect.Y < 4000 AndAlso counter > 30 Then
                srcRect.Y += 800
            End If
        End If

        If DisplayingTextLength < Segments(SegmentIndex).Text.Length AndAlso srcRect.Y = 4000 Then
            DisplayingTextLength += CSng(30.0F * gameTime.ElapsedGameTime.TotalSeconds)
        End If

        If counter > 30 Then
            counter = 0
        End If
        counter += CInt(gameTime.ElapsedGameTime.TotalMilliseconds)
        KeyboardLastState = Keyboard.GetState
    End Sub

    Dim srcRect As New Rectangle(0, 0, 3000, 800)
    Public Sub Draw(sb As SpriteBatch)
        If Active Then
            sb.Draw(Segments(SegmentIndex).FaceSprite, New Rectangle(0, graphics.PreferredBackBufferHeight - 400, 330, 400), Color.White)

            sb.Draw(SpeechBox, New Rectangle(300, graphics.PreferredBackBufferHeight - 250, graphics.PreferredBackBufferWidth - 500, 230), srcRect, Color.White)



            If srcRect.Y = 4000 Then
                FontHand.DrawString(sb, New Vector2(450, graphics.PreferredBackBufferHeight - 220), Segments(SegmentIndex).Text.Substring(0, CInt(Math.Floor(DisplayingTextLength))), Color.White, 0.3)
            End If
        End If
    End Sub
End Class
