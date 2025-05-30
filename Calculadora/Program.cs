using EspacioCalculadora;

bool escape = false;
Console.WriteLine("Bienvenido a la Calculadora");
do
{
    int opcion;
    Console.WriteLine("\n Ingrese una opcion \n 1-Suma \n2-Resta \n3-Division \n4-Multiplicacion");
    bool bandera = int.TryParse(Console.ReadLine(), out opcion);
    var calc = new Calculadora(0);
    if (bandera)
    {
        double numero;
        Console.WriteLine("\n Ingrese un numero");
        bool resultado = double.TryParse(Console.ReadLine(), out numero);
        calc = new Calculadora(numero);
        switch (opcion)
        {
            case 1:
                calc.Sumar(numero);
                break;
            case 2:
                calc.Restar(numero);
                break;
            case 3:
                calc.Dividir(numero);
                break;
            case 4:
                calc.Multiplicar(numero);
                break;
        }
    }
    Console.WriteLine("\n ¿Desea seguir operando?(y/n)");
    char SioNo;
    bool resultado2 = char.TryParse(Console.ReadLine(), out SioNo);
    if (resultado2)
    {
        if (SioNo != 'n' || SioNo != 'N')
        {
            escape = true;
        }
    }
    Console.WriteLine($"\n El resultado es{calc.Resultado()}");

} while (escape);