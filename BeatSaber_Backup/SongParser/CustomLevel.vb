Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Security.Policy
Imports System.Text
Imports System.Threading.Tasks

Namespace BeatSaber_CustomLevelCleanup
    Public Class CustomLevel
        Public ReadOnly Property SongHash As String
        Public ReadOnly Property Directory As String

        Public ReadOnly Property TrimmedDirectory As String
            Get
                Return Path.GetFileName(Me.Directory)
            End Get
        End Property

        Public Property IsFavorite As Boolean

        Public Sub New(ByVal path As String, ByVal hash As String)
            IsFavorite = False
            SongHash = hash
            Directory = path
        End Sub
    End Class
End Namespace
