<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    '   <System.Diagnostics.DebuggerNonUserCode()> _
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
    ' <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ForceItemsIntoToolBox1 = New MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox()
        Me.ModbusTCPCom1 = New AdvancedHMIDrivers.ModbusTCPCom(Me.components)
        Me.RUN_2 = New System.Windows.Forms.Timer(Me.components)
        Me.PilotLight1 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight2 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight3 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight4 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight5 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight6 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight7 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight8 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight9 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight10 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight11 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight12 = New AdvancedHMIControls.PilotLight()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.ModbusTCPCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 662)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "For Development Source Code Visit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "http://www.advancedhmi.com"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ModbusTCPCom1
        '
        Me.ModbusTCPCom1.DisableSubscriptions = False
        Me.ModbusTCPCom1.IniFileName = ""
        Me.ModbusTCPCom1.IniFileSection = Nothing
        Me.ModbusTCPCom1.IPAddress = "127.0.0.1"
        Me.ModbusTCPCom1.MaxReadGroupSize = 20
        Me.ModbusTCPCom1.PollRateOverride = 500
        Me.ModbusTCPCom1.SwapBytes = True
        Me.ModbusTCPCom1.SwapWords = False
        Me.ModbusTCPCom1.TcpipPort = CType(502US, UShort)
        Me.ModbusTCPCom1.TimeOut = 3000
        Me.ModbusTCPCom1.UnitId = CType(1, Byte)
        '
        'RUN_2
        '
        Me.RUN_2.Enabled = True
        Me.RUN_2.Interval = 1000
        '
        'PilotLight1
        '
        Me.PilotLight1.Blink = False
        Me.PilotLight1.ComComponent = Me.ModbusTCPCom1
        Me.PilotLight1.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight1.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Red
        Me.PilotLight1.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight1.Location = New System.Drawing.Point(392, 20)
        Me.PilotLight1.Name = "PilotLight1"
        Me.PilotLight1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight1.PLCAddressClick = ""
        Me.PilotLight1.PLCAddressText = ""
        Me.PilotLight1.PLCAddressValue = "00005"
        Me.PilotLight1.PLCAddressVisible = ""
        Me.PilotLight1.Size = New System.Drawing.Size(42, 62)
        Me.PilotLight1.TabIndex = 7
        Me.PilotLight1.Text = "PilotLight1"
        Me.PilotLight1.Value = False
        Me.PilotLight1.ValueToWrite = 0
        '
        'PilotLight2
        '
        Me.PilotLight2.Blink = False
        Me.PilotLight2.ComComponent = Me.ModbusTCPCom1
        Me.PilotLight2.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight2.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Yellow
        Me.PilotLight2.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight2.Location = New System.Drawing.Point(392, 58)
        Me.PilotLight2.Name = "PilotLight2"
        Me.PilotLight2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight2.PLCAddressClick = ""
        Me.PilotLight2.PLCAddressText = ""
        Me.PilotLight2.PLCAddressValue = "00004"
        Me.PilotLight2.PLCAddressVisible = ""
        Me.PilotLight2.Size = New System.Drawing.Size(42, 62)
        Me.PilotLight2.TabIndex = 8
        Me.PilotLight2.Text = "PilotLight2"
        Me.PilotLight2.Value = False
        Me.PilotLight2.ValueToWrite = 0
        '
        'PilotLight3
        '
        Me.PilotLight3.Blink = False
        Me.PilotLight3.ComComponent = Me.ModbusTCPCom1
        Me.PilotLight3.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight3.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight3.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight3.Location = New System.Drawing.Point(392, 95)
        Me.PilotLight3.Name = "PilotLight3"
        Me.PilotLight3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight3.PLCAddressClick = ""
        Me.PilotLight3.PLCAddressText = ""
        Me.PilotLight3.PLCAddressValue = "00003"
        Me.PilotLight3.PLCAddressVisible = ""
        Me.PilotLight3.Size = New System.Drawing.Size(42, 62)
        Me.PilotLight3.TabIndex = 9
        Me.PilotLight3.Text = "PilotLight3"
        Me.PilotLight3.Value = False
        Me.PilotLight3.ValueToWrite = 0
        '
        'PilotLight4
        '
        Me.PilotLight4.Blink = False
        Me.PilotLight4.ComComponent = Me.ModbusTCPCom1
        Me.PilotLight4.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight4.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Red
        Me.PilotLight4.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight4.Location = New System.Drawing.Point(611, 116)
        Me.PilotLight4.Name = "PilotLight4"
        Me.PilotLight4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight4.PLCAddressClick = ""
        Me.PilotLight4.PLCAddressText = ""
        Me.PilotLight4.PLCAddressValue = "00008"
        Me.PilotLight4.PLCAddressVisible = ""
        Me.PilotLight4.Size = New System.Drawing.Size(41, 60)
        Me.PilotLight4.TabIndex = 10
        Me.PilotLight4.Text = "PilotLight4"
        Me.PilotLight4.Value = False
        Me.PilotLight4.ValueToWrite = 0
        '
        'PilotLight5
        '
        Me.PilotLight5.Blink = False
        Me.PilotLight5.ComComponent = Me.ModbusTCPCom1
        Me.PilotLight5.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight5.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Yellow
        Me.PilotLight5.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight5.Location = New System.Drawing.Point(611, 152)
        Me.PilotLight5.Name = "PilotLight5"
        Me.PilotLight5.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight5.PLCAddressClick = ""
        Me.PilotLight5.PLCAddressText = ""
        Me.PilotLight5.PLCAddressValue = "00007"
        Me.PilotLight5.PLCAddressVisible = ""
        Me.PilotLight5.Size = New System.Drawing.Size(41, 60)
        Me.PilotLight5.TabIndex = 11
        Me.PilotLight5.Text = "PilotLight5"
        Me.PilotLight5.Value = False
        Me.PilotLight5.ValueToWrite = 0
        '
        'PilotLight6
        '
        Me.PilotLight6.Blink = False
        Me.PilotLight6.ComComponent = Me.ModbusTCPCom1
        Me.PilotLight6.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight6.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight6.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight6.Location = New System.Drawing.Point(611, 188)
        Me.PilotLight6.Name = "PilotLight6"
        Me.PilotLight6.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight6.PLCAddressClick = ""
        Me.PilotLight6.PLCAddressText = ""
        Me.PilotLight6.PLCAddressValue = "00006"
        Me.PilotLight6.PLCAddressVisible = ""
        Me.PilotLight6.Size = New System.Drawing.Size(41, 60)
        Me.PilotLight6.TabIndex = 12
        Me.PilotLight6.Text = "PilotLight6"
        Me.PilotLight6.Value = False
        Me.PilotLight6.ValueToWrite = 0
        '
        'PilotLight7
        '
        Me.PilotLight7.Blink = False
        Me.PilotLight7.ComComponent = Me.ModbusTCPCom1
        Me.PilotLight7.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight7.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Red
        Me.PilotLight7.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight7.Location = New System.Drawing.Point(260, 294)
        Me.PilotLight7.Name = "PilotLight7"
        Me.PilotLight7.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight7.PLCAddressClick = ""
        Me.PilotLight7.PLCAddressText = ""
        Me.PilotLight7.PLCAddressValue = "00008"
        Me.PilotLight7.PLCAddressVisible = ""
        Me.PilotLight7.Size = New System.Drawing.Size(41, 60)
        Me.PilotLight7.TabIndex = 13
        Me.PilotLight7.Text = "PilotLight7"
        Me.PilotLight7.Value = False
        Me.PilotLight7.ValueToWrite = 0
        '
        'PilotLight8
        '
        Me.PilotLight8.Blink = False
        Me.PilotLight8.ComComponent = Me.ModbusTCPCom1
        Me.PilotLight8.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight8.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Yellow
        Me.PilotLight8.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight8.Location = New System.Drawing.Point(260, 330)
        Me.PilotLight8.Name = "PilotLight8"
        Me.PilotLight8.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight8.PLCAddressClick = ""
        Me.PilotLight8.PLCAddressText = ""
        Me.PilotLight8.PLCAddressValue = "00007"
        Me.PilotLight8.PLCAddressVisible = ""
        Me.PilotLight8.Size = New System.Drawing.Size(41, 60)
        Me.PilotLight8.TabIndex = 14
        Me.PilotLight8.Text = "PilotLight8"
        Me.PilotLight8.Value = False
        Me.PilotLight8.ValueToWrite = 0
        '
        'PilotLight9
        '
        Me.PilotLight9.Blink = False
        Me.PilotLight9.ComComponent = Me.ModbusTCPCom1
        Me.PilotLight9.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight9.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight9.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight9.Location = New System.Drawing.Point(260, 366)
        Me.PilotLight9.Name = "PilotLight9"
        Me.PilotLight9.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight9.PLCAddressClick = ""
        Me.PilotLight9.PLCAddressText = ""
        Me.PilotLight9.PLCAddressValue = "00006"
        Me.PilotLight9.PLCAddressVisible = ""
        Me.PilotLight9.Size = New System.Drawing.Size(41, 60)
        Me.PilotLight9.TabIndex = 15
        Me.PilotLight9.Text = "PilotLight9"
        Me.PilotLight9.Value = False
        Me.PilotLight9.ValueToWrite = 0
        '
        'PilotLight10
        '
        Me.PilotLight10.Blink = False
        Me.PilotLight10.ComComponent = Me.ModbusTCPCom1
        Me.PilotLight10.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight10.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Red
        Me.PilotLight10.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight10.Location = New System.Drawing.Point(492, 391)
        Me.PilotLight10.Name = "PilotLight10"
        Me.PilotLight10.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight10.PLCAddressClick = ""
        Me.PilotLight10.PLCAddressText = ""
        Me.PilotLight10.PLCAddressValue = "00005"
        Me.PilotLight10.PLCAddressVisible = ""
        Me.PilotLight10.Size = New System.Drawing.Size(42, 62)
        Me.PilotLight10.TabIndex = 16
        Me.PilotLight10.Text = "PilotLight10"
        Me.PilotLight10.Value = False
        Me.PilotLight10.ValueToWrite = 0
        '
        'PilotLight11
        '
        Me.PilotLight11.Blink = False
        Me.PilotLight11.ComComponent = Me.ModbusTCPCom1
        Me.PilotLight11.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight11.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Yellow
        Me.PilotLight11.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight11.Location = New System.Drawing.Point(492, 429)
        Me.PilotLight11.Name = "PilotLight11"
        Me.PilotLight11.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight11.PLCAddressClick = ""
        Me.PilotLight11.PLCAddressText = ""
        Me.PilotLight11.PLCAddressValue = "00004"
        Me.PilotLight11.PLCAddressVisible = ""
        Me.PilotLight11.Size = New System.Drawing.Size(42, 62)
        Me.PilotLight11.TabIndex = 17
        Me.PilotLight11.Text = "PilotLight11"
        Me.PilotLight11.Value = False
        Me.PilotLight11.ValueToWrite = 0
        '
        'PilotLight12
        '
        Me.PilotLight12.Blink = False
        Me.PilotLight12.ComComponent = Me.ModbusTCPCom1
        Me.PilotLight12.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight12.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight12.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight12.Location = New System.Drawing.Point(492, 466)
        Me.PilotLight12.Name = "PilotLight12"
        Me.PilotLight12.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight12.PLCAddressClick = ""
        Me.PilotLight12.PLCAddressText = ""
        Me.PilotLight12.PLCAddressValue = "00003"
        Me.PilotLight12.PLCAddressVisible = ""
        Me.PilotLight12.Size = New System.Drawing.Size(42, 62)
        Me.PilotLight12.TabIndex = 18
        Me.PilotLight12.Text = "PilotLight12"
        Me.PilotLight12.Value = False
        Me.PilotLight12.ValueToWrite = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(436, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 512)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(125, 250)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(644, 44)
        Me.Button2.TabIndex = 20
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PilotLight10)
        Me.Controls.Add(Me.PilotLight11)
        Me.Controls.Add(Me.PilotLight12)
        Me.Controls.Add(Me.PilotLight7)
        Me.Controls.Add(Me.PilotLight8)
        Me.Controls.Add(Me.PilotLight9)
        Me.Controls.Add(Me.PilotLight4)
        Me.Controls.Add(Me.PilotLight5)
        Me.Controls.Add(Me.PilotLight6)
        Me.Controls.Add(Me.PilotLight1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PilotLight2)
        Me.Controls.Add(Me.PilotLight3)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.KeyPreview = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "AdvancedHMI v3.99x"
        CType(Me.ModbusTCPCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DF1ComWF1 As AdvancedHMIDrivers.SerialDF1forSLCMicroCom
    Friend WithEvents ForceItemsIntoToolBox1 As MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox
    Friend WithEvents ModbusTCPCom1 As AdvancedHMIDrivers.ModbusTCPCom
    Friend WithEvents RUN_2 As Timer
    Friend WithEvents PilotLight1 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight2 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight3 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight4 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight5 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight6 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight7 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight8 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight9 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight10 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight11 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight12 As AdvancedHMIControls.PilotLight
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
