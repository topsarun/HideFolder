Public Class Main
    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Integer)
    Private Sub Showfolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Showfolder.Click
        P1.Value = 0
        FileOpen(1, My.Application.Info.DirectoryPath & "\show.bat", OpenMode.Output)
        PrintLine(1, " " & drive.Text & ":")
        PrintLine(1, "cd " & path.Text)
        PrintLine(1, "ren " & folder.Text & ".{20D04FE0-3AEA-1069-A2D8-08002B30309D} " & folder.Text)
        PrintLine(1, "ren " & folder.Text & ".{2227A280-3AEA-1069-A2DE-08002B30309D} " & folder.Text)
        PrintLine(1, "ren " & folder.Text & ".{645FF040-5081-101B-9F08-00AA002F954E} " & folder.Text)
        PrintLine(1, "ren " & folder.Text & ".{208D2C60-3AEA-1069-A2D7-08002B30309D} " & folder.Text)
        FileClose(1)
        P1.Value = 25
        Shell(My.Application.Info.DirectoryPath & "\show.bat", AppWinStyle.Hide)
        P1.Value = 50
        Sleep(1000)
        P1.Value = 75
        Kill(My.Application.Info.DirectoryPath & "\show.bat")
        P1.Value = 100
        MsgBox("ขณะนี้ได้ทำการแสดงโฟวเดอร์ที่ซ่อนแล้ว.", vbOKOnly + vbInformation, "รายงานสถานะ")
    End Sub
    Private Sub HidetoMycom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HidetoMycom.Click
        P1.Value = 0
        FileOpen(1, My.Application.Info.DirectoryPath & "\hide.bat", OpenMode.Output)
        PrintLine(1, " " & drive.Text & ":")
        PrintLine(1, "cd " & path.Text)
        PrintLine(1, "ren " & folder.Text & " " & folder.Text & ".{20D04FE0-3AEA-1069-A2D8-08002B30309D}")
        FileClose(1)
        P1.Value = 25
        Shell(My.Application.Info.DirectoryPath & "\hide.bat", AppWinStyle.Hide)
        P1.Value = 50
        Sleep(1000)
        P1.Value = 75
        Kill(My.Application.Info.DirectoryPath & "\hide.bat")
        P1.Value = 100
        MsgBox("ขณะนี้ได้ทำการซ่อนโฟวเดอร์เป็น My Computer แล้ว.", vbOKOnly + vbInformation, "รายงานสถานะ")
    End Sub
    Private Sub HidetoPrinter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HidetoPrinter.Click
        P1.Value = 0
        FileOpen(1, My.Application.Info.DirectoryPath & "\hide.bat", OpenMode.Output)
        PrintLine(1, " " & drive.Text & ":")
        PrintLine(1, "cd " & path.Text)
        PrintLine(1, "ren " & folder.Text & " " & folder.Text & ".{2227A280-3AEA-1069-A2DE-08002B30309D}")
        FileClose(1)
        P1.Value = 25
        Shell(My.Application.Info.DirectoryPath & "\hide.bat", AppWinStyle.Hide)
        P1.Value = 50
        Sleep(1000)
        P1.Value = 75
        Kill(My.Application.Info.DirectoryPath & "\hide.bat")
        P1.Value = 100
        MsgBox("ขณะนี้ได้ทำการซ่อนโฟวเดอร์เป็น My Printer แล้ว.", vbOKOnly + vbInformation, "รายงานสถานะ")
    End Sub
    Private Sub HidetoBin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HidetoBin.Click
        P1.Value = 0
        FileOpen(1, My.Application.Info.DirectoryPath & "\hide.bat", OpenMode.Output)
        PrintLine(1, " " & drive.Text & ":")
        PrintLine(1, "cd " & path.Text)
        PrintLine(1, "ren " & folder.Text & " " & folder.Text & ".{645FF040-5081-101B-9F08-00AA002F954E}")
        FileClose(1)
        P1.Value = 25
        Shell(My.Application.Info.DirectoryPath & "\hide.bat", AppWinStyle.Hide)
        P1.Value = 50
        Sleep(1000)
        P1.Value = 75
        Kill(My.Application.Info.DirectoryPath & "\hide.bat")
        P1.Value = 100
        MsgBox("ขณะนี้ได้ทำการซ่อนโฟวเดอร์เป็น Recycle Bin แล้ว.", vbOKOnly + vbInformation, "รายงานสถานะ")
    End Sub
    Private Sub HidetoBinNetwork_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HidetoBinNetwork.Click
        P1.Value = 0
        FileOpen(1, My.Application.Info.DirectoryPath & "\hide.bat", OpenMode.Output)
        PrintLine(1, " " & drive.Text & ":")
        PrintLine(1, "cd " & path.Text)
        PrintLine(1, "ren " & folder.Text & " " & folder.Text & ".{208D2C60-3AEA-1069-A2D7-08002B30309D}")
        FileClose(1)
        P1.Value = 25
        Shell(My.Application.Info.DirectoryPath & "\hide.bat", AppWinStyle.Hide)
        P1.Value = 50
        Sleep(1000)
        P1.Value = 75
        Kill(My.Application.Info.DirectoryPath & "\hide.bat")
        P1.Value = 100
        MsgBox("ขณะนี้ได้ทำการซ่อนโฟวเดอร์เป็น My Network แล้ว.", vbOKOnly + vbInformation, "รายงานสถานะ")
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        Help.Show()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub UpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem.Click
        UpdateForm.Show()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        drive.Text = "C"
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        drive.Text = "D"
    End Sub
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        drive.Text = "E"
    End Sub
    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        drive.Text = "F"
    End Sub
    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        drive.Text = "G"
    End Sub
    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        drive.Text = "H"
    End Sub
    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        drive.Text = "I"
    End Sub
    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        drive.Text = "J"
    End Sub

    Private Sub AboutMeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutMeToolStripMenuItem1.Click
        Aboume.Show()
    End Sub
End Class
