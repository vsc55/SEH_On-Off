Imports System.IO
Imports Newtonsoft.Json

Public Class Config

    Public Property portsUSB As List(Of USB_Port)

    <JsonIgnore>
    Public Property FileConfig As String


    Public Sub New()
        Me.New(Nothing)
    End Sub

    Public Sub New(sFile As String)
        portsUSB = New List(Of USB_Port)()

        If (IsNothing(sFile)) Then
            FileConfig = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json")
        Else
            FileConfig = sFile
        End If
    End Sub

    Public Sub AddPortUSB(port As USB_Port)
        portsUSB.Add(port)
    End Sub

    Public Sub SerializarJSON()
        Dim json As String = JsonConvert.SerializeObject(Me, Formatting.Indented)
        File.WriteAllText(FileConfig, json)
    End Sub

    Public Sub DeserializarJSON()
        Dim json As String = File.ReadAllText(FileConfig)
        Dim config As Config = JsonConvert.DeserializeObject(Of Config)(json)
        portsUSB = config.portsUSB
    End Sub

    Public Sub SetPuerto(idPort As Guid, numPort As Integer, bStatus As Boolean, Optional ByVal sIP As String = "")
        Dim portExist As USB_Port = portsUSB.FirstOrDefault(Function(p) p.ID = idPort)

        If portExist IsNot Nothing Then
            portExist.Status = bStatus
        Else
            Dim newPort As New USB_Port(sIP, numPort, bStatus)
            portsUSB.Add(newPort)
        End If
    End Sub

    Public Function GetPuerto(idPort As Guid) As Boolean
        Dim portExist As USB_Port = portsUSB.FirstOrDefault(Function(p) p.ID = idPort)

        If portExist IsNot Nothing Then
            Return portExist.Status
        Else
            Return False ' Puerto no encontrado, estado predeterminado
        End If
    End Function

End Class
