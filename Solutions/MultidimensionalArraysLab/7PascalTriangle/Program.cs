using System.Numerics;

int n = int.Parse(Console.ReadLine());

BigInteger[][] matrix = new BigInteger[n][];

for (int i = 0;i < n; i++)
{
    matrix[i] = new BigInteger[i + 1];
    for (int j = 0; j < i + 1; j++)
	{
		if (j == 0 || j == i)
		{
			matrix[i][j] = 1;
		}
		else
		{
			matrix[i][j] = matrix[i - 1][j - 1] + matrix[i - 1][j];
		}
	}
}

foreach (var array in matrix)
{
	Console.WriteLine(String.Join(" ", array));
}