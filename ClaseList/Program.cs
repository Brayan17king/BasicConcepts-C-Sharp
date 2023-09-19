using System;
using System.Collections.Generic;
internal class Program
{
    private static void Main(string[] args)
    {
        //Clase List
        //se utiliza para crear y manipular listas genéricas. Una lista genérica es una colección que puede contener elementos de un tipo específico

        //Declaracion
        //List<T> nombreLista = new List<T>();

        //Propiedades

        //Count
        //Obtiene el número de elementos incluidos en List<T>.

        List<string> Materias = new List<string>();

        Materias.Add("Calculo");
        Materias.Add("Programacion");
        Materias.Add("Matematicas");
        Materias.Add("Fisica");

        Console.WriteLine("El total de elementos de la lista {0} ", Materias.Count());
        Console.WriteLine("Capacidad total: {0} ", Materias.Capacity);//sirve para saber tambien el numero de elementos de la lista

        //Item
        //Obtiene o establece el elemento en el índice especificado.
        Console.WriteLine("=================================================");
        Console.WriteLine("Materia[3]: {0}", Materias[3]);

        //Metodos 
        //Metodo Add 
        //Agrega un objeto al final de List<T>.
        Console.WriteLine("=================================================");
        Materias.Add("Quimica");

        foreach(string a in Materias)
        {
            Console.WriteLine(a);
        }

        //Metodo AddRange
        //Agregar los elementos de una coleccion especificada al final de lista.
        Console.WriteLine("=================================================");
        List<string> Dinosaurios = new List<string>();

        string[] Dinos = {"Brachiosaurus", "Amargasaurus", "Mamenchisaurus"};
        Dinosaurios.AddRange(Dinos);

        foreach(String dinos in Dinosaurios)
        {
            Console.WriteLine(dinos);
        }

        //Metodo Clear
        //Limpia la lista.
        //Dinosaurios.Clear();

        //Metodo Exist
        //Determina si List<T> contiene elementos que cumplen las condiciones definidas por el predicado especificado.
        Console.WriteLine("=================================================");
        Console.WriteLine("Ingrese el nombre del dinosurio a buscar: ");
        string name = Console.ReadLine();
        Console.WriteLine(Dinosaurios.Exists(item => item.Equals(name)) ? "Se encontro el dinosaurio":"No se encontro el dinosaurio");

        //Metodo Find
        /*Busca un elemento que coincida con las condiciones definidas por el predicado especificado y
        devuelve la primera aparición en toda la matriz List<T>.*/
        Console.WriteLine("=================================================");
        Console.WriteLine("Ingrese el nombre del dinosaurio a buscar: ");
        string name2 = Console.ReadLine();

        string nombre = Dinosaurios.Find(n => n.StartsWith(name2 ?? String.Empty));
        Console.WriteLine(nombre != null ? "Se encontro":"No se encontro");

        //Metodo FindAll
        //Busca todos los elementos que cumplen las condiciones definidas por el predicado especificado.
        List<String> Encontrados = new List<String>();
        Console.WriteLine("=================================================");
        Console.WriteLine("Ingrese la letra del dinosaurio a buscar: ");
        string name3 = Console.ReadLine();

        Encontrados = Dinosaurios.FindAll(n => n.Contains(name3 ?? String.Empty));
        foreach(string n in Encontrados)
        {
            Console.WriteLine(n);
        }

        //Metodo FindLast
        //Busca el último elemento que cumpla las condiciones definidas por el predicado especificado.
        Console.WriteLine("=================================================");
        Console.WriteLine("Ingrese la letra del dinosaurio a buscar: ");
        string name4 = Console.ReadLine();

        string ultimoEncontrado = Dinosaurios.FindLast(n=> n.Contains(name4 ?? String.Empty));
        Console.WriteLine("El ultimo dinosaurio que contiene esa letra es: {0}", ultimoEncontrado);
    }
}
