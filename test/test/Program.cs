using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string[] mois = new string[]
        {
            "Janvier", "Février", "Mars", "Avril", "Mai", "Juin",
            "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre"
        };

        string[] moisAvecRouge = new string[12];
        for (int i = 0; i < 12; i++)
        {
            moisAvecRouge[i] = mois[i].Contains("r") ? $"\u001b[31m{mois[i]}\u001b[0m" : mois[i];
        }

        Console.WriteLine("Numéro des mois :");
        for (int i = 0; i < 12; i++)
        {
            Console.WriteLine($"{i + 1} - {moisAvecRouge[i]}");
        }
        Console.Read();
    }
}
