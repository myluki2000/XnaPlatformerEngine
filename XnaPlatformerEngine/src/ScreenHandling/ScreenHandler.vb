Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class ScreenHandler
    Shared _SelectedScreen As Screen

    Public Shared Property SelectedScreen As Screen
        Get
            Return _SelectedScreen
        End Get
        Set(value As Screen)
            _SelectedScreen = value
            InitializeSelectedScreen()
        End Set
    End Property

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

    Public Shared Sub Draw(sb As SpriteBatch)
        If SelectedScreen IsNot Nothing Then
            SelectedScreen.Draw(sb)
        End If
    End Sub
End Class
