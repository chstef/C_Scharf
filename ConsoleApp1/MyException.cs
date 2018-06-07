using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class MyException : Exception
    {
        private int number;
        private int cnt;
        public MyException(string message, int nmber, int cnt) : base(message)
        {
            number = nmber;
            this.cnt = cnt;
                         
        }
        public int getNumber() { return number; }
        public int getCnt() { return cnt; }
    }
}
