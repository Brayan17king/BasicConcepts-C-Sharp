using System;

public interface IDemo
{
    void MetodoDemo();
}

public class ClaseDemo : IDemo
{
    public void MetodoDemo()
    {
        Console.WriteLine("Método Demo implementado en ClaseDemo");
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        IDemo objetoDemo = new ClaseDemo(); // Crear una instancia de ClaseDemo como IDemo
        objetoDemo.MetodoDemo(); // Llamar al método de la interfaz
    }
}
