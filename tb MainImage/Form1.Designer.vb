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
        Me.DktpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QxdzToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XsbgToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BbztToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SSywgToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZtcbbToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZtcdpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SyzzToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SSylbToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.PptpdxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.QdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ByHHFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.ErrorImage = Global.tb_MainImage.My.Resources.Resources.TBImgg
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
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DktpToolStripMenuItem, Me.QxdzToolStripMenuItem, Me.XsbgToolStripMenuItem, Me.ToolStripMenuItem1, Me.BbztToolStripMenuItem, Me.SSywgToolStripMenuItem, Me.ZtcbbToolStripMenuItem, Me.ZtcdpToolStripMenuItem, Me.SyzzToolStripMenuItem, Me.SSylbToolStripMenuItem, Me.ToolStripMenuItem4, Me.PptpdxToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripTextBox1, Me.ToolStripTextBox2, Me.QdToolStripMenuItem, Me.ToolStripMenuItem3, Me.ByHHFToolStripMenuItem, Me.GbToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(192, 364)
        '
        'DktpToolStripMenuItem
        '
        Me.DktpToolStripMenuItem.Name = "DktpToolStripMenuItem"
        Me.DktpToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.DktpToolStripMenuItem.Text = "打开图片"
        '
        'QxdzToolStripMenuItem
        '
        Me.QxdzToolStripMenuItem.Checked = True
        Me.QxdzToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.QxdzToolStripMenuItem.Name = "QxdzToolStripMenuItem"
        Me.QxdzToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.QxdzToolStripMenuItem.Text = "置顶"
        '
        'XsbgToolStripMenuItem
        '
        Me.XsbgToolStripMenuItem.Name = "XsbgToolStripMenuItem"
        Me.XsbgToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.XsbgToolStripMenuItem.Text = "显示拉伸边框"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(188, 6)
        '
        'BbztToolStripMenuItem
        '
        Me.BbztToolStripMenuItem.Name = "BbztToolStripMenuItem"
        Me.BbztToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.BbztToolStripMenuItem.Text = "宝贝页主图(400*400)"
        '
        'SSywgToolStripMenuItem
        '
        Me.SSywgToolStripMenuItem.Name = "SSywgToolStripMenuItem"
        Me.SSywgToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.SSywgToolStripMenuItem.Text = "搜索页网格(220*220)"
        '
        'ZtcbbToolStripMenuItem
        '
        Me.ZtcbbToolStripMenuItem.Name = "ZtcbbToolStripMenuItem"
        Me.ZtcbbToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ZtcbbToolStripMenuItem.Text = "直通车宝贝(240*240)"
        '
        'ZtcdpToolStripMenuItem
        '
        Me.ZtcdpToolStripMenuItem.Name = "ZtcdpToolStripMenuItem"
        Me.ZtcdpToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ZtcdpToolStripMenuItem.Text = "直通车店铺(219*327)"
        '
        'SyzzToolStripMenuItem
        '
        Me.SyzzToolStripMenuItem.Name = "SyzzToolStripMenuItem"
        Me.SyzzToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.SyzzToolStripMenuItem.Text = "首页钻展(520*280)"
        '
        'SSylbToolStripMenuItem
        '
        Me.SSylbToolStripMenuItem.Name = "SSylbToolStripMenuItem"
        Me.SSylbToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.SSylbToolStripMenuItem.Text = "搜索页列表(80*80)"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(188, 6)
        '
        'PptpdxToolStripMenuItem
        '
        Me.PptpdxToolStripMenuItem.Name = "PptpdxToolStripMenuItem"
        Me.PptpdxToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.PptpdxToolStripMenuItem.Text = "匹配图片大小"
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
        'QdToolStripMenuItem
        '
        Me.QdToolStripMenuItem.Name = "QdToolStripMenuItem"
        Me.QdToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.QdToolStripMenuItem.Text = "确定"
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
        Me.ByHHFToolStripMenuItem.Text = "By HHF v2016.12"
        '
        'GbToolStripMenuItem
        '
        Me.GbToolStripMenuItem.Name = "GbToolStripMenuItem"
        Me.GbToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.GbToolStripMenuItem.Text = "关闭"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(220, 220)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "主图检视"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents GbToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DktpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QxdzToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XsbgToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents BbztToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SSywgToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZtcbbToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZtcdpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SyzzToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SSylbToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripTextBox2 As ToolStripTextBox
    Friend WithEvents QdToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents ByHHFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents PptpdxToolStripMenuItem As ToolStripMenuItem
End Class
