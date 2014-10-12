Option Strict Off
Option Explicit On
Friend Class Pruebas
	Inherits System.Windows.Forms.Form
	
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Me.Close()
		principal.Hide()
		Pruebas1.Show()
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Me.Close()
		principal.Hide()
		Pruebas2.Show()
	End Sub
	
	Private Sub Command8_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command8.Click
		Me.Close()
		CORTE.Hide()
		Embobinado.Hide()
		Empaque.Hide()
		empaque1.Hide()
		empaque2.Hide()
		empaque3.Hide()
		HEE.Hide()
		HEEM.Hide()
		MEE.Hide()
		MEEM.Hide()
		Mold.Hide()
		Mold2.Hide()
		Mold3.Hide()
		PREPARADO.Hide()
		Me.Hide()
		Pruebas1.Hide()
		Pruebas2.Hide()
		principal.Show()
	End Sub
End Class