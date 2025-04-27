
public class Program
{

    static void Main(string[] args)
    {
        string? n = Console.ReadLine();
        if (string.IsNullOrEmpty(n))
        {
            Console.WriteLine("Input cannot be null or empty");
            return;

        }
        int number = int.Parse(n);
        if (number < 0)
        {
            Console.WriteLine("Input cannot be negative");
            return;
        }
        int count = 0;
        for (int i = 1; i <= number; i++)
        {
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input cannot be null or empty");
                return;
            }
            if (input == "++X" || input == "X++")
            {
                count++;
            }
            else if (input == "--X" || input == "X--")
            {
                count--;
            }
            else
            {
                Console.WriteLine("Invalid operation");
                return;
            }
        }
        Console.WriteLine(count);
    }
}

