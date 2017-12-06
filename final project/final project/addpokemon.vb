﻿Option Strict On
Option Explicit On
Public Class addpokemon
    Dim apokemon As New Pokemon
    Private Sub addpokemon_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btnAddPokemon_Click(sender As Object, e As EventArgs) Handles btnAddPokemon.Click
        Dim mID As Integer
        If Integer.TryParse(txtID.Text, mID) Then
            mID = CInt(txtID.Text)
            Dim mName As String = txtName.Text
            Dim mtypingid As Integer
            Dim mAbility As String = txtAbility.Text
            Dim mMove1 As String = txtMove1.Text
            Dim mMove2 As String = txtMove2.Text
            Dim mMove3 As String = txtMove3.Text
            Dim mMove4 As String = txtMove4.Text
            If Integer.TryParse(txtTyping.Text, mtypingid) And mtypingid <= 18 Then
                apokemon.Insert(mID, mName, mtypingid, mAbility, mMove1, mMove2, mMove3, mMove4)
                MessageBox.Show("successfully added pokemon!")
                Me.Close()
            Else
                MessageBox.Show("please enter one of the valid type ids")
            End If
        Else
                MessageBox.Show("please enter a proper integer ID number greater than 0")
        End If
    End Sub
End Class