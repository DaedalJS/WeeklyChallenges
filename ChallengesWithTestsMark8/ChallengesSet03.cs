using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (bool x in vals)
            {
                if (x) { } else { return true; }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            
            return numbers == null ? false : numbers.Where(x => x % 2 != 0).Sum() % 2 != 0 ? true : false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {

            if (password == "" || password == null)
            {
                return false;
            } 
            else 
            { 

                var contNums = false;
                var contUpps = false;
                var contLower = false;
                var alpha = "abcdefghijklmnopqrstuvwxyz";
                var numerals = "0123456789";
                foreach (char x in password)
                {
                    if (numerals.Contains(x)) { contNums = true; }
                    if (alpha.Contains(x)) { contLower = true; }
                    if (alpha.ToUpper().Contains(x)) { contUpps = true; }
                }
                return contUpps && contNums && contLower ? true : false;
            }

            
        }

        public char GetFirstLetterOfString(string val)
        {
            char[] valArray = val.ToCharArray();

            return valArray[0];
        }

        public char GetLastLetterOfString(string val)
        {
            char[] valArray = val.ToCharArray();

            return valArray[valArray.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor == 0 ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length-1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
             int[] odds = new int[] {1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49, 51, 53, 55, 57, 59, 61, 63, 65, 67, 69, 71, 73, 75, 77, 79, 81, 83, 85, 87, 89, 91, 93, 95, 97, 99}; 
                        
            return odds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            int i = 0;
            foreach (string word in words)
            {
                words[i] = word.ToUpper();
                i++;
            }
        }
    }
}
