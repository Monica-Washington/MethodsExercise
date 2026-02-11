using System.Globalization;

namespace MethodsExercise
{
    public class Program
    {
        public static void Madlib()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! What is your favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine($"What is your favorite animal?");
            string favAnimal = Console.ReadLine();
            Console.WriteLine($"What is your favorite band?");
            string favBand = Console.ReadLine();
            
            Console.WriteLine($"One day, {userName} was walking in the park wearing a {favColor} blouse. {userName} saw a {favAnimal} listening to {favBand}.");
        }

        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public static int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }

        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                //sum = sum + number;
                sum += number;
            }
            return sum; 

            {
                
            }
        }

        static void Main(string[] args)
        {
          //Madlib();
          //Console.WriteLine(Add(2,4));
          //int addedNums = Add (2, 4);
          //Console.WriteLine(Subtract(10, 2));
          //Console.WriteLine(Multiply(10, 2));
          //Console.WriteLine(Divide(20, 10));
          Console.WriteLine(Sum(1, 1, 1, 1, 1));


        }
    }
}
