Public Class frmCargaArchivo

    Private Sub btnCarga2_Click(sender As System.Object, e As System.EventArgs) Handles btnCarga2.Click
        OpenFileDialog1.ShowDialog()


        'Guardar Archivo en sistema de archivos y en base de datos

        MsgBox("Guardando archivo en sistema y en base de datos")


    End Sub
End Class