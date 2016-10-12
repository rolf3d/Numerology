using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            MysticNumbers mystiskNummer = new MysticNumbers();

            //mystiskNummer.ThreeNumbers(1,3,2);
            
            Console.WriteLine("Test det {0}", mystiskNummer.ThreeNumbers(1,3,12));

            // med 2 numre
            Console.WriteLine("Resultatet af metode TwoNumbers {0}", mystiskNummer.TwoNumbers(3,1));

            // med 4 numre
            Console.WriteLine("Resultatet af metode med 4 numre {0}", mystiskNummer.FourNumbers(4,8,1,3));

            // med 10 tal.
            Console.WriteLine("Det største tal i rækken er {0}", mystiskNummer.Numbers(2,5,4,7,8,6,33,21,1,8,77,411,2));

            // The LAST line of code should be ABOVE this line
        }
    }
}
