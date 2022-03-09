using System;

namespace Exercicio2Lista5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperaturaFahrenheit temperatura = new TemperaturaFahrenheit();

            temperatura.graus = 30;

            Console.WriteLine("Graus Celsius:{0} ", temperatura.ObterTemperaturaEmCelsius());
            Console.ReadLine();
        }
    }
}
public class TemperaturaFahrenheit
{
    public int graus;
    
    public double ObterTemperaturaEmCelsius()
    {
         double grauscelsius = (graus - 32) * 5 / 9;
        return grauscelsius;    
    }

}
