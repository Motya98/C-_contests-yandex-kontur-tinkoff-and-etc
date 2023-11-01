class Program
{
    static void Main()
    {
        var inp = Console.ReadLine().Split(" ");
        double multiply = double.Parse(inp[0]) * uint.Parse(inp[1]);
        var result = 0;
        while (true)
        {
            if (multiply % 2 == 0)
            {
                multiply = multiply / 2;
                result++;
            }
            else
            {
                Console.WriteLine(result);
                break;
            }
        }
    }
}
