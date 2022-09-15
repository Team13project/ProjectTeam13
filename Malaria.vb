'option statement
Option Explicit On
Option Infer Off
Option Strict On
Public Class Malaria
Inherits Disease

    'constructors
    Public Sub New(ninfect As Integer)
        MyBase.New(ninfect)
    End Sub
    Public Sub New()
    End Sub

    'Methods
    'extending function for symptoms
    Public Overrides Function symptoms() As String
        Dim v As String
        v = CStr("4. Shivering And chills" & vbNewLine & "5. Mental confusion")
        Return CStr(MsgBox(MyBase.symptoms() & vbNewLine & v))
    End Function

    'function for treatment info
    Public Overrides Function treatment() As String
        Dim v As String
        v = CStr("1) Antimalarial medications" & vbNewLine & "SOME PREVENTIONS" & vbNewLine & vbNewLine & "1. Drape mosquito netting over beds." & vbNewLine & "2. Apply mosquito repellent with DEET (diethyltoluamide) to exposed skin")
        Return CStr(MsgBox(vbNewLine & v))
    End Function
End Class
