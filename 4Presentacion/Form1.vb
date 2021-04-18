Imports _3Entidades
Imports _2LogicaNegocios
Public Class Form1
    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Try
            Dim myEmp As New EmpleadoEN
            myEmp.Cedula = txtCedula.Text
            myEmp.NombreCompleto = txtNombre.Text
            myEmp.FechaIngreso = dtpFechaIngreso.Value
            myEmp.HorasTrabajadas = txtHoras.Text
            myEmp.PrecioHora = txtPrecio.Text
            If rbtnNo.Checked Then
                myEmp.IndicadorActivo = False
            ElseIf rbtnSi.Checked Then
                myEmp.IndicadorActivo = True
            End If

            Dim valida As New EmpleadoLN
            valida.InsertarEmpleado(myEmp)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim strCedula As String
        strCedula = InputBox("Digite la Cedula")

        Dim elEmp As empleadoEN = Nothing

        Dim valida As New EmpleadoLN
        elEmp = valida.ObtenerEmpleadoPorCedula(strCedula)
        If IsNothing(elEmp) Then
            MessageBox.Show("No Existe")
        Else
            txtCedula.Text = elEmp.Cedula
            txtNombre.Text = elEmp.NombreCompleto
            dtpFechaIngreso.Value = elEmp.FechaIngreso
            txtHoras.Text = elEmp.HorasTrabajadas
            txtPrecio.Text = elEmp.PrecioHora
            If elEmp.IndicadorActivo Then
                rbtnSi.Checked = True
            Else
                rbtnNo.Checked = True
            End If
        End If

    End Sub
End Class
