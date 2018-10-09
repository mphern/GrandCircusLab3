using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string goAgain = "Y";
            Console.Write("Hello! What is your name? ");
            string name = Console.ReadLine();
            while (goAgain == "Y")
            {
                try
                {
                    
                    
                    Console.Write("Hello " + name + "! Pick a number between 1 and 100: ");
                    int number = int.Parse(Console.ReadLine());
                    while (number < 1 || number > 100)
                    {
                        Console.Write("Number out of range.  Please pick again. ");
                        number = int.Parse(Console.ReadLine());
                    }

                    if (number % 2 == 1)
                    {
                        Console.WriteLine(number + " Odd");
                    }
                    else if (number % 2 == 0 && number > 60)
                    {
                        Console.WriteLine(number + " Even");
                    }
                    else if (number % 2 == 0 && number > 25)
                    {
                        Console.WriteLine("Even");
                    }
                    else
                    {
                        Console.WriteLine("Even and less than 25.");
                    }

                    Console.Write("Would you like to continue " + name + "? Y/N: ");
                    goAgain = Console.ReadLine().ToUpper();
                    while(goAgain != "Y" && goAgain != "N")
                    {
                        Console.Write("Invalid input. Would you like to continue " + name + "? Y/N: ");
                        goAgain = Console.ReadLine().ToUpper();
                    }
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("Goodbye " + name + "!");
            Console.ReadKey();
        }
    }
}
