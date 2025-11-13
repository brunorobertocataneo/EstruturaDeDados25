using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_15_10_2025
{
    public static class SelectionSort
    {
        public static void Sort<T>(T[] array) where T : IComparable<T> // Usado para fazer a comparação entre os elementos de números e textos
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                T minValue = array[i];

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(minValue) < 0)
                    {
                        minIndex = j;
                        minValue = array[j];
                    }
                }
                Swap(array, i, minIndex);
            }
        }
        public static void Swap<T>(T[] array, int first, int second)
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
}