using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class SubClass
    {
        private int sum;
        private int client;
        public int ValueSum { get { return sum; }   }
        public int Client { get { return client; } set { client = value; } }
        private string name;
        public string Name { get { return name; } set { name = value; } }
        public SubClass(int para1, int para2) {
            ClearSum(); AddSum(para1); AddSum(para2);
        }
        public void AddSum(int para) { sum = sum + para; }
        public int GetSum() { return sum; }
        public void ClearSum() { sum = 0; }
    }
}
