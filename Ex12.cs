class Ex12
{
    public void Executar()
    {
        /*12. Elabore um programa que leia um vetor de 12 elementos apresente na tela o 
        produto dos elementos pares positivos (desconsiderar o zero). Exemplo: {0, 5, 8, 1, -
        6, 4, -7, 9, 10, -14, 3, 12} = 8 * 4 * 10 * 12 = 3840. */

        int[] vetorBASE = new int[] { 5, -8, 4, 6, 8, 5, 1, 4, -6, 9, 8, 2 };

        int produto = 1;
        bool encontrouParPositivo = false; 

        for (int i = 0; i < vetorBASE.Length; i++)
        {
            if (vetorBASE[i] > 0 && vetorBASE[i] % 2 == 0)
            {
                produto *= vetorBASE[i];
                encontrouParPositivo = true; 
            }
        }

       
        if (!encontrouParPositivo)
        {
            produto = 0;
        }

        Console.WriteLine("Vetor A: " + string.Join(", ", vetorBASE));
        System.Console.WriteLine();
        Console.WriteLine("reposta do calculo: " + produto);
    }
  }
