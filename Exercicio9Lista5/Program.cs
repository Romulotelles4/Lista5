using System;

namespace Exercicio10Lista5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaPonderada media = new MediaPonderada();
            media.Notas[0] = 4;
            media.Notas[1] = 5;
            media.Notas[2] = 6;
            
            media.Pesos[0] = 5;
            media.Pesos[1] = 2;
            media.Pesos[2] = 3;

            Console.WriteLine("A média ponderada é:{0}", media.ObterMedia());
            Console.ReadLine();
        }
    }
    public class MediaPonderada
    {
        public int[] Notas = new int[3];
        public int[] Pesos = new int[3];

        public double ObterMedia()
        {
            double MediaPonderada = ((Notas[0] * Pesos[0]) + (Notas[1] * Pesos[1]) + (Notas[2] * Pesos[2])) / (Pesos[0] + Pesos[1] + Pesos[2]);
            return MediaPonderada;
        }
    }
}
