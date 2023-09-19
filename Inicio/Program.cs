using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        //Variables en C#
        // int, string, double, bool.✨

        string nombre = string.Empty;
        // int edad = 0;
        // double sueldo = 0.0;
        // bool estado = false;

        //Constantes en C#
        //se declaran con const y se les debe asignar el valor de inmediato.
        //const double iva = 16.8;

        //Booleanos en C#
        bool check = true;
        Console.WriteLine(check ? "Activo":"Inactivo"); //Activo
        Console.WriteLine(false ? "Activo":"Inactivo"); //Inactivo

        //Flotantes en C#
        var a = 12.3;
        double b = 12.3;
        Console.WriteLine($"El valor de a es = {a}");
        Console.WriteLine($"El valor de b es = {b}");

        double d = 3D;
        d = 4d;
        d = 3.934_001;
        Console.WriteLine($"{d}");

        float f = 3_005F;
        f = 5.4f;
        Console.WriteLine($"{f}");

        decimal myMoney = 3_000.5m;
        myMoney = 400.75M;
        Console.WriteLine($"{myMoney}");

        //Cadenas con formato númerico estandar
        decimal value = 123.456m;
        Console.WriteLine(value.ToString("C2")); //$123,46
        Console.WriteLine("Your account balance is {0:C2}.", value);//Your account balance is $ 123,46.

        decimal[] amounts = { 16305.32m, 18794.16m };
        Console.WriteLine(" Balance Inicial  Balance Final");
        Console.WriteLine(" {0,-18:C2}{1,-20:C2}", amounts[0], amounts[1]);

        //Entrada y salida de Datos.
        Console.WriteLine("Esto es un mensaje de texto");
        Console.WriteLine("Este es otro un mensaje de texto");

        //Write -> Permite imprimir en consola un texto sin insertar salto de línea al final.
        Console.Write("El dia esta soleado y");
        Console.WriteLine(" hace calor");

        //Entrada de datos -> C# permite ingresar información desde el teclado a través de la función (Read Line);
        Console.WriteLine("Hola este es mi primer programa. Cual es tu nombre?");
        string name = Console.ReadLine();
        Console.WriteLine($"Hola {name}, Mucho gusto en conocerte 😊");

        //Conversion de tipos de datos:
        //Conversion Implicita:
        int num = 1313545122;
        long bigNum = num;
        bigNum = 1231231238854546564;

        //Estructuras Condicionales
        int totalJugador = 0;
        int totalDealer = 15;
        string mensaje = "";

        //if
        if (totalJugador < totalDealer)
        {
            mensaje = "Haz ganado";
        }
        Console.WriteLine(mensaje);

        //if...else if
        if (totalJugador < totalDealer)
        {
            mensaje = "Haz ganado";
        }
        else
        {
            mensaje = "Haz perdido";
        }
        Console.WriteLine(mensaje); 

        //if...else if...else
        if (totalJugador < totalDealer)
        {
            mensaje = "Haz ganado";
        }
        else if (totalJugador > totalDealer)
        {
            mensaje = "Haz perdido";
        }
        else
        {
            mensaje = "Empate";
        }
        Console.WriteLine(mensaje);

        //Switch
        int num1 = 1;
        switch (num1)
        {
            case 1:
                Console.WriteLine("10"); // Bloque de codigo para el caso 1.
                break;
            case 2:
                Console.WriteLine("20");
                break;
            case 3:
                Console.WriteLine("30");
                break;
            default:
                Console.WriteLine("Otro numero");
                break;
        }
        
        int diaSemana = 3;
        string nombreDia;

        switch(diaSemana)
        {
            case 1:
                nombreDia = "Lunes";
                break;
            case 2:
                nombreDia = "Martes";
                break;
            case 3:
                nombreDia = "Miercoles";
                break;
            case 4:
                nombreDia = "Jueves";
                break;
            case 5:
                nombreDia = "Viernes";
                break;
            case 6:
                nombreDia = "Sabado";
                break;
            case 7:
                nombreDia = "Domingo";
                break;
            default:
                nombreDia = "Dia no valido";
                break;
        }

        //Estructuras Repetitivas
        //Ciclo for
        for(int i = 0; i <= 5; i++)
        {
            Console.WriteLine(i);
        }

        //Ciclo while
        int j = 0;
        while(j <= 5)
        {
            Console.WriteLine(j);
            j++;
        }

        //Ciclo do while
        int numero = 1;
        do
        {
            Console.WriteLine("Ingrese un numero mayor que cero: ");
            string input = Console.ReadLine();
            numero = Convert.ToInt32(input);
        }while(numero <= 0);

        Console.WriteLine("Numero valido ingresado: "+ numero);  
    }
}       