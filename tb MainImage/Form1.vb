Imports System.Drawing.Imaging
Imports System.Text.RegularExpressions
Public Class Form1
    Private GiveIm As Boolean = True
    Private Lun As Integer = 3

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormFade("in")  '打开主程序界面时的效果    
        PictureBox1.ContextMenuStrip = ContextMenuStrip1
        PictureBox1.AllowDrop = True
    End Sub

    Declare Auto Function ReleaseCapture Lib "user32.dll" Alias "ReleaseCapture" () As Boolean
    'API ReleaseCapture函数是用来释放鼠标捕获的  
    Declare Auto Function SendMessage Lib "user32.dll" Alias "SendMessage" (ByVal hWnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As IntPtr
    '向windows发送消息  
    Public Const WM_SYSCOMMAND As Integer = &H112&
    Public Const SC_MOVE As Integer = &HF010&
    Public Const HTCAPTION As Integer = &H2&

    Private Sub PictureBox1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0)
        End If
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        If GiveIm Then
            PictureBox1.Image = Global.tb_MainImage.My.Resources.TBImgg
        End If
        Select Case Me.Height
            Case 400
                If Me.Width = 400 Then
                    ToolTip1.SetToolTip(PictureBox1, "淘宝主图(400*400)")
                End If
            Case 418
                If Me.Width = 418 Then
                    ToolTip1.SetToolTip(PictureBox1, "天猫主图(418*418)")
                End If
            Case 220
                If Me.Width = 220 Then
                    ToolTip1.SetToolTip(PictureBox1, "淘宝网格(220*220)")
                End If
            Case 210
                If Me.Width = 210 Then
                    ToolTip1.SetToolTip(PictureBox1, "天猫网格(210*210)")
                End If
            Case 315
                If Me.Width = 210 Then
                    ToolTip1.SetToolTip(PictureBox1, "直通车店铺(210*315)")
                End If
            Case 240
                If Me.Width = 240 Then
                    ToolTip1.SetToolTip(PictureBox1, "直通车宝贝(240*240)")
                End If
            Case 270
                If Me.Width = 270 Then
                    ToolTip1.SetToolTip(PictureBox1, "直通车宝贝(270*270)")
                End If
            Case 375
                If Me.Width = 250 Then
                    ToolTip1.SetToolTip(PictureBox1, "直通车店铺(250*375)")
                End If
            Case 280
                If Me.Width = 520 Then
                    ToolTip1.SetToolTip(PictureBox1, "首页钻展(520*280)")
                End If
            Case 80
                If Me.Width = 80 Then
                    ToolTip1.SetToolTip(PictureBox1, "搜索页列表(80*80)")
                End If
            Case Else
                ToolTip1.SetToolTip(PictureBox1, "自定义大小(" & Me.Width & "*" & Me.Height & ")")
        End Select
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        If GiveIm Then
            PictureBox1.Image = Global.tb_MainImage.My.Resources.TBImg
        End If
    End Sub

    Private Sub GbToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GbToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click
        ToolStripTextBox1.SelectAll()
    End Sub
    Private Sub ToolStripTextBox2_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox2.Click
        ToolStripTextBox2.SelectAll()
    End Sub

    Private Sub QdToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QdToolStripMenuItem.Click
        Qd()
    End Sub

    Private Sub ToolStripTextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStripTextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Qd()
            ContextMenuStrip1.Close()
        End If
    End Sub

    Private Sub ToolStripTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Qd()
            ContextMenuStrip1.Close()
        End If
    End Sub

    Private Sub Qd()
        If IsNumeric(ToolStripTextBox1.Text) And IsNumeric(ToolStripTextBox2.Text) Then
            If ToolStripTextBox1.Text >= 16 And ToolStripTextBox2.Text >= 16 Then
                ChangeDX(ToolStripTextBox1.Text, ToolStripTextBox2.Text)
            Else
                MsgBox("整这么小，玩儿啊？", MsgBoxStyle.SystemModal, "提示")
            End If
        Else
            MsgBox("请重新输入数值", MsgBoxStyle.SystemModal, "提示")
        End If
    End Sub

    Private Sub TbztToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TbztToolStripMenuItem.Click
        ChangeDX(400, 400)
        Lun = 1
    End Sub

    Private Sub TmztToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TmztToolStripMenuItem.Click
        ChangeDX(418, 418)
        Lun = 2
    End Sub

    Private Sub TbwgToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TbwgToolStripMenuItem.Click
        ChangeDX(220, 220)
        Lun = 3
    End Sub

    Private Sub TmwgToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TmwgToolStripMenuItem.Click
        ChangeDX(210, 210)
        Lun = 4
    End Sub

    Private Sub ZtcbbxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZtcbbxToolStripMenuItem.Click
        ChangeDX(240, 240)
        Lun = 5
    End Sub

    Private Sub ZtcbbdToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZtcbbdToolStripMenuItem.Click
        ChangeDX(270, 270)
        Lun = 6
    End Sub

    Private Sub ZtcdpxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZtcdpxToolStripMenuItem.Click
        ChangeDX(210, 315)
        Lun = 7
    End Sub

    Private Sub ZtcdpdToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZtcdpdToolStripMenuItem.Click
        ChangeDX(250, 375)
        Lun = 8
    End Sub

    Private Sub SyzzToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SyzzToolStripMenuItem.Click
        ChangeDX(520, 280)
        Lun = 9
    End Sub

    Private Sub SsylbToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SSylbToolStripMenuItem.Click
        ChangeDX(80, 80)
        Lun = 10
    End Sub

    Private Sub QxdzToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QxdzToolStripMenuItem.Click
        If Me.TopMost = True Then
            Me.TopMost = False
            QxdzToolStripMenuItem.Text = "置顶"
            QxdzToolStripMenuItem.Checked = False
        Else
            Me.TopMost = True
            QxdzToolStripMenuItem.Text = "置顶"
            QxdzToolStripMenuItem.Checked = True
        End If
    End Sub

    Private Sub DktpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DktpToolStripMenuItem.Click
        OpenFileDialog1.Filter = "图片(*.jpg)|*.jpg|png图像(*.png)|*.png|bmp图像(*.bmp)|*.bmp"
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.ShowDialog()
        Try
            Dim m_image As Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox1.Image = m_image
            GiveIm = False
        Catch ex As Exception
            MsgBox("没有选择正确的图片", MsgBoxStyle.SystemModal, "提示")
        End Try
    End Sub

    Private Sub PictureBox1_DragDrop(sender As Object, e As DragEventArgs) Handles PictureBox1.DragDrop
        'PictureBox1.Image = e.Data.GetData(DataFormats.Bitmap)
        Dim str_drop As Array
        Dim temostr As String
        Dim bkimage As Bitmap
        str_drop = e.Data.GetData(DataFormats.FileDrop, True)
        temostr = str_drop(0)
        Try
            bkimage = New Bitmap(temostr)
            'Me.Size = New System.Drawing.Size(bkimage.Width, bkimage.Height)
            If bkimage.Width >= 16 And bkimage.Height >= 16 Then
                PictureBox1.Image = bkimage
                GiveIm = False
                If PictureBox1.Image.Height = PictureBox1.Image.Width Then
                    ChangeDX(200, 200)
                    Lun = 3
                ElseIf (PictureBox1.Image.Height = 315 And PictureBox1.Image.Width = 210) Or (PictureBox1.Image.Height = 375 And PictureBox1.Image.Width = 250) Then
                    ChangeDX(210, 315)
                    Lun = 7
                ElseIf PictureBox1.Image.Height = 280 And PictureBox1.Image.Width = 520 Then
                    ChangeDX(520, 280)
                    Lun = 9
                End If
            Else
                MsgBox("整这么小图片，玩儿啊？", MsgBoxStyle.SystemModal, "提示")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PictureBox1_DragEnter(sender As Object, e As DragEventArgs) Handles PictureBox1.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub XsbkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XsbgToolStripMenuItem.Click
        If FormBorderStyle = 0 Then
            XsbgToolStripMenuItem.Text = "显示拉伸边框"
            XsbgToolStripMenuItem.Checked = True
            FormBorderStyle = 4
        Else
            XsbgToolStripMenuItem.Text = "显示拉伸边框"
            FormBorderStyle = 0
            XsbgToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub PictureBox1_MouseWheel(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseWheel
        If ModifierKeys = Keys.Control Then
            If e.Delta > 0 Then
                Me.Left += 1
            Else
                Me.Left -= 1
            End If
        ElseIf ModifierKeys = Keys.Shift Then
            If e.Delta < 0 Then
                If Lun >= 10 Then
                    Lun = 1
                Else
                    Lun += 1
                End If
                SetDX(Lun)
            Else
                If Lun <= 1 Then
                    Lun = 10
                Else
                    Lun -= 1
                End If
                SetDX(Lun)
            End If
        Else
            If e.Delta < 0 Then
                Me.Top += 1
            Else
                Me.Top -= 1
            End If
        End If
    End Sub

    Private Sub CleanC()
        TbztToolStripMenuItem.Checked = False
        TmztToolStripMenuItem.Checked = False
        TbwgToolStripMenuItem.Checked = False
        TmwgToolStripMenuItem.Checked = False
        ZtcbbxToolStripMenuItem.Checked = False
        ZtcbbdToolStripMenuItem.Checked = False
        ZtcdpxToolStripMenuItem.Checked = False
        ZtcdpdToolStripMenuItem.Checked = False
        SyzzToolStripMenuItem.Checked = False
        SSylbToolStripMenuItem.Checked = False
    End Sub

    Private Sub SetDX(L As Integer)
        CleanC
        Select Case L
            Case 1
                ChangeDX(400, 400)
                TbztToolStripMenuItem.Checked = True
            Case 2
                ChangeDX(418, 418)
                TmztToolStripMenuItem.Checked = True
            Case 3
                ChangeDX(220, 220)
                TbwgToolStripMenuItem.Checked = True
            Case 4
                ChangeDX(210, 210)
                TmwgToolStripMenuItem.Checked = True
            Case 5
                ChangeDX(240, 240)
                ZtcbbxToolStripMenuItem.Checked = True
            Case 6
                ChangeDX(270, 270)
                ZtcbbdToolStripMenuItem.Checked = True
            Case 7
                ChangeDX(210, 315)
                ZtcdpxToolStripMenuItem.Checked = True
            Case 8
                ChangeDX(250, 375)
                ZtcdpdToolStripMenuItem.Checked = True
            Case 9
                ChangeDX(520, 280)
                SyzzToolStripMenuItem.Checked = True
            Case 10
                ChangeDX(80, 80)
                SSylbToolStripMenuItem.Checked = True
        End Select
    End Sub

    Private Sub ByHHFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ByHHFToolStripMenuItem.Click
        MsgBox("▶ [　双击　]　　　　匹配原图大小" & vbCrLf & "▶ [鼠标滚轮]　　　　微调 上下" & vbCrLf & "▶ [Ctrl + 鼠标滚轮]　微调 左右" & vbCrLf & "▶ [Shift + 鼠标滚轮]  选择大小" & vbCrLf & vbCrLf & "By HHF v2016.12", 0, "关于 主图检视 By HHF")
    End Sub

    Private Sub PptpdxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PptpdxToolStripMenuItem.Click
        Me.Width = PictureBox1.Image.Width
        Me.Height = PictureBox1.Image.Height
    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        ChangeDX(PictureBox1.Image.Width, PictureBox1.Image.Height)
    End Sub


    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        CleanC()
        Select Case Me.Height
            Case 400
                If Me.Width = 400 Then
                    TbztToolStripMenuItem.Checked = True
                End If
            Case 418
                If Me.Width = 418 Then
                    TmztToolStripMenuItem.Checked = True
                End If
            Case 220
                If Me.Width = 220 Then
                    TbwgToolStripMenuItem.Checked = True
                End If
            Case 210
                If Me.Width = 210 Then
                    TmwgToolStripMenuItem.Checked = True
                End If
            Case 315
                If Me.Width = 210 Then
                    ZtcdpxToolStripMenuItem.Checked = True
                End If
            Case 240
                If Me.Width = 240 Then
                    ZtcbbxToolStripMenuItem.Checked = True
                End If
            Case 270
                If Me.Width = 270 Then
                    ZtcbbdToolStripMenuItem.Checked = True
                End If
            Case 375
                If Me.Width = 250 Then
                    ZtcdpdToolStripMenuItem.Checked = True
                End If
            Case 280
                If Me.Width = 520 Then
                    SyzzToolStripMenuItem.Checked = True
                End If
            Case 80
                If Me.Width = 80 Then
                    SSylbToolStripMenuItem.Checked = True
                End If
        End Select
    End Sub

    Private Sub SeZiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeZiToolStripMenuItem.Click
        Form2.Show()
    End Sub


    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        FormFade("out")     '关闭主程序界面时的效果    
    End Sub

    Private Sub FormFade(ByVal FType)
        Select Case FType
            Case ("in")
                Dim FadeCount As Integer
                For FadeCount = 5 To 100 Step 5
                    Me.Opacity = FadeCount / 100
                    Me.Refresh()
                    Threading.Thread.Sleep(30)
                Next
                Me.Opacity = 100
            Case ("out")
                Dim FadeCount As Integer
                For FadeCount = 100 To 5 Step -5
                    Me.Opacity = FadeCount / 100
                    Me.Refresh()
                    Threading.Thread.Sleep(10)
                Next
                Me.Opacity = 0
        End Select
    End Sub

    Private Sub ChangeDX(w As Integer, h As Integer)
        Dim fiii As Integer
        Dim FiiiW, FiiiH As Double
        Dim fast As Integer = 8   '变化帧数
        Dim timeee As Double = 10 / fast
        FiiiW = Math.Abs(Me.Width - w) / fast
        FiiiH = Math.Abs(Me.Height - h) / fast
        For fiii = 0 To fast Step 1
            If Me.Width > w Or Me.Height > h Then
                Me.Width = Me.Width - FiiiW
                Me.Height = Me.Height - FiiiH
                If Me.Width < w Then
                    Me.Width = w
                End If
                If Me.Height < h Then
                    Me.Height = h
                End If
                Me.Refresh()
            End If
            If Me.Width < w Or Me.Height < h Then
                Me.Width = Me.Width + FiiiW
                Me.Height = Me.Height + FiiiH
                If Me.Width > w Then
                    Me.Width = w
                End If
                If Me.Height > h Then
                    Me.Height = h
                End If
                Me.Refresh()
            End If
            Threading.Thread.Sleep(timeee)
        Next
        Me.Width = w
        Me.Height = h
    End Sub

End Class
