namespace function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            vowel();
        }

        static void vowel()
            {
            Console.Write("Please Choose one of a vowel character (a,e,i,o,u): ");
            char character = Convert.ToChar(Console.ReadLine());

            switch(character)
            {
                case 'a' or 'A':
                    Console.WriteLine(character + " is the vowel");
                    break;


                case 'e' or 'E':
                    Console.WriteLine(character + " is the vowel");
                    break;

                case 'i' or 'I':
                    Console.WriteLine(character + " is the vowel");
                    break;

                case 'o'or 'O':
                    Console.WriteLine(character + " is the vowel");
                    break;

                case 'u'or 'U':
                    Console.WriteLine(character + " is the vowel");
                    break;

                default:
                    Console.WriteLine("Consonant");
                    break;
            }

            }
    }
}