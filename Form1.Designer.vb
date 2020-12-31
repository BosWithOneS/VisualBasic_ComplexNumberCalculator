<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Num1_TextBox_Part1 = New System.Windows.Forms.TextBox()
        Me.Num1_TextBox_Part2 = New System.Windows.Forms.TextBox()
        Me.Num1Label = New System.Windows.Forms.Label()
        Me.Num2Label = New System.Windows.Forms.Label()
        Me.Num2_TextBox_Part2 = New System.Windows.Forms.TextBox()
        Me.Num2_TextBox_Part1 = New System.Windows.Forms.TextBox()
        Me.Num1SelectGroupBox = New System.Windows.Forms.GroupBox()
        Me.Num1RectangularRadio = New System.Windows.Forms.RadioButton()
        Me.Num1PolarRadio = New System.Windows.Forms.RadioButton()
        Me.Num2SelectGroupBox = New System.Windows.Forms.GroupBox()
        Me.Num2RectangularRadio = New System.Windows.Forms.RadioButton()
        Me.Num2PolarRadio = New System.Windows.Forms.RadioButton()
        Me.OperationSelectGroupBox = New System.Windows.Forms.GroupBox()
        Me.DivideRadioButton = New System.Windows.Forms.RadioButton()
        Me.MultiplyRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubtractRadioButton = New System.Windows.Forms.RadioButton()
        Me.AddRadioButton = New System.Windows.Forms.RadioButton()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.AnswerInGroupBox = New System.Windows.Forms.GroupBox()
        Me.AnswerInRectangularRadio = New System.Windows.Forms.RadioButton()
        Me.AnswerInPolarRadio = New System.Windows.Forms.RadioButton()
        Me.AnswerTextBox = New System.Windows.Forms.TextBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.InstructionLabel = New System.Windows.Forms.Label()
        Me.QuickConverterButton = New System.Windows.Forms.Button()
        Me.RyLabel = New System.Windows.Forms.Label()
        Me.Num1SelectGroupBox.SuspendLayout()
        Me.Num2SelectGroupBox.SuspendLayout()
        Me.OperationSelectGroupBox.SuspendLayout()
        Me.AnswerInGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(13, 326)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "EXIT"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Num1_TextBox_Part1
        '
        Me.Num1_TextBox_Part1.Location = New System.Drawing.Point(232, 38)
        Me.Num1_TextBox_Part1.Name = "Num1_TextBox_Part1"
        Me.Num1_TextBox_Part1.Size = New System.Drawing.Size(100, 20)
        Me.Num1_TextBox_Part1.TabIndex = 1
        '
        'Num1_TextBox_Part2
        '
        Me.Num1_TextBox_Part2.Location = New System.Drawing.Point(349, 38)
        Me.Num1_TextBox_Part2.Name = "Num1_TextBox_Part2"
        Me.Num1_TextBox_Part2.Size = New System.Drawing.Size(100, 20)
        Me.Num1_TextBox_Part2.TabIndex = 2
        '
        'Num1Label
        '
        Me.Num1Label.AutoSize = True
        Me.Num1Label.Location = New System.Drawing.Point(173, 38)
        Me.Num1Label.Name = "Num1Label"
        Me.Num1Label.Size = New System.Drawing.Size(53, 13)
        Me.Num1Label.TabIndex = 3
        Me.Num1Label.Text = "Number 1"
        '
        'Num2Label
        '
        Me.Num2Label.AutoSize = True
        Me.Num2Label.Location = New System.Drawing.Point(173, 88)
        Me.Num2Label.Name = "Num2Label"
        Me.Num2Label.Size = New System.Drawing.Size(53, 13)
        Me.Num2Label.TabIndex = 6
        Me.Num2Label.Text = "Number 2"
        '
        'Num2_TextBox_Part2
        '
        Me.Num2_TextBox_Part2.Location = New System.Drawing.Point(349, 88)
        Me.Num2_TextBox_Part2.Name = "Num2_TextBox_Part2"
        Me.Num2_TextBox_Part2.Size = New System.Drawing.Size(100, 20)
        Me.Num2_TextBox_Part2.TabIndex = 5
        '
        'Num2_TextBox_Part1
        '
        Me.Num2_TextBox_Part1.Location = New System.Drawing.Point(232, 88)
        Me.Num2_TextBox_Part1.Name = "Num2_TextBox_Part1"
        Me.Num2_TextBox_Part1.Size = New System.Drawing.Size(100, 20)
        Me.Num2_TextBox_Part1.TabIndex = 4
        '
        'Num1SelectGroupBox
        '
        Me.Num1SelectGroupBox.Controls.Add(Me.Num1RectangularRadio)
        Me.Num1SelectGroupBox.Controls.Add(Me.Num1PolarRadio)
        Me.Num1SelectGroupBox.Location = New System.Drawing.Point(12, 23)
        Me.Num1SelectGroupBox.Name = "Num1SelectGroupBox"
        Me.Num1SelectGroupBox.Size = New System.Drawing.Size(154, 39)
        Me.Num1SelectGroupBox.TabIndex = 7
        Me.Num1SelectGroupBox.TabStop = False
        Me.Num1SelectGroupBox.Text = "Number1"
        '
        'Num1RectangularRadio
        '
        Me.Num1RectangularRadio.AutoSize = True
        Me.Num1RectangularRadio.Location = New System.Drawing.Point(62, 16)
        Me.Num1RectangularRadio.Name = "Num1RectangularRadio"
        Me.Num1RectangularRadio.Size = New System.Drawing.Size(83, 17)
        Me.Num1RectangularRadio.TabIndex = 1
        Me.Num1RectangularRadio.TabStop = True
        Me.Num1RectangularRadio.Text = "Rectangular"
        Me.Num1RectangularRadio.UseVisualStyleBackColor = True
        '
        'Num1PolarRadio
        '
        Me.Num1PolarRadio.AutoSize = True
        Me.Num1PolarRadio.Location = New System.Drawing.Point(7, 16)
        Me.Num1PolarRadio.Name = "Num1PolarRadio"
        Me.Num1PolarRadio.Size = New System.Drawing.Size(49, 17)
        Me.Num1PolarRadio.TabIndex = 0
        Me.Num1PolarRadio.TabStop = True
        Me.Num1PolarRadio.Text = "Polar"
        Me.Num1PolarRadio.UseVisualStyleBackColor = True
        '
        'Num2SelectGroupBox
        '
        Me.Num2SelectGroupBox.Controls.Add(Me.Num2RectangularRadio)
        Me.Num2SelectGroupBox.Controls.Add(Me.Num2PolarRadio)
        Me.Num2SelectGroupBox.Location = New System.Drawing.Point(12, 70)
        Me.Num2SelectGroupBox.Name = "Num2SelectGroupBox"
        Me.Num2SelectGroupBox.Size = New System.Drawing.Size(154, 39)
        Me.Num2SelectGroupBox.TabIndex = 8
        Me.Num2SelectGroupBox.TabStop = False
        Me.Num2SelectGroupBox.Text = "Number2"
        '
        'Num2RectangularRadio
        '
        Me.Num2RectangularRadio.AutoSize = True
        Me.Num2RectangularRadio.Location = New System.Drawing.Point(62, 16)
        Me.Num2RectangularRadio.Name = "Num2RectangularRadio"
        Me.Num2RectangularRadio.Size = New System.Drawing.Size(83, 17)
        Me.Num2RectangularRadio.TabIndex = 1
        Me.Num2RectangularRadio.TabStop = True
        Me.Num2RectangularRadio.Text = "Rectangular"
        Me.Num2RectangularRadio.UseVisualStyleBackColor = True
        '
        'Num2PolarRadio
        '
        Me.Num2PolarRadio.AutoSize = True
        Me.Num2PolarRadio.Location = New System.Drawing.Point(7, 16)
        Me.Num2PolarRadio.Name = "Num2PolarRadio"
        Me.Num2PolarRadio.Size = New System.Drawing.Size(49, 17)
        Me.Num2PolarRadio.TabIndex = 0
        Me.Num2PolarRadio.TabStop = True
        Me.Num2PolarRadio.Text = "Polar"
        Me.Num2PolarRadio.UseVisualStyleBackColor = True
        '
        'OperationSelectGroupBox
        '
        Me.OperationSelectGroupBox.Controls.Add(Me.DivideRadioButton)
        Me.OperationSelectGroupBox.Controls.Add(Me.MultiplyRadioButton)
        Me.OperationSelectGroupBox.Controls.Add(Me.SubtractRadioButton)
        Me.OperationSelectGroupBox.Controls.Add(Me.AddRadioButton)
        Me.OperationSelectGroupBox.Location = New System.Drawing.Point(12, 133)
        Me.OperationSelectGroupBox.Name = "OperationSelectGroupBox"
        Me.OperationSelectGroupBox.Size = New System.Drawing.Size(439, 52)
        Me.OperationSelectGroupBox.TabIndex = 9
        Me.OperationSelectGroupBox.TabStop = False
        Me.OperationSelectGroupBox.Text = "Operation"
        '
        'DivideRadioButton
        '
        Me.DivideRadioButton.AutoSize = True
        Me.DivideRadioButton.Location = New System.Drawing.Point(336, 20)
        Me.DivideRadioButton.Name = "DivideRadioButton"
        Me.DivideRadioButton.Size = New System.Drawing.Size(43, 17)
        Me.DivideRadioButton.TabIndex = 3
        Me.DivideRadioButton.TabStop = True
        Me.DivideRadioButton.Text = "DIV"
        Me.DivideRadioButton.UseVisualStyleBackColor = True
        '
        'MultiplyRadioButton
        '
        Me.MultiplyRadioButton.AutoSize = True
        Me.MultiplyRadioButton.Location = New System.Drawing.Point(226, 20)
        Me.MultiplyRadioButton.Name = "MultiplyRadioButton"
        Me.MultiplyRadioButton.Size = New System.Drawing.Size(48, 17)
        Me.MultiplyRadioButton.TabIndex = 2
        Me.MultiplyRadioButton.TabStop = True
        Me.MultiplyRadioButton.Text = "MUL"
        Me.MultiplyRadioButton.UseVisualStyleBackColor = True
        '
        'SubtractRadioButton
        '
        Me.SubtractRadioButton.AutoSize = True
        Me.SubtractRadioButton.Location = New System.Drawing.Point(117, 20)
        Me.SubtractRadioButton.Name = "SubtractRadioButton"
        Me.SubtractRadioButton.Size = New System.Drawing.Size(47, 17)
        Me.SubtractRadioButton.TabIndex = 1
        Me.SubtractRadioButton.TabStop = True
        Me.SubtractRadioButton.Text = "SUB"
        Me.SubtractRadioButton.UseVisualStyleBackColor = True
        '
        'AddRadioButton
        '
        Me.AddRadioButton.AutoSize = True
        Me.AddRadioButton.Location = New System.Drawing.Point(7, 20)
        Me.AddRadioButton.Name = "AddRadioButton"
        Me.AddRadioButton.Size = New System.Drawing.Size(48, 17)
        Me.AddRadioButton.TabIndex = 0
        Me.AddRadioButton.TabStop = True
        Me.AddRadioButton.Text = "ADD"
        Me.AddRadioButton.UseVisualStyleBackColor = True
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(12, 264)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 23)
        Me.CalculateButton.TabIndex = 10
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'AnswerInGroupBox
        '
        Me.AnswerInGroupBox.Controls.Add(Me.AnswerInRectangularRadio)
        Me.AnswerInGroupBox.Controls.Add(Me.AnswerInPolarRadio)
        Me.AnswerInGroupBox.Location = New System.Drawing.Point(12, 202)
        Me.AnswerInGroupBox.Name = "AnswerInGroupBox"
        Me.AnswerInGroupBox.Size = New System.Drawing.Size(154, 39)
        Me.AnswerInGroupBox.TabIndex = 9
        Me.AnswerInGroupBox.TabStop = False
        Me.AnswerInGroupBox.Text = "AnswerIn"
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
        Me.AnswerTextBox.Location = New System.Drawing.Point(129, 267)
        Me.AnswerTextBox.Name = "AnswerTextBox"
        Me.AnswerTextBox.Size = New System.Drawing.Size(262, 30)
        Me.AnswerTextBox.TabIndex = 11
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(108, 326)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 12
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(237, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Magnitude / Real"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(354, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Angle / Imaginary"
        '
        'InstructionLabel
        '
        Me.InstructionLabel.AutoSize = True
        Me.InstructionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InstructionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.InstructionLabel.Location = New System.Drawing.Point(450, 13)
        Me.InstructionLabel.Name = "InstructionLabel"
        Me.InstructionLabel.Size = New System.Drawing.Size(187, 262)
        Me.InstructionLabel.TabIndex = 17
        Me.InstructionLabel.Text = resources.GetString("InstructionLabel.Text")
        '
        'QuickConverterButton
        '
        Me.QuickConverterButton.Location = New System.Drawing.Point(539, 326)
        Me.QuickConverterButton.Name = "QuickConverterButton"
        Me.QuickConverterButton.Size = New System.Drawing.Size(93, 23)
        Me.QuickConverterButton.TabIndex = 18
        Me.QuickConverterButton.Text = "Quick Converter"
        Me.QuickConverterButton.UseVisualStyleBackColor = True
        '
        'RyLabel
        '
        Me.RyLabel.AutoSize = True
        Me.RyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RyLabel.Location = New System.Drawing.Point(549, 280)
        Me.RyLabel.Name = "RyLabel"
        Me.RyLabel.Size = New System.Drawing.Size(83, 12)
        Me.RyLabel.TabIndex = 19
        Me.RyLabel.Text = "Made by Ryan Bos"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(644, 361)
        Me.Controls.Add(Me.RyLabel)
        Me.Controls.Add(Me.QuickConverterButton)
        Me.Controls.Add(Me.InstructionLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.AnswerTextBox)
        Me.Controls.Add(Me.AnswerInGroupBox)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.OperationSelectGroupBox)
        Me.Controls.Add(Me.Num2SelectGroupBox)
        Me.Controls.Add(Me.Num1SelectGroupBox)
        Me.Controls.Add(Me.Num2Label)
        Me.Controls.Add(Me.Num2_TextBox_Part2)
        Me.Controls.Add(Me.Num2_TextBox_Part1)
        Me.Controls.Add(Me.Num1Label)
        Me.Controls.Add(Me.Num1_TextBox_Part2)
        Me.Controls.Add(Me.Num1_TextBox_Part1)
        Me.Controls.Add(Me.ExitButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "ComplexNumberCalculator"
        Me.Num1SelectGroupBox.ResumeLayout(False)
        Me.Num1SelectGroupBox.PerformLayout()
        Me.Num2SelectGroupBox.ResumeLayout(False)
        Me.Num2SelectGroupBox.PerformLayout()
        Me.OperationSelectGroupBox.ResumeLayout(False)
        Me.OperationSelectGroupBox.PerformLayout()
        Me.AnswerInGroupBox.ResumeLayout(False)
        Me.AnswerInGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents Num1_TextBox_Part1 As TextBox
    Friend WithEvents Num1_TextBox_Part2 As TextBox
    Friend WithEvents Num1Label As Label
    Friend WithEvents Num2Label As Label
    Friend WithEvents Num2_TextBox_Part2 As TextBox
    Friend WithEvents Num2_TextBox_Part1 As TextBox
    Friend WithEvents Num1SelectGroupBox As GroupBox
    Friend WithEvents Num1RectangularRadio As RadioButton
    Friend WithEvents Num1PolarRadio As RadioButton
    Friend WithEvents Num2SelectGroupBox As GroupBox
    Friend WithEvents Num2RectangularRadio As RadioButton
    Friend WithEvents Num2PolarRadio As RadioButton
    Friend WithEvents OperationSelectGroupBox As GroupBox
    Friend WithEvents DivideRadioButton As RadioButton
    Friend WithEvents MultiplyRadioButton As RadioButton
    Friend WithEvents SubtractRadioButton As RadioButton
    Friend WithEvents AddRadioButton As RadioButton
    Friend WithEvents CalculateButton As Button
    Friend WithEvents AnswerInGroupBox As GroupBox
    Friend WithEvents AnswerInRectangularRadio As RadioButton
    Friend WithEvents AnswerInPolarRadio As RadioButton
    Friend WithEvents AnswerTextBox As TextBox
    Friend WithEvents ClearButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents InstructionLabel As Label
    Friend WithEvents QuickConverterButton As Button
    Friend WithEvents RyLabel As Label
End Class
