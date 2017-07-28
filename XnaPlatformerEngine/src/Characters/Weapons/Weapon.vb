Imports System.Collections.Generic
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class Weapon

    Public Bullets As New List(Of Bullet)
    Public BulletCooldown As Integer = 200
    Public BulletDamage As Integer = 5
    Public Position As Vector2

    Public Overridable Sub Update(gameTime As GameTime)
        For Each _bul In Bullets
            _bul.Update(gameTime)
        Next

        Bullets.RemoveAll(Function(x) x.Existing = False)

        BulletCooldownCounter += CInt(gameTime.ElapsedGameTime.TotalMilliseconds)
    End Sub

    Dim BulletCooldownCounter As Integer = 0
    Public Sub ShootAt(_target As Vector2)
        If BulletCooldownCounter > BulletCooldown Then
            Bullets.Add(New Bullet(Position, Vector2.Normalize(_target - Position) * 200, 10))

            AddHandler Bullets(Bullets.Count - 1).BulletImpact, AddressOf OnBulletImpact

            BulletCooldownCounter = 0
        End If
    End Sub

    Public Overridable Sub Draw(theSpriteBatch As SpriteBatch)
        For Each _bul In Bullets
            _bul.Draw(theSpriteBatch)
        Next
    End Sub

    Public Overridable Sub OnBulletImpact(ByRef sender As Bullet)
    End Sub
End Class
