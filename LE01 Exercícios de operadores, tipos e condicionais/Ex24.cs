class Ex24
{
    public void Executar(){

    /*9. Leia dois números nas variáveis A e B e identifique se os valores são iguais ou
      diferentes. Caso eles sejam iguais imprima uma mensagem dizendo que são iguais.
      Caso sejam diferentes, informe que são diferentes e qual número é o maior. */

      int A =0;
      int B =0;

      System.Console.WriteLine("digite o valor de A: ");
      A = int.Parse(Console.ReadLine());

      System.Console.WriteLine("digite o valor de B: ");
      B = int.Parse(Console.ReadLine());

      if(A == B) {System.Console.WriteLine("os valores são iguais");}
      else {System.Console.WriteLine($"valor {A} é diferente do valor {B}");}

    }
}