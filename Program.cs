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
            
            Console.ReadKey();
        }
    }
}
