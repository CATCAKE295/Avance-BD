Public Class Moneda
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Moneda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KERMESSEDataSet.Moneda' Puede moverla o quitarla según sea necesario.
        Me.MonedaTableAdapter.Fill(Me.KERMESSEDataSet.Moneda)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txtSegP_Click(sender As Object, e As EventArgs) Handles txtSegM.Click
        Tipo_Cambio_Encabezado.Show()

    End Sub
End Class