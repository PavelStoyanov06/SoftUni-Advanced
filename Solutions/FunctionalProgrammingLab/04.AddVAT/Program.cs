Func<double, double> addVAT = x => x += (20 / 100.0) * x;

double[] prices = Console.ReadLine()
    .Split(", ")
    .Select(double.Parse)
    .Select(addVAT)
    .ToArray();

Array.ForEach(prices, x => Console.WriteLine(x.ToString("0.00")));