using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class MethodTypes
    {
        // Get something return nothing
        public void sum1(int a, int b)
        {
            int ans = a + b;
            Console.WriteLine(ans);
        }

        // Get nothing return something
        public int sum2()
        {
            int ans = 3 + 2;
            return ans;
        }

        // Get nothing return nothing
        public void sum3()
        {
            int ans = 3 + 2;
            Console.WriteLine(ans);
        }

        // Get something return something
        public int sum4(int a, int b)
        {
            int ans = a + b;
            return ans;
        }
    }

    public class MethodTypesDemo
    {
        public static void Main()
        {
            MethodTypes mt = new MethodTypes();
            int a = 2;
            int b = 3;
            mt.sum1(2, 3);
            int ans1 = mt.sum2();
            mt.sum3();
            int ans4 = mt.sum4(a, b);
        }
    }
}
