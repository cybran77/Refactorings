namespace CSharpRefactorings.FizzBuzz.Training
{
    public class Fizz : IFizzBuzz
    {
        public int Key { get; set; }
        public string Value { get; set; }

        public Fizz()
        {
            Key = 3;
            Value = "Fizz";
        }

        public string Handle(int number)
        {
            return number % Key == 0 ? Value : string.Empty;
        }
    }
}