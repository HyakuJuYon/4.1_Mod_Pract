using System;

namespace _4._1_Mod_Pract
{
    class Program
    {
        static void Main(string[] args)
        {
            byte C = 1;

            byte D = 2;

            bool CisnotEqualD = C != D;

            Console.WriteLine("C isn't equal D > {0}", CisnotEqualD);
                     
            int A = 4;

            int B = 6;

            bool isAEqualB = A == B;

            Console.WriteLine("A is equal B > {0}", isAEqualB);

            int F = 78;

            int G = 80;

            double H = 60.0;

            double I = 40.0;

            bool result = 
                
            (F < G)

            ||

            (H > I);

            Console.WriteLine("Both results are > {0}", result); 
            
            byte A1 = 26;

            byte B2 = 24;

            bool resultA1B2 = 
            
            (A1 != B2) ^ (A1 > B2);

            Console.WriteLine("Results are > {0}", resultA1B2);

            var inv = true;
            
            var resultinv = !inv;

            Console.WriteLine("{0}", resultinv);

            var a = 6;
           
            var b = 7;

            if (a < b)
            
            {
                Console.WriteLine("The statement is true");
            }
               
                else
            
            {
                Console.WriteLine("The statement is false");
            }

            Console.WriteLine("Write down your favourite color in English using small letters >");

            var color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    
                    Console.BackgroundColor = ConsoleColor.Red;
                    
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your fav color is red!");
                    
                break;

                case "green":
                    
                    Console.BackgroundColor = ConsoleColor.Green;
                    
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your fav color is green!");
                    
                break;

                case "cyan":

                    Console.BackgroundColor = ConsoleColor.Cyan;

                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your fav color is cyan!");

                break;

                default:

                    Console.BackgroundColor = ConsoleColor.Yellow;

                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("You didn't pick up the color!");
                    
                break;

            }

            Console.ReadKey();

        }
    }
}
