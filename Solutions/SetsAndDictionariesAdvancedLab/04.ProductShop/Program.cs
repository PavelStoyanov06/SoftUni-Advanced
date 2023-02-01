var shops = new Dictionary<string, List<string>>();

string input = Console.ReadLine();

while (input != "Revision")
{
    string[] cmdArgs = input.Split(", ");
    string shop = cmdArgs[0];
    string product = cmdArgs[1];
    string price = double.Parse(cmdArgs[2]).ToString();

    if (shops.ContainsKey(shop))
    {
        shops[shop].Add($"Product: {product}, Price: {price}");
    }
    else
    {
        shops.Add(shop, new List<string>() { $"Product: {product}, Price: {price}" });
    }
    input = Console.ReadLine();
}

var ordered = shops.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

foreach (var shop in ordered)
{
    Console.WriteLine($"{shop.Key}->");
    foreach (var item in shop.Value)
    {
        Console.WriteLine(item);
    }
}