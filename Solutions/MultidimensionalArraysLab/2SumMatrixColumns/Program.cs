int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int rows = size[0];
int cols = size[1];

int[,] matrix = new int[rows, cols];

for(int i = 0;i < rows; i++)
{
	int[] colData = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

	for (int j = 0; j < cols; j++)
	{
		matrix[i, j] = colData[j];
	}
}

for (int i = 0; i < matrix.GetLength(1); i++)
{
	int tempSum = 0;
	for (int j = 0; j < matrix.GetLength(0); j++)
	{
		tempSum += matrix[j, i];
	}
	Console.WriteLine(tempSum);
}