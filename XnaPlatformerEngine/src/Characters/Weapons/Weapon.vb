Imports System.Collections.Generic
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class Weapon

    Public Bullets As New List(Of Bullet)
    Public BulletCooldown As Integer = 200
    Public BulletDamage As Integer = 5
    Public BulletSpeed As Integer = 200
    Public Position As Vector2
    Public BulletsInMag As Integer
    Public BulletsMagMax As Integer = 20
    Public ReloadTime As Integer = 2000

    Public CurrentlyReloading As Boolean = False


    Sub New()
        BulletsInMag = BulletsMagMax
    End Sub

    Public Overridable Sub Update(gameTime As GameTime)
        If BulletsInMag < 1 Then
            ReloadWeapon(gameTime)
        End If

        For Each _bul In Bullets
            _bul.Update(gameTime)
        Next

        Bullets.RemoveAll(Function(x) x.Existing = False)

        BulletCooldownCounter += CInt(gameTime.ElapsedGameTime.TotalMilliseconds)
    End Sub

    Dim BulletCooldownCounter As Integer = 0
    Public Sub ShootAt(_target As Vector2)
        If BulletCooldownCounter > BulletCooldown Then
            If BulletsInMag > 0 Then
                Bullets.Add(New Bullet(Position, Vector2.Normalize(_target - Position) * BulletSpeed, 10))
                BulletsInMag -= 1

                AddHandler Bullets(Bullets.Count - 1).BulletImpact, AddressOf OnBulletImpact

                BulletCooldownCounter = 0
            End If
        End If
    End Sub

    Public Overridable Sub Draw(_sb As SpriteBatch, Optional _parent As Character = Nothing)
        If _parent IsNot Nothing AndAlso TypeOf (_parent) Is Player Then
            If CurrentlyReloading Then
                ' Draw horizontal line
                Misc.DrawRectangle(_sb, New Rectangle(_parent.Position.ToPoint + New Point(0, -20), New Point(CInt(_parent.getTextureSize.X), 2)), Color.Black)

                ' Draw moving vertical line
                Misc.DrawRectangle(_sb, New Rectangle(_parent.Position.ToPoint + New Point(_parent.getTextureSize.X * ReloadCounter / ReloadTime - 2, -24), New Point(4, 10)), Color.Black)
            End If
        End If

        For Each _bul In Bullets
            _bul.Draw(_sb)
        Next
    End Sub

    Public Overridable Sub OnBulletImpact(ByRef sender As Bullet)
    End Sub

    Dim ReloadCounter As Integer = 0
    Public Sub ReloadWeapon(gameTime As GameTime)
        If ReloadCounter >= ReloadTime Then
            ReloadCounter = 0
            BulletsInMag = BulletsMagMax
            CurrentlyReloading = False
        Else
            ReloadCounter += CInt(gameTime.ElapsedGameTime.TotalMilliseconds)
            CurrentlyReloading = True
        End If
    End Sub
End Class
