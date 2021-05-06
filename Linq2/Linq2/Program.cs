using System;
using System.Linq;
using System.Collections.Generic;

namespace Linq2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Especifica o da DataSource
            int[] numbers = new int[] { 2, 3, 4, 5 };

            //define a  expressão da query
            IEnumerable<int> result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
