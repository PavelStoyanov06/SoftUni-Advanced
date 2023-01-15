int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int rows = size[0];
int cols = size[1];

int[,] matrix = new int[rows, cols];

for(int i = 0;i < rows; i++)
{
	int[] colData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

	for (int j = 0; j < cols; j++)
	{
		matrix[i,j] = colData[j];
	}
}

int maxSum = int.MinValue;
int maxRow = int.MinValue;
int maxCol = int.MinValue;
for(int i = 0;i < rows; i++)
{	
	for (int j = 0; j < cols; j++)
	{
        int currSum = 0;
        if (i >= rows - 1 || j >= cols - 1)
		{
			continue;
		}

		currSum += matrix[i,j];
		currSum += matrix[i + 1, j];
		currSum += matrix[i, j + 1];
		currSum += matrix[i + 1, j + 1];

		if(currSum > maxSum)
		{
			maxSum = currSum;
			maxRow = i;
			maxCol = j;
		}
	}
}

Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]}");
Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]}");
Console.WriteLine(maxSum);