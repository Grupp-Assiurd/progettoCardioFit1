using System;
using AllenamentoEfficace;
using System.IO;
using System.Collections.Generic;

namespace rova_metodi
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (StreamWriter w = new StreamWriter("battitiGiornalieri.txt"))
            //{
            //    Random r = new Random();
            //    int a;
            //    int somma = 0;
            //    double media = 0;
            //    for (int i = 0; i < 1440; i++)
            //    {
            //        a = r.Next(60, 80);
            //        somma += a;
            //        w.WriteLine(a);
            //    }
            //    media = somma / 1440;
            //    Console.Write(media);
            //    w.Flush();
            //}
            ScritturaSecondoFileVBC();

        }
        private static void ScritturaSecondoFileVBC()
        {
            StreamWriter sw = new StreamWriter("fileVariabilità.txt");
            Random r = new Random();
            int a;
            double somma1 = 0,somma2=0;
            double media1 = 0, media2 = 0;
            for(int i = 0; i < 1440; i++)
            {
                a = r.Next(60, 80);
                sw.WriteLine(a);
            }
            sw.Flush();
            sw.Close();
            StreamReader sr = new StreamReader("fileVariabilità.txt");
            List<double> battiti = new List<double>();
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                battiti.Add(int.Parse(line));
            }
            sr.Close();
            for(int i = 0; i < 720; i++)
            {
                somma1 += battiti[i];
            }
            for(int i=720; i < 1440; i++)
            {
                somma2 += battiti[i];
            }
            media1 = somma1 / 720;
            media2 = somma2 / 720;
            Console.WriteLine(Math.Round(media1,3));
            Console.WriteLine(Math.Round(media2,3));

            
        }
    }
}
