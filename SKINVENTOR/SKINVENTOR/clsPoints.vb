Public Class clsPoints
    Private _pointstring As String
    Private _pointarr As String()

    Public ReadOnly Property X As String
        Get
            Return _pointarr(0)
        End Get
    End Property

    Public ReadOnly Property Y As String
        Get
            Return _pointarr(1)
        End Get
    End Property

    Public ReadOnly Property Z As String
        Get
            Return _pointarr(2)
        End Get
    End Property

    Public Sub New(ByVal pointstring As String)
        ' widen scope
        _pointstring = pointstring

        ParseString()
    End Sub

    Private Sub ParseString()
        _pointarr = _pointstring.Split(",")
    End Sub

End Class
