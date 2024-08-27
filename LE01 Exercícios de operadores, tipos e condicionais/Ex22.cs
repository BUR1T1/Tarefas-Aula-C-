class Ex22
{
    public void Executar(){

     /*7. Escreva um algoritmo que leia um número e diga, através de uma mensagem, se
     este número está no intervalo entre 100 e 200. Caso o número esteja fora do intervalo
     o usuário também deverá ser informado. */

     int num = 0;

     System.Console.WriteLine("digite um valor: ");
     num = int.Parse(Console.ReadLine());

     if(100 <= num && num <= 200){System.Console.WriteLine($"o numero se encaixa no intervalo entre 100 < '{num}' > 200");}

     else{System.Console.WriteLine($"{num} valor fora do intervalo.");}
    }
}