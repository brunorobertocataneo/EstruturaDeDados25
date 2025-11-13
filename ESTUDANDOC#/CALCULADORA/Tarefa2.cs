namespace Tarefa2
{
    public class Tarefa2
    {
        public static void Main()
        {
            Console.WriteLine("================ Verificador de Números Pares e Ímpares =================");
            Console.WriteLine("Digite um número inteiro:");
            int number = int.Parse(Console.ReadLine());
           
            if (number % 2 == 0) //Se o resto da divisão por 2 for igual a 0, o número é par
            {
                Console.WriteLine($"O número {number} é Par.");
            }
            else
            {
                Console.WriteLine($"O número {number} é Ímpar.");
            }
        }
    }
}