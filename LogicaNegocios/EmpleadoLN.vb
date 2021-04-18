Imports _1AccesoDatos
Imports _3Entidades
Imports System.Data.OleDb


Public Class EmpleadoLN
    Public Sub New()
        ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
    End Sub

    Public Sub InsertarEmpleado(ByVal pEmpleado As empleadoEN)
        Try
            If (pEmpleado.Cedula.Trim().Length = 0) Then
                Throw New Exception("La Cedula es Obligatoria")
            ElseIf (pEmpleado.Cedula.Trim().Length >= 16) Then
                Throw New Exception("La Cedula no debe superar 15 Caracteres")
            ElseIf String.IsNullOrWhiteSpace(pEmpleado.NombreCompleto) Then
                Throw New Exception("Nombre debe existir")
            ElseIf (pEmpleado.HorasTrabajadas <= 19) Then
                Throw New Exception("Debe trabajar mas de 19 horas")
            ElseIf (pEmpleado.PrecioHora <= 799) Then
                Throw New Exception("El precio por hora debe ser mayor a 799")
            ElseIf (pEmpleado.FechaIngreso > Date.Today) Then
                Throw New Exception("El Ingreso no debe ser a futuro")
            End If

            Dim ADEmp As New EmpleadoAD
            ADEmp.InsertarEmpleado(pEmpleado)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub ModificarEmpleado(ByVal pEmpleado As empleadoEN)
        Try


        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub BorrarEmpleado(ByVal pEmpleado As empleadoEN)
        Try


        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Function ObtenerEmpleadoPorCedula(ByVal pCedula As String) As empleadoEN
        Try

            If (pCedula.Trim().Length = 0) Then
                Throw New Exception("La Cedula es Obligatoria")
            ElseIf (pCedula.Trim().Length >= 16) Then
                Throw New Exception("La Cedula no debe superar 15 Caracteres")
            End If

            Dim ADEmp As New EmpleadoAD
            Return ADEmp.ObtenerEmpleadoPorCedula(pCedula)

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

    Public Function obtenerTodosEmpleados() As List(Of empleadoEN)
        Try


        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

End Class

