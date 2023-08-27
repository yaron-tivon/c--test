namespace ReadChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c1;
            Console.WriteLine("Enter a char:");
            c1 = char.Parse(Console.ReadLine());
            Console.WriteLine($"{c1}{c1}{c1}");
        }
    }
}