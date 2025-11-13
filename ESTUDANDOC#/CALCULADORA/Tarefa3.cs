namespace Tarefa2
{
    public class Tarefa3
    {
        public static void Main()
        {
            Console.WriteLine("================ Operadores de Atribuição =================");
            int a = 10;
            Console.WriteLine($"\nValor inicial de a: {a}");

            //Operador de atribuição simples(=)
            a = 20;

            Console.WriteLine("\nValor de a após atribuição simples (a = 20): " + a);

            // Operadores de atribuição compostos
            a++; // Adiciona 1 ao valor de a (incremento)

            Console.WriteLine(a);  // Novo valor de a
            a += 10;

            Console.WriteLine(a);  // Novo valor de a, equivalente a a = a + 10

            a -= 5;
            Console.WriteLine(a);  // Novo valor de a, equivalente a a = a - 5

            a *= 2;
            Console.WriteLine(a);  // Novo valor de a, equivalente a a = a * 2  

            a /= 4;
            Console.WriteLine(a);  // Novo valor de a, equivalente a a = a / 4

        }


    }
}