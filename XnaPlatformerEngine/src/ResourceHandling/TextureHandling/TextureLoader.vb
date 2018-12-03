Imports System.IO
Imports Microsoft.Xna.Framework.Graphics

Public Class TextureLoader
    Public Shared Function Load(contentPath As String) As Texture2D
        Dim p = contentPath & ".png"
        Dim fs = New FileStream(p, FileMode.Open)
        Dim tex = Texture2D.FromStream(graphics.GraphicsDevice, fs)
        fs.Dispose()
        Return tex
    End Function
End Class
