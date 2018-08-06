Imports System.Collections.Generic
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics

Public Class ShadowOverlayRenderer
    Public Shared Sub RenderShadowOverlay(sb As SpriteBatch, shadowOverlay As RenderTarget2D, lightPolygons As List(Of Polygon))
        graphics.GraphicsDevice.SetRenderTarget(shadowOverlay)

        sb.Begin()
        For Each p In lightPolygons
            p.DrawOutline(sb, False, New Color(1, 0, 0, 0))
        Next

        sb.End()

        ' Find point in each polygon
        For Each p In lightPolygons
            For i As Integer = 0 To p.corners.Count - 1
                ' Check if angle for i and next 2 points is convex

                Dim v1 As Vector2 = p.corners(i) - p.corners((i + 1) Mod (p.corners.Count - 1))
                Dim v2 As Vector2 = p.corners((i + 1) Mod (p.corners.Count - 1)) - p.corners((i + 2) Mod (p.corners.Count - 1))

                Dim dp = Vector2.Dot(v1, v2)

                Dim angle = (dp / (v1.Length * v2.Length))


                If angle < 0 AndAlso angle > -Math.PI / 2 Then

                    Dim vm As New Vector2((-v1.X + v2.X) / 2, (-v1.Y + v2.Y) / 2)

                    Dim pointInP As Vector2 = p.corners((i + 1) Mod (p.corners.Count - 1)) - (vm / 5)

                    Misc.FloodFill(shadowOverlay, pointInP.ToPoint)
                    Exit For
                End If

            Next
        Next

        graphics.GraphicsDevice.SetRenderTarget(Nothing)
    End Sub
End Class
