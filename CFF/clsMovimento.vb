Public Class clsMovimento

    Private v_COD_MOVIMENTO As Integer
    Private v_MES_ANO As Integer
    Private v_OBSERVACAO As String

    Public Property COD_MOVIMENTO() As Integer

        Get
            Return v_COD_MOVIMENTO
        End Get

        Set(value As Integer)
            v_COD_MOVIMENTO = value
        End Set

    End Property

    Public Property MES_ANO() As Integer

        Get
            Return v_MES_ANO
        End Get

        Set(value As Integer)
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
