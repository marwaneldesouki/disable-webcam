Imports Cam_Disabled_By_Deso.My
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32
'made_with_love_by_deso
'@marwaneldesouki
Public Class Form1
    Dim Str = MyProject.Computer.Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Services\usbvideo").ToString()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyProject.Computer.Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Services\usbvideo\Start")
        Me.Label1.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue(Me.Str, "Start", "Error"))
        Dim flag As Boolean = Conversions.ToDouble(Me.Label1.Text) = 3.0
        If flag Then
            Label2.Text = "Status:You are already Enabled it"

            Button1.Text = "Disable It now"
        Else
            Label2.Text = "Status:You are already disabled it"
            Button1.Text = "Enable It now"
        End If
    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Disable It now" Then
            Registry.SetValue(Me.Str, "Start", 4, RegistryValueKind.DWord)
            MyProject.Computer.Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Services\USBSTOR\Start")
            Me.Label1.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue(Me.Str, "Start", "Error"))
            Dim flag As Boolean = Conversions.ToDouble(Me.Label1.Text) = 3.0
            Button1.Text = "Enable It now"
        Else

            Registry.SetValue(Me.Str, "Start", 3, RegistryValueKind.DWord)
            MyProject.Computer.Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Services\USBSTOR\Start")
            Me.Label1.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue(Me.Str, "Start", "Error"))
            Button1.Text = "Disable It now"

        End If

    End Sub
End Class
