Imports System.Collections.Generic
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class ScreenHandler
    Shared SelectedScreen As Screen


    Shared Sub InitializeSelectedScreen()
        If SelectedScreen IsNot Nothing Then
            SelectedScreen.Inititialize()
        End If
    End Sub

    Public Shared Sub Update(gameTime As GameTime)
        If SelectedScreen IsNot Nothing Then
            SelectedScreen.Update(gameTime)
        End If
    End Sub

    Public Shared Sub Draw(theSpriteBatch As SpriteBatch)
        If SelectedScreen IsNot Nothing Then
            SelectedScreen.Draw(theSpriteBatch)
        End If
    End Sub

    Public Shared Sub SetSelectedScreen(_screen As Screen)
        SelectedScreen = _screen
        InitializeSelectedScreen()
    End Sub

    Public Shared Function GetSelectedScreen() As Screen
        Return SelectedScreen
    End Function
End Class
