using System;

namespace Exercicio5Lista5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VolumeEsfera volume = new VolumeEsfera();

            volume.raio = 5;

            Console.WriteLine("O volume da esfera é:{0}", volume.ObterVolume());
            Console.ReadLine();


        }
    }

    public class VolumeEsfera
    {
        public int raio;

        public double ObterVolume()
        {
            double volume = 1.33 * Math.PI * (raio * raio * raio);
            return volume;
        }
    }
}
