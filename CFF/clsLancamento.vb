Public Class clsLancamento

    Private v_COD_LANCAMENTO As Long
    Private v_COD_TITULO As Long
    Private v_VALOR As Decimal
    Private v_DATA As Date
    Private v_COD_MOVIMENTO As Short
    Private v_OBSERVACAO As String

    Public Property COD_LANCAMENTO() As Long
        Get
            Return v_COD_LANCAMENTO
        End Get
        Set(value As Long)
            v_COD_LANCAMENTO = value
        End Set
    End Property

    Public Property COD_TITULO() As Long
        Get
            Return v_COD_TITULO
        End Get
        Set(value As Long)
            v_COD_TITULO = value
        End Set
    End Property

    Public Property VALOR() As Decimal
        Get
            Return v_VALOR
        End Get
        Set(value As Decimal)
            v_VALOR = value
        End Set
    End Property

    Public Property DATA() As Date
        Get
            Return v_DATA
        End Get
        Set(value As Date)
            v_DATA = value
        End Set
    End Property

    Public Property COD_MOVIMENTO() As Short
        Get
            Return v_COD_MOVIMENTO
        End Get
        Set(value As Short)
            v_COD_MOVIMENTO = value
        End Set
    End Property

    Public Property OBSERVACAO() As String
        Get
            Return v_OBSERVACAO
        End Get
        Set(value As String)
            v_OBSERVACAO = value
        End Set
    End Property
End Class
