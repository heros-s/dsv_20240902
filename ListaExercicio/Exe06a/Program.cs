using System;

class Program
{
    static void Main()
    {
        // Define o tamanho do vetor
        const int tamanho = 1000;
        int[] vetor = new int[tamanho];
        Random random = new Random();

        // Preenche o vetor com valores aleatórios
        for (int i = 0; i < tamanho; i++)
        {
            vetor[i] = random.Next(1, 10001); // Gera números aleatórios entre 1 e 10000
        }

        // Ordena o vetor usando o algoritmo Bubble Sort
        BubbleSort(vetor);

        // Exibe os primeiros e últimos valores do vetor ordenado
        Console.WriteLine("Os primeiros 10 valores do vetor ordenado:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(vetor[i]);
        }

        Console.WriteLine("\nOs últimos 10 valores do vetor ordenado:");
        for (int i = tamanho - 10; i < tamanho; i++)
        {
            Console.WriteLine(vetor[i]);
        }
    }

    // Função para ordenar o vetor usando Bubble Sort
    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        bool trocado;

        for (int i = 0; i < n - 1; i++)
        {
            trocado = false;

            // Percorre o array da esquerda para a direita
            for (int j = 0; j < n - i - 1; j++)
            {
                // Se o elemento atual é maior que o próximo, troca
                if (array[j] > array[j + 1])
                {
                    // Troca os elementos
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;

                    trocado = true;
                }
            }

            // Se nenhum elemento foi trocado, o vetor já está ordenado
            if (!trocado)
            {
                break;
            }
        }
    }
}
