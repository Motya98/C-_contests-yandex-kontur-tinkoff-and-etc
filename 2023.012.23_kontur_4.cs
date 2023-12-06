class Program
{
    public static void Main(string[] args)
    {
        var result = 1;
        var listResult = new List<char[]>();
        var inp = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
        var lenghtArray = inp[0];
        var actions = inp[1];
        var array = Console.ReadLine().ToArray();
        for (var letter = 0; letter < lenghtArray; letter++)
        {
            var letterCurrent = array[letter];
            for (var index = 0; index <= actions; index++)
            {
                var left = actions - index;
                var right = index;
                var arrayCopyLeft = new char[lenghtArray];
                Array.Copy(array, arrayCopyLeft, lenghtArray);
                
                for (var i = 0; i < left; i++)
                {
                    var k = 1;
                    while (letter - i - k >= 0)
                    {
                        if (arrayCopyLeft[letter - i - k] != letterCurrent)
                        {
                            arrayCopyLeft[letter - i - k] = letterCurrent;
                            break;
                        }
                        k++;
                    }
                }
                listResult.Add(arrayCopyLeft);

                var arrayCopyRight = new char[lenghtArray];
                Array.Copy(array, arrayCopyRight, lenghtArray);
                
                for (var i = 0; i < right; i++)
                {
                    var k = 1;
                    while (letter + i + k < lenghtArray)
                    {
                        if (arrayCopyRight[letter + i + k] != letterCurrent)
                        {
                            arrayCopyRight[letter + i + k] = letterCurrent;
                            break;
                        }
                        k++;
                    }
                }
                listResult.Add(arrayCopyRight);
            }
        }

        foreach (var word in listResult)
        {
            var letterFirst = word[0];
            var tempResult = 1;
            for (var j = 1; j < lenghtArray; j++)
            {
                if (word[j] == letterFirst)
                {
                    tempResult++;
                    if (j == lenghtArray - 1)
                    {
                        if (tempResult > result)
                        {
                            result = tempResult;
                        }
                    }
                }
                else
                {
                    if (tempResult > result)
                    {
                        result = tempResult;
                    }
                    tempResult = 1;
                    letterFirst = word[j];
                }
            }
        }
        
        Console.WriteLine(result);
    }
}


/*
7 2
BRGBBRR
*/
