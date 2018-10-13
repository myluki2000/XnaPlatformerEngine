Imports System.Collections.Generic
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Content
Imports Microsoft.Xna.Framework.Graphics

Public MustInherit Class LevelSpecificCodeTemplate

    Public MustOverride Sub Initialize()
    Public MustOverride Sub LoadContent(content As ContentManager)
    Public MustOverride Sub Draw(sb As SpriteBatch)
    Public MustOverride Sub Update(gameTime As GameTime)

    Friend Player As Player
    Friend Props As List(Of WorldObject)

    Sub New(props As List(Of WorldObject))
        Me.Props = props
    End Sub
End Class
