namespace Homework3
{
    public class PrintColor
    {
        public void PrintGreen(string str)
        {
            Console.ForegroundColor = (ConsoleColor)2;
            Console.WriteLine($"Green color row: {str}");
        }
        public void PrintOrange(string str)
        {
            Console.ForegroundColor = (ConsoleColor)6;
            Console.WriteLine($"Orange color row: {str}");
        }
        public void PrintRandom(string str)
        {
            Random rnd = new Random();
            Console.ForegroundColor = (ConsoleColor)rnd.Next(0,15);
            Console.WriteLine($"Random color row: {str}");
        }
    }
}
