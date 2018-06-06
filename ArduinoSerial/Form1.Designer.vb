<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormArduinoSerial
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbPort = New System.Windows.Forms.ComboBox()
        Me.BtnConnect = New System.Windows.Forms.Button()
        Me.LblTimer = New System.Windows.Forms.Label()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RtbData = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COM PORT"
        '
        'CbPort
        '
        Me.CbPort.FormattingEnabled = True
        Me.CbPort.Location = New System.Drawing.Point(109, 23)
        Me.CbPort.Name = "CbPort"
        Me.CbPort.Size = New System.Drawing.Size(121, 21)
        Me.CbPort.TabIndex = 1
        '
        'BtnConnect
        '
        Me.BtnConnect.Location = New System.Drawing.Point(246, 23)
        Me.BtnConnect.Name = "BtnConnect"
        Me.BtnConnect.Size = New System.Drawing.Size(75, 23)
        Me.BtnConnect.TabIndex = 2
        Me.BtnConnect.Text = "Connect"
        Me.BtnConnect.UseVisualStyleBackColor = True
        '
        'LblTimer
        '
        Me.LblTimer.AutoSize = True
        Me.LblTimer.Location = New System.Drawing.Point(16, 202)
        Me.LblTimer.Name = "LblTimer"
        Me.LblTimer.Size = New System.Drawing.Size(59, 13)
        Me.LblTimer.TabIndex = 4
        Me.LblTimer.Text = "Timer: OFF"
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(89, 195)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 23)
        Me.BtnClear.TabIndex = 5
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'RtbData
        '
        Me.RtbData.Location = New System.Drawing.Point(19, 55)
        Me.RtbData.Name = "RtbData"
        Me.RtbData.Size = New System.Drawing.Size(302, 134)
        Me.RtbData.TabIndex = 6
        Me.RtbData.Text = ""
        '
        'FormArduinoSerial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 261)
        Me.Controls.Add(Me.RtbData)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.LblTimer)
        Me.Controls.Add(Me.BtnConnect)
        Me.Controls.Add(Me.CbPort)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormArduinoSerial"
        Me.Text = "Form Arduino Serial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CbPort As ComboBox
    Friend WithEvents BtnConnect As Button
    Friend WithEvents LblTimer As Label
    Friend WithEvents BtnClear As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents RtbData As RichTextBox
End Class
