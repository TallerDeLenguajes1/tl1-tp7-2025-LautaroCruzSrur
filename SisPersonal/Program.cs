using EmpleadosSpace;

Empleado[] empleados = new Empleado[3]
{
    new Empleado("Juan", "Cruz", new DateTime(1990, 9, 15), 'C', new DateTime(2018, 1, 30), 250000,Empleado.Cargos.Administrativo),
    new Empleado("Martina", "Lopez", new DateTime(1985, 3, 22), 'S', new DateTime(2015, 6, 10), 320000,Empleado.Cargos.Ingeniero),
    new Empleado("Luis", "Gomez", new DateTime(1992, 12, 5), 'S', new DateTime(2020, 11, 1), 280000,Empleado.Cargos.Especialista)
};
double MontoTotal = 0;
int Antiguedad = 0;
int indiceEmpleado = 0;
for (int i = 0; i < 3; i++)
{
    int aux = 0;
    Antiguedad = empleados[i].CalcularAntiguedad(empleados[i].FechaDeIngreso);
    if (Antiguedad > aux)
    {
        indiceEmpleado = i;
    }
    aux = Antiguedad;
    MontoTotal += empleados[i].Salario(empleados[i].SueldoBasico, Antiguedad, empleados[i].Cargo, empleados[i].EstadoCivil);
}

Console.WriteLine($"El Empleado que esta mas proximo a jubilarse es :{empleados[indiceEmpleado].Nombre}+{empleados[indiceEmpleado].Apellido}\n lleva una antiguedad de {Antiguedad}años , tiene {}años , su salario es de {}. Le falta para jubilarse {},");
