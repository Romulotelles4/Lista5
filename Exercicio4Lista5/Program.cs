using System;

namespace Exercicio4Lista5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            ConsumoCombustivel consumo = new ConsumoCombustivel();

            consumo.QuilometragemInicial = 0;
            consumo.QuilometragemFinal = 20;
            consumo.Consumo = 4;

            Console.WriteLine("O consumo total foi de: {0}", consumo.ObterConsumo());
            Console.ReadLine();

        }
    }

    public class ConsumoCombustivel
    {
        public int QuilometragemInicial;
        public int QuilometragemFinal;
        public int Consumo;

        public double ObterConsumo()
        {
            double DistanciaPercorrida = QuilometragemFinal - QuilometragemInicial;
            double ConsumoPorKm = DistanciaPercorrida / Consumo;
            return ConsumoPorKm;
        }
    }
}
