class Ex07
{
    public void Executar(){
        
        /*7. Faça um programa que leia dois vetores de 5 elementos cada e verifique se eles
        são iguais ou não. Para serem iguais, todos os elementos dos dois vetores devem
        coincidir.*/
        
        int[] valoresA = new int[5];

        int[] valoresB = new int[5];

        System.Console.WriteLine("digite a sequencia dos valores A : ");

        for (int i = 0; i < valoresA.Length; i++)
        {
            valoresA[i] = int.Parse(Console.ReadLine());   
        }

        System.Console.WriteLine("digite a sequencia dos valores B :");

        for (int i = 0; i < valoresB.Length; i++)
        {
            valoresB[i] = int.Parse(Console.ReadLine());
        }


        Boolean saoiguais =true;

        for (int i = 0; i < valoresA.Length; i++)
        {
           if (valoresA [i] != valoresB[i])
           {
             saoiguais = false;
            break;
           }
        }

        if (saoiguais)
        {
            System.Console.WriteLine("tudo ingual");
        }
        else
        {
            System.Console.WriteLine("nao ingual");
        }

    }
}