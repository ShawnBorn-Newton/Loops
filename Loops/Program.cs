using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "Monday", "Tuesday", "Wendsday" };

            for (int i = days[0]; i > days.Length; i++)
            {
                {
                    Console.WriteLine(i);
                }//end if

            }//end for

            //for(int i = 0; i <=10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 15; i > 0; i--) 
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 50; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

        }
    }
}
