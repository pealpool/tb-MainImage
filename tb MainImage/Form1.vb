Imports System.Text.RegularExpressions
Public Class Form1
    Private onon As Boolean = False
    Private Zxy As Point
    Private Mxy As Point
    Private Const zz1 = "\d*"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = 0
        Me.ClientSize = New Size(220, 220)
        PictureBox1.ContextMenuStrip = ContextMenuStrip1
        PictureBox1.AllowDrop = True
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        Me.onon = True
        Me.Zxy = New Point(e.X, e.Y)
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        Mxy = New Point(e.X, e.Y)
        If Me.onon = True Then
            Me.Location = PointToScreen(Mxy) - Me.Zxy
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        Me.onon = False
    End Sub

    Private Sub 关闭ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关闭ToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click
        ToolStripTextBox1.SelectAll()
    End Sub
    Private Sub ToolStripTextBox2_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox2.Click
        ToolStripTextBox2.SelectAll()
    End Sub

    Private Sub 确定ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 确定ToolStripMenuItem.Click
        Dim xx, yy As Long
        Dim m1 As Match = Regex.Match(ToolStripTextBox1.Text, zz1)
        Dim m2 As Match = Regex.Match(ToolStripTextBox2.Text, zz1)
        Dim gg1 As Group = m1.Groups(0)
        Dim gg2 As Group = m2.Groups(0)
        Dim ax, ay As Integer
        xx = Screen.PrimaryScreen.Bounds.Width.ToString
        yy = Screen.PrimaryScreen.Bounds.Height.ToString
        ax = gg1.ToString()
        ay = gg2.ToString()
        If ax > xx - 100 Then
            ax = xx - 100
            ToolStripTextBox1.Text = ax
        End If
        If ay > yy - 100 Then
            ay = yy - 100
            ToolStripTextBox2.Text = ax
        End If
    End Sub

    Private Sub changDX(DDDx As Integer, DDDy As Integer)
        Me.Width = DDDx
        Me.Height = DDDy
        PictureBox1.Width = DDDx
        PictureBox1.Height = DDDy
    End Sub

    Private Sub 宝贝页主图ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 宝贝页主图ToolStripMenuItem.Click
        changDX(400, 400)
    End Sub

    Private Sub 搜索页网格800800ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 搜索页网格800800ToolStripMenuItem.Click
        changDX(220, 220)
    End Sub

    Private Sub 直通车宝贝ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 直通车宝贝ToolStripMenuItem.Click
        changDX(240, 240)
    End Sub

    Private Sub 直通车店铺ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 直通车店铺ToolStripMenuItem.Click
        changDX(219, 327)
    End Sub

    Private Sub 首页钻展ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 首页钻展ToolStripMenuItem.Click
        changDX(520, 280)
    End Sub

    Private Sub 搜索页列表8080ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 搜索页列表8080ToolStripMenuItem.Click
        changDX(80, 80)
    End Sub

    Private Sub 取消置顶ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 取消置顶ToolStripMenuItem.Click
        If Me.TopMost = True Then
            Me.TopMost = False
            取消置顶ToolStripMenuItem.Text = "恢复置顶"
        Else
            Me.TopMost = True
            取消置顶ToolStripMenuItem.Text = "取消置顶"
        End If
    End Sub

    Private Sub 打开图片ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 打开图片ToolStripMenuItem.Click
        OpenFileDialog1.Filter = "图片(*.jpg)|*.jpg|png图像(*.png)|*.png|bmp图像(*.bmp)|*.bmp"
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.ShowDialog()
        Try
            Dim m_image As Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox1.Image = m_image
        Catch ex As Exception
            MsgBox("没有选择正确的图片")
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
        Catch ex As Exception
        End Try

    End Sub

    Private Sub PictureBox1_DragEnter(sender As Object, e As DragEventArgs) Handles PictureBox1.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub 显示边框ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 显示边框ToolStripMenuItem.Click
        If FormBorderStyle = 0 Then
            FormBorderStyle = 1
            显示边框ToolStripMenuItem.Text = "隐藏边框"
        Else
            FormBorderStyle = 0
            显示边框ToolStripMenuItem.Text = "显示边框"
        End If
    End Sub
End Class
