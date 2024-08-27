class Ex08
{
    public void Executar(){

    /*8. Dados dois vetores A e B de 5 elementos cada, criar um vetor C que representa a
    concatenação de A e B, ou seja, C contém os elementos de A seguidos dos elementos de B. */

    int[] vetorA = new int[] {1,3,4,2,4};

    int [] vetorB = new int[] {5,1,3,4,2,};

    int[] vetorC = new int[vetorA.Length + vetorB.Length];

    for (int i = 0; i < vetorA.Length; i++)
    {
        vetorC[i] = vetorA[i];
    }
    for (int i = 0; i < vetorB.Length; i++)
    {
         vetorC[vetorA.Length + i] = vetorB[i];
    }
    
        Console.WriteLine("Vetor A: " + string.Join(", ", vetorA));
        Console.WriteLine("Vetor B: " + string.Join(", ", vetorB));
        Console.WriteLine("Vetor C (concatenação): " + string.Join(", ", vetorC));
    
    }
}

/*O string.Join() em C# combina os elementos de uma coleção em uma única string,
 separando-os por um delimitador especificado, como ", ".
 Ele facilita a formatação e exibição de listas ou arrays sem precisar usar loops. 
Isso resulta em um código mais limpo e legível para concatenar elementos.*/