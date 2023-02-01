
var counts = new Dictionary<double, int>();

double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();


for (int i = 0; i < input.Length; i++)
{
    if (counts.ContainsKey(input[i]))
    {
        counts[input[i]]++;
        continue;
    }
    counts.Add(input[i], 1);
}

foreach (var item in counts)
{
    Console.WriteLine($"{item.Key} - {item.Value} times");
}

