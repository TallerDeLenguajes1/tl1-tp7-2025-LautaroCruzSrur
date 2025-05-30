namespace EmpleadosSpace;

public class Empleado
{
    private string Nombre;
    private string Apellido;

    private datetime FechaNacimiento;

    private char EstadoCivil;
    private dateTime FechaDeIngresoEnLaEmpresa;
    private double SueldoBasico;

    private enum Cargos
    {
        Administrativo = 1;
        Ingeniero = 2;
        Especialista = 3;
        Investigador = 4;

    }

    public datetime CalcularAntiguedad() {
        
    }
    public datetime CalcularEdad() {
        
    }
}