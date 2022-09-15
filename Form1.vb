' *****************************************************************
' Team Number: 13
' Team Member 1 Details: Gulamali, MD (222156212)
' Team Member 2 Details: Mayisela,LA (221005407)
' Team Member 3 Details: More, I (222062815)
' Team Member 4 Details: ,  ()
' Practical: Team Project
' Class name: ()
' *****************************************************************
'option statement
Option Explicit On
Option Infer Off
Option Strict On
Public Class frmDiseaseManagers
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
Public Class frmDiseaseManager

    Private nc As Integer
    Private population() As Integer
    Private percentage As Double
    Private objHiv As HIV_AIDS
    Private objtb As TB
    Private objCOVID As Covid19
    Private objmalaria As Malaria
    Private symptoms As Disease
    Private TREATMENT As Disease

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
   'subroutine for grid
    Private Sub Display(ByVal r As Integer, ByVal c As Integer, ByVal t As String)
        grdDisplay.Row = r
        grdDisplay.Col = c
        grdDisplay.Text = t
    End Sub



    'Setting up titles on grid and resizin grid acording to number of countries
    Private Sub btnInit_Click(sender As Object, e As EventArgs) Handles btnInit.Click
        nc = CInt(InputBox("How many countries?"))
        grdDisplay.Rows = nc + 1
        grdDisplay.Cols = 8
        ReDim population(nc)
        Dim c As Integer
        For c = 1 To nc
            Display(c, 0, "Country " & c)
        Next
        grdDisplay.set_ColWidth(6, 150)
        grdDisplay.set_ColWidth(7, 150)
        Display(0, 0, "Country Name")
        Display(0, 1, "HIV/AIDS")
        Display(0, 2, "Malaria")
        Display(0, 3, "TB")
        Display(0, 4, "COVID")
        Display(0, 5, "Population")
        Display(0, 6, "Total infected in country")
        Display(0, 7, "Percentage infected")
    End Sub

    'geting details from user on the country name and its population
    Private Sub btnCInput_Click(sender As Object, e As EventArgs) Handles btnCInput.Click
        Dim c As Integer
        Dim name As String
        For c = 1 To nc
            name = InputBox("what is the name of country " & c)
            population(c) = CInt(InputBox("whats the population of country " & name))
            'displaying details on grid
            Display(c, 0, name)
            Display(c, 5, CStr(population(c)))
        Next c

    End Sub

    'getting details on how many people were infected with each type of disease in each country
    Private Sub btnDInput_Click(sender As Object, e As EventArgs) Handles btnDInput.Click

      Dim c As Integer
        Dim ninfected As Integer

        objtb = New TB()
        objmalaria = New Malaria()
        objCOVID = New Covid19()
        objHiv = New HIV_AIDS()

        For c = 1 To nc
            'Detail input and display
            ninfected = CInt(InputBox("number of people infected with HV/AIDS in country " & c))
            Display(c, 1, CStr(ninfected))
            objHiv = New HIV_AIDS(ninfected)
            ninfected = CInt(InputBox("number of people infected with Malaria in country " & c))
            Display(c, 2, CStr(ninfected))
            objmalaria = New Malaria(ninfected)
            ninfected = CInt(InputBox("number of people infected with TB in country " & c))
            Display(c, 3, CStr(ninfected))
            objtb = New TB(ninfected)
            ninfected = CInt(InputBox("number of people infected with COVID19 in country " & c))
            Display(c, 4, CStr(ninfected))
            objCOVID = New Covid19(ninfected)

            'Calcualting total infected per country and displaying results
            Dim totalinfected As Integer
            totalinfected = objtb.Ninfected + objmalaria.Ninfected + objCOVID.Ninfected + objHiv.Ninfected
            Display(c, 6, CStr(totalinfected))

            'calculating percentage of population that is infected with these diseases
            percentage = (totalinfected / population(c)) * 100
            Display(c, 7, Format(percentage, "0.0") & " %")
        Next
    End Sub

    'Displaying symptoms using a select case, Polymorphism
    Private Sub btnSymptoms_Click(sender As Object, e As EventArgs) Handles btnSymptoms.Click
        Dim choice As Integer
        choice = CInt(InputBox("Symptoms for disease:" & vbNewLine & "1. TB" & vbNewLine & "2. Malaria" & vbNewLine & "3. COVID19" & vbNewLine & "4. HIV/AIDS"))
        Select Case choice
            Case 1
                symptoms = New TB()
                symptoms.symptoms()
            Case 2
                symptoms = New Malaria()
                symptoms.symptoms()
            Case 3
                symptoms = New Covid19()
                symptoms.symptoms()
            Case 4
                symptoms = New HIV_AIDS()
                symptoms.symptoms()
        End Select
    End Sub


    '  displaying treatments and a few preventions using select case, Polymorphism
    Private Sub btntreatment_Click(sender As Object, e As EventArgs) Handles btntreatment.Click
        Dim choice As Integer
        choice = CInt(InputBox("Treatment for Disease:" & vbNewLine & "1. TB" & vbNewLine & "2. Malaria" & vbNewLine & "3. COVID19" & vbNewLine & "4. HIV/AIDS"))
        Select Case choice
            Case 1
                TREATMENT = New TB()
                TREATMENT.Treatment()
            Case 2
                objmalaria = New Malaria()
                TREATMENT.Treatment()
            Case 3
                TREATMENT = New Covid19()
                TREATMENT.Treatment()
            Case 4
                TREATMENT = New HIV_AIDS()
                TREATMENT.Treatment()
        End Select
    End Sub

    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        MsgBox("cost of treatment per disease:" & vbNewLine & "HIV/AIDS- R1,800 pm" & vbNewLine & "Malaria- R300 pm" & vbNewLine & "COVID19- R3000 pm" & vbNewLine & "TB-  R 11,250 for 6 months")
    End Sub
End Class

    End Sub
End Class
