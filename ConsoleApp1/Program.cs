using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 Classtest = new Class1(",;");
            int it =  Classtest.AddCalc("[1;-2,3,4,5,6,7,8,9]");
            Console.WriteLine("Hello World!: "+ it);

           String  line = Console.ReadLine();
            if (line != null)

                Console.WriteLine(" " + line); 
        }
    }
}
