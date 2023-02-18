int[] dimensions = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int rows = dimensions[0];
int cols = dimensions[1];

char[,] matrix = new char[rows, cols];

int startY = 0;
int startX = 0;

int totalOpponents = 0;

for (int i = 0; i < rows; i++)
{
    char[] colData = Console.ReadLine()
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .Select(char.Parse)
        .ToArray();

    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = colData[j];

        if (matrix[i, j] == 'B')
        {
            startY = i;
            startX = j;
        }

        if (matrix[i, j] == 'P')
        {
            totalOpponents++;
        }
    }
}

string input = Console.ReadLine();

int touchedOpponents = 0;
int movesMade = 0;

while(input != "Finish")
{
    if(input == "left" && startX - 1 >= 0)
    {
        if(matrix[startY, startX - 1] == '-')
        {
            matrix[startY, startX] = '-';
            startX--;
            matrix[startY, startX] = 'B';
            movesMade++;
        }
        else if(matrix[startY, startX - 1] == 'P')
        {
            matrix[startY, startX] = '-';
            startX--;
            matrix[startY, startX] = 'B';
            touchedOpponents++;
            movesMade++;
        }
    }
    else if (input == "right" && startX + 1 < cols)
    {
        if (matrix[startY, startX + 1] == '-')
        {
            matrix[startY, startX] = '-';
            startX++;
            matrix[startY, startX] = 'B';
            movesMade++;
        }
        else if (matrix[startY, startX + 1] == 'P')
        {
            matrix[startY, startX] = '-';
            startX++;
            matrix[startY, startX] = 'B';
            touchedOpponents++;
            movesMade++;
        }
    }
    if (input == "up" && startY - 1 >= 0)
    {
        if (matrix[startY - 1, startX] == '-')
        {
            matrix[startY, startX] = '-';
            startY--;
            matrix[startY, startX] = 'B';
            movesMade++;
        }
        else if (matrix[startY - 1, startX] == 'P')
        {
            matrix[startY, startX] = '-';
            startY--;
            matrix[startY, startX] = 'B';
            touchedOpponents++;
            movesMade++;
        }
    }
    if (input == "down" && startY + 1 < rows)
    {
        if (matrix[startY + 1, startX] == '-')
        {
            matrix[startY, startX] = '-';
            startY++;
            matrix[startY, startX] = 'B';
            movesMade++;
        }
        else if (matrix[startY + 1, startX] == 'P')
        {
            matrix[startY, startX] = '-';
            startY++;
            matrix[startY, startX] = 'B';
            touchedOpponents++;
            movesMade++;
        }
    }

    if(touchedOpponents == totalOpponents)
    {
        break;
    }

    input = Console.ReadLine();
}

Console.WriteLine("Game over!");
Console.WriteLine($"Touched opponents: {touchedOpponents} Moves made: {movesMade}");
