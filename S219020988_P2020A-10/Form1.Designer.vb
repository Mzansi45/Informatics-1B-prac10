<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTTP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnResize = New System.Windows.Forms.Button()
        Me.btnCapture = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnRate = New System.Windows.Forms.Button()
        Me.grid1 = New UJGrid.UJGrid()
        Me.SuspendLayout()
        '
        'btnResize
        '
        Me.btnResize.Location = New System.Drawing.Point(12, 12)
        Me.btnResize.Name = "btnResize"
        Me.btnResize.Size = New System.Drawing.Size(116, 41)
        Me.btnResize.TabIndex = 0
        Me.btnResize.Text = "INITIALIZE AND LABEL GRID"
        Me.btnResize.UseVisualStyleBackColor = True
        '
        'btnCapture
        '
        Me.btnCapture.Location = New System.Drawing.Point(12, 83)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(116, 41)
        Me.btnCapture.TabIndex = 1
        Me.btnCapture.Text = "CAPTURE INFORMATION"
        Me.btnCapture.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 155)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(116, 41)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "CALCULATE"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnRate
        '
        Me.btnRate.Location = New System.Drawing.Point(12, 229)
        Me.btnRate.Name = "btnRate"
        Me.btnRate.Size = New System.Drawing.Size(116, 41)
        Me.btnRate.TabIndex = 3
        Me.btnRate.Text = "RATE"
        Me.btnRate.UseVisualStyleBackColor = True
        '
        'grid1
        '
        Me.grid1.FixedCols = 1
        Me.grid1.FixedRows = 1
        Me.grid1.Location = New System.Drawing.Point(146, 12)
        Me.grid1.Name = "grid1"
        Me.grid1.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grid1.Size = New System.Drawing.Size(537, 308)
        Me.grid1.TabIndex = 4
        '
        'frmTTP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 332)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.btnRate)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnCapture)
        Me.Controls.Add(Me.btnResize)
        Me.Name = "frmTTP"
        Me.Text = "TT PAINTING"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnResize As Button
    Friend WithEvents btnCapture As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnRate As Button
    Friend WithEvents grid1 As UJGrid.UJGrid
End Class
