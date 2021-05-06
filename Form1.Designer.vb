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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PortTB = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RawDataRollTB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RawDataPitchTB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RawDataYawTB = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RawDataZTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RawDataYTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RawDataXTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.LogRTB = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Port"
        '
        'PortTB
        '
        Me.PortTB.Location = New System.Drawing.Point(48, 10)
        Me.PortTB.Name = "PortTB"
        Me.PortTB.Size = New System.Drawing.Size(100, 23)
        Me.PortTB.TabIndex = 1
        Me.PortTB.Text = "4747"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RawDataRollTB)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.RawDataPitchTB)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.RawDataYawTB)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.RawDataZTB)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.RawDataYTB)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.RawDataXTB)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(499, 115)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Raw Data"
        '
        'RawDataRollTB
        '
        Me.RawDataRollTB.Enabled = False
        Me.RawDataRollTB.Location = New System.Drawing.Point(284, 74)
        Me.RawDataRollTB.Name = "RawDataRollTB"
        Me.RawDataRollTB.ReadOnly = True
        Me.RawDataRollTB.Size = New System.Drawing.Size(200, 23)
        Me.RawDataRollTB.TabIndex = 15
        Me.RawDataRollTB.Text = "0.000"
        Me.RawDataRollTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(249, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 15)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Roll"
        '
        'RawDataPitchTB
        '
        Me.RawDataPitchTB.Enabled = False
        Me.RawDataPitchTB.Location = New System.Drawing.Point(284, 45)
        Me.RawDataPitchTB.Name = "RawDataPitchTB"
        Me.RawDataPitchTB.ReadOnly = True
        Me.RawDataPitchTB.Size = New System.Drawing.Size(200, 23)
        Me.RawDataPitchTB.TabIndex = 13
        Me.RawDataPitchTB.Text = "0.000"
        Me.RawDataPitchTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(249, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Pitch"
        '
        'RawDataYawTB
        '
        Me.RawDataYawTB.Enabled = False
        Me.RawDataYawTB.Location = New System.Drawing.Point(284, 16)
        Me.RawDataYawTB.Name = "RawDataYawTB"
        Me.RawDataYawTB.ReadOnly = True
        Me.RawDataYawTB.Size = New System.Drawing.Size(200, 23)
        Me.RawDataYawTB.TabIndex = 11
        Me.RawDataYawTB.Text = "0.000"
        Me.RawDataYawTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(249, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 15)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Yaw"
        '
        'RawDataZTB
        '
        Me.RawDataZTB.Enabled = False
        Me.RawDataZTB.Location = New System.Drawing.Point(41, 74)
        Me.RawDataZTB.Name = "RawDataZTB"
        Me.RawDataZTB.ReadOnly = True
        Me.RawDataZTB.Size = New System.Drawing.Size(200, 23)
        Me.RawDataZTB.TabIndex = 9
        Me.RawDataZTB.Text = "0.000"
        Me.RawDataZTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Z"
        '
        'RawDataYTB
        '
        Me.RawDataYTB.Enabled = False
        Me.RawDataYTB.Location = New System.Drawing.Point(41, 45)
        Me.RawDataYTB.Name = "RawDataYTB"
        Me.RawDataYTB.ReadOnly = True
        Me.RawDataYTB.Size = New System.Drawing.Size(200, 23)
        Me.RawDataYTB.TabIndex = 7
        Me.RawDataYTB.Text = "0.000"
        Me.RawDataYTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Y"
        '
        'RawDataXTB
        '
        Me.RawDataXTB.Enabled = False
        Me.RawDataXTB.Location = New System.Drawing.Point(41, 16)
        Me.RawDataXTB.Name = "RawDataXTB"
        Me.RawDataXTB.ReadOnly = True
        Me.RawDataXTB.Size = New System.Drawing.Size(200, 23)
        Me.RawDataXTB.TabIndex = 5
        Me.RawDataXTB.Text = "0.000"
        Me.RawDataXTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "X"
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(154, 9)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(75, 23)
        Me.StartButton.TabIndex = 5
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'StopButton
        '
        Me.StopButton.Enabled = False
        Me.StopButton.Location = New System.Drawing.Point(235, 9)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(75, 23)
        Me.StopButton.TabIndex = 6
        Me.StopButton.Text = "Stop"
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'LogRTB
        '
        Me.LogRTB.Location = New System.Drawing.Point(12, 160)
        Me.LogRTB.Name = "LogRTB"
        Me.LogRTB.ReadOnly = True
        Me.LogRTB.Size = New System.Drawing.Size(500, 140)
        Me.LogRTB.TabIndex = 7
        Me.LogRTB.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 312)
        Me.Controls.Add(Me.LogRTB)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PortTB)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Open Track Input"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PortTB As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RawDataRollTB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents RawDataPitchTB As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents RawDataYawTB As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents RawDataZTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RawDataYTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RawDataXTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents StartButton As Button
    Friend WithEvents StopButton As Button
    Friend WithEvents LogRTB As RichTextBox
End Class
