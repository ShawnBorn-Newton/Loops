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
            //string days = "Monday Tuesday Wendsday";
            //string[] theDay = days.Split();
            //for (int i = 0; i < theDay.Length; i++)
            //    Console.WriteLine(theDay[i]);


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
            //string greeting = "My name is Little Bill";
            ////.Split splits a string into an array in the white space. 
            //string[] wordsInGreeting = greeting.Split();

            //for (int i = 0; i < wordsInGreeting.Length; i++) 
            //Console.WriteLine(wordsInGreeting[i]);

            //string firstLine = "Once upon a time";
            //string[] storyWords = firstLine.Split();
            //Array.Reverse(storyWords);
            //for (int i = 0; i < storyWords.Length; i++)
            //    Console.WriteLine(storyWords[i]);
            

            for (int i = 1; i < 10; i++)
                Console.WriteLine(i * i + i * i);
        }
    }
}
