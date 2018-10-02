Imports System.Collections.Generic
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class LevelSpecificCode

    Shared counter As Integer
    Shared TrainX As Integer = 3

    Public Shared Sub ExecuteUpdate(LevelName As String, gameTime As GameTime, Props As List(Of WorldObject), Player As Player)
        counter += gameTime.ElapsedGameTime.Milliseconds

        Select Case LevelName
            Case "IntroCity"
                Dim Train = Props.Find(Function(x) x.Name = "Train")

                If Train.Position = New Vector2(0, 0) Then
                    Train.Position.X = Train.rect.X * 30
                    Train.Position.Y = Train.rect.Y * 30

                    For Each o In Props.FindAll(Function(x) x.Name = "Overpass1")
                        o.Position.X = o.rect.X * 30
                        o.Position.Y = o.rect.Y * 30
                    Next

                    Player.Visible = False
                    Player.HasGravity = False
                End If



                If counter > 10 Then
                    counter = 0

                    If Train.Position.X < 1000 Then
                        Train.Position.X += 2
                        Player.Position = Train.Position
                    Else
                        Player.Visible = True
                        Player.HasGravity = True
                    End If

                    LevelCameraMatrix.Translation = New Vector3(-CInt(Train.Position.X), -CInt(Train.Position.Y - graphics.PreferredBackBufferHeight / 2) + 200, 0)

                    For Each o In Props.FindAll(Function(x) x.Name = "Overpass1")
                        If o.GetScreenRect.Right < 0 Then
                            o.Position.X += 3600
                        End If
                    Next
                End If


        End Select
    End Sub

    Public Shared Sub ExecuteDraw(LevelName As String, sb As SpriteBatch, props As List(Of WorldObject), player As Player)
        Select Case LevelName
            Case "IntroCity"
                sb.Begin()
                Misc.DrawRectangle(sb, New Rectangle(0, graphics.PreferredBackBufferHeight - 100, 50000, 300), New Color(64, 64, 64))
                sb.End()
        End Select
    End Sub
End Class
