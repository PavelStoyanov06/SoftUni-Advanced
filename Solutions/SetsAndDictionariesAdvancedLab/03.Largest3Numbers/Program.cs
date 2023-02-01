int[] input = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

input = input.OrderByDescending(x => x).ToArray();

if (input.Length < 3)
{
    Console.WriteLine(String.Join(" ", input)); 
}
else
{
    for (int i = 0; i < 3; i++)
    {
        Console.Write(input[i] + " ");
    }
}

