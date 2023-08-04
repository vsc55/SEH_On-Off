<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kernel
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TryIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MenuTryIcon = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuTryIcon.SuspendLayout()
        Me.SuspendLayout()
        '
        'TryIcon
        '
        Me.TryIcon.ContextMenuStrip = Me.MenuTryIcon
        Me.TryIcon.Text = "NotifyIcon1"
        Me.TryIcon.Visible = True
        '
        'MenuTryIcon
        '
        Me.MenuTryIcon.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.MenuTryIcon.Name = "MenuTryIcon"
        Me.MenuTryIcon.Size = New System.Drawing.Size(97, 26)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'Kernel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 490)
        Me.Name = "Kernel"
        Me.Text = "Kernel"
        Me.MenuTryIcon.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TryIcon As NotifyIcon
    Friend WithEvents MenuTryIcon As ContextMenuStrip
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
