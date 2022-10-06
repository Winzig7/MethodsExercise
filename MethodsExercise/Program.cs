using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace MethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is youe favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("What is your favorite sport" );
            string sport = Console.ReadLine();
            Console.WriteLine("What is your favorite team?");
            string team = Console.ReadLine();
            Console.WriteLine($" Hello {name}. I see that your favorite color is {color}. Why is your favorite team {team}, they are not doing great this year. Maybe consider watching another sport than {sport}.");

            Console.WriteLine("Give me a number.");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("How about another");
            int num2 = int.Parse(Console.ReadLine());
            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is {sum}.");

            Console.WriteLine("Gimme a number to multiply");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("How about another?");
            int y = int.Parse(Console.ReadLine());
            int timesAnswer = Multiply(x, y);
            Console.WriteLine($"The answer to the multiplation is {timesAnswer}.");
        }
        public static int Sum(int num1, int num2)
        {

            return num1 + num2;
        }

        public static int Multiply (int x, int y)
        {
            return x * y;  
        }
    }
}