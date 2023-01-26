int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[n,n];

for (int i = 0;i < n; i++)
{
    int[] colData = Console.ReadLine().Split().Select(int.Parse).ToArray();
	for (int j = 0; j < n; j++)
	{
		matrix[i,j] = colData[j];
	}
}

int sumDiag1 = 0;
int sumDiag2 = 0;

for (int i = 0;i < n; i++)
{
	sumDiag1 += matrix[i,i];
	sumDiag2 += matrix[ n - 1 - i, i];
}

Console.WriteLine(Math.Abs(sumDiag2 - sumDiag1));