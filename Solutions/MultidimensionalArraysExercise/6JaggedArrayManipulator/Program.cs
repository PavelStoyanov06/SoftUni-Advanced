int n = int.Parse(Console.ReadLine());

int[][] matrix = new int[n][];

for (int i = 0;i < n; i++)
{
    matrix[i] = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
}

for (int i = 0; i < n - 1; i++)
{
    if (matrix[i].Length == matrix[i + 1].Length)
    {
        for (int j = 0; j < matrix[i].Length; j++)
        {
            matrix[i][j] *= 2;
            matrix[i + 1][j] *= 2;
        }
    }
    else
    {
        for (int j = 0; j < Math.Max(matrix[i].Length, matrix[i + 1].Length); j++)
        {
            if(j < matrix[i].Length)
            {
                matrix[i][j] /= 2;
            }
            if(j < matrix[i + 1].Length)
            {
                matrix[i + 1][j] /= 2;
            }
        }
    }
}

string input = Console.ReadLine();

while(input != "End")
{
    string[] cmdArgs = input.Split();
    string cmd = cmdArgs[0];
    int row = int.Parse(cmdArgs[1]);
    int col = int.Parse(cmdArgs[2]);
    if (row < 0 || row >= matrix.Length)
    {
        input = Console.ReadLine();
        continue;
    }else if (col >= matrix[row].Length || col < 0)
    {
        input = Console.ReadLine();
        continue;
    }
    int value = int.Parse(cmdArgs[3]);

    if(cmd == "Add")
    {
        matrix[row][col] += value;
    }
    else if(cmd == "Subtract")
    {
        matrix[row][col] -= value;
    }
    input = Console.ReadLine();
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < matrix[i].Length; j++)
    {
        Console.Write($"{matrix[i][j]} ");
    }
    Console.WriteLine();
}
