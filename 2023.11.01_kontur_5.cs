class Program // Завал после 20+ тестов
{
    static void Main()
    {
        var lengthN = int.Parse(Console.ReadLine());
        var arrayN = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
        var lengthM = int.Parse(Console.ReadLine());
        var arrayM = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
        var startIndexN = 0;
        var startIndexM = 0;
        var listTemp = new List<int>();
        var listResult = new List<int>();

        while(startIndexN < lengthN && startIndexM < lengthM)
        {
            if (arrayN[startIndexN] == arrayM[startIndexM])
            {
                listTemp.Add(arrayN[startIndexN]);
                ++startIndexM;
                ++startIndexN;
            }
            else
            {
                if (listTemp.Count > listResult.Count)
                {
                    listResult.Clear();
                    listResult = listTemp.ToList();
                    listTemp.Clear();
                }
                else if (listTemp.Count != 0)
                {
                    listTemp.Clear();
                }

                var stopMachine = 0;
                while (startIndexN + 1 < lengthN && startIndexM + 1 < lengthM && arrayN[startIndexN + 1] != arrayM[startIndexM + 1])
                {
                    if (arrayN[startIndexN + 1] > arrayM[startIndexM + 1])
                        ++startIndexM;
                    else
                        ++startIndexN;
                    ++stopMachine;
                }

                if (stopMachine == 0)
                {
                    ++startIndexN;
                    ++startIndexM;
                }
            }
        }

        if (listTemp.Count > listResult.Count)
            listResult = listTemp;
        Console.WriteLine(listResult.Count);
        foreach (var r in listResult)
        {
            Console.Write($"{r} ");
        }
    }
}


/*
6
1 2 4 5 6 7
5
1 3 4 5 6

3
1 2 3
3
1 2 3

3
1 2 3
3
1 2 4

2
4 5
2
3 6

5
1 2 4 5 8
6
1 2 4 4 4 8

5
1 2 4 4 8
6
1 2 4 4 4 8

5
1 2 3 30 31
5
7 8 9 30 35
*/
