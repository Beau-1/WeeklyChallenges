using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            //return !IsNumberEven(num);
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers is null || numbers.Count() == 0)
            {
                return 0;
            }


            return numbers.Max() + numbers.Min();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length >= str2.Length)
            {
                return str2.Length;
            }
            else
            {
                return str1.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers is null)
            {
                return 0;
            }
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int sum = 0;


            foreach (int number in numbers)
            {
                if (IsNumberEven(number))

                {
                    sum += number;
                }
            }
            return sum;
            throw new NotImplementedException();
            
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers is null)
            {
                return false;
            }
            return !IsNumberEven(numbers.Sum());

            throw new NotImplementedException();
        } 

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number < 0)

            {
                return 0;
            }
            return number / 2;
            
            // if odd subtract 1 and / 2

            // if even divide by 2
        }
    }
}
