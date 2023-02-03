int n = int.Parse(Console.ReadLine());

var numbers = new Dictionary<int, int>();

for(int i = 0;i < n; i++)
{
    int number = int.Parse(Console.ReadLine());
    if (numbers.ContainsKey(number))
    {
        numbers[number]++;
    }
    else
    {
        numbers.Add(number, 1);
    }
}

foreach (var number in numbers)
{
    if(number.Value % 2 == 0)
    {
        Console.WriteLine(number.Key);
        break;
    }
}