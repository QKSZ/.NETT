Imports _1AccesoDatos
Imports _3Entidades
Public Class EmpleadoLN
    Public Sub New()
        ' Como la clase no contiene atributos, únicamente métodos, esta se podría dejar tal cual
    End Sub

    Public Sub InsertarEmpleado(ByVal pEmpleado As EmpleadoEN)
        Try
            If (pEmpleado.Cedula.Trim().Length = 0) Then
                Throw New Exception("La Cedula es obligatoria")
            ElseIf (pEmpleado.Cedula.Trim().Length > 15) Then
                Throw New Exception("La Cedula no debe superar 15 caracteres")
            ElseIf String.IsNullOrWhiteSpace(pEmpleado.NombreCompleto) Then
                Throw New Exception("Nombre debe existir")
            ElseIf (pEmpleado.Horas < 20) Then
                Throw New Exception("Debe trabajar mas de 20 horas")
            ElseIf (pEmpleado.PrecioHora < 800) Then
                Throw New Exception("El salario no puede ser menor a 800")
            ElseIf (pEmpleado.Fecha > Date.Today) Then
                Throw New Exception("El ingreso no debe ser a futuro")
            End If

            Dim ADEmp As New EmpleadoAD
            ADEmp.InsertarEmpleado(pEmpleado)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub ModificarEmpleado(ByVal pEmpleado As EmpleadoEN)
        Try


        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub BorrarEmpleado(ByVal pEmpleado As EmpleadoEN)
        Try


        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Function ObtenerEmpleadoPorCedula(ByVal pCedula As String) As EmpleadoEN
        Try


        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

    Public Function obtenerTodosEmpleados() As List(Of EmpleadoEN)
        Try


        Catch ex As Exception
            Throw New Exception(ex.Message)
            Exit Function
        End Try
    End Function

End Class
