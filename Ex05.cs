class Ex05
{
    public  void Executar()
    {
        /*5. Elabore um programa que leia 5 números do teclado e os armazene em um vetor.
        Em seguida, leia um número n qualquer e apresente na tela a quantidade de vezes
        que o número n aparece no vetor.*/



        int[] valor = new int[5];


        Console.WriteLine("digite um sequencia de numeros: ");
        for (int i = 0; i < valor.Length; i++)
        {
            valor[i] = int.Parse(Console.ReadLine());
        }

        System.Console.WriteLine("digite um valor aleatorio: ");
        int valorAleatorio = int.Parse(Console.ReadLine());
        

        int vezesApresentado = 0;

        for (int i = 0; i < valor.Length; i++)
        {
            if (valor[i] == valorAleatorio)
            {
                vezesApresentado++;
            }
        }
        System.Console.WriteLine("O numero " + valorAleatorio + " aparece " + vezesApresentado + " vezes.");
    }
}