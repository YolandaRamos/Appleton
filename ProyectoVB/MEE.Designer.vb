<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class MEE
#Region "Código generado por el Diseñador de Windows Forms "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'Llamada necesaria para el Diseñador de Windows Forms.
		InitializeComponent()
	End Sub
	'Form invalida a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents Command8 As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents _Label1_0 As System.Windows.Forms.Label
	Public WithEvents _MEEM_1 As System.Windows.Forms.Label
	Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents MEEM As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MEE))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Command8 = New System.Windows.Forms.Button
		Me.Command1 = New System.Windows.Forms.Button
		Me._Label1_0 = New System.Windows.Forms.Label
		Me._MEEM_1 = New System.Windows.Forms.Label
		Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.MEEM = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.MEEM, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "APPLETON"
		Me.ClientSize = New System.Drawing.Size(1008, 714)
		Me.Location = New System.Drawing.Point(8, 30)
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.BackgroundImage = CType(resources.GetObject("MEE.BackgroundImage"), System.Drawing.Image)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "MEE"
		Me.Command8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Command8.BackColor = System.Drawing.SystemColors.ControlLight
		Me.Command8.Size = New System.Drawing.Size(81, 57)
		Me.Command8.Location = New System.Drawing.Point(912, 600)
		Me.Command8.Image = CType(resources.GetObject("Command8.Image"), System.Drawing.Image)
		Me.Command8.TabIndex = 3
		Me.Command8.CausesValidation = True
		Me.Command8.Enabled = True
		Me.Command8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command8.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command8.TabStop = True
		Me.Command8.Name = "Command8"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.Text = "Especificaciones"
		Me.Command1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command1.Size = New System.Drawing.Size(311, 70)
		Me.Command1.Location = New System.Drawing.Point(536, 296)
		Me.Command1.TabIndex = 0
		Me.Command1.BackColor = System.Drawing.SystemColors.Control
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me._Label1_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._Label1_0.Text = "Instrucciones de trabajo"
		Me._Label1_0.Font = New System.Drawing.Font("Arial Black", 30!, System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_0.Size = New System.Drawing.Size(633, 65)
		Me._Label1_0.Location = New System.Drawing.Point(376, 176)
		Me._Label1_0.TabIndex = 2
		Me._Label1_0.BackColor = System.Drawing.Color.Transparent
		Me._Label1_0.Enabled = True
		Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_0.UseMnemonic = True
		Me._Label1_0.Visible = True
		Me._Label1_0.AutoSize = False
		Me._Label1_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_0.Name = "_Label1_0"
		Me._MEEM_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._MEEM_1.Text = "Medición de engrapado extremo"
		Me._MEEM_1.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._MEEM_1.Size = New System.Drawing.Size(633, 65)
		Me._MEEM_1.Location = New System.Drawing.Point(376, 237)
		Me._MEEM_1.TabIndex = 1
		Me._MEEM_1.BackColor = System.Drawing.Color.Transparent
		Me._MEEM_1.Enabled = True
		Me._MEEM_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._MEEM_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._MEEM_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._MEEM_1.UseMnemonic = True
		Me._MEEM_1.Visible = True
		Me._MEEM_1.AutoSize = False
		Me._MEEM_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._MEEM_1.Name = "_MEEM_1"
		Me.Controls.Add(Command8)
		Me.Controls.Add(Command1)
		Me.Controls.Add(_Label1_0)
		Me.Controls.Add(_MEEM_1)
		Me.Label1.SetIndex(_Label1_0, CType(0, Short))
		Me.MEEM.SetIndex(_MEEM_1, CType(1, Short))
		CType(Me.MEEM, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class