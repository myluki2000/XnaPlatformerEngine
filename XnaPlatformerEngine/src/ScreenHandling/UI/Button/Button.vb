Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Input

Public MustInherit Class Button
    Inherits UIElement

    Public Event Click(sender As Object)
    Public Event MouseEnter(sender As Object)
    Public Event MouseLeave(sender As Object)
    Public Text As String = ""

    Public ToggleButton As Boolean = False
    Public Checked As Boolean = False
    Public Enabled As Boolean = True
    Public TextAlignment As Alignments
    Public SidePadding As Integer = 5


    Public Enum Alignments
        Left
        Center
        Right
    End Enum

    Sub New()
        Visible = True
    End Sub

    Dim MouseLastState As MouseState
    Public Overrides Sub Draw(sb As SpriteBatch)
        If Enabled Then
            DetectButtonInteraction()
        End If

        MouseLastState = Mouse.GetState
    End Sub

    Private Sub DetectButtonInteraction()
        If rect.Contains(Mouse.GetState.Position) Then
            If Mouse.GetState.LeftButton = ButtonState.Pressed AndAlso MouseLastState.LeftButton = ButtonState.Released Then
                RaiseEvent Click(Me)

                ' Switch checked when button is ToggleButton and clicked
                If ToggleButton Then
                    Checked = Not Checked
                End If
            End If

            If Not rect.Contains(MouseLastState.Position) Then
                RaiseEvent MouseEnter(Me)
            End If
        End If

        ' Detect mouse leave button area
        If rect.Contains(MouseLastState.Position) AndAlso Not rect.Contains(Mouse.GetState.Position) Then
            RaiseEvent MouseLeave(Me)
        End If
    End Sub
End Class


' ------------TEMPLATE FOR BUTTON DRAW METHODS------------

'' Draw checked button
'If Checked Then

'End If

'If rect.Contains(Mouse.GetState.Position) Then
'If Mouse.GetState.LeftButton = ButtonState.Pressed Then
'' Draw clicked button

'Else
'' Draw hovered button

'End If
'Else
'' Draw normal button

'End If