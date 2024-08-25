class Ex13{

    public void Executar(){

        /*13. Elabore um algoritmo que receba um número n e retorne um vetor com os n 
          primeiros termos da sequência de Fibonacci. Exemplo: n = 8, vetor = {1, 1, 2, 3, 5, 8, 13, 21}.*/

          int n = 0;

          System.Console.WriteLine("digite um numero: ");
          n = int.Parse(Console.ReadLine());

          int[] vetorA = new int[n];

          if(n >= 1) vetorA[0] = 1;
          if(n >= 2) vetorA[1] = 1;

          for (int i = 2; i < n; i++)
          {
            vetorA[i] = vetorA[i -1] + vetorA[i - 2];
          }

        System.Console.WriteLine("sequencia de fibonacci: ");
        for (int i = 0; i < n; i++)
        {
            System.Console.Write(vetorA[i] + ", ");
        }
    }
}