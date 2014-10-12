Option Strict Off
Option Explicit On
Friend Class Mold
	Inherits System.Windows.Forms.Form
	
	
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Mold3.Show()
		principal.Hide()
	End Sub
	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
		Mold2.Show()
		principal.Hide()
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
		Me.Hide()
		Mold2.Hide()
		Mold3.Hide()
		PREPARADO.Hide()
		Pruebas.Hide()
		Pruebas1.Hide()
		Pruebas2.Hide()
		principal.Show()
	End Sub
End Class