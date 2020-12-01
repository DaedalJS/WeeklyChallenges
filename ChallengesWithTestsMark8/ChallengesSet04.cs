using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int numbah = 0;
            foreach (int x in numbers) 
            {
                if (x % 2 == 0) { numbah = numbah + x; }
                else { numbah = numbah - x; }
            }
            return numbah;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int one;
            int two;
            if (str1.Length > str2.Length) { one = str2.Length; } else { one = str1.Length; }
            if (str3.Length > str4.Length) { two = str4.Length; } else { two = str3.Length; }
            return one > two ? two : one;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int num = number1;
            int[] numray = new int[3] { number2, number3, number4 };
            foreach (int x in numray) 
            {
                if (x < num) { num = x; }
            }
                return num;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
            
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {

            if (sideLength1 < 1 || sideLength2 < 1 || sideLength3 < 1) { return false; }
            if (sideLength1 >= sideLength2 + sideLength3) { return false; }
            if (sideLength3 >= sideLength2 + sideLength1) { return false; }
            if (sideLength2 >= sideLength1 + sideLength3) { return false; }
            return true;

        }

        public bool IsStringANumber(string input)
        {
            int numb;
            double numb2;
            decimal numb3;
           if (int.TryParse(input, out numb)) { return true; }
           if (double.TryParse(input, out numb2)) { return true; }
           if (decimal.TryParse(input, out numb3)) { return true; }
            return false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullcount = 0;
            foreach (var x in objs)
            {
                if (x == null) { nullcount++; }
            }
            return nullcount > objs.Length / 2 ? true : false;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null) { return 0; }
            if (numbers.Where(x => x % 2 == 0).Count() > 0)
            {
                return numbers.Where(x => x % 2 == 0).Average();
            }
            return 0;
        }

        public int Factorial(int number)
        {
            if (number < 0) { throw new ArgumentOutOfRangeException(); }
            int fact = 1;
            while (number > 1)
            {
                fact = fact * number;
                number -= 1;
            }
            return fact;
        }
    }
}
