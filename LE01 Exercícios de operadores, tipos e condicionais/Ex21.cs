class Ex21
{
    public void Executar(){
     /*6. Ler uma temperatura em graus Celsius e apresentá-la convertida em graus
    Fahrenheit. A fórmula de conversão é:  F = (9 * C + 160) / 5.   */

    double Fahrenheit;

    double Celsius;

    System.Console.WriteLine("digite o valor em graus celcius: ");
    Celsius = double.Parse(Console.ReadLine());

    Fahrenheit = ((9 * Celsius) + 160) / 5;

    System.Console.WriteLine($"conversõa de {Celsius} graus Celsius para Fahrenheit = {Fahrenheit} ");
    }
}