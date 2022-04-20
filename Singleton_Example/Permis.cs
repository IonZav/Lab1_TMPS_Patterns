using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Implementation
{
    class Permis
    {
        private static Permis _instance = null;
        private static object locker = new object();

        public string Categorie { get; set; }
        public string Nume { get; set; }
        public string NrInregistrare { get; set; }



        private Permis()
        {

        }

        public static Permis GetInstance()
        {
            if (_instance == null)
            {
                lock (locker)
                {
                    if (_instance == null)
                    {
                        _instance = new Permis();
                    }
                }
            }
            return _instance;
        }

        public void EliberatDe(string originCountry)
        {
            Console.WriteLine($"Permis eliberat de catre {originCountry}");
        }
    }
}
