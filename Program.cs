using System;

class Program
{
    static void insertionSort(int[] arr)
    {
        int num, pos_verificada;

        for (int pos = 1; pos < arr.Length; pos++)
        {
            num = arr[pos];
            pos_verificada = pos - 1;

            // Move os elementos do arr[0..i-1] que são maiores que num
            // para uma posição à frente de sua posição atual
            while (pos_verificada >= 0 && num < arr[pos_verificada])
            {
                arr[pos_verificada + 1] = arr[pos_verificada];
                pos_verificada--;
            }

            arr[pos_verificada + 1] = num;
        }
    }

    public static void Main(string[] args)
    {
        Console.Clear();

        int[] vetor = { 5, 3, 7, 6, 2 };

        Console.WriteLine("ARRAY ANTES A ORDENAÇÃO POR INSERÇÃO:");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"{vetor[i]} ");
        }

        insertionSort(vetor);
        Console.WriteLine("\n");

        Console.WriteLine("\nARRAY APOS A ORDENAÇÃO POR INSERÇÃO:");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"{vetor[i]} ");
        }

        Console.WriteLine("\n");
    }
}
