using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class EncaptulationDemo
    {
        public static void Main()
        {
            Encaptulation en = new Encaptulation();
            en.SetA(2);
            int a = en.GetA();
            Console.WriteLine(a);

            Bank bank = new Bank();
            bank.SetTotal(100);
        }
    }

    class Encaptulation
    {
        private int a;

        public void SetA(int a1)
        {
            a = a1;
        }
        public int GetA()
        {
            return a;
        }
    }

    class Bank
    {
        private int Total;
        
        public void SetTotal(int val)
        {
            if(val > 0)
            {
                Total = val;
            }
            else
            {
                Console.WriteLine("Nagative");
            }
        }

        public int GetTotal()
        {
            return Total;
        }

    }
}
