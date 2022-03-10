using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_Cycle_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int number = random.Next(0, 101);
            int sum = 0;
            int multipleOfFive = 5;

            for (int i = 0; i < number; i++)
            {
                if(i % multipleOfFive == 0)
                {
                    sum += i;
                }
            }

            sum += number;

            Console.WriteLine(sum);
        }
    }
}
