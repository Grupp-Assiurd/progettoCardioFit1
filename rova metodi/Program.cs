using System;
using AllenamentoEfficace;
using System.IO;

namespace rova_metodi
{
    class Program
    {
        static void Main(string[] args)
        {       
            using (StreamWriter w = new StreamWriter("battitiGiornalieri.txt"))
            {
                Random r = new Random();
                int a;
                int somma = 0;
                double media = 0;
                for (int i = 0; i < 1440; i++)
                {
                    a = r.Next(60, 80);
                    somma += a;
                    w.WriteLine(a);
                }
                media = somma / 1440;
                Console.Write(media);
                w.Flush();
            }

        }
    }
}
