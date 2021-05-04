using System;
using AllenamentoEfficace;
using System.IO;

namespace rova_metodi
{
    class Program
    {
        static void Main(string[] args)
        {
           double a= Gestione.LetturafileMediaGiornaliera();
            Console.WriteLine(a);
            Console.ReadLine();
            
        }
    }
}
