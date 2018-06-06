<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.LblTimerSpeed = New System.Windows.Forms.Label()
        Me.LblCountValue = New System.Windows.Forms.Label()
        Me.LblCount = New System.Windows.Forms.Label()
        Me.LblPotenValue = New System.Windows.Forms.Label()
        Me.LblPoten = New System.Windows.Forms.Label()
        Me.LblTempValue = New System.Windows.Forms.Label()
        Me.LblTemp = New System.Windows.Forms.Label()
        Me.LblBtnSwitchValue = New System.Windows.Forms.Label()
        Me.LblBtnSwitch = New System.Windows.Forms.Label()
        Me.CmbPort = New System.Windows.Forms.ComboBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnKonek = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.COMport_LBL = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblTimer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblTimerSpeed
        '
        Me.LblTimerSpeed.AutoSize = True
        Me.LblTimerSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTimerSpeed.Location = New System.Drawing.Point(19, 107)
        Me.LblTimerSpeed.Name = "LblTimerSpeed"
        Me.LblTimerSpeed.Size = New System.Drawing.Size(104, 20)
        Me.LblTimerSpeed.TabIndex = 56
        Me.LblTimerSpeed.Text = "Timer speed: "
        '
        'LblCountValue
        '
        Me.LblCountValue.AutoSize = True
        Me.LblCountValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCountValue.Location = New System.Drawing.Point(148, 292)
        Me.LblCountValue.Name = "LblCountValue"
        Me.LblCountValue.Size = New System.Drawing.Size(18, 20)
        Me.LblCountValue.TabIndex = 55
        Me.LblCountValue.Text = "0"
        '
        'LblCount
        '
        Me.LblCount.AutoSize = True
        Me.LblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCount.Location = New System.Drawing.Point(19, 292)
        Me.LblCount.Name = "LblCount"
        Me.LblCount.Size = New System.Drawing.Size(130, 20)
        Me.LblCount.TabIndex = 54
        Me.LblCount.Text = "Command count:"
        '
        'LblPotenValue
        '
        Me.LblPotenValue.AutoSize = True
        Me.LblPotenValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPotenValue.Location = New System.Drawing.Point(151, 245)
        Me.LblPotenValue.Name = "LblPotenValue"
        Me.LblPotenValue.Size = New System.Drawing.Size(46, 20)
        Me.LblPotenValue.TabIndex = 53
        Me.LblPotenValue.Text = "value"
        '
        'LblPoten
        '
        Me.LblPoten.AutoSize = True
        Me.LblPoten.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPoten.Location = New System.Drawing.Point(19, 245)
        Me.LblPoten.Name = "LblPoten"
        Me.LblPoten.Size = New System.Drawing.Size(113, 20)
        Me.LblPoten.TabIndex = 52
        Me.LblPoten.Text = "Potentiometer:"
        '
        'LblTempValue
        '
        Me.LblTempValue.AutoSize = True
        Me.LblTempValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTempValue.Location = New System.Drawing.Point(151, 211)
        Me.LblTempValue.Name = "LblTempValue"
        Me.LblTempValue.Size = New System.Drawing.Size(46, 20)
        Me.LblTempValue.TabIndex = 51
        Me.LblTempValue.Text = "value"
        '
        'LblTemp
        '
        Me.LblTemp.AutoSize = True
        Me.LblTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTemp.Location = New System.Drawing.Point(19, 211)
        Me.LblTemp.Name = "LblTemp"
        Me.LblTemp.Size = New System.Drawing.Size(104, 20)
        Me.LblTemp.TabIndex = 50
        Me.LblTemp.Text = "Temperature:"
        '
        'LblBtnSwitchValue
        '
        Me.LblBtnSwitchValue.AutoSize = True
        Me.LblBtnSwitchValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBtnSwitchValue.Location = New System.Drawing.Point(151, 177)
        Me.LblBtnSwitchValue.Name = "LblBtnSwitchValue"
        Me.LblBtnSwitchValue.Size = New System.Drawing.Size(46, 20)
        Me.LblBtnSwitchValue.TabIndex = 49
        Me.LblBtnSwitchValue.Text = "value"
        '
        'LblBtnSwitch
        '
        Me.LblBtnSwitch.AutoSize = True
        Me.LblBtnSwitch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBtnSwitch.Location = New System.Drawing.Point(19, 177)
        Me.LblBtnSwitch.Name = "LblBtnSwitch"
        Me.LblBtnSwitch.Size = New System.Drawing.Size(112, 20)
        Me.LblBtnSwitch.TabIndex = 48
        Me.LblBtnSwitch.Text = "Button Switch:"
        '
        'CmbPort
        '
        Me.CmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPort.FormattingEnabled = True
        Me.CmbPort.Location = New System.Drawing.Point(19, 37)
        Me.CmbPort.Name = "CmbPort"
        Me.CmbPort.Size = New System.Drawing.Size(121, 28)
        Me.CmbPort.TabIndex = 42
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.HideSelection = False
        Me.RichTextBox1.Location = New System.Drawing.Point(279, 37)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(181, 228)
        Me.RichTextBox1.TabIndex = 46
        Me.RichTextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(341, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "INPUT"
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(329, 294)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 23)
        Me.BtnClear.TabIndex = 44
        Me.BtnClear.Text = "CLEAR"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnKonek
        '
        Me.BtnKonek.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKonek.Location = New System.Drawing.Point(151, 37)
        Me.BtnKonek.Name = "BtnKonek"
        Me.BtnKonek.Size = New System.Drawing.Size(102, 32)
        Me.BtnKonek.TabIndex = 43
        Me.BtnKonek.Text = "Connect"
        Me.BtnKonek.UseVisualStyleBackColor = True
        '
        'COMport_LBL
        '
        Me.COMport_LBL.AutoSize = True
        Me.COMport_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COMport_LBL.Location = New System.Drawing.Point(19, 14)
        Me.COMport_LBL.Name = "COMport_LBL"
        Me.COMport_LBL.Size = New System.Drawing.Size(78, 20)
        Me.COMport_LBL.TabIndex = 41
        Me.COMport_LBL.Text = "COM Port"
        '
        'Timer1
        '
        '
        'LblTimer
        '
        Me.LblTimer.AutoSize = True
        Me.LblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTimer.Location = New System.Drawing.Point(19, 83)
        Me.LblTimer.Name = "LblTimer"
        Me.LblTimer.Size = New System.Drawing.Size(88, 20)
        Me.LblTimer.TabIndex = 47
        Me.LblTimer.Text = "Timer: OFF"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 346)
        Me.Controls.Add(Me.LblTimerSpeed)
        Me.Controls.Add(Me.LblCountValue)
        Me.Controls.Add(Me.LblCount)
        Me.Controls.Add(Me.LblPotenValue)
        Me.Controls.Add(Me.LblPoten)
        Me.Controls.Add(Me.LblTempValue)
        Me.Controls.Add(Me.LblTemp)
        Me.Controls.Add(Me.LblBtnSwitchValue)
        Me.Controls.Add(Me.LblBtnSwitch)
        Me.Controls.Add(Me.CmbPort)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnKonek)
        Me.Controls.Add(Me.COMport_LBL)
        Me.Controls.Add(Me.LblTimer)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTimerSpeed As Label
    Friend WithEvents LblCountValue As Label
    Friend WithEvents LblCount As Label
    Friend WithEvents LblPotenValue As Label
    Friend WithEvents LblPoten As Label
    Friend WithEvents LblTempValue As Label
    Friend WithEvents LblTemp As Label
    Friend WithEvents LblBtnSwitchValue As Label
    Friend WithEvents LblBtnSwitch As Label
    Friend WithEvents CmbPort As ComboBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnKonek As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents COMport_LBL As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LblTimer As Label
End Class
