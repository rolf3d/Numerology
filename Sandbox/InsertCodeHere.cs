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
            // The LAST line of code should be ABOVE this line
        }
    }
}
