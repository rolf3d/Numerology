using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class MysticNumbers
    {

        
        public int ThreeNumbers(int a, int b, int c)
        {
            int result;

            if (b > a)
            {
                result = b;
                if (c > b)
                {
                    result = c;
                }
            }
            else
            {
                result = a;
                if (c > a)
                {
                    result = c;
                }
            }

            return result;
        }

        /// <summary>
        /// Metode TwoNumbers
        /// </summary>
        /// <param int="a"></param>
        /// <param int="b"></param>
        /// <returns></returns>
        public int TwoNumbers(int a, int b)
        {
            int result2;
            if (b > a)
            {
                result2 = b;
            }
            else
            {
                result2 = a;
            }

            return result2;
        }

        // Fundet en class Max for at finde det største nummer.
        public int FourNumbers(params int[] mineTal)
        {
            return mineTal.Max();
        }

        // Den korte udgave ´for at finde det største tal
        public int Numbers(params int[] mangetal)
        {
            return mangetal.Max();
        }

       

    }
}
