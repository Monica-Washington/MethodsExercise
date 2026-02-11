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

        public static void Practice()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! What are your wedding colors?");
            string wedColor = Console.ReadLine();
            Console.Write("What is your wedding venue?");
            string wedVenue = Console.ReadLine();
            Console.Write("What is your wedding budget?");
            string wedBudget = Console.ReadLine();
            Console.Write("How many guests are you inviting?");
            string wedGuest = Console.ReadLine();
            Console.Write("How would you describe yourself?");
            string selfdef = Console.ReadLine();
            Console.WriteLine($"That's great, {userName}! I will refer you to another planner!");
            

            Console.WriteLine($"I met {userName} at a bridal show. {userName} has chosen {wedColor} as her wedding colors. She is getting marrid at {wedVenue}. The guest count is {wedGuest}. {userName}'s wedding budget is {wedBudget}. {userName} describes herself as {selfdef}. I will refer her to another planner.");
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
            }
        
        static void Main(string[] args)
        {
          //Madlib();
          //Console.WriteLine(Add(2,4));
          //int addedNums = Add (2, 4);
          //Console.WriteLine(Subtract(10, 2));
          //Console.WriteLine(Multiply(10, 2));
          //Console.WriteLine(Divide(20, 10));
          //Console.WriteLine(Sum(1, 1, 1, 1, 1));
          Practice();
          
          
          



        }
    }
}
