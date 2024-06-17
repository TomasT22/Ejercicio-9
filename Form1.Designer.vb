<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdEjecutar = New System.Windows.Forms.Button()
        Me.dtvMatriz = New System.Windows.Forms.DataGridView()
        Me.dtvNuevaMatriz = New System.Windows.Forms.DataGridView()
        Me.dtvVector = New System.Windows.Forms.DataGridView()
        Me.lblVector = New System.Windows.Forms.Label()
        Me.lblNuevaMatriz = New System.Windows.Forms.Label()
        Me.lblMatriz = New System.Windows.Forms.Label()
        CType(Me.dtvMatriz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtvNuevaMatriz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtvVector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdEjecutar
        '
        Me.cmdEjecutar.Location = New System.Drawing.Point(324, 24)
        Me.cmdEjecutar.Name = "cmdEjecutar"
        Me.cmdEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.cmdEjecutar.TabIndex = 0
        Me.cmdEjecutar.Text = "Ejecutar"
        Me.cmdEjecutar.UseVisualStyleBackColor = True
        '
        'dtvMatriz
        '
        Me.dtvMatriz.AllowUserToAddRows = False
        Me.dtvMatriz.AllowUserToDeleteRows = False
        Me.dtvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtvMatriz.ColumnHeadersVisible = False
        Me.dtvMatriz.Location = New System.Drawing.Point(21, 24)
        Me.dtvMatriz.Name = "dtvMatriz"
        Me.dtvMatriz.RowHeadersVisible = False
        Me.dtvMatriz.Size = New System.Drawing.Size(286, 159)
        Me.dtvMatriz.TabIndex = 1
        '
        'dtvNuevaMatriz
        '
        Me.dtvNuevaMatriz.AllowUserToAddRows = False
        Me.dtvNuevaMatriz.AllowUserToDeleteRows = False
        Me.dtvNuevaMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtvNuevaMatriz.ColumnHeadersVisible = False
        Me.dtvNuevaMatriz.Location = New System.Drawing.Point(21, 288)
        Me.dtvNuevaMatriz.Name = "dtvNuevaMatriz"
        Me.dtvNuevaMatriz.ReadOnly = True
        Me.dtvNuevaMatriz.RowHeadersVisible = False
        Me.dtvNuevaMatriz.Size = New System.Drawing.Size(164, 73)
        Me.dtvNuevaMatriz.TabIndex = 2
        '
        'dtvVector
        '
        Me.dtvVector.AllowUserToAddRows = False
        Me.dtvVector.AllowUserToDeleteRows = False
        Me.dtvVector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtvVector.ColumnHeadersVisible = False
        Me.dtvVector.Location = New System.Drawing.Point(21, 223)
        Me.dtvVector.Name = "dtvVector"
        Me.dtvVector.ReadOnly = True
        Me.dtvVector.RowHeadersVisible = False
        Me.dtvVector.Size = New System.Drawing.Size(211, 27)
        Me.dtvVector.TabIndex = 3
        '
        'lblVector
        '
        Me.lblVector.AutoSize = True
        Me.lblVector.Location = New System.Drawing.Point(18, 207)
        Me.lblVector.Name = "lblVector"
        Me.lblVector.Size = New System.Drawing.Size(39, 13)
        Me.lblVector.TabIndex = 4
        Me.lblVector.Text = "Label1"
        '
        'lblNuevaMatriz
        '
        Me.lblNuevaMatriz.AutoSize = True
        Me.lblNuevaMatriz.Location = New System.Drawing.Point(18, 272)
        Me.lblNuevaMatriz.Name = "lblNuevaMatriz"
        Me.lblNuevaMatriz.Size = New System.Drawing.Size(39, 13)
        Me.lblNuevaMatriz.TabIndex = 5
        Me.lblNuevaMatriz.Text = "Label2"
        '
        'lblMatriz
        '
        Me.lblMatriz.AutoSize = True
        Me.lblMatriz.Location = New System.Drawing.Point(18, 8)
        Me.lblMatriz.Name = "lblMatriz"
        Me.lblMatriz.Size = New System.Drawing.Size(39, 13)
        Me.lblMatriz.TabIndex = 6
        Me.lblMatriz.Text = "Label3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblMatriz)
        Me.Controls.Add(Me.lblNuevaMatriz)
        Me.Controls.Add(Me.lblVector)
        Me.Controls.Add(Me.dtvVector)
        Me.Controls.Add(Me.dtvNuevaMatriz)
        Me.Controls.Add(Me.dtvMatriz)
        Me.Controls.Add(Me.cmdEjecutar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dtvMatriz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtvNuevaMatriz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtvVector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdEjecutar As Button
    Friend WithEvents dtvMatriz As DataGridView
    Friend WithEvents dtvNuevaMatriz As DataGridView
    Friend WithEvents dtvVector As DataGridView
    Friend WithEvents lblVector As Label
    Friend WithEvents lblNuevaMatriz As Label
    Friend WithEvents lblMatriz As Label
End Class
