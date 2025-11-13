namespace Tarefa5
{
    public class Tarefa5
    {
        public static void Main()
        {
            Console.WriteLine("================ Operadores Lógicos =================");

            bool isLoggedIn = true;
            bool hasPermission = false;

            Console.WriteLine("\nInformações do usuário:");
            COnsole.WriteLine("Usuário logado: " + isLoggedIn);
            Console.WriteLine("Usuário com permissão: " + hasPermission);

            // Operador (&&) - E
            if (isLoggedIn && hasPermission)
            {
                Console.WriteLine("\nAcesso concedido: O usuário está logado e tem permissão.");
            }
            else
            {
                Console.WriteLine("\nAcesso negado: O usuário não está logado ou não tem permissão.");
            }
        }
    }
}