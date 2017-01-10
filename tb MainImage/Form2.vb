Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.TransparencyKey = SystemColors.Control Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub Button_Cannel_Click(sender As Object, e As EventArgs) Handles Button_Cannel.Click
        Me.Close()
    End Sub

    Private Sub Button_Set_Click(sender As Object, e As EventArgs) Handles Button_Set.Click
        If CheckBox1.Checked = False Then
            Form1.TransparencyKey = Color.Empty
        Else
            Form1.TransparencyKey = SystemColors.Control
        End If
        Me.Close()
    End Sub
End Class