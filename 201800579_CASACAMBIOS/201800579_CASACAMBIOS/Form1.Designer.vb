<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.CKcompra = New System.Windows.Forms.CheckBox()
        Me.CKventa = New System.Windows.Forms.CheckBox()
        Me.GPtransacciones = New System.Windows.Forms.GroupBox()
        Me.GPingresos = New System.Windows.Forms.GroupBox()
        Me.TBcantidadVenta = New System.Windows.Forms.TextBox()
        Me.TBcantidadCompra = New System.Windows.Forms.TextBox()
        Me.LBcantidadcompra = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GPCompra = New System.Windows.Forms.GroupBox()
        Me.CMcolones = New System.Windows.Forms.RadioButton()
        Me.CMeuros = New System.Windows.Forms.RadioButton()
        Me.CMpesos = New System.Windows.Forms.RadioButton()
        Me.CMdolares = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.VNcolones = New System.Windows.Forms.RadioButton()
        Me.VNeuros = New System.Windows.Forms.RadioButton()
        Me.VNpesos = New System.Windows.Forms.RadioButton()
        Me.VNdolares = New System.Windows.Forms.RadioButton()
        Me.BTcalcular = New System.Windows.Forms.Button()
        Me.BTLimpiar = New System.Windows.Forms.Button()
        Me.BTsalir = New System.Windows.Forms.Button()
        Me.GPtransacciones.SuspendLayout()
        Me.GPingresos.SuspendLayout()
        Me.GPCompra.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CKcompra
        '
        Me.CKcompra.AutoSize = True
        Me.CKcompra.Location = New System.Drawing.Point(52, 26)
        Me.CKcompra.Name = "CKcompra"
        Me.CKcompra.Size = New System.Drawing.Size(99, 28)
        Me.CKcompra.TabIndex = 0
        Me.CKcompra.Text = "Compra"
        Me.CKcompra.UseVisualStyleBackColor = True
        '
        'CKventa
        '
        Me.CKventa.AutoSize = True
        Me.CKventa.Location = New System.Drawing.Point(52, 59)
        Me.CKventa.Name = "CKventa"
        Me.CKventa.Size = New System.Drawing.Size(82, 28)
        Me.CKventa.TabIndex = 1
        Me.CKventa.Text = "Venta"
        Me.CKventa.UseVisualStyleBackColor = True
        '
        'GPtransacciones
        '
        Me.GPtransacciones.Controls.Add(Me.CKventa)
        Me.GPtransacciones.Controls.Add(Me.CKcompra)
        Me.GPtransacciones.Location = New System.Drawing.Point(12, 27)
        Me.GPtransacciones.Name = "GPtransacciones"
        Me.GPtransacciones.Size = New System.Drawing.Size(247, 102)
        Me.GPtransacciones.TabIndex = 2
        Me.GPtransacciones.TabStop = False
        Me.GPtransacciones.Text = "Transacciones"
        '
        'GPingresos
        '
        Me.GPingresos.Controls.Add(Me.TBcantidadVenta)
        Me.GPingresos.Controls.Add(Me.TBcantidadCompra)
        Me.GPingresos.Controls.Add(Me.LBcantidadcompra)
        Me.GPingresos.Controls.Add(Me.Label1)
        Me.GPingresos.Location = New System.Drawing.Point(273, 27)
        Me.GPingresos.Name = "GPingresos"
        Me.GPingresos.Size = New System.Drawing.Size(480, 103)
        Me.GPingresos.TabIndex = 3
        Me.GPingresos.TabStop = False
        Me.GPingresos.Text = "Ingresos"
        '
        'TBcantidadVenta
        '
        Me.TBcantidadVenta.Enabled = False
        Me.TBcantidadVenta.Location = New System.Drawing.Point(192, 63)
        Me.TBcantidadVenta.Name = "TBcantidadVenta"
        Me.TBcantidadVenta.Size = New System.Drawing.Size(282, 29)
        Me.TBcantidadVenta.TabIndex = 3
        '
        'TBcantidadCompra
        '
        Me.TBcantidadCompra.Enabled = False
        Me.TBcantidadCompra.Location = New System.Drawing.Point(192, 26)
        Me.TBcantidadCompra.Name = "TBcantidadCompra"
        Me.TBcantidadCompra.Size = New System.Drawing.Size(282, 29)
        Me.TBcantidadCompra.TabIndex = 1
        '
        'LBcantidadcompra
        '
        Me.LBcantidadcompra.AutoSize = True
        Me.LBcantidadcompra.Location = New System.Drawing.Point(6, 30)
        Me.LBcantidadcompra.Name = "LBcantidadcompra"
        Me.LBcantidadcompra.Size = New System.Drawing.Size(180, 24)
        Me.LBcantidadcompra.TabIndex = 0
        Me.LBcantidadcompra.Text = "Cantidad a Comprar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cantidad a Vender"
        '
        'GPCompra
        '
        Me.GPCompra.Controls.Add(Me.CMcolones)
        Me.GPCompra.Controls.Add(Me.CMeuros)
        Me.GPCompra.Controls.Add(Me.CMpesos)
        Me.GPCompra.Controls.Add(Me.CMdolares)
        Me.GPCompra.Location = New System.Drawing.Point(12, 152)
        Me.GPCompra.Name = "GPCompra"
        Me.GPCompra.Size = New System.Drawing.Size(248, 239)
        Me.GPCompra.TabIndex = 2
        Me.GPCompra.TabStop = False
        Me.GPCompra.Text = "Moneda a Comprar"
        '
        'CMcolones
        '
        Me.CMcolones.AutoSize = True
        Me.CMcolones.Location = New System.Drawing.Point(30, 155)
        Me.CMcolones.Name = "CMcolones"
        Me.CMcolones.Size = New System.Drawing.Size(217, 28)
        Me.CMcolones.TabIndex = 3
        Me.CMcolones.Text = "Colones Costarricense"
        Me.CMcolones.UseVisualStyleBackColor = True
        '
        'CMeuros
        '
        Me.CMeuros.AutoSize = True
        Me.CMeuros.Location = New System.Drawing.Point(30, 121)
        Me.CMeuros.Name = "CMeuros"
        Me.CMeuros.Size = New System.Drawing.Size(78, 28)
        Me.CMeuros.TabIndex = 2
        Me.CMeuros.Text = "Euros"
        Me.CMeuros.UseVisualStyleBackColor = True
        '
        'CMpesos
        '
        Me.CMpesos.AutoSize = True
        Me.CMpesos.Location = New System.Drawing.Point(30, 87)
        Me.CMpesos.Name = "CMpesos"
        Me.CMpesos.Size = New System.Drawing.Size(175, 28)
        Me.CMpesos.TabIndex = 1
        Me.CMpesos.Text = "Pesos Mexicanos"
        Me.CMpesos.UseVisualStyleBackColor = True
        '
        'CMdolares
        '
        Me.CMdolares.AutoSize = True
        Me.CMdolares.Location = New System.Drawing.Point(30, 53)
        Me.CMdolares.Name = "CMdolares"
        Me.CMdolares.Size = New System.Drawing.Size(95, 28)
        Me.CMdolares.TabIndex = 0
        Me.CMdolares.Text = "Dolares"
        Me.CMdolares.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.VNcolones)
        Me.GroupBox1.Controls.Add(Me.VNeuros)
        Me.GroupBox1.Controls.Add(Me.VNpesos)
        Me.GroupBox1.Controls.Add(Me.VNdolares)
        Me.GroupBox1.Location = New System.Drawing.Point(273, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 239)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Moneda a Vender"
        '
        'VNcolones
        '
        Me.VNcolones.AutoSize = True
        Me.VNcolones.Location = New System.Drawing.Point(30, 155)
        Me.VNcolones.Name = "VNcolones"
        Me.VNcolones.Size = New System.Drawing.Size(217, 28)
        Me.VNcolones.TabIndex = 3
        Me.VNcolones.Text = "Colones Costarricense"
        Me.VNcolones.UseVisualStyleBackColor = True
        '
        'VNeuros
        '
        Me.VNeuros.AutoSize = True
        Me.VNeuros.Location = New System.Drawing.Point(30, 121)
        Me.VNeuros.Name = "VNeuros"
        Me.VNeuros.Size = New System.Drawing.Size(78, 28)
        Me.VNeuros.TabIndex = 2
        Me.VNeuros.Text = "Euros"
        Me.VNeuros.UseVisualStyleBackColor = True
        '
        'VNpesos
        '
        Me.VNpesos.AutoSize = True
        Me.VNpesos.Location = New System.Drawing.Point(30, 87)
        Me.VNpesos.Name = "VNpesos"
        Me.VNpesos.Size = New System.Drawing.Size(175, 28)
        Me.VNpesos.TabIndex = 1
        Me.VNpesos.Text = "Pesos Mexicanos"
        Me.VNpesos.UseVisualStyleBackColor = True
        '
        'VNdolares
        '
        Me.VNdolares.AutoSize = True
        Me.VNdolares.Location = New System.Drawing.Point(30, 53)
        Me.VNdolares.Name = "VNdolares"
        Me.VNdolares.Size = New System.Drawing.Size(95, 28)
        Me.VNdolares.TabIndex = 0
        Me.VNdolares.Text = "Dolares"
        Me.VNdolares.UseVisualStyleBackColor = True
        '
        'BTcalcular
        '
        Me.BTcalcular.BackColor = System.Drawing.Color.Wheat
        Me.BTcalcular.Location = New System.Drawing.Point(571, 175)
        Me.BTcalcular.Name = "BTcalcular"
        Me.BTcalcular.Size = New System.Drawing.Size(175, 30)
        Me.BTcalcular.TabIndex = 5
        Me.BTcalcular.Text = "Calcular"
        Me.BTcalcular.UseVisualStyleBackColor = False
        '
        'BTLimpiar
        '
        Me.BTLimpiar.BackColor = System.Drawing.Color.Wheat
        Me.BTLimpiar.Location = New System.Drawing.Point(572, 239)
        Me.BTLimpiar.Name = "BTLimpiar"
        Me.BTLimpiar.Size = New System.Drawing.Size(175, 30)
        Me.BTLimpiar.TabIndex = 6
        Me.BTLimpiar.Text = "Limpiar"
        Me.BTLimpiar.UseVisualStyleBackColor = False
        '
        'BTsalir
        '
        Me.BTsalir.BackColor = System.Drawing.Color.Wheat
        Me.BTsalir.Location = New System.Drawing.Point(571, 305)
        Me.BTsalir.Name = "BTsalir"
        Me.BTsalir.Size = New System.Drawing.Size(175, 30)
        Me.BTsalir.TabIndex = 7
        Me.BTsalir.Text = "Salir"
        Me.BTsalir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(765, 448)
        Me.Controls.Add(Me.BTsalir)
        Me.Controls.Add(Me.BTLimpiar)
        Me.Controls.Add(Me.BTcalcular)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GPCompra)
        Me.Controls.Add(Me.GPingresos)
        Me.Controls.Add(Me.GPtransacciones)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CASA CAMBIOS"
        Me.GPtransacciones.ResumeLayout(False)
        Me.GPtransacciones.PerformLayout()
        Me.GPingresos.ResumeLayout(False)
        Me.GPingresos.PerformLayout()
        Me.GPCompra.ResumeLayout(False)
        Me.GPCompra.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CKcompra As CheckBox
    Friend WithEvents CKventa As CheckBox
    Friend WithEvents GPtransacciones As GroupBox
    Friend WithEvents GPingresos As GroupBox
    Friend WithEvents LBcantidadcompra As Label
    Friend WithEvents TBcantidadCompra As TextBox
    Friend WithEvents GPCompra As GroupBox
    Friend WithEvents CMcolones As RadioButton
    Friend WithEvents CMeuros As RadioButton
    Friend WithEvents CMpesos As RadioButton
    Friend WithEvents CMdolares As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents VNcolones As RadioButton
    Friend WithEvents VNeuros As RadioButton
    Friend WithEvents VNpesos As RadioButton
    Friend WithEvents VNdolares As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents TBcantidadVenta As TextBox
    Friend WithEvents BTcalcular As Button
    Friend WithEvents BTLimpiar As Button
    Friend WithEvents BTsalir As Button
End Class
