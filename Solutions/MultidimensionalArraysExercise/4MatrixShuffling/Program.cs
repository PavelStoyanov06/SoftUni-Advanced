int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rows = size[0];
int cols = size[1];

string[,] matrix = new string[rows, cols];

for (int i = 0;i < rows; i++)
{
    string[] colData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
	for (int j = 0; j < cols; j++)
	{
		matrix[i, j] = colData[j];
	}
}

string input = Console.ReadLine();

while (input != "END")
{
	string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
	string cmd = cmdArgs[0];

	if(cmd != "swap" || cmdArgs.Length > 5 || cmdArgs.Length < 5)
	{
		Console.WriteLine("Invalid input!");
		input = Console.ReadLine();
		continue;
	} 
	
	int row1 = int.Parse(cmdArgs[1]);
	int col1 = int.Parse(cmdArgs[2]);
	int row2 = int.Parse(cmdArgs[3]);
	int col2 = int.Parse(cmdArgs[4]);

	if(row1 >= matrix.GetLength(0) || row1 < 0 || col1 >= matrix.GetLength(1) || col1 < 0 
		|| row2 >= matrix.GetLength(0) || row2 < 0 || col2 >= matrix.GetLength(1) || col2 < 0)
	{
		Console.WriteLine("Invalid input!");
		input = Console.ReadLine();
		continue;
	}

	string temp = matrix[row1, col1];
	matrix[row1, col1] = matrix[row2, col2];
	matrix[row2, col2] = temp;

	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			Console.Write($"{matrix[i, j]} ");
		}
		Console.WriteLine();
	}

	input = Console.ReadLine();
}
