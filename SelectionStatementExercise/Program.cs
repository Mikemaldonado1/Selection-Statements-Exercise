namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            var r = new Random();
            var favNumber = r.Next(1, 100);

            //var favNumber = 5;

            Console.WriteLine("Enter your guess for my favorite number (1-100) ");

            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("Too Low");

            }

            else if (userInput > favNumber)
            {

                Console.WriteLine("Too High");

            }

            else
            {

                Console.WriteLine("You guessed it!!!");
            }

            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------------------------");


            Console.WriteLine("What is your favorite subject in school? ");
            var subAnswer = Console.ReadLine();

            switch (subAnswer)
            {
                case "Mathmatics":
                    Console.WriteLine("Mathmatics is a great subject!");
                    break;

                case "English":
                    Console.WriteLine("English is a great subject");
                    break;

                case "Psychology":
                    Console.WriteLine("Psychology is a great subject");
                    break;

                case "Spanish":
                    Console.WriteLine("Spanish is a great subject");
                    break;

                case "History":
                    Console.WriteLine("History is a great subject");
                    break;

                default:
                    Console.WriteLine("That is an invalid input");
                    break;
            }
        }
    }
}
