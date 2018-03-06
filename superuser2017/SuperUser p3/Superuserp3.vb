Imports System.Environment
Public Class Superuserp4
    Dim DriveLetter
    Dim appData As String = GetFolderPath(SpecialFolder.ApplicationData)


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Process.Start(DriveLetter & ":\Windows\System32\taskmgr.exe")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Process.Start(DriveLetter & ":\Windows\regedit.exe")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Process.Start(DriveLetter & ":\Windows\System32\cmd.exe")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Process.Start(DriveLetter & ":\Windows\System32\control.exe")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Shell("shutdown -s")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Shell("shutdown -l")
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Shell("shutdown -r")
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("you really think i'd code this!?",
            vbCritical,
            "HAHA Trolled")


    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Process.Start(DriveLetter & ":\Windows\System32\eventvwr.exe")
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Process.Start(DriveLetter & ":\Windows\System32\devmgmt.msc")
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Process.Start(DriveLetter & ":\Windows\System32\dxdiag.exe")
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Process.Start(DriveLetter & ":\Windows\System32\msinfo32.exe")
    End Sub

    Private Sub Superuserp3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Process.Start(DriveLetter & ":\Windows\System32\WindowsPowerShell\v1.0\powershell.exe")
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Process.Start(DriveLetter & ":\Windows\System32\winver.exe")
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Process.Start(DriveLetter & ":\Windows\System32\services.msc")
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Process.Start(DriveLetter & ":\Windows\System32\compmgmt.msc")
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Process.Start(DriveLetter & ":\Windows\System32\cleanmgr.exe")
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        MsgBox("Made By Reece's Puffs. Now on GitHub", vbOKOnly, "Version: 3.2 Alpha")
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        DriveLetter = TextBox1.Text
    End Sub


    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Shell("shutdown -r -o")
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Process.Start(DriveLetter & ":\windows\explorer.exe", appData)
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Shell("shutdown -a")
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        System.Diagnostics.Process.Start("control.exe", "system")
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Try
            If IO.Directory.Exists(DriveLetter & ":\windows") Then
                MsgBox(DriveLetter & ": Drive is a Thing :D", vbOKOnly, "Our Service Says:")
            Else
                MsgBox(DriveLetter & ": Drive is Not a Thing D:", vbOKOnly, "Our Service Says:")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
