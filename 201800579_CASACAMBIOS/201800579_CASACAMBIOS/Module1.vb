Imports System.Math
Module Module1


    'crearemos el espacio en memoria para nuestas contantes con los cuales se realizaran las transacciones 
    Public Const CambioDolar As Double = 7.69
    Public Const CambioPeso As Double = 0.38
    Public Const CambioEuro As Double = 8.79
    Public Const CambioColonos As Double = 0.012
    Public Const ComisionVt As Double = 0.03
    Public Const ComisionCM As Double = 0.025
    'variables subtotales compra
    Dim sbc As Double
    Dim sbv As Double
    'varavles comisiones
    Dim cc As Double
    Dim cv As Double
    Dim t As Double
    Public Sub Calculotransacciones()

        'evaluaremos que se encuente seleccionado la opcion de compar para realizar el proceso de cambio
        If (Form1.CKcompra.Checked = True) Then
            If (Form1.CMdolares.Checked = True) Then
                'primero realizamos el subtotal
                sbc = Form1.TBcantidadCompra.Text * CambioDolar
                Form2.TBparcialcompra.Text = Round(sbc, 2)
                'aplicaremos la comision
                cc = Form2.TBparcialcompra.Text * ComisionCM
                Form2.TBcomisioncompra.Text = Round(cc, 2)
                Form2.TBcomisionventa.Text = 0
                Form2.TBparcialventa.Text = 0
                t = sbc + cc
                Form2.TBtotal.Text = Round(t, 2)
            ElseIf (Form1.CMpesos.Checked = True) Then
                sbc = Form1.TBcantidadCompra.Text * CambioPeso
                Form2.TBparcialcompra.Text = Round(sbc, 2)
                cc = Form2.TBparcialcompra.Text * ComisionCM
                Form2.TBcomisioncompra.Text = Round(cc, 2)
                Form2.TBcomisionventa.Text = 0
                Form2.TBparcialventa.Text = 0
                t = sbc + cc
                Form2.TBtotal.Text = Round(t, 2)
            ElseIf (Form1.CMeuros.Checked = True) Then
                sbc = Form1.TBcantidadCompra.Text * CambioEuro
                Form2.TBparcialcompra.Text = Round(sbc, 2)
                cc = Form2.TBparcialcompra.Text * ComisionCM
                Form2.TBcomisioncompra.Text = Round(cc, 2)
                Form2.TBcomisionventa.Text = 0
                Form2.TBparcialventa.Text = 0
                t = sbc + cc
                Form2.TBtotal.Text = Round(t, 2)
            ElseIf (Form1.CMcolones.Checked = True) Then
                sbc = Form1.TBcantidadCompra.Text * CambioColonos
                Form2.TBparcialcompra.Text = Round(sbc, 2)
                cc = Form2.TBparcialcompra.Text * ComisionCM
                Form2.TBcomisioncompra.Text = Round(cc, 2)
                Form2.TBcomisionventa.Text = 0
                Form2.TBparcialventa.Text = 0
                t = sbc + cc
                Form2.TBtotal.Text = Round(t, 2)
            End If
        End If



        'evaluaremos que se encuente seleccionado la opcion de venta para realizar el proceso de cambio

        If (Form1.CKventa.Checked = True) Then
            If (Form1.VNdolares.Checked = True) Then
                sbv = Form1.TBcantidadVenta.Text * CambioDolar
                Form2.TBparcialventa.Text = Round(sbv, 2)
                cv = Form2.TBparcialventa.Text * ComisionVt
                Form2.TBcomisionventa.Text = Round(cv, 2)
                Form2.TBcomisioncompra.Text = 0
                Form2.TBparcialcompra.Text = 0
                t = sbv + cv
                Form2.TBtotal.Text = Round(t, 2)
            ElseIf (Form1.VNpesos.Checked = True) Then
                sbv = Form1.TBcantidadVenta.Text * CambioPeso
                Form2.TBparcialventa.Text = Round(sbv, 2)
                cv = Form2.TBparcialventa.Text * ComisionVt
                Form2.TBcomisionventa.Text = Round(cv, 2)
                Form2.TBcomisioncompra.Text = 0
                Form2.TBparcialcompra.Text = 0
                t = sbv + cv
                Form2.TBtotal.Text = Round(t, 2)
            ElseIf (Form1.VNeuros.Checked = True) Then
                sbv = Form1.TBcantidadVenta.Text * CambioEuro
                Form2.TBparcialventa.Text = Round(sbv, 2)
                cv = Form2.TBparcialventa.Text * ComisionVt
                Form2.TBcomisionventa.Text = Round(cv, 2)
                Form2.TBcomisioncompra.Text = 0
                Form2.TBparcialcompra.Text = 0
                t = sbv + cv
                Form2.TBtotal.Text = Round(t, 2)
            ElseIf (Form1.VNcolones.Checked = True) Then
                sbv = Form1.TBcantidadVenta.Text * CambioColonos
                Form2.TBparcialventa.Text = Round(sbv, 2)
                cv = Form2.TBparcialventa.Text * ComisionVt
                Form2.TBcomisionventa.Text = Round(cv, 2)
                Form2.TBcomisioncompra.Text = 0
                Form2.TBparcialcompra.Text = 0
                t = sbv + cv
                Form2.TBtotal.Text = Round(t, 2)
            End If
        End If



    End Sub







    'limpiaremos los datos que se han ingresado en nuestras cajas de texto y tambien de las opciones de radio
    ' button que hallamos seleccionado ademas de las cajas de nuestros resultados que se encuentran alojadas
    ' en un segundo formulario
    Public Sub Limpieza()
        Form1.TBcantidadCompra.Clear()
        Form1.TBcantidadVenta.Clear()
        Form1.CKcompra.Checked = 0
        Form1.CKventa.Checked = 0
        Form1.CMdolares.Checked = 0
        Form1.CMpesos.Checked = 0
        Form1.CMeuros.Checked = 0
        Form1.CMcolones.Checked = 0
        Form1.VNdolares.Checked = 0
        Form1.VNpesos.Checked = 0
        Form1.VNeuros.Checked = 0
        Form1.VNcolones.Checked = 0
        Form2.TBcomisioncompra.Text = 0
        Form2.TBcomisionventa.Text = 0
        Form2.TBparcialcompra.Text = 0
        Form2.TBparcialventa.Text = 0
        Form2.TBtotal.Text = 0
    End Sub

End Module
