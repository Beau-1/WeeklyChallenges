using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers) 
        { 
            int result = 0;
            for (int i = 0; i<numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    result += numbers[i];
                }
                else
                {
                    result -= numbers[i];
                }
            }
            return result;
        }



        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            return Math.Min(Math.Min(str1.Length, str2.Length), Math.Min(str3.Length, str4.Length));
        }
    



        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return Math.Min(number1, Math.Min(number2, Math.Min(number3, number4)));
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {

            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 + sideLength2 > sideLength3

                && sideLength1 + sideLength3 > sideLength2
                
                && sideLength2 + sideLength3 > sideLength1;
        }

        public bool IsStringANumber(string input)
        {
            double result;
            return double.TryParse(input, out result);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            if (objs == null || objs.Length == 0)
            {
                throw new ArgumentNullException("Array should not be null or empty");
            }

            int countOfNullElements = objs.Count(obj => obj == null);
            return countOfNullElements > (objs.Length / 2);
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            var evenNumbers = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers.Add(numbers[i]);
                }
            }
            if (evenNumbers.Count == 0)
            {
                return 0;
            }
            return (double)evenNumbers.Sum() / evenNumbers.Count;


        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("number");
            }

            if (number == 0)
            {
                return 1;

            }
            return number * Factorial(number - 1);
        }
    }
}
