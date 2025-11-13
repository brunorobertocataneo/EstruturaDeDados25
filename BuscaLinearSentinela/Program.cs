int[] numeros = {10, 20, 100, 30, 60, 50, 110, 100, 70};
int keyint = 110;
SenlineSearch(numeros, numeros.Length, keyint);

string[] nomes = {"Ana", "Bia", "Carlos", "Daniel", "Eva"};
string keystr = "Carlos";
SenlineSearch(nomes, nomes.Length, keystr);

static void SenlineSearch<T>(T[] arr, int n, T key)
{
    // Guardar o último elemento
    T last = arr[n - 1];

    // Coloca o elemento a ser buscado na ultima posição
    arr[n - 1] = key;
    int i = 0;

    // Busca até encontrar o valor
    while (!EqualityComparer<T>.Default.Equals(arr[i], key))
    {
        i++;

        // Restaura o ultimo elemento original
        arr[n - 1] = last;

        // verifica se aumentou dentro da faixa valida 

        if (i < n - 1 || EqualityComparer<T>.Default.Equals(arr[n - 1], key))
        {
            Console.WriteLine($"{key} esrtá presente no índice {i}");
        }
        else
        {
            Console.WriteLine("Elemento não encontrado");
        }
    }
}