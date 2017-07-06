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
            //for loops
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

            ////way 1
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int product = numbers[0];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    product = product * numbers[i];
            //}
            //Console.WriteLine(product);
            //int product = 1;
            //    for(int i = 1; i <= 10; i++)
            //{
            //    product = product * i;
            //}
            //Console.WriteLine(product);

            //foreach loops
            //string[] theMonths = { "Jan", "Dog", "Mar", "Apr", "May", "Jun" };
            //foreach(string month in theMonths)
            //{
            //    Console.WriteLine(month);
            //}
            string[] musicians = { "Tim", "Jim", "Him", "Nim" };
            foreach(string band in musicians)
            {
                Console.WriteLine(band);
            }

        }
    }
}
