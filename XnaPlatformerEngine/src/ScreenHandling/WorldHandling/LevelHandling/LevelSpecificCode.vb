﻿Imports System.Collections.Generic
Imports Microsoft.Xna.Framework

Public Class LevelSpecificCode

    Shared counter As Integer
    Shared TrainX As Integer = 3

    Public Shared Sub Execute(LevelName As String, Props As List(Of WorldObject), Player As Player, gameTime As GameTime)
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

                    Train.Position.X += 2
                    Player.Position = Train.Position

                    LevelCameraMatrix.Translation = New Vector3(-CInt(Train.Position.X), -CInt(Train.Position.Y - graphics.PreferredBackBufferHeight / 2) + 200, 0)

                    For Each o In Props.FindAll(Function(x) x.Name = "Overpass1")
                        Diagnostics.Debug.WriteLine(Props.FindAll(Function(x) x.Name = "Overpass1")(0).GetScreenRect.X)
                        If o.GetScreenRect.Right < 0 Then
                            o.Position.X += 1800
                        End If
                    Next
                End If


        End Select
    End Sub

End Class
