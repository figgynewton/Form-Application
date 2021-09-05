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
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblEnterInteger = New System.Windows.Forms.Label()
        Me.btnDouble = New System.Windows.Forms.Button()
        Me.btnHalf = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(229, 50)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 20)
        Me.txtInput.TabIndex = 0
        '
        'lblEnterInteger
        '
        Me.lblEnterInteger.AutoSize = True
        Me.lblEnterInteger.Location = New System.Drawing.Point(79, 53)
        Me.lblEnterInteger.Name = "lblEnterInteger"
        Me.lblEnterInteger.Size = New System.Drawing.Size(86, 13)
        Me.lblEnterInteger.TabIndex = 1
        Me.lblEnterInteger.Text = "Enter an Integer:"
        '
        'btnDouble
        '
        Me.btnDouble.Location = New System.Drawing.Point(90, 130)
        Me.btnDouble.Name = "btnDouble"
        Me.btnDouble.Size = New System.Drawing.Size(75, 23)
        Me.btnDouble.TabIndex = 2
        Me.btnDouble.Text = "Double"
        Me.btnDouble.UseVisualStyleBackColor = True
        '
        'btnHalf
        '
        Me.btnHalf.Location = New System.Drawing.Point(229, 130)
        Me.btnHalf.Name = "btnHalf"
        Me.btnHalf.Size = New System.Drawing.Size(75, 23)
        Me.btnHalf.TabIndex = 3
        Me.btnHalf.Text = "Half"
        Me.btnHalf.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 450)
        Me.Controls.Add(Me.btnHalf)
        Me.Controls.Add(Me.btnDouble)
        Me.Controls.Add(Me.lblEnterInteger)
        Me.Controls.Add(Me.txtInput)
        Me.Name = "Form1"
        Me.Text = "Hannah Newton"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblEnterInteger As Label
    Friend WithEvents btnDouble As Button
    Friend WithEvents btnHalf As Button
End Class
