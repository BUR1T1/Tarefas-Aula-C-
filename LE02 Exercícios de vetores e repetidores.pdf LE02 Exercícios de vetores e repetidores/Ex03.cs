class Ex03(){

public void Executar(){

/*3. Faça um programa que leia em um vetor uma sequência finita de números digitados
pelo usuário. Crie um segundo vetor que armazene o dobro de cada número do
primeiro vetor e depois apresente os valores deste vetor.*/

    Console.Write("Qual a quantidade de valores ? ");
    int quant = int.Parse(Console.ReadLine());
    int[] valores = new int[quant];

    for (int i = 0; i < valores.Length; i++)
    {
        Console.Write("Digite o valor " + (i + 1) + ": ");
        valores[i] = int.Parse(Console.ReadLine());
    }

    int[] multiplodosvalores = new int[quant];
    for (int i = 0; i < valores.Length; i++)
    {  
        multiplodosvalores[i] = valores[i] * 2;
    }


    Console.WriteLine("resposta do calculo dos valores: ");
    for (int i = 0; i < valores.Length; i++)
    {
        Console.WriteLine("calculo " + ( i + 1 ) + " : " + valores[i] + " x " + " 2 " + " = "+ multiplodosvalores[i] );
    }

    }


}