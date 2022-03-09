using System;

namespace Exercicio6Lista5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConverterCelsius converter = new ConverterCelsius();

            converter.GrausCelsius = 10;

            Console.WriteLine("O valor em Fahrenheit é:{0}", converter.ObterValor());
            Console.ReadLine();
        }
    }

    public class ConverterCelsius
    {
        public int GrausCelsius;

        public double ObterValor()
        {
            double GrausFahrenheit = (GrausCelsius * 1.8) + 32;
            return GrausFahrenheit;
        }
    }
}
