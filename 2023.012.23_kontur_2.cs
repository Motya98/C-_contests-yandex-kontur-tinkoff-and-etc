class Program // 10/10
{
    public static void Main(string[] args)
    {
        var arrayLength = int.Parse(Console.ReadLine());
        var array = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        var startIndex = 0;
        var endIndex = arrayLength - 1;
        var startSum = array[startIndex];
        var endSum = array[endIndex];
        
        while(startIndex + 1 != endIndex)
        {
            if (startSum >= endSum)
                endSum += array[--endIndex];
            else if (startSum < endSum)
                startSum += array[++startIndex];
        }

        if (startSum == endSum)
        {
            for (var i = 0; i < arrayLength; i++)
            {
                if (i < startIndex || (i > startIndex && i != arrayLength - 1))
                    Console.Write($"{array[i]}+");
                else if(i == startIndex)
                    Console.Write($"{array[i]}=");
                else
                    Console.Write(array[i]);
            }
        }
        else
            Console.WriteLine(-1);
    }
}

/*
5
8 1 1 5 5
*/
