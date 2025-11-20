using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> rastreios = new Dictionary<string, string>();

        Console.Write("Quantos pacotes deseja cadastrar? ");
        int qtd = int.Parse(Console.ReadLine());

        for (int i = 0; i < qtd; i++)
        {
            Console.Write("Código de rastreio: ");
            string rastreio = Console.ReadLine();

            Console.Write("Código da encomenda: ");
            string encomenda = Console.ReadLine();

            if (rastreios.ContainsValue(encomenda))
            {
                Console.WriteLine("Encomenda já cadastrada.");
            }
            else
            {
                try
                {
                    rastreios.Add(rastreio, encomenda);
                }
                catch
                {
                    Console.WriteLine("Rastreio já cadastrado.");
                }
            }
        }

        Console.Write("\nDigite um código para buscar: ");
        string busca = Console.ReadLine();

        if (rastreios.ContainsKey(busca))
        {
            Console.WriteLine($"Rastreio: {busca} - Encomenda: {rastreios[busca]}");
        }
        else if (rastreios.ContainsValue(busca))
        {
            foreach (var item in rastreios)
                if (item.Value == busca)
                    Console.WriteLine($"Rastreio: {item.Key} - Encomenda: {item.Value}");
        }
        else
        {
            Console.WriteLine("Nenhum registro encontrado.");
        }
    }
}