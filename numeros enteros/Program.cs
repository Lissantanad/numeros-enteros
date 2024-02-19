
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad de números enteros: ");
        int cantidad = int.Parse(Console.ReadLine());

        int[] numeros = new int[cantidad];

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Los números ingresados son:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}