<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.GPSalidas = New System.Windows.Forms.GroupBox()
        Me.TBcomisionventa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBcomisioncompra = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBparcialventa = New System.Windows.Forms.TextBox()
        Me.TBparcialcompra = New System.Windows.Forms.TextBox()
        Me.LBparcialcompra = New System.Windows.Forms.Label()
        Me.LBparcialventa = New System.Windows.Forms.Label()
        Me.LBtotal = New System.Windows.Forms.Label()
        Me.TBtotal = New System.Windows.Forms.TextBox()
        Me.BTregresar = New System.Windows.Forms.Button()
        Me.GPSalidas.SuspendLayout()
        Me.SuspendLayout()
        '
        'GPSalidas
        '
        Me.GPSalidas.Controls.Add(Me.TBtotal)
        Me.GPSalidas.Controls.Add(Me.LBtotal)
        Me.GPSalidas.Controls.Add(Me.TBcomisionventa)
        Me.GPSalidas.Controls.Add(Me.Label2)
        Me.GPSalidas.Controls.Add(Me.TBcomisioncompra)
        Me.GPSalidas.Controls.Add(Me.Label1)
        Me.GPSalidas.Controls.Add(Me.TBparcialventa)
        Me.GPSalidas.Controls.Add(Me.TBparcialcompra)
        Me.GPSalidas.Controls.Add(Me.LBparcialcompra)
        Me.GPSalidas.Controls.Add(Me.LBparcialventa)
        Me.GPSalidas.Location = New System.Drawing.Point(23, 33)
        Me.GPSalidas.Margin = New System.Windows.Forms.Padding(4)
        Me.GPSalidas.Name = "GPSalidas"
        Me.GPSalidas.Padding = New System.Windows.Forms.Padding(4)
        Me.GPSalidas.Size = New System.Drawing.Size(660, 312)
        Me.GPSalidas.TabIndex = 4
        Me.GPSalidas.TabStop = False
        Me.GPSalidas.Text = "Resulatados Transaccion"
        '
        'TBcomisionventa
        '
        Me.TBcomisionventa.Enabled = False
        Me.TBcomisionventa.Location = New System.Drawing.Point(264, 196)
        Me.TBcomisionventa.Margin = New System.Windows.Forms.Padding(4)
        Me.TBcomisionventa.Name = "TBcomisionventa"
        Me.TBcomisionventa.Size = New System.Drawing.Size(386, 29)
        Me.TBcomisionventa.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 196)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Comision Venta"
        '
        'TBcomisioncompra
        '
        Me.TBcomisioncompra.Enabled = False
        Me.TBcomisioncompra.Location = New System.Drawing.Point(264, 147)
        Me.TBcomisioncompra.Margin = New System.Windows.Forms.Padding(4)
        Me.TBcomisioncompra.Name = "TBcomisioncompra"
        Me.TBcomisioncompra.Size = New System.Drawing.Size(386, 29)
        Me.TBcomisioncompra.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 147)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Comision Compra"
        '
        'TBparcialventa
        '
        Me.TBparcialventa.Enabled = False
        Me.TBparcialventa.Location = New System.Drawing.Point(264, 94)
        Me.TBparcialventa.Margin = New System.Windows.Forms.Padding(4)
        Me.TBparcialventa.Name = "TBparcialventa"
        Me.TBparcialventa.Size = New System.Drawing.Size(386, 29)
        Me.TBparcialventa.TabIndex = 3
        '
        'TBparcialcompra
        '
        Me.TBparcialcompra.Enabled = False
        Me.TBparcialcompra.Location = New System.Drawing.Point(264, 39)
        Me.TBparcialcompra.Margin = New System.Windows.Forms.Padding(4)
        Me.TBparcialcompra.Name = "TBparcialcompra"
        Me.TBparcialcompra.Size = New System.Drawing.Size(386, 29)
        Me.TBparcialcompra.TabIndex = 1
        '
        'LBparcialcompra
        '
        Me.LBparcialcompra.AutoSize = True
        Me.LBparcialcompra.Location = New System.Drawing.Point(45, 44)
        Me.LBparcialcompra.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBparcialcompra.Name = "LBparcialcompra"
        Me.LBparcialcompra.Size = New System.Drawing.Size(188, 24)
        Me.LBparcialcompra.TabIndex = 0
        Me.LBparcialcompra.Text = "Total Parcial Compra"
        '
        'LBparcialventa
        '
        Me.LBparcialventa.AutoSize = True
        Me.LBparcialventa.Location = New System.Drawing.Point(62, 94)
        Me.LBparcialventa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBparcialventa.Name = "LBparcialventa"
        Me.LBparcialventa.Size = New System.Drawing.Size(171, 24)
        Me.LBparcialventa.TabIndex = 2
        Me.LBparcialventa.Text = "Total Parcial Venta"
        '
        'LBtotal
        '
        Me.LBtotal.AutoSize = True
        Me.LBtotal.Location = New System.Drawing.Point(179, 238)
        Me.LBtotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBtotal.Name = "LBtotal"
        Me.LBtotal.Size = New System.Drawing.Size(54, 24)
        Me.LBtotal.TabIndex = 8
        Me.LBtotal.Text = "Total"
        '
        'TBtotal
        '
        Me.TBtotal.Enabled = False
        Me.TBtotal.Location = New System.Drawing.Point(264, 238)
        Me.TBtotal.Margin = New System.Windows.Forms.Padding(4)
        Me.TBtotal.Name = "TBtotal"
        Me.TBtotal.Size = New System.Drawing.Size(386, 29)
        Me.TBtotal.TabIndex = 9
        '
        'BTregresar
        '
        Me.BTregresar.Location = New System.Drawing.Point(230, 379)
        Me.BTregresar.Name = "BTregresar"
        Me.BTregresar.Size = New System.Drawing.Size(247, 42)
        Me.BTregresar.TabIndex = 5
        Me.BTregresar.Text = "Regresar al Menu"
        Me.BTregresar.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(729, 495)
        Me.ControlBox = False
        Me.Controls.Add(Me.BTregresar)
        Me.Controls.Add(Me.GPSalidas)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TRANSACCION"
        Me.GPSalidas.ResumeLayout(False)
        Me.GPSalidas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GPSalidas As GroupBox
    Friend WithEvents TBparcialventa As TextBox
    Friend WithEvents TBparcialcompra As TextBox
    Friend WithEvents LBparcialcompra As Label
    Friend WithEvents LBparcialventa As Label
    Friend WithEvents TBcomisionventa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TBcomisioncompra As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TBtotal As TextBox
    Friend WithEvents LBtotal As Label
    Friend WithEvents BTregresar As Button
End Class
