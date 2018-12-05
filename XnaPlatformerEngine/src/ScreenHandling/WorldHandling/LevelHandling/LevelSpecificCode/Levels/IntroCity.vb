Imports System.Collections.Generic
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Content
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Input

Namespace LevelSpecificCode
    Namespace Levels
        Public Class IntroCity
            Inherits LevelSpecificCodeTemplate

            Private TrainX As Integer = 3
            Private TrainVelocityX As Single = 4.0F

            Private Class Textures
                Public Shared Logo As Texture2D
                Public Shared TrainLights As Texture2D
            End Class


            Sub New(level As Level, props As List(Of WorldObject))
                MyBase.New(level, props)
            End Sub

            Public Overrides Sub Initialize()
                Level.Camera.Scale = New Vector3(1.4, 1.4, 1)
            End Sub

            Public Overrides Sub LoadContent(content As ContentManager)
                Textures.Logo = TextureLoader.Load("Content/Textures/Other/logo")
                Textures.TrainLights = TextureLoader.Load("World/Textures/Blocks/City/train_lights")
            End Sub

            Dim Transparency As Single = -0.5
            Dim TrainCountdown As Integer = 8000
            Dim PassingTrainActivated As Boolean = False

            Dim lastscroll As Integer = 0
            Dim musicPlaying As Boolean = False
            Dim textCounter As Integer = 0
            Public Overrides Sub Draw(sb As SpriteBatch)
                sb.Begin(, BlendState.NonPremultiplied,,,,, ScreenHandler.SelectedScreen.ToWorld.SelectedLevel.Camera.GetMatrix())

                Misc.DrawRectangle(sb, New Rectangle(0, -1000, 1600, 3000), Color.Black)

                sb.End()

                sb.Begin(, BlendState.NonPremultiplied,,,,,)

                If Transparency < 1 Then
                    Transparency += 0.02F
                Else
                    PassingTrainActivated = True
                End If

                If PassingTrainActivated Then
                    If TrainCountdown > -2500 Then
                        TrainCountdown -= 80
                    End If
                End If

                If TrainCountdown < 1000 Then
                    If Transparency > 0 Then
                        Transparency -= 0.2F
                    Else
                        If Not musicPlaying Then
                            musicPlaying = True
                            Media.MediaPlayer.Volume = 0.7
                            Media.MediaPlayer.Play(Sounds.Music.SweetYou)
                        End If
                    End If
                End If


                If textCounter > 13000 AndAlso textCounter < 18000 Then
                    DrawTextFlicker(sb, "NAMEHERE")
                End If


                sb.Draw(Textures.TrainLights, New Vector2(CSng(graphics.PreferredBackBufferWidth / 2) + TrainCountdown, CSng(graphics.PreferredBackBufferHeight / 2)),
                        Nothing, Color.White, Nothing, New Vector2(CSng(Textures.TrainLights.Width / 2), CSng(Textures.TrainLights.Height / 2)), 3, Nothing, Nothing)

                sb.End()
            End Sub

            Dim Counter As Integer = -5000
            Public Overrides Sub Update(gameTime As GameTime)
                Dim selectedLevel = ScreenHandler.SelectedScreen.ToWorld.SelectedLevel

                If Player Is Nothing Then
                    Player = ScreenHandler.SelectedScreen.ToWorld.Player
                End If

                Counter += gameTime.ElapsedGameTime.Milliseconds

                textCounter += gameTime.ElapsedGameTime.Milliseconds

                Dim Train = Props.Find(Function(x) x.Name = "Train1")

                If Train.Position = New Vector2(0, 0) Then
                    Train.Position.X = Train.rect.X * 30
                    Train.Position.Y = Train.rect.Y * 30

                    Player.Visible = False
                    Player.HasGravity = False
                End If



                If Counter > 10 Then
                    Counter = 0
                    If Train.Position.X < 2800 Then
                        Train.Position.X += TrainVelocityX
                        Player.Position = Train.Position + New Vector2(400, 0)
                    Else
                        If TrainVelocityX > 0 Then
                            Train.Position.X += TrainVelocityX
                            TrainVelocityX -= 0.02F
                            Player.Position = Train.Position + New Vector2(180, 200)
                        Else
                            Player.HasGravity = True
                            Player.Visible = True
                        End If
                    End If
                End If


                Level.Camera.FocusOnPosition(Train.Position + New Vector2(700, 0))
            End Sub

            Dim displacement As New Vector2(0, 0)
            Private Sub DrawTextFlicker(sb As SpriteBatch, text As String)
                If displacement = New Vector2(0, 0) Then
                    If Random.Next(0, 10) = 0 Then
                        displacement = New Vector2(Random.Next(-10, 10), Random.Next(-10, 10))
                    End If

                Else

                    If Random.Next(0, 5) = 0 Then
                        displacement = New Vector2(0, 0)
                    End If
                End If

                sb.DrawString(Fonts.ChakraPetch.ExtraLarge,
                              text,
                              New Vector2(CSng(graphics.PreferredBackBufferWidth / 2 - Fonts.ChakraPetch.ExtraLarge.MeasureString(text).X / 2), 100) + displacement,
                              Color.Black)

            End Sub
        End Class
    End Namespace
End Namespace