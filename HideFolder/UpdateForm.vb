Imports System.Net
Public Class UpdateForm

    Private Sub Check_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Check.Click
        Dim Web As New WebClient
        Dim update As String = Web.DownloadString("https://dl.dropbox.com/u/9099190/HideFolder/version")
        If update.Contains(Application.ProductVersion) Then
            MsgBox("ไม่มีเวอร์ชันใหม่")
            Label4.Text = update
        Else
            MsgBox("มีเวอร์ชันใหม่ รับการอัพเดทได้ที่ Facebook")
            Label4.Text = update
        End If
    End Sub

    Private Sub UpdateForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = Application.ProductVersion
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        Help.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Hide()
    End Sub
End Class