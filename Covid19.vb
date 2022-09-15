'option statement
Option Explicit On
Option Infer Off
Option Strict On

Public Class Covid19
    Inherits Disease
    Public Sub New(ninfect As Integer)
        MyBase.New(ninfect)
    End Sub
    Public Sub New()

    End Sub

    'Methods
    'extending function for symptoms
    Public Overrides Function symptoms() As String
        Dim v As String
        v = CStr("4. Tiredness" & vbNewLine & "5. Loss of taste or smell")
        Return CStr(MsgBox(MyBase.symptoms() & vbNewLine & v))

    End Function

    'function for treatment info
    Public Overrides Function treatment() As String
        Dim v As String
        v = CStr("1) Nirmatrelvir with Ritonavi (Tablet)" & vbNewLine & "2) Remdesivir(infusion)" & vbNewLine & "3) Bebtelovimab Monoclonal antibody(Injection)" & vbNewLine & "SOME PREVENTIONS:" & vbNewLine & vbNewLine & "1. Wear medical masks" & vbNewLine & "2. Take vaccines" & vbNewLine & "3. Social distance")
        Return CStr(MsgBox(vbNewLine & v))
    End Function

End Class

