Public Class empleadoEN
#Region "Atributos"
    Dim _Cedula As String
    Dim _Nombre As String
    Dim _FechaIngreso As Date
    Dim _Horas As Integer
    Dim _PrecioHora As Double
    Dim _Activo As Boolean
#End Region
#Region "Constructores"

    ''' <summary>
    ''' Constructor de inicilizacion vacia del objeto
    ''' </summary>
    Public Sub New()
        _Cedula = String.Empty
        _Nombre = String.Empty
        _FechaIngreso = CType("01/01/1900", Date)
        _Horas = 0
        _PrecioHora = 0
        _Activo = False
    End Sub

    ''' <summary>
    ''' Recibe todos los valores del objeto
    ''' </summary>
    ''' <param name="pCedula">Id del empleado</param>
    ''' <param name="pNombre">Nombre completo</param>
    ''' <param name="pFecha">Fecha de ingreso</param>
    ''' <param name="pHoras">Horas trabajadas por semana</param>
    ''' <param name="pPrecio">Precio de cada hora</param>
    ''' <param name="pActivo">Indica si esta activo el empleado</param>
    Public Sub New(ByVal pCedula As String, ByVal pNombre As String,
               ByVal pFecha As Date, ByVal pHoras As Integer,
               ByVal pPrecio As Double, ByVal pActivo As Boolean)
        _Cedula = pCedula
        _Nombre = pNombre
        _FechaIngreso = pFecha
        _Horas = pHoras
        _PrecioHora = pPrecio
        _Activo = pActivo
    End Sub
#End Region
#Region "Propiedades"


    ''' <summary>
    ''' Id del Empleado
    ''' </summary>
    ''' <returns>Id del empleado</returns>
    Public Property Cedula As String
        Set(value As String)
            _Cedula = value
        End Set
        Get
            Return _Cedula
        End Get
    End Property
    ''' <summary>
    ''' Nombre Completo
    ''' </summary>
    ''' <returns>Nombre Completo</returns>
    Public Property NombreCompleto As String
        Set(value As String)
            _Nombre = value
        End Set
        Get
            Return _Nombre
        End Get
    End Property
    ''' <summary>
    ''' Fecha de Ingreso a la empresa
    ''' </summary>
    ''' <returns>Fecha de Ingreso a la empresa</returns>
    Public Property FechaIngreso As Date
        Set(value As Date)
            _FechaIngreso = value
        End Set
        Get
            Return _FechaIngreso
        End Get
    End Property
    ''' <summary>
    ''' Horas trabajadas por semana
    ''' </summary>
    ''' <returns>Horas trabajadas por semana</returns>
    Public Property HorasTrabajadas As Integer
        Set(value As Integer)
            _Horas = value
        End Set
        Get
            Return _Horas
        End Get
    End Property
    ''' <summary>
    ''' Precio de cada hora
    ''' </summary>
    ''' <returns>Precio de cada hora</returns>
    Public Property PrecioHora As Double
        Set(value As Double)
            _PrecioHora = value
        End Set
        Get
            Return _PrecioHora
        End Get
    End Property
    ''' <summary>
    ''' Indica si esta activo el empleado
    ''' </summary>
    ''' <returns>Indica si esta activo el empleado</returns>
    Public Property IndicadorActivo As Boolean
        Set(value As Boolean)
            _Activo = value
        End Set
        Get
            Return _Activo
        End Get
    End Property
#End Region
#Region "Metodos"
    Public Overrides Function ToString() As String

        Dim strDatos As String = String.Empty

        strDatos = "Cedula: " & _Cedula & vbCrLf &
        "Nombre: " & _Nombre & vbCrLf &
        "Fecha Ingreso: " & _FechaIngreso.ToShortDateString & vbCrLf &
        "Horas Trabajadas: " & _Horas & vbCrLf &
        "Precio Hora: " & _PrecioHora & vbCrLf &
        "Estado: " & IIf(_Activo, "Activo", "Inactivo")

        Return strDatos
    End Function
    ''' <summary>
    ''' Salario del empleado sin deducciones
    ''' </summary>
    ''' <returns></returns>
    Public Function SalarioBruto() As Double
        Dim dblSalario As Double
        dblSalario = _Horas * _PrecioHora
        Return dblSalario
    End Function
    Public Function SeguroSocial() As Double
        Dim dblSeguro As Double
        dblSeguro = SalarioBruto() * 9 / 100
        Return dblSeguro
    End Function
    Public Function SalarioNeto() As Double
        Dim dblSalario As Double
        dblSalario = SalarioBruto() - SeguroSocial()
        Return dblSalario
    End Function
#End Region
End Class



