Imports System.Environment
Public Class Superuserp4

    Dim DriveLetter
    Dim appDataloc As String = GetFolderPath(SpecialFolder.ApplicationData)
    Dim DriveIsValid = False
    Dim sitedl As String



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TaskManager.Click
        If DriveIsValid = True Then
            Process.Start(DriveLetter & ":\Windows\System32\taskmgr.exe")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Regedit.Click
        If DriveIsValid = True Then
            Process.Start(DriveLetter & ":\Windows\regedit.exe")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD.Click
        If DriveIsValid = True Then
            Process.Start(DriveLetter & ":\Windows\System32\cmd.exe")
        Else
            MsgBox("Please press Verify")
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControlPanel.Click
        If DriveIsValid = True Then
            Process.Start(DriveLetter & ":\Windows\System32\control.exe")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Shutdown.Click
        If DriveIsValid = True Then
            Shell("shutdown -s")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Logoff.Click
        If DriveIsValid = True Then
            Shell("shutdown -l")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Restart.Click
        If DriveIsValid = True Then
            Shell("shutdown -r")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("you really think i'd code this!?",
            vbCritical,
            "HAHA Trolled")


    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EventViewer.Click
        If DriveIsValid = True Then
            Process.Start(DriveLetter & ":\Windows\System32\eventvwr.exe")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeviceManager.Click
        If DriveIsValid = True Then
            Process.Start(DriveLetter & ":\Windows\System32\devmgmt.msc")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DirectXDiag.Click
        If DriveIsValid = True Then
            Process.Start(DriveLetter & ":\Windows\System32\dxdiag.exe")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MSinfo.Click
        If DriveIsValid = True Then
            Process.Start(DriveLetter & ":\Windows\System32\msinfo32.exe")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub Superuserp3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PowerShell.Click
        If DriveIsValid = True Then
            Process.Start(DriveLetter & ":\Windows\System32\WindowsPowerShell\v1.0\powershell.exe")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Winver.Click
        If DriveIsValid = True Then
            Process.Start(DriveLetter & ":\Windows\System32\winver.exe")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Services.Click
        If DriveIsValid = True Then
            Process.Start(DriveLetter & ":\Windows\System32\services.msc")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompMgmt.Click
        If DriveIsValid = True Then
            Process.Start(DriveLetter & ":\Windows\System32\compmgmt.msc")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeskCleanup.Click
        If DriveIsValid = True Then
            Process.Start(DriveLetter & ":\Windows\System32\cleanmgr.exe")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles About.Click
        sitedl = "https://github.com/ReecesPuffs/SuperUserWindows"
        MsgBox("Made By Reece's Puffs and digm0repaka, Beta Tested by barndon, Now on GitHub " & sitedl, vbOKOnly, "Version: 4.3.1")
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        DriveLetter = TextBox1.Text
    End Sub


    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SafeMode.Click
        If DriveIsValid = True Then
            Shell("shutdown -r -o")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Appdata.Click
        If DriveIsValid = True Then
            Process.Start(DriveLetter & ":\windows\explorer.exe", appDataloc)
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbortShutdown.Click
        If DriveIsValid = True Then
            Shell("shutdown -a")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        If DriveIsValid = True Then
            System.Diagnostics.Process.Start("control.exe", "system")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Verify.Click
        Try
            If IO.Directory.Exists(DriveLetter & ":\windows") Then
                MsgBox(DriveLetter & ": Drive is a Thing :D", vbOKOnly, "Our Service Says:")
                DriveIsValid = True
            Else
                MsgBox(DriveLetter & ": Drive is Not a Thing D:", vbOKOnly, "Our Service Says:")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub AppDefult_Click(sender As Object, e As EventArgs) Handles AppDefult.Click
        If DriveIsValid = True Then
            Process.Start(DriveLetter & ":\windows\System32\ComputerDefaults.exe")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub GroupPolicyEditor_Click(sender As Object, e As EventArgs) Handles GroupPolicyEditor.Click
        If DriveIsValid = True Then
            Process.Start(DriveLetter & ":\windows\System32\gpedit.msc")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub WinMobCentre_Click(sender As Object, e As EventArgs) Handles ResourceMonitor.Click
        If DriveIsValid = True Then
            Process.Start(DriveLetter & ":\windows\System32\resmon.exe")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub

    Private Sub AppWizard_Click(sender As Object, e As EventArgs) Handles AppWizard.Click
        If DriveIsValid = True Then
            Process.Start(DriveLetter & ":\windows\system32\appwiz.cpl")
        Else
            MsgBox("Please press Verify")
        End If
    End Sub
End Class