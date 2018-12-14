Imports Microsoft.Xna.Framework.Content
Imports Microsoft.Xna.Framework.Graphics

Public Class Fonts
    Public Class ChakraPetch
        Public Shared Normal As SpriteFont          ' Loaded at program start
        ''' <summary>
        ''' Font Size: 32
        ''' </summary>
        Public Shared Large As SpriteFont           ' Loaded at program start
        ''' <summary>
        ''' Font Size: 90
        ''' </summary>
        Public Shared ExtraLarge As SpriteFont
    End Class

    Public Shared Sub LoadContent(content As ContentManager)
        ChakraPetch.ExtraLarge = content.Load(Of SpriteFont)("Fonts/ChakraPetch/ChakraPetch-ExtraLarge")

    End Sub
End Class
