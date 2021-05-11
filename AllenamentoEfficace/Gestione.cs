using System;
using System.IO;

namespace AllenamentoEfficace
{
    public class Gestione
    {
        public static readonly string DIRECTORY = Directory.GetCurrentDirectory();
        public const string FILE = @"\datiBattiti.txt";
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
            using (StreamWriter w = new StreamWriter(DIRECTORY + FILE))
            {
                Random r = new Random();
                for (int i = 0; i < 1440; i++)
                {
                    w.WriteLine(r.Next(60, 80));
                }
                w.Flush();
            }
            using (StreamReader sr = new StreamReader(DIRECTORY + FILE))
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
    }
}
