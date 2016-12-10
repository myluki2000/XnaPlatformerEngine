Imports System.Collections.Generic
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class ScreenHandler
    Public Shared SelectedScreen As Screen = New TestScreen


    Public Shared Sub InitializeSelectedScreen()
        SelectedScreen.Inititialize()
    End Sub

    Public Shared Sub Update(gameTime As GameTime)
        SelectedScreen.Update(gameTime)
    End Sub

    Public Shared Sub Draw(theSpriteBatch As SpriteBatch)
        SelectedScreen.Draw(theSpriteBatch)
    End Sub
End Class
