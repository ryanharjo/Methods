namespace Methods_Harjo_Ryan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to input two whole numbers
            Console.WriteLine("Please enter a whole number");
            int x = Convert.ToInt32(Console.ReadLine());  // Convert input to an integer
            Console.WriteLine("Please enter another whole numer");  
            int y = Convert.ToInt32(Console.ReadLine());  // Convert input to an integer
            
            // Multiply the two numbers and display the result
            Console.WriteLine(Multiply(x, y));
            // Ask for the user's name
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine(); // Get user input for name
            
            // Welcome the user
            WelcomeUser(name);
            // Say goodbye to the user
            Goodbye();
        }
        // Multiply method that returns the product of two numbers
        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        // WelcomeUser method that greets the user by name
        static void WelcomeUser(string username)
        {
            Console.WriteLine($"Hello, {username} It is nice to meet you.");
        }
        // Goodbye method that says a farewell message
        static void Goodbye()
        {
            Console.WriteLine("Have a fantastic day!");
        }
    }
}
