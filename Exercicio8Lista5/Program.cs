using System;

namespace Exercicio8Lista5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaixaRetangular caixa = new CaixaRetangular();

            caixa.altura = 10;
            caixa.largura = 10;
            caixa.comprimento = 10;

            Console.WriteLine("O volume da caixa é: {0} ", caixa.ObterVolume());
            Console.ReadLine();
        }
    }

    public class CaixaRetangular
    {
        public int altura;
        public int largura;
        public int comprimento;

        public double ObterVolume()
        {
            double volume = altura * largura * comprimento;
            return volume;
        }

    }
}
