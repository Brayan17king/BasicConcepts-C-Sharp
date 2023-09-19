using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace Clases
{
    //Clase Abstracta
    public abstract class Vehiculo
    {
        //propiedad regular
        public string Marca {get; set;}

        //Metodo abstracto que debe ser implementado por las clases hijas
        public abstract void Conducir();

        //Metodo no abstracto (con implementacion) que puede ser heredado por las clases hijas
        public void MostrarMarca()
        {
            Console.WriteLine("Marca de vehiculo: "+ Marca);
        }

    }

    //Clase que hereda de la clase abstracta
    public class Coche :Vehiculo
    {
        //Implementacion del metodo abstracto Conducir
        public override void Conducir()
        {
            Console.WriteLine("El coche se esta conduciendo");
        }
    }

    //Clase que hereda de la clase abstracta
    public class Moto : Vehiculo
    {
        //Implementacion del metodo abstracto Conducir
        public override void Conducir()
        {
            Console.WriteLine("La moto se esta conduciendo");
        }
    }

    class Program
    {
        static void Main()
        {
            //No se puede instanciar un objeto directo directamente de la clase abstacta
            //Vehiculo miVehiculo = new Vehiculo(); // Esto da error

            //Sin embargo, se pueden crear objetos de las clases hijas
            Vehiculo miCoche = new Coche();
            miCoche.Marca = "Toyota";
            miCoche.MostrarMarca();
            miCoche.Conducir();

            Vehiculo miMoto = new Moto();
            miMoto.Marca = "Yamaha";
            miMoto.MostrarMarca();
            miMoto.Conducir();
        }
    }
}