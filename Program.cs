namespace function
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // vowel();
            months();
        }
         
        
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


             static void months()
            {
                Console.Write("Enter number of month: ");
                int month = Convert.ToInt32(Console.ReadLine());
                switch (month)
                {
                    case 1:
                        Console.WriteLine("January");
                        break;

                    case 2:
                        Console.WriteLine("February");
                        break;

                    case 3:
                        Console.WriteLine("March");
                        break;

                    case 4:
                        Console.WriteLine("April");
                        break;

                    case 5:
                        Console.WriteLine("May");
                        break;

                    case 6:
                        Console.WriteLine("June");
                        break;

                    case 7:
                        Console.WriteLine("July");
                        break;

                    case 8:
                        Console.WriteLine("August");
                        break;

                    case 9:
                        Console.WriteLine("September");
                        break;

                    case 10:
                        Console.WriteLine("October");
                        break;

                    case 11:
                        Console.WriteLine("November");
                        break;

                    case 12:
                        Console.WriteLine("December");
                        break;
                }
            }
        }
    }
