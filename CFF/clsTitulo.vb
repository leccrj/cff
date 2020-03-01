Public Class clsTitulo

    Private v_COD_TITULO As Integer
    Private v_DESCRICAO As String
    Private v_DAT_VENCIMENTO As Date
    Private v_VALOR As Decimal
    Private v_COD_CONTA As Short
    Private v_OBSERVACAO As String

    Public Property COD_TITULO() As Integer
        Get
            Return v_COD_TITULO
        End Get
        Set(value As Integer)
            v_COD_TITULO = value
        End Set
    End Property

    Public Property DESCRICAO() As String
        Get
            Return v_DESCRICAO
        End Get
        Set(value As String)
            v_DESCRICAO = value
        End Set
    End Property

    Public Property DAT_VENCIMENTO() As Date
        Get
            Return v_DAT_VENCIMENTO
        End Get
        Set(value As Date)
            v_DAT_VENCIMENTO = value
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

    Public Property COD_CONTA() As Short
        Get
            Return v_COD_CONTA
        End Get
        Set(value As Short)
            v_COD_CONTA = value
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
