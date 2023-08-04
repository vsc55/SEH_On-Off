Imports System.Drawing.Text
Imports System.Runtime.InteropServices
Imports Newtonsoft.Json.Converters
Imports Newtonsoft.Json.Serialization

Public Class frmKernel

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Timer1.Enabled = False

        If (AppRunSEH.IsInstalled() = False) Then
            MsgBox("The application 'SEH UTN Manager' was not detected, the application will be closed!", MsgBoxStyle.Information, "Error!")
            Me.Close()
        End If

        Me.Visible = False
    End Sub

    Private Sub Kernel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Timer1.Enabled = True
        Me.lVersion.Text = String.Format("Version: {0}", AppRunSEH.GetVersion())

        ' Crear servidores USB de ejemplo
        Dim port1 As New USB_Port With {
            .Name = "Cype",
            .Number = 5,
            .IP = "192.168.1.101",
            .Status = True
        }

        Dim port2 As New USB_Port With {
            .Name = "Cype2",
            .Number = 1,
            .IP = "192.168.1.101",
            .Status = False
        }


        ' Agregar servidores a la configuración
        configServers.AddPortUSB(port1)
        configServers.AddPortUSB(port2)

        ' Serializar la configuración en un archivo JSON
        configServers.SerializarJSON()



        '    ' Cargar la configuración desde un archivo JSON
        '    Dim configuracionCargada As Config = Config.DeserializarJSON()

        '    ' Prueba: Obtener el estado de un puerto en un servidor
        '    Dim idServidor As Guid = configuracionCargada.ServidoresUSB(0).ID
        '    Dim numeroPuerto As Integer = 2
        '    Dim estadoPuerto As Boolean = configuracionCargada.GetPuerto(idServidor, numeroPuerto)

        '    Console.WriteLine($"Estado del puerto {numeroPuerto} en el servidor {idServidor}: {estadoPuerto}")

        '    ' Prueba: Establecer o actualizar el estado de un puerto en un servidor
        '    Dim nuevoEstado As Boolean = Not estadoPuerto
        '    configuracionCargada.SetPuerto(idServidor, numeroPuerto, nuevoEstado)

        '    ' Serializar la configuración actualizada en el archivo JSON
        '    configuracionCargada.SerializarJSON()

        '    Console.WriteLine($"Nuevo estado del puerto {numeroPuerto} en el servidor {idServidor}: {nuevoEstado}")

        Call MostrarMenuContextual()
    End Sub




    Private Sub MostrarMenuContextual()

        ProgramasToolStripMenuItem.DropDownItems.Clear()

        For Each puerto As USB_Port In configServers.portsUSB
            Dim puertoMenuItem As New ToolStripMenuItem(puerto.Name)
            puertoMenuItem.Tag = puerto.ID

            Dim statusMenuItem As New ToolStripMenuItem("Status")
            statusMenuItem.Enabled = False ' No editable
            puertoMenuItem.DropDownItems.Add(statusMenuItem)

            Dim onMenuItem As New ToolStripMenuItem("On")
            onMenuItem.Checked = puerto.Status
            AddHandler onMenuItem.Click, Sub(sender, e) Me.ActualizarEstadoPuerto(puerto, True)
            puertoMenuItem.DropDownItems.Add(onMenuItem)

            Dim offMenuItem As New ToolStripMenuItem("Off")
            offMenuItem.Checked = Not puerto.Status
            AddHandler offMenuItem.Click, Sub(sender, e) Me.ActualizarEstadoPuerto(puerto, False)
            puertoMenuItem.DropDownItems.Add(offMenuItem)

            ProgramasToolStripMenuItem.DropDownItems.Add(puertoMenuItem)
        Next
    End Sub

    Private Sub ActualizarEstadoPuerto(puerto As USB_Port, nuevoEstado As Boolean)
        puerto.Status = nuevoEstado
        configServers.SerializarJSON()
        MostrarMenuContextual() ' Actualizar el menú
    End Sub


End Class
