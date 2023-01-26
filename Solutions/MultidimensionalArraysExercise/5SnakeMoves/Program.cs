using System.Text;

int[] size = 
    Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
    .ToArray();

int rows = size[0];
int cols = size[1];

char[,] matrix = new char[rows, cols];

char[] snake = Console.ReadLine().ToCharArray();

Queue<char> snakeQueue = new Queue<char>(snake);

for (int i = 0; i < rows; i++)
{
    if(i % 2 == 0)
    {
        for (int j = 0; j < cols; j++)
        {
            if(snakeQueue.Count > 0)
            {
                matrix[i, j] = snakeQueue.Dequeue();
            }
            else
            {
                snakeQueue = new Queue<char>(snake);
                matrix[i, j] = snakeQueue.Dequeue();
            }
        }
    }
    else
    {
        for (int j = cols - 1; j >= 0; j--)
        {
            if(snakeQueue.Count > 0)
            {
                matrix[i, j] = snakeQueue.Dequeue();
            }
            else
            {
                snakeQueue = new Queue<char>(snake);
                matrix[i, j] = snakeQueue.Dequeue();
            }
        }
    }
}

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write($"{matrix[i, j]}");
    }
    Console.WriteLine();
}