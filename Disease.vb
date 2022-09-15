'option statement
Option Explicit On
Option Infer Off
Option Strict On
Public Class Disease
  private _name as string
  private _ test as string 
  
   'Property methods
    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property
    Public Property Ninfected As Integer
        Get
            Return _Ninfected
        End Get
        Set(value As Integer)
            _Ninfected = value
        End Set
    End Property

    'constructors
    Public Sub New(name As String, ninfect As Integer)
        _name = name
        _Ninfected = ninfect
    End Sub
    Public Sub New()

    End Sub

    'ovveridable function showing common symptoms
    Public Overridable Function symptoms() As String
        Dim smptoms, v As String
        smptoms = "1. Cough" & vbNewLine & "2. Fever" & vbNewLine & "3. Breathing difficulties"
        v = CStr(smptoms)
        Return v
    End Function

    'funtion for treatmentss
    Public MustOverride Function Treatment() As String


End Class
