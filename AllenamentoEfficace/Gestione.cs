using System;
using System.Collections.Generic;
using System.IO;

namespace AllenamentoEfficace
{
    public class Gestione
    {
        public static string btmMaxMin(int eta)
        {
            int freqMax = 220 - eta;
            double freqMinAll = (freqMax * 70) / 100;
            double freqMaxAll = (freqMax * 90) / 100;
            return ($"{freqMaxAll} {freqMinAll}");
        }
        public static double LetturafileMediaGiornaliera()
        {
            double media;
            using (StreamReader sr = new StreamReader("fileBattiti.txt"))
            {
                string line;
                double somma = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    somma += double.Parse(line);
                }
                media = somma / 1440;
            }
            return Math.Round(media, 2);
        }


        public static bool BattitiRisposo(int battito)
        {
            Scrivifile();           
            using StreamReader sr = new StreamReader("battitiRiposo.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                if (int.Parse(line) == battito)
                    return true;
            }
            return false;
        }

        private static void Scrivifile()
        {
            StreamWriter w = new StreamWriter("battitiRiposo.txt");
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                w.WriteLine(r.Next(60, 101));
            }
            w.Flush();
            w.Close();
        }
        public static double Variabilità()
        {
            double somma1 = 0, somma2 = 0, media1 = 0, media2 = 0;
            StreamReader sr = new StreamReader("fileVariabilità.txt");
            List<double> battiti = new List<double>();
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                battiti.Add(int.Parse(line));
            }
            sr.Close();
            for (int i = 0; i < 720; i++)
            {
                somma1 += battiti[i];
            }
            for (int i = 720; i < 1440; i++)
            {
                somma2 += battiti[i];
            }
            media1 = somma1 / 720;
            media2 = somma2 / 720;
            return Math.Round(media2-media1, 3);
            
        }
    }
}
