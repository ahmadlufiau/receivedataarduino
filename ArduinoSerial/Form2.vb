Imports System
Imports System.IO.Ports
Public Class Form2

    Dim comPORT As String
    Dim receivedData As String = ""
    Dim commandCount As Integer = 0

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
        LblTimerSpeed.Text = "Timer speed: " & Timer1.Interval
        comPORT = ""
        For Each sp As String In My.Computer.Ports.SerialPortNames
            CmbPort.Items.Add(sp)
        Next
    End Sub

    Private Sub CmbPort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbPort.SelectedIndexChanged
        If (CmbPort.SelectedItem <> "") Then
            comPORT = CmbPort.SelectedItem
        End If
    End Sub

    Private Sub BtnKonek_Click(sender As Object, e As EventArgs) Handles BtnKonek.Click
        If (BtnKonek.Text = "Connect") Then
            If (comPORT <> "") Then
                SerialPort1.Close()
                SerialPort1.PortName = comPORT
                SerialPort1.BaudRate = 9600
                SerialPort1.DataBits = 8
                SerialPort1.Parity = Parity.None
                SerialPort1.StopBits = StopBits.One
                SerialPort1.Handshake = Handshake.None
                SerialPort1.Encoding = System.Text.Encoding.Default 'very important!
                SerialPort1.ReadTimeout = 10000
                SerialPort1.Open()
                BtnKonek.Text = "Dis-connect"
                CmbPort.Enabled = False
                Timer1.Enabled = True
                LblTimer.Text = "Timer: ON"
            Else
                MsgBox("Select a COM port first")
            End If
        Else
            Timer1.Enabled = False
            SerialPort1.Close()
            BtnKonek.Text = "Connect"
            CmbPort.Enabled = True
            LblTimer.Text = "Timer: OFF"
            CmbPort.Text = String.Empty
            RichTextBox1.Text = ""
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        RichTextBox1.Text = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'stop the timer (stops this function being called while it is still working
        Timer1.Enabled = False
        LblTimer.Text = "Timer: OFF"


        ' get any new data and add the the global variable receivedData
        receivedData = ReceiveSerialData()

        'If receivedData contains a "<" and a ">" then we have data
        If ((receivedData.Contains("<") And receivedData.Contains(">"))) Then
            parseData()
        End If

        ' restart the timer
        Timer1.Enabled = True
        LblTimer.Text = "Timer: ON"
    End Sub

    Function ReceiveSerialData() As String
        ' returns new data from the serial connection
        Dim Incoming As String
        Try
            Incoming = SerialPort1.ReadExisting()
            If Incoming Is Nothing Then
                Return "nothing" & vbCrLf
            Else
                Return Incoming
            End If
        Catch ex As TimeoutException
            Return "Error: Serial Port read timed out."
        End Try
    End Function

    Function parseData()
        ' uses the global variable receivedData
        Dim pos1 As Integer
        Dim pos2 As Integer
        Dim length As Integer
        Dim newCommand As String
        Dim done As Boolean = False

        While (Not done)

            pos1 = receivedData.IndexOf("<") + 1
            pos2 = receivedData.IndexOf(">") + 1

            'occasionally we may not get complete data and the end marker will be in front of the start marker
            ' for exampe "55><"
            ' if pos2 < pos1 then remove the first part of the string from receivedData
            If (pos2 < pos1) Then
                receivedData = Microsoft.VisualBasic.Mid(receivedData, pos2 + 1)
                pos1 = receivedData.IndexOf("<") + 1
                pos2 = receivedData.IndexOf(">") + 1
            End If

            If (pos1 = 0 Or pos2 = 0) Then
                ' we do not have both start and end markers and we are done
                done = True

            Else
                ' we have both start and end markers

                length = pos2 - pos1 + 1
                If (length > 0) Then
                    'remove the start and end markers from the command
                    newCommand = Mid(receivedData, pos1 + 1, length - 2)

                    ' show the command in the text box
                    RichTextBox1.AppendText("Command = " & newCommand & vbCrLf)

                    'remove the command from receivedData
                    receivedData = Mid(receivedData, pos2 + 1)


                    ' B for button switch
                    If (newCommand(0) = "B") Then
                        If (newCommand(1) = "L") Then
                            LblBtnSwitchValue.Text = "LOW"
                        ElseIf (newCommand(1) = "H") Then
                            LblBtnSwitchValue.Text = "HIGH"
                        End If
                    End If ' (newCommand(0) = "B")


                    ' P for potentiometer
                    If (newCommand.Substring(0, 1) = "P") Then
                        LblPotenValue.Text = newCommand.Substring(1, 4)
                    End If '(newCommand.Substring(0, 1) = "P")


                    'T for temperature
                    If (newCommand.Substring(0, 1) = "T") Then
                        LblTempValue.Text = newCommand.Substring(1, 4)
                    End If '(newCommand.Substring(0, 1) = "P")

                    commandCount = commandCount + 1
                    LblCountValue.Text = commandCount

                End If ' (length > 0) 

            End If '(pos1 = 0 Or pos2 = 0)

        End While
    End Function

End Class