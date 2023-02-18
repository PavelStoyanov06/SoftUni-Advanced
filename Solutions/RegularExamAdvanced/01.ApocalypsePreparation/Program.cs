Queue<int> textiles = new Queue<int>(Console.ReadLine()
    .Split(" ")
    .Select(int.Parse));
Stack<int> medicaments = new Stack<int>(Console.ReadLine()
    .Split(" ")
    .Select(int.Parse));

Dictionary<string, int> healingItems = new Dictionary<string, int>();

int excess = 0;

while(textiles.Count > 0 && medicaments.Count > 0)
{
    int sum = textiles.Peek() + medicaments.Peek();

    if(sum == 30)
    {
        textiles.Dequeue();
        medicaments.Pop();

        if (!healingItems.ContainsKey("Patch"))
        {
            healingItems.Add("Patch", 0);
        }

        healingItems["Patch"]++;
        excess = 0;
    }
    else if(sum == 40)
    {
        textiles.Dequeue();
        medicaments.Pop();

        if (!healingItems.ContainsKey("Bandage"))
        {
            healingItems.Add("Bandage", 0);
        }
        healingItems["Bandage"]++;

        excess = 0;
    }
    else if(sum >= 100)
    {
        textiles.Dequeue();
        medicaments.Pop();

        if (!healingItems.ContainsKey("MedKit"))
        {
            healingItems.Add("MedKit", 0);
        }
        healingItems["MedKit"]++;

        excess = sum - 100;
        if(medicaments.Count > 0)
        {
            medicaments.Push(medicaments.Pop() + excess);
        }
    }
    else
    {
        textiles.Dequeue();
        medicaments.Push(medicaments.Pop() + 10);
    }
}

if(textiles.Count == 0 && medicaments.Count == 0)
{
    Console.WriteLine("Textiles and medicaments are both empty.");
}
else if(textiles.Count == 0)
{
    Console.WriteLine("Textiles are empty.");
}
else if(medicaments.Count == 0)
{
    Console.WriteLine("Medicaments are empty.");
}

if(healingItems.Count > 0)
{
    healingItems = healingItems
        .OrderBy(x => x.Key)
        .OrderByDescending(x => x.Value)
        .ToDictionary(x => x.Key, x => x.Value);

    foreach (var item in healingItems)
    {
        Console.WriteLine($"{item.Key} - {item.Value}");
    }
}

if(medicaments.Count > 0)
{
    Console.WriteLine($"Medicaments left: {String.Join(", ", medicaments)}");
}
if(textiles.Count > 0)
{
    Console.WriteLine($"Textiles left: {String.Join(", ", textiles)}");
}