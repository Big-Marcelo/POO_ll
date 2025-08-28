using System;
using BibliotecaConversao;

namespace TesteConversor
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversoes conversor = new Conversoes();

            double celsius = 25;
            double fahrenheit = conversor.CelsiusParaFahrenheit(celsius);
            Console.WriteLine($"{celsius}°C equivalem a {fahrenheit}°F.");

            double metros = 1500;
            double km = conversor.MetrosParaQuilometros(metros);
            Console.WriteLine($"{metros} metros equivalem a {km} quilômetros.");

            Console.WriteLine("\n--- Teste de Conversão de Moeda ---");
            Console.Write("Digite o valor em Dólar (USD): ");
            double valorDolar = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a taxa de câmbio para Real (BRL): ");
            double taxa = Convert.ToDouble(Console.ReadLine());

            double valorReal = conversor.ConverterMoeda(valorDolar, taxa);
            Console.WriteLine($"${valorDolar:F2} USD equivalem a R${valorReal:F2} BRL.");
        }
    }
}