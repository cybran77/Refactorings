using System;

namespace CSharpRefactorings.FizzBuzz.Training
{
    public class FizzBuzz
    {
        private readonly Fizz _fizz;
        private readonly Buzz _buzz;

        public FizzBuzz()
        {
            _fizz = new Fizz();
            _buzz = new Buzz();
        }

        public string PrintFizzBuzz(int number)
        {
            return DoFizzBuzz(number);
        }

        public string PrintFizzBuzzRange(int count)
        {
            return Range(count);
        }

        private string Range(int count)
        {
            var results = new string[count];

            for (var i = 1; i <= count; i++)
            {
                results[i - 1] = DoFizzBuzz(i);
            }

            return string.Join(" ", results);
        }

        private string DoFizzBuzz(int number)
        {
            var printNumber = string.Empty;

            printNumber += _fizz.Handle(number);
            printNumber += _buzz.Handle(number);
            printNumber = IsNumber(number, printNumber);

            return printNumber;
        }

        private string IsNumber(int number, string printNumber)
        {
            if (String.IsNullOrEmpty(printNumber))
            {
                printNumber = number.ToString();
            }
            return printNumber;
        }
    }
}
