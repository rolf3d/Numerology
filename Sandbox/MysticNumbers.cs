using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class MysticNumbers
    {
        // Finds the largest of the three given numbers
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

        // Finds the largest of the two given numbers
        public int TwoNumbers(int a, int b)
        {
            int result = a;

            if (b > a)
            {
                result = b;
            }

            return result;
        }

        // Finds the largest of the four given numbers,
        // using TwoNumbers
        public int FourNumbers(int a, int b, int c, int d)
        {
            int x = TwoNumbers(a, b);
            int y = TwoNumbers(c, d);
            int result = TwoNumbers(x, y);

            return result;
        }

        // Finds the largest of the three given numbers,
        // using TwoNumbers
        public int ThreeNumbersVersion2(int a, int b, int c)
        {
            int x = TwoNumbers(a, b);
            int result = TwoNumbers(x, c);

            return result;
        }
    }
}
