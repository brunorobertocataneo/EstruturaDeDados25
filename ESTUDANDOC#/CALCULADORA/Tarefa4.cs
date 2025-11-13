namespace Tarefa4
{
    public class Tarefa4
    {
        public static void Main()
        {
            Console.WriteLine("================ Operadores Relacionais =================");
            Console.WriteLine("Digite o primeiro número:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int y = int.Parse(Console.ReadLine());

            string result;

            // Operador de Igualdade (==)
            if (x == y)
            {
                result = "x é igual a y.";
            }
            else
            {
                result = "x não é igual a y.";
            }

            Console.WriteLine("\n igualdade (==): " + result);

            // Operador de Desigualdade (!=)
            if (x != y)
            {
                result = "x é diferente de y.";
            }
            else
            {
                result = "x é igual y.";
            }

            Console.WriteLine("\n Desigualdade (!=): " + result);

            // Operador Maior Que (>)
            if (x > y)
            {
                result = "x é maior que y.";
            }
            else
            {
                result = "x não é maior que y.";
            }
            // Operador Menor Que (<)
            Console.WriteLine("\n Maior Que (>): " + result);
            if (x < y)
            {
                result = "x é menor que y.";
            }
            else
            {
                result = "x não é menor que y.";
            }
        }
    }
}