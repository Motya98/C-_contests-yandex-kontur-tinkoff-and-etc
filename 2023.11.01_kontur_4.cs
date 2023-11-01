class Program
{
    static void Main()
    {
        var result = new HashSet<int>();
        var len = int.Parse(Console.ReadLine());
        for (var i = 0; i < len; i++)
        {
            var arrayTemp = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            var startValue = arrayTemp[0];
            var endValue = arrayTemp[1] + 1;
            var arrayLength = endValue - startValue;
            var array = new int[arrayLength];
            var iterator = 0;
            for (var j = startValue; j < endValue; j++)
            {
                array[iterator] = j;
                iterator += 1;
            }
            result.UnionWith(array);
        }
        Console.WriteLine(result.Count);
    }
}
