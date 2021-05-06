Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Imports Microsoft.VisualStudio.Threading

Public Class Form1
    Dim listening As Boolean = False

    Dim cts As CancellationTokenSource

    Private Sub log(text As String)
        Me.Invoke(Sub() LogRTB.Text += $"{vbCrLf}{text}")
    End Sub

    Private Sub setValues(x As Double, y As Double, z As Double, yaw As Double, pitch As Double, roll As Double)
        RawDataXTB.Text = x.ToString("N03")
        RawDataYTB.Text = y.ToString("N03")
        RawDataZTB.Text = z.ToString("N03")

        RawDataPitchTB.Text = pitch.ToString("N03")
        RawDataYawTB.Text = yaw.ToString("N03")
        RawDataRollTB.Text = roll.ToString("N03")

    End Sub

    Private Async Function ListenUDPAsync(port As Integer, cancellationToken As CancellationToken) As Task
        Dim UDPClient = New UdpClient()
        UDPClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, True)

        log($"Listening to UDP on port: {port}")

        Dim iepRemoteEndPoint As IPEndPoint = New IPEndPoint(IPAddress.Any, port)

        UDPClient.Client.Bind(iepRemoteEndPoint)

        listening = True
        Try
            Dim strMessage As String = String.Empty
            Do
                Try

                    Dim receiveResults As UdpReceiveResult = Await UDPClient.ReceiveAsync().WithCancellation(cancellationToken)

                    If receiveResults.Buffer.Length <> 48 Then
                        log($"Buffer size was Not the right size {receiveResults.Buffer.Length }")
                        Continue Do
                    End If

                    Dim x = BitConverter.ToDouble(receiveResults.Buffer, 0)
                    Dim y = BitConverter.ToDouble(receiveResults.Buffer, 8)
                    Dim z = BitConverter.ToDouble(receiveResults.Buffer, 16)
                    Dim yaw = BitConverter.ToDouble(receiveResults.Buffer, 24)
                    Dim pitch = BitConverter.ToDouble(receiveResults.Buffer, 32)
                    Dim roll = BitConverter.ToDouble(receiveResults.Buffer, 40)

                    Me.Invoke(Sub() setValues(x, y, z, yaw, pitch, roll))

                Catch e As OperationCanceledException
                    listening = False
                End Try


            Loop While (listening)

            log($"Closing UDP connection")

            UDPClient.Close()
            UDPClient.Dispose()

        Catch e As Exception
            log(e.ToString())
        End Try

        listening = False
    End Function


    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Dim port As Integer
        Try
            port = Integer.Parse(PortTB.Text)
        Catch ex As Exception
            Return
        End Try

        StopButton.Enabled = True
        StartButton.Enabled = False
        cts = New CancellationTokenSource()
        ListenUDPAsync(port, cts.Token)
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        listening = False
        StopButton.Enabled = False


        If (cts IsNot Nothing) Then
            cts.Cancel()
        End If
        cts = Nothing

        StartButton.Enabled = True
    End Sub
End Class
