<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.dtpHour = New System.Windows.Forms.DateTimePicker()
        Me.lblState = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dtpHour
        '
        Me.dtpHour.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHour.Location = New System.Drawing.Point(27, 47)
        Me.dtpHour.Name = "dtpHour"
        Me.dtpHour.ShowUpDown = True
        Me.dtpHour.Size = New System.Drawing.Size(200, 20)
        Me.dtpHour.TabIndex = 0
        Me.dtpHour.Value = New Date(2018, 10, 9, 1, 0, 0, 0)
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(27, 74)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(109, 13)
        Me.lblState.TabIndex = 1
        Me.lblState.Text = "Property not initialised"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 130)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.dtpHour)
        Me.Name = "Form1"
        Me.Text = "What is Richard doing?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpHour As DateTimePicker
    Friend WithEvents lblState As Label
End Class
