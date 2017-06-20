Imports System.Collections.Generic
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class ParticleSystem
    Private Particles As New List(Of Particle)
    Public PossibleTextures() As Texture2D
    Public Position As Vector2
    Public ParticleVelocityLowest As Point
    Public ParticleVelocityHighest As Point
    Public ParticleLifetime As Integer = 5000
    Private Rand As New Random
    Public SpawnsPerSecond As Single = 10
    Public ParticleFadeTime As Integer = 500

    Sub New(_pos As Vector2)
        Position = _pos
    End Sub

    Public Sub SpawnParticles(_amount As Integer)
        For i As Integer = 1 To _amount
            Dim randVelocity As Vector2
            randVelocity.X = Rand.Next(ParticleVelocityLowest.X, ParticleVelocityHighest.X + 1)
            randVelocity.Y = Rand.Next(ParticleVelocityLowest.Y, ParticleVelocityHighest.Y + 1)
            Particles.Add(New Particle(PossibleTextures(Misc.GetRandomArrayIndex(PossibleTextures)), Position, randVelocity, ParticleLifetime, ParticleFadeTime))
        Next
    End Sub

    Public Sub Draw(theSpriteBatch As SpriteBatch)
        For Each _par In Particles
            _par.Draw(theSpriteBatch)
        Next
    End Sub

    Dim intervalCounter As Integer = 0
    Public Sub Update(gameTime As GameTime)
        If SpawnsPerSecond <> 0 Then
            Dim spawnInterval As Integer = CInt(1000 / SpawnsPerSecond)


            intervalCounter += CInt(gameTime.ElapsedGameTime.TotalMilliseconds)
            If intervalCounter >= spawnInterval Then
                SpawnParticles(1)
                intervalCounter = 0
            End If
        End If


        For Each _par In Particles
            _par.Update(gameTime)
        Next

        Particles.RemoveAll(Function(x) x.Alive = False)
    End Sub
End Class
