﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.IcImagingControl1 = New TIS.Imaging.ICImagingControl()
        Me.Start = New System.Windows.Forms.Button()
        Me.ZoomIn = New System.Windows.Forms.Button()
        Me.ZoomOut = New System.Windows.Forms.Button()
        Me.Settings = New System.Windows.Forms.Button()
        Me.Trigger = New System.Windows.Forms.Button()
        Me.ImgSave = New System.Windows.Forms.Button()
        Me.Path1 = New System.Windows.Forms.Button()
        Me.Path2 = New System.Windows.Forms.Button()
        Me.IncLow = New System.Windows.Forms.Button()
        Me.SaveConf = New System.Windows.Forms.Button()
        Me.LoadConf = New System.Windows.Forms.Button()
        Me.Bit64 = New System.Windows.Forms.Button()
        Me.SaveTiff = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.ShowImgNum = New System.Windows.Forms.Button()
        CType(Me.IcImagingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IcImagingControl1
        '
        Me.IcImagingControl1.BackColor = System.Drawing.Color.White
        Me.IcImagingControl1.DeviceListChangedExecutionMode = TIS.Imaging.EventExecutionMode.Invoke
        Me.IcImagingControl1.DeviceLostExecutionMode = TIS.Imaging.EventExecutionMode.AsyncInvoke
        Me.IcImagingControl1.ImageAvailableExecutionMode = TIS.Imaging.EventExecutionMode.MultiThreaded
        Me.IcImagingControl1.LiveDisplayPosition = New System.Drawing.Point(0, 0)
        Me.IcImagingControl1.Location = New System.Drawing.Point(0, 0)
        Me.IcImagingControl1.Name = "IcImagingControl1"
        Me.IcImagingControl1.Size = New System.Drawing.Size(757, 665)
        Me.IcImagingControl1.TabIndex = 0
        '
        'Start
        '
        Me.Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start.Location = New System.Drawing.Point(777, 27)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(146, 65)
        Me.Start.TabIndex = 1
        Me.Start.Text = "Start"
        Me.Start.UseVisualStyleBackColor = True
        '
        'ZoomIn
        '
        Me.ZoomIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZoomIn.Location = New System.Drawing.Point(777, 289)
        Me.ZoomIn.Name = "ZoomIn"
        Me.ZoomIn.Size = New System.Drawing.Size(146, 56)
        Me.ZoomIn.TabIndex = 2
        Me.ZoomIn.Text = "ZoomIn"
        Me.ZoomIn.UseVisualStyleBackColor = True
        '
        'ZoomOut
        '
        Me.ZoomOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZoomOut.Location = New System.Drawing.Point(777, 351)
        Me.ZoomOut.Name = "ZoomOut"
        Me.ZoomOut.Size = New System.Drawing.Size(146, 53)
        Me.ZoomOut.TabIndex = 3
        Me.ZoomOut.Text = "ZoomOut"
        Me.ZoomOut.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.Settings.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Settings.Location = New System.Drawing.Point(777, 455)
        Me.Settings.Name = "Settings"
        Me.Settings.Size = New System.Drawing.Size(146, 52)
        Me.Settings.TabIndex = 4
        Me.Settings.Text = "Settings"
        Me.Settings.UseVisualStyleBackColor = True
        '
        'Trigger
        '
        Me.Trigger.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Trigger.Location = New System.Drawing.Point(777, 99)
        Me.Trigger.Name = "Trigger"
        Me.Trigger.Size = New System.Drawing.Size(146, 60)
        Me.Trigger.TabIndex = 5
        Me.Trigger.Text = "Trigger"
        Me.Trigger.UseVisualStyleBackColor = True
        '
        'ImgSave
        '
        Me.ImgSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImgSave.Location = New System.Drawing.Point(777, 165)
        Me.ImgSave.Name = "ImgSave"
        Me.ImgSave.Size = New System.Drawing.Size(146, 66)
        Me.ImgSave.TabIndex = 6
        Me.ImgSave.Text = "ImgSave"
        Me.ImgSave.UseVisualStyleBackColor = True
        '
        'Path1
        '
        Me.Path1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Path1.Location = New System.Drawing.Point(946, 27)
        Me.Path1.Name = "Path1"
        Me.Path1.Size = New System.Drawing.Size(126, 60)
        Me.Path1.TabIndex = 7
        Me.Path1.Text = "PathHi"
        Me.Path1.UseVisualStyleBackColor = True
        '
        'Path2
        '
        Me.Path2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Path2.Location = New System.Drawing.Point(946, 99)
        Me.Path2.Name = "Path2"
        Me.Path2.Size = New System.Drawing.Size(126, 66)
        Me.Path2.TabIndex = 8
        Me.Path2.Text = "PathLo"
        Me.Path2.UseVisualStyleBackColor = True
        '
        'IncLow
        '
        Me.IncLow.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IncLow.Location = New System.Drawing.Point(943, 348)
        Me.IncLow.Name = "IncLow"
        Me.IncLow.Size = New System.Drawing.Size(126, 56)
        Me.IncLow.TabIndex = 9
        Me.IncLow.Text = "Disp Exp"
        Me.IncLow.UseVisualStyleBackColor = True
        '
        'SaveConf
        '
        Me.SaveConf.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveConf.Location = New System.Drawing.Point(943, 455)
        Me.SaveConf.Name = "SaveConf"
        Me.SaveConf.Size = New System.Drawing.Size(126, 52)
        Me.SaveConf.TabIndex = 11
        Me.SaveConf.Text = "SaveConf"
        Me.SaveConf.UseVisualStyleBackColor = True
        '
        'LoadConf
        '
        Me.LoadConf.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadConf.Location = New System.Drawing.Point(943, 513)
        Me.LoadConf.Name = "LoadConf"
        Me.LoadConf.Size = New System.Drawing.Size(126, 51)
        Me.LoadConf.TabIndex = 12
        Me.LoadConf.Text = "LoadConf"
        Me.LoadConf.UseVisualStyleBackColor = True
        '
        'Bit64
        '
        Me.Bit64.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bit64.Location = New System.Drawing.Point(943, 570)
        Me.Bit64.Name = "Bit64"
        Me.Bit64.Size = New System.Drawing.Size(126, 52)
        Me.Bit64.TabIndex = 13
        Me.Bit64.Text = "Bit64"
        Me.Bit64.UseVisualStyleBackColor = True
        '
        'SaveTiff
        '
        Me.SaveTiff.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveTiff.Location = New System.Drawing.Point(943, 628)
        Me.SaveTiff.Name = "SaveTiff"
        Me.SaveTiff.Size = New System.Drawing.Size(129, 52)
        Me.SaveTiff.TabIndex = 14
        Me.SaveTiff.Text = "SaveTiff"
        Me.SaveTiff.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(943, 289)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 35)
        Me.NumericUpDown1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(940, 244)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 31)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "EXP INC"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(783, 535)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 31)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Img Num"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown2.Location = New System.Drawing.Point(786, 582)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(120, 35)
        Me.NumericUpDown2.TabIndex = 18
        '
        'ShowImgNum
        '
        Me.ShowImgNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowImgNum.Location = New System.Drawing.Point(786, 628)
        Me.ShowImgNum.Name = "ShowImgNum"
        Me.ShowImgNum.Size = New System.Drawing.Size(137, 52)
        Me.ShowImgNum.TabIndex = 19
        Me.ShowImgNum.Text = "Disp Num"
        Me.ShowImgNum.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1118, 706)
        Me.Controls.Add(Me.ShowImgNum)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.SaveTiff)
        Me.Controls.Add(Me.Bit64)
        Me.Controls.Add(Me.LoadConf)
        Me.Controls.Add(Me.SaveConf)
        Me.Controls.Add(Me.IncLow)
        Me.Controls.Add(Me.Path2)
        Me.Controls.Add(Me.Path1)
        Me.Controls.Add(Me.ImgSave)
        Me.Controls.Add(Me.Trigger)
        Me.Controls.Add(Me.Settings)
        Me.Controls.Add(Me.ZoomOut)
        Me.Controls.Add(Me.ZoomIn)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.IcImagingControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.IcImagingControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IcImagingControl1 As TIS.Imaging.ICImagingControl
    Friend WithEvents Start As Button
    Friend WithEvents ZoomIn As Button
    Friend WithEvents ZoomOut As Button
    Friend WithEvents Settings As Button
    Friend WithEvents Trigger As Button
    Friend WithEvents ImgSave As Button
    Friend WithEvents Path1 As Button
    Friend WithEvents Path2 As Button
    Friend WithEvents IncLow As Button
    Friend WithEvents SaveConf As Button
    Friend WithEvents LoadConf As Button
    Friend WithEvents Bit64 As Button
    Friend WithEvents SaveTiff As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents ShowImgNum As Button
End Class
