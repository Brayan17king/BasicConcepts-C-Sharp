using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clases.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Alumno estudiante = new Alumno("Pepito");
        Console.WriteLine(estudiante.IdAlumno);
        Console.WriteLine(estudiante.Nombre);
    }
}