﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.Core.Objects
Imports System.Linq

Partial Public Class FINANCEIROEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=FINANCEIROEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property sysdiagrams() As DbSet(Of sysdiagram)
    Public Overridable Property TB_CONTA() As DbSet(Of TB_CONTA)
    Public Overridable Property TB_LANCAMENTO() As DbSet(Of TB_LANCAMENTO)
    Public Overridable Property TB_TITULO() As DbSet(Of TB_TITULO)
    Public Overridable Property TB_CARTAO() As DbSet(Of TB_CARTAO)
    Public Overridable Property TB_CLASSIFICACAO() As DbSet(Of TB_CLASSIFICACAO)
    Public Overridable Property TB_MOVIMENTO_CARTAO() As DbSet(Of TB_MOVIMENTO_CARTAO)
    Public Overridable Property vw_titulo() As DbSet(Of vw_titulo)
    Public Overridable Property TB_PARCELA() As DbSet(Of TB_PARCELA)
    Public Overridable Property TB_PARCELAMENTO() As DbSet(Of TB_PARCELAMENTO)
    Public Overridable Property vw_parcelamento() As DbSet(Of vw_parcelamento)

    Public Overridable Function sp_alterdiagram(diagramname As String, owner_id As Nullable(Of Integer), version As Nullable(Of Integer), definition As Byte()) As Integer
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Dim versionParameter As ObjectParameter = If(version.HasValue, New ObjectParameter("version", version), New ObjectParameter("version", GetType(Integer)))

        Dim definitionParameter As ObjectParameter = If(definition IsNot Nothing, New ObjectParameter("definition", definition), New ObjectParameter("definition", GetType(Byte())))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter)
    End Function

    Public Overridable Function sp_creatediagram(diagramname As String, owner_id As Nullable(Of Integer), version As Nullable(Of Integer), definition As Byte()) As Integer
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Dim versionParameter As ObjectParameter = If(version.HasValue, New ObjectParameter("version", version), New ObjectParameter("version", GetType(Integer)))

        Dim definitionParameter As ObjectParameter = If(definition IsNot Nothing, New ObjectParameter("definition", definition), New ObjectParameter("definition", GetType(Byte())))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter)
    End Function

    Public Overridable Function sp_dropdiagram(diagramname As String, owner_id As Nullable(Of Integer)) As Integer
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter)
    End Function

    Public Overridable Function sp_helpdiagramdefinition(diagramname As String, owner_id As Nullable(Of Integer)) As ObjectResult(Of sp_helpdiagramdefinition_Result)
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of sp_helpdiagramdefinition_Result)("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter)
    End Function

    Public Overridable Function sp_helpdiagrams(diagramname As String, owner_id As Nullable(Of Integer)) As ObjectResult(Of sp_helpdiagrams_Result)
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of sp_helpdiagrams_Result)("sp_helpdiagrams", diagramnameParameter, owner_idParameter)
    End Function

    Public Overridable Function sp_renamediagram(diagramname As String, owner_id As Nullable(Of Integer), new_diagramname As String) As Integer
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Dim new_diagramnameParameter As ObjectParameter = If(new_diagramname IsNot Nothing, New ObjectParameter("new_diagramname", new_diagramname), New ObjectParameter("new_diagramname", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter)
    End Function

    Public Overridable Function sp_upgraddiagrams() As Integer
        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_upgraddiagrams")
    End Function

    Public Overridable Function sp_credito(p_data_inicio As Nullable(Of Date), p_data_final As Nullable(Of Date)) As ObjectResult(Of Nullable(Of Decimal))
        Dim p_data_inicioParameter As ObjectParameter = If(p_data_inicio.HasValue, New ObjectParameter("p_data_inicio", p_data_inicio), New ObjectParameter("p_data_inicio", GetType(Date)))

        Dim p_data_finalParameter As ObjectParameter = If(p_data_final.HasValue, New ObjectParameter("p_data_final", p_data_final), New ObjectParameter("p_data_final", GetType(Date)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Decimal))("sp_credito", p_data_inicioParameter, p_data_finalParameter)
    End Function

End Class