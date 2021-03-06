﻿Imports System.IO
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Content
Imports Microsoft.Xna.Framework.Graphics

Public Class MainMenu
    Inherits Screen

#Region "UI Declarations"
    Dim WithEvents btnLoadWorld As New ParallelogramButton With {
        .rect = New Rectangle(100, 100, 300, 130),
        .Text = "Load Game",
        .TextAlignment = Button.Alignments.Left,
        .SidePadding = 10}
#End Region

    Public Overrides Sub Inititialize()

    End Sub

    Public Sub LoadContent(Content As ContentManager)

    End Sub

    Public Overrides Sub Update(gameTime As GameTime)

    End Sub

    Public Overrides Sub Draw(sb As SpriteBatch)
        sb.Begin()

        btnLoadWorld.Draw(sb)

        sb.End()
    End Sub

#Region "Event Handlers"
    Private Sub btnLoadWorld_Click() Handles btnLoadWorld.Click
        'Dim ofdWorld As New Windows.Forms.OpenFileDialog
        'ofdWorld.Filter = "World Files | *.pwrld"
        'ofdWorld.Multiselect = False

        'While ofdWorld.FileName = ""
        '    ofdWorld.ShowDialog()
        'End While

        Main.worldFilePath = Directory.GetCurrentDirectory & "\World\world.pwrld"
        Main.LoadWorldOnNextUpdate = True
    End Sub
#End Region
End Class
