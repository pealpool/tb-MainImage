<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.打开图片ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.取消置顶ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.显示边框ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.宝贝页主图ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.搜索页网格800800ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.直通车宝贝ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.直通车店铺ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.首页钻展ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.搜索页列表8080ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.确定ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ByHHFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关闭ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = Global.tb_MainImage.My.Resources.Resources.TBImg
        Me.PictureBox1.InitialImage = Global.tb_MainImage.My.Resources.Resources.TBImg
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(220, 220)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.打开图片ToolStripMenuItem, Me.取消置顶ToolStripMenuItem, Me.显示边框ToolStripMenuItem, Me.ToolStripMenuItem1, Me.宝贝页主图ToolStripMenuItem, Me.搜索页网格800800ToolStripMenuItem, Me.直通车宝贝ToolStripMenuItem, Me.直通车店铺ToolStripMenuItem, Me.首页钻展ToolStripMenuItem, Me.搜索页列表8080ToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripTextBox1, Me.ToolStripTextBox2, Me.确定ToolStripMenuItem, Me.ToolStripMenuItem3, Me.ByHHFToolStripMenuItem, Me.关闭ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(192, 358)
        '
        '打开图片ToolStripMenuItem
        '
        Me.打开图片ToolStripMenuItem.Name = "打开图片ToolStripMenuItem"
        Me.打开图片ToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.打开图片ToolStripMenuItem.Text = "打开图片"
        '
        '取消置顶ToolStripMenuItem
        '
        Me.取消置顶ToolStripMenuItem.Name = "取消置顶ToolStripMenuItem"
        Me.取消置顶ToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.取消置顶ToolStripMenuItem.Text = "取消置顶"
        '
        '显示边框ToolStripMenuItem
        '
        Me.显示边框ToolStripMenuItem.Name = "显示边框ToolStripMenuItem"
        Me.显示边框ToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.显示边框ToolStripMenuItem.Text = "显示边框"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(188, 6)
        '
        '宝贝页主图ToolStripMenuItem
        '
        Me.宝贝页主图ToolStripMenuItem.Name = "宝贝页主图ToolStripMenuItem"
        Me.宝贝页主图ToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.宝贝页主图ToolStripMenuItem.Text = "宝贝页主图(400*400)"
        '
        '搜索页网格800800ToolStripMenuItem
        '
        Me.搜索页网格800800ToolStripMenuItem.Name = "搜索页网格800800ToolStripMenuItem"
        Me.搜索页网格800800ToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.搜索页网格800800ToolStripMenuItem.Text = "搜索页网格(220*220)"
        '
        '直通车宝贝ToolStripMenuItem
        '
        Me.直通车宝贝ToolStripMenuItem.Name = "直通车宝贝ToolStripMenuItem"
        Me.直通车宝贝ToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.直通车宝贝ToolStripMenuItem.Text = "直通车宝贝(240*240)"
        '
        '直通车店铺ToolStripMenuItem
        '
        Me.直通车店铺ToolStripMenuItem.Name = "直通车店铺ToolStripMenuItem"
        Me.直通车店铺ToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.直通车店铺ToolStripMenuItem.Text = "直通车店铺(219*327)"
        '
        '首页钻展ToolStripMenuItem
        '
        Me.首页钻展ToolStripMenuItem.Name = "首页钻展ToolStripMenuItem"
        Me.首页钻展ToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.首页钻展ToolStripMenuItem.Text = "首页钻展(520*280)"
        '
        '搜索页列表8080ToolStripMenuItem
        '
        Me.搜索页列表8080ToolStripMenuItem.Name = "搜索页列表8080ToolStripMenuItem"
        Me.搜索页列表8080ToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.搜索页列表8080ToolStripMenuItem.Text = "搜索页列表(80*80)"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(188, 6)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripTextBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox1.Text = "自定义宽度"
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripTextBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox2.Text = "自定义高度"
        '
        '确定ToolStripMenuItem
        '
        Me.确定ToolStripMenuItem.Name = "确定ToolStripMenuItem"
        Me.确定ToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.确定ToolStripMenuItem.Text = "确定"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(188, 6)
        '
        'ByHHFToolStripMenuItem
        '
        Me.ByHHFToolStripMenuItem.Name = "ByHHFToolStripMenuItem"
        Me.ByHHFToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ByHHFToolStripMenuItem.Text = "By HHF 2016.12"
        '
        '关闭ToolStripMenuItem
        '
        Me.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem"
        Me.关闭ToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.关闭ToolStripMenuItem.Text = "关闭软件"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(204, 181)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents 关闭ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 打开图片ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 取消置顶ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 显示边框ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents 宝贝页主图ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 搜索页网格800800ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 直通车宝贝ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 直通车店铺ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 首页钻展ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 搜索页列表8080ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripTextBox2 As ToolStripTextBox
    Friend WithEvents 确定ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents ByHHFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
