namespace Methods_Hunt_Shayla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asks user to enter two whole numbers, then saves them to an interger variable.
            Console.WriteLine("Please enter a whole number!");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another whole number!");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Multiply(x,y)); // Calls the Multiply method and passes the two numbers as arguments.

            // Asks user for their name, then saves it to a string variable.
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            WelcomeUser(name); // Calls the WelcomeUser method and passes the name as an argument.

            GoodBye(); // Prints out a fantastic day message to the user.
        }

        /// <summary>
        /// Multiplies two numbers together and returns the result.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        /// <summary>
        /// Prints a greeting to the console.
        /// </summary>
        /// <param name="username"></param>
        static void WelcomeUser(string username)
        {
            Console.WriteLine($"Hello, {username}! It is nice to meet you!");
        }

        /// <summary>
        /// Prints a goodbye message to the console.
        /// </summary>
        static void GoodBye()
        {
            Console.WriteLine("Have a fansatic day!");
        }
    }
}
