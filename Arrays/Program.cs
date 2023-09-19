internal class Program
{
    private static void Main(string[] args)
    {
        //Estructuras de datos 

        //Arreglos
        int[] arreglo1 = new int[2];
        arreglo1[0] = 10;
        arreglo1[1] = 20;
        
        //Declaracion
        // int[] num;
        // string [] nombres;
        // double[] precios;

        //Inicializacion
        int[] numeros = new int[5];
        string[] nom = new string[]{"Ana","Juan","Maria"};
        Double[] prec = {2.99, 4.5, 9.99, 2.5};

        //Acceso a Elementos de un arreglo
        double primeroNumero = prec[0];//Primer elemeto 2.99
        Console.WriteLine(primeroNumero);
        double segundoNumero = prec[1];//segundo elemeto 4.5
        Console.WriteLine(segundoNumero);

        //recorrer un arreglo
        foreach(double n in prec)
        {
            Console.WriteLine(n);
        }

        //Metodos de arreglos

        //Metodo Length
        //Devuelve la longitud del arreglo
        double longitud = prec.Length;
        Console.WriteLine(longitud);//Devuelve 3

        //Metodo Sort()
        //ordena los elementos de un arreglo de forma ascendente.
        Array.Sort(prec);
        foreach(double n in prec)
        {
            Console.WriteLine(n);
        }

        //Metodo Reverse()
        //Devuelve el índice de la primera aparición de un elemento en el arreglo.
        double indice = Array.IndexOf(prec, 4.5);
        Console.WriteLine(indice);

        //Metodo Copy()
        //Copia los elementos de un arreglo a otro.
        int [] arreglo = {1,2,3,4,5};    
        int [] arreglo2 = new int[5];    
        Array.Copy(arreglo, arreglo2, 5);
        foreach(int n in arreglo2)
        {
            Console.WriteLine(n);
        }

    }
}