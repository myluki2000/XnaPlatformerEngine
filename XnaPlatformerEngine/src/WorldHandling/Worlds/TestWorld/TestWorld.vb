Imports Microsoft.Xna.Framework

Namespace TestWorld
    Public Class TestWorld
        Inherits World

        Public Overrides Sub Inititialize()

        End Sub

        Public Overrides Sub PostContentLoad()
            ' set world objects here
            WorldObjects.Add(New WorldObject() With {.Texture = Textures.Dirt, .Position = New Vector2(100, 100)})
        End Sub
    End Class
End Namespace
