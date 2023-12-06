class Program // зубчатый массив, возможно, был бы чуть быстрее многомерного. 5/10
{
    public static void Main(string[] args)
    {
        var inpRowColumnTable = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        var rowTable = inpRowColumnTable[0];
        var columnTable = inpRowColumnTable[1];
        var table = new int[rowTable, columnTable];
        var iteration = int.Parse(Console.ReadLine());
        
        for (var i = 0; i < iteration; i++)
        {
            var inpXYC = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var row = inpXYC[0] - 1;
            var column = inpXYC[1] - 1;
            var color = inpXYC[2];
            
            for (var col = 0; col < columnTable; col++)
                table[row, col] = color;
            
            for (var ro = 0; ro < rowTable; ro++)
                table[ro, column] = color;
        }
        
        for (var k = 0; k < rowTable; k++)
        {
            for (var kk = 0; kk < columnTable; kk++)
                Console.Write($"{table[k, kk]} ");
            
            Console.WriteLine();
        }
    }
}

/*
3 4
1
3 4 4

3 4
2
2 2 4
3 1 1
*/
