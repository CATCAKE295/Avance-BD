Public Class Tipo_Cambio_Detalle
    Private Sub Tipo_Cambio_Detalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KERMESSEDataSet.TipoCambioDet' Puede moverla o quitarla según sea necesario.
        Me.TipoCambioDetTableAdapter.Fill(Me.KERMESSEDataSet.TipoCambioDet)

    End Sub
End Class