Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Input

Public Class ParallelogramButton
    Inherits Button
    Public Overrides Sub Draw(sb As SpriteBatch)
        If Visible Then
            ' Draw checked button
            If Checked Then

            End If

            If rect.Contains(Mouse.GetState.Position) Then
                If Mouse.GetState.LeftButton = ButtonState.Pressed Then
                    ' Draw clicked button

                Else
                    ' Draw hovered button

                End If
            Else
                ' Draw normal button

            End If

            MyBase.Draw(sb)

        End If
    End Sub
End Class
