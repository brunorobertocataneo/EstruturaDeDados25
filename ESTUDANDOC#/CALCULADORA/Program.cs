namespace Program
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("================ Calculadora Aritmética Básica =================");
            Console.WriteLine("Digite o primeiro número:");
            float number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            float number2 = int.Parse(Console.ReadLine());

            float sum = number1 + number2;
            float subtraction = number2 - number1;
            float multiplication = number1 * number2;
            double division = (double)number2 / number1;
            float modulus = number2 % number1; // Resto da Divisão

            Console.WriteLine("Soma: " + sum); // Pode ser dessa maneira também
            Console.WriteLine($"Subtração: {subtraction}");
            Console.WriteLine($"Multiplicação: {multiplication}");
            Console.WriteLine($"Divisão: {division}");
            Console.WriteLine($"Módulo (Resto da Divisão): {modulus}");
            
            
        }
    }
}