using System;

namespace Exercicio7Lista5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalcularSalario salario = new CalcularSalario();

            salario.SalarioBase = 1000;
            salario.TotalVendas = 90;
            salario.Porcentagem = 25;

            Console.WriteLine("O slario total é de:{0}", salario.ObterCalculo());
            Console.ReadLine();
        }
    }

    public class CalcularSalario
    {
        public int SalarioBase;
        public int TotalVendas;
        public int Porcentagem;

        public double ObterCalculo()
        {
            double SalarioTotal = SalarioBase + (TotalVendas * Porcentagem / 100);
            return SalarioTotal;
        }
    }
}
