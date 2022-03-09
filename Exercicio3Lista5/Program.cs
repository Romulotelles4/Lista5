using System;

namespace Exercicio3Lista5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VolumeCilindro cilindro = new VolumeCilindro();

            cilindro.raio = 9;
            cilindro.altura = 13;

            Console.WriteLine("O volume do cilinro é: {0}", cilindro.ObterVolume());
            Console.ReadLine();
        }
    }

    public class VolumeCilindro
    {
        
        public int raio;
        public int altura;

        public double ObterVolume()
        {
            double areab = (Math.PI * raio * raio);
            double volume = areab * altura;
            return volume;
        }
    }
}
