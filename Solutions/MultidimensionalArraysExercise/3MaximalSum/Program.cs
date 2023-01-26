using System.Globalization;

int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rows = size[0];
int cols = size[1];

int[,] matrix = new int[rows,cols];

for (int i = 0; i < rows; i++)
{
    int[] colData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
	for (int j = 0; j < cols; j++)
	{
		matrix[i, j] = colData[j];
	}
}

int maxSum = int.MinValue;
int maxRow = int.MinValue;
int maxCol = int.MinValue;

for (int i = 0; i < rows; i++)
{
	for (int j = 0; j < cols; j++)
	{
		if(i > rows - 3 || j > cols - 3)
		{
			continue;
		}
        int currSum = 0;
        for (int x = i; x < i + 3; x++)
        {
            for (int y = j; y < j + 3; y++)
            {
                currSum += matrix[x, y];
            }
        }
        if (currSum > maxSum)
        {
            maxSum = currSum;
            maxRow = i;
            maxCol = j;
        }
	}
}

Console.WriteLine($"Sum = {maxSum}");
for (int i = maxRow; i < maxRow + 3; i++)
{
    for (int j = maxCol; j < maxCol + 3; j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}