class Program
{
    static void Main()
    {
        var inp = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
        var multiply = inp[0] * inp[1];
        var result = 0;
        while (true)
        {
            if (multiply % 2 == 0)
            {
                multiply /= 2;
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
