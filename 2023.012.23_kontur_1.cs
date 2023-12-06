class Program // 10/10
{
    public static void Main(string[] args)
    {
        var inp = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        var n = inp[0];
        var m = inp[1];
        if (n == m)
            Console.WriteLine(n + m * 2);
        else if (n > m)
            Console.WriteLine(m + 1 + m * 2);
        else
            Console.WriteLine(n + (n + 1) * 2);
    }
}
