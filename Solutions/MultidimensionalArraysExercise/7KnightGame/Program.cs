int n = int.Parse(Console.ReadLine());

char[,] matrix = new char[n,n];

for (int i = 0;i < n; i++)
{
    char[] colData = Console.ReadLine().ToCharArray();

	for (int j = 0; j < n; j++)
	{
		matrix[i, j] = colData[j];
	}
}

int toRemove = 0;

while (true)
{
	bool isSafe = true;
	int maxDanger = 0;
	int maxRow = int.MinValue;
	int maxCol = int.MaxValue;
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < n; j++)
		{
			if (matrix[i, j] == 'K')
			{
				var rowSign = new List<char>() 
				{ 
					'+', '+', '-', '-', '+', '+', '-', '-' 
				};
				var colSign = new List<char>() 
				{ 
					'+', '-', '+', '-', '+', '-', '+', '-'
				};

				var listAdd = new List<int>() { 2, 2, 2, 2, 1, 1, 1, 1 };

				int currDanger = 0;

                for (int x = 0; x < listAdd.Count; x++)
				{
					int newRow = i;
					int newCol = j;

					if (rowSign[x] == '+')
					{
						newRow += listAdd[x];
					}
					else
					{
						newRow -= listAdd[x];
					}

					if(newRow < 0 || newRow >= n)
					{
						continue;
					}

					if (colSign[x] == '+') 
					{ 
						newCol += listAdd[listAdd.Count - 1 - x];
					}
					else
					{
                        newCol -= listAdd[listAdd.Count - 1 - x];
                    }

					if(newCol < 0 || newCol >= n)
					{
						continue;
					}

					if (matrix[newRow, newCol] == 'K')
					{
						isSafe = false;
						currDanger++;
					}
                }

				if(maxDanger < currDanger)
				{
					maxDanger = currDanger;
					maxRow = i;
					maxCol = j;
				}
			}
		}
	}
	if(isSafe)
	{
		break;
	}
	else
	{
        matrix[maxRow, maxCol] = '0';
		toRemove++;
    }
}

Console.WriteLine(toRemove);