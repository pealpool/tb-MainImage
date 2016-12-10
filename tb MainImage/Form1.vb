﻿Imports System.Text.RegularExpressions
Public Class Form1
    'Private onon As Boolean = False
    'Private Zxy As Point
    'Private Mxy As Point
    'Private Const zz1 = "\d*"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'FormBorderStyle = 0
        'Me.ClientSize = New Size(220, 220)
        PictureBox1.ContextMenuStrip = ContextMenuStrip1
        PictureBox1.AllowDrop = True
    End Sub

    'Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
    '    Me.onon = True
    '    Me.Zxy = New Point(e.X, e.Y)
    'End Sub

    'Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
    '    Mxy = New Point(e.X, e.Y)
    '    If Me.onon = True Then
    '        Me.Location = PointToScreen(Mxy) - Me.Zxy
    '        'Me.Location = Control.MousePosition - Me.Zxy
    '    End If
    'End Sub

    'Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
    '    Me.onon = False
    'End Sub


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
        'Dim ax, ay As Integer
        'ax = ToolStripTextBox1.Text
        'ay = ToolStripTextBox2.Text
        If IsNumeric(ToolStripTextBox1.Text) And IsNumeric(ToolStripTextBox2.Text) Then
            ChangDX(ToolStripTextBox1.Text, ToolStripTextBox2.Text)
        Else
            MsgBox("请重新输入数值", 0, "提示")
        End If
    End Sub

    Private Sub ChangDX(DDDx As Integer, DDDy As Integer)
        Me.Width = DDDx
        Me.Height = DDDy
    End Sub

    Private Sub BbztToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BbztToolStripMenuItem.Click
        ChangDX(400, 400)
    End Sub

    Private Sub SsywgToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SSywgToolStripMenuItem.Click
        ChangDX(220, 220)
    End Sub

    Private Sub ZtcbbToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZtcbbToolStripMenuItem.Click
        ChangDX(240, 240)
    End Sub

    Private Sub ZtcdpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZtcdpToolStripMenuItem.Click
        ChangDX(219, 327)
    End Sub

    Private Sub SyzzToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SyzzToolStripMenuItem.Click
        ChangDX(520, 280)
    End Sub

    Private Sub SsylbToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SSylbToolStripMenuItem.Click
        ChangDX(80, 80)
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
        Catch ex As Exception
            MsgBox("没有选择正确的图片", 0, "提示")
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
            PictureBox1.Image = bkimage
            If PictureBox1.Image.Height = PictureBox1.Image.Width Then
                Me.Height = 220
                Me.Width = 220
            ElseIf PictureBox1.Image.Height = 327 And PictureBox1.Image.Width = 219 Then
                Me.Height = 327
                Me.Width = 219
            ElseIf PictureBox1.Image.Height = 280 And PictureBox1.Image.Width = 520 Then
                Me.Height = 280
                Me.Width = 520
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
        Else
            If e.Delta > 0 Then
                Me.Top += 1
            Else
                Me.Top -= 1
            End If
        End If
    End Sub

    Private Sub ByHHFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ByHHFToolStripMenuItem.Click
        MsgBox("▶ [　双击　]　　　　匹配原图大小" & vbCrLf & "▶ [鼠标滚轮]　　　　微调 上下" & vbCrLf & "▶ [Ctrl + 鼠标滚轮]　微调 左右" & vbCrLf & vbCrLf & "By HHF v2016.12", 0, "关于 主图检视 By HHF")
    End Sub

    Private Sub PptpdxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PptpdxToolStripMenuItem.Click
        Me.Width = PictureBox1.Image.Width
        Me.Height = PictureBox1.Image.Height
    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        Me.Width = PictureBox1.Image.Width
        Me.Height = PictureBox1.Image.Height
    End Sub
End Class
