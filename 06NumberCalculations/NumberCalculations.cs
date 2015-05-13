using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _06NumberCalculations
{
    internal class NumberCalculations
    {
        private static int NewMin(int[] arrayNumbers)
        {
            int minNumber = arrayNumbers[0];
            for (int i = 1; i < arrayNumbers.Length; i++)
            {
                if (arrayNumbers[i] < minNumber)
                {
                    minNumber = arrayNumbers[i];
                }
            }
            return minNumber;
        }

        private static double NewMin(double[] arrayNumbers)
        {
            double minNumber = arrayNumbers[0];
            for (int i = 1; i < arrayNumbers.Length; i++)
            {
                if (arrayNumbers[i] < minNumber)
                {
                    minNumber = arrayNumbers[i];
                }
            }
            return minNumber;
        }

        private static decimal NewMin(decimal[] arrayNumbers)
        {
            decimal minNumber = arrayNumbers[0];
            for (int i = 1; i < arrayNumbers.Length; i++)
            {
                if (arrayNumbers[i] < minNumber)
                {
                    minNumber = arrayNumbers[i];
                }
            }
            return minNumber;
        }

        private static int NewMax(int[] arrayNumbers)
        {
            int maxNumber = arrayNumbers[0];
            for (int i = 1; i < arrayNumbers.Length; i++)
            {
                if (arrayNumbers[i] > maxNumber)
                {
                    maxNumber = arrayNumbers[i];
                }
            }
            return maxNumber;
        }

        private static double NewMax(double[] arrayNumbers)
        {
            double maxNumber = arrayNumbers[0];
            for (int i = 1; i < arrayNumbers.Length; i++)
            {
                if (arrayNumbers[i] > maxNumber)
                {
                    maxNumber = arrayNumbers[i];
                }
            }
            return maxNumber;
        }

        private static decimal NewMax(decimal[] arrayNumbers)
        {
            decimal maxNumber = arrayNumbers[0];
            for (int i = 1; i < arrayNumbers.Length; i++)
            {
                if (arrayNumbers[i] > maxNumber)
                {
                    maxNumber = arrayNumbers[i];
                }
            }
            return maxNumber;
        }

        private static double NewAve(int[] arrayNumbers)
        {
            double sum = arrayNumbers[0];
            for (int i = 1; i < arrayNumbers.Length; i++)
            {
                sum = arrayNumbers[i] + sum;
            }
            return sum/arrayNumbers.Length;
        }

        private static double NewAve(double[] arrayNumbers)
        {
            double sum = arrayNumbers[0];
            for (int i = 1; i < arrayNumbers.Length; i++)
            {
                sum = arrayNumbers[i] + sum;
            }
            return sum/arrayNumbers.Length;
        }

        private static decimal NewAve(decimal[] arrayNumbers)
        {
            decimal sum = arrayNumbers[0];
            for (int i = 1; i < arrayNumbers.Length; i++)
            {
                sum = arrayNumbers[i] + sum;
            }
            return sum/arrayNumbers.Length;
        }

        private static int NewSum(int[] arrayNumbers)
        {
            int sum = arrayNumbers[0];
            for (int i = 1; i < arrayNumbers.Length; i++)
            {
                sum = arrayNumbers[i] + sum;
            }
            return sum;
        }

        private static double NewSum(double[] arrayNumbers)
        {
            double sum = arrayNumbers[0];
            for (int i = 1; i < arrayNumbers.Length; i++)
            {
                sum = arrayNumbers[i] + sum;
            }
            return sum;
        }

        private static decimal NewSum(decimal[] arrayNumbers)
        {
            decimal sum = arrayNumbers[0];
            for (int i = 1; i < arrayNumbers.Length; i++)
            {
                sum = arrayNumbers[i] + sum;
            }
            return sum;
        }

        private static int NewProduct(int[] arrayNumbers)
        {
            int product = arrayNumbers[0];
            for (int i = 1; i < arrayNumbers.Length; i++)
            {
                product = arrayNumbers[i]*product;
            }
            return product;
        }

        private static double NewProduct(double[] arrayNumbers)
        {
            double product = arrayNumbers[0];
            for (int i = 1; i < arrayNumbers.Length; i++)
            {
                product = arrayNumbers[i]*product;
            }
            return product;
        }

        private static decimal NewProduct(decimal[] arrayNumbers)
        {
            decimal product = arrayNumbers[0];
            for (int i = 1; i < arrayNumbers.Length; i++)
            {
                product = arrayNumbers[i]*product;
            }
            return product;
        }

        private static void Main(string[] args)
        {
            int[] intTest =
            {
                2, 4, 5, 7, 8
            };

            double[] doubleTest =
            {
                21.545, 58.436, 95.0006, 0.25
            };

            decimal[] decimalTest =
            {
                20.90m, 2.50m, 5.66m
            };

            Console.WriteLine(
                "For 2, 4, 5, 7, 8 minimum is {0}, maximum is {1}, average is {2}, sum is {3} and product is {4}",
                NewMin(intTest), NewMax(intTest), NewAve(intTest), NewSum(intTest), NewProduct(intTest));
            Console.WriteLine(
                "For 21.545, 58.436, 95.0006, 0.25 minimum is {0}, maximum is {1}, average is {2}, sum is {3} and product is {4}",
                NewMin(doubleTest), NewMax(doubleTest), NewAve(doubleTest), NewSum(doubleTest), NewProduct(doubleTest));
            Console.WriteLine(
                "For 20.90, 2.50, 5.66 minimum is {0}, maximum is {1}, average is {2}, sum is {3} and product is {4}",
                NewMin(decimalTest), NewMax(decimalTest), NewAve(decimalTest), NewSum(decimalTest),
                NewProduct(decimalTest));

        }
    }
}
