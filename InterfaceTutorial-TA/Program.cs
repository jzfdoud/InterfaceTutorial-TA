using System;

namespace InterfaceTutorial_TA
{
    class Program
    {
        static void Main(string[] args)
        {

            var gs = new GermanShephard();
            gs.SetName("Sargent");
            var pg = new Pug();
            pg.SetName("Walter") ;
            var bh = new BassetHound();
            bh.SetName("Charlie");
            var dp = new DogParrot();
            dp.SetName("Polly");

            var dogs = new IBarkable[]
            {
                gs,pg,bh,dp
            };

            foreach(var dog in dogs)
            {
                //Console.WriteLine($"The dog says {dog.Bark()}");
                Console.WriteLine($" The dog {dog.GetName()} says {dog.Bark()}");
            }
        }
    }
}
