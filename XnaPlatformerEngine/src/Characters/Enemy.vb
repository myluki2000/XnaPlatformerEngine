Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class Enemy
    Inherits Character

    Dim Player As Player = ScreenHandler.SelectedScreen.ToWorld.Player

    Sub New(_frmWidth As Integer, _rect As Rectangle)
        MyBase.New(_frmWidth, _rect, CharacterTypes.Enemy)
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

    Dim _viewRect As Rectangle
    Public Function IsPlayerInSight() As Boolean
        If Math.Abs(Player.Position.X - Position.X) > 300 Then
            Return False
        End If

        Select Case ViewDirection
            Case ViewDirections.Left
                    _viewRect = New Rectangle(CInt(Player.Position.X), CInt(Position.Y), CInt(Position.X - Player.Position.X), 32)

                Case ViewDirections.Right
                    _viewRect = New Rectangle(CInt(Position.X), CInt(Position.Y), CInt(Player.Position.X - Position.X), 32)
            End Select

        For x As Integer = 0 To ScreenHandler.SelectedScreen.ToWorld.SelectedLevel.PlacedObjects.GetUpperBound(0)
            For y As Integer = 0 To ScreenHandler.SelectedScreen.ToWorld.SelectedLevel.PlacedObjects.GetUpperBound(1)
                Dim _wObj As WorldObject = ScreenHandler.SelectedScreen.ToWorld.SelectedLevel.PlacedObjects(x, y, 50)
                If _wObj IsNot Nothing AndAlso _wObj.GetType Is GetType(WorldObject) Then
                    If _viewRect.Intersects(_wObj.getTrueRect) Then
                        Return False

                    End If
                End If
            Next
        Next

        If Player.getTrueRect.Intersects(_viewRect) Then
                Return True
            End If

            Return False
    End Function

    Public Overrides Sub Draw(sb As SpriteBatch)
        MyBase.Draw(sb)
    End Sub
End Class
