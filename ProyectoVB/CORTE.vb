Option Strict Off
Option Explicit On
Friend Class CORTE

    Inherits System.Windows.Forms.Form

    Dim prcCorte As New Proceso
    Dim mdlCorte As New modelProceso
    Dim ctrlCorte As New controllerProceso

    Private Sub CORTE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'al cargar formulario llenar modelo y controlador de proceso
        ctrlCorte.setModelo(mdlCorte)

       
    End Sub
    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
       
        ctrlCorte.setProceso(prcCorte, mdlCorte, "planAccion")
        Call Shell(prcCorte.cadenaExec, AppWinStyle.MaximizedFocus)

    End Sub

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click

        ctrlCorte.setProceso(prcCorte, mdlCorte, "apunte")
        Call Shell(prcCorte.cadenaExec, AppWinStyle.MaximizedFocus)

    End Sub

    Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click

        ctrlCorte.setProceso(prcCorte, mdlCorte, "apunte2")
        Call Shell(prcCorte.cadenaExec, AppWinStyle.MaximizedFocus)

    End Sub

    Private Sub Command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command5.Click

        mostrarForm(Me, principal)

    End Sub

   
    Private Sub btnCargar_Click(sender As System.Object, e As System.EventArgs) Handles btnCargar.Click

        Dim pass As String

        pass = InputBox("ingrese contraseña")

        If pass = "guillermo" Then

            frmCargaArchivo.Show()

        End If



    End Sub
End Class