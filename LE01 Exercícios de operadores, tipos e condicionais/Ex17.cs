class Ex17
{
    public void Executar(){

    /*2. Escreva um algoritmo que leia dois números digitados pelo usuário e exiba o
    resultado da sua soma.*/

    double numA =0;
    double numB =0;

    double res= 0;

    System.Console.WriteLine("digite um valor para ser lido: ");
    numA = double.Parse(Console.ReadLine());

    System.Console.WriteLine("digite outro valor: ");
    numB = double.Parse(Console.ReadLine());    

    res = numA + numB;

    System.Console.WriteLine($"resultado do calculo: {numA} + {numB} ={res}");

    }
}