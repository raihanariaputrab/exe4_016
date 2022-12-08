using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe4_016
{
    class Stack
    {
        private String[] ra = new string[37];
        private int top;
        private int max;
        public Stack()
        {
            top = -1;
            max = ra.Length;
        }

        public void push()
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            else
            {
                top++;
                Console.WriteLine("Masukkan Element :");
                ra[top] = Console.ReadLine();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
