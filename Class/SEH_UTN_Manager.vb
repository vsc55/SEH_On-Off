Imports System.IO
Imports System.Diagnostics
Imports Microsoft.VisualBasic.ApplicationServices
Imports Newtonsoft.Json.Linq
Imports Microsoft.SqlServer
Imports Newtonsoft.Json.Serialization
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions

Public Class SEH_UTN_Manager

    Public Property AppPath As String

    Public Sub New()
        Me.New("C:\Program Files\SEH Computertechnik GmbH\SEH UTN Manager\utnm.exe")
    End Sub
    Public Sub New(sAppPath As String)
        Me.AppPath = sAppPath
    End Sub

    Public ReadOnly Property IsInstalled() As Boolean
        Get
            Return IO.File.Exists(Me.AppPath)
        End Get
    End Property

    Public Function connect(ByRef oUSBPort As USB_Port) As Boolean
        Return Me.Connect(oUSBPort.IP, oUSBPort.Number)
    End Function
    Public Function Connect(ByVal sIP As String, ByVal sUSBPort As Integer) As Boolean
        Dim cmd As String = $"/c ""activate {sIP} {sUSBPort}"""
        Dim returnRun = RunUTNM(cmd)

        Console.WriteLine("ExitCode: " & returnRun.ExitCode)
        Console.WriteLine(returnRun.Out)

        Select Case returnRun.ExitCode
            Case 0
                Return True
            Case Else
                Return False
        End Select
    End Function


    Public Function DisConnect(ByRef oUSBPort As USB_Port) As Boolean
        Return Me.DisConnect(oUSBPort.IP, oUSBPort.Number)
    End Function
    Public Function DisConnect(ByVal sIP As String, ByVal sUSBPort As Integer) As Boolean
        Dim cmd As String = $"/c ""deactivate {sIP} {sUSBPort}"""
        Dim returnRun = RunUTNM(cmd)

        Console.WriteLine("ExitCode: " & returnRun.ExitCode)
        Console.WriteLine(returnRun.Out)

        Select Case returnRun.ExitCode
            Case 0
                Return True
            Case Else
                Return False
        End Select
    End Function


    Public Function GetStatus(ByRef oUSBPort As USB_Port) As Boolean
        Return Me.GetStatus(oUSBPort.IP, oUSBPort.Number)
    End Function
    Public Function GetStatus(ByVal sIP As String, ByVal sUSBPort As Integer) As Boolean
        Dim cmd As String = $"/c ""state {sIP} {sUSBPort}"""
        Dim returnRun = RunUTNM(cmd)

        Console.WriteLine("ExitCode: " & returnRun.ExitCode)
        Console.WriteLine(returnRun.Out)

        Select Case returnRun.ExitCode
            Case 0
                Return True
            Case Else
                MsgBox(returnRun.Out, MsgBoxStyle.Exclamation, $"Error ({returnRun.ExitCode})")
                Return False
        End Select
    End Function


    Public Function RunUTNM(ByVal sCommand As String) As (ExitCode As Integer, Out As String)

        ' "C:\Program Files\SEH Computertechnik GmbH\SEH UTN Manager\utnm.exe" /c "activate 192.168.0.32 1"
        ' "C:\Program Files\SEH Computertechnik GmbH\SEH UTN Manager\utnm.exe" /c "deactivate 192.168.0.32 1"
        ' "C:\Program Files\SEH Computertechnik GmbH\SEH UTN Manager\utnm.exe" /c "state 192.168.0.32 1"
        '
        'Return     Value Description
        '0          The command was executed successfully.
        '20         Activation failed.
        '21         Deactivation failed.
        '23         Is already activated.
        '24         Is already deactivated Or Not available.
        '25         Activation failed: Another user has activated the USB port incl. device.
        '26         Not found: There Is no device connected to the USB port Or the USB port key (manual page 76) Is missing Or wrong.
        '29         Not found: No USB device with this VID And PID connected.
        '30         Isochronous USB devices are Not supported.
        '31         UTN driver error. Contact the SEH Computertechnik GmbH support (manual page 6).
        '40         No network connection to the UTN server.
        '41         An encrypted connection to UTN server cannot be established.
        '42         No connection to UTN service.
        '43         The DNS resolution failed.
        '44         Insufficient rights (administrative rights required).
        '47         This feature Is Not supported.
        '200        Error (with error code).

        If (Me.IsInstalled() = False) Then
            Return (500, "Not Installed App!")
            Return Nothing
        End If

        Dim proceso As New Process()
        Dim startInfo As New ProcessStartInfo With {
            .FileName = Me.AppPath,
            .Arguments = sCommand,
            .RedirectStandardOutput = True,
            .UseShellExecute = False,
            .CreateNoWindow = True
        }
        proceso.StartInfo = startInfo
        proceso.Start()

        Dim out As String = proceso.StandardOutput.ReadToEnd()

        proceso.WaitForExit()

        Return (proceso.ExitCode, out)
    End Function


    Public Function GetVersion() As String
        Dim cmd As String = "/v"
        Dim returnRun = RunUTNM(cmd)

        'Console.WriteLine("ExitCode: " & returnRun.ExitCode)
        'Console.WriteLine(returnRun.Out)

        Select Case returnRun.ExitCode
            Case 0
                Dim versionMatch As Match = Regex.Match(returnRun.Out, "Version (\d+\.\d+\.\d+)")
                If versionMatch.Success Then
                    Return versionMatch.Groups(1).Value
                Else
                    Return "Unknown"
                End If
            Case Else
                MsgBox(returnRun.Out, MsgBoxStyle.Exclamation, $"Error ({returnRun.ExitCode})")
                Return "Unknown"
        End Select

    End Function

End Class