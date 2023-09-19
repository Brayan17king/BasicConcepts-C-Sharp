using System;
using System.Collections; // Dependecia Necesaria
internal class Program
{
    private static void Main(string[] args)
    {
        //Array List
        //convencionales, ArrayList puede crecer o disminuir automáticamente según sea necesario para acomodar elementos adicionales.

        //Metodos

        //Metodo Add
        //Agrega un elemento al final de la lista
        ArrayList myAL = new ArrayList();
        myAL.Add("The");
        myAL.Add("quick");
        myAL.Add("brown");
        myAL.Add("fox");

        foreach(string n in myAL)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine("================================");
        //Metodo AddRange
        //Combinar elementos de las listas
        ArrayList Carnivoros = new ArrayList();
        ArrayList Acuaticos  = new ArrayList();
        ArrayList Animales  = new ArrayList();

        Carnivoros.Add("Tigre");
        Carnivoros.Add("Leon");
        Carnivoros.Add("Pantera");
        Carnivoros.Add("Leopardo");
        Acuaticos.Add("Tiburon");
        Acuaticos.Add("Delfin");
        Acuaticos.Add("Ballena");
        Acuaticos.Add("Pulpo");

        Animales.AddRange(Carnivoros);
        foreach(Object c in Animales)
        {
            Console.WriteLine(c);
        }

        Animales.Clear();
        Console.WriteLine("================================");

        Animales.AddRange(Acuaticos);
        foreach(Object a in Animales)
        {
            Console.WriteLine(a);
        }

        //Metodo Clear()
        //Quita todos los elementos de ArrayList.

        // Animales.Clear();
        
        //Metodo Contains
        //Determina si un elemento se encuentra en ArrayList.
        //Devuelve True o False
        Console.WriteLine("================================");
        string palabra;
        ArrayList Materias = new ArrayList();

        Materias.Add("Matematicas");
        Materias.Add("Fisica");
        Materias.Add("Quimica");
        Materias.Add("Ingles");
        Materias.Add("Matematicas");

        Console.WriteLine("Escriba la materia a buscar: ");
        palabra = Console.ReadLine();
        Console.WriteLine(Materias.Contains(palabra) ? "La materia esta disponible":"la materia no esta disponible");
        
        Console.WriteLine("================================");
        //Metodo IndexOf
        //Busca el objeto Object especificado y devuelve el índice de base cero de la primera aparición en toda la colección ArrayList.
        Console.WriteLine(Materias.IndexOf(palabra));

        //Metodos Insert e InsertRange
        //Inserta un elemento en ArrayList en el índice especificado e InsertRange Inserta los elementos de una colección en ArrayList en el índice especificado.
        //Insert
        Console.WriteLine("================================");
        string juego;
        int idx;
        ArrayList Juegos = new ArrayList();

        Juegos.Add("League of Leyends");
        Juegos.Add("Clash Royale");
        Juegos.Add("Brawl Stars");
        Juegos.Add("Pokemon Unite");

        do
        {
            Console.Write("Ingrese la posicion donde desea insertar el nuevo juego: ");
            idx = Convert.ToInt32(Console.ReadLine());
        }while(idx > Juegos.Count);

        Console.Write("Escriba el juego a insertar: ");
        juego = Console.ReadLine();

        Juegos.Insert(idx, juego);

        foreach(Object j in Juegos)
        {
            Console.WriteLine(j);
        }

        //InsertRange
        Console.WriteLine("================================");
        ArrayList Cursos = new ArrayList();

        Cursos.Add("Octavo");
        Cursos.Add("Noveno");

        Juegos.InsertRange(idx, Cursos);

        foreach(Object n in Juegos)
        {
            Console.WriteLine(n);
        }
        
        //Metodo LastIndexOF()
        //ultima aparicion de un elemento.
        Console.WriteLine("================================");
        Console.WriteLine(Materias.LastIndexOf(palabra)); //Devuelve 4

        //Metodo Remove()
        //Elimina la primera aparicion de un elemento especifico del ArrayList.
        Console.WriteLine("================================");
        ArrayList Frutas = new ArrayList();
        Frutas.Add("Manzana");
        Frutas.Add("Pera");
        Frutas.Add("Kiwi");

        Frutas.Remove("Manzana");//Eliminamos del ArrayList "Manzana"
        foreach(Object f in Frutas)
        {
            Console.WriteLine(f);
        }

        //Metodo RemoveAt()
        //Elimina un elemento especifico de un ArrayList.
        Console.WriteLine("================================");
        Frutas.RemoveAt(0);

        foreach(Object at in Frutas)//Elimina un elemento 0 
        {
            Console.WriteLine(at);
        }

        //Metodo ToArray()
        //se utiliza para convertir una colección o secuencia en un arreglo.
        Console.WriteLine("================================");
        string [] ToArray = (String[]) Frutas.ToArray(typeof(string));

        foreach(string to in ToArray)
        {
            Console.WriteLine(to);
        }
    }
}