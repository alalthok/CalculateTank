<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.btnContent1 = New System.Windows.Forms.Button()
        Me.btnContent2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnShell = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnContent1
        '
        Me.btnContent1.Font = New System.Drawing.Font("NewsGoth BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContent1.Location = New System.Drawing.Point(130, 100)
        Me.btnContent1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnContent1.Name = "btnContent1"
        Me.btnContent1.Size = New System.Drawing.Size(950, 40)
        Me.btnContent1.TabIndex = 0
        Me.btnContent1.Text = "Design Specification"
        Me.btnContent1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnContent1.UseVisualStyleBackColor = True
        '
        'btnContent2
        '
        Me.btnContent2.Font = New System.Drawing.Font("NewsGoth BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContent2.Location = New System.Drawing.Point(130, 148)
        Me.btnContent2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnContent2.Name = "btnContent2"
        Me.btnContent2.Size = New System.Drawing.Size(950, 40)
        Me.btnContent2.TabIndex = 1
        Me.btnContent2.Text = "Design Tank Capacity"
        Me.btnContent2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnContent2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1133, 49)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "STRENGTH CALCULATION FOR PARAXYLENE TANK"
        '
        'btnShell
        '
        Me.btnShell.Font = New System.Drawing.Font("NewsGoth BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShell.Location = New System.Drawing.Point(130, 196)
        Me.btnShell.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnShell.Name = "btnShell"
        Me.btnShell.Size = New System.Drawing.Size(950, 40)
        Me.btnShell.TabIndex = 3
        Me.btnShell.Text = "Design Calculation of Shell"
        Me.btnShell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShell.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.btnShell)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnContent2)
        Me.Controls.Add(Me.btnContent1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainMenu"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnContent1 As Button
    Friend WithEvents btnContent2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnShell As Button
End Class
