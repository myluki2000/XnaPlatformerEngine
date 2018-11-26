Imports System.Collections.Generic
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class Misc

    Shared dummyTexture As Texture2D = New Texture2D(graphics.GraphicsDevice, 1, 1)

    Shared Sub New()
        dummyTexture.SetData(New Color() {Color.White})
    End Sub

    ''' <summary>
    ''' Draw a single-color rectangle
    ''' </summary>
    ''' <param name="sb">SpriteBatch to draw with</param>
    ''' <param name="destRect">Rectangle to draw</param>
    ''' <param name="color">Color of the rectangle</param>
    Public Shared Sub DrawRectangle(sb As SpriteBatch, destRect As Rectangle, color As Color)
        sb.Draw(dummyTexture, destRect, color)
    End Sub

    ''' <summary>
    ''' Draw a single-color rectangle with an outline
    ''' </summary>
    ''' <param name="sb">SpriteBatch to draw with</param>
    ''' <param name="destRect">Rectangle to draw</param>
    ''' <param name="color">Color of the rectangle</param>
    ''' <param name="colorOutline">Color of the outline of the rectangle</param>
    ''' <param name="thicknessOutline">Thickness of the outline</param>
    Public Shared Sub DrawRectangle(sb As SpriteBatch, destRect As Rectangle, color As Color, colorOutline As Color, thicknessOutline As Integer)
        DrawRectangle(sb, destRect, color) ' Main Rect
        DrawRectangle(sb, New Rectangle(destRect.X, destRect.Y, destRect.Width, thicknessOutline), colorOutline) ' Outline Top
        DrawRectangle(sb, New Rectangle(destRect.X, destRect.Y + destRect.Height - thicknessOutline, destRect.Width, thicknessOutline), colorOutline) ' Outline Bottom
        DrawRectangle(sb, New Rectangle(destRect.X, destRect.Y, thicknessOutline, destRect.Height), colorOutline) ' Outline Left
        DrawRectangle(sb, New Rectangle(destRect.X + destRect.Width - thicknessOutline, destRect.Y, thicknessOutline, destRect.Height), colorOutline) ' Outline Right
    End Sub

    ''' <summary>
    ''' Draw a rectangular outline
    ''' </summary>
    ''' <param name="sb">SpriteBatch to draw with</param>
    ''' <param name="destRect">Rectangle to draw the outline around</param>
    ''' <param name="colorOutline">Color of the outline</param>
    ''' <param name="thicknessOutline">Thickness of the outline</param>
    Public Shared Sub DrawOutline(sb As SpriteBatch, destRect As Rectangle, colorOutline As Color, thicknessOutline As Integer)
        DrawRectangle(sb, New Rectangle(destRect.X, destRect.Y, destRect.Width, thicknessOutline), colorOutline) ' Outline Top
        DrawRectangle(sb, New Rectangle(destRect.X, destRect.Y + destRect.Height - thicknessOutline, destRect.Width, thicknessOutline), colorOutline) ' Outline Bottom
        DrawRectangle(sb, New Rectangle(destRect.X, destRect.Y, thicknessOutline, destRect.Height), colorOutline) ' Outline Left
        DrawRectangle(sb, New Rectangle(destRect.X + destRect.Width - thicknessOutline, destRect.Y, thicknessOutline, destRect.Height), colorOutline) ' Outline Right
    End Sub

    ''' <summary>
    ''' Draw a line between two points
    ''' </summary>
    ''' <param name="sb">SpriteBatch to draw with</param>
    ''' <param name="startPoint">First end point of the line</param>
    ''' <param name="end">Second end point of line</param>
    ''' <param name="color">Color of the line</param>
    Public Shared Sub DrawLine(sb As SpriteBatch, startPoint As Vector2, endPoint As Vector2, color As Color)
        Dim edge As Vector2 = endPoint - startPoint
        ' calculate angle to rotate line
        Dim angle As Single = CSng(Math.Atan2(edge.Y, edge.X))


        ' rectangle defines shape of line and position of start of line
        ' sb will strech the texture to fill this rectangle
        ' width of line, change this to make thicker line
        ' colour of line
        ' angle of line (calulated above)
        ' point in line about which to rotate
        sb.Draw(dummyTexture, New Rectangle(CInt(startPoint.X), CInt(startPoint.Y), CInt(edge.Length()), 1), Nothing, color, angle, New Vector2(0, 0),
        SpriteEffects.None, 0)

    End Sub

    ''' <summary>
    ''' Convert hex code to Color object
    ''' </summary>
    ''' <param name="hexColor">hex color code as String</param>
    ''' <returns></returns>
    Public Shared Function ConvertToRbg(ByVal hexColor As String) As Color
        Dim Red As Integer
        Dim Green As Integer
        Dim Blue As Integer
        hexColor = Replace(hexColor, "#", "")
        Red = CInt("&H" & Mid(hexColor, 1, 2))
        Green = CInt("&H" & Mid(hexColor, 3, 2))
        Blue = CInt("&H" & Mid(hexColor, 5, 2))
        Return New Color(Red, Green, Blue, 255)
    End Function

    ''' <summary>
    ''' Converts a Texture2D object to a 2-dimentional array of color values
    ''' </summary>
    ''' <param name="texture">Texture to convert</param>
    ''' <returns>2D color array (x, y)</returns>
    Public Shared Function TextureTo2DArray(texture As Texture2D) As Color(,)
        Dim colors1D As Color() = New Color(texture.Width * texture.Height - 1) {}
        texture.GetData(colors1D)


        Dim colors2D As Color(,) = New Color(texture.Width - 1, texture.Height - 1) {}
        For x As Integer = 0 To texture.Width - 1
            For y As Integer = 0 To texture.Height - 1
                colors2D(x, y) = colors1D(x + y * texture.Width)
            Next
        Next

        Return colors2D
    End Function

    '''' <summary>
    '''' Convert a list of world objects to a 3-dimentional array of world objects
    '''' </summary>
    '''' <param name="_wObjs">List of world objects to convert</param>
    '''' <returns>3D WorldObject array (x, y, z)</returns>
    'Public Shared Function WObjListTo3DArray(_wObjs As List(Of WorldObject)) As WorldObject(,,)
    '    Dim arrWObjs(,,) As WorldObject

    '    Dim minX As Integer = 0
    '    Dim minY As Integer = 0

    '    ' Find min x and y values
    '    For Each _wObj In _wObjs
    '        If _wObj.rect.X < minX Then
    '            minX = _wObj.rect.X
    '        End If

    '        If _wObj.rect.Y < minY Then
    '            minY = _wObj.rect.Y
    '        End If
    '    Next

    '    ' Move x and y values of all placed objects so no position is < 0
    '    For Each _wObj In _wObjs
    '        _wObj.rect.X += -minX
    '        _wObj.rect.Y += -minY
    '    Next


    '    Dim maxX As Integer = 0
    '    Dim maxY As Integer = 0

    '    ' Find max x and y values for placed objects
    '    For Each _wObj In _wObjs
    '        If _wObj.rect.X > maxX Then
    '            maxX = _wObj.rect.X
    '        End If

    '        If _wObj.rect.Y > maxY Then
    '            maxY = _wObj.rect.Y
    '        End If
    '    Next


    '    ' Resize array
    '    ReDim arrWObjs(maxX, maxY, 100)

    '    ' Copy objects from list to array
    '    For Each _wObj In _wObjs
    '        arrWObjs(_wObj.rect.X, _wObj.rect.Y, _wObj.zIndex + 50) = _wObj
    '    Next

    '    Return arrWObjs
    'End Function

    ''' <summary>
    ''' Converts screen coordinates to level coordinates
    ''' </summary>
    ''' <param name="screenPos">Position on the screen</param>
    ''' <returns></returns>
    Public Shared Function ScreenPosToWorldPos(screenPos As Point) As Vector2
        Return New Vector2((screenPos.X - LevelCameraMatrix.Translation.X) / LevelCameraMatrix.Scale.X,
                           (screenPos.Y - LevelCameraMatrix.Translation.Y) / LevelCameraMatrix.Scale.Y)
    End Function

    ''' <summary>
    ''' Returns a random index of an array
    ''' </summary>
    ''' <param name="_arr">Array to get index for</param>
    ''' <returns>index</returns>
    Public Shared Function GetRandomArrayIndex(_arr() As Object) As Integer
        Dim rand As New Random
        Return rand.Next(0, _arr.GetLength(0))
    End Function

    ''' <summary>
    ''' Subtract two colors from each other
    ''' </summary>
    ''' <param name="color1">Base color</param>
    ''' <param name="color2">color to subtract</param>
    ''' <returns></returns>
    Public Shared Function SubtractColors(color1 As Color, color2 As Color) As Color
        Dim returnColor As New Color

        If CInt(color1.R) - color2.R > 0 Then
            returnColor.R = color1.R - color2.R
        Else
            returnColor.R = 0
        End If

        If CInt(color1.G) - color2.G > 0 Then
            returnColor.G = color1.G - color2.G
        Else
            returnColor.G = 0
        End If

        If CInt(color1.B) - color2.B > 0 Then
            returnColor.B = color1.B - color2.B
        Else
            returnColor.B = 0
        End If

        If CInt(color1.A) - color2.A > 0 Then
            returnColor.A = color1.A - color2.A
        Else
            returnColor.A = 0
        End If

        Return returnColor
    End Function

    ''' <summary>
    ''' UNTESTED - MAY NOT WORK CORRECTLY
    ''' </summary>
    ''' <param name="rt"></param>
    ''' <param name="point"></param>
    Public Shared Sub FloodFill(rt As RenderTarget2D, point As Point)
        Throw New NotImplementedException("Function was never tested or may not be complete. Test before using")

        Dim colors(rt.Width * rt.Height) As Color
        rt.GetData(colors)

        Dim coordStack As New Stack(Of Point)

        coordStack.Push(point)

        While coordStack.Count > 0
            Dim p As Point = coordStack.Pop

            Try
                If colors(p.Y * rt.Width + p.X) = New Color(0, 0, 0) Then

                    colors(p.Y * rt.Width + p.X) = New Color(0, 0, 0, 0)

                    coordStack.Push(p + New Point(1, 0))
                    coordStack.Push(p + New Point(-1, 0))
                    coordStack.Push(p + New Point(0, -1))
                    coordStack.Push(p + New Point(0, 1))

                End If
            Catch ex As Exception

            End Try
        End While

        rt.SetData(colors)
    End Sub
End Class
