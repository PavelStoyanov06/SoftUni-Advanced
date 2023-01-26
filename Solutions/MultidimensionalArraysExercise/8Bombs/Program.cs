int size = int.Parse(Console.ReadLine());
int[,] matrix = new int[size,size];

for (int row = 0;row < size; row++)
{
	int[] colData = Console.ReadLine()
		.Split()
		.Select(int.Parse)
		.ToArray();

	for (int col = 0; col < size; col++)
	{
		matrix[row, col] = colData[col];
	}
}

string[] bombs = Console.ReadLine()
	.Split(" ", StringSplitOptions.RemoveEmptyEntries)
	.ToArray();

foreach (var bomb in bombs)
{
	int[] bombArgs = bomb
		.Split(",")
		.Select(int.Parse)
		.ToArray();

	int value = matrix[bombArgs[0], bombArgs[1]];

	if(value <= 0)
	{
		continue;
	}

	matrix[bombArgs[0], bombArgs[1]] = 0;

	List<char> rowSign = new List<char>() 
	{ 
		'+', '+', '+', '-', '-', '-', '0', '0'
	};

	List<char> colSign = new List<char>()
	{
		'+', '-', '0', '+', '-', '0', '+', '-'
	};

	for (int i = 0; i < rowSign.Count; i++)
	{
		int bombRow = bombArgs[0];
		int bombCol = bombArgs[1];

		if (rowSign[i] == '+')
		{
			bombRow++;
		}
		else if (rowSign[i] == '-')
		{
			bombRow--;
		}

		if(bombRow < 0 || bombRow >= size)
		{
			continue;
		}

		if (colSign[i] == '+')
		{
			bombCol++;
		}
		else if (colSign[i] == '-')
		{
			bombCol--;
		}

		if(bombCol < 0 || bombCol >= size)
		{
			continue;
		}

		if (matrix[bombRow, bombCol] > 0)
		{
			matrix[bombRow, bombCol] -= value;
		}
	}
}

int aliveCells = 0;
int sum = 0;

for (int row = 0; row < size; row++)
{
	for (int col = 0; col < size; col++)
	{
		if (matrix[row, col] > 0)
		{
			aliveCells++;
			sum += matrix[row, col];
		}
	}
}

Console.WriteLine($"Alive cells: {aliveCells}");
Console.WriteLine($"Sum: {sum}");

for (int row = 0;row < size; row++)
{
	for (int col = 0; col < size; col++)
	{
		Console.Write($"{matrix[row, col]} ");
	}
	Console.WriteLine();
}