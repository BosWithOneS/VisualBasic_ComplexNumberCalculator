'RyanBos
'ComplexNumberCalculator
'11.19.2020
'Used to calculate any operation between 2 complex numbers of either rectangular form of polar form



Public Class MainForm

    'Variable Declaration

    Dim Num1_Part1 As Double 'Num 1 real or magnutide
    Dim Num1_Part2 As Double 'Num 1 Imaginary or angle

    Dim Num2_Part1 As Double 'Num 2 real or magnitude
    Dim Num2_Part2 As Double 'Num 2 imaginary or angle

    Dim Num1_PolarMagnitude As Double
    Dim Num1_PolarAngle As Double

    Dim Num1_RectangularReal As Double
    Dim Num1_RectangularImaginary As Double

    Dim Num2_PolarMagnitude As Double
    Dim Num2_PolarAngle As Double

    Dim Num2_RectangularReal As Double
    Dim Num2_RectangularImaginary As Double

    Dim Answer_RectangularReal As Double
    Dim Answer_RectangularImaginary As Double

    Dim Answer_PolarMagnitude As Double
    Dim Answer_PolarAngle As Double

    Dim Answer_Part1 As Double
    Dim Answer_Part2 As Double

    Dim Accuarcy As Integer = 4 'For the number of decimal places the answer will show

    Public Function RectangularToPolarMagnitude(ByVal RectangularRealValue As Double, RectangularImaginaryValue As Double) As Double
        Dim ResultMagnitude As Double

        'Get polar magnitude
        ResultMagnitude = (Math.Sqrt((RectangularRealValue ^ 2) + (RectangularImaginaryValue ^ 2)))

        'Keeps it to accuracy ammount of decimal places
        ResultMagnitude = Math.Round(ResultMagnitude, Accuarcy)

        'Return polar magnitude
        Return ResultMagnitude

    End Function

    Public Function RectangularToPolarAngle(ByVal RectangularRealValue As Double, RectangularImaginaryValue As Double) As Double
        Dim ResultAngle As Double

        'Get polar angle
        ResultAngle = (Math.Atan((RectangularImaginaryValue / RectangularRealValue)))

        'Turns result into degrees
        ResultAngle = (ResultAngle * 180) / (Math.PI)

        'Keeps it to accuracy ammount of decimal places
        ResultAngle = Math.Round(ResultAngle, Accuarcy)

        'Return polar angle
        Return ResultAngle

    End Function

    Public Function PolarToRectangularReal(ByVal PolarMagnitudeValue As Double, PolarAngleValue As Double) As Double
        Dim ResultReal As Double

        'Get rectangular real
        ResultReal = (PolarMagnitudeValue * (Math.Cos((PolarAngleValue * (Math.PI)) / 180)))

        'Keeps it to accuracy ammount of decimal places
        ResultReal = Math.Round(ResultReal, Accuarcy)


        'Return Real part
        Return ResultReal
    End Function

    Public Function PolarToRectangularImaginary(ByVal PolarMagnitudeValue As Double, PolarAngleValue As Double) As Double
        Dim ResultImaginary As Double

        'Get rectangular imaginary
        ResultImaginary = (PolarMagnitudeValue * (Math.Sin((PolarAngleValue * (Math.PI)) / 180)))

        'Keeps it to accuracy ammount of decimal places
        ResultImaginary = Math.Round(ResultImaginary, Accuarcy)

        'Return imaginary part
        Return ResultImaginary
    End Function

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click

        If Num1PolarRadio.Checked Then
            'Num comes in in polar

            Num1_Part1 = Val(Num1_TextBox_Part1.Text) 'Magnitude
            Num1_Part2 = Val(Num1_TextBox_Part2.Text) 'Angle

            'Polar Declare
            Num1_PolarMagnitude = Num1_Part1
            Num1_PolarAngle = Num1_Part2

            'Rectagular Declare
            Num1_RectangularReal = PolarToRectangularReal(Num1_Part1, Num1_Part2)
            Num1_RectangularImaginary = PolarToRectangularImaginary(Num1_Part1, Num1_Part2)

        End If

        If Num1RectangularRadio.Checked Then
            'Num comes in in rectanctular

            Num1_Part1 = Val(Num1_TextBox_Part1.Text) 'Real
            Num1_Part2 = Val(Num1_TextBox_Part2.Text) 'Imaginary

            'Polar Declare
            Num1_PolarMagnitude = RectangularToPolarMagnitude(Num1_Part1, Num1_Part2)
            Num1_PolarAngle = RectangularToPolarAngle(Num1_Part1, Num1_Part2)

            'Rectangular Declare
            Num1_RectangularReal = Num1_Part1
            Num1_RectangularImaginary = Num1_Part2

        End If

        If Num2PolarRadio.Checked Then
            'Num comes in in polar

            Num2_Part1 = Val(Num2_TextBox_Part1.Text) 'Magnitude
            Num2_Part2 = Val(Num2_TextBox_Part2.Text) 'Angle

            'Polar Declare
            Num2_PolarMagnitude = Num2_Part1
            Num2_PolarAngle = Num2_Part2

            'Rectagular Declare
            Num2_RectangularReal = PolarToRectangularReal(Num2_Part1, Num2_Part2)
            Num2_RectangularImaginary = PolarToRectangularImaginary(Num2_Part1, Num2_Part2)
        End If

        If Num2RectangularRadio.Checked Then
            'Num comes in in rectangular

            Num2_Part1 = Val(Num2_TextBox_Part1.Text) 'Real
            Num2_Part2 = Val(Num2_TextBox_Part2.Text) 'Imaginary

            'Polar Declare
            Num2_PolarMagnitude = RectangularToPolarMagnitude(Num2_Part1, Num2_Part2)
            Num2_PolarAngle = RectangularToPolarAngle(Num2_Part1, Num2_Part2)

            'Rectangular Declare
            Num2_RectangularReal = Num2_Part1
            Num2_RectangularImaginary = Num2_Part2
        End If

        If AddRadioButton.Checked Then
            'Numbers in rectangular
            Answer_RectangularReal = (Num1_RectangularReal + Num2_RectangularReal)                  'Add the reals
            Answer_RectangularImaginary = (Num1_RectangularImaginary + Num2_RectangularImaginary)   'Add the imaginarys

            'Numbers in polar
            Answer_PolarMagnitude = RectangularToPolarMagnitude(Answer_RectangularReal, Answer_RectangularImaginary)
            Answer_PolarAngle = RectangularToPolarAngle(Answer_RectangularReal, Answer_RectangularImaginary)


        End If

        If SubtractRadioButton.Checked Then
            'Numbers in rectangular
            Answer_RectangularReal = (Num1_RectangularReal - Num2_RectangularReal)                  'Subtracts the reals
            Answer_RectangularImaginary = (Num1_RectangularImaginary - Num2_RectangularImaginary)   'Subtracts the imaginarys

            'Numbers in polar
            Answer_PolarMagnitude = RectangularToPolarMagnitude(Answer_RectangularReal, Answer_RectangularImaginary)
            Answer_PolarAngle = RectangularToPolarAngle(Answer_RectangularReal, Answer_RectangularImaginary)

        End If

        If MultiplyRadioButton.Checked Then
            'Numbers in polar
            Answer_PolarMagnitude = (Num1_PolarMagnitude * Num2_PolarMagnitude)
            Answer_PolarAngle = (Num1_PolarAngle + Num2_PolarAngle)

            'Numbers in rectangular
            Answer_RectangularReal = PolarToRectangularReal(Answer_PolarMagnitude, Answer_PolarAngle)
            Answer_RectangularImaginary = PolarToRectangularImaginary(Answer_PolarMagnitude, Answer_PolarAngle)
        End If

        If DivideRadioButton.Checked Then
            'Numbers in polar
            Answer_PolarMagnitude = Math.Round((Num1_PolarMagnitude / Num2_PolarMagnitude), Accuarcy)
            Answer_PolarAngle = Math.Round((Num1_PolarAngle - Num2_PolarAngle), Accuarcy)

            'Numbers in rectangular
            Answer_RectangularReal = Math.Round(PolarToRectangularReal(Answer_PolarMagnitude, Answer_PolarAngle), Accuarcy)
            Answer_RectangularImaginary = Math.Round(PolarToRectangularImaginary(Answer_PolarMagnitude, Answer_PolarAngle), Accuarcy)
        End If

        If AnswerInPolarRadio.Checked Then
            'Make answer equal to part 1 and part 2 polar
            Answer_Part1 = Answer_PolarMagnitude
            Answer_Part2 = Answer_PolarAngle

            'Display answer
            AnswerTextBox.Text = Answer_Part1 & " @ " & Answer_Part2
        End If

        If AnswerInRectangularRadio.Checked Then
            'Make answer equal to part 1 and part 2 rectangular
            Answer_Part1 = Answer_RectangularReal
            Answer_Part2 = Answer_RectangularImaginary

            'Display answer
            AnswerTextBox.Text = Answer_Part1 & " + " & Answer_Part2 & "j"

        End If

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'Closes MainForm
        Me.Close()
        QuickConverterForm.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'Clears all text boxes and radio button settings
        Num1_TextBox_Part1.Text = ""
        Num1_TextBox_Part2.Text = ""
        Num2_TextBox_Part1.Text = ""
        Num2_TextBox_Part2.Text = ""

        Num1PolarRadio.Checked = False
        Num1RectangularRadio.Checked = False

        Num2PolarRadio.Checked = False
        Num2RectangularRadio.Checked = False

        AddRadioButton.Checked = False
        SubtractRadioButton.Checked = False
        MultiplyRadioButton.Checked = False
        DivideRadioButton.Checked = False

        AnswerInPolarRadio.Checked = False
        AnswerInRectangularRadio.Checked = False

        AnswerTextBox.Text = ""

    End Sub

    Private Sub QuickConverterButton_Click(sender As Object, e As EventArgs) Handles QuickConverterButton.Click
        Me.Visible = False
        QuickConverterForm.Visible = True
    End Sub
End Class
