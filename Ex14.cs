class Ex14{

    public void Executar(){

/*14. Faça um programa que leia um vetor de 5 elementos e, após a leitura, posicione 
o maior elemento na última posição do vetor. Nenhum número do vetor pode ser 
apagado ou duplicado. Apresente o vetor atualizado na tela.*/


    int[] vetor = new int[]{4,5,8,6,2,3,1};

    Console.WriteLine("Vetor Original: " + string.Join(", ", vetor));

    int maiorNumero = 0;
    for (int i = 0; i < vetor.Length; i++)
    {
        if (vetor[i] > vetor[maiorNumero])
        {
            maiorNumero = i;
        }
    }
    int temporario = vetor[maiorNumero];
    vetor[maiorNumero] = vetor[vetor.Length - 1];
    vetor[vetor.Length - 1] = temporario;


    Console.WriteLine("Vetor Atualizado: " + string.Join(", ", vetor));

    }
}