Imports System.Collections.Generic
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class ParticleSystem
    ''' <summary>
    ''' List of all currently existing particles emitted from the spawner
    ''' </summary>
    Private Particles As New List(Of Particle)
    ''' <summary>
    ''' All textures which canbe applied to the particles
    ''' </summary>
    Public PossibleTextures() As Texture2D
    ''' <summary>
    ''' Position of the particle spawner
    ''' </summary>
    Public Position As Vector2
    ''' <summary>
    ''' The lowest velocity a particle can have
    ''' </summary>
    Public ParticleVelocityLowest As Point
    ''' <summary>
    ''' The highest velocity a particle can have
    ''' </summary>
    Public ParticleVelocityHighest As Point
    ''' <summary>
    ''' How long each particle lives for
    ''' </summary>
    Public ParticleLifetime As Integer = 5000
    ''' <summary>
    ''' How many particles the spawner creates per second
    ''' </summary>
    Public SpawnsPerSecond As Single = 0
    ''' <summary>
    ''' How long a particle fades for (from fully opaque to invisible)
    ''' </summary>
    Public ParticleFadeTime As Integer = 500
    ''' <summary>
    ''' Fired when all particles of the system have despawned
    ''' </summary>
    Public Event ParticlesDespawned()

    Private Rand As New Random

    Sub New(_pos As Vector2)
        Position = _pos
    End Sub

    Sub New()

    End Sub

    Public Sub SpawnParticles(_amount As Integer)
        For i As Integer = 1 To _amount
            Dim randVelocity As Vector2
            randVelocity.X = Rand.Next(ParticleVelocityLowest.X, ParticleVelocityHighest.X + 1)
            randVelocity.Y = Rand.Next(ParticleVelocityLowest.Y, ParticleVelocityHighest.Y + 1)
            Particles.Add(New Particle(PossibleTextures(Misc.GetRandomArrayIndex(PossibleTextures)), Position, randVelocity, ParticleLifetime, ParticleFadeTime))
        Next
    End Sub

    Public Sub Draw(sb As SpriteBatch)
        For Each _par In Particles
            _par.Draw(sb)
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
        If Particles.Count = 0 Then
            RaiseEvent ParticlesDespawned()
        End If
    End Sub
End Class
