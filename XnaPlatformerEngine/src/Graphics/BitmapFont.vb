Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Content
Imports Microsoft.Xna.Framework.Graphics

Public Class BitmapFont
    Private TextureSheet As Texture2D
    Public FrameWidth As Integer

    Public Sub LoadContent(Content As ContentManager, _sheetPath As String, _frameWidth As Integer)
        TextureSheet = Content.Load(Of Texture2D)(_sheetPath)
        FrameWidth = _frameWidth
    End Sub

    Dim displacementIndex As Vector2
    Public Sub DrawString(sb As SpriteBatch, position As Vector2, text As String, Optional scale As Single = 1)
        displacementIndex = Vector2.Zero

        For Each character In text.ToCharArray
            If character <> Convert.ToChar(vbCr) Then
                If character <> Convert.ToChar(vbLf) Then
                    sb.Draw(texture:=TextureSheet,
                    position:=position + New Vector2(displacementIndex.X * FrameWidth * scale, displacementIndex.Y * TextureSheet.Height * scale),
                    sourceRectangle:=New Rectangle(FrameWidth * GetCharacterIndex(character), 0, 70, TextureSheet.Height),
                    scale:=New Vector2(scale, scale))

                    displacementIndex.X += 1
                Else
                    displacementIndex.X = 0
                    displacementIndex.Y += 1
                End If
            End If
        Next
    End Sub

    Private Function GetCharacterIndex(character As Char) As Integer
        If Char.IsLower(character) Then
            Return Convert.ToInt32(character) - 71

        ElseIf Char.IsUpper(character) Then
            Return Convert.ToInt32(character) - 65

        ElseIf Char.IsDigit(character) Then
            Return Convert.ToInt32(character) + 3

        Else
            Select Case character
                Case "."c
                    Return 62

                Case Else


            End Select
        End If



        Return -1
    End Function

    Public Function MeasureString(text As String, Optional scale As Integer = 1) As Vector2
        Return New Vector2(text.Length * FrameWidth * scale, TextureSheet.Height * scale)
    End Function
End Class
