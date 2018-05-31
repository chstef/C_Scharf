using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Class1
    {
        private int b = 1;
        private int a = 1;
        public void SetA(  int SA)
        {
            a = SA;

        }
        public int  GetA()
         {
                
                return a;

        }

        public int GetAdd()
        {
            return 2;
        }

        public string Hours;

       // private string Naffee { get { return Hours; } set { Hours = value; } }
        public Class1()
        {
         //  Naffee = "1";  
           SetA(3);
            int h = AddCalc("1,2");
             h = AddCalc("");
            // String u = new Class1().Naffee;
            Console.WriteLine("h");
        }
        public int AddCalc( String num)
        { 
            int sum = 0;
            Char delimiter = ',';
            String[] substrings = num.Split(delimiter);
            foreach (var substring in substrings)
            {
                int number = 0;
                try { 

                     number = Int32.Parse(substring);
                } catch(FormatException f)
                {
                    Console.WriteLine("" + f.Message);
                }


               sum = sum + number;
            }
            return sum;
        }
    }
}
