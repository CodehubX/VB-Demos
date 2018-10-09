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
        Me.lstFriends = New System.Windows.Forms.ListBox()
        Me.btnArrayElement = New System.Windows.Forms.Button()
        Me.btnEnumerateArray = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstFriends
        '
        Me.lstFriends.FormattingEnabled = True
        Me.lstFriends.IntegralHeight = False
        Me.lstFriends.Location = New System.Drawing.Point(12, 12)
        Me.lstFriends.Name = "lstFriends"
        Me.lstFriends.Size = New System.Drawing.Size(258, 426)
        Me.lstFriends.TabIndex = 0
        '
        'btnArrayElement
        '
        Me.btnArrayElement.Location = New System.Drawing.Point(288, 12)
        Me.btnArrayElement.Name = "btnArrayElement"
        Me.btnArrayElement.Size = New System.Drawing.Size(121, 23)
        Me.btnArrayElement.TabIndex = 1
        Me.btnArrayElement.Text = "Array Element"
        Me.btnArrayElement.UseVisualStyleBackColor = True
        '
        'btnEnumerateArray
        '
        Me.btnEnumerateArray.Location = New System.Drawing.Point(288, 42)
        Me.btnEnumerateArray.Name = "btnEnumerateArray"
        Me.btnEnumerateArray.Size = New System.Drawing.Size(121, 23)
        Me.btnEnumerateArray.TabIndex = 2
        Me.btnEnumerateArray.Text = "Enumerate Array"
        Me.btnEnumerateArray.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 450)
        Me.Controls.Add(Me.btnEnumerateArray)
        Me.Controls.Add(Me.btnArrayElement)
        Me.Controls.Add(Me.lstFriends)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstFriends As ListBox
    Friend WithEvents btnArrayElement As Button
    Friend WithEvents btnEnumerateArray As Button
End Class
