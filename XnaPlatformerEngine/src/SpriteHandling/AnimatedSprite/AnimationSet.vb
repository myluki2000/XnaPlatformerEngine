Imports System.Collections.Generic
Imports Microsoft.Xna.Framework.Content

Public Class AnimationSet
    Public _Animations As New List(Of Animation)

    Sub New()
    End Sub

    Sub New(_anims As Animation())
        Animations.AddRange(_anims)
    End Sub

    Public Property Animations As List(Of Animation)
        Get
            Return _Animations
        End Get
        Set(value As List(Of Animation))
            _Animations = value
        End Set
    End Property

    Public Sub AddAnimation(anim As Animation)
        Animations.Add(anim)
    End Sub

    Public Sub LoadContent(Content As ContentManager)
        For Each _anim In Animations
            _anim.LoadContent(Content)
        Next
    End Sub
End Class
