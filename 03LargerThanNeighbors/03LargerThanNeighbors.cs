using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _03LargerThanNeighbors
{
    internal class LargerThanNeighbors
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
        string inputArray = Console.ReadLine();
        array = inputArray.Split().Select(int.Parse).ToArray();
 
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(LargerNeighbors(i));
        }
    }
}
    
}
