int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int rows = size[0];
int cols = size[1];

int[,] matrix = new int[rows, cols];
int sum = 0;
for (int i = 0;i < rows; i++)
{
	int[] colData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray()
;
	for (int j = 0; j < cols; j++)
	{
		matrix[i, j] = colData[j];
	}

	sum += colData.Sum();
}

Console.WriteLine(matrix.GetLength(0));
Console.WriteLine(matrix.GetLength(1));
Console.WriteLine(sum);
