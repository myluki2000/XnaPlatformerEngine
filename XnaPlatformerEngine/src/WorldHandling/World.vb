Imports System.Collections.Generic
Imports Microsoft.Xna.Framework.Graphics

Public MustInherit Class World
    Inherits Screen

    Public Shared WorldObjects As New List(Of WorldObject)

    Public Overrides Sub PostContentLoad()

    End Sub

    Public Overrides Sub Draw(theSpriteBatch As SpriteBatch)
        theSpriteBatch.Begin()

        For Each _object In WorldObjects
            _object.Draw(theSpriteBatch)
        Next
        theSpriteBatch.End()
    End Sub
End Class
