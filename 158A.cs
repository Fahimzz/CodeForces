
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
        string[] arr = n.Split(' ');
        if (arr.Length != 2)
        {
            Console.WriteLine("Input must contain exactly two integers");
            return;
        }
        int a = int.Parse(arr[0]);
        int b = int.Parse(arr[1]);
        string? s = Console.ReadLine();
        if (string.IsNullOrEmpty(s))
        {
            Console.WriteLine("Input cannot be null or empty");
            return;
        }
        string[] arr2 = s.Split(' ');
        if (arr2.Length != a)
        {
            Console.WriteLine("Input must contain exactly two integers");
            return;
        }
        int count = 0;
        for (int i = 0; i < arr2.Length; i++)
        {
            if (int.Parse(arr2[i]) <= 0)
            {
                continue;
            }
            if (int.Parse(arr2[i]) >= int.Parse(arr2[b - 1]))
            {
                count++;
            }
        }

        Console.WriteLine(count);

    }
}

