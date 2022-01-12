
Namespace BeatSaber_CustomLevelCleanup
    Public Class BeatSaberDataParser
        Public Shared Function GetFavoriteLevelsFromPlayerDataFile(ByVal playerData As String)
            Dim favoritesStart As Integer = playerData.IndexOf("favoritesLevelIds")
            Dim nextSectionStart As Integer = playerData.IndexOf("guestPlayers")
            Dim favLevelsSection As String = playerData.Substring(favoritesStart, nextSectionStart - favoritesStart)
            Dim listStart As Integer = favLevelsSection.IndexOf("["c) + 1
            Dim listEnd As Integer = favLevelsSection.IndexOf("]"c)
            Dim commaSeparatedLevelIds As String = favLevelsSection.Substring(listStart, listEnd - listStart)
            Dim favoriteLevels As List(Of String) = commaSeparatedLevelIds.Split(","c).ToList
            Return favoriteLevels.[Select](Function(s) s.Trim(""""c)).ToList
        End Function

        Public Shared Function GetCustomLevelsFromSongHashFile(ByVal songHashData As String) As List(Of CustomLevel)
            Dim levels As List(Of CustomLevel) = New List(Of CustomLevel)()
            Dim commaSeparatedLevels As String = songHashData.Substring(1, songHashData.Length - 3)
            Dim levelsToParse As List(Of String) = commaSeparatedLevels.Split(New String() {"},"}, StringSplitOptions.None).ToList

            For Each s As String In levelsToParse
                Dim pathEnd As Integer = s.IndexOf(":{")
                Dim songHashLocator As String = """songHash"":"
                Dim hashStart As Integer = s.IndexOf(songHashLocator) + songHashLocator.Length
                Dim path As String = s.Substring(0, pathEnd).Trim(""""c)
                Dim hash As String = s.Substring(hashStart, s.Length - hashStart).Trim(""""c)
                levels.Add(New CustomLevel(path, hash))
            Next

            Return levels
        End Function
    End Class
End Namespace
