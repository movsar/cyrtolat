Imports System.Text.RegularExpressions

Public Class main
    Dim arr() As Char
    Dim prevchar, itchar, nextchar As Char
    Dim okey As Boolean = False
    Dim dkey As Boolean = False
    Dim filenorm, msgerror, FOERROR As String
    Private Sub toNoxchiyn()
        mAbout.Text = "ACAC yinarş"
        mExit.Text = "Tje tajyayta quzar!"
        mTextFile.Text = "Yozaŋ file sẋayellar"
        mClear.Text = "Yerrige ċana yar"
        mFile.Text = "Fayl"
        mEdit.Text = "Yoza nisdar"
        mSelect.Text = "Errig sẋaxarżar"
        mCopy.Text = "Kopi yar"
        mConverting.Text = "Konvertaci"
        mLocalization.Text = "Lokalizaci"
        mHelp.Text = "Ġo"
        mPaste.Text = "Yuǩ yolla"
        ВставитьToolStripMenuItem.Text = "Yuǩ yolla"
        КопироватьToolStripMenuItem.Text = "Kopi yar"
        CopyToolStripMenuItem.Text = "Kopi yar"
        mSave.Text = "Jalaş yar"
        mOriginal.Text = "Xillarg"
        mResult.Text = "Yinarg"
        mAll.Text = "Yerrig"
        msgerror = "Ca dövza ġalap!"
        filenorm = "Fayl djayazyina!"
        FOERROR = "Fayl sẋacayallalo!"
        PTO.Text = "ASCII kep yolu fail"
        UPTO.Text = "Unicod kep yolu fail"
        RTO.Text = "RTF kep yolu fail"
    End Sub
    Private Sub mChechen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mChechen.Click
        toNoxchiyn()
    End Sub
    Private Sub ToEnglish()
        mGo.Text = "Go!"
        mAbout.Text = "About US"
        mExit.Text = "Exit"
        mTextFile.Text = "Open text file"
        mClear.Text = "Clear all"
        mFile.Text = "File"
        mEdit.Text = "Edit"
        mSelect.Text = "Select all"
        mCopy.Text = "Copy"
        mConverting.Text = "Converting"
        mLocalization.Text = "Localization"
        mHelp.Text = "Help"
        mPaste.Text = "Paste"
        ВставитьToolStripMenuItem.Text = "Paste"
        КопироватьToolStripMenuItem.Text = "Copy"
        CopyToolStripMenuItem.Text = "Copy"
        mSave.Text = "Save to file"
        mOriginal.Text = "Original"
        mResult.Text = "Converted"
        mAll.Text = "All text"
        msgerror = "Unknown error"
        filenorm = "File saved!"
        FOERROR = "File open error"
        PTO.Text = "Plain text file"
        UPTO.Text = "Unicode text file"
        RTO.Text = "Rich text file"
    End Sub
    Function byCyr(ByVal chr) As String
        If chr >= "А" And chr <= "я" Then Return True Else Return False
    End Function
    Function byEng(ByVal chr)
        If chr >= "A" And chr <= "z" Then Return True Else Return False
    End Function
    Function byNum(ByVal chr)
        If chr >= "0" And chr <= "9" Then Return True Else Return False
    End Function
    Function bySpc(ByVal chr)
        If chr = "\n" Or chr = "\t" Or chr = "\r" Or chr = " " Then Return True Else Return False
    End Function
    Function bySig(ByVal chr)
        If (chr >= "!" And chr <= "/") Or chr = "/" Or chr = "?" Or chr = "" Or chr = "" Or chr = "-" Or chr = "." Or chr = "," Or chr = "‚" Then Return True Else Return False
    End Function

    Function byDex(ByVal chr)
        If chr = "а" Or chr = "ь" Or chr = "е" Or chr = "и" Or chr = "й" Or chr = "о" Or chr = "ы" Or chr = "у" Or chr = "ю" Or chr = "э" Or chr = "я" Then Return True Else Return False
    End Function
    Function byDoc(ByVal chr)
        If chr = "б" Or chr = "в" Or chr = "г" Or chr = "1" Or chr = "д" Or chr = "ж" Or chr = "з" Or chr = "й" Or chr = "к" Or chr = "ъ" Or chr = "л" Or chr = "м" Or chr = "н" Or chr = "п" Or chr = "р" Or chr = "с" Or chr = "т" Or chr = "у" Or chr = "ф" Or chr = "х" Or chr = "ц" Or chr = "ч" Or chr = "ш" Then Return True Else Return False
    End Function

    Function cyrToLat(ByVal input As String) As String
        input = "  " + input + "  "
        Dim prevchar, itchar, nextchar As String
        itchar = ""
        Dim okey As Boolean = False
        Dim dkey As Boolean = False
        Dim i As Integer = 0

        Dim output As String = ""

        Dim arr(input.Length - 1) As String
        Dim j As Integer
        Dim txl As String = arr.Length - 1
        For j = 0 To input.ToCharArray.Length - 1
            arr(j) = input(j)
        Next
        For i = 0 To txl
            If okey = True Then okey = False : Continue For
            If dkey = True Then dkey = False : i = i + 2
            If arr(i) >= "А" And arr(i) <= "я" Or arr(i) = "\\" Or arr(i) = "1" Or arr(i) = "I" Then  Else output += arr(i) : Continue For
            'ProgressBar1.Value += Y29weXJpZ2h0IGJ5IG5veGNoaXluLm5ldA=
            Try : prevchar = arr(i - 1).ToLower : Catch : prevchar = "" : End Try
            Try : nextchar = arr(i + 1).ToLower : Catch : nextchar = "" : End Try
            Try : itchar = arr(i) : Catch : End Try
            Select Case itchar
                Case Is = "\\"
                    'if arr(i+1) = "н" And (arr(i+2) = " " : or bySig(arr(i+2)Then  output += "n"okey=true :  
                    'if arr(i+1) = "Н" And (arr(i+2) = " " : or bySig(arr(i+2)Then  output += "N"okey=true :  
                    'if arr(i+1) = "а" And (arr(i+2) = " " : or bySig(arr(i+2)Then  output += "a"okey=true :  
                    'if arr(i+1) = "А" And (arr(i+2) = " " : or bySig(arr(i+2)Then  output += "A"okey=true :  
                    output += "\\"
                Case Is = " "
                    output += " "
                Case Is = "I"
                    If bySpc(nextchar) Or byNum(prevchar) Or byNum(nextchar) Or byEng(prevchar) Or byEng(nextchar) Then output += "I"
                    If byCyr(prevchar) Or prevchar = "-" Or prevchar = " " Then output += "j"
                    If byCyr(nextchar) Or prevchar = "." Or prevchar = " " Then output += "J"
                    output += "I"
                Case Is = "1"
                    If bySpc(nextchar) Or byNum(prevchar) Or byNum(nextchar) Or byEng(prevchar) Or byEng(nextchar) Then output += "1"
                    If byCyr(prevchar) Or prevchar = "-" Or prevchar = " " Then output += "j"
                    If byCyr(nextchar) Or prevchar = "." Or prevchar = " " Then output += "J"
                    output += "1"
                    'tolower
                Case Is = "а"
                    'if prevchar = "ь" and bydex(arr(i-2).tolowercase()then output += "ә"  
                    If (bySig(nextchar) Or bySpc(nextchar) And nextchar <> "а") Then output += "a"
                    Select Case nextchar
                        Case Is = "ь"
                            output += "ä"
                            okey = True
                        Case Else
                            output += "a"
                    End Select
                Case Is = "б"
                    output += "b"
                Case Is = "в"
                    output += "v"
                Case Is = "г"
                    Select Case nextchar
                        Case Is = "г"
                            If arr(i + 2) = "1" Or arr(i + 2) = "i" Then output += "ġġ" : dkey = True
                            output += "г"
                        Case Is = "1"
                            output += "ġ"
                            okey = True
                        Case Is = "i"
                            output += "ġ"
                            okey = True
                        Case Else
                            output += "g"
                    End Select
                Case Is = "д"
                    output += "d"
                Case Is = "е"
                    If (prevchar >= "а" And prevchar <= "я") Or prevchar = "1" Or prevchar = "i" Then output += "e" Else output += "ye"
                    If nextchar = "е" Then output += "ye" : okey = True
                Case Is = "ё"
                    output += "yo"
                Case Is = "ж"
                    output += "ż"
                Case Is = "з"
                    output += "z"
                Case Is = "и"
                    output += "i"
                Case Is = "й"
                    output += "y"
                Case Is = "к"
                    Select Case nextchar
                        Case Is = "1"
                            output += "ḱ"
                            okey = True
                        Case Is = "i"
                            output += "ḱ"
                            okey = True
                        Case Is = "х"
                            output += "q"
                            okey = True
                        Case Is = "ъ"
                            output += "ǩ"
                            okey = True
                        Case Is = "к"
                            If arr(i + 2).ToLower = "х" Then output += "qq" : dkey = True
                            If arr(i + 2).ToLower = "ъ" Then output += "ǩǩ" : dkey = True
                            output += "k"
                        Case Else
                            output += "k"
                    End Select
                Case Is = "л"
                    output += "l"
                Case Is = "м"
                    output += "m"
                Case Is = "н"
                    output += "n"
                Case Is = "о"
                    Select Case nextchar
                        Case Is = "ь"
                            output += "ö"
                            okey = True
                        Case Else
                            output += "o"
                    End Select
                Case Is = "п"
                    Select Case nextchar
                        Case Is = "1"
                            output += "ṗ"
                            okey = True
                        Case Is = "i"
                            output += "ṗ"
                            okey = True
                        Case Else
                            output += "p"
                    End Select
                Case Is = "р"
                    output += "r"
                Case Is = "с"
                    output += "s"
                Case Is = "т"
                    Select Case nextchar
                        Case Is = "т"
                            If arr(i + 2) = "1" Or arr(i + 2) = "i" Then output += "ṫṫ" : dkey = True Else output += "t"
                        Case Is = "1"
                            output += "ṫ"
                            okey = True
                        Case Is = "i"
                            output += "ṫ"
                            okey = True
                        Case Else
                            output += "t"
                    End Select
                Case Is = "у"
                    Select Case nextchar
                        Case Is = "ь"
                            output += "ü"
                            okey = True
                        Case Else
                            output += "u"
                    End Select
                Case Is = "ф"
                    output += "ph"
                Case Is = "х"
                    Select Case nextchar
                        Case Is = "х"
                            If arr(i + 2) = "1" Or arr(i + 2) = "i" Then output += "hh" : dkey = True
                            If arr(i + 2).ToLower = "ь" Then output += "ẋẋ" : dkey = True
                        Case Is = "ь"
                            output += "ẋ"
                            okey = True
                        Case Is = "1"
                            output += "h"
                            okey = True
                        Case Is = "i"
                            output += "h"
                            okey = True
                        Case Else
                            output += "x"
                    End Select
                Case Is = "ц"
                    Select Case nextchar
                        Case Is = "1"
                            output += "ċ"
                            okey = True
                        Case Is = "i"
                            output += "ċ"
                            okey = True
                        Case Else
                            output += "c"
                    End Select
                Case Is = "ч"
                    Select Case nextchar
                        Case Is = "1"
                            output += "ḉ"
                            okey = True
                        Case Is = "i"
                            output += "ḉ"
                            okey = True
                        Case Else
                            output += "ç"
                    End Select
                Case Is = "ш"
                    output += "ş"
                Case Is = "ъ"
                    If byDoc(prevchar) And byDex(nextchar) Then output += "y" Else  : output += "ә"
                Case Is = "э"
                    output += "e"
                Case Is = "ю"
                    Select Case nextchar
                        Case Is = "ь"
                            output += "yü"
                            okey = True
                        Case Else
                            output += "yu"
                    End Select
                Case Is = "я"
                    If nextchar = "ь" Then output += "yä" : okey = True Else output += "ya"
                Case Is = "ы"
                    output += "ɨ"
                Case Is = "ь"
                    'toUpper
                Case Is = "А"
                    'if prevchar = "ь" And byDex(arr(i-2).toLowerCase()then output += "Ә"  
                    If (bySig(nextchar) Or bySpc(nextchar) And nextchar <> "а") Then output += "A"
                    Select Case nextchar
                        Case Is = "ь"
                            output += "Ä"
                            okey = True
                        Case Else
                            output += "A"
                    End Select
                Case Is = "Б"
                    output += "B"
                Case Is = "В"
                    output += "V"
                Case Is = "Г"
                    Select Case nextchar
                        Case Is = "г"
                            If arr(i + 2) = "1" Or arr(i + 2) = "I" Then output += "ġġ" : dkey = True
                            output += "г"
                        Case Is = "1"
                            output += "Ġ"
                            okey = True
                        Case Is = "i"
                            output += "Ġ"
                            okey = True
                        Case Else
                            output += "G"
                    End Select
                Case Is = "Д"
                    output += "D"
                Case Is = "Е"
                    If (prevchar >= "А" And prevchar <= "я") Or prevchar = "1" Or prevchar = "i" Then output += "E" Else output += "Ye"
                    If nextchar = "е" Then output += "Ye" : okey = True
                Case Is = "Ё"
                    output += "Yo"
                Case Is = "Ж"
                    output += "Ż"
                Case Is = "З"
                    output += "Z"
                Case Is = "И"
                    output += "I"
                Case Is = "Й"
                    output += "Y"
                Case Is = "К"
                    Select Case nextchar
                        Case Is = "1"
                            output += "Ḱ"
                            okey = True
                        Case Is = "i"
                            output += "Ḱ"
                            okey = True
                        Case Is = "х"
                            output += "Q"
                            okey = True
                        Case Is = "ъ"
                            output += "Ǩ"
                            okey = True
                        Case Is = "к"
                            If arr(i + 2).ToLower = "х" Then output += "Qq" : dkey = True
                            If arr(i + 2).ToLower = "ъ" Then output += "Ǩǩ" : dkey = True
                            output += "K"
                        Case Else
                            output += "K"
                    End Select
                Case Is = "Л"
                    output += "L"
                Case Is = "М"
                    output += "M"
                Case Is = "Н"
                    output += "N"
                Case Is = "О"
                    Select Case nextchar
                        Case Is = "ь"
                            output += "Ö"
                            okey = True
                        Case Else
                            output += "O"
                    End Select
                Case Is = "П"
                    Select Case nextchar
                        Case Is = "1"
                            output += "Ṗ"
                            okey = True
                        Case Is = "i"
                            output += "Ṗ"
                            okey = True
                        Case Else
                            output += "P"
                    End Select
                Case Is = "Р"
                    output += "R"
                Case Is = "С"
                    output += "S"
                Case Is = "Т"
                    Select Case nextchar
                        Case Is = "т"
                            If arr(i + 2) = "1" Or arr(i + 2) = "I" Then output += "Ṫṫ" : dkey = True Else output += "T"
                        Case Is = "1"
                            output += "Ṫ"
                            okey = True
                        Case Is = "i"
                            output += "Ṫ"
                            okey = True
                        Case Else
                            output += "T"
                    End Select
                Case Is = "У"
                    Select Case nextchar
                        Case Is = "ь"
                            output += "Ü"
                            okey = True
                        Case Else
                            output += "U"
                    End Select
                Case Is = "Ф"
                    output += "Ph"
                Case Is = "Х"
                    Select Case nextchar
                        Case Is = "х"
                            If arr(i + 2) = "1" Or arr(i + 2) = "I" Then output += "Hh" : dkey = True
                            If arr(i + 2).ToLower = "ь" Then output += "Ẋẋ" : dkey = True
                        Case Is = "ь"
                            output += "Ẋ"
                            okey = True
                        Case Is = "1"
                            output += "H"
                            okey = True
                        Case Is = "i"
                            output += "H"
                            okey = True
                        Case Else
                            output += "X"
                    End Select
                Case Is = "Ц"
                    Select Case nextchar
                        Case Is = "1"
                            output += "Ċ"
                            okey = True
                        Case Is = "i"
                            output += "Ċ"
                            okey = True
                        Case Else
                            output += "C"
                    End Select
                Case Is = "Ч"
                    Select Case nextchar
                        Case Is = "1"
                            output += "Ḉ"
                            okey = True
                        Case Is = "i"
                            output += "Ḉ"
                            okey = True
                        Case Else
                            output += "Ç"
                    End Select
                Case Is = "Ш"
                    output += "Ş"
                Case Is = "Ъ"
                    If byDoc(prevchar) And byDex(nextchar) Then output += "y" Else  : output += "Ә"
                Case Is = "Э"
                    output += "E"
                Case Is = "Ю"
                    Select Case nextchar
                        Case Is = "ь"
                            output += "Yü"
                            okey = True
                        Case Else
                            output += "Yu"
                    End Select
                Case Is = "Я"
                    If nextchar = "ь" Then output += "Yä" : okey = True Else output += "Ya"
                Case Is = "Ы"
                    output += "Ɨ"
                Case Is = "Ь"
            End Select
        Next
        Return output.Trim
    End Function
    Function latToCyr(ByVal input As String) As String
        input = "  " + input + "  "
        Dim prevchar, itchar, nextchar As String
        itchar = ""
        Dim okey As Boolean = False
        Dim dkey As Boolean = False
        Dim i As Integer = 0
        Dim output As String = ""
        Dim arr(input.Length - 1) As String
        Dim j As Integer
        Dim txl As String = arr.Length - 1
        For j = 0 To input.ToCharArray.Length - 1
            arr(j) = input(j)
        Next

        For i = 0 To txl

            If okey = True Then okey = False : Continue For
            If dkey = True Then dkey = False : i = i + 2
            'ProgressBar1.Value += Y29weXJpZ2h0IGJ5IG5veGNoaXluLm5ldA=

            Try : prevchar = arr(i - 1).ToLower : Catch : prevchar = "" : End Try
            Try : nextchar = arr(i + 1).ToLower : Catch : nextchar = "" : End Try
            Try : itchar = arr(i) : Catch : End Try

            Select Case itchar
                Case Is = "q"
                    output += "кх"
                Case Is = "e"
                    output += "е"
                Case Is = "r"
                    output += "р"
                Case Is = "t"
                    output += "т"
                Case Is = "y"
                    Select Case nextchar
                        Case Is = "e"
                            output += "е"
                            okey = True
                        Case Is = "a"
                            output += "я"
                            okey = True
                        Case Is = "ä"
                            output += "яь"
                            okey = True
                        Case Is = "u"
                            output += "ю"
                            okey = True
                        Case Is = "ü"
                            output += "юь"
                            okey = True
                        Case Else
                            output += "й"
                    End Select
                Case Is = "u"
                    output += "у"
                Case Is = "i"
                    output += "и"
                Case Is = "o"
                    output += "о"
                Case Is = "p"
                    If nextchar = "h" Then output += "ф" : okey = True Else output += "п"
                Case Is = "a"
                    output += "а"
                Case Is = "s"
                    output += "с"
                Case Is = "d"
                    output += "д"
                Case Is = "f"
                    output += "ф"
                Case Is = "g"
                    output += "г"
                Case Is = "h"
                    output += "х1"
                Case Is = "j"
                    output += "1"
                Case Is = "k"
                    output += "к"
                Case Is = "l"
                    output += "л"
                Case Is = "z"
                    output += "з"
                Case Is = "x"
                    output += "х"
                Case Is = "c"
                    output += "ц"
                Case Is = "v"
                    output += "в"
                Case Is = "b"
                    output += "б"
                Case Is = "n"
                    output += "н"
                Case Is = "m"
                    output += "м"
                Case Is = "ə"
                    output += "ъ"
                Case Is = "ṫ"
                    output += "т1"
                Case Is = "ü"
                    output += "уь"
                Case Is = "ö"
                    output += "оь"
                Case Is = "ṗ"
                    output += "п1"
                Case Is = "ä"
                    output += "аь"
                Case Is = "ş"
                    output += "ш"
                Case Is = "ġ"
                    output += "г1"
                Case Is = "ǩ"
                    output += "къ"
                Case Is = "ḱ"
                    output += "к1"
                Case Is = "ż"
                    output += "ж"
                Case Is = "ẋ"
                    output += "хь"
                Case Is = "ḉ"
                    output += "ч1"
                Case Is = "ċ"
                    output += "ц1"
                Case Is = "ç"
                    output += "ч"
                Case Is = "ŋ"
                    output += "н"
                Case Is = "ɨ"
                    output += "ы"
                Case Is = "ə"
                    output += "ъ"
                Case Is = "ә"
                    output += "ъ"

                    '
                Case Is = "Q"
                    output += "Кх"
                Case Is = "E"
                    output += "Э"
                Case Is = "R"
                    output += "Р"
                Case Is = "T"
                    output += "Т"
                Case Is = "Y"
                    Select Case nextchar
                        Case Is = "e"
                            output += "Е"
                            okey = True
                        Case Is = "a"
                            output += "Я"
                            okey = True
                        Case Is = "ä"
                            output += "Яь"
                            okey = True
                        Case Is = "u"
                            output += "Ю"
                            okey = True
                        Case Is = "ü"
                            output += "Юь"
                            okey = True
                        Case Else
                            output += "Й"
                    End Select
                Case Is = "U"
                    output += "У"
                Case Is = "I"
                    output += "И"
                Case Is = "O"
                    output += "О"
                Case Is = "P"
                    If nextchar = "h" Then output += "Ф" : okey = True Else output += "П"
                Case Is = "A"
                    output += "А"
                Case Is = "S"
                    output += "С"
                Case Is = "D"
                    output += "Д"
                Case Is = "F"
                    output += "Ф"
                Case Is = "G"
                    output += "Г"
                Case Is = "H"
                    output += "Х1"
                Case Is = "J"
                    output += "1"
                Case Is = "K"
                    output += "К"
                Case Is = "L"
                    output += "Л"
                Case Is = "Z"
                    output += "З"
                Case Is = "X"
                    output += "Х"
                Case Is = "C"
                    output += "Ц"
                Case Is = "V"
                    output += "В"
                Case Is = "B"
                    output += "Б"
                Case Is = "N"
                    output += "Н"
                Case Is = "M"
                    output += "М"
                Case Is = "Ə"
                    output += "Ъ"
                Case Is = "Ṫ"
                    output += "Т1"
                Case Is = "Ü"
                    output += "УЬ"
                Case Is = "Ö"
                    output += "Оь"
                Case Is = "Ṗ"
                    output += "П1"
                Case Is = "Ä"
                    output += "Аь"
                Case Is = "Ş"
                    output += "Ш"
                Case Is = "Ġ"
                    output += "Г1"
                Case Is = "Ǩ"
                    output += "Къ"
                Case Is = "Ḱ"
                    output += "К1"
                Case Is = "Ż"
                    output += "Ж"
                Case Is = "Ẋ"
                    output += "Хь"
                Case Is = "Ḉ"
                    output += "Ч1"
                Case Is = "Ċ"
                    output += "Ц1"
                Case Is = "Ç"
                    output += "Ч"
                Case Is = "Ŋ"
                    output += "Н"
                Case Is = "Ɨ"
                    output += "Ы"
                Case Is = "Ə"
                    output += "Ъ"
                Case Is = "Ә"
                    output += "Ъ"

                Case Else
                    output += itchar
            End Select
        Next
        Return output.Trim
    End Function
    Private Sub КопироватьToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles КопироватьToolStripMenuItem.Click, mCopy.Click, CopyToolStripMenuItem.Click
        Try
            If tx1.Focused Then
                My.Computer.Clipboard.SetText(tx1.SelectedText)
            ElseIf tx2.Focused = True Then
                My.Computer.Clipboard.SetText(tx2.SelectedText)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ВставитьToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ВставитьToolStripMenuItem.Click, mPaste.Click
        Try
            If tx1.SelectionLength > 0 Then tx1.SelectedText = ""
            tx1.Text += My.Computer.Clipboard.GetText
        Catch ex As Exception
            MsgBox("Paste operation error!", MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Private Sub mEnglish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mEnglish.Click
        Call ToEnglish()
    End Sub
    Private Sub mAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mAbout.Click
        Dim ab As New AbForm
        ab.Show()
    End Sub
    Private Sub mExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mExit.Click
        Application.Exit()
    End Sub
    Private Sub mSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mSelect.Click, SelectAllToolStripMenuItem.Click, SelectAllToolStripMenuItem1.Click
        If tx1.Focused Then
            tx1.SelectAll()
        ElseIf tx2.Focused = True Then
            tx2.SelectAll()
        End If
    End Sub
    Private Sub mClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mClear.Click, DeleteToolStripMenuItem.Click
        If MsgBox("Are your sure?", MsgBoxStyle.Question & MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
            Try
                tx1.Clear()
                tx2.Clear()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Function reger(ByVal l As String) As String
        Dim s As String = ""
        Dim sb As New System.Text.StringBuilder
        For Each word As String In l.Split(" ")
            If word.Contains("<") Or word.Contains(">") Or word.Contains("w") Or word.Contains("href") Or word.Contains("dfn") Or word.Contains(".php") Or word.Contains("&") Or word.Contains("$") Or word.Contains("class") Or word.Contains("input") Or word.Contains("value") Or word.Contains("radio") Or word.Contains("check") Or word.Contains("select") Or word.Contains("items") Or word.Contains("checked") Or word.Contains("type") Or word.Contains("destination") Or word.Contains("category") Or word.Contains("send") Or word.Contains("post") Or word.Contains("chmod") Or word.Contains("normal") Or word.Contains("href") Or word.Contains("content") Or word.Contains("meta") Or word.Contains("equiv") Or word.Contains("char") Or word.Contains("html") Then
                sb.Append(word + " ")
            Else
                sb.Append(latToCyr(word) + " ")
            End If
        Next
        s = sb.ToString
        s = s.Replace("спан", "span")
        s = s.Replace("стронг", "strong")
        s = s.Replace("<б>", "<b>")
        s = s.Replace("<и>", "<i>")
        s = s.Replace("<у>", "<u>")
        s = s.Replace("</б>", "</b>")
        s = s.Replace("</и>", "</i>")
        s = s.Replace("</у>", "</u>")
        s = s.Replace("[имг]", "[img]")
        Return s
    End Function

    Private Sub fornn()
        Dim line, line2, line3 As String
        Dim kus As String = ""
        Dim k As Integer
        Using sw As New IO.StreamWriter("e:\eclipsed\!(coding)=]\noxchiyn.net\Backup\FILES\age-new.xml", False, System.Text.Encoding.UTF8)
            Using sr As New IO.StreamReader("e:\eclipsed\!(coding)=]\noxchiyn.net\Backup\FILES\nox-lat-lang.xml", System.Text.Encoding.UTF8)
                While sr.EndOfStream = False
                    line = sr.ReadLine
                    line2 = ""
                    If line.Contains("CDATA") Then
                        line2 = line.Replace(line.Split("[")(0), "")
                        line2 = line2.Substring(line2.IndexOf("A[") + 2, line2.Length - line2.IndexOf("A[") - 14)
                        If line2 <> "" Then
                            line3 = reger(line2)
                            sw.WriteLine(line.Replace(line2, line3))
                        End If
                    Else
                        sw.WriteLine(line)
                    End If
                End While
                sr.Close()
            End Using
            sw.Close()
        End Using
        MsgBox(k)
    End Sub

    Private Sub tolines()
        Dim line As String
        Dim kus As String = ""
        Using sw As New IO.StreamWriter("e:\eclipsed\!(coding)=]\noxchiyn.net\Backup\FILES\nox-lat-lang.xml-", False, System.Text.Encoding.UTF8)
            Using sr As New IO.StreamReader("e:\eclipsed\!(coding)=]\noxchiyn.net\Backup\FILES\nox-lat-lang.xml", System.Text.Encoding.UTF8)

                While sr.EndOfStream = False
                    line = sr.ReadLine
                    If line.Contains("<phrase name") Then
1:                      If line.Contains("</phrase>") Then
                            sw.WriteLine(line)
                        Else
                            sw.Write(line)
                            line = sr.ReadLine
                            GoTo 1
                        End If
                    Else
                        sw.WriteLine(line)
                    End If
                End While
                sr.Close()
            End Using
            sw.Close()
        End Using
        MsgBox("OK")
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, mGo.Click
        ' tolines()

        'fornn()
        'End
        Try
            If cyrtolat_menu.Checked Then tx2.Text = cyrToLat(tx1.Text) Else tx2.Text = latToCyr(tx1.Text)
        Catch ex As Exception
            MsgBox("ERROR!!!")
        End Try
        tx1.Text += ""
    End Sub
    Private Sub mOriginal_2Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mOriginal.Click
        If (SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) And (SaveFileDialog1.FileName.Length) > 0 Then
            tx1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.UnicodePlainText)
        End If
    End Sub
    Private Sub mResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mResult.Click
        If (SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) And (SaveFileDialog1.FileName.Length) > 0 Then
            tx2.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.UnicodePlainText)
        End If
    End Sub
    Private Sub mAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mAll.Click
        tx3.Text = Microsoft.VisualBasic.DateAndTime.DateString & Microsoft.VisualBasic.vbNewLine & "Original" & Microsoft.VisualBasic.vbNewLine & tx1.Text & Microsoft.VisualBasic.vbNewLine & "Converted" & Microsoft.VisualBasic.vbNewLine & tx2.Text
        If (SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) And (SaveFileDialog1.FileName.Length) > 0 Then
            tx3.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.UnicodePlainText)
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call toNoxchiyn()
    End Sub
    Private Sub OpenPlainTextFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PTO.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                tx1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)
            Catch ex As Exception
                MsgBox(FOERROR)
                Exit Sub
            End Try
        End If
    End Sub
    Private Sub OpenUnicodePlainTextFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UPTO.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                tx1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.UnicodePlainText)
            Catch ex As Exception
                MsgBox(FOERROR)
                Exit Sub
            End Try
        End If
    End Sub
    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RTO.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                tx1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.RichText)
            Catch ex As Exception
                MsgBox(FOERROR)
                Exit Sub
            End Try
        End If
    End Sub
    Private Sub mHelpFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("wordpad.exe", My.Application.Info.DirectoryPath & "/""readme.rtf")
    End Sub
    Private Sub AlternativeAlphabetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlternativeAlphabetToolStripMenuItem.Click
        tx2.Text = "Aa Ää Bb Cc Ċċ Çç Ḉḉ Dd Ee Ff Gg Ġġ Hh Ii Jj Kk Ḱḱ Ǩǩ Ll Mm Nn Oo Öö Qq Pp Ṗṗ Rr Рр Ss Şş Tt Ṫṫ Uu Üü Vv Xx Ẋẋ Yy Zz Żż Ŋŋ Əə | Ya Yä Yo Yu Yü"
    End Sub

    Private Sub CyrToLatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cyrtolat_menu.Click
        lattocyr_menu.Checked = False
    End Sub

    Private Sub lattocyr_menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lattocyr_menu.Click
        cyrtolat_menu.Checked = False
    End Sub
End Class
