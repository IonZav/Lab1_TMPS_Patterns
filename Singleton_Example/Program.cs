using System;
using System.Threading.Tasks;

namespace Singleton_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Permis.GetInstance().Nume = "Pascari Vadim";
            Permis.GetInstance().Categorie = "B1";
            Permis.GetInstance().NrInregistrare = "0124909232";

            Console.WriteLine($"Permisul de conducere categoria {Permis.GetInstance().Categorie}" +
                $" pe numele {Permis.GetInstance().Nume} cu numarul de inregistrare {Permis.GetInstance().NrInregistrare}");

            Permis.GetInstance().EliberatDe("Republica Moldova");

            Console.ReadLine();
        }
    }
}