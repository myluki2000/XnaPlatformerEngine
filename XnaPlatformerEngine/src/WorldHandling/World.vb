Imports System.Collections.Generic
Imports Microsoft.Xna.Framework.Content
Imports Microsoft.Xna.Framework.Graphics

Public Class World
    Inherits Screen

    Public Levels As New List(Of Level)
    Private SelectedLevel As Level

    Public Sub LoadContent(_content As ContentManager)
        For Each _level In Levels
            _level.LoadContent(_content)
        Next
    End Sub

    Public Overrides Sub PostContentLoad()

    End Sub

    Public Sub SetSelectedLevel(index As Integer)
        SelectedLevel = Levels(index)
    End Sub

    Public Overrides Sub Draw(theSpriteBatch As SpriteBatch)
        theSpriteBatch.Begin()

        If SelectedLevel IsNot Nothing Then
            For Each _object In SelectedLevel.PlacedObjects
                _object.Draw(theSpriteBatch)
            Next
        End If
        theSpriteBatch.End()
    End Sub

    Public Sub LoadLevel()

    End Sub
End Class
