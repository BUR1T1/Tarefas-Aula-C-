class Ex10
{
        public void Executar(){

        /*10. Crie um programa que leia um vetor A de 5 posições e, ao final da leitura, copie 
        os elementos de A em B de forma invertida. Ou seja, o primeiro elemento de A é o último 
        elemento de B, o segundo elemento de A é o penúltimo elemento de B, e assim por diante.*/

        int[] vetorA = new int[]{2,4,2,5,3};
        int[] vetorB = new int[vetorA.Length];

        for (int i = 0; i < vetorA.Length; i++)
        {
            vetorB[vetorA.Length -1 - i] = vetorA[i];
        }
         
        Console.WriteLine("Vetor A: " + string.Join(", ", vetorA));
        System.Console.WriteLine("");
        Console.WriteLine("Vetor B: " + string.Join(", ", vetorB));
    }

}