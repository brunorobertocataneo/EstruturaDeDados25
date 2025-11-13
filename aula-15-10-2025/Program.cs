int[] integersValues = { 11, -42, 0, 1, 90, 68, 6, -9 };

aula_15_10_2025.SelectionSort.Sort(integersValues);

Console.WriteLine("Array de inte:");
Console.WriteLine(string.Join(", ", integersValues));

Console.WriteLine("**************************");

Console.WriteLine("Array de strings:");

string[] stringValues = { "Banana", "Abacaxi", "Laranja", "Uva", "Goiaba", "Manga" };

aula_15_10_2025.SelectionSort.Sort(stringValues);

Console.WriteLine(string.Join(", ", stringValues));


// O QuickSort é mais rápido que o SelectionSort, mas o SelectionSort é mais fácil de implementar e entender.
// O QuickSort é mais eficiente para grandes conjuntos de dados, enquanto o SelectionSort pode ser mais adequado para conjuntos de dados menores ou quase ordenados.
// O QuickSort é um algoritmo de ordenação baseado na técnica de divisão e conquista, enquanto o SelectionSort é um algoritmo de ordenação por seleção direta.
