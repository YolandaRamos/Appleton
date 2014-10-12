Module Module1
    'Contenedor de datos para modelo
    Dim dbModelo(10) As String
    'Rutina para llenar datos de modelo
    Sub iniDbModelo()

        dbModelo(1) = "LINEA AHB" 'Carpeta1
        dbModelo(2) = "INSTRUCCIONES DE TRABAJO" 'Carpeta2
        dbModelo(3) = "CORTE A LONGITUD" 'Carpeta3
        dbModelo(4) = "planAccion" '"AE-AV-EH-53" 'Archivo
        dbModelo(5) = ".pdf" 'Extensión
        dbModelo(6) = "C:\" 'Unidad
        dbModelo(7) = "D:\Program Files\Adobe\Acrobat 11.0\Acrobat\Acrobat.exe"



    End Sub

    'Clase para cada proceso o procedimiento de fabricación
    Class Proceso

        Public nombre As String
        Public rutaArchivo As String
        Public rutaLector As String
        Public cadenaExec As String


        Sub setRutaArchivo(cadena As String)

            rutaArchivo = cadena


        End Sub

        Sub setRutaLector(Cadena As String)

            rutaLector = Cadena

        End Sub

    End Class
    'Clase para guardar los datos del proceso de fabricación
    Class modelProceso

        Public nombre As String
        Public carpeta1 As String
        Public carpeta2 As String
        Public carpeta3 As String
        Public archivo As String
        Public extension As String
        Public unidad As String

    End Class
    'Clase para controlar datos y vista de proceso de fabricación
    Class controllerProceso

        'Poner datos de modelo

        Sub setModelo(modelo As modelProceso)

            'los datos se pueden tomar de una base de datos
            'Se llamaria  base de datos
            'ahora se simula obteniendolos de un arreglo de cadenas.


            modelo.carpeta1 = dbModelo(1)
            modelo.carpeta2 = dbModelo(2)
            modelo.carpeta3 = dbModelo(3)
            modelo.archivo = dbModelo(4)
            modelo.extension = dbModelo(5)
            modelo.unidad = dbModelo(6)


        End Sub

        'Rellenar datos de clase proceso
        Sub setProceso(proceso As Proceso, modelo As modelProceso, archivo As String)
            proceso.rutaLector = dbModelo(7)
            If archivo = "" Then
                archivo = modelo.archivo
            End If
            proceso.cadenaExec = proceso.rutaLector + " " + modelo.unidad + modelo.carpeta1 + "\" + modelo.carpeta2 + "\" + modelo.carpeta3 + "\" + archivo + modelo.extension

        End Sub

    End Class
    'Función o rutina para ocultar formularios abiertos
    Sub mostrarForm(forma As Form, forma2 As Form)

        Dim Form As Form

        ' bucle recursivo por los formularios del proyecto  
        For Each Form In Application.OpenForms

            Form.Hide()

        Next Form
        forma.Close()
        forma2.Show()

    End Sub
End Module
