using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
       
        int[] arreglo = { 5, 10, 15, 20, 25 };
        Console.WriteLine("Arreglo original:");
        MostrarArreglo(arreglo);

        
        Console.WriteLine("\nActualizando valor del índice 2 a 30...");
        ActualizarValorEnArreglo(arreglo, 2, 30);
        MostrarArreglo(arreglo);

        
        Console.WriteLine("\nBuscando el valor 20 en el arreglo...");
        int indiceEncontrado = BuscarEnArreglo(arreglo, 20);
        Console.WriteLine(indiceEncontrado != -1
            ? $"Valor 20 encontrado en el índice {indiceEncontrado}."
            : "Valor 20 no encontrado.");

        
        List<int> lista = new List<int> { 3, 6, 9, 12, 15 };
        Console.WriteLine("\nLista original:");
        MostrarLista(lista);

        
        Console.WriteLine("\nAñadiendo valor 18 a la lista...");
        AgregarALista(lista, 18);
        MostrarLista(lista);

        
        Console.WriteLine("\nBuscando el valor 12 en la lista...");
        indiceEncontrado = BuscarEnLista(lista, 12);
        Console.WriteLine(indiceEncontrado != -1
            ? $"Valor 12 encontrado en el índice {indiceEncontrado}."
            : "Valor 12 no encontrado.");

        
        double promedio = CalcularPromedio(lista);
        Console.WriteLine($"\nEl promedio de los valores en la lista es: {promedio:F2}");
    }

    
    static void MostrarArreglo(int[] arreglo)
    {
        foreach (int valor in arreglo)
        {
            Console.Write(valor + " ");
        }
        Console.WriteLine();
    }

    
    static void ActualizarValorEnArreglo(int[] arreglo, int indice, int nuevoValor)
    {
        if (indice >= 0 && indice < arreglo.Length)
        {
            arreglo[indice] = nuevoValor;
        }
        else
        {
            Console.WriteLine("Índice fuera de rango.");
        }
    }

    
    static int BuscarEnArreglo(int[] arreglo, int valor)
    {
        for (int i = 0; i < arreglo.Length; i++)
        {
            if (arreglo[i] == valor)
            {
                return i;
            }
        }
        return -1;
    }

    
    static void MostrarLista(List<int> lista)
    {
        foreach (int valor in lista)
        {
            Console.Write(valor + " ");
        }
        Console.WriteLine();
    }

    
    static void AgregarALista(List<int> lista, int valor)
    {
        lista.Add(valor);
    }

    
    static int BuscarEnLista(List<int> lista, int valor)
    {
        return lista.IndexOf(valor);
    }

    
    static double CalcularPromedio(List<int> lista)
    {
        int suma = 0;
        foreach (int valor in lista)
        {
            suma += valor;
        }
        return (double)suma / lista.Count;
    }
}

