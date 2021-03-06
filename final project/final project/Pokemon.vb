﻿Option Strict On
Option Explicit On
Public Class Pokemon
    'create instance of adapter to work with database
    Private adapter As New PokemonDataSetTableAdapters.PokemonTableAdapter
    'gets data
    Public ReadOnly Property Pokemonlist As DataTable
        Get
            Dim listAdapter As New PokemonDataSetTableAdapters.PokemonTableAdapter
            Return listAdapter.GetData()
        End Get
    End Property
    Public Shared Property LastError As String
    'insert method
    Public Function Insert(ByVal pID As Integer,
                           ByVal pName As String,
                           ByVal pTypeid As Integer,
                           ByVal pAbility As String,
                           ByVal pMove1 As String,
                           ByVal pMove2 As String,
                           ByVal pMove3 As String,
                           ByVal pMove4 As String) As Boolean
        'insert a new row into th eappointments talbe. return true if successful.
        'if an exception is thrown, last error will hold an error message.
        Try
            LastError = String.Empty
            adapter.Insert(pID, pName, pTypeid, pAbility, pMove1, pMove2, pMove3, pMove4)
            Return True
        Catch ex As Exception
            LastError = ex.Message
            Return False
        End Try
    End Function
    'get info items method
    Public ReadOnly Property Items() As DataTable
        Get
            Return adapter.GetData()
        End Get
    End Property
    'update method
    Public Function Update(ByVal pID As Integer,
                           ByVal pAbility As String,
                           ByVal pMove1 As String,
                           ByVal pMove2 As String,
                           ByVal pMove3 As String,
                           ByVal pMove4 As String) As Boolean
        'update a row into the appointments table.
        'return true if successful. if an exception is thrown last error will hold an error message.
        LastError = String.Empty
        Try
            adapter.Update(pAbility, pMove1, pMove2, pMove3, pMove4, pID)
            Return True
        Catch ex As Exception
            LastError = ex.Message
            Return False
        End Try
    End Function
    'delete method
    Public Function Delete(ByVal pID As Integer) As Boolean
        Dim rowsAffected As Integer = adapter.Delete(pID)
        Return rowsAffected > 0
    End Function
    'function to find by id
    Public Function FindByID(ByVal Id As Short) As PokemonDataSet.PokemonRow
        Dim table As PokemonDataSet.PokemonDataTable
        table = adapter.GetData()
        Return table.FindByID(Id)
    End Function
    'function to get by type
    Public Function GetByType(ByVal TypeId As Short) As DataTable
        Dim table As DataTable = adapter.GetData()
        table.DefaultView.RowFilter = "TypeId = " & TypeId
        Return table
    End Function
    'function to help validate pokemon id when adding a new pokemon to the database
    Public Function checkId(ByVal id As Integer) As Boolean
        Dim idisreal As Boolean = True
        Dim count As Integer = CInt(adapter.checkID(id))
        If count <> 1 Then
            idisreal = False
        End If
        Return idisreal
    End Function
End Class
