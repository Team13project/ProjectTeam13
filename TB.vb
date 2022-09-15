'option statement
Option Explicit On
Option Infer Off
Option Strict On
Public Class TB
 Inherits Disease

    Public Sub New(ninfect As Integer)
        MyBase.New(ninfect)
    End Sub
    Public Sub New()
    End Sub

    'Methods.
    'extending function for symptoms
    Public Overrides Function symptoms() As String
        Dim v As String
        v = CStr("4. Night sweats" & vbNewLine & "5.Coughing up of blood")
        Return CStr(MsgBox(MyBase.symptoms() & vbNewLine & v))

    End Function

    'function for treatment info
    Public Overrides Function treatment() As String
        Dim v As String
        v = CStr("1) 2 antibiotics (isoniazid and rifampicin) for 6 months." & vbNewLine & "2) 2 additional antibiotics (pyrazinamide and ethambutol) for the first 2     months of the 6-month treatment period." & vbNewLine & vbNewLine & "SOME PREVENTION:" & vbNewLine & " 1. Use a fan or open windows to move around fresh air" & vbNewLine & "2. Wash your hands after coughing or sneezing")
        Return CStr(MsgBox(vbNewLine & v))

    End Function

End Class
