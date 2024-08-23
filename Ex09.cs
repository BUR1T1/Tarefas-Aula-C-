class Ex09
{
    public void Executar(){

/*9. Elabore um programa que leia os vetores A e B de 5 elementos e 
gere um vetor C de acordo com as seguintes regras:

a. Os elementos das posições pares de C são os elementos das posições pares de A;
b. Os elementos das posições ímpares de C são os elementos das posições ímpares de B;

*/
    int[] vetorA = new int[]{1,3,4,3,7};

    int[] vetorB = new int[]{1,4,7,8,2};

    int[] vetorC = new int[vetorA.Length];

    for (int i = 0; i < vetorA.Length; i++)
    {
       if (i %  2 == 0)
       {
        vetorC[i] = vetorA[i];
       }
       else
       {
        vetorC[i] = vetorB[i];
       }
    }
    

        Console.WriteLine("Vetor A: " + string.Join(", ", vetorA));
        Console.WriteLine("Vetor B: " + string.Join(", ", vetorB));
        Console.WriteLine("Vetor C: " + string.Join(", ", vetorC));
    }
}