namespace EmpleadosSpace;

public class Empleado
{
    private string Nombre;
    private string Apellido;

    private DateTime FechaNacimiento;

    private char EstadoCivil;
    private DateTime FechaDeIngresoEnLaEmpresa;
    private double SueldoBasico;

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
        int JubilacionEdad = edad - 65;

        return JubilacionEdad;
    }
    public double Salario(double SueldoBasico, int Antiguedad, Cargos Cargo)
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
}