﻿Imports System.Data.SqlClient
Imports Entidades
Public Class DatosPersonalesADvb
    Dim conexion As New Conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter
    Public Function LlenarDatosPersonal() As DataTable
        cn = conexion.conectar
        Dim vsql As String
        vsql = "exec sp_DatosPersonales 1"
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(vsql, cn)
        da.Fill(dt)
        Return dt
    End Function
End Class
