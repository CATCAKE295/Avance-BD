Public Class Tipo_Cambio_Encabezado
    Private Sub Tipo_Cambio_Encabezado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KERMESSEDataSet.TipoCambioEnc' Puede moverla o quitarla según sea necesario.
        Me.TipoCambioEncTableAdapter.Fill(Me.KERMESSEDataSet.TipoCambioEnc)

    End Sub

    Private Sub txtSegTPE_Click(sender As Object, e As EventArgs) Handles txtSegTPE.Click

        Tipo_Cambio_Detalle.Show()

    End Sub
End Class