Public Class clsConta

    Private v_COD_CONTA As Integer
    Private v_DESCRICAO As String
    Private v_TIPO As String
    Private v_OBSERVACAO As String

    Public Property COD_CONTA() As Integer
        Get
            Return v_COD_CONTA
        End Get
        Set(value As Integer)
            v_COD_CONTA = value
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

    Public Property TIPO() As String
        Get
            Return v_TIPO
        End Get
        Set(value As String)
            v_TIPO = value
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

    Public Function fn_Incluir() As Boolean
        Try

            Dim v_sql As String

            v_sql = "insert into (descricao,tipo,observacao) values ('" & v_DESCRICAO & "','" & v_TIPO & "','" & v_OBSERVACAO & "')"

            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function fn_Alterar() As Boolean
        Try

            Dim v_sql As String

            v_sql = "update tb_conta set descricao = '" & v_DESCRICAO & "'"
            v_sql = v_sql & ", tipo = '" & v_TIPO & "'"
            v_sql = v_sql & ", observacao = '" & v_OBSERVACAO & "'"
            v_sql = v_sql & " where cod_conta = " & v_COD_CONTA

            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function fn_Excluir() As Boolean
        Try

            Dim v_sql As String

            v_sql = "delete from tb_conta where cod_conta = " & v_COD_CONTA

            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function fn_Consulta() As Boolean
        Try

            Dim v_sql As String

            v_sql = "select cod_conta, descricao, cod_tipo, observacao from tb_conta"

            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
