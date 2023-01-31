namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
            
        {
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
                $"\n I'll go to {place} while you hang out with your buddy {friend} in hockey land. Later alligator!");
        }
    }
}
