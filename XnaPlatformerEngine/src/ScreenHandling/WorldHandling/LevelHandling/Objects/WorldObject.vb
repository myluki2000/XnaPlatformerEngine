Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class WorldObject
    Inherits Sprite

    Public rect As Rectangle

    Public zIndex As Integer = 0

    Public IsPlayerInRange As Boolean = False

    Public HasRandomTextureRotation As Boolean = False
    Public IsFoliage As Boolean = False

    Public Rotation As Single = 0

    Public ParallaxMultiplier As Single = 1.0F

    Public IsProp As Boolean = False

    Sub New()
        RotateRandomly()

    End Sub

    Public Sub RotateRandomly()
        If HasRandomTextureRotation Then
            Rotation = CSng(Random.Next(0, 4) * Math.PI / 2)
        End If
    End Sub

    Public Overrides Sub Update(gameTime As GameTime)
    End Sub

    Public Overridable Sub Interaction()
    End Sub

    Public Overrides Sub Draw(sb As SpriteBatch)
        If Texture IsNot Nothing Then
            If Not IsProp Then
                ' Add 15 for destrect position because origin of sprite is in the center of it
                sb.Draw(Texture, New Rectangle(CInt(rect.X * 30 + rect.Width / 2), CInt(rect.Y * 30 + rect.Height / 2), CInt(rect.Width * Scale), CInt(rect.Height * Scale)), Nothing, Color.White, Rotation, New Vector2(CSng(Texture.Width / 2), CSng(Texture.Height / 2)), Nothing, Nothing)
            Else
                ' Add 15 for destrect position because origin of sprite is in the center of it
                sb.Draw(Texture, New Rectangle(CInt(Position.X + rect.Width / 2), CInt(Position.Y + rect.Height / 2), CInt(rect.Width * Scale), CInt(rect.Height * Scale)), Nothing, Color.White, Rotation, New Vector2(CSng(Texture.Width / 2), CSng(Texture.Height / 2)), Nothing, Nothing)
            End If

            ' Misc.DrawOutline(sb, New Rectangle(CInt(rect.X * 30), CInt(rect.Y * 30), CInt(rect.Width * Scale), CInt(rect.Height * Scale)), Color.Red, 2)
        Else
            Misc.DrawOutline(sb, New Rectangle(CInt(rect.X * 30), CInt(rect.Y * 30), CInt(rect.Width * Scale), CInt(rect.Height * Scale)), Color.Red, 2)
        End If
    End Sub

    Public Function ShallowCopy() As WorldObject
        Return DirectCast(Me.MemberwiseClone, WorldObject)
    End Function

    Public Overrides Function GetScreenRect() As Rectangle
        If IsProp Then
            Return New Rectangle(CInt(Position.X + LevelCameraMatrix.Translation.X), CInt(Position.Y + LevelCameraMatrix.Translation.Y), rect.Width, rect.Height)
        Else
            Return New Rectangle(CInt(rect.X * 30 + LevelCameraMatrix.Translation.X), CInt(rect.Y * 30 + LevelCameraMatrix.Translation.Y), rect.Width, rect.Height)
        End If
    End Function

    Public Overrides Function GetTrueRect() As Rectangle
        Return New Rectangle(rect.X * 30, rect.Y * 30, rect.Width, rect.Height)
    End Function
End Class
