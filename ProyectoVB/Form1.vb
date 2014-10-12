Option Strict Off
Option Explicit On
Friend Class principal
    Inherits System.Windows.Forms.Form
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'al cargar formulario
        iniDbModelo()



    End Sub
	Dim a As Short
	
	
	Private Sub Command10_Click()
		Pruebas2.Show()
		Me.Hide()
	End Sub
	
	Private Sub Command11_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command11.Click
		Pruebas.Show()
		Me.Hide()
	End Sub
	
	Private Sub Command14_Click()
		Mold3.Show()
		Me.Hide()
	End Sub
	
	Private Sub Command15_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command15.Click
		Embobinado.Show()
		Me.Hide()
	End Sub
	
	Private Sub Command16_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command16.Click
		Mold.Show()
		Me.Hide()
	End Sub
	
	Private Sub Command17_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command17.Click
		HEE.Show()
		Me.Hide()
	End Sub
	
	Private Sub Command18_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command18.Click
		MEEM.Show()
		Me.Hide()
	End Sub
	
	Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click
		Empaque.Show()
		Me.Hide()
	End Sub
	
	Private Sub Command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command5.Click
		CORTE.Show()
		Me.Hide()
	End Sub
	
	Private Sub Command6_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command6.Click
		MEE.Show()
		Me.Hide()
	End Sub
	
	Private Sub Command7_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command7.Click
		PREPARADO.Show()
		Me.Hide()
	End Sub
	
	Private Sub Command8_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command8.Click
		HEEM.Show()
		Me.Hide()
	End Sub
	
	Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
		Image1.Image = Picture1(a).Image
		a = a + 1
		
		If a = 11 Then
			a = 0
			
		End If
		
		
		
	End Sub
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        'Dim ITff As Object
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ITff.Show. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'ITff.Show()
		Me.Hide()
		
		
	End Sub
	
	
	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
		Dim VMARLEY As Object
		Me.Hide()
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto VMARLEY.Show. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		VMARLEY.Show()
	End Sub
	
	
	
	
	Private Sub Timer2_Timer()
		Dim Image3 As Object
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Image3.Picture. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'Image3.Picture = Image1(a).Image
		a = a + 2
		
		If a = 6 Then
			a = 0
			
		End If
	End Sub
End Class