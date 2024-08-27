class Ex18
{
    public void Executar(){

     /*3. Escreva um algoritmo que leia os valores de dois números inteiros distintos nas
     variáveis A e B e informe qual deles é o maior. Caso os números sejam iguais informar
     ao usuário que a sequência de números informados é inválida.*/

     int numA =0;

     int numB =0;

     System.Console.WriteLine("digite um valor : ");
     numA = int.Parse(Console.ReadLine());

     System.Console.WriteLine("digite outro valor: ");
     numB = int.Parse(Console.ReadLine());  

     if(numA > numB){System.Console.WriteLine($"O numero {numA} maior que {numB}.");}

     else if (numA < numB){System.Console.WriteLine($"O numero {numA} é menor que {numB}");}

     else {System.Console.WriteLine("Os valores são iguais....");}


    }
}