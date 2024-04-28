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
        NumTextBox = New TextBox()
        NumLabel = New Label()
        OutPutLabel = New Label()
        OKButton = New Button()
        ExitButton = New Button()
        SuspendLayout()
        ' 
        ' NumTextBox
        ' 
        NumTextBox.Location = New Point(113, 31)
        NumTextBox.Name = "NumTextBox"
        NumTextBox.Size = New Size(174, 23)
        NumTextBox.TabIndex = 0
        ' 
        ' NumLabel
        ' 
        NumLabel.AutoSize = True
        NumLabel.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        NumLabel.Location = New Point(22, 31)
        NumLabel.Name = "NumLabel"
        NumLabel.Size = New Size(85, 21)
        NumLabel.TabIndex = 1
        NumLabel.Text = "Number  :"
        ' 
        ' OutPutLabel
        ' 
        OutPutLabel.AutoSize = True
        OutPutLabel.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        OutPutLabel.Location = New Point(67, 153)
        OutPutLabel.Name = "OutPutLabel"
        OutPutLabel.Size = New Size(0, 19)
        OutPutLabel.TabIndex = 2
        ' 
        ' OKButton
        ' 
        OKButton.BackColor = Color.OrangeRed
        OKButton.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        OKButton.Location = New Point(334, 24)
        OKButton.Name = "OKButton"
        OKButton.Size = New Size(92, 34)
        OKButton.TabIndex = 3
        OKButton.Text = "OK"
        OKButton.UseVisualStyleBackColor = False
        ' 
        ' ExitButton
        ' 
        ExitButton.BackColor = Color.OrangeRed
        ExitButton.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ExitButton.Location = New Point(334, 71)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(92, 34)
        ExitButton.TabIndex = 4
        ExitButton.Text = "EXIT"
        ExitButton.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Coral
        ClientSize = New Size(461, 300)
        Controls.Add(ExitButton)
        Controls.Add(OKButton)
        Controls.Add(OutPutLabel)
        Controls.Add(NumLabel)
        Controls.Add(NumTextBox)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NumTextBox As TextBox
    Friend WithEvents NumLabel As Label
    Friend WithEvents OutPutLabel As Label
    Friend WithEvents OKButton As Button
    Friend WithEvents ExitButton As Button
End Class
