<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Main
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Main))
        Me.TextBox_Beatsaber_Path = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView_songs = New System.Windows.Forms.ListView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_BackupFolder = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog_Main = New System.Windows.Forms.FolderBrowserDialog()
        Me.Button_Select_Backupfolder = New System.Windows.Forms.Button()
        Me.ListBox_Protocol = New System.Windows.Forms.ListBox()
        Me.Button_Choose_Beatsaber = New System.Windows.Forms.Button()
        Me.Button_Backup_song = New System.Windows.Forms.Button()
        Me.Button_Restore_song = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label_Backup_size = New System.Windows.Forms.Label()
        Me.Label_Song_size = New System.Windows.Forms.Label()
        Me.VlcControl_MusicPlayer = New Vlc.DotNet.Forms.VlcControl()
        Me.Timer_Media_Position = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip_Song_Right = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConvertToMp3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox_Search = New System.Windows.Forms.TextBox()
        Me.RadioButton_All = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Fav = New System.Windows.Forms.RadioButton()
        Me.GroupBox_Backup = New System.Windows.Forms.GroupBox()
        Me.Label_Backup_songs = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox_Songs = New System.Windows.Forms.GroupBox()
        Me.Label_Songs_songs = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label_Sabers = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label_size_saber = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label_Sabers_Backup = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label_size_saber_backup = New System.Windows.Forms.Label()
        Me.Button_restore_Saber = New System.Windows.Forms.Button()
        Me.Button_backup_saber = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label_favorites = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label_favorite_size = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label_favorite_backup_favorites = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label_favorite_backup_size = New System.Windows.Forms.Label()
        Me.Button_Restore_Fav = New System.Windows.Forms.Button()
        Me.Button_Backup_Fav = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.VlcControl_MusicPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip_Song_Right.SuspendLayout()
        Me.GroupBox_Backup.SuspendLayout()
        Me.GroupBox_Songs.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox_Beatsaber_Path
        '
        Me.TextBox_Beatsaber_Path.Location = New System.Drawing.Point(892, 8)
        Me.TextBox_Beatsaber_Path.Name = "TextBox_Beatsaber_Path"
        Me.TextBox_Beatsaber_Path.Size = New System.Drawing.Size(275, 20)
        Me.TextBox_Beatsaber_Path.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(757, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BeatSaber Songdirectory:"
        '
        'ListView_songs
        '
        Me.ListView_songs.HideSelection = False
        Me.ListView_songs.Location = New System.Drawing.Point(12, 60)
        Me.ListView_songs.MultiSelect = False
        Me.ListView_songs.Name = "ListView_songs"
        Me.ListView_songs.Size = New System.Drawing.Size(378, 659)
        Me.ListView_songs.TabIndex = 3
        Me.ListView_songs.UseCompatibleStateImageBehavior = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(757, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Backup Directory:"
        '
        'TextBox_BackupFolder
        '
        Me.TextBox_BackupFolder.Location = New System.Drawing.Point(892, 34)
        Me.TextBox_BackupFolder.Name = "TextBox_BackupFolder"
        Me.TextBox_BackupFolder.Size = New System.Drawing.Size(275, 20)
        Me.TextBox_BackupFolder.TabIndex = 2
        '
        'Button_Select_Backupfolder
        '
        Me.Button_Select_Backupfolder.Location = New System.Drawing.Point(1173, 32)
        Me.Button_Select_Backupfolder.Name = "Button_Select_Backupfolder"
        Me.Button_Select_Backupfolder.Size = New System.Drawing.Size(65, 23)
        Me.Button_Select_Backupfolder.TabIndex = 5
        Me.Button_Select_Backupfolder.Text = "Select"
        Me.Button_Select_Backupfolder.UseVisualStyleBackColor = True
        '
        'ListBox_Protocol
        '
        Me.ListBox_Protocol.FormattingEnabled = True
        Me.ListBox_Protocol.Location = New System.Drawing.Point(400, 585)
        Me.ListBox_Protocol.Name = "ListBox_Protocol"
        Me.ListBox_Protocol.Size = New System.Drawing.Size(853, 134)
        Me.ListBox_Protocol.TabIndex = 6
        '
        'Button_Choose_Beatsaber
        '
        Me.Button_Choose_Beatsaber.Location = New System.Drawing.Point(1173, 6)
        Me.Button_Choose_Beatsaber.Name = "Button_Choose_Beatsaber"
        Me.Button_Choose_Beatsaber.Size = New System.Drawing.Size(65, 23)
        Me.Button_Choose_Beatsaber.TabIndex = 9
        Me.Button_Choose_Beatsaber.Text = "Select"
        Me.Button_Choose_Beatsaber.UseVisualStyleBackColor = True
        '
        'Button_Backup_song
        '
        Me.Button_Backup_song.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Backup_song.Location = New System.Drawing.Point(908, 64)
        Me.Button_Backup_song.Name = "Button_Backup_song"
        Me.Button_Backup_song.Size = New System.Drawing.Size(185, 34)
        Me.Button_Backup_song.TabIndex = 11
        Me.Button_Backup_song.Text = "Backup  >>>"
        Me.Button_Backup_song.UseVisualStyleBackColor = True
        '
        'Button_Restore_song
        '
        Me.Button_Restore_song.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Restore_song.Location = New System.Drawing.Point(908, 112)
        Me.Button_Restore_song.Name = "Button_Restore_song"
        Me.Button_Restore_song.Size = New System.Drawing.Size(185, 34)
        Me.Button_Restore_song.TabIndex = 12
        Me.Button_Restore_song.Text = "<<< Restore"
        Me.Button_Restore_song.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Size:"
        '
        'Label_Backup_size
        '
        Me.Label_Backup_size.AutoSize = True
        Me.Label_Backup_size.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Backup_size.Location = New System.Drawing.Point(70, 36)
        Me.Label_Backup_size.Name = "Label_Backup_size"
        Me.Label_Backup_size.Size = New System.Drawing.Size(10, 13)
        Me.Label_Backup_size.TabIndex = 15
        Me.Label_Backup_size.Text = "-"
        '
        'Label_Song_size
        '
        Me.Label_Song_size.AutoSize = True
        Me.Label_Song_size.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Song_size.Location = New System.Drawing.Point(70, 36)
        Me.Label_Song_size.Name = "Label_Song_size"
        Me.Label_Song_size.Size = New System.Drawing.Size(10, 13)
        Me.Label_Song_size.TabIndex = 16
        Me.Label_Song_size.Text = "-"
        '
        'VlcControl_MusicPlayer
        '
        Me.VlcControl_MusicPlayer.BackColor = System.Drawing.Color.Black
        Me.VlcControl_MusicPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.VlcControl_MusicPlayer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.VlcControl_MusicPlayer.Location = New System.Drawing.Point(400, 11)
        Me.VlcControl_MusicPlayer.Name = "VlcControl_MusicPlayer"
        Me.VlcControl_MusicPlayer.Size = New System.Drawing.Size(339, 316)
        Me.VlcControl_MusicPlayer.Spu = -1
        Me.VlcControl_MusicPlayer.TabIndex = 17
        Me.VlcControl_MusicPlayer.Text = "VlcControl_MusicPlayer"
        Me.VlcControl_MusicPlayer.VlcLibDirectory = Nothing
        Me.VlcControl_MusicPlayer.VlcMediaplayerOptions = Nothing
        '
        'Timer_Media_Position
        '
        Me.Timer_Media_Position.Enabled = True
        Me.Timer_Media_Position.Interval = 500
        '
        'ContextMenuStrip_Song_Right
        '
        Me.ContextMenuStrip_Song_Right.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteFileToolStripMenuItem, Me.ConvertToMp3ToolStripMenuItem})
        Me.ContextMenuStrip_Song_Right.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip_Song_Right.Size = New System.Drawing.Size(158, 48)
        '
        'DeleteFileToolStripMenuItem
        '
        Me.DeleteFileToolStripMenuItem.Name = "DeleteFileToolStripMenuItem"
        Me.DeleteFileToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.DeleteFileToolStripMenuItem.Text = "Delete File"
        '
        'ConvertToMp3ToolStripMenuItem
        '
        Me.ConvertToMp3ToolStripMenuItem.Name = "ConvertToMp3ToolStripMenuItem"
        Me.ConvertToMp3ToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ConvertToMp3ToolStripMenuItem.Text = "Convert to mp3"
        '
        'TextBox_Search
        '
        Me.TextBox_Search.Location = New System.Drawing.Point(12, 30)
        Me.TextBox_Search.Name = "TextBox_Search"
        Me.TextBox_Search.Size = New System.Drawing.Size(378, 20)
        Me.TextBox_Search.TabIndex = 19
        Me.TextBox_Search.Text = "Search"
        '
        'RadioButton_All
        '
        Me.RadioButton_All.AutoSize = True
        Me.RadioButton_All.Checked = True
        Me.RadioButton_All.Location = New System.Drawing.Point(12, 6)
        Me.RadioButton_All.Name = "RadioButton_All"
        Me.RadioButton_All.Size = New System.Drawing.Size(69, 17)
        Me.RadioButton_All.TabIndex = 22
        Me.RadioButton_All.TabStop = True
        Me.RadioButton_All.Text = "All Songs"
        Me.RadioButton_All.UseVisualStyleBackColor = True
        '
        'RadioButton_Fav
        '
        Me.RadioButton_Fav.AutoSize = True
        Me.RadioButton_Fav.Location = New System.Drawing.Point(87, 6)
        Me.RadioButton_Fav.Name = "RadioButton_Fav"
        Me.RadioButton_Fav.Size = New System.Drawing.Size(68, 17)
        Me.RadioButton_Fav.TabIndex = 23
        Me.RadioButton_Fav.Text = "Favorites"
        Me.RadioButton_Fav.UseVisualStyleBackColor = True
        '
        'GroupBox_Backup
        '
        Me.GroupBox_Backup.Controls.Add(Me.Label_Backup_songs)
        Me.GroupBox_Backup.Controls.Add(Me.Label4)
        Me.GroupBox_Backup.Controls.Add(Me.Label7)
        Me.GroupBox_Backup.Controls.Add(Me.Label_Backup_size)
        Me.GroupBox_Backup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Backup.Location = New System.Drawing.Point(1113, 60)
        Me.GroupBox_Backup.Name = "GroupBox_Backup"
        Me.GroupBox_Backup.Size = New System.Drawing.Size(125, 88)
        Me.GroupBox_Backup.TabIndex = 24
        Me.GroupBox_Backup.TabStop = False
        Me.GroupBox_Backup.Text = "Backup"
        '
        'Label_Backup_songs
        '
        Me.Label_Backup_songs.AutoSize = True
        Me.Label_Backup_songs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Backup_songs.Location = New System.Drawing.Point(70, 61)
        Me.Label_Backup_songs.Name = "Label_Backup_songs"
        Me.Label_Backup_songs.Size = New System.Drawing.Size(10, 13)
        Me.Label_Backup_songs.TabIndex = 20
        Me.Label_Backup_songs.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Size:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Songs:"
        '
        'GroupBox_Songs
        '
        Me.GroupBox_Songs.Controls.Add(Me.Label_Songs_songs)
        Me.GroupBox_Songs.Controls.Add(Me.Label3)
        Me.GroupBox_Songs.Controls.Add(Me.Label5)
        Me.GroupBox_Songs.Controls.Add(Me.Label_Song_size)
        Me.GroupBox_Songs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Songs.Location = New System.Drawing.Point(760, 60)
        Me.GroupBox_Songs.Name = "GroupBox_Songs"
        Me.GroupBox_Songs.Size = New System.Drawing.Size(125, 88)
        Me.GroupBox_Songs.TabIndex = 25
        Me.GroupBox_Songs.TabStop = False
        Me.GroupBox_Songs.Text = "Songs"
        '
        'Label_Songs_songs
        '
        Me.Label_Songs_songs.AutoSize = True
        Me.Label_Songs_songs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Songs_songs.Location = New System.Drawing.Point(70, 61)
        Me.Label_Songs_songs.Name = "Label_Songs_songs"
        Me.Label_Songs_songs.Size = New System.Drawing.Size(10, 13)
        Me.Label_Songs_songs.TabIndex = 18
        Me.Label_Songs_songs.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Songs:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label_Sabers)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label_size_saber)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(760, 157)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(125, 88)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sabers"
        '
        'Label_Sabers
        '
        Me.Label_Sabers.AutoSize = True
        Me.Label_Sabers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Sabers.Location = New System.Drawing.Point(70, 61)
        Me.Label_Sabers.Name = "Label_Sabers"
        Me.Label_Sabers.Size = New System.Drawing.Size(10, 13)
        Me.Label_Sabers.TabIndex = 18
        Me.Label_Sabers.Text = "-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Sabers:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Size:"
        '
        'Label_size_saber
        '
        Me.Label_size_saber.AutoSize = True
        Me.Label_size_saber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_size_saber.Location = New System.Drawing.Point(70, 36)
        Me.Label_size_saber.Name = "Label_size_saber"
        Me.Label_size_saber.Size = New System.Drawing.Size(10, 13)
        Me.Label_size_saber.TabIndex = 16
        Me.Label_size_saber.Text = "-"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label_Sabers_Backup)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label_size_saber_backup)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(1113, 157)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(125, 88)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Backup"
        '
        'Label_Sabers_Backup
        '
        Me.Label_Sabers_Backup.AutoSize = True
        Me.Label_Sabers_Backup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Sabers_Backup.Location = New System.Drawing.Point(70, 61)
        Me.Label_Sabers_Backup.Name = "Label_Sabers_Backup"
        Me.Label_Sabers_Backup.Size = New System.Drawing.Size(10, 13)
        Me.Label_Sabers_Backup.TabIndex = 20
        Me.Label_Sabers_Backup.Text = "-"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 36)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Size:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(15, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Sabers:"
        '
        'Label_size_saber_backup
        '
        Me.Label_size_saber_backup.AutoSize = True
        Me.Label_size_saber_backup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_size_saber_backup.Location = New System.Drawing.Point(70, 36)
        Me.Label_size_saber_backup.Name = "Label_size_saber_backup"
        Me.Label_size_saber_backup.Size = New System.Drawing.Size(10, 13)
        Me.Label_size_saber_backup.TabIndex = 15
        Me.Label_size_saber_backup.Text = "-"
        '
        'Button_restore_Saber
        '
        Me.Button_restore_Saber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_restore_Saber.Location = New System.Drawing.Point(908, 211)
        Me.Button_restore_Saber.Name = "Button_restore_Saber"
        Me.Button_restore_Saber.Size = New System.Drawing.Size(185, 34)
        Me.Button_restore_Saber.TabIndex = 28
        Me.Button_restore_Saber.Text = "<<< Restore Sabers"
        Me.Button_restore_Saber.UseVisualStyleBackColor = True
        '
        'Button_backup_saber
        '
        Me.Button_backup_saber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_backup_saber.Location = New System.Drawing.Point(908, 163)
        Me.Button_backup_saber.Name = "Button_backup_saber"
        Me.Button_backup_saber.Size = New System.Drawing.Size(185, 34)
        Me.Button_backup_saber.TabIndex = 27
        Me.Button_backup_saber.Text = "Backup Sabers >>>"
        Me.Button_backup_saber.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label_favorites)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label_favorite_size)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(760, 256)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(125, 88)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Favorites"
        '
        'Label_favorites
        '
        Me.Label_favorites.AutoSize = True
        Me.Label_favorites.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_favorites.Location = New System.Drawing.Point(70, 61)
        Me.Label_favorites.Name = "Label_favorites"
        Me.Label_favorites.Size = New System.Drawing.Size(10, 13)
        Me.Label_favorites.TabIndex = 18
        Me.Label_favorites.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Favorites:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Size:"
        '
        'Label_favorite_size
        '
        Me.Label_favorite_size.AutoSize = True
        Me.Label_favorite_size.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_favorite_size.Location = New System.Drawing.Point(70, 36)
        Me.Label_favorite_size.Name = "Label_favorite_size"
        Me.Label_favorite_size.Size = New System.Drawing.Size(10, 13)
        Me.Label_favorite_size.TabIndex = 16
        Me.Label_favorite_size.Text = "-"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label_favorite_backup_favorites)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label_favorite_backup_size)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(1113, 256)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(125, 88)
        Me.GroupBox4.TabIndex = 26
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Backup"
        '
        'Label_favorite_backup_favorites
        '
        Me.Label_favorite_backup_favorites.AutoSize = True
        Me.Label_favorite_backup_favorites.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_favorite_backup_favorites.Location = New System.Drawing.Point(70, 61)
        Me.Label_favorite_backup_favorites.Name = "Label_favorite_backup_favorites"
        Me.Label_favorite_backup_favorites.Size = New System.Drawing.Size(10, 13)
        Me.Label_favorite_backup_favorites.TabIndex = 20
        Me.Label_favorite_backup_favorites.Text = "-"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(15, 36)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(30, 13)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "Size:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(15, 61)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 13)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Favorites:"
        '
        'Label_favorite_backup_size
        '
        Me.Label_favorite_backup_size.AutoSize = True
        Me.Label_favorite_backup_size.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_favorite_backup_size.Location = New System.Drawing.Point(70, 36)
        Me.Label_favorite_backup_size.Name = "Label_favorite_backup_size"
        Me.Label_favorite_backup_size.Size = New System.Drawing.Size(10, 13)
        Me.Label_favorite_backup_size.TabIndex = 15
        Me.Label_favorite_backup_size.Text = "-"
        '
        'Button_Restore_Fav
        '
        Me.Button_Restore_Fav.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Restore_Fav.Location = New System.Drawing.Point(908, 310)
        Me.Button_Restore_Fav.Name = "Button_Restore_Fav"
        Me.Button_Restore_Fav.Size = New System.Drawing.Size(185, 34)
        Me.Button_Restore_Fav.TabIndex = 30
        Me.Button_Restore_Fav.Text = "<<< Restore Favorites"
        Me.Button_Restore_Fav.UseVisualStyleBackColor = True
        '
        'Button_Backup_Fav
        '
        Me.Button_Backup_Fav.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Backup_Fav.Location = New System.Drawing.Point(908, 262)
        Me.Button_Backup_Fav.Name = "Button_Backup_Fav"
        Me.Button_Backup_Fav.Size = New System.Drawing.Size(185, 34)
        Me.Button_Backup_Fav.TabIndex = 29
        Me.Button_Backup_Fav.Text = "Backup Favorites >>>"
        Me.Button_Backup_Fav.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(458, 569)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(316, 13)
        Me.LinkLabel1.TabIndex = 31
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "https://github.com/CamSchnur/BeatSaber_CustomLevelCleanup"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(397, 569)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Thanks to:"
        '
        'Form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1263, 731)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button_Restore_Fav)
        Me.Controls.Add(Me.Button_Backup_Fav)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button_restore_Saber)
        Me.Controls.Add(Me.Button_backup_saber)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox_Songs)
        Me.Controls.Add(Me.GroupBox_Backup)
        Me.Controls.Add(Me.RadioButton_Fav)
        Me.Controls.Add(Me.Button_Restore_song)
        Me.Controls.Add(Me.RadioButton_All)
        Me.Controls.Add(Me.TextBox_Search)
        Me.Controls.Add(Me.VlcControl_MusicPlayer)
        Me.Controls.Add(Me.Button_Backup_song)
        Me.Controls.Add(Me.Button_Choose_Beatsaber)
        Me.Controls.Add(Me.ListBox_Protocol)
        Me.Controls.Add(Me.Button_Select_Backupfolder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox_BackupFolder)
        Me.Controls.Add(Me.ListView_songs)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_Beatsaber_Path)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Main"
        Me.Text = "BeatSaber Backup"
        CType(Me.VlcControl_MusicPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip_Song_Right.ResumeLayout(False)
        Me.GroupBox_Backup.ResumeLayout(False)
        Me.GroupBox_Backup.PerformLayout()
        Me.GroupBox_Songs.ResumeLayout(False)
        Me.GroupBox_Songs.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_Beatsaber_Path As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListView_songs As ListView
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_BackupFolder As TextBox
    Friend WithEvents FolderBrowserDialog_Main As FolderBrowserDialog
    Friend WithEvents Button_Select_Backupfolder As Button
    Friend WithEvents ListBox_Protocol As ListBox
    Friend WithEvents Button_Choose_Beatsaber As Button
    Friend WithEvents Button_Backup_song As Button
    Friend WithEvents Button_Restore_song As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label_Backup_size As Label
    Friend WithEvents Label_Song_size As Label
    Friend WithEvents VlcControl_MusicPlayer As Vlc.DotNet.Forms.VlcControl
    Friend WithEvents Timer_Media_Position As Timer
    Friend WithEvents ContextMenuStrip_Song_Right As ContextMenuStrip
    Friend WithEvents DeleteFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConvertToMp3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox_Search As TextBox
    Friend WithEvents RadioButton_All As RadioButton
    Friend WithEvents RadioButton_Fav As RadioButton
    Friend WithEvents GroupBox_Backup As GroupBox
    Friend WithEvents Label_Backup_songs As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox_Songs As GroupBox
    Friend WithEvents Label_Songs_songs As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label_Sabers As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label_size_saber As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label_Sabers_Backup As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label_size_saber_backup As Label
    Friend WithEvents Button_restore_Saber As Button
    Friend WithEvents Button_backup_saber As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label_favorites As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label_favorite_size As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label_favorite_backup_favorites As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label_favorite_backup_size As Label
    Friend WithEvents Button_Restore_Fav As Button
    Friend WithEvents Button_Backup_Fav As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label6 As Label
End Class
