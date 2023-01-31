namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
            
        {
            Console.WriteLine("Exercise 1");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite hockey team?");
            string team = Console.ReadLine();
            Console.WriteLine("Who is your best friend?");
            string friend = Console.ReadLine();
            Console.WriteLine("Where is your favorite place to visit?");
            string place = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"Cool name {name}, I see that the {team} is your favorite hockey team but I don't like hockey." +
                $"\nI'll go to {place} while you hang out with your buddy {friend} in hockey land. Later alligator!");
            Console.WriteLine();

            Console.WriteLine("Exercise 2");
            int answer1 = Methods.Add(2, 2);
            Console.WriteLine(answer1);
            int answer2 = Methods.Sub(10, 5);
            Console.WriteLine(answer2);
            int answer3 = Methods.Multiply(13, 28);
            Console.WriteLine(answer3);
            int answer4 = Methods.Divide(1026, 30);
            Console.WriteLine(answer4);
        }

        
    }
}
