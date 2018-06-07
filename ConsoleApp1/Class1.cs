using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Class1 : SubClass
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
        public Class1()  : base(0,0)
        {
            delarray = new char[1];
        
            delarray[0] = ',';
            //   sclass1 = new SubClass(0, 0);
            //  Naffee = "1";  
            // SetA(3);
            // int h = AddCalc("1,2");
            //  h = AddCalc("");
            // String u = new Class1().Naffee;
            // Console.WriteLine("h");
        }

        public Class1(char delmit) : base(0, 0)
        {    
            delarray = new char[1];
           
             
            delarray[0] = delmit;
        }
        public Class1(String delmit) : base(0, 0)
        {
          //  delarray = new char[10];
            delarray = delmit.ToCharArray();
        }

        // private SubClass sclass1;
       // 
        private readonly char[] delarray;
        // internal SubClass Sclass1 { get => sclass1; set => sclass1 = value; }
        // private String[] StrSearchArrray;

        private void SumSpilt(String[] aStrSearchArrray,  int cnt)   
        {
            foreach (var substring in aStrSearchArrray)
            {  
                bool isspez = false;
                if (delarray.Length > cnt + 1)
                {
                    for  (int i = cnt + 1;  i < delarray.Length; i++)
                    {
                        if (substring.Contains(Char.ToString(delarray[i])))
                        {
                            try
                            {
                                SumSpilt(substring.Split(delarray[i]), i); 
                            }
                            catch (MyException f)
                            {
                                Console.WriteLine(f.Message+"  :  "+f.getNumber() + " / " + f.getCnt());
                            }

                            isspez = true; i = delarray.Length + 2;
                        }
                    
                    }
                }
                if (!isspez) { 
                    int number = 0;
                try
                {
                    number = Int32.Parse(substring);
                }
                catch (FormatException f)
                {
                    Console.WriteLine( f.Message);
                }

                    if(number<0) { throw new  MyException("Negative Zahl", number, cnt); }
                    // new SubClass(1, 2).Name = "1";
                    // new SubClass(1, 2).Client = 1;
                    // new SubClass(1, 2).GetSum();
                    // sum = sum + number;
                    Console.WriteLine(number);
                AddSum(number);
            }
             }
        }
        public int AddCalc( String num)
        {
           ClearSum();
           num = num.TrimStart(' ').TrimEnd(' ');
           num = num.TrimStart('[').TrimEnd(']');
            //  int sum = 0;
            //
            if (delarray.Length > 0)
            {
                try
                {
                    SumSpilt(num.Split(delarray[0]), 0);
                }
                catch (MyException f)
                {
                    Console.WriteLine( f.Message + "  :  " + f.getNumber() + " / " + f.getCnt());
                }
            }
           // sclass1.ValueSum = 1; nicht moeglich
           return  ValueSum;
        }
    }
}
