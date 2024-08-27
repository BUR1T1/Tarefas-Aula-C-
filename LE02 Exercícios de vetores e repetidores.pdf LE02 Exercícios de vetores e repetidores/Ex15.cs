class Ex15
{
    
    public void Executar(){
    /*15. Elabore um algoritmo que leia 5 números do teclado e preencha um vetor de 
    acordo com a seguinte regra: com exceção do 1º número, só é permitido armazenar 
    um número se ele for maior que o anterior. Ex.: se o primeiro valor lido for 5, o próximo 
    valor lido só poderá ser maior que 5.*/


    int[] vetor = new int[5];

        Console.WriteLine("Digite o 1º número:");
        vetor[0] = int.Parse(Console.ReadLine());

        for (int i = 1; i < vetor.Length; i++)
        {
            int num;
            do
            {
                Console.WriteLine($"Digite um número maior que {vetor[i - 1]}:");
                num = int.Parse(Console.ReadLine());

                if (num <= vetor[i - 1])
                {
                    Console.WriteLine("O número deve ser maior que o anterior. Tente novamente.");
                }

            } while (num <= vetor[i - 1]);

            vetor[i] = num;
        }

        Console.WriteLine("Vetor preenchido:");
        Console.WriteLine(string.Join(", ", vetor));
}
}