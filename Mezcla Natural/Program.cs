using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> elementos = new List<int> { 3, 4, 1, 9, 2 };
        Console.WriteLine("Orden original: " + string.Join(" ", elementos));

        NaturalMergeSort(elementos);
        Console.ReadKey();
    }

    static void NaturalMergeSort(List<int> arr)
    {
        List<int> resultadoParcial = null;

        while (true)
        {
            List<int> aux1 = new List<int>();
            List<int> aux2 = new List<int>();
            List<int> merged = new List<int>();

            int i = 0;
            while (i < arr.Count - 1)
            {
                if (arr[i] > arr[i + 1])
                {
                    break;
                }
                i++;
            }

            if (i == arr.Count - 1)
            {
                resultadoParcial = new List<int>(arr);
                break;
            }

            aux1 = arr.GetRange(0, i + 1);
            aux2 = arr.GetRange(i + 1, arr.Count - i - 1);

            Console.WriteLine("\nAuxiliar 1: " + string.Join(" ", aux1));
            Console.WriteLine("Auxiliar 2: " + string.Join(" ", aux2));

            while (aux1.Count > 0 && aux2.Count > 0)
            {
                if (aux1[0] <= aux2[0])
                {
                    merged.Add(aux1[0]);
                    aux1.RemoveAt(0);
                }
                else
                {
                    merged.Add(aux2[0]);
                    aux2.RemoveAt(0);
                }
            }

            merged.AddRange(aux1);
            merged.AddRange(aux2);
            arr = new List<int>(merged);

            resultadoParcial = new List<int>(arr);

            Console.WriteLine("Orden parcial: " + string.Join(" ", arr));
        }

        // Imprimir el resultado del último paso parcial como Orden final
        Console.WriteLine("\nOrden final: " + string.Join(" ", resultadoParcial));
    }
}
