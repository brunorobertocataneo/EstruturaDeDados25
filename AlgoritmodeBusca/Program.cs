using System;

public class Program
{
    public static void Main(string[] args)
    {
        string[] dados = new string[] 
        {
            "Maria", "25", "Pedro", "Ana", "Carlos", 
            "100", "Lucas", "Sofia", "Miguel", "7"
        };

        Console.Write("Digite o nome ou número a ser pesquisado: ");
        string? entradaUsuario = Console.ReadLine(); 

        bool encontrado = false;
        int i = 0;

        if (entradaUsuario != null)
        {
            while (i < dados.Length) 
            {
                if (dados[i].ToLower() == entradaUsuario.ToLower())
                {
                    Console.WriteLine($"Item {entradaUsuario} encontrado na posição: {i}");
                    encontrado = true;
                    break; 
                }
                i++; 
            }
        }
        
        if (!encontrado)
        {
            Console.WriteLine("Item não encontrado.");
        }
    }
}