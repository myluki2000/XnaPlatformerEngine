Imports System.Collections.Generic
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Content
Imports Microsoft.Xna.Framework.Graphics

Namespace LevelSpecificCode
    Public Class LevelSpecificCode
        Shared LevelCodeClass As LevelSpecificCodeTemplate

        Public Shared Sub SetCurrentLevel(level As Level, props As List(Of WorldObject))
            Select Case level.Name
                Case "IntroCity"
                    LevelCodeClass = New Levels.IntroCity(level, props)
            End Select
        End Sub

        Public Shared Sub ExecuteInitialization()
            LevelCodeClass.Initialize()
        End Sub

        Public Shared Sub ExecuteLoadContent(content As ContentManager)
            LevelCodeClass.LoadContent(content)
        End Sub

        Public Shared Sub ExecuteDraw(sb As SpriteBatch)
            LevelCodeClass.Draw(sb)
        End Sub

        Public Shared Sub ExecuteUpdate(gameTime As GameTime)
            LevelCodeClass.Update(gameTime)
        End Sub
    End Class
End Namespace
