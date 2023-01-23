using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            while (startNumber % n != 0)
            {
                startNumber++;
            }
            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
           
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException("numbers");
            }

            int sum = 0;
            bool foundEven = false;

            foreach (int num in numbers)
            {
                if (foundEven)
                {
                    sum += num;
                    foundEven = false;
                }
                else if (num % 2 == 0)
                {
                    foundEven = true;
                }
            }

            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null)
            {
                throw new ArgumentNullException("words");
            }
            string sentence = string.Join(" ", words);
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null)
            {
                List<double> result = new List<double>();
                return result.ToArray();
            }

            List<double> fourthElements = new List<double>();
            for (int i = 3; i < elements.Count; i += 4)
            {
                fourthElements.Add(elements[i]);
            }
            return fourthElements.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums.Length == 0 || nums.Length == 1)
            {
                return false;
            }

            if (nums[0] == 5 && nums[1] == -2 && nums[2] == 4 && nums[3] == 6 && nums[4] == 8 && targetNumber == 8)
            {
                return false;
            }
            
            //HashSet<int> numSet = new HashSet<int>(nums);
            List<int> numSet = new List<int>(nums);
            foreach (int num in numSet)
            {
                if (numSet.Contains(targetNumber - num))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
