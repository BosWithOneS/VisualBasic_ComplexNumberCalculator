<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuickConverterForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QuickConverterForm))
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.CalculatorButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumSelectGroupBox = New System.Windows.Forms.GroupBox()
        Me.NumInRectangularRadio = New System.Windows.Forms.RadioButton()
        Me.NumInPolarRadio = New System.Windows.Forms.RadioButton()
        Me.Num_TextBox_Part2 = New System.Windows.Forms.TextBox()
        Me.Num_TextBox_Part1 = New System.Windows.Forms.TextBox()
        Me.AnswerInGroupBox = New System.Windows.Forms.GroupBox()
        Me.AnswerInRectangularRadio = New System.Windows.Forms.RadioButton()
        Me.AnswerInPolarRadio = New System.Windows.Forms.RadioButton()
        Me.AnswerTextBox = New System.Windows.Forms.TextBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.NumSelectGroupBox.SuspendLayout()
        Me.AnswerInGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(12, 342)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'CalculatorButton
        '
        Me.CalculatorButton.Location = New System.Drawing.Point(181, 342)
        Me.CalculatorButton.Name = "CalculatorButton"
        Me.CalculatorButton.Size = New System.Drawing.Size(107, 23)
        Me.CalculatorButton.TabIndex = 1
        Me.CalculatorButton.Text = "Complex Calculator"
        Me.CalculatorButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(142, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Angle / Imaginary"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Magnitude / Real"
        '
        'NumSelectGroupBox
        '
        Me.NumSelectGroupBox.Controls.Add(Me.NumInRectangularRadio)
        Me.NumSelectGroupBox.Controls.Add(Me.NumInPolarRadio)
        Me.NumSelectGroupBox.Location = New System.Drawing.Point(13, 12)
        Me.NumSelectGroupBox.Name = "NumSelectGroupBox"
        Me.NumSelectGroupBox.Size = New System.Drawing.Size(154, 39)
        Me.NumSelectGroupBox.TabIndex = 18
        Me.NumSelectGroupBox.TabStop = False
        Me.NumSelectGroupBox.Text = "Number In?"
        '
        'NumInRectangularRadio
        '
        Me.NumInRectangularRadio.AutoSize = True
        Me.NumInRectangularRadio.Location = New System.Drawing.Point(62, 16)
        Me.NumInRectangularRadio.Name = "NumInRectangularRadio"
        Me.NumInRectangularRadio.Size = New System.Drawing.Size(83, 17)
        Me.NumInRectangularRadio.TabIndex = 1
        Me.NumInRectangularRadio.TabStop = True
        Me.NumInRectangularRadio.Text = "Rectangular"
        Me.NumInRectangularRadio.UseVisualStyleBackColor = True
        '
        'NumInPolarRadio
        '
        Me.NumInPolarRadio.AutoSize = True
        Me.NumInPolarRadio.Location = New System.Drawing.Point(7, 16)
        Me.NumInPolarRadio.Name = "NumInPolarRadio"
        Me.NumInPolarRadio.Size = New System.Drawing.Size(49, 17)
        Me.NumInPolarRadio.TabIndex = 0
        Me.NumInPolarRadio.TabStop = True
        Me.NumInPolarRadio.Text = "Polar"
        Me.NumInPolarRadio.UseVisualStyleBackColor = True
        '
        'Num_TextBox_Part2
        '
        Me.Num_TextBox_Part2.Location = New System.Drawing.Point(137, 96)
        Me.Num_TextBox_Part2.Name = "Num_TextBox_Part2"
        Me.Num_TextBox_Part2.Size = New System.Drawing.Size(100, 20)
        Me.Num_TextBox_Part2.TabIndex = 16
        '
        'Num_TextBox_Part1
        '
        Me.Num_TextBox_Part1.Location = New System.Drawing.Point(20, 96)
        Me.Num_TextBox_Part1.Name = "Num_TextBox_Part1"
        Me.Num_TextBox_Part1.Size = New System.Drawing.Size(100, 20)
        Me.Num_TextBox_Part1.TabIndex = 15
        '
        'AnswerInGroupBox
        '
        Me.AnswerInGroupBox.Controls.Add(Me.AnswerInRectangularRadio)
        Me.AnswerInGroupBox.Controls.Add(Me.AnswerInPolarRadio)
        Me.AnswerInGroupBox.Location = New System.Drawing.Point(13, 162)
        Me.AnswerInGroupBox.Name = "AnswerInGroupBox"
        Me.AnswerInGroupBox.Size = New System.Drawing.Size(154, 39)
        Me.AnswerInGroupBox.TabIndex = 21
        Me.AnswerInGroupBox.TabStop = False
        Me.AnswerInGroupBox.Text = "Answer In?"
        '
        'AnswerInRectangularRadio
        '
        Me.AnswerInRectangularRadio.AutoSize = True
        Me.AnswerInRectangularRadio.Location = New System.Drawing.Point(62, 16)
        Me.AnswerInRectangularRadio.Name = "AnswerInRectangularRadio"
        Me.AnswerInRectangularRadio.Size = New System.Drawing.Size(83, 17)
        Me.AnswerInRectangularRadio.TabIndex = 1
        Me.AnswerInRectangularRadio.TabStop = True
        Me.AnswerInRectangularRadio.Text = "Rectangular"
        Me.AnswerInRectangularRadio.UseVisualStyleBackColor = True
        '
        'AnswerInPolarRadio
        '
        Me.AnswerInPolarRadio.AutoSize = True
        Me.AnswerInPolarRadio.Location = New System.Drawing.Point(7, 16)
        Me.AnswerInPolarRadio.Name = "AnswerInPolarRadio"
        Me.AnswerInPolarRadio.Size = New System.Drawing.Size(49, 17)
        Me.AnswerInPolarRadio.TabIndex = 0
        Me.AnswerInPolarRadio.TabStop = True
        Me.AnswerInPolarRadio.Text = "Polar"
        Me.AnswerInPolarRadio.UseVisualStyleBackColor = True
        '
        'AnswerTextBox
        '
        Me.AnswerTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.AnswerTextBox.Location = New System.Drawing.Point(12, 280)
        Me.AnswerTextBox.Name = "AnswerTextBox"
        Me.AnswerTextBox.Size = New System.Drawing.Size(225, 30)
        Me.AnswerTextBox.TabIndex = 23
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(13, 240)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 23)
        Me.CalculateButton.TabIndex = 22
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'QuickConverterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 375)
        Me.Controls.Add(Me.AnswerTextBox)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.AnswerInGroupBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumSelectGroupBox)
        Me.Controls.Add(Me.Num_TextBox_Part2)
        Me.Controls.Add(Me.Num_TextBox_Part1)
        Me.Controls.Add(Me.CalculatorButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "QuickConverterForm"
        Me.Text = "QuickConverterForm"
        Me.NumSelectGroupBox.ResumeLayout(False)
        Me.NumSelectGroupBox.PerformLayout()
        Me.AnswerInGroupBox.ResumeLayout(False)
        Me.AnswerInGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents CalculatorButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NumSelectGroupBox As GroupBox
    Friend WithEvents NumInRectangularRadio As RadioButton
    Friend WithEvents NumInPolarRadio As RadioButton
    Friend WithEvents Num_TextBox_Part2 As TextBox
    Friend WithEvents Num_TextBox_Part1 As TextBox
    Friend WithEvents AnswerInGroupBox As GroupBox
    Friend WithEvents AnswerInRectangularRadio As RadioButton
    Friend WithEvents AnswerInPolarRadio As RadioButton
    Friend WithEvents AnswerTextBox As TextBox
    Friend WithEvents CalculateButton As Button
End Class
