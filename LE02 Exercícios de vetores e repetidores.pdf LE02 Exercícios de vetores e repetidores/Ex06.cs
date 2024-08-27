using System.Reflection;

class Ex06
{
    public void Executar(){

        /*6. Elabore um programa que leia um vetor com 5 notas de um aluno e um outro vetor
        com 5 pesos e calcule a média ponderada do aluno.*/

        float peso1 = 10.0f;
        float peso2 = 10.0f;
        float peso3 = 10.0f;

        float mediaPonderada;

        System.Console.WriteLine("digite o valor da prova A , B , C :");
        System.Console.Write("nota da prova A : ");
        float notaA = float.Parse(Console.ReadLine());

        System.Console.Write("nota da prova B : ");
        float notaB = float.Parse(Console.ReadLine());

        System.Console.Write("nota da prova C : ");
        float notaC = float.Parse(Console.ReadLine());

        mediaPonderada = ((peso1 * notaA) + (peso2 * notaB) + (peso3 * notaC))  / (peso1 + peso2 + peso3);

        System.Console.WriteLine($"media Ponderada : {mediaPonderada:f2}");

    }
}