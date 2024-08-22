using System;

namespace AulaCSharp
{
     class Ex01
    {
        public void Exercicio01()
        {
            int[] valores = new int[5];
        int soma = 0;

        // Ler os valores
        for (int i = 0; i < valores.Length; i++)
        {
            Console.Write($"Digite o valor {i + 1}: ");
            valores[i] = int.Parse(Console.ReadLine());
            soma += valores[i];
        }

        // Calcular a média
        double media = soma / (double)valores.Length;
        Console.WriteLine($"\nMédia dos valores: {media}");

        // Exibir os valores menores, iguais e maiores que a média
        Console.WriteLine("\nValores menores que a média:");
        foreach (int valor in valores)
        {
            if (valor < media)
            {
                Console.Write(valor + " ");
            }
        }

        Console.WriteLine("\nValores iguais à média:");
        foreach (int valor in valores)
        {
            if (valor == media)
            {
                Console.Write(valor + " ");
            }
        }

        Console.WriteLine("\nValores maiores que a média:");
        foreach (int valor in valores)
        {
            if (valor > media)
            {
                Console.Write(valor + " ");
            }
        }
    }

    }
}
