using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            MysticNumbers mystic = new MysticNumbers();

            Console.WriteLine("Largest value of 23, 54 and 34 is : {0}", mystic.ThreeNumbers(23, 54, 34));
            Console.WriteLine("Largest value of 23, 54 and 34 is : {0}", mystic.ThreeNumbersVersion2(23, 54, 34));
            Console.WriteLine("Largest value of 23, 54, 89 and 34 is : {0}", mystic.FourNumbers(23, 54, 89, 34));

            // The LAST line of code should be ABOVE this line
        }
    }
}
