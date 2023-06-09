using App;
using POO;
using System;

namespace MainApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture V1 = new("bleu", "toyota");
            Garage g1 = new("konki", "bependa");

            V1.GetText();
            Console.WriteLine($"mon garage s appelle {g1.name} et c est situer a {g1.localisation} et a l interieur il ya " + g1.GetText);
        }
    }
}