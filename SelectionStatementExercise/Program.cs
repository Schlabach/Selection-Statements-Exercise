namespace SelectionStatementExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my favorite number");

            var r = new Random();
            var favNumber = r.Next(1,1000);
            var userInput = int.Parse(Console.ReadLine());	
			
			
                if(userInput < favNumber)
                {
                    Console.WriteLine($"Too Low");
                }
                else if(userInput == favNumber)
                {
                    Console.WriteLine($"Correct!");
                }
                else if(userInput > favNumber)
                {
                    Console.WriteLine($"Too High");
                }
                else
                {
                    Console.WriteLine($"Nevermind");
                }
        }
    }
}