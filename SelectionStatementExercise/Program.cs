namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var randomNumber = new Random();
            var favNumber = randomNumber.Next(1, 11);

            Console.WriteLine("Try to guess my favorite number between 1 and 10");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine($"Your guess is too low. My favorite number is {favNumber} and not {userInput}");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine($"Your guess is too high. My favorite number is {favNumber} and not {userInput}");
            }
            else
            {
                Console.WriteLine($"You guessed it! My favorite number is {favNumber}");
            }
        }
    }
}
