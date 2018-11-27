Imports System.Collections.Generic
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Content
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Input

Namespace LevelSpecificCode
    Namespace Levels
        Public Class IntroCity
            Inherits LevelSpecificCodeTemplate

            Shared TrainX As Integer = 3
            Shared TrainVelocityX As Single = 4.0F

            Private Class Textures
                Public Shared Logo As Texture2D
                Public Shared TrainLights As Texture2D
            End Class

            Public Overrides Sub Initialize()
                ScreenHandler.SelectedScreen.ToWorld.SelectedLevel.Camera.Scale = New Vector3(1.4, 1.4, 1)
            End Sub

            Public Overrides Sub LoadContent(content As ContentManager)
                Textures.Logo = TextureLoader.Load("World/Textures/Other/logo")
                Textures.TrainLights = TextureLoader.Load("World/Textures/Blocks/City/train_lights")
            End Sub

            Dim Transparency As Single = -0.5
            Dim TrainCountdown As Integer = 8000
            Dim PassingTrainActivated As Boolean = False

            Dim lastscroll As Integer = 0
            Public Overrides Sub Draw(sb As SpriteBatch)
                sb.Begin(,,,,,, ScreenHandler.SelectedScreen.ToWorld.SelectedLevel.Camera.GetMatrix())

                Misc.DrawRectangle(sb, New Rectangle(0, -1000, 1600, 3000), Color.Black)

                sb.End()

                sb.Begin()

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

                If TrainCountdown < 1000 AndAlso Transparency > 0 Then
                    Transparency -= 0.2F
                End If


                sb.Draw(Textures.Logo, New Vector2(CSng(graphics.PreferredBackBufferWidth / 2), CSng(graphics.PreferredBackBufferHeight / 2)),
                        Nothing, Color.White * Transparency, Nothing, New Vector2(CSng(Textures.Logo.Width / 2), CSng(Textures.Logo.Height / 2)), 0.8, Nothing, Nothing)

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

                Dim Train = Props.Find(Function(x) x.Name = "Train1")

                If Train.Position = New Vector2(0, 0) Then
                    Train.Position.X = Train.rect.X * 30
                    Train.Position.Y = Train.rect.Y * 30

                    Player.Visible = False
                    Player.HasGravity = False
                End If



                If Counter > 10 Then
                    Counter = 0

                    If Train.Position.X < 1200 Then
                        Train.Position.X += TrainVelocityX
                        Player.Position = Train.Position
                    Else
                        If TrainVelocityX > 0 Then
                            Train.Position.X += TrainVelocityX
                            TrainVelocityX -= 0.02F
                            Player.Position = Train.Position
                        Else
                            Player.HasGravity = True
                            Player.Visible = True
                        End If
                    End If
                End If



                selectedLevel.Camera.Translation = New Vector3(-CInt(Train.Position.X * selectedLevel.Camera.Scale.X),
                        -CInt(Train.Position.Y - (graphics.PreferredBackBufferHeight / 2 + 100) / selectedLevel.Camera.Scale.Y),
                        0)
            End Sub

            Sub New(props As List(Of WorldObject))
                MyBase.New(props)
            End Sub
        End Class
    End Namespace
End Namespace