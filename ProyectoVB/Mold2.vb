Option Strict Off
Option Explicit On
Friend Class Mold2
	Inherits System.Windows.Forms.Form
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Dim Index As Short = Command1.GetIndex(eventSender)
		Dim cadenatexto As Object
		Dim extension As Object
		Dim archivo As Object
		Dim carpeta3 As Object
		Dim carpeta2 As Object
		Dim carpeta1 As Object
		Dim unidad As Object
		Dim rutaprog As Object
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rutaprog. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		rutaprog = "C:\Program Files\\Adobe\Reader 9.0\Reader\AcroRd32.exe"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rutaprog. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		rutaprog = "C:\Program Files\\Adobe\Reader 9.0\Reader\AcroRd32.exe"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto unidad. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		unidad = "C:\"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta1. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		carpeta1 = "LINEA AHB"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta2. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		carpeta2 = "INSTRUCCIONES DE TRABAJO"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta3. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		carpeta3 = "MOLDEO"
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto archivo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		archivo = "AE-AV-EH-69"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto extension. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		extension = ".pdf"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto extension. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto archivo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta3. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta2. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta1. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto unidad. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rutaprog. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenatexto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cadenatexto = rutaprog + " " + unidad + carpeta1 + "\" + carpeta2 + "\" + carpeta3 + "\" + archivo + extension
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenatexto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Call Shell(cadenatexto, AppWinStyle.MaximizedFocus)
	End Sub
	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
		Dim Index As Short = Command3.GetIndex(eventSender)
		Dim cadenatexto As Object
		Dim extension As Object
		Dim archivo As Object
		Dim carpeta3 As Object
		Dim carpeta2 As Object
		Dim carpeta1 As Object
		Dim unidad As Object
		Dim rutaprog As Object
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rutaprog. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		rutaprog = "C:\Program Files\\Adobe\Reader 9.0\Reader\AcroRd32.exe"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rutaprog. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		rutaprog = "C:\Program Files\\Adobe\Reader 9.0\Reader\AcroRd32.exe"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto unidad. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		unidad = "C:\"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta1. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		carpeta1 = "LINEA AHB"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta2. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		carpeta2 = "INSTRUCCIONES DE TRABAJO"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta3. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		carpeta3 = "MOLDEO"
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto archivo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		archivo = "AE-AV-EH-71"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto extension. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		extension = ".pdf"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto extension. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto archivo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta3. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta2. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta1. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto unidad. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rutaprog. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenatexto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cadenatexto = rutaprog + " " + unidad + carpeta1 + "\" + carpeta2 + "\" + carpeta3 + "\" + archivo + extension
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenatexto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Call Shell(cadenatexto, AppWinStyle.MaximizedFocus)
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Dim Index As Short = Command2.GetIndex(eventSender)
		Dim cadenatexto As Object
		Dim extension As Object
		Dim archivo As Object
		Dim carpeta3 As Object
		Dim carpeta2 As Object
		Dim carpeta1 As Object
		Dim unidad As Object
		Dim rutaprog As Object
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rutaprog. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		rutaprog = "C:\Program Files\\Adobe\Reader 9.0\Reader\AcroRd32.exe"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rutaprog. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		rutaprog = "C:\Program Files\\Adobe\Reader 9.0\Reader\AcroRd32.exe"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto unidad. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		unidad = "C:\"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta1. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		carpeta1 = "LINEA AHB"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta2. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		carpeta2 = "INSTRUCCIONES DE TRABAJO"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta3. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		carpeta3 = "MOLDEO"
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto archivo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		archivo = "AE-AV-EH-70"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto extension. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		extension = ".pdf"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto extension. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto archivo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta3. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta2. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta1. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto unidad. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rutaprog. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenatexto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cadenatexto = rutaprog + " " + unidad + carpeta1 + "\" + carpeta2 + "\" + carpeta3 + "\" + archivo + extension
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenatexto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Call Shell(cadenatexto, AppWinStyle.MaximizedFocus)
	End Sub
	Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click
		Dim Index As Short = Command4.GetIndex(eventSender)
		Dim cadenatexto As Object
		Dim extension As Object
		Dim archivo As Object
		Dim carpeta3 As Object
		Dim carpeta2 As Object
		Dim carpeta1 As Object
		Dim unidad As Object
		Dim rutaprog As Object
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rutaprog. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		rutaprog = "C:\Program Files\\Adobe\Reader 9.0\Reader\AcroRd32.exe"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rutaprog. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		rutaprog = "C:\Program Files\\Adobe\Reader 9.0\Reader\AcroRd32.exe"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto unidad. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		unidad = "C:\"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta1. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		carpeta1 = "LINEA AHB"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta2. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		carpeta2 = "INSTRUCCIONES DE TRABAJO"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta3. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		carpeta3 = "MOLDEO"
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto archivo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		archivo = "AE-AV-EH-72"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto extension. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		extension = ".pdf"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto extension. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto archivo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta3. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta2. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta1. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto unidad. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rutaprog. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenatexto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cadenatexto = rutaprog + " " + unidad + carpeta1 + "\" + carpeta2 + "\" + carpeta3 + "\" + archivo + extension
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenatexto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Call Shell(cadenatexto, AppWinStyle.MaximizedFocus)
	End Sub
	
	Private Sub Command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command5.Click
		Dim Index As Short = Command5.GetIndex(eventSender)
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
		Me.Hide()
		Mold3.Hide()
		PREPARADO.Hide()
		Pruebas.Hide()
		Pruebas1.Hide()
		Pruebas2.Hide()
		principal.Show()
	End Sub
	
	Private Sub Command51_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command51.Click
		Dim Index As Short = Command51.GetIndex(eventSender)
		Dim cadenatexto As Object
		Dim extension As Object
		Dim archivo As Object
		Dim carpeta3 As Object
		Dim carpeta2 As Object
		Dim carpeta1 As Object
		Dim unidad As Object
		Dim rutaprog As Object
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rutaprog. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		rutaprog = "C:\Program Files\\Adobe\Reader 9.0\Reader\AcroRd32.exe"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rutaprog. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		rutaprog = "C:\Program Files\\Adobe\Reader 9.0\Reader\AcroRd32.exe"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto unidad. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		unidad = "C:\"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta1. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		carpeta1 = "LINEA AHB"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta2. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		carpeta2 = "INSTRUCCIONES DE TRABAJO"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta3. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		carpeta3 = "MOLDEO"
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto archivo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		archivo = "AE-AV-EH-73"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto extension. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		extension = ".pdf"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto extension. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto archivo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta3. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta2. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta1. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto unidad. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rutaprog. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenatexto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cadenatexto = rutaprog + " " + unidad + carpeta1 + "\" + carpeta2 + "\" + carpeta3 + "\" + archivo + extension
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenatexto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Call Shell(cadenatexto, AppWinStyle.MaximizedFocus)
	End Sub
	
	Private Sub Command6_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command6.Click
		Dim Index As Short = Command6.GetIndex(eventSender)
		Dim cadenatexto As Object
		Dim extension As Object
		Dim archivo As Object
		Dim carpeta3 As Object
		Dim carpeta2 As Object
		Dim carpeta1 As Object
		Dim unidad As Object
		Dim rutaprog As Object
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rutaprog. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		rutaprog = "C:\Program Files\\Adobe\Reader 9.0\Reader\AcroRd32.exe"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rutaprog. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		rutaprog = "C:\Program Files\\Adobe\Reader 9.0\Reader\AcroRd32.exe"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto unidad. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		unidad = "C:\"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta1. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		carpeta1 = "LINEA AHB"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta2. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		carpeta2 = "INSTRUCCIONES DE TRABAJO"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta3. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		carpeta3 = "MOLDEO"
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto archivo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		archivo = "AE-AV-EH-74"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto extension. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		extension = ".pdf"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto extension. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto archivo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta3. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta2. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta1. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto unidad. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rutaprog. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenatexto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cadenatexto = rutaprog + " " + unidad + carpeta1 + "\" + carpeta2 + "\" + carpeta3 + "\" + archivo + extension
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenatexto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Call Shell(cadenatexto, AppWinStyle.MaximizedFocus)
	End Sub
	
	Private Sub Command7_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command7.Click
		Dim Index As Short = Command7.GetIndex(eventSender)
		Dim cadenatexto As Object
		Dim extension As Object
		Dim archivo As Object
		Dim carpeta3 As Object
		Dim carpeta2 As Object
		Dim carpeta1 As Object
		Dim unidad As Object
		Dim rutaprog As Object
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rutaprog. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		rutaprog = "C:\Program Files\\Adobe\Reader 9.0\Reader\AcroRd32.exe"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rutaprog. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		rutaprog = "C:\Program Files\\Adobe\Reader 9.0\Reader\AcroRd32.exe"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto unidad. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		unidad = "C:\"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta1. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		carpeta1 = "LINEA AHB"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta2. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		carpeta2 = "INSTRUCCIONES DE TRABAJO"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta3. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		carpeta3 = "MOLDEO"
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto archivo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		archivo = "AE-AV-EH-30"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto extension. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		extension = ".pdf"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto extension. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto archivo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta3. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta2. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta1. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto unidad. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rutaprog. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenatexto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cadenatexto = rutaprog + " " + unidad + carpeta1 + "\" + carpeta2 + "\" + carpeta3 + "\" + archivo + extension
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenatexto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Call Shell(cadenatexto, AppWinStyle.MaximizedFocus)
	End Sub
	
	Private Sub Command8_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command8.Click
		Dim Index As Short = Command8.GetIndex(eventSender)
		Dim cadenatexto As Object
		Dim extension As Object
		Dim archivo As Object
		Dim carpeta3 As Object
		Dim carpeta2 As Object
		Dim carpeta1 As Object
		Dim unidad As Object
		Dim rutaprog As Object
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rutaprog. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		rutaprog = "C:\Program Files\\Adobe\Reader 9.0\Reader\AcroRd32.exe"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rutaprog. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		rutaprog = "C:\Program Files\\Adobe\Reader 9.0\Reader\AcroRd32.exe"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto unidad. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		unidad = "C:\"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta1. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		carpeta1 = "LINEA AHB"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta2. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		carpeta2 = "INSTRUCCIONES DE TRABAJO"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta3. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		carpeta3 = "MOLDEO"
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto archivo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		archivo = "AE-AV-EH-31"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto extension. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		extension = ".pdf"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto extension. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto archivo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta3. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta2. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto carpeta1. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto unidad. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rutaprog. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenatexto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cadenatexto = rutaprog + " " + unidad + carpeta1 + "\" + carpeta2 + "\" + carpeta3 + "\" + archivo + extension
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenatexto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Call Shell(cadenatexto, AppWinStyle.MaximizedFocus)
	End Sub
End Class