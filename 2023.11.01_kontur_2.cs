class Program // Завал после 20+ тестов
{
    static void Main()
    {
        var arrayLength = int.Parse(Console.ReadLine());
        var array = Console.ReadLine().ToArray();
        var startSpanIndex = 0;
        var endSpanIndex = arrayLength - 1;
        bool controlExistOne = false;
        for (var i = 0; i < array.Length; i++)
        {
            if (array[i] == '0')
                startSpanIndex += 1;
            else
            {
                controlExistOne = true;
                break;
            }
        }
        for (var i = endSpanIndex; i > 0; i--)
        {
            if (array[i] == '1')
            {
                endSpanIndex -= 1;
                if (i == 1)
                    controlExistOne = true;
            }
            else
                break;
        }
        var arraySpanLenght = endSpanIndex - startSpanIndex + 1;
        ReadOnlySpan<char> arraySpanMiddle = array.AsSpan().Slice(startSpanIndex, arraySpanLenght);
        var countNollInSpan = 0;
        var counOneInSpan = 0;
        foreach (var i in arraySpanMiddle)
        {
            if (i == '0')
                countNollInSpan += 1;
            else
                counOneInSpan += 1;
        }

        if (controlExistOne == true)
        {
            if (countNollInSpan <= counOneInSpan)
                Console.WriteLine(countNollInSpan);
            else
                Console.WriteLine(counOneInSpan);
        }
        else
            Console.WriteLine(0);
    }
}
