<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button_Set = New System.Windows.Forms.Button()
        Me.Button_Cannel = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Button_Set
        '
        Me.Button_Set.Location = New System.Drawing.Point(68, 100)
        Me.Button_Set.Name = "Button_Set"
        Me.Button_Set.Size = New System.Drawing.Size(75, 23)
        Me.Button_Set.TabIndex = 0
        Me.Button_Set.Text = "确定"
        Me.Button_Set.UseVisualStyleBackColor = True
        '
        'Button_Cannel
        '
        Me.Button_Cannel.Location = New System.Drawing.Point(149, 100)
        Me.Button_Cannel.Name = "Button_Cannel"
        Me.Button_Cannel.Size = New System.Drawing.Size(75, 23)
        Me.Button_Cannel.TabIndex = 1
        Me.Button_Cannel.Text = "取消"
        Me.Button_Cannel.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 12)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(96, 16)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "png 图片透明"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(236, 135)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button_Cannel)
        Me.Controls.Add(Me.Button_Set)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "设置 - 主图检视"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Set As Button
    Friend WithEvents Button_Cannel As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
