﻿Imports MySql.Data.MySqlClient
Public Class CONNECT
    Private connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=vbnetdbaseone")

    ' return the connection
    ReadOnly Property getConnection() As MySqlConnection
        Get
            Return connection
        End Get
    End Property

    ' open the connection
    Sub openConnection()

        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

    End Sub

    ' close the connection
    Sub closeConnection()

        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If

    End Sub

End Class

