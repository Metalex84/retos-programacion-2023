/**
 * El Famoso Fizz Buzz, en una función reutilizable
 * @Metalex84
 *
**/

class Program
{
    static void Main()
    {
		for (int i = 1; i <= 100; i++)
		{
			Console.WriteLine(FizzBuzz(i));
		}
    }

    static string FizzBuzz(int n)
    {
		if (n % 3 == 0 && n % 5 == 0)
		{
			return "FizzBuzz";
		}
		else if (n % 3 == 0)
		{
			return "Fizz";
		}
		else if (n % 5 == 0)
		{
			return "Buzz";
		}
		else
		{
			return n.ToString();
		}
    }
}
