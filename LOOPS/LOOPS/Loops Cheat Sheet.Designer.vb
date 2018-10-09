<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.btnForNextLoop = New System.Windows.Forms.Button()
        Me.btnForNextLoopWithStep = New System.Windows.Forms.Button()
        Me.btnBackwardsForNextLoop = New System.Windows.Forms.Button()
        Me.btnForEachLoop = New System.Windows.Forms.Button()
        Me.btnDoLoopUntil = New System.Windows.Forms.Button()
        Me.btnDoWhileLoop = New System.Windows.Forms.Button()
        Me.btnNestedLoops = New System.Windows.Forms.Button()
        Me.btnQuittingAForLoop = New System.Windows.Forms.Button()
        Me.btnQuittingADoLoop = New System.Windows.Forms.Button()
        Me.btnAddition = New System.Windows.Forms.Button()
        Me.txtNumInput = New System.Windows.Forms.TextBox()
        Me.btnDoWhileClass = New System.Windows.Forms.Button()
        Me.btnCountdown = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstData
        '
        Me.lstData.FormattingEnabled = True
        Me.lstData.IntegralHeight = False
        Me.lstData.Location = New System.Drawing.Point(3, 67)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(291, 463)
        Me.lstData.TabIndex = 0
        '
        'btnForNextLoop
        '
        Me.btnForNextLoop.Location = New System.Drawing.Point(300, 25)
        Me.btnForNextLoop.Name = "btnForNextLoop"
        Me.btnForNextLoop.Size = New System.Drawing.Size(190, 23)
        Me.btnForNextLoop.TabIndex = 1
        Me.btnForNextLoop.Text = "For Next Loop"
        Me.btnForNextLoop.UseVisualStyleBackColor = True
        '
        'btnForNextLoopWithStep
        '
        Me.btnForNextLoopWithStep.Location = New System.Drawing.Point(300, 67)
        Me.btnForNextLoopWithStep.Name = "btnForNextLoopWithStep"
        Me.btnForNextLoopWithStep.Size = New System.Drawing.Size(190, 23)
        Me.btnForNextLoopWithStep.TabIndex = 2
        Me.btnForNextLoopWithStep.Text = "For Next Loop w/ Step"
        Me.btnForNextLoopWithStep.UseVisualStyleBackColor = True
        '
        'btnBackwardsForNextLoop
        '
        Me.btnBackwardsForNextLoop.Location = New System.Drawing.Point(299, 106)
        Me.btnBackwardsForNextLoop.Name = "btnBackwardsForNextLoop"
        Me.btnBackwardsForNextLoop.Size = New System.Drawing.Size(190, 23)
        Me.btnBackwardsForNextLoop.TabIndex = 3
        Me.btnBackwardsForNextLoop.Text = "Backwards For Next Loop"
        Me.btnBackwardsForNextLoop.UseVisualStyleBackColor = True
        '
        'btnForEachLoop
        '
        Me.btnForEachLoop.Location = New System.Drawing.Point(300, 145)
        Me.btnForEachLoop.Name = "btnForEachLoop"
        Me.btnForEachLoop.Size = New System.Drawing.Size(190, 23)
        Me.btnForEachLoop.TabIndex = 4
        Me.btnForEachLoop.Text = "For Each Loop"
        Me.btnForEachLoop.UseVisualStyleBackColor = True
        '
        'btnDoLoopUntil
        '
        Me.btnDoLoopUntil.Location = New System.Drawing.Point(300, 184)
        Me.btnDoLoopUntil.Name = "btnDoLoopUntil"
        Me.btnDoLoopUntil.Size = New System.Drawing.Size(190, 23)
        Me.btnDoLoopUntil.TabIndex = 5
        Me.btnDoLoopUntil.Text = "Do Until Loop"
        Me.btnDoLoopUntil.UseVisualStyleBackColor = True
        '
        'btnDoWhileLoop
        '
        Me.btnDoWhileLoop.Location = New System.Drawing.Point(300, 223)
        Me.btnDoWhileLoop.Name = "btnDoWhileLoop"
        Me.btnDoWhileLoop.Size = New System.Drawing.Size(190, 23)
        Me.btnDoWhileLoop.TabIndex = 6
        Me.btnDoWhileLoop.Text = "Do While Loop"
        Me.btnDoWhileLoop.UseVisualStyleBackColor = True
        '
        'btnNestedLoops
        '
        Me.btnNestedLoops.Location = New System.Drawing.Point(300, 262)
        Me.btnNestedLoops.Name = "btnNestedLoops"
        Me.btnNestedLoops.Size = New System.Drawing.Size(190, 23)
        Me.btnNestedLoops.TabIndex = 7
        Me.btnNestedLoops.Text = "Nested Loops"
        Me.btnNestedLoops.UseVisualStyleBackColor = True
        '
        'btnQuittingAForLoop
        '
        Me.btnQuittingAForLoop.Location = New System.Drawing.Point(300, 301)
        Me.btnQuittingAForLoop.Name = "btnQuittingAForLoop"
        Me.btnQuittingAForLoop.Size = New System.Drawing.Size(190, 23)
        Me.btnQuittingAForLoop.TabIndex = 8
        Me.btnQuittingAForLoop.Text = "Quitting a For Loop"
        Me.btnQuittingAForLoop.UseVisualStyleBackColor = True
        '
        'btnQuittingADoLoop
        '
        Me.btnQuittingADoLoop.Location = New System.Drawing.Point(300, 340)
        Me.btnQuittingADoLoop.Name = "btnQuittingADoLoop"
        Me.btnQuittingADoLoop.Size = New System.Drawing.Size(190, 23)
        Me.btnQuittingADoLoop.TabIndex = 9
        Me.btnQuittingADoLoop.Text = "Quitting a Do Loop"
        Me.btnQuittingADoLoop.UseVisualStyleBackColor = True
        '
        'btnAddition
        '
        Me.btnAddition.Location = New System.Drawing.Point(300, 379)
        Me.btnAddition.Name = "btnAddition"
        Me.btnAddition.Size = New System.Drawing.Size(190, 23)
        Me.btnAddition.TabIndex = 10
        Me.btnAddition.Text = "Add ( For...Each Loop )"
        Me.btnAddition.UseVisualStyleBackColor = True
        '
        'txtNumInput
        '
        Me.txtNumInput.Location = New System.Drawing.Point(13, 25)
        Me.txtNumInput.Name = "txtNumInput"
        Me.txtNumInput.Size = New System.Drawing.Size(100, 20)
        Me.txtNumInput.TabIndex = 11
        Me.txtNumInput.Text = "Enter Number"
        '
        'btnDoWhileClass
        '
        Me.btnDoWhileClass.Location = New System.Drawing.Point(300, 418)
        Me.btnDoWhileClass.Name = "btnDoWhileClass"
        Me.btnDoWhileClass.Size = New System.Drawing.Size(188, 23)
        Me.btnDoWhileClass.TabIndex = 12
        Me.btnDoWhileClass.Text = "Do...While Class"
        Me.btnDoWhileClass.UseVisualStyleBackColor = True
        '
        'btnCountdown
        '
        Me.btnCountdown.Location = New System.Drawing.Point(301, 457)
        Me.btnCountdown.Name = "btnCountdown"
        Me.btnCountdown.Size = New System.Drawing.Size(187, 23)
        Me.btnCountdown.TabIndex = 13
        Me.btnCountdown.Text = "Countdown Timer"
        Me.btnCountdown.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 535)
        Me.Controls.Add(Me.btnCountdown)
        Me.Controls.Add(Me.btnDoWhileClass)
        Me.Controls.Add(Me.txtNumInput)
        Me.Controls.Add(Me.btnAddition)
        Me.Controls.Add(Me.btnQuittingADoLoop)
        Me.Controls.Add(Me.btnQuittingAForLoop)
        Me.Controls.Add(Me.btnNestedLoops)
        Me.Controls.Add(Me.btnDoWhileLoop)
        Me.Controls.Add(Me.btnDoLoopUntil)
        Me.Controls.Add(Me.btnForEachLoop)
        Me.Controls.Add(Me.btnBackwardsForNextLoop)
        Me.Controls.Add(Me.btnForNextLoopWithStep)
        Me.Controls.Add(Me.btnForNextLoop)
        Me.Controls.Add(Me.lstData)
        Me.Name = "Form1"
        Me.Text = "Loops"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstData As ListBox
    Friend WithEvents btnForNextLoop As Button
    Friend WithEvents btnForNextLoopWithStep As Button
    Friend WithEvents btnBackwardsForNextLoop As Button
    Friend WithEvents btnForEachLoop As Button
    Friend WithEvents btnDoLoopUntil As Button
    Friend WithEvents btnDoWhileLoop As Button
    Friend WithEvents btnNestedLoops As Button
    Friend WithEvents btnQuittingAForLoop As Button
    Friend WithEvents btnQuittingADoLoop As Button
    Friend WithEvents btnAddition As Button
    Friend WithEvents txtNumInput As TextBox
    Friend WithEvents btnDoWhileClass As Button
    Friend WithEvents btnCountdown As Button
End Class
