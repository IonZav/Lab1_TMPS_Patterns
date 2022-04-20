using System;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton.GetInstance().Name = "Ana";
            Console.WriteLine(Singleton.GetInstance().Name);
            Console.ReadLine();
        }
    }
}