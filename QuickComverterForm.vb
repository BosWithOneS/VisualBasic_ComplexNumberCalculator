'RyanBos
'ComplexNumberCalculator
'11.21.2020
'Converts numbers between polar and rectangular

Public Class QuickConverterForm
    'Variable declaration
    Dim Num_Part1 As Double 'Num real or magnutide
    Dim Num_Part2 As Double 'Num Imaginary or angle

    Dim Num_PolarMagnitude As Double
    Dim Num_PolarAngle As Double

    Dim Num_RectangularReal As Double
    Dim Num_RectangularImaginary As Double

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
        ResultAngle = (ResultAngle * 180) / 3.14159

        'Keeps it to accuracy ammount of decimal places
        ResultAngle = Math.Round(ResultAngle, Accuarcy)

        'Return polar angle
        Return ResultAngle

    End Function
    Public Function PolarToRectangularReal(ByVal PolarMagnitudeValue As Double, PolarAngleValue As Double) As Double
        Dim ResultReal As Double

        'Get rectangular real
        ResultReal = (PolarMagnitudeValue * (Math.Cos((PolarAngleValue * 3.14159) / 180)))

        'Keeps it to accuracy ammount of decimal places
        ResultReal = Math.Round(ResultReal, Accuarcy)


        'Return Real part
        Return ResultReal
    End Function
    Public Function PolarToRectangularImaginary(ByVal PolarMagnitudeValue As Double, PolarAngleValue As Double) As Double
        Dim ResultImaginary As Double

        'Get rectangular imaginary
        ResultImaginary = (PolarMagnitudeValue * (Math.Sin((PolarAngleValue * 3.14159) / 180)))

        'Keeps it to accuracy ammount of decimal places
        ResultImaginary = Math.Round(ResultImaginary, Accuarcy)

        'Return imaginary part
        Return ResultImaginary
    End Function

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click

        If NumInPolarRadio.Checked Then
            'Num comes in polar
            Num_Part1 = Val(Num_TextBox_Part1.Text)
            Num_Part2 = Val(Num_TextBox_Part2.Text)

            'Number already in polar
            Num_PolarMagnitude = Num_Part1
            Num_PolarAngle = Num_Part2

            'Number convert to rectangular
            Num_RectangularReal = PolarToRectangularReal(Num_Part1, Num_Part2)
            Num_RectangularImaginary = PolarToRectangularImaginary(Num_Part1, Num_Part2)
        End If

        If NumInRectangularRadio.Checked Then

            'Num comes in rectangular
            Num_Part1 = Val(Num_TextBox_Part1.Text)
            Num_Part2 = Val(Num_TextBox_Part2.Text)

            'Number convert to polar
            Num_PolarMagnitude = RectangularToPolarMagnitude(Num_Part1, Num_Part2)
            Num_PolarAngle = RectangularToPolarAngle(Num_Part1, Num_Part2)

            'Number already in rectangular
            Num_RectangularReal = Num_Part1
            Num_RectangularImaginary = Num_Part2

        End If

        If AnswerInPolarRadio.Checked Then
            'Set answer variables to be polar values
            Answer_Part1 = Num_PolarMagnitude
            Answer_Part2 = Num_PolarAngle

            'Display answer in textbox
            AnswerTextBox.Text = Answer_Part1 & " @ " & Answer_Part2

        End If

        If AnswerInRectangularRadio.Checked Then
            'Set answer variables to be rectangular values
            Answer_Part1 = Num_RectangularReal
            Answer_Part2 = Num_RectangularImaginary

            'Display answer in textbox
            AnswerTextBox.Text = Answer_Part1 & " + " & Answer_Part2 & "j"

        End If








    End Sub


    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
        MainForm.Close()
    End Sub

    Private Sub CalculatorButton_Click(sender As Object, e As EventArgs) Handles CalculatorButton.Click
        Me.Visible = False
        MainForm.Visible = True
    End Sub


End Class