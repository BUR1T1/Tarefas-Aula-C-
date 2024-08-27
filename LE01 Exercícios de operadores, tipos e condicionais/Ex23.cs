class Ex23
{
    public void Executor(){

        /*8. Escreva um algoritmo que leia um número e mostre uma mensagem caso este
        número seja maior ou igual a 50, outra se ele for menor que 50. */

        int valor = 0;

        System.Console.WriteLine("gigite um valor: ");
        valor = int.Parse(Console.ReadLine());

        if(valor > 50){System.Console.WriteLine($"valor {valor} maior que 50.");}
        else if(valor < 50){System.Console.WriteLine($"valor {valor} menor que 50.");}
        else{System.Console.WriteLine($"{valor} possui o mesmo valor 50.");}
        
    }
}