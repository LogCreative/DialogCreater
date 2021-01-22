' Dialog Creater
' LogCreative 2021 Dist Version
' https://github.com/LogCreative/DialogCreater
Public Class Form1
    Dim num, ok As Integer
    Dim x, y As Integer
    Dim MoreVis As Boolean
    Dim a As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TabControl1.Height = 128
        Me.Height = 214
        Me.TextBox1.Text = My.Settings.L1T
        Me.TextBox2.Text = My.Settings.L1P
        PictureHelp1.Visible = True
        PictureHelp2.Visible = False
        PictureHelp3.Visible = False
        PictureHelp4.Visible = False
        PictureHelp5.Visible = False
        PictureHelp6.Visible = False
        Button5.Enabled = False
        Button6.Enabled = True
        Call listbox2load()
        Select Case My.Settings.MinStart
            Case True
                Me.CheckBox2.Checked = True
            Case Else
                Me.CheckBox2.Checked = False
        End Select
        Select Case My.Settings.MoreVis
            Case True
                Me.CheckBox3.Checked = True
            Case Else
                Me.CheckBox3.Checked = False
        End Select
        NumericUpDown2.Value = My.Settings.VisInterval
        Button7.Enabled = False
        Label16.Text = "版本：" & Application.ProductVersion
    End Sub
    Private Sub Test()
        MsgBox("16", MsgBoxStyle.Critical, "重要信息")
        MsgBox("32", MsgBoxStyle.Question, "警告查询")
        MsgBox("48", MsgBoxStyle.Exclamation, "警告信息")
        MsgBox("64", MsgBoxStyle.Information, "信息消息")
        MsgBox("0", MsgBoxStyle.OkOnly, "仅确定按钮")
        MsgBox("1", MsgBoxStyle.OkCancel, "确定和取消按钮")
        MsgBox("2", MsgBoxStyle.AbortRetryIgnore, "中止重试忽略按钮")
        MsgBox("3", MsgBoxStyle.YesNoCancel, "是否取消按钮")
        MsgBox("4", MsgBoxStyle.YesNo, "是否按钮")
        MsgBox("5", MsgBoxStyle.RetryCancel, "重试取消按钮")
    End Sub

    Private Sub Run()
        '开始
        Me.Text = "对话框生成器(正在运行)"
        Select Case Me.CheckBox2.Checked
            Case True
                Me.Hide()
            Case Else

        End Select
        Me.StatusStrip1.BackColor = Color.Orange
        If Me.TabControl1.SelectedIndex = 0 Then
            LabelTip.Text = "正在运行对话框..."
            If Me.ComboBox1.Text = "16 MsgBoxStyle.Critical 重要信息" Then
                Dim result As Integer = MsgBox(Me.TextBox2.Text, MsgBoxStyle.Critical, Me.TextBox1.Text)
                LabelResult.Text = result
            ElseIf Me.ComboBox1.Text = "32 MsgBoxStyle.Question 警告查询" Then
                Dim result As Integer = MsgBox(Me.TextBox2.Text, MsgBoxStyle.Question, Me.TextBox1.Text)
                LabelResult.Text = result
            ElseIf Me.ComboBox1.Text = "48 MsgBoxStyle.Exclamation 警告信息" Then
                Dim result As Integer = MsgBox(Me.TextBox2.Text, MsgBoxStyle.Exclamation, Me.TextBox1.Text)
                LabelResult.Text = result
            ElseIf Me.ComboBox1.Text = "64 MsgBoxStyle.Information 信息消息" Then
                Dim result As Integer = MsgBox(Me.TextBox2.Text, MsgBoxStyle.Information, Me.TextBox1.Text)
                LabelResult.Text = result
            ElseIf Me.ComboBox1.Text = "0  MsgBoxStyle.OkOnly 仅确定按钮" Then
                Dim result As Integer = MsgBox(Me.TextBox2.Text, MsgBoxStyle.OkOnly, Me.TextBox1.Text)
                LabelResult.Text = result
            ElseIf Me.ComboBox1.Text = "1  MsgBoxStyle.OkCancel 确定和取消按钮" Then
                Dim result As Integer = MsgBox(Me.TextBox2.Text, MsgBoxStyle.OkCancel, Me.TextBox1.Text)
                LabelResult.Text = result
            ElseIf Me.ComboBox1.Text = "2  MsgBoxStyle.AbortRetryIgnore 中止重试忽略按钮" Then
                Dim result As Integer = MsgBox(Me.TextBox2.Text, MsgBoxStyle.AbortRetryIgnore, Me.TextBox1.Text)
                LabelResult.Text = result
            ElseIf Me.ComboBox1.Text = "3  MsgBoxStyle.YesNoCancel 是否取消按钮" Then
                Dim result As Integer = MsgBox(Me.TextBox2.Text, MsgBoxStyle.YesNoCancel, Me.TextBox1.Text)
                LabelResult.Text = result
            ElseIf Me.ComboBox1.Text = "4  MsgBoxStyle.YesNo 是否按钮" Then
                Dim result As Integer = MsgBox(Me.TextBox2.Text, MsgBoxStyle.YesNo, Me.TextBox1.Text)
                LabelResult.Text = result
            ElseIf Me.ComboBox1.Text = "5  MsgBoxStyle.RetryCancel 重试取消按钮" Then
                Dim result As Integer = MsgBox(Me.TextBox2.Text, MsgBoxStyle.RetryCancel, Me.TextBox1.Text)
                LabelResult.Text = result
            Else
                Dim result As Integer = MsgBox(Me.TextBox2.Text, MsgBoxStyle.OkOnly, Me.TextBox1.Text)
                LabelResult.Text = result
            End If
            Call CheckNumN()
        ElseIf Me.TabControl1.SelectedIndex = 1 Then
            Dim pic, btn As Integer
            btn = 0
            If Me.RadioButton1.Checked = True Then
                pic = 16
            ElseIf Me.RadioButton2.Checked = True Then
                pic = 32
            ElseIf Me.RadioButton3.Checked = True Then
                pic = 48
            ElseIf Me.RadioButton4.Checked = True Then
                pic = 64
            Else
                pic = 0
            End If
            If Me.ComboBox2.Text = "" Or Me.ComboBox2.Text = "0  仅确定按钮" Then
                btn = 0
            ElseIf Me.ComboBox2.Text = "1  确定和取消按钮" Then
                btn = 1
            ElseIf Me.ComboBox2.Text = "2  中止重试忽略按钮" Then
                btn = 2
            ElseIf Me.ComboBox2.Text = "3  是否取消按钮" Then
                btn = 3
            ElseIf Me.ComboBox2.Text = "4  是否按钮" Then
                btn = 4
            ElseIf Me.ComboBox2.Text = "5  重试取消按钮" Then
                btn = 5
            End If
            'msgbox(Textbox4.Text, ,Textbox3.Text)
            Select Case pic
                Case 0
                    Dim result As Integer = MsgBox(TextBox4.Text, btn, TextBox3.Text)
                    LabelResult.Text = result
                Case Else
                    Dim result As Integer = MsgBox(TextBox4.Text, pic + btn, TextBox3.Text)
                    LabelResult.Text = result
            End Select
            Call CheckNumN()
        ElseIf Me.TabControl1.SelectedIndex = 2 Then
            If Me.TabControl2.SelectedIndex = 0 Then
                Try
                    Dim result As Integer = MsgBox(TextBox5.Text, Val(ComboBox4.Text) + Val(ComboBox5.Text), TextBox7.Text)
                    LabelResult.Text = result
                    Call CheckNumN()
                Catch ex As Exception
                    MsgBox("代码有误。", MsgBoxStyle.Critical)
                End Try
            ElseIf Me.TabControl2.SelectedIndex = 2 Then

                TextBox11.Text = TimeOfDay & "  " & "正在初始化..." & vbNewLine
                LabelTip.Text = "正在初始化..."
                num = NumericUpDown1.Value
                ok = 0
                Me.ToolStripProgressBar1.Visible = True
                Me.ToolStripProgressBar1.Maximum = num
                Me.ToolStripProgressBar1.Value = 0
                Select Case CheckBox3.Checked
                    Case True
                        Timer1.Start()
                        TextBox11.Text += TimeOfDay & "  " & "包含多重存在。" & vbNewLine
                        LabelTip.Text += "包含多重存在。"
                        Me.Text = "对话框生成器(正在运行，包含多重存在)"
                        MoreVis = True
                    Case Else
                        Timer1.Stop()
                        MoreVis = False
                End Select
                TextBox11.Text += TimeOfDay & "  " & "重复执行开始。" & vbNewLine
                LabelTip.Text = "重复执行开始。"
                Select Case MoreVis
                    Case False
                        Do
                            ok = ok + 1
                            TextBox11.Text += TimeOfDay & "  " & "正在运行第 " & ok & " 个对话框，还剩 " & (num - ok) & " 个对话框。"
                            LabelTip.Text = "正在运行第 " & ok & " 个对话框，还剩 " & (num - ok) & " 个对话框。"
                            Me.ToolStripProgressBar1.PerformStep()
                            Dim result As Integer = MsgBox(TextBox5.Text, Val(ComboBox4.Text) + Val(ComboBox5.Text), TextBox7.Text)
                            If result = 1 Then
                                ToolStripLabel1.Visible = True
                                TextBox11.Text += "返回值为 1 （确定）。" & vbNewLine
                                ToolStripLabel1.Text = "确定"
                            ElseIf result = 2 Then
                                ToolStripLabel1.Visible = True
                                TextBox11.Text += "返回值为 2 （取消）。" & vbNewLine
                                ToolStripLabel1.Text = "取消"
                            ElseIf result = 3 Then
                                ToolStripLabel1.Visible = True
                                TextBox11.Text += "返回值为 3 （中止）。" & vbNewLine
                                ToolStripLabel1.Text = "中止"
                            ElseIf result = 4 Then
                                ToolStripLabel1.Visible = True
                                TextBox11.Text += "返回值为 4 （重试）。" & vbNewLine
                                ToolStripLabel1.Text = "重试"
                            ElseIf result = 5 Then
                                ToolStripLabel1.Visible = True
                                TextBox11.Text += "返回值为 5 （忽略）。" & vbNewLine
                                ToolStripLabel1.Text = "忽略"
                            ElseIf result = 6 Then
                                ToolStripLabel1.Visible = True
                                TextBox11.Text += "返回值为 6 （是）。" & vbNewLine
                                ToolStripLabel1.Text = "是"
                            ElseIf result = 7 Then
                                ToolStripLabel1.Visible = True
                                TextBox11.Text += "返回值为 7 （否）。" & vbNewLine
                                ToolStripLabel1.Text = "否"
                            Else
                                ToolStripLabel1.Visible = True
                                TextBox11.Text += "返回值无法识别 。" & vbNewLine
                                ToolStripLabel1.Text = "<未知>"
                            End If
                            TextBox11.ScrollToCaret()
                        Loop Until (ok = num)
                        TextBox11.Text += TimeOfDay & "  " & "重复执行结束。"
                        LabelTip.Text = "重复执行结束。"
                End Select
            ElseIf TabControl2.SelectedIndex = 4 Then
                Select Case CheckBox3.Checked
                    Case True
                        MoreVis = True
                    Case Else
                        MoreVis = False
                End Select
                Select Case MoreVis
                    Case True
                        TabControl2.SelectedIndex = 2
                    Case Else
                        TabControl2.SelectedIndex = 0
                End Select
                Call Run()
            End If
        End If
        '结束
        If MoreVis = False Or TabControl1.SelectedIndex <> 2 Or TabControl2.SelectedIndex <> 2 Then
            Me.Text = "对话框生成器"
            Me.StatusStrip1.BackColor = Color.DodgerBlue
            Me.Show()
        End If
    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Call Run()
    End Sub

    Private Sub ComboBox2_GotFocus(sender As Object, e As EventArgs) Handles ComboBox2.GotFocus
        LabelTip.Text = "可选。作为对话框的按钮。"
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        '0  仅确定按钮
        '1  确定和取消按钮
        '2  中止重试忽略按钮
        '3  是否取消按钮
        '4  是否按钮
        '5  重试取消按钮
        If Me.ComboBox2.Text = "0  仅确定按钮" Then
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = True
            Button3.Text = "确定"
        ElseIf Me.ComboBox2.Text = "1  确定和取消按钮" Then
            Button1.Visible = False
            Button2.Visible = True
            Button2.Text = "确定"
            Button3.Visible = True
            Button3.Text = "取消"
        ElseIf Me.ComboBox2.Text = "2  中止重试忽略按钮" Then
            Button1.Visible = True
            Button1.Text = "中止(&A)"
            Button2.Visible = True
            Button2.Text = "重试(&R)"
            Button3.Visible = True
            Button3.Text = "忽略(&I)"
        ElseIf Me.ComboBox2.Text = "3  是否取消按钮" Then
            Button1.Visible = True
            Button1.Text = "是(&Y)"
            Button2.Visible = True
            Button2.Text = "否(&N)"
            Button3.Visible = True
            Button3.Text = "取消"
        ElseIf Me.ComboBox2.Text = "4  是否按钮" Then
            Button1.Visible = False
            Button2.Visible = True
            Button2.Text = "是(&Y)"
            Button3.Visible = True
            Button3.Text = "否(&N)"
        ElseIf Me.ComboBox2.Text = "5  重试取消按钮" Then
            Button1.Visible = False
            Button2.Visible = True
            Button2.Text = "重试(&R)"
            Button3.Visible = True
            Button3.Text = "取消"
        End If
    End Sub

    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
        LabelTip.Text = "必选。作为对话框的内容。最大长度约为1024个字符，具体取决于所用字符的宽度。"
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        LabelTip.Text = "可选。作为对话框的标题。"
    End Sub

    Private Sub ComboBox1_GotFocus(sender As Object, e As EventArgs) Handles ComboBox1.GotFocus
        LabelTip.Text = "可选。为空即为仅确定按钮。此模式下不支持图像模式和按钮模式并用。"
    End Sub

    Private Sub TextBox3_GotFocus(sender As Object, e As EventArgs) Handles TextBox3.GotFocus
        LabelTip.Text = "可选。作为对话框的标题。"
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        LabelTip.Text = "可选。作为对话框的图像。"
    End Sub

    Private Sub TextBox4_GotFocus(sender As Object, e As EventArgs) Handles TextBox4.GotFocus
        LabelTip.Text = "必选。作为对话框的内容。最大长度约为1024个字符。按Enter可换行。"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox3.Text = TextBox1.Text
        TextBox7.Text = TextBox1.Text
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        TextBox1.Text = TextBox3.Text
        TextBox7.Text = TextBox3.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox4.Text = TextBox2.Text
        TextBox5.Text = TextBox2.Text
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If Me.ComboBox1.Text = "16 MsgBoxStyle.Critical 重要信息" Then
            RadioButton1.Checked = True
        ElseIf Me.ComboBox1.Text = "32 MsgBoxStyle.Question 警告查询" Then
            RadioButton2.Checked = True
        ElseIf Me.ComboBox1.Text = "48 MsgBoxStyle.Exclamation 警告信息" Then
            RadioButton3.Checked = True
        ElseIf Me.ComboBox1.Text = "64 MsgBoxStyle.Information 信息消息" Then
            RadioButton4.Checked = True
        ElseIf Me.ComboBox1.Text = "0  MsgBoxStyle.OkOnly 仅确定按钮" Then
            ComboBox2.Text = "0  仅确定按钮"
        ElseIf Me.ComboBox1.Text = "1  MsgBoxStyle.OkCancel 确定和取消按钮" Then
            ComboBox2.Text = "1  确定和取消按钮"
        ElseIf Me.ComboBox1.Text = "2  MsgBoxStyle.AbortRetryIgnore 中止重试忽略按钮" Then
            ComboBox2.Text = "2  中止重试忽略按钮"
        ElseIf Me.ComboBox1.Text = "3  MsgBoxStyle.YesNoCancel 是否取消按钮" Then
            ComboBox2.Text = "3  是否取消按钮"
        ElseIf Me.ComboBox1.Text = "4  MsgBoxStyle.YesNo 是否按钮" Then
            ComboBox2.Text = "4  是否按钮"
        ElseIf Me.ComboBox1.Text = "5  MsgBoxStyle.RetryCancel 重试取消按钮" Then
            ComboBox2.Text = "5  重试取消按钮"
        Else
            ComboBox2.Text = ""
        End If
    End Sub

    Private Sub TextBox5_GotFocus(sender As Object, e As EventArgs) Handles TextBox5.GotFocus
        TextBox9.Visible = True
        TextBox9.Text = "Prompt:必选。作为消息显示在对话框中的 String 表达式。Prompt 的最大长度大约为1024个字符，具体取决于所用字符的宽度。如果 Prompt 包含多行内容，则可以在每行之间使用 & vbNewLine & 来分隔各行。"
        LabelTip.Text = "Prompt 内容"
    End Sub

    Private Sub TextBox6_GotFocus(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox7_GotFocus(sender As Object, e As EventArgs) Handles TextBox7.GotFocus
        TextBox9.Visible = True
        TextBox9.Text = "Title:可选。显示在对话框标题栏中的 String 表达式。如果省略 Title ，则标题栏中显示应用程序名称。"
        LabelTip.Text = "Title 标题"
    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click
        TextBox9.Visible = False
    End Sub

    Private Sub ComboBox3_GotFocus(sender As Object, e As EventArgs) Handles ComboBox3.GotFocus
        LabelTip.Text = "可执行码类型"
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        ToolStripButton5.Enabled = True
        Call changezxm()
    End Sub

    Private Sub CHANGE()
        If Me.ComboBox3.Text = "vbs" Then
            Call VBS()
        ElseIf Me.ComboBox3.Text = "bat" Then
            Call BAT()
        End If
    End Sub
    Private Sub VBS()
        Me.TextBox8.Text = "msgbox " & """" & TextBox5.Text & """" & "," & ComboBox4.Text & "+" & ComboBox5.Text & "," & """" & TextBox7.Text & """"
        If Me.TextBox5.TextLength > 1024 And Me.TextBox5.Lines.Length > 1 Then
            Me.ToolStripLabel2.Visible = True
            Me.ToolStripLabel3.Visible = False
            Me.ToolStripLabel2.ToolTipText = "错误信息：03 " & vbNewLine & "内容长度超过 1024 个字符，可能会导致内容显示不完全。" & vbNewLine & "错误信息：04" & vbNewLine & "内容有换行，会导致可执行码命令错误。"
        ElseIf Me.TextBox5.TextLength > 1024 Then
            Me.ToolStripLabel2.Visible = True
            Me.ToolStripLabel3.Visible = False
            Me.ToolStripLabel2.ToolTipText = "错误信息：04 " & vbNewLine & "内容长度超过 1024 个字符，可能会导致内容显示不完全。"
        ElseIf Me.TextBox5.Lines.Length > 1 Then
            Me.ToolStripLabel2.Visible = True
            Me.ToolStripLabel3.Visible = False
            Me.ToolStripLabel2.ToolTipText = "错误信息：02" & vbNewLine & "内容有换行，会导致可执行码命令错误。"
        Else
            Me.ToolStripLabel3.Visible = True
            Me.ToolStripLabel2.Visible = False
        End If
    End Sub

    Private Sub BAT()
        Me.TextBox8.Text = "mshta vbscript:" & "Msgbox(" & """" & TextBox5.Text & """" & "," & ComboBox4.Text & "+" & ComboBox5.Text & "," & """" & TextBox7.Text & """" & ")" & "(window.close)"
        If Me.TextBox5.TextLength > 1024 And Me.TextBox5.Lines.Length > 1 Then
            Me.ToolStripLabel2.Visible = True
            Me.ToolStripLabel3.Visible = False
            Me.ToolStripLabel2.ToolTipText = "错误信息：01 " & vbNewLine & "内容长度超过 1024 个字符，可能会导致转化的可执行码无法执行命令。" & vbNewLine & "错误信息：02" & vbNewLine & "内容有换行，会导致可执行码执行命令失败。"
        ElseIf Me.TextBox5.TextLength > 1024 Then
            Me.ToolStripLabel2.Visible = True
            Me.ToolStripLabel3.Visible = False
            Me.ToolStripLabel2.ToolTipText = "错误信息：01 " & vbNewLine & "内容长度超过 1024 个字符，可能会导致转化的可执行码无法执行命令。"
        ElseIf Me.TextBox5.Lines.Length > 1 Then
            Me.ToolStripLabel2.Visible = True
            Me.ToolStripLabel3.Visible = False
            Me.ToolStripLabel2.ToolTipText = "错误信息：02" & vbNewLine & "内容有换行，会导致可执行码执行命令失败。"
        Else
            Me.ToolStripLabel3.Visible = True
            Me.ToolStripLabel2.Visible = False
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

        TextBox4.Text = TextBox5.Text
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        TextBox1.Text = TextBox7.Text
    End Sub

    Private Sub ComboBox4_GotFocus(sender As Object, e As EventArgs) Handles ComboBox4.GotFocus
        TextBox9.Visible = True
        TextBox9.Text = "Buttons:可选。数值表达式是多个值的总和，这些值指定要先是的按钮数目和类型、要使用的图标样式、默认按钮的标识以及消息框的模态。如果省略 Buttons ,则默认为 0 。"
        LabelTip.Text = "Buttons 模式"
    End Sub

    Private Sub ComboBox5_GotFocus(sender As Object, e As EventArgs) Handles ComboBox5.GotFocus
        TextBox9.Visible = True
        TextBox9.Text = "Buttons:可选。数值表达式是多个值的总和，这些值指定要先是的按钮数目和类型、要使用的图标样式、默认按钮的标识以及消息框的模态。如果省略 Buttons ,则默认为 0 。"
        LabelTip.Text = "Buttons 模式"
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        TabControl1.SelectTab(3)
        LabelTip.Text = "帮助"
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        TabControl1.SelectTab(4)
        LabelTip.Text = "关于"
    End Sub


    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        '窗口大小
        Me.ToolStripLabel3.Visible = False
        Me.ToolStripLabel2.Visible = False
        If Me.TabControl1.SelectedIndex = 0 Then
            Me.TabControl1.Height = 128
            Me.Height = 214
            Me.ToolStripButton1.Enabled = True
            Me.ToolStripButton4.Visible = False
            Me.ToolStripButton5.Visible = False
            Me.ToolStripLabel1.Visible = False
            Me.ToolStripButton2.Enabled = True
            Me.ToolStripProgressBar1.Visible = False
            Me.ToolStripButton2.Visible = True
            Me.ToolStripSplitButton1.Visible = False
        ElseIf Me.TabControl1.SelectedIndex = 1 Then
            Me.TabControl1.Height = 316
            Me.Height = 402
            Me.ToolStripButton1.Enabled = True
            Me.ToolStripButton4.Visible = False
            Me.ToolStripButton5.Visible = False
            Me.ToolStripLabel1.Visible = False
            Me.ToolStripButton2.Enabled = True
            Me.ToolStripProgressBar1.Visible = False
            Me.ToolStripButton2.Visible = True
            Me.ToolStripSplitButton1.Visible = False
        ElseIf Me.TabControl1.SelectedIndex = 2 Then
            Me.TabControl1.Height = 373
            Me.TabControl2.Height = 341
            Me.Height = 459
            Me.ToolStripButton5.Visible = True
            Me.ToolStripLabel1.Visible = False
            Me.ToolStripButton2.Visible = True
            Me.ToolStripSplitButton1.Visible = False
            If Me.TabControl2.SelectedIndex = 2 Then
                Me.TabControl1.Height = 373
                Me.TabControl2.Height = 341
                Me.Height = 459
                Me.ToolStripButton2.Enabled = True
                Me.ToolStripButton2.Visible = True
                Me.ToolStripButton4.Visible = True
                Me.ToolStripButton5.Enabled = False
                Me.ToolStripButton4.Enabled = True
                Me.ToolStripSplitButton1.Visible = False
                Call restartchange()
            ElseIf Me.TabControl2.SelectedIndex = 0 Then
                Me.TabControl1.Height = 373
                Me.TabControl2.Height = 341
                Me.Height = 459
                Me.ToolStripButton2.Enabled = True
                Me.ToolStripButton2.Visible = True
                Me.ToolStripSplitButton1.Visible = False
                Me.ToolStripButton4.Visible = True
                Me.ToolStripButton5.Enabled = False
                Me.ToolStripProgressBar1.Visible = False
                Me.ToolStripButton4.Enabled = True
                ToolStripLabel1.Visible = False
            ElseIf Me.TabControl2.SelectedIndex = 1 Then
                Me.TabControl1.Height = 373
                Me.TabControl2.Height = 341
                Me.Height = 459
                Me.ToolStripButton2.Enabled = False
                Me.ToolStripButton4.Visible = True
                Me.ToolStripButton2.Visible = True
                Me.ToolStripProgressBar1.Visible = False
                Me.ToolStripButton4.Enabled = True
                ToolStripLabel1.Visible = False
                Me.ToolStripSplitButton1.Visible = False
                If Me.ComboBox3.Text = "" Then
                    Me.ToolStripButton5.Enabled = False
                Else
                    Me.ToolStripButton5.Enabled = True
                End If
                Call changezxm()
            ElseIf Me.TabControl2.SelectedIndex = 3 Then
                Me.TabControl1.Height = 373
                Me.TabControl2.Height = 341
                Me.Height = 459
                Me.ToolStripButton2.Visible = False
                Me.ToolStripButton4.Enabled = False
                Me.ToolStripButton5.Enabled = False
                Me.ToolStripSplitButton1.Visible = True
            ElseIf Me.TabControl2.SelectedIndex = 4 Then
                Me.TabControl1.Height = 373
                Me.TabControl2.Height = 341
                Me.Height = 459
                Me.ToolStripSplitButton1.Visible = False
                '复制、保存按钮
                Me.ToolStripButton5.Enabled = False
                Me.ToolStripProgressBar1.Visible = False
                Me.ToolStripButton4.Enabled = False
                ToolStripLabel1.Visible = False
            End If
            '按钮模态
            If Me.RadioButton1.Checked = True Then
                Me.ComboBox4.Text = 16
            ElseIf Me.RadioButton2.Checked = True Then
                Me.ComboBox4.Text = 32
            ElseIf Me.RadioButton3.Checked = True Then
                Me.ComboBox4.Text = 48
            ElseIf Me.RadioButton4.Checked = True Then
                Me.ComboBox4.Text = 64
            End If
            If Me.ComboBox2.Text = "0  仅确定按钮" Then
                Me.ComboBox5.Text = 0
            ElseIf Me.ComboBox2.Text = "1  确定和取消按钮" Then
                Me.ComboBox5.Text = 1
            ElseIf Me.ComboBox2.Text = "2  中止重试忽略按钮" Then
                Me.ComboBox5.Text = 2
            ElseIf Me.ComboBox2.Text = "3  是否取消按钮" Then
                Me.ComboBox5.Text = 3
            ElseIf Me.ComboBox2.Text = "4  是否按钮" Then
                Me.ComboBox5.Text = 4
            ElseIf Me.ComboBox2.Text = "5  重试取消按钮" Then
                Me.ComboBox5.Text = 5
            End If
        ElseIf Me.TabControl1.SelectedIndex = 3 Then
            Me.TabControl1.Height = 316
            Me.Height = 402
            Me.LabelTip.Text = "帮助"
            Me.ToolStripButton2.Enabled = False
            Me.ToolStripProgressBar1.Visible = False
            Me.ToolStripButton2.Visible = True
            Me.ToolStripSplitButton1.Visible = False
        ElseIf Me.TabControl1.SelectedIndex = 4 Then
            Me.TabControl1.Height = 316
            Me.Height = 402
            Me.LabelTip.Text = "关于"
            Me.ToolStripButton2.Enabled = False
            Me.ToolStripProgressBar1.Visible = False
            Me.ToolStripButton2.Visible = True
            Me.ToolStripSplitButton1.Visible = False
        End If
        If Me.TabControl1.SelectedIndex <> 2 Then
            Me.Width = 523
            Me.TabControl1.Width = 507
            Me.ToolStripButton4.Visible = False
            Me.ToolStripButton5.Visible = False
            Me.ToolStripButton5.Enabled = False
            Me.ToolStripProgressBar1.Visible = False
            Me.ToolStripButton4.Enabled = False
            ToolStripLabel1.Visible = False
        End If
    End Sub

    Private Sub NumericUpDown1_GotFocus(sender As Object, e As EventArgs) Handles NumericUpDown1.GotFocus
        LabelTip.Text = "设置重复次数 1 - 300 "
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Call restartchange()
    End Sub

    Private Sub restartchange()
        Dim num, ok As Integer
        Dim cs As String = "Msgbox(" & """" & TextBox5.Text & """" & "," & ComboBox4.Text & "+" & ComboBox5.Text & "," & """" & TextBox7.Text & """" & ")"
        num = NumericUpDown1.Value
        ok = 0
        TextBox10.Text = "'对话框生成器生成代码 (LC)No.0043" & vbNewLine
        TextBox10.Text += "'如果有换行内容，请在换行处添加 "" & vbNewLine & ""。" & vbNewLine
        TextBox10.Text += "Dim Times As Integer = " & num & vbNewLine
        TextBox10.Text += "Dim Now As Integer = 0" & vbNewLine
        TextBox10.Text += "Do" & vbNewLine
        TextBox10.Text += " Now = Now + 1" & vbNewLine
        TextBox10.Text += " " & cs & vbNewLine
        TextBox10.Text += "Loop Until(Now = Times)"
    End Sub

    Private Sub TabControl2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl2.SelectedIndexChanged
        Me.ToolStripLabel3.Visible = False
        Me.ToolStripLabel2.Visible = False
        Me.ToolStripButton5.Visible = True
        If Me.TabControl2.SelectedIndex = 2 Then
            Me.ToolStripButton2.Enabled = True
            Me.ToolStripButton2.Visible = True
            Me.ToolStripButton4.Visible = True
            Me.ToolStripButton4.Enabled = True
            Me.ToolStripButton5.Enabled = False
            Me.ToolStripSplitButton1.Visible = False
            Call restartchange()
        ElseIf Me.TabControl2.SelectedIndex = 0 Then
            Me.ToolStripButton2.Enabled = True
            Me.ToolStripButton2.Visible = True
            Me.ToolStripSplitButton1.Visible = False
            Me.ToolStripButton4.Visible = True
            Me.ToolStripButton4.Enabled = True
            Me.ToolStripButton5.Enabled = False
            Me.ToolStripProgressBar1.Visible = False
            ToolStripLabel1.Visible = False
        ElseIf Me.TabControl2.SelectedIndex = 1 Then
            Me.ToolStripButton2.Enabled = False
            Me.ToolStripButton4.Visible = True
            Me.ToolStripButton2.Visible = True
            Me.ToolStripButton4.Enabled = True
            Me.ToolStripProgressBar1.Visible = False
            ToolStripLabel1.Visible = False
            Me.ToolStripSplitButton1.Visible = False
            If Me.ComboBox3.Text = "" Then
                Me.ToolStripButton5.Enabled = False
            Else
                Me.ToolStripButton5.Enabled = True
            End If
            Call changezxm()
        ElseIf Me.TabControl2.SelectedIndex = 3 Then
            Me.ToolStripButton2.Visible = False
            Me.ToolStripButton4.Enabled = False
            Me.ToolStripButton5.Enabled = False
            Me.ToolStripSplitButton1.Visible = True
        ElseIf TabControl2.SelectedIndex = 4 Then
            Me.ToolStripButton2.Enabled = True
            Me.ToolStripButton2.Visible = True
            Me.ToolStripButton5.Enabled = False
            Me.ToolStripProgressBar1.Visible = False
            Me.ToolStripButton4.Enabled = False
            ToolStripLabel1.Visible = False
            Me.ToolStripProgressBar1.Visible = False
            ToolStripLabel1.Visible = False
            Me.ToolStripSplitButton1.Visible = False
        End If
    End Sub

    Private Sub changezxm()
        If Me.CheckBox1.Checked = False Then
            Call CHANGE()
        Else
            Call CHANGERESTART()
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Call changezxm()
    End Sub

    Private Sub CHANGERESTART()
        If ComboBox3.Text = "vbs" Then
            Dim num, ok As Integer
            Dim csvbs As String = "msgbox " & """" & TextBox5.Text & """" & "," & ComboBox4.Text & "+" & ComboBox5.Text & "," & """" & TextBox7.Text & """"
            num = NumericUpDown1.Value
            ok = 0
            TextBox8.Text = "'对话框生成器重复执行器生成代码 (LC) No.0043" & vbNewLine
            TextBox8.Text += "for i = 1 to " & num & vbNewLine
            TextBox8.Text += vbTab & csvbs & vbNewLine
            TextBox8.Text += "next"
            If Me.TextBox5.TextLength > 1024 And Me.TextBox5.Lines.Length > 1 Then
                Me.ToolStripLabel2.Visible = True
                Me.ToolStripLabel3.Visible = False
                Me.ToolStripLabel2.ToolTipText = "错误信息：03 " & vbNewLine & "内容长度超过 1024 个字符，可能会导致内容显示不完全。" & vbNewLine & "错误信息：04" & vbNewLine & "内容有换行，会导致可执行码命令错误。"
            ElseIf Me.TextBox5.TextLength > 1024 Then
                Me.ToolStripLabel2.Visible = True
                Me.ToolStripLabel3.Visible = False
                Me.ToolStripLabel2.ToolTipText = "错误信息：04 " & vbNewLine & "内容长度超过 1024 个字符，可能会导致内容显示不完全。"
            ElseIf Me.TextBox5.Lines.Length > 1 Then
                Me.ToolStripLabel2.Visible = True
                Me.ToolStripLabel3.Visible = False
                Me.ToolStripLabel2.ToolTipText = "错误信息：02" & vbNewLine & "内容有换行，会导致可执行码命令错误。"
            Else
                Me.ToolStripLabel3.Visible = True
                Me.ToolStripLabel2.Visible = False
            End If
        ElseIf ComboBox3.Text = "bat" Then
            Dim num, ok As Integer
            Dim csbat As String = "mshta vbscript:" & "Msgbox(" & """" & TextBox5.Text & """" & "," & ComboBox4.Text & "+" & ComboBox5.Text & "," & """" & TextBox7.Text & """" & ")" & "(window.close)"
            num = NumericUpDown1.Value
            ok = 0
                    TextBox8.Text = ""
                    TextBox8.Text += "@echo off" & vbNewLine
                    TextBox8.Text += "::对话框生成器重复执行器生成代码" & vbNewLine
                    TextBox8.Text += "::Li Copyright(LC) 2014-2015 ,All Rights Reserved." & vbNewLine
                    TextBox8.Text += "::(LC)No.0043" & vbNewLine
                    TextBox8.Text += "set a=0" & vbNewLine
                    TextBox8.Text += "set b=" & num & vbNewLine
                    TextBox8.Text += "set c=0" & vbNewLine
                    TextBox8.Text += ":0" & vbNewLine
                    TextBox8.Text += "cls" & vbNewLine
                    TextBox8.Text += "echo 对话框生成器重复执行器生成代码 (LC)No.0043" & vbNewLine
                    TextBox8.Text += "set/a a = %a%+1" & vbNewLine
                    TextBox8.Text += "set/a c = %b%-%a%" & vbNewLine
                    TextBox8.Text += "TITLE 正在进行：%a% 个，还剩：%c% 个" & vbNewLine
                    TextBox8.Text += "echo 运行状态：" & vbNewLine
                    TextBox8.Text += "echo 正在进行：%a% 个，还剩：%c% 个" & vbNewLine
                    TextBox8.Text += csbat & vbNewLine
                    TextBox8.Text += "if %c% LEQ 0 (goto 1) else (goto 0)" & vbNewLine
                    TextBox8.Text += "goto 0" & vbNewLine
                    TextBox8.Text += ":1" & vbNewLine
                    TextBox8.Text += "cls" & vbNewLine
                    TextBox8.Text += "echo 对话框生成器重复执行器生成代码 (LC)No.0043" & vbNewLine
                    TextBox8.Text += "echo 运行状态：" & vbNewLine
                    TextBox8.Text += "echo 重复执行结束" & vbNewLine
                    TextBox8.Text += "TITLE 重复执行结束" & vbNewLine
                    TextBox8.Text += "pause" & vbNewLine
            If Me.TextBox5.TextLength > 1024 And Me.TextBox5.Lines.Length > 1 Then
                Me.ToolStripLabel2.Visible = True
                Me.ToolStripLabel3.Visible = False
                Me.ToolStripLabel2.ToolTipText = "错误信息：01 " & vbNewLine & "内容长度超过 1024 个字符，可能会导致转化的可执行码无法执行命令。" & vbNewLine & "错误信息：02" & vbNewLine & "内容有换行，会导致可执行码执行命令失败。"
            ElseIf Me.TextBox5.TextLength > 1024 Then
                Me.ToolStripLabel2.Visible = True
                Me.ToolStripLabel3.Visible = False
                Me.ToolStripLabel2.ToolTipText = "错误信息：01 " & vbNewLine & "内容长度超过 1024 个字符，可能会导致转化的可执行码无法执行命令。"
            ElseIf Me.TextBox5.Lines.Length > 1 Then
                Me.ToolStripLabel2.Visible = True
                Me.ToolStripLabel3.Visible = False
                Me.ToolStripLabel2.ToolTipText = "错误信息：02" & vbNewLine & "内容有换行，会导致可执行码执行命令失败。"
            Else
                Me.ToolStripLabel3.Visible = True
                Me.ToolStripLabel2.Visible = False
            End If
        End If
    End Sub

    Private Sub TextBox8_GotFocus(sender As Object, e As EventArgs) Handles TextBox8.GotFocus
        LabelTip.Text = "可执行码"
    End Sub

    Private Sub CheckBox1_GotFocus(sender As Object, e As EventArgs) Handles CheckBox1.GotFocus
        LabelTip.Text = "是否使用重复执行数据。"
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        If Me.TabControl2.SelectedIndex = 0 Then
            Dim cs As String = "Msgbox(" & """" & TextBox5.Text & """" & "," & ComboBox4.Text & "+" & ComboBox5.Text & "," & """" & TextBox7.Text & """" & ")"
            My.Computer.Clipboard.SetText(cs, TextDataFormat.UnicodeText)
            LabelTip.Text = "复制 vb.net 代码成功"
        ElseIf Me.TabControl2.SelectedIndex = 1 Then
            My.Computer.Clipboard.SetText(TextBox8.Text, TextDataFormat.UnicodeText)
            If Me.CheckBox1.Checked = True Then
                LabelTip.Text = "复制" & " " & ComboBox3.Text & " " & "代码成功(重复执行)"
            Else
                LabelTip.Text = "复制" & " " & ComboBox3.Text & " " & "代码成功"
            End If
        ElseIf Me.TabControl2.SelectedIndex = 2 Then
            My.Computer.Clipboard.SetText(TextBox10.Text, TextDataFormat.UnicodeText)
            LabelTip.Text = "复制 vb.net 代码成功(重复执行)"
        End If
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        If Me.ComboBox3.Text = "vbs" Then
            SaveFileDialog1.Filter = "Visual Basic Script文件(*.vbs)|*.vbs"
            SaveFileDialog1.InitialDirectory = Application.StartupPath
            SaveFileDialog1.ShowDialog()
            If (SaveFileDialog1.FileName <> "") Then
                RichTextBox1.Text = Me.TextBox8.Text
                RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
                RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
            End If
        ElseIf Me.ComboBox3.Text = "bat" Then
            SaveFileDialog1.Filter = "Windows 批处理文件(*.bat)|*.bat"
            SaveFileDialog1.InitialDirectory = Application.StartupPath
            SaveFileDialog1.ShowDialog()
            If (SaveFileDialog1.FileName <> "") Then
                RichTextBox1.Text = Me.TextBox8.Text
                RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
                RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
            End If
        End If
    End Sub

    Private Sub CheckNumN()
        Dim result As Integer = Val(LabelResult.Text)
        If result = 1 Then
            ToolStripLabel1.Visible = True
            LabelTip.Text = "返回值为 1 （确定）。"
            ToolStripLabel1.Text = "确定"
        ElseIf result = 2 Then
            ToolStripLabel1.Visible = True
            LabelTip.Text = "返回值为 2 （取消）。"
            ToolStripLabel1.Text = "取消"
        ElseIf result = 3 Then
            ToolStripLabel1.Visible = True
            LabelTip.Text = "返回值为 3 （中止）。"
            ToolStripLabel1.Text = "中止"
        ElseIf result = 4 Then
            ToolStripLabel1.Visible = True
            LabelTip.Text = "返回值为 4 （重试）。"
            ToolStripLabel1.Text = "重试"
        ElseIf result = 5 Then
            ToolStripLabel1.Visible = True
            LabelTip.Text = "返回值为 5 （忽略）。"
            ToolStripLabel1.Text = "忽略"
        ElseIf result = 6 Then
            ToolStripLabel1.Visible = True
            LabelTip.Text = "返回值为 6 （是）。"
            ToolStripLabel1.Text = "是"
        ElseIf result = 7 Then
            ToolStripLabel1.Visible = True
            LabelTip.Text = "返回值为 7 （否）。"
            ToolStripLabel1.Text = "否"
        Else
            ToolStripLabel1.Visible = True
            LabelTip.Text = "返回值无法识别 。"
            ToolStripLabel1.Text = "<未知>"
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim title, mode, say As String
        If Me.ListBox1.SelectedIndex = 0 Then
            Me.ListBox2.SelectedItem = Nothing
            title = "内存错误"
            mode = "预设"
            say = "假冒的 Windows 错误之一——内存错误。(LC)2013-2015."
            Me.Label24.Text = title
            Me.Label25.Text = mode
            Me.TextBox12.Text = say
        ElseIf Me.ListBox1.SelectedIndex = 1 Then
            Me.ListBox2.SelectedItem = Nothing
            title = "致命错误"
            mode = "预设"
            say = "假冒的 Windows 错误之二—— Win C++ Library Error。(LC)2013-2015."
            Me.Label24.Text = title
            Me.Label25.Text = mode
            Me.TextBox12.Text = say
        ElseIf Me.ListBox1.SelectedIndex = 2 Then
            Me.ListBox2.SelectedItem = Nothing
            title = "关机威胁"
            mode = "预设"
            say = "中国政府恶搞之一—— 关机威胁。(LC)2013-2015."
            Me.Label24.Text = title
            Me.Label25.Text = mode
            Me.TextBox12.Text = say
        ElseIf Me.ListBox1.SelectedIndex = 3 Then
            Me.ListBox2.SelectedItem = Nothing
            title = "欠债威胁"
            mode = "预设"
            say = "中国政府恶搞之二—— 欠债威胁。(LC)2013-2015."
            Me.Label24.Text = title
            Me.Label25.Text = mode
            Me.TextBox12.Text = say
        ElseIf Me.ListBox1.SelectedIndex = 4 Then
            Me.ListBox2.SelectedItem = Nothing
            title = "关机威胁"
            mode = "预设"
            say = "Windows AI —— 笨蛋提示。(LC)2013-2015."
            Me.Label24.Text = title
            Me.Label25.Text = mode
            Me.TextBox12.Text = say
        ElseIf Me.ListBox1.SelectedIndex = 5 Then
            Me.ListBox2.SelectedItem = Nothing
            title = "超级巨大"
            mode = "预设"
            say = "此预设谨慎使用！！！！！！:-D(LC)2015."
            Me.Label24.Text = title
            Me.Label25.Text = mode
            Me.TextBox12.Text = say
        End If
        If Me.ListBox1.SelectedItem <> Nothing Then
            Me.ToolStripSplitButton1.Enabled = True
            Me.载入ToolStripMenuItem.Enabled = True
            Me.修改FToolStripMenuItem.Enabled = False
            Me.说明SToolStripMenuItem.Enabled = False
            Me.删除DToolStripMenuItem.Enabled = False
            LabelTip.Text = "预设"
        End If
        TextBox12.ReadOnly = True
        Button4.Visible = False
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        If Me.ListBox2.SelectedIndex = 0 Then
            Me.ListBox1.SelectedItem = Nothing
            Me.Label24.Text = My.Settings.M1T
            Me.Label25.Text = "自定义"
            Me.TextBox12.Text = My.Settings.M1S
        ElseIf Me.ListBox2.SelectedIndex = 1 Then
            Me.ListBox1.SelectedItem = Nothing
            Me.Label24.Text = My.Settings.M2T
            Me.Label25.Text = "自定义"
            Me.TextBox12.Text = My.Settings.M2S
        ElseIf Me.ListBox2.SelectedIndex = 2 Then
            Me.ListBox1.SelectedItem = Nothing
            Me.Label24.Text = My.Settings.M3T
            Me.Label25.Text = "自定义"
            Me.TextBox12.Text = My.Settings.M3S
        ElseIf Me.ListBox2.SelectedIndex = 3 Then
            Me.ListBox1.SelectedItem = Nothing
            Me.Label24.Text = My.Settings.M4T
            Me.Label25.Text = "自定义"
            Me.TextBox12.Text = My.Settings.M4S
        ElseIf Me.ListBox2.SelectedIndex = 4 Then
            Me.ListBox1.SelectedItem = Nothing
            Me.Label24.Text = My.Settings.M5T
            Me.Label25.Text = "自定义"
            Me.TextBox12.Text = My.Settings.M5S
        ElseIf Me.ListBox2.SelectedIndex = 5 Then
            Me.ListBox1.SelectedItem = Nothing
            Me.Label24.Text = My.Settings.M6T
            Me.Label25.Text = "自定义"
            Me.TextBox12.Text = My.Settings.M6S
        End If
        If Me.ListBox2.SelectedItem <> Nothing Then
            Me.ToolStripSplitButton1.Enabled = True
            Me.载入ToolStripMenuItem.Enabled = True
            Me.修改FToolStripMenuItem.Enabled = True
            Me.说明SToolStripMenuItem.Enabled = True
            Me.删除DToolStripMenuItem.Enabled = True
            LabelTip.Text = "自定义"
        End If
        TextBox12.ReadOnly = True
        Button4.Visible = False
    End Sub

    Private Sub ButtonLoad_Click(sender As Object, e As EventArgs)
        Call loadbutton()
    End Sub

    Private Sub loadbutton()
        If Me.ListBox1.SelectedIndex = 0 Then
            Me.TextBox7.Text = "DDE Sever Window:iexplore.exe - 应用程序错误"
            Me.ComboBox4.Text = 16
            Me.ComboBox5.Text = 1
            Me.TextBox5.Text = "0x7eaf9883指令引用的0x02043a98内存。该内存不能为read。" & vbNewLine & "要终止程序，请单击 确定 。" & vbNewLine & "要调试程序，请单击 取消 。"
            LabelTip.Text = "载入成功"
            Me.TabControl2.SelectedIndex = 0
        ElseIf Me.ListBox1.SelectedIndex = 1 Then
            Me.TextBox7.Text = "Microsoft Visual C++ Runtime Library"
            Me.ComboBox4.Text = 16
            Me.ComboBox5.Text = 0
            Me.TextBox5.Text = "Runtime Error!" & vbNewLine & "Program:C:\windows\system32\rundll32.exe" & vbNewLine & "This application has requested the Runtime to terminate it in an unusual way." & vbNewLine & "Please contrat the application's support team for more information."
            LabelTip.Text = "载入成功"
            Me.TabControl2.SelectedIndex = 0
        ElseIf Me.ListBox1.SelectedIndex = 2 Then
            Me.TextBox7.Text = "中华人民共和国计算机技术管理中心"
            Me.ComboBox4.Text = 16
            Me.ComboBox5.Text = 0
            Me.TextBox5.Text = "因为您的错误操作，造成中华人民共和国计算机技术管理中心必须对您进行惩罚，您的计算机将在 90 秒内关闭。"
            LabelTip.Text = "载入成功"
            Me.TabControl2.SelectedIndex = 0
        ElseIf Me.ListBox1.SelectedIndex = 3 Then
            Me.TextBox7.Text = "中华人民共和国税务总局"
            Me.ComboBox4.Text = 48
            Me.ComboBox5.Text = 0
            Me.TextBox5.Text = "对不起，我们查询您的账户共欠债 10000000000000000000 美元（USB），因为您的账户欠债过多，您将会被封杀。"
            LabelTip.Text = "载入成功"
            Me.TabControl2.SelectedIndex = 0
        ElseIf Me.ListBox1.SelectedIndex = 4 Then
            Me.TextBox7.Text = "Windows AI"
            Me.ComboBox4.Text = 64
            Me.ComboBox5.Text = 0
            Me.TextBox5.Text = "You are a bendan，you should eat naocanpian."
            LabelTip.Text = "载入成功"
            Me.TabControl2.SelectedIndex = 0
        ElseIf Me.ListBox1.SelectedIndex = 5 Then
            Me.TextBox7.Text = "Windows AI"
            Me.ComboBox4.Text = 0
            Me.ComboBox5.Text = 0
            Me.TextBox5.Text = "哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈"
            LabelTip.Text = "载入成功"
            Me.TabControl2.SelectedIndex = 0
        End If
        If Me.ListBox2.SelectedIndex = 0 Then
            Me.TextBox7.Text = My.Settings.M1T
            Me.ComboBox4.Text = My.Settings.M1M1
            Me.ComboBox5.Text = My.Settings.M1M2
            Me.TextBox5.Text = My.Settings.M1P
            LabelTip.Text = "载入成功"
            Me.TabControl2.SelectedIndex = 0
        ElseIf Me.ListBox2.SelectedIndex = 1 Then
            Me.TextBox7.Text = My.Settings.M2T
            Me.ComboBox4.Text = My.Settings.M2M1
            Me.ComboBox5.Text = My.Settings.M2M2
            Me.TextBox5.Text = My.Settings.M2P
            LabelTip.Text = "载入成功"
            Me.TabControl2.SelectedIndex = 0
        ElseIf Me.ListBox2.SelectedIndex = 2 Then
            Me.TextBox7.Text = My.Settings.M3T
            Me.ComboBox4.Text = My.Settings.M3M1
            Me.ComboBox5.Text = My.Settings.M3M2
            Me.TextBox5.Text = My.Settings.M3P
            LabelTip.Text = "载入成功"
            Me.TabControl2.SelectedIndex = 0
        ElseIf Me.ListBox2.SelectedIndex = 3 Then
            Me.TextBox7.Text = My.Settings.M4T
            Me.ComboBox4.Text = My.Settings.M4M1
            Me.ComboBox5.Text = My.Settings.M4M2
            Me.TextBox5.Text = My.Settings.M4P
            LabelTip.Text = "载入成功"
            Me.TabControl2.SelectedIndex = 0
        ElseIf Me.ListBox2.SelectedIndex = 4 Then
            Me.TextBox7.Text = My.Settings.M5T
            Me.ComboBox4.Text = My.Settings.M5M1
            Me.ComboBox5.Text = My.Settings.M5M2
            Me.TextBox5.Text = My.Settings.M5P
            LabelTip.Text = "载入成功"
            Me.TabControl2.SelectedIndex = 0
        ElseIf Me.ListBox2.SelectedIndex = 5 Then
            Me.TextBox7.Text = My.Settings.M6T
            Me.ComboBox4.Text = My.Settings.M6M1
            Me.ComboBox5.Text = My.Settings.M6M2
            Me.TextBox5.Text = My.Settings.M6P
            LabelTip.Text = "载入成功"
            Me.TabControl2.SelectedIndex = 0
        End If
    End Sub
    Private Sub listbox2load()
        Me.ListBox2.Items.Clear()
        Me.ListBox2.Items.Add(My.Settings.M1T)
        Me.ListBox2.Items.Add(My.Settings.M2T)
        Me.ListBox2.Items.Add(My.Settings.M3T)
        Me.ListBox2.Items.Add(My.Settings.M4T)
        Me.ListBox2.Items.Add(My.Settings.M5T)
        Me.ListBox2.Items.Add(My.Settings.M6T)
    End Sub

    Private Sub ButtonFix_Click(sender As Object, e As EventArgs)
        Call fixbutton()
    End Sub

    Private Sub fixbutton()
        If Me.ListBox2.SelectedIndex = 0 Then
            My.Settings.M1T = Me.TextBox7.Text
            My.Settings.M1M1 = Me.ComboBox4.Text
            My.Settings.M1M2 = Me.ComboBox5.Text
            My.Settings.M1P = Me.TextBox5.Text
        ElseIf Me.ListBox2.SelectedIndex = 1 Then
            My.Settings.M2T = Me.TextBox7.Text
            My.Settings.M2M1 = Me.ComboBox4.Text
            My.Settings.M2M2 = Me.ComboBox5.Text
            My.Settings.M2P = Me.TextBox5.Text
        ElseIf Me.ListBox2.SelectedIndex = 2 Then
            My.Settings.M3T = Me.TextBox7.Text
            My.Settings.M3M1 = Me.ComboBox4.Text
            My.Settings.M3M2 = Me.ComboBox5.Text
            My.Settings.M3P = Me.TextBox5.Text
        ElseIf Me.ListBox2.SelectedIndex = 3 Then
            My.Settings.M4T = Me.TextBox7.Text
            My.Settings.M4M1 = Me.ComboBox4.Text
            My.Settings.M4M2 = Me.ComboBox5.Text
            My.Settings.M4P = Me.TextBox5.Text
        ElseIf Me.ListBox2.SelectedIndex = 4 Then
            My.Settings.M5T = Me.TextBox7.Text
            My.Settings.M5M1 = Me.ComboBox4.Text
            My.Settings.M5M2 = Me.ComboBox5.Text
            My.Settings.M5P = Me.TextBox5.Text
        ElseIf Me.ListBox2.SelectedIndex = 5 Then
            My.Settings.M6T = Me.TextBox7.Text
            My.Settings.M6M1 = Me.ComboBox4.Text
            My.Settings.M6M2 = Me.ComboBox5.Text
            My.Settings.M6P = Me.TextBox5.Text
        End If
        Call listbox2load()
    End Sub
    Private Sub ButtonSay_Click(sender As Object, e As EventArgs)
        Call saybutton()
    End Sub

    Private Sub saybutton()
        TextBox12.ReadOnly = False
        Button4.Visible = True
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ListBox2.SelectedIndex = 0 Then
            My.Settings.M1S = Me.TextBox12.Text
            TextBox12.ReadOnly = True
            Button4.Visible = False
        ElseIf ListBox2.SelectedIndex = 1 Then
            My.Settings.M2S = Me.TextBox12.Text
            TextBox12.ReadOnly = True
            Button4.Visible = False
        ElseIf ListBox2.SelectedIndex = 2 Then
            My.Settings.M3S = Me.TextBox12.Text
            TextBox12.ReadOnly = True
            Button4.Visible = False
        ElseIf ListBox2.SelectedIndex = 3 Then
            My.Settings.M4S = Me.TextBox12.Text
            TextBox12.ReadOnly = True
            Button4.Visible = False
        ElseIf ListBox2.SelectedIndex = 4 Then
            My.Settings.M5S = Me.TextBox12.Text
            TextBox12.ReadOnly = True
            Button4.Visible = False
        ElseIf ListBox2.SelectedIndex = 5 Then
            My.Settings.M6S = Me.TextBox12.Text
            TextBox12.ReadOnly = True
            Button4.Visible = False
        End If
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs)
        Call deletebutton()
    End Sub

    Private Sub deletebutton()
        If Me.ListBox2.SelectedIndex = 0 Then
            My.Settings.M1T = "<空>"
            My.Settings.M1M1 = 0
            My.Settings.M1M2 = 0
            My.Settings.M1P = "<空>"
            My.Settings.M1S = "<空>"
        ElseIf Me.ListBox2.SelectedIndex = 1 Then
            My.Settings.M2T = "<空>"
            My.Settings.M2M1 = 0
            My.Settings.M2M2 = 0
            My.Settings.M2P = "<空>"
            My.Settings.M2S = "<空>"
        ElseIf Me.ListBox2.SelectedIndex = 2 Then
            My.Settings.M3T = "<空>"
            My.Settings.M3M1 = 0
            My.Settings.M3M2 = 0
            My.Settings.M3P = "<空>"
            My.Settings.M3S = "<空>"
        ElseIf Me.ListBox2.SelectedIndex = 3 Then
            My.Settings.M4T = "<空>"
            My.Settings.M4M1 = 0
            My.Settings.M4M2 = 0
            My.Settings.M4P = "<空>"
            My.Settings.M4S = "<空>"
        ElseIf Me.ListBox2.SelectedIndex = 4 Then
            My.Settings.M5T = "<空>"
            My.Settings.M5M1 = 0
            My.Settings.M5M2 = 0
            My.Settings.M5P = "<空>"
            My.Settings.M5S = "<空>"
        ElseIf Me.ListBox2.SelectedIndex = 5 Then
            My.Settings.M6T = "<空>"
            My.Settings.M6M1 = 0
            My.Settings.M6M2 = 0
            My.Settings.M6P = "<空>"
            My.Settings.M6S = "<空>"
        End If
        Call listbox2load()
    End Sub


    Private Sub ToolStripSplitButton1_ButtonClick(sender As Object, e As EventArgs) Handles ToolStripSplitButton1.ButtonClick
        Call loadbutton()
    End Sub

    Private Sub 载入ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 载入ToolStripMenuItem.Click
        Call loadbutton()
    End Sub

    Private Sub 修改FToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 修改FToolStripMenuItem.Click
        Call fixbutton()
    End Sub

    Private Sub 说明SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 说明SToolStripMenuItem.Click
        Call saybutton()
    End Sub

    Private Sub 删除DToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 删除DToolStripMenuItem.Click
        Call deletebutton()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        RichTextBox1.Text = TextBox8.Text
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If PictureHelp1.Visible = True Then
            PictureHelp2.Visible = True
            PictureHelp1.Visible = False
            Button5.Enabled = True
        ElseIf PictureHelp2.Visible = True Then
            PictureHelp3.Visible = True
            PictureHelp2.Visible = False
        ElseIf Me.PictureHelp3.Visible = True Then
            PictureHelp4.Visible = True
            PictureHelp3.Visible = False
        ElseIf Me.PictureHelp4.Visible = True Then
            PictureHelp5.Visible = True
            PictureHelp4.Visible = False
        ElseIf Me.PictureHelp5.Visible = True Then
            PictureHelp6.Visible = True
            PictureHelp5.Visible = False
            Me.Button6.Enabled = False
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If PictureHelp6.Visible = True Then
            PictureHelp5.Visible = True
            PictureHelp6.Visible = False
            Button6.Enabled = True
        ElseIf PictureHelp5.Visible = True Then
            PictureHelp4.Visible = True
            PictureHelp5.Visible = False
        ElseIf Me.PictureHelp4.Visible = True Then
            PictureHelp3.Visible = True
            PictureHelp4.Visible = False
        ElseIf Me.PictureHelp3.Visible = True Then
            PictureHelp2.Visible = True
            PictureHelp3.Visible = False
        ElseIf Me.PictureHelp2.Visible = True Then
            PictureHelp1.Visible = True
            PictureHelp2.Visible = False
            Me.Button5.Enabled = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Button7.Enabled = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        TabControl2.SelectedIndex = 2
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        Select Case CheckBox3.Checked
            Case True
                GroupBox6.Enabled = True
            Case Else
                GroupBox6.Enabled = False
        End Select
        Button7.Enabled = True
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        Timer1.Interval = Me.NumericUpDown2.Value
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ok = num Then
            TextBox11.Text += TimeOfDay & "  " & "重复执行结束。包含多重存在。" & vbNewLine
            LabelTip.Text = "重复执行结束。包含多重存在。"
            Me.Text = "对话框生成器"
            Me.StatusStrip1.BackColor = Color.DodgerBlue
            Me.Show()
            Timer1.Stop()
        Else
            ok = ok + 1
            TextBox11.Text += TimeOfDay & "  " & "已经显示第 " & ok & " 个对话框，还剩 " & (num - ok) & " 个对话框。" & vbNewLine
            LabelTip.Text = "已经显示第 " & ok & " 个对话框，还剩 " & (num - ok) & " 个对话框。"
            Me.ToolStripProgressBar1.PerformStep()
            Dim result As Integer = MsgBox(TextBox5.Text, Val(ComboBox4.Text) + Val(ComboBox5.Text), TextBox7.Text)
            If result = 1 Then
                ToolStripLabel1.Visible = True
                TextBox11.Text += TimeOfDay & "  " & "返回值为 1 （确定）。" & vbNewLine
                ToolStripLabel1.Text = "确定"
            ElseIf result = 2 Then
                ToolStripLabel1.Visible = True
                TextBox11.Text += TimeOfDay & "  " & "返回值为 2 （取消）。" & vbNewLine
                ToolStripLabel1.Text = "取消"
            ElseIf result = 3 Then
                ToolStripLabel1.Visible = True
                TextBox11.Text += TimeOfDay & "  " & "返回值为 3 （中止）。" & vbNewLine
                ToolStripLabel1.Text = "中止"
            ElseIf result = 4 Then
                ToolStripLabel1.Visible = True
                TextBox11.Text += TimeOfDay & "  " & "返回值为 4 （重试）。" & vbNewLine
                ToolStripLabel1.Text = "重试"
            ElseIf result = 5 Then
                ToolStripLabel1.Visible = True
                TextBox11.Text += TimeOfDay & "  " & "返回值为 5 （忽略）。" & vbNewLine
                ToolStripLabel1.Text = "忽略"
            ElseIf result = 6 Then
                ToolStripLabel1.Visible = True
                TextBox11.Text += TimeOfDay & "  " & "返回值为 6 （是）。" & vbNewLine
                ToolStripLabel1.Text = "是"
            ElseIf result = 7 Then
                ToolStripLabel1.Visible = True
                TextBox11.Text += TimeOfDay & "  " & "返回值为 7 （否）。" & vbNewLine
                ToolStripLabel1.Text = "否"
            Else
                ToolStripLabel1.Visible = True
                TextBox11.Text += TimeOfDay & "  " & "返回值无法识别 。" & vbNewLine
                ToolStripLabel1.Text = "<未知>"
            End If
            TextBox11.ScrollToCaret()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Select Case CheckBox2.Checked
            Case True
                My.Settings.MinStart = True
            Case Else
                My.Settings.MinStart = False
        End Select
        Select Case CheckBox3.Checked
            Case True
                My.Settings.MoreVis = True
            Case Else
                My.Settings.MoreVis = False
        End Select
        My.Settings.VisInterval = NumericUpDown2.Value
        LabelTip.Text = "保存鬼畜设置成功。"
        Button7.Enabled = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Call Test()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            System.Diagnostics.Process.Start("https://github.com/LogCreative/DialogCreator")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        a = 0
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If a = 50 Then
            Timer2.Stop()
        Else
            a = a + 1
            MsgBox("2.6.0 鬼畜模式 鬼畜 哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈", 16 + 0, "对话框生成器")
        End If
    End Sub
End Class
