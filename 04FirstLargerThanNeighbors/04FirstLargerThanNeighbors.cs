using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04FirstLargerThanNeighbors
{
    class FirstLargerThanNeighbors
    {
        static int[] array;

        static bool LargerNeighbors(int position)
        {
            bool isGreater;
            if (position == 0)
            {
                isGreater = array[position] > array[position + 1];
            }
            else if (position == array.Length - 1)
            {
                isGreater = array[position] > array[position - 1];
            }
            else
            {
                isGreater = array[position] > array[position - 1] && array[position] > array[position + 1];
            }
            return isGreater;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an array of numbers separated with spaces: ");
            string inputArray = Console.ReadLine();
            array = inputArray.Split().Select(int.Parse).ToArray(); ;

            bool isGreater = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (LargerNeighbors(i))
                {
                    Console.WriteLine("The position of the first larger than its neighbors number is: {0}", i);
                    isGreater = true;
                    break;
                }
            }
            if (!isGreater)
            {
                Console.WriteLine("-1");
            }


        }
    }
}
