Imports Newtonsoft.Json

Public Class USB_Port

    Public Property ID As Guid
    Public Property Name As String
    Public Property Number As Integer
    Public Property IP As String

    <JsonIgnore>
    Public Property Status As Boolean

    Public Sub New()
        Me.New("", 0, False)
    End Sub

    Public Sub New(ByVal sIP As String, ByVal iNum As Integer, Optional ByVal bStatus As Boolean = False)
        Me.ID = Guid.NewGuid()
        Me.IP = sIP
        Me.Number = iNum
        Me.Status = bStatus
    End Sub

End Class
