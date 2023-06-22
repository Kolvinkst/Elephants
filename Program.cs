using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elephants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elephant lloyd = new Elephant() {Name = "Lloyd", EarSize = 40};
            Elephant lucinda = new Elephant() {Name = "Lucinda", EarSize = 33};

            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");
            while (true)
            {
                char input = Console.ReadKey(true).KeyChar;
                Console.WriteLine("You pressed " + input);
                if (input == '1')
                {
                    Console.WriteLine("Calling lloyd.WhoAmI()");
                    lloyd.WhoAmi();
                }
                else if (input == '2')
                {
                    Console.WriteLine("Calling lucinda.WhoAmI()");
                    lucinda.WhoAmi();
                }
                else if (input == '3')
                {
                    Console.WriteLine("References have been swapped");
                    Elephant holder;
                    holder = lloyd;
                    lloyd = lucinda;
                    lucinda = holder;
                    Console.WriteLine("References have been swapped");
                }
                else return;
                Console.WriteLine();
            }
        }
    }
}
