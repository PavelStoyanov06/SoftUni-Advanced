int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

char[,] matrix = new char[size[0], size[1]];

for (int i = 0; i < size[0]; i++)
{
	char[] colData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
	for (int j = 0; j < size[1]; j++)
	{
		matrix[i, j] = colData[j];
	}
}

int squareCount = 0;

for (int i = 0; i < size[0]; i++)
{
	for (int j = 0; j < size[1]; j++)
    {
        if (i <= size[0] - 2 && j <= size[1] - 2)
        {
            if (matrix[i, j + 1] == matrix[i, j]
                && matrix[i + 1, j] == matrix[i, j]
                && matrix[i + 1, j + 1] == matrix[i, j])
            {
                squareCount++;
            }
        }
    }
}

Console.WriteLine(squareCount);