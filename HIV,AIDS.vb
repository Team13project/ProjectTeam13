'option statement
Option Explicit On
Option Infer Off
Option Strict On
Public Class HIV_AIDS

    'Constructor
    Public Sub New(ninfect As Integer)
        MyBase.New(ninfect)
    End Sub
    Public Sub New()

    End Sub

    'Methods
    'extending function for symptoms
    Public Overrides Function symptoms() As String
        Dim v As String
        v = CStr("4. Joint pains" & vbNewLine & "5. Headache/Muscle aches" & vbNewLine & "6. Weight loss" & vbNewLine & "7. Diarrhea.")
        Return CStr(MsgBox(MyBase.symptoms() & vbNewLine & v))

    End Function

    'function for treatment info
    Public Overrides Function treatment() As String
        Dim v As String
        v = CStr("1) Antiretroviral Therapy" & vbNewLine & vbNewLine & "SOME PREVENTIONS:" & vbNewLine & "1) Use contraceptives" & vbNewLine & "2) Do not share needles")

        Return CStr(MsgBox(vbNewLine & v))

    End Function
End Class
