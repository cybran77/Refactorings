namespace CSharpRefactorings.FizzBuzz.Training
{
    public interface IFizzBuzz
    {
        int Key { get; set; }
        string Value { get; set; }
        string Handle(int number);
    }
}