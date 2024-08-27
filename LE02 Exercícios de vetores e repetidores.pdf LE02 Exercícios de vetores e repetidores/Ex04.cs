class Ex04{

    public void Executar(){

    /*4. Elabore um programa que leia um vetor de 5 números digitados pelo usuário e uma
    variável de um número n qualquer, depois mostre na tela o índice dos elementos que
    são inferiores a n.*/

    int[] valores = new int[5];

    int valorqualque = 0;

    System.Console.WriteLine("digite algum valor entre de sua preferencia: ");
    valorqualque = int.Parse(Console.ReadLine());

    System.Console.WriteLine("digite uma sequencia de 5 valores");
    for (int i = 0; i < valores.Length; i++)
    {
        valores[i] = int.Parse(Console.ReadLine());
    }

     Console.WriteLine("Índices dos elementos menores que " + valorqualque + ":");
        for (int i = 0; i < valores.Length; i++)
        {
            if (valores[i] < valorqualque)
            {
                Console.WriteLine("Índice " + (i+1) + " (Valor: " + valores[i] + ")");
            }
        }
    }
}