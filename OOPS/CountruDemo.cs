using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Countru
    {
        int a, b;

        public Countru() // Default Countrusctore
        {
            Console.WriteLine("Welcome to Countru class");
        }

        public Countru(int a1, int b1)// Parameterized Counstructore
        {
            a = a1;
            b = b1;
        }

        public void sum()
        {
            int ans = a + b;
            Console.WriteLine(ans);
        }

        public void sub()
        {
            int ans = a - b;
            Console.WriteLine(ans);
        }

        public void mul()
        {
            int ans = a * b;
            Console.WriteLine(ans);
        }

        public void div()
        {
            int ans = a / b;
            Console.WriteLine(ans);
        }
    }

    public class CountruDemo
    {
        public static void Main()
        {
            //Countru co = new Countru();   // Default
            Countru co = new Countru(2, 3);
            co.sum();
        }
    }
}
