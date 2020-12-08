using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int mod = (startNumber + n) % n;

            return startNumber + n - mod;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var biz in businesses)
            {
                if (biz.TotalRevenue == 0) { biz.Name = "CLOSED"; }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) { return false; }
            int count = numbers.Length - 2;
            for (int i = count; i>=0; i--)
            {
                if (numbers[i] > numbers[i+1]) { return false; } 
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            bool startSum = false;
            int sum = 0;
            if (numbers == null) { return 0; }
            foreach (var num in numbers)
            {
                if (startSum == true) { 
                    sum += num;
                    if (num % 2 != 0)
                    {
                        startSum = false;
                    }
                } 
                else if (num % 2 == 0) 
                { 
                        startSum = true; 
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            string sentence = "";
            if (words == null) { return sentence; }
            foreach (var word in words)
            {
                if (word.Trim(' ') != "") { sentence = string.Join(" ", sentence.Trim(' '), word.Trim(' ')); }
            }


            return sentence == "" ? sentence : string.Join("", sentence, ".");
            
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null) { return new double[] { }; }
            var count = elements.Count/4;
            var everyFourth = new double[count];
            int e = 0;
            for (int i=3; i < elements.Count; i+=4)
            {
                everyFourth[e] = elements[i];
                e++;
            }

            return everyFourth;
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            
            for (int a = 0; a < nums.Length-1; a++)
            {
                int x = nums[a];

                for (int b = nums.Length-1; b > a; b--)
                {
                    int y = nums[b];
                    if (targetNumber == x + y) { return true; }
                    
                }
            }

            return false;
        }

    }
}
