using System.Security.Cryptography;

int n = int.Parse(Console.ReadLine());

char[,] matrix = new char[n, n];

string racingNum = Console.ReadLine();

for (int i = 0; i < n; i++)
{
	char[] colData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select  (char.Parse).ToArray();

	for (int j = 0; j < n; j++)
	{
		matrix[i, j] = colData[j];
	}
}

int startX = 0;
int startY = 0;

matrix[startX, startY] = 'C';

int kilometres = 0;

string dir = Console.ReadLine();

while(dir != "End")
{
	if(dir == "up")
	{
        if (matrix[startX - 1, startY] == '.')
		{
			kilometres += 10;
			matrix[startX, startY] = '.';
			startX--;
			matrix[startX, startY] = 'C';
		}
        else if (matrix[startX - 1, startY] == 'T')
        {
            kilometres += 30;
            matrix[startX, startY] = '.';
            matrix[startX - 1, startY] = '.';
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == 'T')
                    {
                        matrix[i, j] = 'C';
                        startX = i;
                        startY = j;
                        continue;
                    }
                }
            }
        }
        else if (matrix[startX - 1, startY] == 'F')
        {
            matrix[startX, startY] = '.';
            startX--;
            matrix[startX, startY] = 'C';
            kilometres += 10;
            break;
        }
	}
	else if(dir == "down")
	{
        if (matrix[startX + 1, startY] == '.')
        {
            kilometres += 10;
            matrix[startX, startY] = '.';
            startX++;
            matrix[startX, startY] = 'C';
        }
        else if (matrix[startX + 1, startY] == 'T')
        {
            kilometres += 30;
            matrix[startX, startY] = '.';
            matrix[startX + 1, startY] = '.';
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == 'T')
                    {
                        matrix[i, j] = 'C';
                        startX = i;
                        startY = j;
                        continue;
                    }
                }
            }
        }
        else if (matrix[startX + 1, startY] == 'F')
        {
            matrix[startX, startY] = '.';
            startX++;
            matrix[startX, startY] = 'C';
            kilometres += 10;
            break;
        }
    }
	else if(dir == "left")
	{
        if (matrix[startX, startY - 1] == '.')
        {
            kilometres += 10;
            matrix[startX, startY] = '.';
            startY--;
            matrix[startX, startY] = 'C';
        }
        else if (matrix[startX, startY - 1] == 'T')
        {
            kilometres += 30;
            matrix[startX, startY] = '.';
            matrix[startX, startY - 1] = '.';
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == 'T')
                    {
                        matrix[i, j] = 'C';
                        startX = i;
                        startY = j;
                        continue;
                    }
                }
            }
        }
        else if (matrix[startX, startY - 1] == 'F')
        {
            matrix[startX, startY] = '.';
            startY--;
            matrix[startX, startY] = 'C';
            kilometres += 10;
            break;
        }
    }
	else if(dir == "right")
	{
        if (matrix[startX, startY + 1] == '.')
        {
            kilometres += 10;
            matrix[startX, startY] = '.';
            startY++;
            matrix[startX, startY] = 'C';
        }
        else if (matrix[startX, startY + 1] == 'T')
        {
            kilometres += 30;
            matrix[startX, startY] = '.';
            matrix[startX, startY + 1] = '.';
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == 'T')
                    {
                        matrix[i, j] = 'C';
                        startX = i;
                        startY = j;
                        continue;
                    }
                }
            }
        }
        else if (matrix[startX, startY + 1] == 'F')
        {
            matrix[startX, startY] = '.';
            startY++;
            matrix[startX, startY] = 'C';
            kilometres += 10;
            break;
        }
    }

    dir = Console.ReadLine();
}

if(dir == "End")
{
    Console.WriteLine($"Racing car {racingNum} DNF.");
}
else
{
    Console.WriteLine($"Racing car {racingNum} finished the stage!");
}

Console.WriteLine($"Distance covered {kilometres} km.");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j]);
    }
    Console.WriteLine();
}