﻿Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class Enemy
    Inherits Character

    Sub New(_frmWidth As Integer, _rect As Rectangle)
        MyBase.New(_frmWidth, _rect)
    End Sub

    Public Overrides Sub Update(gameTime As GameTime)
        MyBase.Update(gameTime)
    End Sub

    Public Overrides Sub Draw(theSpriteBatch As SpriteBatch)
        MyBase.Draw(theSpriteBatch)
    End Sub
End Class
