Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class ParticleSpawner
    Inherits TechnicalObject
    Public ps As New ParticleSystem
    Public InnerPosition As Vector2

    Sub New()
        Name = "Particle" & vbNewLine & "Spawner"
        Throw New NotImplementedException
    End Sub

    Public Overrides Sub Draw(theSpriteBatch As SpriteBatch)
        Throw New NotImplementedException
    End Sub
End Class
