int[] lengths = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int n = lengths[0];
int m = lengths[1];

var set1 = new HashSet<int>();
var set2 = new HashSet<int>();

var shared = new HashSet<int>();

for (int i = 0;i < n; i++)
{
    set1.Add(int.Parse(Console.ReadLine()));
}

for (int i = 0;i < m; i++)
{
    set2.Add(int.Parse(Console.ReadLine()));
}

foreach (var num in set1)
{
    if (set2.Contains(num))
    {
        shared.Add(num);
    }
}

Console.WriteLine(String.Join(" ", shared));
