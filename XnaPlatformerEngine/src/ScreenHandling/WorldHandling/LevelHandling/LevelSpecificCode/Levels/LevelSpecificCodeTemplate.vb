Imports System.Collections.Generic
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Content
Imports Microsoft.Xna.Framework.Graphics

Public MustInherit Class LevelSpecificCodeTemplate
    ''' <summary>
    ''' Ran as the first step when level is loaded
    ''' </summary>
    Public MustOverride Sub Initialize()
    ''' <summary>
    ''' Here specific content that the level uses can be loaded
    ''' </summary>
    ''' <param name="content">The game's ContentManager</param>
    Public MustOverride Sub LoadContent(content As ContentManager)
    ''' <summary>
    ''' Called for every frame while the level is active to draw to the screen 
    ''' </summary>
    ''' <param name="sb">The game's SpriteBatch</param>
    Public MustOverride Sub Draw(sb As SpriteBatch)
    ''' <summary>
    ''' Called regularly to update objects in the level etc.
    ''' </summary>
    ''' <param name="gameTime">GameTime to handle passing real time</param>
    Public MustOverride Sub Update(gameTime As GameTime)

    Friend Player As Player
    Friend Props As List(Of WorldObject)

    Sub New(props As List(Of WorldObject))
        Me.Props = props
    End Sub
End Class
