Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class Enemy
    Inherits NPC

    Dim Player As Player = ScreenHandler.SelectedScreen.ToWorld.Player

    Sub New(_frmWidth As Integer)
        MyBase.New(_frmWidth, CharacterTypes.Enemy)
    End Sub

    Dim viewDirectionCounter As Integer = 0
    Public Overrides Sub Update(gameTime As GameTime)
        MyBase.Update(gameTime)

        If IsPlayerInSight() Then
            Select Case ViewDirection
                Case ViewDirections.Left
                    Weapon.ShootLeft()
                Case ViewDirections.Right
                    Weapon.ShootRight()
            End Select

            viewDirectionCounter = 0
        Else
            If viewDirectionCounter > 1999 Then
                SwitchViewDirection()
                viewDirectionCounter = 0
            End If
        End If


        viewDirectionCounter += CInt(gameTime.ElapsedGameTime.TotalMilliseconds)
    End Sub

    Dim viewRect As Rectangle
    Public Function IsPlayerInSight() As Boolean
        If Math.Abs(Player.Position.X - Position.X) > 300 Then
            Return False
        End If

        Select Case ViewDirection
            Case ViewDirections.Left
                viewRect = New Rectangle(CInt(Player.Position.X), CInt(Position.Y), CInt(Position.X - Player.Position.X), 32)

            Case ViewDirections.Right
                viewRect = New Rectangle(CInt(Position.X), CInt(Position.Y), CInt(Player.Position.X - Position.X), 32)
        End Select

        For Each wObj In ScreenHandler.SelectedScreen.ToWorld.SelectedLevel.PlacedObjects
            If viewRect.Intersects(wObj.GetTrueRect) AndAlso wObj.GetType = GetType(WorldObject) Then
                Return False
            End If
        Next

        If Player.GetTrueRect.Intersects(viewRect) Then
            Return True
        End If

        Return False
    End Function

    Public Overrides Sub Draw(sb As SpriteBatch)
        MyBase.Draw(sb)
    End Sub
End Class
