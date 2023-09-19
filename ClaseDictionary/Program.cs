using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        //Diccionarios
        /*En C#, un diccionario es una estructura de datos que almacena pares de clave-valor. Cada
        elemento en un diccionario consiste en una clave única y su correspondiente valor. La clave se
        utiliza para acceder y recuperar el valor asociado.*/

        Dictionary<int, string> diccionario = new Dictionary<int, string>();

        //Propiedades

        //Count
        //Obtiene el número de pares clave-valor incluidos en Dictionary<TKey,TValue>.
        Console.WriteLine("El total de elementos del diccionario es : {0}", diccionario.Count);

        //Add
        //Agrega un elemento nuevo al diccionario.
        Console.WriteLine("=====================================================");
        diccionario.Add(1, "Uno");
        diccionario.Add(2, "Dos");
        diccionario.Add(3, "Tres");
        diccionario.Add(4, "Cuatro");
        
        foreach (Object n in diccionario)
        {
            Console.WriteLine(n);
        }

        //Agregamos un Try-Catch para los errores
        try
        {
            diccionario.Add(1, "Holis");
        }
        catch
        {
            Console.WriteLine("Un elemento con la llave 1 ya existe.");
        }
        
        //Key
        //Obtiene una colección que contiene las claves de Dictionary<TKey,TValue>.
        Console.WriteLine("=====================================================");
        Dictionary<int, string>.KeyCollection keyColl = diccionario.Keys;

        foreach (int key in keyColl)
        {
            Console.WriteLine(key);
        }

        //KeyValuePair
        Console.WriteLine("=====================================================");
        foreach(KeyValuePair<int, string> pair in diccionario)
        {
        Console.WriteLine("Llave {0} - Valor {1}", pair.Key, pair.Value);
        }

        //Values
        //Obtiene una colección que contiene los valores de Dictionary<TKey,TValue>.
        Console.WriteLine("=====================================================");
        Dictionary<int, string>.ValueCollection valueColl = diccionario.Values;
        foreach(string valor in valueColl)
        {
            Console.WriteLine(valor);
        }

        //Metodos

        //Metodo Add
        //Agrega un elemento nuevo al diccionario.
        Console.WriteLine("=====================================================");
        diccionario.Add(5, "Cinco");

        //Metodo Clear
        //Quitar todas las claves y valores del diccionario.
        //diccionario.Clear();

        //ContainsKey
        //Determina si Dictionary<TKey,TValue> contiene la clave especificada.
        Console.WriteLine("=====================================================");
        // Crear un diccionario de cadenas (string) a enteros (int)
        Dictionary<string, int> edades = new Dictionary<string, int>();

        // Agregar algunas entradas al diccionario
        edades["Juan"] = 30;
        edades["María"] = 25;
        edades["Carlos"] = 40;

        // Verificar si una clave existe en el diccionario
        string nombre = "Juancho";
        bool contieneLaClave = edades.ContainsKey(nombre);

        // Mostrar el resultado
        if (contieneLaClave)
        {
            Console.WriteLine($"El diccionario contiene la clave '{nombre}' y su valor es {edades[nombre]} años.");
        }
        else
        {
            Console.WriteLine($"La clave '{nombre}' no se encuentra en el diccionario.");
        }

        //ContainsValue
        //Determina si Dictionary<TKey,TValue> contiene un valor específico.

        //Verificar si un valor existe en el diccionario
        Console.WriteLine("=============================================");
        int edad = 25;
        bool contieneElValor = edades.ContainsValue(edad);

        // Mostrar el resultado
        if (contieneElValor)
        {
            Console.WriteLine($"El diccionario contiene el valor '{edad}' años.");
        }
        else
        {
            Console.WriteLine($"El valor '{edad}' no se encuentra en el diccionario.");
        }

        //Metodo Remove
        //Quitar una clave y su valor del diccionario.
        Console.WriteLine("=====================================================");
        edades.Remove("Juan");

        foreach(Object a in edades)
        {
            Console.WriteLine(a);
        }
    }
}