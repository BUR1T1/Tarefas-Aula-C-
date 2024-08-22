 class  Ex02(){

    public void Executar(){

            /*2. Escreva um algoritmo que leia em um vetor uma sequência finita de números
            digitados pelo usuário e, logo após, mostre o número de cada posição do vetor e se
            ele é positivo, negativo ou zero*/

              Console.Write("Qual a quantidade de números você pretende escrever? ");
            int quantidade = int.Parse(Console.ReadLine());
            int[] valores = new int[quantidade];

            for (int i = 0; i < valores.Length; i++)
            {
                Console.Write($"Digite o valor {i + 1}: ");
                valores[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nAnálise dos valores:");
            for (int i = 0; i < valores.Length; i++)
            {
                string tipo = valores[i] > 0 ? "positivo" :
                              valores[i] < 0 ? "negativo" : "zero";

                Console.WriteLine($"Valor na posição {i}: {valores[i]} é {tipo}");
            }


    }
}