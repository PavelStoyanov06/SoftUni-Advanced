Stack<int> milligramsCaffein = new Stack<int>(Console.ReadLine()
    .Split(", ")
    .Select(int.Parse));

Queue<int> energyDrinks = new Queue<int>(Console.ReadLine()
    .Split(", ")
    .Select(int.Parse));

int availableCaffein = 300;

while(milligramsCaffein.Count > 0 && energyDrinks.Count > 0)
{
    int res = milligramsCaffein.Peek() * energyDrinks.Peek();

    if(availableCaffein >= res)
    {
        availableCaffein -= res;
        milligramsCaffein.Pop();
        energyDrinks.Dequeue();
    }
    else
    {
        milligramsCaffein.Pop();
        energyDrinks.Enqueue(energyDrinks.Dequeue());
        if(availableCaffein + 30 > 300)
        {
            continue;
        }
        availableCaffein += 30;
    }
}

if(energyDrinks.Count > 0)
{
    Console.WriteLine($"Drinks left: { String.Join(", ", energyDrinks) }");
}
else
{
    Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
}

Console.WriteLine($"Stamat is going to sleep with { 300 - availableCaffein } mg caffeine.");
