using System.Collections.Generic;

namespace Builder_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MailMessage message = MailMessage.With()
                .From("anisya.grytskan@gmail.com")
                .To("emery.swarovsky@gmail.co" +
                "m")
                .Subject("Citate")
                .Body("Care este citatul tau preferat")
                .Build();

            Console.ReadLine();

        }
    }
}