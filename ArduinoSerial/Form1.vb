Imports System
Imports System.IO.Ports
Public Class FormArduinoSerial

    Dim comPORT As String
    Dim receivedData As String = ""

    Private Sub FormArduinoSerial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
        comPORT = ""
        For Each sp As String In My.Computer.Ports.SerialPortNames
            CbPort.Items.Add(sp)
        Next
    End Sub

    Private Sub CbPort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbPort.SelectedIndexChanged
        If (CbPort.SelectedItem <> "") Then
            comPORT = CbPort.SelectedItem
        End If
    End Sub

    Private Sub BtnConnect_Click(sender As Object, e As EventArgs) Handles BtnConnect.Click
        If (BtnConnect.Text = "Connect") Then
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
                BtnConnect.Text = "Dis-connect"
                Timer1.Enabled = True
                LblTimer.Text = "Timer: ON"
            Else
                MsgBox("Select a COM port first")
            End If
        Else
            SerialPort1.Close()
            BtnConnect.Text = "Connect"
            Timer1.Enabled = False
            LblTimer.Text = "Timer: OFF"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        receivedData = ReceiveSerialData()
        RtbData.Text &= receivedData
    End Sub

    Function ReceiveSerialData() As String
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

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        RtbData.Text = ""
    End Sub

End Class
