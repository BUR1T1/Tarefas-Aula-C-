class Ex16
{
     public void Executar(){

     /*1. Escreva um algoritmo que leia um número digitado pelo usuário e mostre a
     mensagem “Número maior do que 10!”, caso este número seja maior, ou “Número
     menor ou igual a 10!”, caso este número seja menor ou igual. */

     System.Console.WriteLine("digite um numero : ");
     int valor = int.Parse(Console.ReadLine());

     if(valor > 10)  {System.Console.WriteLine($"numero {valor}, maior que 10.");}

     else if(valor < 10) {System.Console.WriteLine($"numero {valor}, menor que 10.");}

     else {System.Console.WriteLine($"numero {valor},digitado é do mesmo valor que 10.");}


     }
}