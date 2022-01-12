Imports System.Security.Cryptography
Imports System.Text
Imports System.IO


Public Class Form_Main


    Dim Watch_BS_Process As Boolean = True
    Dim ProgressBar2 As MyProgressBar
    Private Sub Form_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load


            ProgressBar2 = New MyProgressBar()
            ProgressBar2.Location = New Point(400, 328)
            ProgressBar2.Size = New Size(339, 12)
            ProgressBar2.BackColor = Color.FromArgb(255, 230, 230, 230)

            Me.Controls.Add(ProgressBar2)
            AddHandler ProgressBar2.MouseDown, AddressOf ProgressBar2_MouseDown
            AddHandler ProgressBar2.MouseUp, AddressOf ProgressBar2_MouseUp
            AddHandler ProgressBar2.MouseMove, AddressOf ProgressBar2_MouseMove

            'set values

            ProgressBar2.Minimum = 0
            ProgressBar2.Maximum = 100
            ProgressBar2.Value = 0
            'add the progress bar to the form
            Me.Controls.Add(ProgressBar2)


            'Load settings
            TextBox_BackupFolder.Text = My.Settings.BackupPath

            ListBox_Protocol.Items.Add(DateTime.Now & "     | " & "Checking Betasaberregistryentry...")
            'Get Beatsaberinstallpath from registry
            Dim regVersion64 As Microsoft.Win32.RegistryKey = Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry64).OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 620980")
            Dim ProgramPath As String = regVersion64.GetValue("InstallLocation")
        TextBox_Beatsaber_Path.Text = ProgramPath

        load_data_folder(TextBox_Beatsaber_Path.Text & "\Beat Saber_Data\CustomLevels")
        get_infos_song()
        get_infos_saber()
        get_infos_favorites()
        ListBox_Protocol.Items.Add(DateTime.Now & "     | " & "Ready...")

    End Sub

    Dim TotalSize As Long = 0
    Public Function GetDirSize(RootFolder As String) As Long
        Try
            Dim FolderInfo = New IO.DirectoryInfo(RootFolder)
            For Each File In FolderInfo.GetFiles : TotalSize += File.Length
            Next
            For Each SubFolderInfo In FolderInfo.GetDirectories : GetDirSize(SubFolderInfo.FullName)
            Next
            Return TotalSize
        Catch e As Exception
            Return "1"
        End Try
    End Function

    Public Sub get_infos_song()

        'get the foldersize
        ListBox_Protocol.Items.Add(DateTime.Now & "     | " & "Getting Songfoldersize...")
        TotalSize = 0 'Reset the counter
        Dim TheSize_Beatsaber As Long = GetDirSize(TextBox_Beatsaber_Path.Text & "\Beat Saber_Data\CustomLevels")
        If TheSize_Beatsaber > 1073741824 Then
            Label_Song_size.Text = FormatNumber(TheSize_Beatsaber / 1024 / 1024 / 1024, 1) & " Gb"
        Else
            Label_Song_size.Text = FormatNumber(TheSize_Beatsaber / 1024 / 1024, 1) & " Mb"
        End If
        If Not TextBox_Beatsaber_Path.Text = Nothing Then
            Dim counter1 As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
            counter1 = My.Computer.FileSystem.GetDirectories(TextBox_Beatsaber_Path.Text & "\Beat Saber_Data\CustomLevels")
            Label_Songs_songs.Text = CStr(counter1.Count)
        End If


        TotalSize = 0 'Reset the counter
        ListBox_Protocol.Items.Add(DateTime.Now & "     | " & "Getting Backupfoldersize...")
        Dim TheSize_Backup As Long = GetDirSize(TextBox_BackupFolder.Text & "\CustomLevels")
        If TheSize_Backup > 1073741824 Then
            Label_Backup_size.Text = FormatNumber(TheSize_Backup / 1024 / 1024 / 1024, 1) & " Gb"
        Else
            Label_Backup_size.Text = FormatNumber(TheSize_Backup / 1024 / 1024, 1) & " Mb"
        End If

        If Not TextBox_BackupFolder.Text = Nothing Then
            If Directory.Exists(TextBox_BackupFolder.Text & "\CustomLevels") Then
                Dim counter As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
                counter = My.Computer.FileSystem.GetDirectories(TextBox_BackupFolder.Text & "\CustomLevels")
                Label_Backup_songs.Text = CStr(counter.Count)
            End If

        End If


    End Sub


    Public Sub get_infos_saber()
        'get the foldersize
        ListBox_Protocol.Items.Add(DateTime.Now & "     | " & "Getting Saberfoldersize...")
        TotalSize = 0 'Reset the counter
        Dim TheSize_Beatsaber As Long = GetDirSize(TextBox_Beatsaber_Path.Text & "\CustomSabers")
        If TheSize_Beatsaber > 1073741824 Then
            Label_size_saber.Text = FormatNumber(TheSize_Beatsaber / 1024 / 1024 / 1024, 1) & " Gb"
        Else
            Label_size_saber.Text = FormatNumber(TheSize_Beatsaber / 1024 / 1024, 1) & " Mb"
        End If
        If Not TextBox_Beatsaber_Path.Text = Nothing Then
            Dim di As New IO.DirectoryInfo(TextBox_Beatsaber_Path.Text & "\CustomSabers")
            Dim diar1 = di.GetFiles.Where(Function(fi) fi.Extension = ".saber").ToArray
            Label_Sabers.Text = diar1.Count
        End If


        TotalSize = 0 'Reset the counter
        ListBox_Protocol.Items.Add(DateTime.Now & "     | " & "Getting Saberbackupfoldersize...")
        Dim TheSize_Backup As Long = GetDirSize(TextBox_BackupFolder.Text & "\CustomSabers")
        If TheSize_Backup > 1073741824 Then
            Label_size_saber_backup.Text = FormatNumber(TheSize_Backup / 1024 / 1024 / 1024, 1) & " Gb"
        Else
            Label_size_saber_backup.Text = FormatNumber(TheSize_Backup / 1024 / 1024, 1) & " Mb"
        End If

        If Not TextBox_BackupFolder.Text = Nothing Then
            If Directory.Exists(TextBox_BackupFolder.Text & "\CustomSabers") Then
                Dim di As New IO.DirectoryInfo(TextBox_BackupFolder.Text & "\CustomSabers")
                Dim diar1 = di.GetFiles.Where(Function(fi) fi.Extension = ".saber").ToArray
                Label_Sabers_Backup.Text = diar1.Count
            End If

        End If

    End Sub


    Public Sub get_infos_favorites()
        'Fill listview with images and folders
        Try
            'set the properties of the listview


            If Not IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\AppData\LocalLow\Hyperbolic Magnetism\Beat Saber\PlayerData.dat") Then
                ListBox_Protocol.Items.Add(DateTime.Now & "     | " & "Cound not find PlayerData.dat, pleace place it in:")
                ListBox_Protocol.Items.Add(DateTime.Now & "     | " & Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\AppData\LocalLow\Hyperbolic Magnetism\Beat Saber\PlayerData.dat")
                Exit Sub
            End If
            If Not IO.File.Exists(TextBox_Beatsaber_Path.Text & "\UserData\SongCore\SongHashData.dat") Then
                ListBox_Protocol.Items.Add(DateTime.Now & "     | " & "Cound not find SongHashData.dat, pleace place it in:")
                ListBox_Protocol.Items.Add(DateTime.Now & "     | " & TextBox_Beatsaber_Path.Text & "\UserData\SongCore\SongHashData.dat")
                ListBox_Protocol.Items.Add(DateTime.Now & "     | " & "You need the Plugin ""SongCore"" for that. Install it via ModAssistent.exe")
                Exit Sub
            End If


            Dim playerData As String = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\AppData\LocalLow\Hyperbolic Magnetism\Beat Saber\PlayerData.dat")
            Dim songHashData As String = File.ReadAllText(TextBox_Beatsaber_Path.Text & "\UserData\SongCore\SongHashData.dat")
            Dim favorites As List(Of String) = BeatSaber_CustomLevelCleanup.BeatSaberDataParser.GetFavoriteLevelsFromPlayerDataFile(playerData)
            Dim customLevels As List(Of BeatSaber_CustomLevelCleanup.CustomLevel) = BeatSaber_CustomLevelCleanup.BeatSaberDataParser.GetCustomLevelsFromSongHashFile(songHashData)

            TotalSize = 0
            Dim favSize As Long = 0
            Dim favCount As Integer = 0

            '   FillListview(favorites, customLevels)

            For Each c As BeatSaber_CustomLevelCleanup.CustomLevel In customLevels

                For Each s As String In favorites

                    If s.StartsWith("custom_level_") Then

                        If s = "custom_level_" & c.SongHash Then
                            c.IsFavorite = True
                            favCount = favCount + 1
                            favSize = +GetDirSize(c.Directory)

                            Exit For
                        End If
                    End If
                Next

                If c.Directory.Contains("CustomWIPLevels") Then
                    favCount = +1

                    favSize = favSize + GetDirSize(c.Directory)

                End If
            Next

            If favSize > 1073741824 Then
                Label_favorite_size.Text = FormatNumber(favSize / 1024 / 1024 / 1024, 1) & " Gb"
            Else
                Label_favorite_size.Text = FormatNumber(favSize / 1024 / 1024, 1) & " Mb"
            End If


            Label_favorites.Text = favCount
            TotalSize = 0
        Catch ex As Exception
            ''catching error
            MessageBox.Show("error : " + ex.Message)
        End Try




        TotalSize = 0 'Reset the counter
        ListBox_Protocol.Items.Add(DateTime.Now & "     | " & "Getting Backupfoldersize...")
        Dim TheSize_Backup As Long = GetDirSize(TextBox_BackupFolder.Text & "\CustomFavorites")
        If TheSize_Backup > 1073741824 Then
            Label_favorite_backup_size.Text = FormatNumber(TheSize_Backup / 1024 / 1024 / 1024, 1) & " Gb"
        Else
            Label_favorite_backup_size.Text = FormatNumber(TheSize_Backup / 1024 / 1024, 1) & " Mb"
        End If

        If Not TextBox_BackupFolder.Text = Nothing Then
            If Directory.Exists(TextBox_BackupFolder.Text & "\CustomFavorites") Then
                Dim counter As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
                counter = My.Computer.FileSystem.GetDirectories(TextBox_BackupFolder.Text & "\CustomFavorites")
                Label_favorite_backup_favorites.Text = CStr(counter.Count)
            End If

        End If

    End Sub




    Public Sub CopyFolder(ByVal sSrcPath As String, ByVal sDestPath As String, Optional ByVal bSubFolder As Boolean = True, Optional ByVal bOverWrite As Boolean = True)

        ' Falls Zielordner nicht existiert, jetzt erstellen
        If Not System.IO.Directory.Exists(sDestPath) Then
            System.IO.Directory.CreateDirectory(sDestPath)
        End If

        ' zunächst alle Dateien des Quell-Ordners ermitteln
        ' und kopieren
        Dim sFiles() As String = System.IO.Directory.GetFiles(sSrcPath)
        Dim sFile As String
        For i As Integer = 0 To sFiles.Length - 1
            ' Falls Datei im Zielordner bereits existiert, nur 
            ' kopieren, wenn Parameter "bOverWrite" auf True 
            ' festgelegt ist
            sFile = sFiles(i).Substring(sFiles(i).LastIndexOf("\") + 1)
            If bOverWrite Or Not System.IO.File.Exists(sDestPath & "\" & sFile) Then
                System.IO.File.Copy(sFiles(i), sDestPath & "\" & sFile, True)
            End If
        Next i

        If bSubFolder Then
            ' jetzt alle Unterordner ermitteln und die CopyFolder-Funktion
            ' rekursiv aufrufen
            Dim sDirs() As String = System.IO.Directory.GetDirectories(sSrcPath)
            Dim sDir As String
            For i As Integer = 0 To sDirs.Length - 1
                If sDirs(i) <> sDestPath Then
                    sDir = sDirs(i).Substring(sDirs(i).LastIndexOf("\") + 1)
                    CopyFolder(sDirs(i), sDestPath & "\" & sDir, True, bOverWrite)
                End If
            Next i
        End If
    End Sub



    Dim lstviewItem As ListViewItem
    Dim lstviewItemImageList As ImageList = New ImageList()


    Private Sub load_data_folder(path As String)

        'Fill listview with images and folders
        Try
            'set the properties of the listview
            ListView_songs.View = View.Details
            ListView_songs.Columns.Add("Installed Songs")
            ListView_songs.Columns(0).Width = 500



            'display an array values in the listview
            For Each folder In IO.Directory.GetDirectories(path)
                lstviewItem = New ListViewItem(folder.Replace(path & "\", ""))
                lstviewItemImageList.ImageSize = New Size(50, 50)
                ListView_songs.SmallImageList = lstviewItemImageList

                Dim di As New IO.DirectoryInfo(folder)
                Dim diar1 = di.GetFiles.Where(Function(fi) fi.Extension = ".jpg" OrElse fi.Extension = ".png" OrElse fi.Extension = ".gif" OrElse fi.Extension = ".jpeg").ToArray
                Try
                    lstviewItem.ImageIndex = lstviewItemImageList.Images.Add(Image.FromFile(diar1(0).FullName.ToString), Color.Transparent)
                Catch ex As Exception

                End Try

                ListView_songs.Items.Add(lstviewItem)

            Next

        Catch ex As Exception
            'Ä  catching error
            MessageBox.Show("error : " + ex.Message)
        End Try
    End Sub


    Private Sub load_data_favorites()
        'Fill listview with images and folders
        Try
            'set the properties of the listview
            ListView_songs.View = View.Details
            ListView_songs.Columns.Add("Installed Songs")
            ListView_songs.Columns(0).Width = 500




            Dim playerData As String = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\AppData\LocalLow\Hyperbolic Magnetism\Beat Saber\PlayerData.dat")
            Dim songHashData As String = File.ReadAllText(TextBox_Beatsaber_Path.Text & "\UserData\SongCore\SongHashData.dat")
            Dim favorites As List(Of String) = BeatSaber_CustomLevelCleanup.BeatSaberDataParser.GetFavoriteLevelsFromPlayerDataFile(playerData)
            Dim customLevels As List(Of BeatSaber_CustomLevelCleanup.CustomLevel) = BeatSaber_CustomLevelCleanup.BeatSaberDataParser.GetCustomLevelsFromSongHashFile(songHashData)

            '   FillListview(favorites, customLevels)


            For Each c As BeatSaber_CustomLevelCleanup.CustomLevel In customLevels

                For Each s As String In favorites

                    If s.StartsWith("custom_level_") Then

                        If s = "custom_level_" & c.SongHash Then
                            c.IsFavorite = True


                            lstviewItem = New ListViewItem(c.TrimmedDirectory)
                            lstviewItemImageList.ImageSize = New Size(50, 50)
                            ListView_songs.SmallImageList = lstviewItemImageList

                            Dim di As New IO.DirectoryInfo(c.Directory)
                            Dim diar1 = di.GetFiles.Where(Function(fi) fi.Extension = ".jpg" OrElse fi.Extension = ".png" OrElse fi.Extension = ".gif" OrElse fi.Extension = ".jpeg").ToArray
                            Try
                                lstviewItem.ImageIndex = lstviewItemImageList.Images.Add(Image.FromFile(diar1(0).FullName.ToString), Color.Transparent)
                            Catch ex As Exception

                            End Try

                            ListView_songs.Items.Add(lstviewItem)


                            Exit For
                        End If
                    End If
                Next

                If c.Directory.Contains("CustomWIPLevels") Then

                    lstviewItem = New ListViewItem(c.TrimmedDirectory)
                    lstviewItemImageList.ImageSize = New Size(50, 50)
                    ListView_songs.SmallImageList = lstviewItemImageList

                    Dim di As New IO.DirectoryInfo(c.Directory)
                    Dim diar1 = di.GetFiles.Where(Function(fi) fi.Extension = ".jpg" OrElse fi.Extension = ".png" OrElse fi.Extension = ".gif" OrElse fi.Extension = ".jpeg").ToArray
                    Try
                        lstviewItem.ImageIndex = lstviewItemImageList.Images.Add(Image.FromFile(diar1(0).FullName.ToString), Color.Transparent)
                    Catch ex As Exception

                    End Try

                    ListView_songs.Items.Add(lstviewItem)

                End If
            Next



        Catch ex As Exception
            ''catching error
            MessageBox.Show("error : " + ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox_BackupFolder.TextChanged
        My.Settings.BackupPath = TextBox_BackupFolder.Text
        My.Settings.Save()


        TotalSize = 0 'Reset the counter
        ListBox_Protocol.Items.Add(DateTime.Now & "     | " & "Getting Backupfoldersize...")
        Dim TheSize_Backup As Long = GetDirSize(TextBox_BackupFolder.Text)
        If TheSize_Backup > 1073741824 Then
            Label_Backup_size.Text = FormatNumber(TheSize_Backup / 1024 / 1024 / 1024, 1) & " Gb"
        Else
            Label_Backup_size.Text = FormatNumber(TheSize_Backup / 1024 / 1024, 1) & " Mb"
        End If

        If Not TextBox_BackupFolder.Text = Nothing Then
            Dim counter As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
            counter = My.Computer.FileSystem.GetDirectories(TextBox_BackupFolder.Text)
            Label_Backup_songs.Text = CStr(counter.Count)
        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_Select_Backupfolder.Click
        FolderBrowserDialog_Main.SelectedPath = Environ("USERPROFILE") & "\Music\"
        FolderBrowserDialog_Main.Description = "Please select the mirror folder where you want to backup your songs to."
        If FolderBrowserDialog_Main.ShowDialog() = DialogResult.OK Then
            TextBox_BackupFolder.Text = FolderBrowserDialog_Main.SelectedPath
        End If
    End Sub




    Private Sub Button_Choose_Beatsaber_Click(sender As Object, e As EventArgs) Handles Button_Choose_Beatsaber.Click
        FolderBrowserDialog_Main.SelectedPath = "C:"
        FolderBrowserDialog_Main.Description = "Please select the BeatSaber installation Folder."
        If FolderBrowserDialog_Main.ShowDialog() = DialogResult.OK Then
            TextBox_Beatsaber_Path.Text = FolderBrowserDialog_Main.SelectedPath
        End If
    End Sub


    Private Sub TextBox_Beatsaber_Path_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Beatsaber_Path.TextChanged

        My.Settings.BeatSaber_Path = TextBox_Beatsaber_Path.Text
        My.Settings.Save()
    End Sub

    Private Sub Button_Backup_Click(sender As Object, e As EventArgs) Handles Button_Backup_song.Click

        If Not Directory.Exists(TextBox_BackupFolder.Text) Then
            Directory.CreateDirectory(TextBox_BackupFolder.Text)
        End If
        If Not Directory.Exists(TextBox_BackupFolder.Text & "\CustomLevels") Then
            Directory.CreateDirectory(TextBox_BackupFolder.Text & "\CustomLevels")
        End If

        If Not TextBox_Beatsaber_Path.Text = Nothing Then
            If Not TextBox_BackupFolder.Text = Nothing Then
                For Each folder In IO.Directory.GetDirectories(TextBox_Beatsaber_Path.Text & "\Beat Saber_Data\CustomLevels")
                    Dim directory As String = Path.GetFileName(folder)
                    ListBox_Protocol.Items.Add(DateTime.Now & "     | Copying " & directory & "...")
                    CopyFolder(folder, TextBox_BackupFolder.Text & "\CustomLevels\" & directory, True, True)
                    ListBox_Protocol.SelectedIndex = ListBox_Protocol.Items.Count - 1
                Next
                ListBox_Protocol.Items.Add(DateTime.Now & "     | Done")
                ListBox_Protocol.SelectedIndex = ListBox_Protocol.Items.Count - 1
            Else
                ListBox_Protocol.Items.Add(DateTime.Now & "     | Please set the Backupdirectory first.")
                ListBox_Protocol.SelectedIndex = ListBox_Protocol.Items.Count - 1
            End If
        Else
            ListBox_Protocol.Items.Add(DateTime.Now & "     | Please set the Beatsaber Songdirectory first.")
            ListBox_Protocol.SelectedIndex = ListBox_Protocol.Items.Count - 1
        End If

        get_infos_song()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button_Restore_song.Click
        If Not Directory.Exists(TextBox_BackupFolder.Text & "\CustomLevels") Then
            ListBox_Protocol.Items.Add(DateTime.Now & "     | No Backup found. If ther .IS. a backup, please move it into a folder called ""CustomLevels""")
            Exit Sub
        End If
        If Not TextBox_Beatsaber_Path.Text = Nothing Then
            If Not TextBox_BackupFolder.Text = Nothing Then
                For Each folder In IO.Directory.GetDirectories(TextBox_BackupFolder.Text & "\CustomLevels")
                    Dim directory As String = Path.GetFileName(folder)
                    ListBox_Protocol.Items.Add(DateTime.Now & "     | Copying " & directory & "...")
                    CopyFolder(folder, TextBox_Beatsaber_Path.Text & "\Beat Saber_Data\CustomLevels\" & directory, True, True)
                    ListBox_Protocol.SelectedIndex = ListBox_Protocol.Items.Count - 1
                Next
                ListBox_Protocol.Items.Add(DateTime.Now & "     | Done")
                ListBox_Protocol.SelectedIndex = ListBox_Protocol.Items.Count - 1
            Else
                ListBox_Protocol.Items.Add(DateTime.Now & "     | Please set the Backupdirectory first.")
                ListBox_Protocol.SelectedIndex = ListBox_Protocol.Items.Count - 1
            End If
        Else
            ListBox_Protocol.Items.Add(DateTime.Now & "     | Please set the Beatsaber Songdirectory first.")
            ListBox_Protocol.SelectedIndex = ListBox_Protocol.Items.Count - 1
        End If

        get_infos_song()


    End Sub

    Dim BS_running As Boolean = False
        Dim bs_closed_time As Integer = 0

        Private Sub TextBox_BackupFolder_DoubleClick(sender As Object, e As EventArgs) Handles TextBox_BackupFolder.DoubleClick
            If Not TextBox_BackupFolder.Text = Nothing Then
                Process.Start(TextBox_BackupFolder.Text)
            End If
        End Sub

        Private Sub TextBox_Beatsaber_Path_DoubleClick(sender As Object, e As EventArgs) Handles TextBox_Beatsaber_Path.DoubleClick
            If Not TextBox_Beatsaber_Path.Text = Nothing Then
            Process.Start(TextBox_Beatsaber_Path.Text)
        End If
        End Sub


    Private Sub VlcControl1_VlcLibDirectoryNeeded(sender As Object, e As Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs) Handles VlcControl_MusicPlayer.VlcLibDirectoryNeeded
            e.VlcLibDirectory = New IO.DirectoryInfo("VLC/")
        End Sub



        Private Sub VlcControl_MusicPlayer_Click(sender As Object, e As EventArgs) Handles VlcControl_MusicPlayer.Click
            If VlcControl_MusicPlayer.IsPlaying Then
                VlcControl_MusicPlayer.Pause()
            Else
                VlcControl_MusicPlayer.Play()
            End If
        End Sub

        Private Sub Timer_Media_Position_Tick(sender As Object, e As EventArgs) Handles Timer_Media_Position.Tick
            If Not CInt(Math.Round(VlcControl_MusicPlayer.Position * 100, 0)) = -100 Then
                ProgressBar2.Value = CInt(Math.Round(VlcControl_MusicPlayer.Position * 100, 0))
            End If
        End Sub

        Private Sub TrackBar_Position_MouseDown(sender As Object, e As MouseEventArgs)
            Timer_Media_Position.Enabled = False
        End Sub

        Private Sub TrackBar_Position_MouseUp(sender As Object, e As MouseEventArgs)
            Timer_Media_Position.Enabled = True
        End Sub


        Private Shared Sub ChangeProgress(bar As ProgressBar, e As MouseEventArgs)
            If e.Button = Windows.Forms.MouseButtons.Left Then
                Dim mousepos = Math.Min(Math.Max(e.X, 0), bar.ClientSize.Width)
                Dim value = CInt(bar.Minimum + (bar.Maximum - bar.Minimum) * mousepos / bar.ClientSize.Width)
                '' Disable animation, if possible
                If value > bar.Value And value < bar.Maximum Then
                    bar.Value = value + 1
                    bar.Value = value
                Else
                    bar.Value = value
                End If
            End If
        End Sub



        Private Sub ProgressBar2_MouseDown(sender As Object, e As MouseEventArgs)
            ChangeProgress(ProgressBar2, e)
            Timer_Media_Position.Enabled = False
        End Sub

        Private Sub ProgressBar2_MouseMove(sender As Object, e As MouseEventArgs)
            ChangeProgress(ProgressBar2, e)
        End Sub

        Private Sub ProgressBar2_MouseUp(sender As Object, e As MouseEventArgs)
            VlcControl_MusicPlayer.Position = ProgressBar2.Value / 100
            Timer_Media_Position.Enabled = True
        End Sub

        Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox_Search.TextChanged
            For Each item As ListViewItem In ListView_songs.Items
                If item.Text.ToLower.Contains(TextBox_Search.Text.ToLower) Then
                    item.Selected = True
                    item.EnsureVisible()
                    Exit For
                End If
            Next
        End Sub


        Private Sub ListView_songs_MouseUp(sender As Object, e As MouseEventArgs) Handles ListView_songs.MouseUp
            If e.Button = MouseButtons.Right Then
                If Not ListView_songs.SelectedItems.Count = 0 Then
                    ContextMenuStrip_Song_Right.Show(Cursor.Position)
                End If
            End If
            If e.Button = MouseButtons.Left Then
                'play song

                If Not ListView_songs.SelectedItems.Count = 0 Then

                    Dim files() As String
                files = Directory.GetFiles(TextBox_Beatsaber_Path.Text & "\Beat Saber_Data\CustomLevels" & "\" & ListView_songs.SelectedItems(0).Text, "*.egg", SearchOption.TopDirectoryOnly)

                Me.Text = "BeatSaber Backup    | Playing: " & ListView_songs.SelectedItems(0).Text
                    Dim f As Uri = New Uri(files(0))
                    VlcControl_MusicPlayer.Play(f)



                Dim di As New IO.DirectoryInfo(TextBox_Beatsaber_Path.Text & "\Beat Saber_Data\CustomLevels" & "\" & ListView_songs.SelectedItems(0).Text)
                Dim diar1 = di.GetFiles.Where(Function(fi) fi.Extension = ".jpg" OrElse fi.Extension = ".png" OrElse fi.Extension = ".gif" OrElse fi.Extension = ".jpeg").ToArray
                    VlcControl_MusicPlayer.BackgroundImage = Bitmap.FromFile(diar1(0).FullName.ToString)


                End If
            End If
        End Sub



    Private Sub RadioButton_Fav_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Fav.CheckedChanged
        If RadioButton_Fav.Checked = True Then
            ListView_songs.Clear()
            load_data_favorites()
        End If


    End Sub

    Private Sub RadioButton_All_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_All.CheckedChanged
        If RadioButton_All.Checked = True Then
            ListView_songs.Clear()
            If Not TextBox_Beatsaber_Path.Text = Nothing Then
                load_data_folder(TextBox_Beatsaber_Path.Text & "\Beat Saber_Data\CustomLevels")
            End If
        End If
    End Sub

    Private Sub DeleteFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteFileToolStripMenuItem.Click
        IO.Directory.Delete(TextBox_Beatsaber_Path.Text & "\Beat Saber_Data\CustomLevels\" & ListView_songs.SelectedItems(0).Text, True)
        ListView_songs.SelectedItems(0).Remove()
    End Sub

    Private Sub Button_backup_saber_Click(sender As Object, e As EventArgs) Handles Button_backup_saber.Click

        If Not Directory.Exists(TextBox_BackupFolder.Text) Then
            Directory.CreateDirectory(TextBox_BackupFolder.Text)
        End If
        If Not Directory.Exists(TextBox_BackupFolder.Text & "\CustomSabers") Then
            Directory.CreateDirectory(TextBox_BackupFolder.Text & "\CustomSabers")
        End If

        If Not TextBox_Beatsaber_Path.Text = Nothing Then
            If Not TextBox_BackupFolder.Text = Nothing Then
                For Each file In IO.Directory.GetFiles(TextBox_Beatsaber_Path.Text & "\CustomSabers")
                    Dim filename As String = Path.GetFileName(file)
                    ListBox_Protocol.Items.Add(DateTime.Now & "     | Copying " & filename & "...")
                    FileCopy(file, TextBox_BackupFolder.Text & "\CustomSabers\" & filename)
                    ListBox_Protocol.SelectedIndex = ListBox_Protocol.Items.Count - 1
                Next
                ListBox_Protocol.Items.Add(DateTime.Now & "     | Done")
                ListBox_Protocol.SelectedIndex = ListBox_Protocol.Items.Count - 1
            Else
                ListBox_Protocol.Items.Add(DateTime.Now & "     | Please set the Backupdirectory first.")
                ListBox_Protocol.SelectedIndex = ListBox_Protocol.Items.Count - 1
            End If
        Else
            ListBox_Protocol.Items.Add(DateTime.Now & "     | Please set the Beatsaber Songdirectory first.")
            ListBox_Protocol.SelectedIndex = ListBox_Protocol.Items.Count - 1
        End If

        get_infos_saber()
    End Sub

    Private Sub Button_restore_Saber_Click(sender As Object, e As EventArgs) Handles Button_restore_Saber.Click
        If Not Directory.Exists(TextBox_BackupFolder.Text & "\CustomSabers") Then
            ListBox_Protocol.Items.Add(DateTime.Now & "     | No Backup found. If ther .IS. a backup, please move it into a folder called ""CustomSabers""")
            Exit Sub
        End If
        If Not TextBox_Beatsaber_Path.Text = Nothing Then
            If Not TextBox_BackupFolder.Text = Nothing Then
                For Each file In IO.Directory.GetFiles(TextBox_BackupFolder.Text & "\CustomSabers")
                    Dim filename As String = Path.GetFileName(file)
                    ListBox_Protocol.Items.Add(DateTime.Now & "     | Copying " & filename & "...")
                    FileCopy(file, TextBox_Beatsaber_Path.Text & "\CustomSabers\" & filename)
                    ListBox_Protocol.SelectedIndex = ListBox_Protocol.Items.Count - 1
                Next
                ListBox_Protocol.Items.Add(DateTime.Now & "     | Done")
                ListBox_Protocol.SelectedIndex = ListBox_Protocol.Items.Count - 1
            Else
                ListBox_Protocol.Items.Add(DateTime.Now & "     | Please set the Backupdirectory first.")
                ListBox_Protocol.SelectedIndex = ListBox_Protocol.Items.Count - 1
            End If
        Else
            ListBox_Protocol.Items.Add(DateTime.Now & "     | Please set the Beatsaber Songdirectory first.")
            ListBox_Protocol.SelectedIndex = ListBox_Protocol.Items.Count - 1
        End If

        get_infos_saber()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button_Backup_Fav.Click
        'Fill listview with images and folders
        Try
            'set the properties of the listview
            If Not IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\AppData\LocalLow\Hyperbolic Magnetism\Beat Saber\PlayerData.dat") Then
                ListBox_Protocol.Items.Add(DateTime.Now & "     | " & "Cound not find PlayerData.dat, pleace place it in:")
                ListBox_Protocol.Items.Add(DateTime.Now & "     | " & Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\AppData\LocalLow\Hyperbolic Magnetism\Beat Saber\PlayerData.dat")
                Exit Sub
            End If
            If Not IO.File.Exists(TextBox_Beatsaber_Path.Text & "\UserData\SongCore\SongHashData.dat") Then
                ListBox_Protocol.Items.Add(DateTime.Now & "     | " & "Cound not find SongHashData.dat, pleace place it in:")
                ListBox_Protocol.Items.Add(DateTime.Now & "     | " & TextBox_Beatsaber_Path.Text & "\UserData\SongCore\SongHashData.dat")
                ListBox_Protocol.Items.Add(DateTime.Now & "     | " & "You need the Plugin ""SongCore"" for that. Install it via ModAssistent.exe")
                Exit Sub
            End If

            Dim playerData As String = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\AppData\LocalLow\Hyperbolic Magnetism\Beat Saber\PlayerData.dat")
            Dim songHashData As String = File.ReadAllText(TextBox_Beatsaber_Path.Text & "\UserData\SongCore\SongHashData.dat")
            Dim favorites As List(Of String) = BeatSaber_CustomLevelCleanup.BeatSaberDataParser.GetFavoriteLevelsFromPlayerDataFile(playerData)
            Dim customLevels As List(Of BeatSaber_CustomLevelCleanup.CustomLevel) = BeatSaber_CustomLevelCleanup.BeatSaberDataParser.GetCustomLevelsFromSongHashFile(songHashData)

            '   FillListview(favorites, customLevels)
            For Each c As BeatSaber_CustomLevelCleanup.CustomLevel In customLevels

                For Each s As String In favorites

                    If s.StartsWith("custom_level_") Then

                        If s = "custom_level_" & c.SongHash Then

                            If Not Directory.Exists(TextBox_BackupFolder.Text) Then
                                Directory.CreateDirectory(TextBox_BackupFolder.Text)
                            End If

                            If Not Directory.Exists(TextBox_BackupFolder.Text & "\CustomFavorites") Then
                                Directory.CreateDirectory(TextBox_BackupFolder.Text & "\CustomFavorites")
                            End If

                            If Not TextBox_Beatsaber_Path.Text = Nothing Then
                                If Not TextBox_BackupFolder.Text = Nothing Then

                                    ListBox_Protocol.Items.Add(DateTime.Now & "     | Copying " & c.TrimmedDirectory & "...")
                                    CopyFolder(c.Directory, TextBox_BackupFolder.Text & "\CustomFavorites\" & c.TrimmedDirectory, True, True)
                                    ListBox_Protocol.SelectedIndex = ListBox_Protocol.Items.Count - 1
                                Else
                                    ListBox_Protocol.Items.Add(DateTime.Now & "     | Please set the Backupdirectory first.")
                                    ListBox_Protocol.SelectedIndex = ListBox_Protocol.Items.Count - 1
                                End If
                            Else
                                ListBox_Protocol.Items.Add(DateTime.Now & "     | Please set the Beatsaber Songdirectory first.")
                                ListBox_Protocol.SelectedIndex = ListBox_Protocol.Items.Count - 1
                            End If

                            Exit For
                        End If
                    End If
                Next

                If c.Directory.Contains("CustomWIPLevels") Then
                    If Not Directory.Exists(TextBox_BackupFolder.Text) Then
                        Directory.CreateDirectory(TextBox_BackupFolder.Text)
                    End If

                    If Not Directory.Exists(TextBox_BackupFolder.Text & "\CustomFavorites") Then
                        Directory.CreateDirectory(TextBox_BackupFolder.Text & "\CustomFavorites")
                    End If

                    If Not TextBox_Beatsaber_Path.Text = Nothing Then
                        If Not TextBox_BackupFolder.Text = Nothing Then

                            ListBox_Protocol.Items.Add(DateTime.Now & "     | Copying " & c.TrimmedDirectory & "...")
                            CopyFolder(c.Directory, TextBox_BackupFolder.Text & "\CustomFavorites\" & c.TrimmedDirectory, True, True)
                            ListBox_Protocol.SelectedIndex = ListBox_Protocol.Items.Count - 1

                        Else
                            ListBox_Protocol.Items.Add(DateTime.Now & "     | Please set the Backupdirectory first.")
                            ListBox_Protocol.SelectedIndex = ListBox_Protocol.Items.Count - 1
                        End If
                    Else
                        ListBox_Protocol.Items.Add(DateTime.Now & "     | Please set the Beatsaber Songdirectory first.")
                        ListBox_Protocol.SelectedIndex = ListBox_Protocol.Items.Count - 1
                    End If


                End If
            Next

            get_infos_favorites()
        Catch ex As Exception
            ''catching error
            MessageBox.Show("error : " + ex.Message)
        End Try
    End Sub
End Class



Public Class MyProgressBar
    Inherits ProgressBar
    Public Sub New()
        'Damit du das Control zeichnen kannst und nicht das Betriebsystem
        SetStyle(ControlStyles.UserPaint, True)
    End Sub
    Private _ProgressBarColor As Color = Color.Purple

    Public Property ProgressBarColor() As Color
        Get
            Return _ProgressBarColor
        End Get
        Set(ByVal value As Color)
            _ProgressBarColor = value
            'die Farbe hat sich geändert, das Control muss sich neuzeichnen:
            Me.Invalidate()
        End Set
    End Property
    'Ist eigentlcih genau das gleiche wie das paint-event. Trotzdem sollte man Control-Intern das hier verwenden.
    Protected Overrides Sub OnPaint(e As System.Windows.Forms.PaintEventArgs)

        Dim wertebereich As Integer = Maximum - Minimum '=> im normallfall von 0 bis 100, also einen Wertebereich von 100.
        Dim length As Integer = CInt((Value / wertebereich) * Me.Size.Width) 'Berechnet die länge des zu zeichnenden balkens
        With e.Graphics
            .Clear(BackColor)
            .FillRectangle(New SolidBrush(ProgressBarColor), 0, 0, length, Height)
            .DrawRectangle(New Pen(ProgressBarColor), 0, 0, Width - 1, Height - 1)
        End With
    End Sub

End Class