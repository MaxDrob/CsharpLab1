using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divider
{
    class DivideIt
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Input 1st integer:");
                string temp = Console.ReadLine();
                int i = Int32.Parse(temp);

                Console.WriteLine("Input 2nd integer:");
                temp = Console.ReadLine();
                int j = Int32.Parse(temp);

                Console.WriteLine("Your digits: {0}, {1}", i, j);

                int m = i / j;
                Console.WriteLine("The result of dividing {0} / {1} = {2}", i, j, m);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception was thrown: {0}", e);
            }
            Console.Read();
        }
    }
}
