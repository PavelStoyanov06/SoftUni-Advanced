using System.Runtime.InteropServices;

int rows = int.Parse(Console.ReadLine());

int[][] matrix = new int[rows][];

for(int i = 0;i < rows; i++)
{
    matrix[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
}

string input = Console.ReadLine();

while (input != "END")
{
    string[] cmdArgs = input.Split();
    string cmd = cmdArgs[0];
    int row = int.Parse(cmdArgs[1]);
    int col = int.Parse(cmdArgs[2]);
    int value = int.Parse(cmdArgs[3]);

    if (row < matrix.Length && row > -1)
    {
        if (col < matrix[row].Length && col > -1)
        {
            if(cmd == "Add")
            {
                matrix[row][col] += value;
            }
            else if(cmd == "Subtract")
            {
                matrix[row][col] -= value;
            }
        }
        else
        {
            Console.WriteLine("Invalid coordinates");
        }
    }
    else
    {
        Console.WriteLine("Invalid coordinates");
    }
    input = Console.ReadLine();
}

for (int i = 0; i < matrix.Length; i++)
{
    for (int j = 0; j < matrix[i].Length; j++)
    {
        Console.Write($"{matrix[i][j]} ");
    }
    Console.WriteLine();
}