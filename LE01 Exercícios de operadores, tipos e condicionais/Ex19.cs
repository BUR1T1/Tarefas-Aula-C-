class Ex19
{
    public void Executar(){

     /*4. Escreva um algoritmo que leia dois números e ao final mostre a soma, subtração,
     multiplicação e a divisão dos números lidos. */

     double numA = 0;
     double numB = 0;

     System.Console.WriteLine("digite um valo: ");
     numA = double.Parse(Console.ReadLine());

     System.Console.WriteLine("digite outro valor: ");
     numB = double.Parse(Console.ReadLine());

     System.Console.WriteLine($"soma: {numA} + {numB} = {numA + numB}");
     System.Console.WriteLine($"subtração: {numA} - {numB} = {numA - numB}");
     System.Console.WriteLine($"multiplicação: {numA} x {numB} = {numA * numB}");
     System.Console.WriteLine($"divisão: {numA} / {numB} = {numA / numB}");


     
    }
}