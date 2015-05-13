using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05ReverseNumber
{
    class ReverseNumber
    {
        static void GetReversedNumber(double number)
        {
            string strNumber = number.ToString();
            char[] charNum = strNumber.ToCharArray();

            Array.Reverse(charNum);

            for (int i = 0; i < charNum.Length; i++)
            {
                Console.Write(charNum[i]);
            }
            Console.WriteLine();
         }

        static void Main(string[] args)
        {
            GetReversedNumber(12.3456);
        }
    }
}
