<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.tx1 = New System.Windows.Forms.RichTextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.КопироватьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВставитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tx2 = New System.Windows.Forms.RichTextBox()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mTextFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.PTO = New System.Windows.Forms.ToolStripMenuItem()
        Me.UPTO = New System.Windows.Forms.ToolStripMenuItem()
        Me.RTO = New System.Windows.Forms.ToolStripMenuItem()
        Me.mSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mOriginal = New System.Windows.Forms.ToolStripMenuItem()
        Me.mResult = New System.Windows.Forms.ToolStripMenuItem()
        Me.mAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mSelect = New System.Windows.Forms.ToolStripMenuItem()
        Me.mConverting = New System.Windows.Forms.ToolStripMenuItem()
        Me.cyrtolat_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.lattocyr_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mGo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mLocalization = New System.Windows.Forms.ToolStripMenuItem()
        Me.mChechen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mEnglish = New System.Windows.Forms.ToolStripMenuItem()
        Me.mHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlternativeAlphabetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.tx3 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tx1
        '
        Me.tx1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.tx1.BackColor = System.Drawing.Color.White
        Me.tx1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.tx1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.tx1.ForeColor = System.Drawing.Color.Black
        Me.tx1.Location = New System.Drawing.Point(-1, 23)
        Me.tx1.Name = "tx1"
        Me.tx1.Size = New System.Drawing.Size(500, 130)
        Me.tx1.TabIndex = 2
        Me.tx1.Text = ""
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.КопироватьToolStripMenuItem, Me.ВставитьToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.SelectAllToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(128, 92)
        '
        'КопироватьToolStripMenuItem
        '
        Me.КопироватьToolStripMenuItem.Image = Global.ACAC.My.Resources.Resources.CopyHS
        Me.КопироватьToolStripMenuItem.Name = "КопироватьToolStripMenuItem"
        Me.КопироватьToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.КопироватьToolStripMenuItem.Text = "Copy"
        '
        'ВставитьToolStripMenuItem
        '
        Me.ВставитьToolStripMenuItem.Image = Global.ACAC.My.Resources.Resources.PasteHS
        Me.ВставитьToolStripMenuItem.Name = "ВставитьToolStripMenuItem"
        Me.ВставитьToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ВставитьToolStripMenuItem.Text = "Paste"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select all"
        '
        'tx2
        '
        Me.tx2.BackColor = System.Drawing.Color.White
        Me.tx2.ContextMenuStrip = Me.ContextMenuStrip2
        Me.tx2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.tx2.ForeColor = System.Drawing.Color.Black
        Me.tx2.Location = New System.Drawing.Point(-1, 170)
        Me.tx2.Name = "tx2"
        Me.tx2.ReadOnly = True
        Me.tx2.Size = New System.Drawing.Size(500, 130)
        Me.tx2.TabIndex = 4
        Me.tx2.Text = ""
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.SelectAllToolStripMenuItem1})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(128, 48)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = Global.ACAC.My.Resources.Resources.CopyHS
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'SelectAllToolStripMenuItem1
        '
        Me.SelectAllToolStripMenuItem1.Name = "SelectAllToolStripMenuItem1"
        Me.SelectAllToolStripMenuItem1.Size = New System.Drawing.Size(127, 22)
        Me.SelectAllToolStripMenuItem1.Text = "Select all"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ProgressBar1.Location = New System.Drawing.Point(-1, 150)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(500, 23)
        Me.ProgressBar1.TabIndex = 5
        Me.ProgressBar1.UseWaitCursor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "*.txt; *.rtf"
        Me.OpenFileDialog1.Filter = "Text files|*.txt; *.rtf"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Label1.Location = New System.Drawing.Point(0, 300)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(537, 45)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Label1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mFile, Me.mEdit, Me.mConverting, Me.mLocalization, Me.mHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(494, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mFile
        '
        Me.mFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mTextFile, Me.mSave, Me.ToolStripSeparator1, Me.mExit})
        Me.mFile.Name = "mFile"
        Me.mFile.Size = New System.Drawing.Size(37, 20)
        Me.mFile.Text = "&File"
        '
        'mTextFile
        '
        Me.mTextFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PTO, Me.UPTO, Me.RTO})
        Me.mTextFile.Image = Global.ACAC.My.Resources.Resources.OpenSelectedItemHS
        Me.mTextFile.Name = "mTextFile"
        Me.mTextFile.ShortcutKeyDisplayString = "Ctrl+O"
        Me.mTextFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mTextFile.Size = New System.Drawing.Size(187, 22)
        Me.mTextFile.Text = "&Open text file"
        '
        'PTO
        '
        Me.PTO.Name = "PTO"
        Me.PTO.Size = New System.Drawing.Size(188, 22)
        Me.PTO.Text = "Plain text file"
        '
        'UPTO
        '
        Me.UPTO.Name = "UPTO"
        Me.UPTO.Size = New System.Drawing.Size(188, 22)
        Me.UPTO.Text = "Unicode plain text file"
        '
        'RTO
        '
        Me.RTO.Name = "RTO"
        Me.RTO.Size = New System.Drawing.Size(188, 22)
        Me.RTO.Text = "Rich text file"
        '
        'mSave
        '
        Me.mSave.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mOriginal, Me.mResult, Me.mAll})
        Me.mSave.Image = Global.ACAC.My.Resources.Resources.saveHS
        Me.mSave.Name = "mSave"
        Me.mSave.ShortcutKeyDisplayString = ""
        Me.mSave.Size = New System.Drawing.Size(187, 22)
        Me.mSave.Text = "&Save to file"
        '
        'mOriginal
        '
        Me.mOriginal.Image = Global.ACAC.My.Resources.Resources.PortraitHS
        Me.mOriginal.Name = "mOriginal"
        Me.mOriginal.ShortcutKeyDisplayString = ""
        Me.mOriginal.Size = New System.Drawing.Size(150, 22)
        Me.mOriginal.Text = "&Original "
        '
        'mResult
        '
        Me.mResult.Image = Global.ACAC.My.Resources.Resources.TaskHS
        Me.mResult.Name = "mResult"
        Me.mResult.ShortcutKeyDisplayString = ""
        Me.mResult.Size = New System.Drawing.Size(150, 22)
        Me.mResult.Text = "&Converted"
        '
        'mAll
        '
        Me.mAll.Name = "mAll"
        Me.mAll.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mAll.Size = New System.Drawing.Size(150, 22)
        Me.mAll.Text = "&All text"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(184, 6)
        '
        'mExit
        '
        Me.mExit.Image = Global.ACAC.My.Resources.Resources.RightArrow2HS
        Me.mExit.Name = "mExit"
        Me.mExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.mExit.Size = New System.Drawing.Size(187, 22)
        Me.mExit.Text = "&Exit"
        '
        'mEdit
        '
        Me.mEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mCopy, Me.mPaste, Me.mClear, Me.mSelect})
        Me.mEdit.Name = "mEdit"
        Me.mEdit.Size = New System.Drawing.Size(39, 20)
        Me.mEdit.Text = "&Edit"
        '
        'mCopy
        '
        Me.mCopy.Image = Global.ACAC.My.Resources.Resources.CopyHS
        Me.mCopy.Name = "mCopy"
        Me.mCopy.ShortcutKeyDisplayString = "Ctrl+C"
        Me.mCopy.Size = New System.Drawing.Size(162, 22)
        Me.mCopy.Text = "&Copy"
        '
        'mPaste
        '
        Me.mPaste.Image = Global.ACAC.My.Resources.Resources.PasteHS
        Me.mPaste.Name = "mPaste"
        Me.mPaste.ShortcutKeyDisplayString = "Ctrl+V"
        Me.mPaste.Size = New System.Drawing.Size(162, 22)
        Me.mPaste.Text = "&Paste"
        '
        'mClear
        '
        Me.mClear.Name = "mClear"
        Me.mClear.Size = New System.Drawing.Size(162, 22)
        Me.mClear.Text = "C&lear all"
        '
        'mSelect
        '
        Me.mSelect.Name = "mSelect"
        Me.mSelect.ShortcutKeyDisplayString = "Ctrl+A"
        Me.mSelect.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mSelect.Size = New System.Drawing.Size(162, 22)
        Me.mSelect.Text = "&Select all"
        '
        'mConverting
        '
        Me.mConverting.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cyrtolat_menu, Me.lattocyr_menu, Me.mGo})
        Me.mConverting.Name = "mConverting"
        Me.mConverting.Size = New System.Drawing.Size(78, 20)
        Me.mConverting.Text = "&Converting"
        '
        'cyrtolat_menu
        '
        Me.cyrtolat_menu.Checked = True
        Me.cyrtolat_menu.CheckOnClick = True
        Me.cyrtolat_menu.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cyrtolat_menu.Name = "cyrtolat_menu"
        Me.cyrtolat_menu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.cyrtolat_menu.Size = New System.Drawing.Size(168, 22)
        Me.cyrtolat_menu.Text = "Cyr To Lat"
        '
        'lattocyr_menu
        '
        Me.lattocyr_menu.CheckOnClick = True
        Me.lattocyr_menu.Name = "lattocyr_menu"
        Me.lattocyr_menu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.lattocyr_menu.Size = New System.Drawing.Size(168, 22)
        Me.lattocyr_menu.Text = "Lat To Cyr"
        '
        'mGo
        '
        Me.mGo.Image = Global.ACAC.My.Resources.Resources.FormRunHS
        Me.mGo.Name = "mGo"
        Me.mGo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Space), System.Windows.Forms.Keys)
        Me.mGo.Size = New System.Drawing.Size(168, 22)
        Me.mGo.Text = "&Go"
        '
        'mLocalization
        '
        Me.mLocalization.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mChechen, Me.mEnglish})
        Me.mLocalization.Name = "mLocalization"
        Me.mLocalization.Size = New System.Drawing.Size(82, 20)
        Me.mLocalization.Text = "&Localization"
        '
        'mChechen
        '
        Me.mChechen.Image = Global.ACAC.My.Resources.Resources.Без_имени_1
        Me.mChechen.Name = "mChechen"
        Me.mChechen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mChechen.Size = New System.Drawing.Size(160, 22)
        Me.mChechen.Text = "&Noxçiyŋ"
        '
        'mEnglish
        '
        Me.mEnglish.Image = Global.ACAC.My.Resources.Resources.English
        Me.mEnglish.Name = "mEnglish"
        Me.mEnglish.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mEnglish.Size = New System.Drawing.Size(160, 22)
        Me.mEnglish.Text = "&English"
        '
        'mHelp
        '
        Me.mHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.mAbout, Me.AlternativeAlphabetToolStripMenuItem})
        Me.mHelp.Name = "mHelp"
        Me.mHelp.Size = New System.Drawing.Size(44, 20)
        Me.mHelp.Text = "&Help"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(179, 6)
        '
        'mAbout
        '
        Me.mAbout.Image = Global.ACAC.My.Resources.Resources.HomeHS
        Me.mAbout.Name = "mAbout"
        Me.mAbout.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.mAbout.Size = New System.Drawing.Size(182, 22)
        Me.mAbout.Text = "&About"
        '
        'AlternativeAlphabetToolStripMenuItem
        '
        Me.AlternativeAlphabetToolStripMenuItem.Name = "AlternativeAlphabetToolStripMenuItem"
        Me.AlternativeAlphabetToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.AlternativeAlphabetToolStripMenuItem.Text = "Alternative Alphabet"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "*.txt"
        Me.SaveFileDialog1.Filter = "Text Files | *.txt"
        '
        'tx3
        '
        Me.tx3.ContextMenuStrip = Me.ContextMenuStrip1
        Me.tx3.Location = New System.Drawing.Point(530, 300)
        Me.tx3.Name = "tx3"
        Me.tx3.Size = New System.Drawing.Size(1, 1)
        Me.tx3.TabIndex = 16
        Me.tx3.Text = ""
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Image = Global.ACAC.My.Resources.Resources.FormRunHS
        Me.Button1.Location = New System.Drawing.Point(0, 300)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(499, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = False
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(494, 323)
        Me.Controls.Add(Me.tx1)
        Me.Controls.Add(Me.tx3)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.tx2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "main"
        Me.Text = "Alternative Chechen Alphabet Converter"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tx1 As System.Windows.Forms.RichTextBox
    Friend WithEvents tx2 As System.Windows.Forms.RichTextBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents КопироватьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ВставитьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mLocalization As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mTextFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mConverting As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mChechen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mEnglish As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mOriginal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mResult As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tx3 As System.Windows.Forms.RichTextBox
    Private WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PTO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UPTO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RTO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mSelect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlternativeAlphabetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mGo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cyrtolat_menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lattocyr_menu As System.Windows.Forms.ToolStripMenuItem

End Class
