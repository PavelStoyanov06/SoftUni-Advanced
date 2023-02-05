Predicate<string> filterUppercase = x => x[0].ToString() != x[0].ToString().ToLower();

string[] words = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Where(x => filterUppercase(x))
    .ToArray();
Array.ForEach(words, (x) => Console.WriteLine(x));  