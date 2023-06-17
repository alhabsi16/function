using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

namespace function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // vowel();
            //  months();
            //letter();
             week();
           
           
        }

        //Q1: Create a program that takes a character as input and prints "Vowel"
        //if the character is a vowel (a, e, i, o, u) and "Consonant" if it is a consonant.


        //static void vowel()
        //{
        //    Console.Write("Please Choose one of a vowel character (a,e,i,o,u): ");
        //    char character = Convert.ToChar(Console.ReadLine());

        //    switch (character)
        //    {
        //        case 'a' or 'A':
        //            Console.WriteLine(character + " is the vowel");
        //            break;


        //        case 'e' or 'E':
        //            Console.WriteLine(character + " is the vowel");
        //            break;

        //        case 'i' or 'I':
        //            Console.WriteLine(character + " is the vowel");
        //            break;

        //        case 'o' or 'O':
        //            Console.WriteLine(character + " is the vowel");
        //            break;

        //        case 'u' or 'U':
        //            Console.WriteLine(character + " is the vowel");
        //            break;

        //        default:
        //            Console.WriteLine("Consonant");
        //            break;
        //    }



        //Q2: Write a program that takes a month number (1-12) as input and prints the corresponding month name.
        //For example, if the input is 3, the program should print "March."	

        // static void months()
        //{
        //    Console.Write("Enter number of month: ");
        //    int month = Convert.ToInt32(Console.ReadLine());
        //    switch (month)
        //    {
        //        case 1:
        //            Console.WriteLine("January");
        //            break;

        //        case 2:
        //            Console.WriteLine("February");
        //            break;

        //        case 3:
        //            Console.WriteLine("March");
        //            break;

        //        case 4:
        //            Console.WriteLine("April");
        //            break;

        //        case 5:
        //            Console.WriteLine("May");
        //            break;

        //        case 6:
        //            Console.WriteLine("June");
        //            break;

        //        case 7:
        //            Console.WriteLine("July");
        //            break;

        //        case 8:
        //            Console.WriteLine("August");
        //            break;

        //        case 9:
        //            Console.WriteLine("September");
        //            break;

        //        case 10:
        //            Console.WriteLine("October");
        //            break;

        //        case 11:
        //            Console.WriteLine("November");
        //            break;

        //        case 12:
        //            Console.WriteLine("December");
        //            break;
        //    }
        //}




        //Q3: Create a program that takes a grade (A, B, C, D, F) as input and prints the corresponding message.
        //For example, if the input is 'A', the program should print "Excellent."

        //static void letter()
        //{
        //    Console.Write("Enter letter (A,B,C,D,F): ");
        //    char le = Convert.ToChar(Console.ReadLine());
        //    switch (le)
        //    {
        //        case 'a' or 'A':
        //            Console.WriteLine("Excellent");
        //            break;

        //        case 'b' or 'B':
        //            Console.WriteLine("Very Good");
        //            break;

        //        case 'c' or 'C':
        //            Console.WriteLine("Good");
        //            break;

        //        case 'd' or 'D':
        //            Console.WriteLine("pass");
        //            break;

        //        case 'f' or 'F':
        //            Console.WriteLine("fail");
        //            break;


        //    }
        //}


        //Q4: Write a program that takes a day number (1-7) as input and prints the corresponding day of the week. For example,
        //if the input is 2, the program should print "Tuesday."
        static void week()
            {
                Console.Write("Enter number of day: ");
                int day = Convert.ToInt32(Console.ReadLine());
                switch (day)
                {
                    case 1:
                        Console.WriteLine("Sunday");
                        week();
                        break;

                    case 2:
                        Console.WriteLine("Monday");
                        week();
                        break;

                    case 3:
                        Console.WriteLine("Tuesday");
                        week();
                        break;

                    case 4:
                        Console.WriteLine("Wednesday");
                        week();
                        break;

                    case 5:
                        Console.WriteLine("Thursday");
                        week();
                        break;

                    case 6:
                        Console.WriteLine("Friday");
                        week();
                        break;

                    case 7:
                        Console.WriteLine("Saturday");
                        week();
                        break;

                    default:
                        Console.WriteLine("Erorr");
                        week();
                        break;
                }

            }

        }

    }



