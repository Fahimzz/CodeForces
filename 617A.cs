
public class Program
{
    public int count = 0;
    public int NumberOfStep(int n)
    {
        if (n == 0)
            return count;

        if (n >= 5)
        {
            count++;
            return NumberOfStep(n - 5);
        }
        else if (n >= 4)
        {
            count++;
            return NumberOfStep(n - 4);
        }
        else if (n >= 3)
        {
            count++;
            return NumberOfStep(n - 3);
        }
        else if (n >= 2)
        {
            count++;
            return NumberOfStep(n - 2);
        }
        else if (n >= 1)
        {
            count++;
            return NumberOfStep(n - 1);
        }

        return count;

    }

    static void Main(string[] args)
    {
        string? n = Console.ReadLine();
        if (string.IsNullOrEmpty(n))
        {
            Console.WriteLine("Input cannot be null or empty");
            return;

        }
        int num = int.Parse(n);
        Program program = new Program();
        int result = program.NumberOfStep(num);
        Console.WriteLine(result);
    }
}

