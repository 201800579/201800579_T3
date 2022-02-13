Public Class Form1

    'IMPLEMENTAREMOS UN METODO PARA VERIFICAR CUAL DE LAS TRANSACCIONES SE REALIZARAN Y DE ESTA MANERA
    'DESBLOQUEAR LAS CAJAS DE TEXTO DONDE SE INGRESARAN LAS CANTIDADES YA SEA PARA VENTA O COMPRA
    'INCLUSIVE AMBAS
    Private Sub CKcompra_CheckedChanged(sender As Object, e As EventArgs) Handles CKcompra.CheckedChanged
        'con la ayuda de un if verificaremos que se seleccione alguno de los checkbox y habilitarr las cantidades
        'a ingresar, y con la ayuda de comando focus se desplazara automaticamete a la casilla de ingreso de texto
        If CKcompra.Checked = True Then
            TBcantidadCompra.Enabled = True
            TBcantidadCompra.Focus()
        Else
            TBcantidadCompra.Enabled = False
        End If

    End Sub

    Private Sub CKventa_CheckedChanged(sender As Object, e As EventArgs) Handles CKventa.CheckedChanged
        If CKventa.Checked = True Then
            TBcantidadVenta.Enabled = True
            TBcantidadVenta.Focus()
            TBcantidadCompra.Focus()
        Else
            TBcantidadVenta.Enabled = False
        End If
    End Sub


    'programacion mediante un if para el boton de salida de la aplicacion si no desea salir se limpiara los valotes contenidos
    Private Sub BTsalir_Click(sender As System.Object, ByVal e As System.EventArgs) Handles BTsalir.Click
        If MsgBox("¿Desea Salir de la aplicacion?", vbQuestion + vbYesNo, "Salir") = vbYes Then
            Close()
        Else
            Limpieza()
        End If


    End Sub



    'llamaremo al metodo limbiar que se aloja en nuestro modulo
    Private Sub BTLimpiar_Click(sender As Object, e As EventArgs) Handles BTLimpiar.Click
        Limpieza()
    End Sub


    'llamaremos el metodo donde el cual se aloja todo el algoritmo para realizar las transacciones
    Private Sub BTcalcular_Click(sender As Object, e As EventArgs) Handles BTcalcular.Click
        Calculotransacciones()
        Form2.Show()
        Me.Hide()
    End Sub

    'este fragmento de codigo hara que en nuestra caja de texto destinada a la compra solo se 
    'ingresen numeros para ello utilizaremos if
    Private Sub TBcantidadCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBcantidadCompra.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    'este fragmento de codigo hara que en nuestra caja de texto destinada a la compra solo se 
    'ingresen numeros para ello utilizaremos if
    Private Sub TBcantidadVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBcantidadVenta.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub


End Class
