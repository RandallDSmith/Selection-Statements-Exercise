namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            
            Console.WriteLine("Try to guess my favorite number");

            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("To Low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too High");
            }
            else if (userInput == favNumber)
            {
                Console.WriteLine("Great Guess!");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }

            Console.WriteLine($"Nice try, my favorite number was {favNumber}");
        }
    }
}
