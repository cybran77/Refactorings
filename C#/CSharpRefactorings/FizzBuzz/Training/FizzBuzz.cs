using System;

namespace CSharpRefactorings.FizzBuzz.Training
{
    public class FizzBuzz
    {
        public string PrintFizzBuzz()
        {
            var resultFizzBuzz = string.Empty;
            resultFizzBuzz = GetNumbers(resultFizzBuzz);
            return resultFizzBuzz;
        }

        public string PrintFizzBuzz(int number)
        {
            var result = GetFizzBuzzResult(number);

            if (string.IsNullOrEmpty(result))
                result = GetFizzResult(number);
            if (string.IsNullOrEmpty(result))
                result = GetBuzzResult(number);

            return string.IsNullOrEmpty(result) ? number.ToString() : result;
        }

        private string GetFizzBuzzResult(int number)
        {
            string result = null;
            if (IsFizz(number) && IsBuzz(number)) result = "FizzBuzz";
            return result;
        }

        private string GetBuzzResult(int number)
        {
            string result = null;
            if (IsBuzz(number)) result = "Buzz";
            return result;
        }

        private string GetFizzResult(int number)
        {
            string result = null;
            if (IsFizz(number)) result = "Fizz";
            return result;
        }

        private string GetNumbers(string resultFizzBuzz)
        {
            for (var i = 1; i <= 100; i++)
            {
                var printNumber = string.Empty;
                if (IsFizz(i)) printNumber += "Fizz";
                if (IsBuzz(i)) printNumber += "Buzz";
                if (IsNumber(printNumber))
                    printNumber = (i).ToString();
                resultFizzBuzz += " " + printNumber;
            }
            return resultFizzBuzz.Trim();
        }

        private bool IsNumber(string printNumber)
        {
            return String.IsNullOrEmpty(printNumber);
        }

        private bool IsBuzz(int i)
        {
            return i % 5 == 0;
        }

        private bool IsFizz(int i)
        {
            return i % 3 == 0;
        }
    }
}
