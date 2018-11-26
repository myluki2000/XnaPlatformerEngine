Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Partial Public Class Character
    Inherits AnimatedSprite

    Friend Velocity As New Vector2(0, 0)
    Friend Acceleration As New Vector2(0, 0)
    ''' <summary>
    ''' True when character is on the ground
    ''' </summary>
    Public IsGrounded As Boolean = True
    ''' <summary>
    ''' True when the character is alive
    ''' </summary>
    Public Alive As Boolean = True
    ''' <summary>
    ''' Direction the character is looking at
    ''' </summary>
    Public ViewDirection As ViewDirections = ViewDirections.Right
    ''' <summary>
    ''' Character is drawn to screen when true
    ''' </summary>
    Public Visible As Boolean = True
    ''' <summary>
    ''' Abides to gravity when true, ignores it when false
    ''' </summary>
    Public HasGravity As Boolean = True
    ''' <summary>
    ''' Type of the character
    ''' </summary>
    Public CharacterType As CharacterTypes
    ''' <summary>
    ''' Current health points of the character
    ''' </summary>
    Public HealthPoints As Integer = 100
    ''' <summary>
    ''' The weapon this character is using
    ''' </summary>
    Public Weapon As Weapon

    Public Enum CharacterTypes
        Player
        Enemy
        Friendly
    End Enum

    Public Enum ViewDirections
        Left
        Right
    End Enum

    Sub New(_frmWidth As Integer, _cType As CharacterTypes)
        MyBase.New(_frmWidth)

        CharacterType = _cType
        Weapon = New AR(CharacterType)
    End Sub

    Public Sub Jump()
        If IsGrounded Then
            Velocity.Y = -120
        End If
    End Sub

    Public Overrides Sub Update(gameTime As GameTime)
        MyBase.Update(gameTime)

        Dim _newPos As Vector2 = Velocity * CSng(gameTime.ElapsedGameTime.TotalSeconds)

        If HasGravity Then
            CollidingCheck(_newPos, gameTime)
        End If

        Weapon.Position = Position
        Weapon.Update(gameTime)

        If HealthPoints < 1 Then
            Alive = False
        End If

    End Sub

    Public Overrides Sub Draw(sb As SpriteBatch)
        If Visible Then
            If SelectedAnimation IsNot Nothing Then
                sb.Draw(SelectedAnimation.Texture, New Rectangle(CInt(Position.X), CInt(Position.Y), FrameWidth, SelectedAnimation.Texture.Height), srcRect, Color.White)
            End If

            Weapon.Draw(sb, Me)
        End If
    End Sub

    Public Overrides Function GetTrueRect() As Rectangle
        Return New Rectangle(Position.ToPoint, getTextureSize.ToPoint)
    End Function

    Public Overrides Function GetScreenRect() As Rectangle
        Return New Rectangle(Position.ToPoint - New Point(CInt(LevelCameraMatrix.Translation.X), CInt(LevelCameraMatrix.Translation.Y)), getTextureSize.ToPoint)
    End Function

    Public Overridable Sub Interaction()

    End Sub

    Public Sub SwitchViewDirection()
        Select Case ViewDirection
            Case ViewDirections.Left
                ViewDirection = ViewDirections.Right
            Case ViewDirections.Right
                ViewDirection = ViewDirections.Left
        End Select
    End Sub
End Class
