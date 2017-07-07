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
            //FOR LOOPS
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

            //FOREACH LOOP
            //string[] theMonths = { "Jan", "Dog", "Mar", "Apr", "May", "Jun" };
            //foreach(string month in theMonths)
            //{
            //    Console.WriteLine(month);
            //}
            //string[] musicians = { "Tim", "Jim", "Him", "Nim" };
            //foreach(string band in musicians)
            //{
            //    Console.WriteLine(band);
            //}

            //WHILE LOOPS

            //Console.WriteLine("What is your first name?");
            //string firstName = Console.ReadLine();
            //while(firstName.ToUpper() == "SHAWN")
            //{
            //    Console.WriteLine("Why me");
            //    break;
            //}

            //Console.WriteLine("Do you want to play the game? YES/NO");
            //string playAgain = Console.ReadLine();
            //while(playAgain.ToUpper() == "YES")
            //{
            //    Console.WriteLine("It's a rematch!\nDo you want to play again? YES/NO");
            //    playAgain = Console.ReadLine();
            //}

            //DOWHILE LOOPS

            //string playAgain;
            //do
            //{
            //    Console.WriteLine("Welcome to game!\n" + 
            //        "Great Game!!\nDo you want to play again? YES/NO");
            //    playAgain = Console.ReadLine();
            //}
            //while (playAgain.ToUpper() == "YES");

            //string classAdd;
            //string grade;
            //string doAgain;
            //do
            //{
            //    Console.WriteLine("What class would you like to add to your GPA?");
            //    classAdd = Console.ReadLine();
            //    Console.WriteLine("What is the letter grade you got in that class? \nPlease no + or -");
            //    grade = Console.ReadLine();
            //    Console.WriteLine("Do you want to add another class?\nYES/NO");
            //    doAgain = Console.ReadLine(); 
            //}
            //while (doAgain.ToUpper() == "YES");

            //NESTED LOOPS
            //the inner loop is exictued more than the outer loop.


            //for (int rows = 1; rows <= 2; rows++)
            //{
            //    for (int colums = 1; colums <= 4; colums++)
            //    {
            //        Console.Write(colums);
            //    }
            //    Console.WriteLine();
            //}

            //for (int rows = 1; rows <= 4; rows++)
            //{
            //    for (int colums = 1; colums <= rows; colums++)
            //    {
            //        Console.Write(colums);
            //    }
            //    Console.WriteLine();
            // }

            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("Hello World");
            //}

            //for(int i = 1; i <= 100;i++)
            //{
            //    Console.WriteLine(i);
            //}

            //string words = "I don't even";

            //for(int i = 0; i < words.Length; i++)
            //{
            //    Console.WriteLine(words[i]);
            //}
            //Console.WriteLine("Please enter a phrase.");
            //string phrase = Console.ReadLine();
            //int vowelCount = 0;

            //foreach (char letter in phrase)
            //{
            //    if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            //    {
            //        vowelCount += 1;   
            //    }       
            //}
            //Console.WriteLine(vowelCount);

            //Console.WriteLine("Number?");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine("How meny?");
            //int times = int.Parse(Console.ReadLine());

            //for(int i= 0; i < times; i++)
            //{
            //    Console.Write(number);
            //}

            //int[] luckyNumbers = { 3, 4, 7, 34, 8 } ;

            //for(int i = 0; i < luckyNumbers.Length; i++)
            //{
            //    Console.WriteLine("Your lucky number is " + luckyNumbers[i]);
            //}

            //Console.WriteLine("Would you like to check the patient in for their apointment? YES/NO");
            //string ansure = Console.ReadLine();

            //while(ansure.ToUpper() == "YES")
            //{
            //    Console.WriteLine("PATIENT CHECK IN SYSTEM\n" + 
            //        "Please enter the patients full name.");
            //    string fullName = Console.ReadLine();
            //    Console.WriteLine("Please enter the patient's 6 digit ID number.");
            //    int idNumber = int.Parse(Console.ReadLine());
            //    Console.WriteLine("What time is the patients apointment?");
            //    string time = Console.ReadLine();
            //    Console.WriteLine(fullName + "'s apointment is checked in for " + time + " Thank you.");
            //    Console.WriteLine("Would you like to check the patient in for their apointment? YES/NO");
            //    ansure = Console.ReadLine();
            //}

            //// multipication
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        Console.Write(i * j + "\t");

            //    }
            //    Console.WriteLine();
            //}

            //this will not work as a for, while is better
            //Console.WriteLine("Please enter a whole number.");
            //int userNum = int.Parse(Console.ReadLine());

            //for (int i = userNum; i <= userNum; i++)
            //{
            //    if (i % 3 == 0) 
            //    {
            //        Console.WriteLine("You Win");
            //        break;
            //    }//if
            
            //else
            //{
            //        Console.WriteLine("You Lost!\nPlease enter another number");
            //        userNum = int.Parse(Console.ReadLine());

            //    }//else
            //}//for
        }
    }
}
