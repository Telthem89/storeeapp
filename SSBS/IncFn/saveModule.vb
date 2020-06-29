﻿Imports System.Data.OleDb
Module saveModule
    Public Function insert(ByVal sql As String) As Boolean

        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    Return False
                Else
                    Return True
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()

        End Try
        Return Nothing
    End Function

    Public Function update(ByVal sql As String) As Boolean
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then

                    Return False
                Else
                    Return True

                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()

        End Try
        Return Nothing
    End Function

    Public Function delete(ByVal sql As String) As Boolean
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    Return False
                Else
                    Return True
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()

        End Try
        Return Nothing
    End Function

    Public Sub save(ByVal sql As String)

        With cmd
            .Connection = con
            .CommandText = sql

            Dim result As Integer

            result = .ExecuteNonQuery
            If result > 0 Then
                MsgBox("data has been saved!")
            Else
                MsgBox("No data has been saved!")
            End If
        End With
    End Sub
End Module
