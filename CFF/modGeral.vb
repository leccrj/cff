Module modGeral

    Public Enum grc
        conta = 1
        titulo = 2
        lancamento = 3
        cartao = 4
        movimento = 5
        parcelamento = 6
    End Enum

    Public Enum Mes
        janeiro = 1
        fevereiro = 2
        marco = 3
        abril = 4
        maio = 5
        junho = 6
        julho = 7
        agosto = 8
        setembro = 9
        outubro = 10
        novembro = 11
        dezembro = 12
    End Enum

    Sub Main()
        frmPrincipal.StartPosition = FormStartPosition.CenterScreen
        Application.Run(frmPrincipal)
    End Sub

    Public Function Fn_Tipo_Conta(ByVal p_cod_conta As Integer) As String

        Try

            Using ctx = New FINANCEIROEntities

                Return (From conta In ctx.TB_CONTA Where conta.COD_CONTA = p_cod_conta Select conta.TIPO).SingleOrDefault

            End Using

        Catch ex As Exception

            Return String.Empty

        End Try

    End Function

    Public Function Fn_Retorna_Cartao(ByVal p_cod_conta As Integer) As Integer

        Try

            Using ctx = New FINANCEIROEntities

                Return (From conta In ctx.TB_CONTA
                        Join cartao In ctx.TB_CARTAO On cartao.COD_CONTA Equals conta.COD_CONTA
                        Where conta.COD_CONTA = p_cod_conta
                        Select cartao.COD_CARTAO).SingleOrDefault

            End Using

        Catch ex As Exception

            Return 0

        End Try

    End Function

    Public Function Fn_Credito() As Decimal

        Try

            Using ctx = New FINANCEIROEntities

                Dim vCredito = (From titulo In ctx.TB_TITULO
                                Join conta In ctx.TB_CONTA On conta.COD_CONTA Equals titulo.COD_CONTA
                                Join lanc In ctx.TB_LANCAMENTO On lanc.COD_TITULO Equals titulo.COD_TITULO
                                Where conta.TIPO = "C"
                                Select lanc.VALOR).Sum


                Return vCredito

            End Using

        Catch ex As Exception

            Return 0

        End Try

    End Function

    Public Function fn_Credito(ByVal p_dt_inicio As Date, ByVal p_dt_final As Date) As Decimal

        Try

            Using ctx = New FINANCEIROEntities

                Dim vCredito = (From vc In ctx.vw_titulo
                                Where vc.TIPO = "C" _
                                    And (vc.DAT_PAGAMENTO >= p_dt_inicio And vc.DAT_PAGAMENTO <= p_dt_final)
                                Select vc.VALOR).Sum


                Return vCredito

            End Using

        Catch ex As Exception

            Return 0

        End Try

    End Function

    Public Function fn_Debito() As Decimal

        Try

            Using ctx = New FINANCEIROEntities

                Dim vCredito = (From titulo In ctx.vw_titulo
                                Where titulo.TIPO = "D"
                                Select titulo.VALOR).Sum

                Return vCredito

            End Using

        Catch ex As Exception

            Return 0

        End Try

    End Function

    Public Function fn_Debito(ByVal p_dt_inicio As Date, ByVal p_dt_final As Date) As Decimal

        Try

            Using ctx = New FINANCEIROEntities

                Dim vDebito = (From tl In ctx.vw_titulo
                               Where tl.TIPO = "D" _
                                   And (((tl.DAT_PLANEJAMENTO >= p_dt_inicio And tl.DAT_PLANEJAMENTO <= p_dt_final) And tl.DAT_PAGAMENTO Is Nothing) _
                                   Or (tl.DAT_PAGAMENTO >= p_dt_inicio And tl.DAT_PAGAMENTO <= p_dt_final))
                               Select tl.VAL_TITULO).Sum

                Return vDebito

            End Using

        Catch ex As Exception

            Return 0

        End Try

    End Function

    Public Function fn_Pagamento() As Decimal

        Try

            Using ctx = New FINANCEIROEntities

                Dim vPagamento = (From titulo In ctx.TB_TITULO
                                  Join conta In ctx.TB_CONTA On conta.COD_CONTA Equals titulo.COD_CONTA
                                  Join lanc In ctx.TB_LANCAMENTO On lanc.COD_TITULO Equals titulo.COD_TITULO
                                  Where conta.TIPO = "D"
                                  Select lanc.VALOR).Sum

                Return vPagamento

            End Using

        Catch ex As Exception

            Return 0

        End Try

    End Function

    Public Function fn_Pagamento(ByVal p_dt_inicio As Date, ByVal p_dt_final As Date) As Decimal

        Try

            Using ctx = New FINANCEIROEntities

                Dim vPagamento = (From tl In ctx.vw_titulo
                                  Where tl.TIPO = "D" _
                                      And (tl.DAT_PAGAMENTO >= p_dt_inicio And tl.DAT_PAGAMENTO <= p_dt_final)
                                  Select tl.VALOR).Sum

                Return vPagamento

            End Using

        Catch ex As Exception

            Return 0

        End Try

    End Function

    Public Function fn_Debito_Mes(ByVal p_mes As Mes, ByVal p_ano As Integer) As Decimal

        Try

            Using ctx = New FINANCEIROEntities

                Dim vDebito = (From titulo In ctx.TB_TITULO
                               Join conta In ctx.TB_CONTA On conta.COD_CONTA Equals titulo.COD_CONTA
                               Where Month(titulo.DAT_VENCIMENTO) = p_mes And Year(titulo.DAT_VENCIMENTO) = p_ano And conta.TIPO = "D"
                               Select titulo.VALOR).Sum

                Return vDebito

            End Using

        Catch ex As Exception

            Return 0

        End Try

    End Function

    Public Function fn_Pago(ByVal p_data_inicio As Date, ByVal p_data_final As Date) As Decimal

        Try


            Using ctx = New FINANCEIROEntities

                Dim vPago = (From titulo In ctx.TB_TITULO
                             Join conta In ctx.TB_CONTA On conta.COD_CONTA Equals titulo.COD_CONTA
                             Join lanc In ctx.TB_LANCAMENTO On lanc.COD_TITULO Equals titulo.COD_TITULO
                             Where titulo.DAT_VENCIMENTO >= p_data_inicio And titulo.DAT_VENCIMENTO <= p_data_final And conta.TIPO = "D"
                             Select lanc.VALOR).Sum

                Return vPago

            End Using

        Catch ex As Exception

            Return 0

        End Try

    End Function

    Public Function fn_APagar(ByVal p_data_inicio As Date, ByVal p_data_final As Date) As Decimal

        Try


            Using ctx = New FINANCEIROEntities

                'tl.DAT_VENCIMENTO >= p_data_inicio And tl.DAT_VENCIMENTO <= p_data_final _

                Dim vAPagar = (From tl In ctx.vw_titulo
                               Where tl.DAT_PLANEJAMENTO >= p_data_inicio And tl.DAT_PLANEJAMENTO <= p_data_final _
                                   And tl.DAT_PAGAMENTO Is Nothing _
                                   And tl.TIPO = "D"
                               Select (tl.VAL_TITULO - tl.VAL_PAGO)).Sum

                Return vAPagar

            End Using

        Catch ex As Exception

            Return 0

        End Try

    End Function

    Public Function fn_Mes(ByVal p_date As Date) As String

        Select Case Month(p_date)
            Case 1
                Return "Janeiro"
            Case 2
                Return "Fevereiro"
            Case 3
                Return "Março"
            Case 4
                Return "Abril"
            Case 5
                Return "Maio"
            Case 6
                Return "Junho"
            Case 7
                Return "Julho"
            Case 8
                Return "Agosto"
            Case 9
                Return "Setembro"
            Case 10
                Return "Outubro"
            Case 11
                Return "Novembro"
            Case 12
                Return "Dezembro"
            Case Else
                Return ""
        End Select

    End Function

    Public Function fn_UltimoDia_Mes(ByVal p_data As Date) As Date

        Dim v_data As Date = DateAdd("m", 1, p_data)

        Return DateSerial(Year(v_data), Month(v_data), 0)

    End Function

    Public Function fn_PrimeiroDia_Mes(ByVal p_data As Date) As Date

        Dim v_dia As Integer = Format(p_data, "dd").ToString

        Return DateAdd(DateInterval.Day, ((v_dia - 1) * -1), p_data)

    End Function

    Public Sub sb_Preenche_Conta(ByVal p_combo As ComboBox)

        Try

            Using ctx = New FINANCEIROEntities

                p_combo.DataSource = (From conta In ctx.TB_CONTA Where Not conta.COD_CONTA_RAIZ.HasValue).ToList

                p_combo.DisplayMember = "DESCRICAO"

                p_combo.ValueMember = "COD_CONTA"

            End Using

        Catch ex As Exception

            MessageBox.Show("Erro " + ex.Message, "Erro::sb_Preenche_Conta_Debito", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Public Sub sb_Preenche_Conta(ByVal p_combo As ComboBox, ByVal p_tipo As String)

        Try

            Using ctx = New FINANCEIROEntities

                p_combo.DataSource = (From conta In ctx.TB_CONTA Where conta.TIPO = p_tipo And Not conta.COD_CONTA_RAIZ.HasValue).ToList

                p_combo.DisplayMember = "DESCRICAO"

                p_combo.ValueMember = "COD_CONTA"

            End Using

        Catch ex As Exception

            MessageBox.Show("Erro " + ex.Message, "Erro::sb_Preenche_Conta_Debito", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Public Sub sb_Preenche_Conta(ByVal p_combo As ComboBox, ByVal p_cod_conta As Decimal)

        Try

            Using ctx = New FINANCEIROEntities

                p_combo.DataSource = (From conta In ctx.TB_CONTA Where conta.COD_CONTA_RAIZ = p_cod_conta).ToList

                p_combo.DisplayMember = "DESCRICAO"

                p_combo.ValueMember = "COD_CONTA"

            End Using

        Catch ex As Exception

            MessageBox.Show("Erro " + ex.Message, "Erro::sb_Preenche_Conta_Debito", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

End Module
