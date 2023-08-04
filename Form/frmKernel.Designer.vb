<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKernel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKernel))
        Me.TryIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MenuTryIcon = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ProgramasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.OnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.sLoading = New System.Windows.Forms.Label()
        Me.lVersion = New System.Windows.Forms.Label()
        Me.MenuTryIcon.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TryIcon
        '
        Me.TryIcon.ContextMenuStrip = Me.MenuTryIcon
        Me.TryIcon.Icon = CType(resources.GetObject("TryIcon.Icon"), System.Drawing.Icon)
        Me.TryIcon.Text = "NotifyIcon1"
        Me.TryIcon.Visible = True
        '
        'MenuTryIcon
        '
        Me.MenuTryIcon.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramasToolStripMenuItem, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem})
        Me.MenuTryIcon.Name = "MenuTryIcon"
        Me.MenuTryIcon.Size = New System.Drawing.Size(132, 54)
        '
        'ProgramasToolStripMenuItem
        '
        Me.ProgramasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CypeToolStripMenuItem})
        Me.ProgramasToolStripMenuItem.Name = "ProgramasToolStripMenuItem"
        Me.ProgramasToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ProgramasToolStripMenuItem.Text = "&Programas"
        '
        'CypeToolStripMenuItem
        '
        Me.CypeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstadoToolStripMenuItem, Me.ToolStripSeparator2, Me.OnToolStripMenuItem, Me.OffToolStripMenuItem})
        Me.CypeToolStripMenuItem.Name = "CypeToolStripMenuItem"
        Me.CypeToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.CypeToolStripMenuItem.Text = "Cype"
        '
        'EstadoToolStripMenuItem
        '
        Me.EstadoToolStripMenuItem.Enabled = False
        Me.EstadoToolStripMenuItem.Name = "EstadoToolStripMenuItem"
        Me.EstadoToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.EstadoToolStripMenuItem.Text = "Estado: ?"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(117, 6)
        '
        'OnToolStripMenuItem
        '
        Me.OnToolStripMenuItem.Image = Global.SEH_On_Off.My.Resources.Resources.aceptar_verde_ok_si_icono_8925_16
        Me.OnToolStripMenuItem.Name = "OnToolStripMenuItem"
        Me.OnToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.OnToolStripMenuItem.Text = "On"
        '
        'OffToolStripMenuItem
        '
        Me.OffToolStripMenuItem.Name = "OffToolStripMenuItem"
        Me.OffToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.OffToolStripMenuItem.Text = "Off"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(128, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "checkok")
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lVersion)
        Me.Panel1.Controls.Add(Me.sLoading)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(381, 86)
        Me.Panel1.TabIndex = 1
        '
        'sLoading
        '
        Me.sLoading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sLoading.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sLoading.Location = New System.Drawing.Point(0, 0)
        Me.sLoading.Name = "sLoading"
        Me.sLoading.Size = New System.Drawing.Size(377, 82)
        Me.sLoading.TabIndex = 0
        Me.sLoading.Text = "Loading..."
        Me.sLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lVersion
        '
        Me.lVersion.BackColor = System.Drawing.Color.Transparent
        Me.lVersion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lVersion.Location = New System.Drawing.Point(0, 69)
        Me.lVersion.Name = "lVersion"
        Me.lVersion.Size = New System.Drawing.Size(377, 13)
        Me.lVersion.TabIndex = 1
        Me.lVersion.Text = "Version:"
        Me.lVersion.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'frmKernel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(381, 86)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmKernel"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kernel"
        Me.TopMost = True
        Me.MenuTryIcon.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TryIcon As NotifyIcon
    Friend WithEvents MenuTryIcon As ContextMenuStrip
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgramasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents OnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Panel1 As Panel
    Friend WithEvents sLoading As Label
    Friend WithEvents lVersion As Label
End Class
