
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
        if (arr.Length != 3)
        {
            Console.WriteLine("Invalid input");
            return;
        }
        int costOfBananna = int.Parse(arr[0]);
        int soldierDollar = int.Parse(arr[1]);
        int numberOfBananna = int.Parse(arr[2]);
        if (costOfBananna < 0 || soldierDollar < 0 || numberOfBananna < 0)
        {
            Console.WriteLine("Invalid input");
            return;
        }
        int priceOfBananna = 0;
        for (int i = 1; i <= numberOfBananna; i++)
        {
            priceOfBananna += i * costOfBananna;
        }
        if (priceOfBananna > soldierDollar)
        {
            Console.WriteLine(priceOfBananna - soldierDollar);
        }
        else
        {
            Console.WriteLine(0);
        }

    }
}

