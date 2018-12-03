Imports Microsoft.Xna.Framework.Content

Public Class AnimationSets
    Public Shared Player As New AnimationSet({New Animation("idle", "Content/Characters/Player/idle", 500)})
    Public Shared BasicSoldier As New AnimationSet

    Public Shared Sub LoadContent(Content As ContentManager)
        Player.LoadContent(Content)
    End Sub
End Class
