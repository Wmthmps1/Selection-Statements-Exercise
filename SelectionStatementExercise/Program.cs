namespace SelectionStatementExercise
{
    public class Program
    {
        public static void GuessChecker(int myNumber, int userNumber){

            if (userNumber < myNumber)
            {
                Console.WriteLine("too low");
            }
            else if (userNumber > myNumber)
            {
                Console.WriteLine("too high");
            }
            else // userNumber == myNumber
            {
                Console.WriteLine("You Guessed it!!!!");
            }

         }


        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            // Uncomment to easily test.
            // Console.WriteLine(favNumber);

            Console.WriteLine("Guess what my favorite number is: ");
            Console.WriteLine("Guess a number between 1-1000");
            var userInput = int.Parse(Console.ReadLine());

            GuessChecker(favNumber,userInput);
        }
    }
}
