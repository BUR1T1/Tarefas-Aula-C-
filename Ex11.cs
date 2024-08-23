class Ex11
{
    public void Executar(){

    /*11. Elabore um algoritmo que calcule o produto escalar entre dois vetores de inteiros 
    de tamanho igual a 5. Exemplo: {0, 2, 4, 6, 8}, {1, 3, 5, 7, 9} = 0*1 + 2*3 + 4*5 + 6*7 + 8*9 = 140 */

    int[] vetorA = new int[]{0, 2, 4, 6, 8};

    int[] vetorB = new int[]{1, 3, 5, 7, 9};

    int[] vetorRES = new int[vetorA.Length];

    int soma= 0;

    for (int i = 0; i < vetorA.Length; i++)
    {
        vetorRES[i] = vetorA[i] * vetorB[i];
    }

    for (int i = 0; i < vetorA.Length; i++)
    {
        soma+=vetorRES[i];
    }

    Console.WriteLine("Vetor A: " + string.Join(", ", vetorA));
    System.Console.WriteLine("");
    Console.WriteLine("Vetor B: " + string.Join(", ", vetorB));
    System.Console.WriteLine("");
    Console.WriteLine("Multiplo de vetores A e vetores B : " + string.Join(", ", vetorRES));
    System.Console.WriteLine();
    Console.WriteLine("soma do vetorRES: " + soma);


    }
}