int[] numbers = Console.ReadLine()
    .Split(", ")
    .Select(Parse)
    .ToArray();

int Parse (string str)
{
    return int.Parse(str);
}

int sumOfNumbers = numbers.Sum();
int countOfNumbers = numbers.Length;

Console.WriteLine(countOfNumbers);
Console.WriteLine(sumOfNumbers);
