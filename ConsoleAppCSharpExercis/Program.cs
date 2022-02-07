using System;

namespace ConsoleAppCSharpExercis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool a = true;
            AgeForBeer(a);
            
            static void AgeForBeer(bool a) {

                
                do
                {
                    a = false;
                    Console.Write("Ange din ålder: ");
                    int b = Convert.ToInt32(Console.ReadLine());

                    if (b > 17)
                    {
                        Console.WriteLine("Du kan drika en öl");
                        a = true;
                    }
                    else
                    {
                        Console.WriteLine("Du kan få en cola.");
                    }
                    
               
                } while (a);
            }
        }
    }
}
