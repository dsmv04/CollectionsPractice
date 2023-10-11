using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Tres matrices básicas
        int[] numeros = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        string[] nombres = new string[] { "Tim", "Martin", "Nikki", "Sara" };
        bool[] valoresBooleanos = new bool[10];
        for (int i = 0; i < valoresBooleanos.Length; i++)
        {
            valoresBooleanos[i] = i % 2 == 0; // Alterna entre verdadero y falso
        }

        // Lista de Sabores
        List<string> saboresHelado = new List<string>
        {
            "Chocolate", "Fresa", "Vainilla", "Caramelo", "Mango"
        };
        Console.WriteLine("Longitud de la lista de sabores: " + saboresHelado.Count);

        if (saboresHelado.Count >= 3)
        {
            Console.WriteLine("Tercer sabor de la lista: " + saboresHelado[2]);
            saboresHelado.RemoveAt(2);
            Console.WriteLine("Nueva longitud de la lista: " + saboresHelado.Count);
        }

        // Diccionario de Información del Usuario
        Dictionary<string, string> informacionUsuario = new Dictionary<string, string>();
        Random rand = new Random();

        // Añade pares clave/valor al diccionario
        for (int i = 0; i < nombres.Length; i++)
        {
            int indiceSabor = rand.Next(saboresHelado.Count);
            informacionUsuario[nombres[i]] = saboresHelado[indiceSabor];
        }

        // Imprime el diccionario
        foreach (var kvp in informacionUsuario)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}
