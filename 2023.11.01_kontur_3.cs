class Program // Завал после 20+ тестов
{
    static void Main()
    {
        int valueLastUnderArray = 0;
        var numberOfPallets = uint.Parse(Console.ReadLine());
        var array = new int[numberOfPallets][];
        for (int i = 0; i < numberOfPallets; i++)
        {
            var tempArray = Console.ReadLine().Split(" ");
            var numberOfBox = int.Parse(tempArray[0]);
            var lastValueTempArray = int.Parse(tempArray[numberOfBox]);
            array[i] = new int[numberOfBox];
            var solveOfReverse = 0;
            var solveOfReversePermanentBan = 0;
            for (int j = 0; j < numberOfBox; j++)
            {
                array[i][j] = int.Parse(tempArray[j + 1]);
                if (j != 0 && array[i][j] < array[i][j - 1])
                {
                    solveOfReverse += 1;
                    if (array[i][j] != lastValueTempArray && array[i][j] < lastValueTempArray)
                    {
                        solveOfReversePermanentBan += 1;
                    }
                }
                else if (j != 0 && array[i][j] != lastValueTempArray && array[i][j] > array[i][j - 1] &&
                         array[i][j] > lastValueTempArray)
                {
                    Console.WriteLine(-1);
                    return;
                }
            }
            if (solveOfReverse >= 1)
                Array.Reverse(array[i]);
            if (solveOfReversePermanentBan >= 1)
            {
                Console.WriteLine(-1);
                return;
            }

            if (i != 0 && valueLastUnderArray > array[i][0])
            {
                Console.WriteLine(-1);
                return;
            }
            valueLastUnderArray = array[i][numberOfBox - 1];
        }
        foreach (var underArray in array)
        {
            foreach (var element in underArray)
            {
                Console.Write($"{element} ");
            }
        }
    }
}
