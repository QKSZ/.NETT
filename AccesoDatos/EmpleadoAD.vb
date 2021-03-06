Imports _3Entidades
Imports System.Data.OleDb

Public Class EmpleadoAD
    ' Objeto que permite conectarse a la BD Access
    Dim miConexion As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Planilla.accdb")

    Public Sub New()
        ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
    End Sub

    Public Sub InsertarEmpleado(ByVal pEmpleado As EmpleadoEN)
        Try
            miConexion.Open()
            Dim strInsert As String
            strInsert = "INSERT INTO Empleado(Cedula,Nombre,Fecha_Ingreso,Horas,Precio_hora,Ind_Activo) Values(@Cedula,@Nombre,@Fecha_Ingreso,@Horas,@Precio_hora,@Ind_Activo)"
            Dim cmdEmpleado As New OleDbCommand(strInsert, miConexion)
            cmdEmpleado.Parameters.Add("@Cedula", OleDbType.VarChar).Value = pEmpleado.Cedula
            cmdEmpleado.Parameters.Add("@Nombre", OleDbType.VarChar).Value = pEmpleado.NombreCompleto
            cmdEmpleado.Parameters.Add("@Fecha_Ingreso", OleDbType.Date).Value = pEmpleado.FechaIngreso
            cmdEmpleado.Parameters.Add("@Horas", OleDbType.Integer).Value = pEmpleado.HorasTrabajadas
            cmdEmpleado.Parameters.Add("@Precio_hora", OleDbType.Double).Value = pEmpleado.PrecioHora
            cmdEmpleado.Parameters.Add("@Ind_Activo", OleDbType.Boolean).Value = pEmpleado.IndicadorActivo
            cmdEmpleado.ExecuteNonQuery()
            miConexion.Close()
        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub ModificarEmpleado(ByVal pEmpleado As EmpleadoEN)
        Try


        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub BorrarEmpleado(ByVal pEmpleado As EmpleadoEN)
        Try


        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Function ObtenerEmpleadoPorCedula(ByVal pCedula As String) As EmpleadoEN
        Try
            miConexion.Open()
            Dim strBuscar As String
            strBuscar = "SELECT Cedula,Nombre,Fecha_Ingreso,Horas,Precio_hora,Ind_Activo FROM Empleado Where Cedula=@Cedula"
            Dim cmdEmpleado As New OleDbCommand(strBuscar, miConexion)
            cmdEmpleado.Parameters.Add("@Cedula", OleDbType.VarChar).Value = pCedula

            Dim myEmp As empleadoEN = Nothing
            Dim drEmpleado As OleDbDataReader
            drEmpleado = cmdEmpleado.ExecuteReader()
            While (drEmpleado.Read)
                myEmp = New empleadoEN
                myEmp.Cedula = drEmpleado("Cedula")
                myEmp.NombreCompleto = drEmpleado("Nombre")
                myEmp.FechaIngreso = drEmpleado("Fecha_Ingreso")
                myEmp.HorasTrabajadas = drEmpleado("Horas")
                myEmp.PrecioHora = drEmpleado("Precio_hora")
                myEmp.IndicadorActivo = drEmpleado("Ind_Activo")

            End While
            drEmpleado.Close()
            miConexion.Close()
            Return myEmp

        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

    Public Function obtenerTodosEmpleados() As List(Of EmpleadoEN)
        Try


        Catch ex As Exception
            If (miConexion.State = ConnectionState.Open) Then
                miConexion.Close()
            End If
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

End Class




