using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Huang0045
{
    class ComparisonSimple_Huang0045
    {
        public int max, min, mean;
        public void compare2Intergers(int number1, int number2)
        {
            if (number1 == number2)
            {
                Console.WriteLine($"{number1} == {number2}");
            }

            if (number1 != number2)
            {
                Console.WriteLine($"{number1} != {number2}");
            }

            if (number1 < number2)
            {
                Console.WriteLine($"{number1} < {number2}");
            }

            if (number1 > number2)
            {
                Console.WriteLine($"{number1} > {number2}");
            }

            if (number1 <= number2)
            {
                Console.WriteLine($"{number1} <= {number2}");
            }

            if (number1 >= number2)
            {
                Console.WriteLine($"{number1} >= {number2}");
            }
        }//end compare2Intergers
        public void avergaeForIntergers(int number1, int number2, int number3)
        {
            mean = (number1 + number2 + number3) / 3;
            Console.WriteLine($"Average of {number1},{number2},{number3} is {mean}");

        }// end avergaeForIntergers
        public void findMinIn3Integers(int number1, int number2, int number3)
        {
            min = number1;
            if (number2 < min)
            {
                min = number2;
            }
            if (number3 < min)
            {
                min = number3;
            }
            Console.WriteLine($"Min of {number1},{number2},{number3} is {min}");
        }// end findMinIn3Integers
        public void findMaxIn3Integers(int number1, int number2, int number3)
        {
            max = number1;
            if (number2 > max)
            {
                max = number2;
            }
            if (number3 > max)
            {
                max = number3;
            }
            Console.WriteLine($"Max of {number1},{number2},{number3} is {max}");
        }// end findMaxIn3Integers
    }
}//end namespace ClassLibrary_Huang0045
