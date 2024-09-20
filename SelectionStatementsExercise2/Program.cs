namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            string favoriteSubject = Console.ReadLine();

            switch (favoriteSubject)
            {
                case "Math":
                    Console.WriteLine("Math can be hard good luck!");
                    break;

                case "Science":
                    Console.WriteLine("Science is cool, have fun experimenting.");
                    break;

                case "History":
                    Console.WriteLine("History is filled with lots of interesting stories.");
                    break;

                default:
                    Console.WriteLine("Interesting choice! What do you like about it?");
                    break;

            }
        }
    }
}