class Ex20
{
    public void Executar(){
    
    /*5. Leia valores nas variáveis A e B, e efetue a troca dos valores de forma que o valor
    da variável A passe a ser o valor da variável B e o valor da variável B passe a ser o
    valor da variável A. Apresentar uma mensagem com o valor original de cada variável
    e outra com os valores trocados. */

    int numA;
    int numB;

    int ajudante =0;

    System.Console.WriteLine("digite um valor A: ");
    numA = int.Parse(Console.ReadLine());

    System.Console.WriteLine("digite outro valor B: ");
    numB = int.Parse(Console.ReadLine());

    System.Console.WriteLine($"valor A : {numA}");

    System.Console.WriteLine($"valor B : {numB}");

    System.Console.WriteLine("trocando valores :");

   ajudante = numA;

   numA= numB;

   numB = ajudante;
    

    System.Console.WriteLine($"valor A : {numA}");

    System.Console.WriteLine($"valor B : {numB}");
    }
}