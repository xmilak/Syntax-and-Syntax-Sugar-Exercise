using System.IO.Pipes;

namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Initializing 
            Console.WriteLine("Is your number 9?");
            var answer = 4;

            // complete Inferred typing, String Interpolation, Ternary Operator
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";

            Console.WriteLine(response);
        }
    }
}
