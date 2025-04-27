
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
        string distinct = new string(n.Distinct().ToArray());
        if (distinct.Length % 2 == 0)
        {
            Console.WriteLine("CHAT WITH HER!");
        }
        else
        {
            Console.WriteLine("IGNORE HIM!");
        }
    }
}

