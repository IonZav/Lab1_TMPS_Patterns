using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    class Singleton
    {
        private static Singleton _instance = null;
        private static object locker = new object();

        public string Name { get; set; }

        private Singleton()
        {
            Console.WriteLine("Singleton Created");
        }

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                lock (locker)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
        }
    }
}
