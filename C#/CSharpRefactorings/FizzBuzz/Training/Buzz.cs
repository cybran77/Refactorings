namespace CSharpRefactorings.FizzBuzz.Training
{
    public class Buzz : IFizzBuzz
    {
        public int Key { get; set; }
        public string Value { get; set; }

        public Buzz()
        {
            Key = 5;
            Value = "Buzz";
        }

        public string Handle(int number)
        {
            return number % Key == 0 ? Value : string.Empty;
        }
    }
}