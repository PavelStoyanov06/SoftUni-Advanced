int fieldSize = int.Parse(Console.ReadLine());

string[] commands = Console.ReadLine()
	.Split();

char[,] field = new char[fieldSize, fieldSize];

int numCoals = 0;

int minerX = -1;
int minerY = -1;

for(int row = 0;row < fieldSize; row++)
{
    char[] colData = Console.ReadLine()
		.Split()
		.Select(char.Parse)
		.ToArray();

	for (int col = 0; col < fieldSize; col++)
	{
		field[row, col] = colData[col];

		if (field[row, col] == 'c')
		{
			numCoals++;
		}

		if (field[row, col] == 's')
		{
			minerX = col;
			minerY = row;
		}
	}
}

bool usedAllMoves = true;

foreach (var command in commands)
{
	if (command == "up")
	{
		if (minerY - 1 >= 0)
		{
            field[minerY, minerX] = '*';
            minerY--;
            if (isGameOver(field, minerY, minerX, ref numCoals))
            {
				usedAllMoves = false;
                break;
            }

            field[minerY, minerX] = 's';
        }
	}
	else if (command == "down")
	{
		if (minerY + 1 < fieldSize)
		{
            field[minerY, minerX] = '*';
            minerY++;
            if (isGameOver(field, minerY, minerX, ref numCoals))
            {
				usedAllMoves = false;
                break;
            }

            field[minerY, minerX] = 's';
        }
	}
	else if (command == "left")
	{
		if (minerX - 1 >= 0)
		{
            field[minerY, minerX] = '*';
			minerX--;
            if (isGameOver(field, minerY, minerX, ref numCoals))
            {
				usedAllMoves = false;
                break;
            }

            field[minerY, minerX] = 's';
        }
	}
	else if (command == "right")
	{
		if (minerX + 1 < fieldSize)
		{
            field[minerY, minerX] = '*';
            minerX++;
            if (isGameOver(field, minerY, minerX, ref numCoals))
            {
				usedAllMoves = false;
                break;
            }

            field[minerY, minerX] = 's';
        }
	}
}

if (usedAllMoves)
{
	Console.WriteLine($"{numCoals} coals left. ({minerY}, {minerX})");
}


static bool isGameOver(char[,] matrix, int row, int col, ref int numCoals)
{
	if (matrix[row, col] == 'c')
	{
		numCoals--;
		if(numCoals <= 0)
		{
			Console.WriteLine($"You collected all coals! ({row}, {col})");
			return true;
		}
	}

	if (matrix[row, col] == 'e')
	{
		Console.WriteLine($"Game over! ({row}, {col})");
		return true;
	}

	return false;
}

