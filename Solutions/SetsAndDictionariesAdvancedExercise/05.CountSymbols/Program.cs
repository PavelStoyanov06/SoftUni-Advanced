string text = Console.ReadLine();

var symbols = new Dictionary<char, int>();

for (int i = 0; i < text.Length; i++)
{
    if (symbols.ContainsKey(text[i]))
    {
        symbols[text[i]]++;
    }
    else
    {
        symbols.Add(text[i], 1);
    }
}

symbols = symbols.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

foreach (var symbol in symbols)
{
    Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
}