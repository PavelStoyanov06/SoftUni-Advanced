int n = int.Parse(Console.ReadLine());

var wardrobe = new Dictionary<string, Dictionary<string, int>>();

for (int i = 0; i < n; i++)
{
    string[] cmdArgs = Console.ReadLine().Split(" -> ");
    string color = cmdArgs[0];
    if (!wardrobe.ContainsKey(color))
    {
        wardrobe.Add(color, new Dictionary<string, int>());
    }
    string[] items = cmdArgs[1].Split(",");
    for (int j = 0; j < items.Length; j++)
    {
        if (!wardrobe[color].ContainsKey(items[j]))
        {
            wardrobe[color].Add(items[j], 0);
        }
        wardrobe[color][items[j]]++;
    }
}

string[] req = Console.ReadLine().Split();

string col = req[0];
string it = req[1];

foreach (var color in wardrobe)
{
    Console.WriteLine($"{color.Key} clothes:");
    foreach (var item in color.Value)
    {
        if (col == color.Key && it == item.Key)
        {
            Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
        }
        else
        {
            Console.WriteLine($"* {item.Key} - {item.Value}");
        }
    }
}