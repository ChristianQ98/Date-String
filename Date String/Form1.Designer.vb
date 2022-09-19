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
        Me.txtDayOfWeek = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.txtDayOfMonth = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDateString = New System.Windows.Forms.Label()
        Me.btnShowDate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDayOfWeek
        '
        Me.txtDayOfWeek.Location = New System.Drawing.Point(367, 36)
        Me.txtDayOfWeek.Name = "txtDayOfWeek"
        Me.txtDayOfWeek.Size = New System.Drawing.Size(281, 31)
        Me.txtDayOfWeek.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter the day of the week"
        '
        'txtMonth
        '
        Me.txtMonth.Location = New System.Drawing.Point(367, 104)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(281, 31)
        Me.txtMonth.TabIndex = 2
        '
        'txtDayOfMonth
        '
        Me.txtDayOfMonth.Location = New System.Drawing.Point(367, 172)
        Me.txtDayOfMonth.Name = "txtDayOfMonth"
        Me.txtDayOfMonth.Size = New System.Drawing.Size(281, 31)
        Me.txtDayOfMonth.TabIndex = 3
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(367, 240)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(281, 31)
        Me.txtYear.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(127, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Enter the month"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(226, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Enter the day of the month"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(147, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Enter the year"
        '
        'lblDateString
        '
        Me.lblDateString.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDateString.Location = New System.Drawing.Point(41, 315)
        Me.lblDateString.Name = "lblDateString"
        Me.lblDateString.Size = New System.Drawing.Size(607, 48)
        Me.lblDateString.TabIndex = 8
        Me.lblDateString.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnShowDate
        '
        Me.btnShowDate.Location = New System.Drawing.Point(41, 394)
        Me.btnShowDate.Name = "btnShowDate"
        Me.btnShowDate.Size = New System.Drawing.Size(180, 34)
        Me.btnShowDate.TabIndex = 9
        Me.btnShowDate.Text = "Show Date"
        Me.btnShowDate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(264, 394)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(176, 34)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(473, 394)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(175, 34)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 451)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnShowDate)
        Me.Controls.Add(Me.lblDateString)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtDayOfMonth)
        Me.Controls.Add(Me.txtMonth)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDayOfWeek)
        Me.Name = "Form1"
        Me.Text = "Date String"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDayOfWeek As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMonth As TextBox
    Friend WithEvents txtDayOfMonth As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblDateString As Label
    Friend WithEvents btnShowDate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
