using System;

class Program
{
    static void InsertionSort(int[] arr)
    {
        // Declaração das variáveis
        int chave, pos_verificada;

        // Percorre o array
        for (int i = 1; i < arr.Length; i++)
        {
            //  Atribui o valor da posição i a chave
            chave = arr[i];
            //  Atribui o valor da posição i - 1 a pos_verificada
            pos_verificada = i - 1;

            // Enquanto a posição verificada for maior ou igual a 0 e o valor da posição verificada for maior que a chave
            while (pos_verificada >= 0 && arr[pos_verificada] > chave)
            {
                //  Atribui o valor da posição verificada + 1 a posição verificada
                arr[pos_verificada + 1] = arr[pos_verificada];
                //  Decrementa a posição verificada
                pos_verificada--;
            }

            // Atribui o valor da chave a posição verificada + 1  
            arr[pos_verificada + 1] = chave;
        }
    }

    public static void Main(string[] args)
    {
        // Limpa a tela
        Console.Clear();

        // Array de inteiros
        int[] vetor = { 5, 3, 7, 6, 2, 3 };

        // Exibe o array antes da ordenação
        Console.WriteLine("ARRAY ANTES A ORDENAÇÃO POR INSERÇÃO:");
        // Percorre o array
        for (int i = 0; i < vetor.Length; i++)
        {
            // Exibe o valor do array na posição i
            Console.Write($"{vetor[i]} ");
        }

        // Chama o método de ordenação por inserção
        InsertionSort(vetor);

        // Pula uma linha
        Console.WriteLine("\n");

        // Exibe o array após a ordenação
        Console.WriteLine("\nARRAY APOS A ORDENAÇÃO POR INSERÇÃO:");

        // Percorre o array
        for (int i = 0; i < vetor.Length; i++)
        {
            // Exibe o valor do array na posição i
            Console.Write($"{vetor[i]} ");
        }

        // Pula uma linha
        Console.WriteLine("\n");
    }
}
