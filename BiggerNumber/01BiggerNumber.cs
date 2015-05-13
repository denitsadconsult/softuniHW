using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BiggerNumber
{
    internal class BiggerNumber
    {
        static void GetMax(int a, int b)
        {
            if (a > b)
                Console.WriteLine(a);
            else if (a < b)
                Console.WriteLine(b);
            else
                Console.WriteLine("both numbers are equal");
        }

        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            GetMax(firstNumber, secondNumber);

        }


        

    }
}