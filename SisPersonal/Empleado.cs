namespace EmpleadosSpace;

public class Empleado
{
    private string nombre;
    private string apellido;

    private DateTime fechaNacimiento;

    private char estadoCivil;
    private DateTime fechaDeIngreso;
    private double sueldoBasico;
    private Cargos cargo;
    public string Nombre
{
    get => nombre;
    set => nombre = value;
}

public string Apellido
{
    get => apellido;
    set => apellido = value;
}

public DateTime FechaNacimiento
{
    get => fechaNacimiento;
    set => fechaNacimiento = value;
}

public char EstadoCivil
{
    get => estadoCivil;
    set => estadoCivil = value;
}

public DateTime FechaDeIngreso
{
    get => fechaDeIngreso;
    set => fechaDeIngreso = value;
}

public double SueldoBasico
{
    get => sueldoBasico;
    set => sueldoBasico = value;
}

public Cargos Cargo
{
    get => cargo;
    set => cargo = value;
}


    public enum Cargos
    {
        Administrativo = 1,
        Ingeniero = 2,
        Especialista = 3,
        Investigador = 4,
    }

    public int CalcularAntiguedad(DateTime FechaDeIngresoEnLaEmpresa)
    {
        DateTime hoy = DateTime.Today;
        int Antiguedad = hoy.Year - FechaDeIngresoEnLaEmpresa.Year;

        if (hoy.Month < FechaDeIngresoEnLaEmpresa.Month || (hoy.Month == FechaDeIngresoEnLaEmpresa.Month && hoy.Day < FechaDeIngresoEnLaEmpresa.Day))
        {
            Antiguedad--;
        }

        return Antiguedad;
    }
    public int CalcularEdad(DateTime FechaNacimiento)
    {
        DateTime hoy = DateTime.Today;
        int edad = hoy.Year - FechaNacimiento.Year;

        if (hoy.Month < FechaNacimiento.Month || (hoy.Month == FechaNacimiento.Month && hoy.Day < FechaNacimiento.Day))
        {
            edad--;
        }

        return edad;

    }
    public int Jubilacion(int edad)
    {
        int JubilacionEdad = 65 - edad;

        return JubilacionEdad;
    }
    public double Salario(double SueldoBasico, int Antiguedad, Cargos Cargo, char EstadoCivil)
    {
        double Adicional = 0;
        if (Antiguedad > 20)
        {
            Adicional += (SueldoBasico * 0.25);
        }
        else
        {
            Adicional += ((SueldoBasico * 0.01) * Antiguedad);
        }
        if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
        {
            Adicional += (Adicional * 0.50);
        }
        if (EstadoCivil == 'C')
        {
            Adicional += 150000;
        }
        double salario = SueldoBasico + Adicional;

        return salario;
    }
    
    public Empleado(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil, DateTime fechaDeIngreso, double sueldoBasico, Cargos cargo)
{
    this.nombre = nombre;
    this.apellido = apellido;
    this.fechaNacimiento = fechaNacimiento;
    this.estadoCivil = estadoCivil;
    this.fechaDeIngreso = fechaDeIngreso;
    this.sueldoBasico = sueldoBasico;
    this.cargo = cargo;
}

}